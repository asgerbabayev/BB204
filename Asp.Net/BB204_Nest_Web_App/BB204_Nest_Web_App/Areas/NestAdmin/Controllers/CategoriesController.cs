using BB204_Nest_Web_App.DAL;
using BB204_Nest_Web_App.Models;
using BB204_Nest_Web_App.Utilities.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BB204_Nest_Web_App.Areas.NestAdmin.Controllers
{
    [Area("NestAdmin")]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public CategoriesController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.Where(x => x.IsDeleted == false).ToListAsync());
        }
        public async Task<IActionResult> Detail(int id)
        {
            return View(await _context.Categories.FirstOrDefaultAsync(x => x.Id == id));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid) return View();
            if (!category.PhotoFile.CheckFileType("image"))
            {
                ModelState.AddModelError("PhotoFile", "File must be image format");
                return View();
            }
            if (category.PhotoFile.CheckFileSize(200))
            {
                ModelState.AddModelError("PhotoFile", "File must be less than 200kb");
                return View();
            }
            category.Photo = await category.PhotoFile.SaveFileAsync(_environment.WebRootPath, "shop");

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _context.Categories.FirstOrDefaultAsync(x => x.Id == id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            Category? exists = await _context.Categories.FirstOrDefaultAsync(x => x.Id == category.Id);
            if (exists == null)
            {
                ModelState.AddModelError("", "Category is null");
                return View();
            }
            exists.Name = category.Name;
            exists.Logo = category.Logo;
            exists.Photo = category.Photo;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            Category? exists = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (exists == null)
            {
                ModelState.AddModelError("", "Category is null");
                return View();
            }
            //_context.Categories.Remove(exists);
            exists.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
