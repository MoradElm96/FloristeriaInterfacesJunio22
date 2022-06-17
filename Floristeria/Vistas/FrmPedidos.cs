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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        DataSet dataSet = new DataSet();
        private void FrmPedidos_Load(object sender, EventArgs e)
        {

            dataSet = Controladores.ControladorPedidos.recuperarPedidosDataSet();
            dtgPedidos.DataSource = dataSet.Tables[0];

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Controladores.ControladorPedidos.guardarPedidosDeDataSet(this.dataSet))
            {
                
                MessageBox.Show("datos actualizados en la base de datos");
                cargarDatos();

            }
            else
            {
                MessageBox.Show(" no se ha podido guardar cambios");
            }
        }

        public void cargarDatos()
        {
            dataSet = Controladores.ControladorPedidos.recuperarPedidosDataSet();
            dtgPedidos.Refresh();
            dtgPedidos.DataSource = dataSet.Tables[0];

            

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

            List<Pedido> listPed = new List<Pedido>();

              listPed =   Controladores.ControladorPedidos.recuperarPedidosEnLista();

           



            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Title = "guardar pedidos en  xml";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.Filter = "Xml files (*.xml) | *.xml";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if(saveFileDialog.ShowDialog()== DialogResult.OK)
            {
                string nombreArchivo = saveFileDialog.FileName; //ruta

Controladores.ControladorPedidos.guardarPedidosEnXml(listPed, nombreArchivo);//recibe lista y ruta
                MessageBox.Show("fichero exportado");
            }
            else
            {
                MessageBox.Show("no se pudo exportar");
            }

            


        }

        private void btnCalcularIVa_Click(object sender, EventArgs e)
        {

        }


        /*
        public double calcularIVA(double precio,int cantidad)
        {


        }
        */



    }
}
