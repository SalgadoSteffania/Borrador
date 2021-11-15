using Domain.Entities.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
   public  class Factura
    {
        public int Id { get; set; }
        public int TotalProductos;
        public ProductoDgv [] Productos { get; set; }
       
        
    }
}
