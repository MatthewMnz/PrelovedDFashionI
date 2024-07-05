using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrelovedDFashion.Modelos
{
    public class Ropa : Producto
    {
        public string Talla { get; set; }

        public Ropa(int id, string nombre, decimal precio, int cantidad, string sexo, string talla)
            : base(id, nombre, precio, cantidad, sexo)
        {
            Talla = talla;
        }

        public override string MostrarInfo()
        {
            return $"{Nombre} - {Talla} - {Precio} C$";
        }
    }
}
