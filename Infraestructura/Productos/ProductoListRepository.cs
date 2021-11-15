using Domain.Entities.Productos;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructura.Productos
{
    public class ProductoListRepository : BaseRepository<Producto>, IProductoRepository
    {
        public bool Delete(Producto t)
        {
           
                if (t is null)
                {
                    throw new ArgumentNullException(nameof(t));
                }
                if (datos.Count == 0)
                {
                    throw new ArgumentException("No hay Productosr");
                }
                return datos.Remove(t);
            }

        public ICollection<Producto> FindAll(int tipo)
        {
            throw new NotImplementedException();
        }

        public Producto GetEmpleadoById(int id)
        {
            throw new NotImplementedException();
        }

        public Producto GetEmpleadoById(ICollection<Producto> productos, int id)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoById(ICollection<Producto> productos, int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"El id {id} es invalido");
            }
            if (Producto.Count == 0)
            {
                throw new ArgumentException("No hay empleados");
            }
            return productos.ToList().Find(p => p.Id == id);
        }


        public Producto GetProductoById(int id)
        {
            throw new NotImplementedException();
        }

        public ProductoDgv GetResumenEmpleado(int id, int mes)
        {
            throw new NotImplementedException();
        }

        public ProductoDgv[] GetResumenEmpleados(int mes)
        {
            throw new NotImplementedException();
        }

        public ProductoDgv GetResumenProducto(int id)
        {
           
                if (FindAll(3).Count == 0)
                {
                    return null;
                }
                ProductoDgv[] productosDgv = new ProductoDgv[FindAll(3).Count];
                int i = 0;
                foreach ( Producto e in FindAll(3))
                {
                    productosDgv[i] = GetResumenProducto(e.Id);
                    i++;
                }
                return productosDgv;
         }

      


        public int Update(Producto t, int i)
        {
            if (t is null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            if (i == 1)
            {
                if (datos.Count == 0)
                {
                    throw new ArgumentException("No hay productos");
                }
                int index = datos.FindIndex(p => p.Id == t.Id);
                if (index < 0)
                {
                    throw new ArgumentException($"El producto con Id {t.Id} no se encuentra");
                }
                datos[index] = t;
                return index;
            }
            return 0;
        }

    }




}
   

      
