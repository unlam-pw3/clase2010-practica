using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication4
{
    public partial class Venta
    {
        public Venta()
        {
            VentasProductos = new HashSet<VentasProducto>();
        }

        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public decimal Monto { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<VentasProducto> VentasProductos { get; set; }
    }
}
