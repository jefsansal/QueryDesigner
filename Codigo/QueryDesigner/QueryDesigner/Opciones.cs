using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QueryDesigner
{
    public partial class Opciones : UserControl
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void Opciones_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(Titulo.Text);
        }

        private void Opciones_Load(object sender, EventArgs e)
        {

        }

        private void Icon_Click(object sender, EventArgs e)
        {

        }

    }
}
