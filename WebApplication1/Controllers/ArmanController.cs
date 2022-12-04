using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ArmanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}