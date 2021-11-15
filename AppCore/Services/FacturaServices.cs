using AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class FacturaService : BaseService<Factura>, IFacturaService
    {
        private IFacturaRepositorio facturaRepositorio;

        public FacturaService(IFacturaRepositorio facturaRepositorio) : base(facturaRepositorio)
        {
            this.facturaRepositorio = facturaRepositorio;
        }

        public ICollection<Factura> FindAll(Predicate<Factura> predicate)
        {
            return facturaRepositorio.FindAll(predicate);
        }

        public Factura  FindAny(Predicate<Factura> predicate)
        {
            return facturaRepositorio.FindAny(predicate);
        }
    }
}
