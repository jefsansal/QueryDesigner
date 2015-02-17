namespace QueryDesigner
{
    partial class ColumnaImagenes
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuUsuario = new System.Windows.Forms.PictureBox();
            this.MenuReportes = new System.Windows.Forms.PictureBox();
            this.MenuControl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MenuUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuControl)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.Image = global::QueryDesigner.Properties.Resources.Usuario;
            this.MenuUsuario.Location = new System.Drawing.Point(0, 3);
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(35, 35);
            this.MenuUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuUsuario.TabIndex = 5;
            this.MenuUsuario.TabStop = false;
            this.MenuUsuario.Click += new System.EventHandler(this.MenuUsuario_Click);
            // 
            // MenuReportes
            // 
            this.MenuReportes.Image = global::QueryDesigner.Properties.Resources.Control;
            this.MenuReportes.Location = new System.Drawing.Point(0, 44);
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(35, 35);
            this.MenuReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuReportes.TabIndex = 4;
            this.MenuReportes.TabStop = false;
            this.MenuReportes.Click += new System.EventHandler(this.MenuReportes_Click);
            // 
            // MenuControl
            // 
            this.MenuControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuControl.Image = global::QueryDesigner.Properties.Resources.Datos;
            this.MenuControl.Location = new System.Drawing.Point(0, 85);
            this.MenuControl.Name = "MenuControl";
            this.MenuControl.Size = new System.Drawing.Size(35, 35);
            this.MenuControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuControl.TabIndex = 3;
            this.MenuControl.TabStop = false;
            this.MenuControl.Click += new System.EventHandler(this.MenuControl_Click);
            // 
            // ColumnaImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MenuUsuario);
            this.Controls.Add(this.MenuReportes);
            this.Controls.Add(this.MenuControl);
            this.Name = "ColumnaImagenes";
            this.Size = new System.Drawing.Size(37, 125);
            ((System.ComponentModel.ISupportInitialize)(this.MenuUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MenuUsuario;
        private System.Windows.Forms.PictureBox MenuReportes;
        private System.Windows.Forms.PictureBox MenuControl;
    }
}
