using Microsoft.AspNetCore.Mvc;

namespace BookStorevn.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
