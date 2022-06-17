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
    public partial class FrmFlores : Form
    {
        public FrmFlores()
        {
            InitializeComponent();
        }

        DataSet dataSet = new DataSet();
        private void btnCargar_Click(object sender, EventArgs e)
        {
            dataSet = Controladores.ControladorFlores.recuperarFloresDataSet();

            dtgFlores.Refresh();
            dtgFlores.DataSource = dataSet.Tables[0];




        }

        List<Flor> listaFlores = new List<Flor>();

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            List<Flor> listaFlores = Controladores.ControladorFlores.recuperarFloresEnLista();


            listaFlores.Sort((a,b)=> a.codigo_color -b.codigo_color);


            if (listaFlores.Count > 0) { 
            dtgFlores.Refresh();
            dtgFlores.DataSource = listaFlores;
            }
            else
            {
                MessageBox.Show("No hay flores");
            }
            //List<Flor> listaColor = listaFlores.FindAll((color)=> color.codigo_color.Contains("") )

        }

        private void FrmFlores_Load(object sender, EventArgs e)
        {
            listaFlores = Controladores.ControladorFlores.recuperarFloresEnLista();

            cmbColores.DataSource = listaFlores;
            cmbColores.DisplayMember = "codigo_color";
            cmbColores.ValueMember = "codigo_color";

            //PARA EL CONTROL PERSONALIZADO
            controlUsuario11.cmbColores.DataSource = listaFlores;
            controlUsuario11.cmbColores.DisplayMember = "codigo_color";
            controlUsuario11.cmbColores.ValueMember = "codigo_color";

        

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            


            listaFlores = Controladores.ControladorFlores.recuperarFloresEnLista();

            listaFlores.FindAll((color)=> color.codigo_color == Convert.ToInt32( cmbColores.SelectedValue.ToString()));

           
           
             
            dtgFlores.Refresh();
            dtgFlores.DataSource = listaFlores;

           

        }

        private void controlUsuario11_Load(object sender, EventArgs e)
        {

           

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
