using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace diseno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserControl1 us = new UserControl1();
            us.label1.Text = "hola";
            us.label2.Text = "mundo";
            listView1.Controls.Add(us);
        }
    }
}
