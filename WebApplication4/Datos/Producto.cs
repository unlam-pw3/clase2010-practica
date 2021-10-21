using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication4
{
    public partial class Producto
    {
        public Producto()
        {
            VentasProductos = new HashSet<VentasProducto>();
        }

        public int IdProducto { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<VentasProducto> VentasProductos { get; set; }
    }
}
