using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using BU_Logica.CargaDatosXml;
using BU_Logica.Objetos;

namespace QueryDesigner
{
    public partial class Menu : Form
    {
        private Opciones us;
        private List<ObjMenu> Simbolos;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Simbolos = new CargarMenuOpciones().Simbolos();

            foreach (var Opciones in Simbolos)
            {
                CargarDatos(Opciones.Imagen, Opciones.Titulo, Opciones.Descripcion);
            }
        }

        private void CargarDatos(string URLImagen, string Titulo, string Descripcion)
        {

            us = new Opciones();
            us.Icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\"+URLImagen+".png");
            us.Titulo.Text = Titulo;
            us.Descripcion.Text = Descripcion;
            AddControl(us);

        }

        private void AddControl(Control ctl)
        {
            tableLayoutPnl.RowCount += 1;
            tableLayoutPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / tableLayoutPnl.RowCount));

            ctl.Dock = DockStyle.Fill;

            tableLayoutPnl.Controls.Add(ctl, 0, tableLayoutPnl.RowCount - 2);

            foreach (RowStyle rs in tableLayoutPnl.RowStyles)
            {
                rs.Height = 100F / tableLayoutPnl.RowCount;
            }
        }

    }    
}
