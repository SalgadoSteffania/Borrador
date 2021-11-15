using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Productos
{
   public class ProductoDgv
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Descuento { get; set; }
        public decimal IVA{ get; set; }
        public decimal Ingresos_Totales { get; set; }

        public decimal IngresosNeto => (Ingresos_Totales + IVA) - Descuento;

        public string CodigoProducto { get; set; }





    }
}
