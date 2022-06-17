
namespace Floristeria.Vistas
{
    partial class FrmFlores
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
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtgFlores = new System.Windows.Forms.DataGridView();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.controlUsuario11 = new Floristeria.ControlUsuario1();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFlores)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbColores.Location = new System.Drawing.Point(211, 77);
            this.cmbColores.Margin = new System.Windows.Forms.Padding(2);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(143, 21);
            this.cmbColores.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(370, 72);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(194, 28);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "FILTRAR POR COLORES";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtgFlores
            // 
            this.dtgFlores.AllowUserToAddRows = false;
            this.dtgFlores.AllowUserToDeleteRows = false;
            this.dtgFlores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFlores.Location = new System.Drawing.Point(97, 110);
            this.dtgFlores.Margin = new System.Windows.Forms.Padding(2);
            this.dtgFlores.Name = "dtgFlores";
            this.dtgFlores.ReadOnly = true;
            this.dtgFlores.RowHeadersWidth = 51;
            this.dtgFlores.RowTemplate.Height = 24;
            this.dtgFlores.Size = new System.Drawing.Size(581, 212);
            this.dtgFlores.TabIndex = 2;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(302, 353);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(172, 28);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "ORDENAR POR COLORES";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(513, 353);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(97, 353);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(172, 28);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "CARGAR FLORES";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // controlUsuario11
            // 
            this.controlUsuario11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.controlUsuario11.Location = new System.Drawing.Point(211, 8);
            this.controlUsuario11.Name = "controlUsuario11";
            this.controlUsuario11.Size = new System.Drawing.Size(372, 59);
            this.controlUsuario11.TabIndex = 7;
            this.controlUsuario11.Load += new System.EventHandler(this.controlUsuario11_Load);
            // 
            // FrmFlores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 473);
            this.Controls.Add(this.controlUsuario11);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.dtgFlores);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbColores);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFlores";
            this.Text = "FrmFlores";
            this.Load += new System.EventHandler(this.FrmFlores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFlores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dtgFlores;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCargar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ControlUsuario1 controlUsuario11;
    }
}