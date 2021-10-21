using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication4
{
    public partial class VentasProducto
    {
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Venta IdVentaNavigation { get; set; }
    }
}
