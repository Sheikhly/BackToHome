using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ParsaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}