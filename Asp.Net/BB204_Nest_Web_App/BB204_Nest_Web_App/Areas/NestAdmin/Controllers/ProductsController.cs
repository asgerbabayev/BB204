using BB204_Nest_Web_App.DAL;
using BB204_Nest_Web_App.Models;
using BB204_Nest_Web_App.Utilities.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BB204_Nest_Web_App.Areas.NestAdmin.Controllers
{
    [Area("NestAdmin")]
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ProductsController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Products
                .Include(x => x.Category)
                .Include(x => x.ProductImages)
                .Where(x => x.IsDeleted == false)
                .OrderByDescending(p => p.Id)
                .Take(10).ToListAsync());
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            ViewBag.Categories = _context.Categories.ToList();
            if (!ModelState.IsValid) return View();

            if (_context.Products.Any(p => p.Name.Trim().ToLower().Contains(product.Name.ToLower().Trim())))
            {
                ModelState.AddModelError("Name", "Product name already exist");
                return View();
            }

            if (product.Discount != null)
            {
                if (product.Discount > product.SellPrice)
                {
                    ModelState.AddModelError("Discount", "Discount price can't be less sell price");
                    return View();
                }
            }
            else
                product.Discount = product.SellPrice;

            if (!CheckFile(product.PhotoBack, 2000, out string messageBack))
            {
                ModelState.AddModelError("PhotoBack", messageBack);
                return View();
            }

            _context.ProductImages.Add(new ProductImage
            {
                Image = await product.PhotoBack.SaveFileAsync(_env.WebRootPath, "shop"),
                IsBack = true,
                IsFront = false,
                Product = product
            });

            if (!CheckFile(product.PhotoFront, 2000, out string messageFront))
            {
                ModelState.AddModelError("PhotoFront", messageFront);
                return View();
            }

            _context.ProductImages.Add(new ProductImage
            {
                Image = await product.PhotoFront.SaveFileAsync(_env.WebRootPath, "shop"),
                IsBack = false,
                IsFront = true,
                Product = product
            });

            foreach (IFormFile file in product.Files)
            {
                if (!CheckFile(file, 2000, out string messageFiles))
                {
                    ModelState.AddModelError("Files", messageFiles);
                    return View();
                }

                _context.ProductImages.Add(new ProductImage
                {
                    Image = await file.SaveFileAsync(_env.WebRootPath, "shop"),
                    IsBack = false,
                    IsFront = false,
                    Product = product
                });
            }
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            return View(await _context.Products
                .Include(c => c.Category)
                .Include(pi => pi.ProductImages).FirstOrDefaultAsync(p => p.Id == id));
        }

        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            return View(await _context.Products.
                Include(c => c.Category).
                Include(pi => pi.ProductImages)
                .FirstOrDefaultAsync(x => x.Id == id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            ViewBag.Categories = _context.Categories.ToList();
            if (!ModelState.IsValid) return View(product);

            Product? exist = await _context.Products.
                Include(c => c.Category).
                Include(pi => pi.ProductImages)
                .FirstOrDefaultAsync(x => x.Id == product.Id);

            if (product.Discount != null)
            {
                if (product.Discount > product.SellPrice)
                {
                    ModelState.AddModelError("Discount", "Discount price can't be less sell price");
                    return View();
                }
            }
            else
                product.Discount = product.SellPrice;

            if (product.PhotoBack != null)
            {
                if (!CheckFile(product.PhotoBack, 2000, out string messageBack))
                {
                    ModelState.AddModelError("PhotoBack", messageBack);
                    return View();
                }

                _context.ProductImages.Add(new ProductImage
                {
                    Image = await product.PhotoBack.SaveFileAsync(_env.WebRootPath, "shop"),
                    IsBack = true,
                    IsFront = false,
                    Product = product
                });
                product.PhotoBack.DeleteFile(_env.WebRootPath, "shop", exist.ProductImages.FirstOrDefault(x => x.IsBack == true).Image);

            }
            if (product.PhotoFront != null)
            {
                if (!CheckFile(product.PhotoFront, 2000, out string messageFront))
                {
                    ModelState.AddModelError("PhotoFront", messageFront);
                    return View();
                }

                _context.ProductImages.Add(new ProductImage
                {
                    Image = await product.PhotoFront.SaveFileAsync(_env.WebRootPath, "shop"),
                    IsBack = false,
                    IsFront = true,
                    Product = product
                });
                product.PhotoBack.DeleteFile(_env.WebRootPath, "shop", exist.ProductImages.FirstOrDefault(x => x.IsFront == true).Image);
            }
            if (product.Files != null)
            {
                foreach (IFormFile file in product.Files)
                {
                    if (!CheckFile(file, 2000, out string messageFiles))
                    {
                        ModelState.AddModelError("Files", messageFiles);
                        return View();
                    }

                    _context.ProductImages.Add(new ProductImage
                    {
                        Image = await file.SaveFileAsync(_env.WebRootPath, "shop"),
                        IsBack = false,
                        IsFront = false,
                        Product = product
                    });
                }
            }
            exist.Name = product.Name;
            exist.SellPrice = product.SellPrice;
            exist.CostPrice = product.CostPrice;
            exist.CategoryId = product.CategoryId;
            exist.Discount = product.Discount;
            exist.StockCount = product.StockCount;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteImage(int id)
        {
            ProductImage productImage = await _context.ProductImages.FirstOrDefaultAsync(x => x.Id == id);
            productImage.File.DeleteFile(_env.WebRootPath, "shop", productImage.Image);
            _context.ProductImages.Remove(productImage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CheckFile(IFormFile file, int size, out string message)
        {
            message = string.Empty;
            if (!file.CheckFileType("image"))
            {
                message = "File must be image type";
                return false;
            }
            if (file.CheckFileSize(size))
            {
                message = $"Image type must be lesst than {size}";
                return false;
            }
            return true;
        }

    }
}
