using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication4.Models;

namespace WebApplication4.Servicios
{
    public class ProductosServicio
    {
        private EF_AppContext _contexto;
        public ProductosServicio()
        {

            _contexto = new EF_AppContext();
        }

        public IList<Producto> Obtener(int idUsuario, string nombre)
        {
            //return (from p in _contexto.Productos
            //        where p.Nombre.StartsWith(nombre)
            //        && p.IdUsuario == idUsuario
            //        select p).ToList();

            return _contexto.Productos.Where(p => p.Nombre.StartsWith(nombre)).ToList();
        }
    }
}
