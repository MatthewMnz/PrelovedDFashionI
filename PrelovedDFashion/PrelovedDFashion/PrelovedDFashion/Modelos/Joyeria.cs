using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrelovedDFashion.Modelos
{
    public class Joyeria : Producto
    {
        public string Material { get; set; }

        public Joyeria(int id, string nombre, decimal precio, int cantidad, string sexo, string material)
            : base(id, nombre, precio, cantidad, sexo)
        {
            Material = material;
        }

        public override string MostrarInfo()
        {
            return $"{Nombre} - {Material} - {Precio} C$";
        }
    }
}
