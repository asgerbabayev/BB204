using BB204_Nest_Web_App.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BB204_Nest_Web_App.Areas.NestAdmin.Controllers
{
    [Area("NestAdmin")]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;
        public CategoriesController(AppDbContext context)
        => _context = context;


        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.Where(x => x.IsDeleted == false).ToListAsync());
        }
        public IActionResult Detail(int id)
        {
            return Json(new
            {
                Id = id
            });
        }
    }
}
