using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BU_Logica.Objetos;
using System.Xml;

namespace BU_Logica.CargaDatosXml
{
    public class CargarMenuOpciones
    {
        XmlDocument xDoc = new XmlDocument();
        List<ObjMenu> tablaSimbol = new List<ObjMenu>();


        public List<ObjMenu> Simbolos()
        {

            xDoc.Load("TablaMenu.xml");

            XmlNodeList personas = xDoc.GetElementsByTagName("Tabla");

            XmlNodeList lista =
                ((XmlElement)personas[0]).GetElementsByTagName("ts");

            XmlElement nodo;

            for (int i = 0; i < lista.Count; i++)
            {
                nodo = (XmlElement)lista.Item(i);

                XmlNodeList Titulo = nodo.GetElementsByTagName("titulo");

                XmlNodeList Descripcion = nodo.GetElementsByTagName("descripcion");

                XmlNodeList Imagen = nodo.GetElementsByTagName("imagen");

                tablaSimbol.Add(new ObjMenu(Titulo[0].InnerText, Descripcion[0].InnerText, Imagen[0].InnerText));

            }

            return tablaSimbol;
        }

    }
}
