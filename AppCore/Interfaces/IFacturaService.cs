using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IFacturaService : IService<Factura>
    {
        Factura FindAny(Predicate<Factura> predicate);
        ICollection<Factura> FindAll(Predicate<Factura> predicate);
    }
}
