namespace QueryDesigner
{
    partial class Opciones
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
            this.Titulo = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(50, 28);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(39, 15);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "label1";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Descripcion.Location = new System.Drawing.Point(50, 53);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(36, 11);
            this.Descripcion.TabIndex = 1;
            this.Descripcion.Text = "label2";
            // 
            // Icon
            // 
            this.Icon.Location = new System.Drawing.Point(3, 19);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(41, 50);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon.TabIndex = 2;
            this.Icon.TabStop = false;
            this.Icon.Click += new System.EventHandler(this.Icon_Click);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Titulo);
            this.Name = "Opciones";
            this.Size = new System.Drawing.Size(170, 87);
            this.Load += new System.EventHandler(this.Opciones_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Opciones_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Titulo;
        public System.Windows.Forms.Label Descripcion;
        public System.Windows.Forms.PictureBox Icon;
    }
}
