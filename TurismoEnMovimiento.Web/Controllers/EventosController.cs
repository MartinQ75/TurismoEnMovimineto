using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TurismoEnMovimiento.Web.Controllers
{
    public class EventosController : Controller
    {
        public IActionResult GranAbrazo()
        {
            return View();
        }

        public IActionResult Papalotes()
        {
            return View();
        }

        public IActionResult Globos()
        {
            return View();
        }
    }
}
