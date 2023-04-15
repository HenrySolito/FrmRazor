using Microsoft.AspNetCore.Mvc;

namespace FrmRazor.Controllers
{
    public class Index1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
