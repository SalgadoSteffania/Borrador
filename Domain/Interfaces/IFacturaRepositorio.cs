using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IFacturaRepositorio : IModel<Factura>
    {
        Factura FindAny(Predicate<Factura> predicate);
        ICollection<Factura> FindAll(Predicate<Factura> predicate);
    }
}
