using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Servicios;

namespace WebApplication4.Controllers
{
    public class UsuariosController : Controller
    {
        private UsuarioServicio _servicio = new UsuarioServicio();

        public IActionResult Registrar()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Usuario usuario)
        {
            if (ModelState.IsValid) {

                if (!_servicio.ExisteElUsuario(usuario)) {

                    _servicio.Registrar(usuario);

                    TempData["Mensaje"] = "Gracias por registrarte!!";
                    return RedirectToAction("Login", "Home");
                }

                ModelState.AddModelError("", "Usuario duplicado");
            }

            return View(usuario);
        }
    }
}
