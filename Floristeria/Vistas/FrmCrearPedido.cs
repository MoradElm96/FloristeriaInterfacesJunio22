using Floristeria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floristeria.Vistas
{
    public partial class FrmCrearPedido : Form
    {
        public FrmCrearPedido()
        {
            InitializeComponent();
        }

        List<Flor> listaFlores = new List<Flor>();
        private void FrmCrearPedido_Load(object sender, EventArgs e)
        {
            listaFlores = Controladores.ControladorFlores.recuperarFloresEnLista();

            cmbFlores.DataSource = listaFlores;
            cmbFlores.DisplayMember = "nombre";
            cmbFlores.ValueMember = "codigo";


        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {

            int codFlor = cmbFlores.SelectedIndex;

          
             int codigo_cliente = Convert.ToInt32(numCliente.Value);
            DateTime fecha = monthCalendar1.SelectionStart;
            int cantidad = Convert.ToInt32(numCantidad.Value);
             string foto = pcbFotoFlor.Name;


            if (cmbFlores.SelectedIndex > 0 && numCantidad.Value>0 && monthCalendar1!=null )
            {
                if (Controladores.ControladorPedidos.guardarPedidos(codFlor,Convert.ToInt32(codigo_cliente),fecha,cantidad)  ){

                    MessageBox.Show("pedido guardado");
                }
                else
                {
                    MessageBox.Show("no se ha podido guardar");
                }


            }
            else
            {
                MessageBox.Show("revisa los campos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
