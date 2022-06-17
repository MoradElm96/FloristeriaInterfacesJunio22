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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void floresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFlores frmFlores = new FrmFlores();
            frmFlores.MdiParent = this;
            frmFlores.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearPedido frmCrearPedido = new FrmCrearPedido();
            frmCrearPedido.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.Show();
        }
    }
}
