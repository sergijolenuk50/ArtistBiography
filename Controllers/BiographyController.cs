using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BiographyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReligiousCompositions()
        {
            return View();
        }
        public IActionResult Portrait()
        {
            return View();
        }

       
        public IActionResult SelectedWorks()
        {
            return View();
        }
    }
}
