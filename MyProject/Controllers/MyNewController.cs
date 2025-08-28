using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class MyNewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
