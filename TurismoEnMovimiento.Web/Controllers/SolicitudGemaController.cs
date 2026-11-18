using Microsoft.AspNetCore.Mvc;
using TurismoEnMovimiento.Class;
using TurismoEnMovimiento.Class.Models;
using TurismoEnMovimiento.Web.ViewModel;

namespace TurismoEnMovimiento.Web.Controllers
{
    public class SolicitudGemaController : Controller
    {
        private readonly ISolicitudGemaRepository _repository;

        // Constructor: recibe el repositorio
        public SolicitudGemaController(ISolicitudGemaRepository repository)
        {
            _repository = repository;
        }



        // POST: SolicitudGema/Registrar
        [HttpPost("/Gema")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registrar(SolicitudGemaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/Gema/Index.cshtml", model);
            }

            var solicitud = new SolicitudGemaModel
            {
                Nombre = model.Nombre,
                Direccion = model.Direccion,
                Correo = model.Correo,
                Celular = model.Celular,
                Profesion = model.Profesion,
                Edad = (int)model.Edad,
                FechaRegistro = DateTime.Now
            };

            await _repository.AddAsync(solicitud);

            TempData["Mensaje"] = "¡Tu solicitud se ha registrado correctamente!";

            return Redirect("/Gema");
        }
    }
} 