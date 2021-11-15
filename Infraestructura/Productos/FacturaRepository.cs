using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Productos
{
    public class FacturaRepository : BaseRepository<Factura>, IFacturaRepositorio
    {
        public ICollection<Factura> FindAll(Predicate<Factura> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            return datos.FindAll(predicate);
        }

        public Factura FindAny(Predicate<Factura> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            return datos.Find(predicate);
        }
    }

   
}
