
namespace Floristeria.Vistas
{
    partial class FrmPedidos
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
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalcularIVa = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPedidos
            // 
            this.dtgPedidos.AllowUserToDeleteRows = false;
            this.dtgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Location = new System.Drawing.Point(64, 98);
            this.dtgPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.RowHeadersWidth = 51;
            this.dtgPedidos.RowTemplate.Height = 24;
            this.dtgPedidos.Size = new System.Drawing.Size(516, 212);
            this.dtgPedidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIDOS";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(64, 328);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(162, 38);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR CAMBIOS";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCalcularIVa
            // 
            this.btnCalcularIVa.Location = new System.Drawing.Point(421, 328);
            this.btnCalcularIVa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcularIVa.Name = "btnCalcularIVa";
            this.btnCalcularIVa.Size = new System.Drawing.Size(162, 38);
            this.btnCalcularIVa.TabIndex = 3;
            this.btnCalcularIVa.Text = "Calcular IVA";
            this.btnCalcularIVa.UseVisualStyleBackColor = true;
            this.btnCalcularIVa.Click += new System.EventHandler(this.btnCalcularIVa_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(242, 328);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(162, 38);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 408);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnCalcularIVa);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgPedidos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPedidos";
            this.Text = "FrmPedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCalcularIVa;
        private System.Windows.Forms.Button btnExportar;
    }
}