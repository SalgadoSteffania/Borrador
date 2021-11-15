using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Productos;
using Domain.Enums;
using Domain.Interfaces;

namespace AppCore.Interfaces
{
    public interface IEmpleadoService : IService<Producto>
    {
       Producto GetEmpleadoById(int id);
        ProductosDgv GetResumenProductos(int id);
      
        
        int Update(Producto t, int i);
        bool Delete(Producto t);
      
        ICollection<Producto> FindAll(int tipo);
      Producto GetProductoById(ICollection<Producto> productos, int id);
        
    }


}
