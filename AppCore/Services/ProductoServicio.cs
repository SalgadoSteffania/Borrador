using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class ProductoServicio : BaseService<Producto>, IProductoServicio
    {
        private IProductoRepositorio productoRepositorio;

        public ProductoServicio(IProductoRepositorio productoRepositorio) : base(productoRepositorio)
        {
            this.productoRepositorio = productoRepositorio;
        }

        public Producto GetProductoById(int id)
        {
            return productoRepositorio.GetProductooById(id);
        }

        public int Update(Producto t, int i)
        {
            return productoRepositorio.Update(t, i);
        }


        public bool Delete(Producto t)
        {
            return productoRepositorio.Delete(t);
        }

        public Producto EmpleadoDgv GetResumenProducto(int id)
        {
            return productoRepositorio.GetResumenEmpleado(id);
        }

      
        public ICollection<Producto> FindAll(int tipo)
        {
            return productoRepositorio.FindAll(tipo);
        }

        public Producto GetProductoById(ICollection<Producto> productos, int id)
        {
            return productoRepositorio.GetEmpleadoById(productos, id);
        }

        
    }
}
