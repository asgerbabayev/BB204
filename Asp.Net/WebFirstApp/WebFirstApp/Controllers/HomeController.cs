

namespace WebFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            #region ViewBag,ViewData,TempData
            //ViewBag.Aslan = "Aslan";
            //ViewData["Elvin"] = "Elvin";
            //TempData["Nergiz"] = "Nergiz"; 
            //return RedirectToAction("Contact");
            #endregion
            List<Student> students = new List<Student>()
            {
                new Student{Id = 1, Name ="Jale", Surname = "Ekberova", Age= 20},
                new Student{Id = 2, Name ="Aslan", Surname = "Qeribov", Age= 19},
                new Student{Id = 3, Name ="Elvin", Surname = "Qasimov", Age= 18},
            };
            List<Group> groups = new List<Group>()
            {
                new Group{Id = 1, Name ="BB204"},
                new Group{Id = 2, Name ="RNET101"},
                new Group{Id = 3, Name ="RNET102"},
            };
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            HomeViewModel model = new HomeViewModel()
            {
                Students = students,
                Groups = groups,
                Numbers = numbers
            };


            return View(model);
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
