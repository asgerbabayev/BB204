using BB204_Nest_Web_App.DAL;
using BB204_Nest_Web_App.Models;
using BB204_Nest_Web_App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BB204_Nest_Web_App.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.
                Include(x => x.Category).
                Include(x => x.ProductImages).
                Take(5).ToListAsync());
        }
        public async Task<IActionResult> LoadProduct(int skip)
        {
            return PartialView("_ProductPartial", await _context.Products.
                Include(x => x.Category).
                Include(x => x.ProductImages).Skip(skip).Take(5).ToListAsync());
        }

        public IActionResult Shop(int page = 1, int take = 5)
        {
            var products = _context.Products
                .Where(x => x.IsDeleted == false)
                .Skip((page - 1) * take)
                .Take(take)
                .Include(x => x.Category)
                .Include(x => x.ProductImages)
                .ToList();
            PaginateVM<Product> paginateVM = new PaginateVM<Product>()
            {
                Items = products,
                CurrentPage = page,
                PageCount = GetPageCount(take)
            };
            return View(paginateVM);
        }

        private int GetPageCount(int take)
        {
            var productCount = _context.Products.Where(x => x.IsDeleted == false).Count();
            return (int)Math.Ceiling(((decimal)productCount / take));
        }
    }
}
