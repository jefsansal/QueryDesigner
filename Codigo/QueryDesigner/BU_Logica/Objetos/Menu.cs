using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BU_Logica.Objetos
{
    [DataContract]
    public class Menu
    {
        [DataMember]
        public Menu(string Titulo, string Descripcion, string Imagen) {
            this.Titulo = Titulo;
            this.Descripcion = Descripcion;
            this.Imagen = Imagen;
        }

        [DataMember]
        private string Titulo { get; set; }

        [DataMember]
        private string Descripcion { get; set; }

        [DataMember]
        private string Imagen { get; set; }

    }
}
