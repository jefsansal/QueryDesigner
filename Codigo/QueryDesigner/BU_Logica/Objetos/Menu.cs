using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BU_Logica.Objetos
{
    
    public class ObjMenu
    {
        private string imagen;
        private string titulo;
        private string descripcion;

        public ObjMenu(string Titulo, string Descripcion, string Imagen) {
            this.titulo = Titulo;
            this.descripcion = Descripcion;
            this.imagen = Imagen;
        }

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
