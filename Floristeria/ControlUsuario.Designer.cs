
namespace Floristeria
{
    partial class ControlUsuario1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Location = new System.Drawing.Point(19, 17);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(181, 21);
            this.cmbColores.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(223, 14);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(136, 24);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar por colores";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // ControlUsuario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbColores);
            this.Name = "ControlUsuario1";
            this.Size = new System.Drawing.Size(372, 59);
            this.Load += new System.EventHandler(this.ControlUsuario1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbColores;
        public System.Windows.Forms.Button btnFiltrar;
    }
}
