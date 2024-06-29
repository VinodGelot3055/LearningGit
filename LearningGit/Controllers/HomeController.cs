using Microsoft.AspNetCore.Mvc;

namespace LearningGit.Controllers
{
    public class HomeController : Controller
    {
        //this is for single file reset.
        public IActionResult Index()
        {
            return View();
        }
    }
}
