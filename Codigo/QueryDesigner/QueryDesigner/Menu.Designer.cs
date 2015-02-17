namespace QueryDesigner
{
    partial class Menu
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
            this.tableLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.columnaImagenes1 = new QueryDesigner.ColumnaImagenes();
            this.SuspendLayout();
            // 
            // tableLayoutPnl
            // 
            this.tableLayoutPnl.ColumnCount = 1;
            this.tableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPnl.Location = new System.Drawing.Point(43, 12);
            this.tableLayoutPnl.Name = "tableLayoutPnl";
            this.tableLayoutPnl.RowCount = 1;
            this.tableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPnl.Size = new System.Drawing.Size(205, 451);
            this.tableLayoutPnl.TabIndex = 0;
            this.tableLayoutPnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPnl_MouseClick);
            // 
            // columnaImagenes1
            // 
            this.columnaImagenes1.Location = new System.Drawing.Point(0, 12);
            this.columnaImagenes1.Name = "columnaImagenes1";
            this.columnaImagenes1.Size = new System.Drawing.Size(37, 125);
            this.columnaImagenes1.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 475);
            this.Controls.Add(this.columnaImagenes1);
            this.Controls.Add(this.tableLayoutPnl);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPnl;
        private ColumnaImagenes columnaImagenes1;






    }
}