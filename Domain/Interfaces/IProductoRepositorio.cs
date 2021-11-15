using Domain.Entities.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IProductoRepository : IModel<Producto>
    {
     Producto GetEmpleadoById(int id);
        ProductoDgv GetResumenEmpleado(int id, int mes);
        ProductoDgv[] GetResumenEmpleados(int mes);
        
        int Update(Producto t, int i);
        bool Delete(Producto t);
      
        ICollection<Producto> FindAll(int tipo);
        Producto GetEmpleadoById(ICollection<Producto> productos, int id);
        
    }
}
