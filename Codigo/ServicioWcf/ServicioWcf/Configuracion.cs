﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace ServicioWcf
{
    public class Configuracion
    {
        public static string CadenaConexion
        {

            get
            {

                return ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString.ToString();


            }

        }
    }
}