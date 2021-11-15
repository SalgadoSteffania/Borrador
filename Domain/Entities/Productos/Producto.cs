using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Productos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre {get; set;}
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
        public string CodigoProducto { get; set; }
        public static int Count { get; set; }

        public Producto (string nombre,int id,string descripcion,decimal precio, int cantidad, DateTime fechaAdquisicion, DateTime fechaVencimiento,
            UnidadMedida unidadMedida, string codigoProducto)
        {
            Nombre = nombre;
            Id = id;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
            FechaAdquisicion = fechaAdquisicion;
            FechaVencimiento = fechaVencimiento;
            UnidadMedida = unidadMedida;
            CodigoProducto = codigoProducto;

        }

    }
}
