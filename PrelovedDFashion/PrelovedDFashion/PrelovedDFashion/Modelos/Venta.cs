using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrelovedDFashion.Modelos
{
    public class Venta
    {
        public int Id { get; set; }
        public Producto ProductoVendido { get; set; }
        public int CantidadVendida { get; set; }
        public DateTime FechaVenta { get; set; }

        public Venta(int id, Producto producto, int cantidadVendida, DateTime fechaVenta)
        {
            Id = id;
            ProductoVendido = producto;
            CantidadVendida = cantidadVendida;
            FechaVenta = fechaVenta;
        }

        public decimal CalcularTotal()
        {
            return ProductoVendido.Precio * CantidadVendida;
        }

        public string MostrarVenta()
        {
            return $"{FechaVenta.ToShortDateString()} - {ProductoVendido.Nombre} - Cantidad: {CantidadVendida} - Total: {CalcularTotal()} C$";
        }
    }
}
