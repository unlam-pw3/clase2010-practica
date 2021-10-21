using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nuevo()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Producto producto)
        {

            return View();
        }


        [HttpPost]
        public IActionResult Buscar(string nombre)
        {

            return View();
        }
    }
}
