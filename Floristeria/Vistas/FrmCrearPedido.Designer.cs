
namespace Floristeria.Vistas
{
    partial class FrmCrearPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFlor = new System.Windows.Forms.Label();
            this.cmbFlores = new System.Windows.Forms.ComboBox();
            this.pcbFotoFlor = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.numCliente = new System.Windows.Forms.NumericUpDown();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoFlor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFlor
            // 
            this.lblFlor.AutoSize = true;
            this.lblFlor.Location = new System.Drawing.Point(72, 49);
            this.lblFlor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFlor.Name = "lblFlor";
            this.lblFlor.Size = new System.Drawing.Size(27, 13);
            this.lblFlor.TabIndex = 0;
            this.lblFlor.Text = "Flor:";
            // 
            // cmbFlores
            // 
            this.cmbFlores.FormattingEnabled = true;
            this.cmbFlores.Location = new System.Drawing.Point(104, 49);
            this.cmbFlores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFlores.Name = "cmbFlores";
            this.cmbFlores.Size = new System.Drawing.Size(130, 21);
            this.cmbFlores.TabIndex = 1;
            // 
            // pcbFotoFlor
            // 
            this.pcbFotoFlor.Location = new System.Drawing.Point(303, 38);
            this.pcbFotoFlor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbFotoFlor.Name = "pcbFotoFlor";
            this.pcbFotoFlor.Size = new System.Drawing.Size(214, 132);
            this.pcbFotoFlor.TabIndex = 2;
            this.pcbFotoFlor.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(74, 195);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(72, 369);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(70, 428);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.Location = new System.Drawing.Point(160, 492);
            this.btnRealizarPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(125, 33);
            this.btnRealizarPedido.TabIndex = 6;
            this.btnRealizarPedido.Text = "REALIZAR PEDIDO";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(392, 492);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 33);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(133, 195);
            this.monthCalendar1.MinDate = new System.DateTime(2022, 6, 16, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // numCliente
            // 
            this.numCliente.Location = new System.Drawing.Point(137, 369);
            this.numCliente.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numCliente.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCliente.Name = "numCliente";
            this.numCliente.Size = new System.Drawing.Size(120, 20);
            this.numCliente.TabIndex = 11;
            this.numCliente.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(137, 421);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 12;
            // 
            // FrmCrearPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 567);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.numCliente);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRealizarPedido);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pcbFotoFlor);
            this.Controls.Add(this.cmbFlores);
            this.Controls.Add(this.lblFlor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCrearPedido";
            this.Text = "FrmCrearPedido";
            this.Load += new System.EventHandler(this.FrmCrearPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoFlor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlor;
        private System.Windows.Forms.ComboBox cmbFlores;
        private System.Windows.Forms.PictureBox pcbFotoFlor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown numCliente;
        private System.Windows.Forms.NumericUpDown numCantidad;
    }
}