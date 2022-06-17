using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floristeria.Clases
{
    /// <summary>
    /// clase flor
    /// </summary>
  public  class Flor
    {
        public int codigo { get; set;}
        public string nombre { get; set; }
        public string foto { get; set; }
        public double precio { get; set; }
        public int codigo_color { get; set; }
        public string estacion { get; set; }

        public Flor(int codigo, string nombre, string foto, double precio, int codigo_color, string estacion)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.foto = foto;
            this.precio = precio;
            this.codigo_color = codigo_color;
            this.estacion = estacion;
        }

       




    }
}
