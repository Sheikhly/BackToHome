using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MohamadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
