using Microsoft.AspNetCore.Mvc;

namespace project_SWD.Controllers
{
    public class categoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
