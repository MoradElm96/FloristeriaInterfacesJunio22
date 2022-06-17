using Floristeria.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floristeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string textoCaja = txtClave.Text;

            //SE TIENE QUE ESCRIBIR EN MAYUSCULA
            if (textoCaja.Equals("ADELANTE")){

                
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.Show();
                this.Close();

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
