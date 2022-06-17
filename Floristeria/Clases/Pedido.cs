using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floristeria.Clases
{
   public  class Pedido
    {
        public int codigo_pedido { set; get; }
        public int codigo_flor { set; get; }
        public int codigo_cliente { set; get; }
        DateTime fecha { set; get; }
        public int cantidad { set; get; }

        public Pedido(int codigo_pedido, int codigo_flor, int codigo_cliente, DateTime fecha, int cantidad)
        {
            this.codigo_pedido = codigo_pedido;
            this.codigo_flor = codigo_flor;
            this.codigo_cliente = codigo_cliente;
            this.fecha = fecha;
            this.cantidad = cantidad;
        }

        public Pedido(int codigo_flor, int codigo_cliente, DateTime fecha, int cantidad)
        {
            
            this.codigo_flor = codigo_flor;
            this.codigo_cliente = codigo_cliente;
            this.fecha = fecha;
            this.cantidad = cantidad;
        }



        public Pedido()
        {
        }



       
    }
}
