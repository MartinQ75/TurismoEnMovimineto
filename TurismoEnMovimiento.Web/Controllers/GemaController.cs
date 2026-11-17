using Microsoft.AspNetCore.Mvc;

namespace TurismoEnMovimiento.Web.Controllers
{
    public class GemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
