using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BU_Logica
{   
    public class GenerarSql
    {
        private string[] Tablas = null;
        private string[] Campos = null;
        private string[] Comparacion = null;
        private string OrderBy = null;
        private string GroupBy = null;

        public GenerarSql(string[] Tablas,string[] Campos,string[] Comparacion,
                          string OrderBy,string GroupBy) 
        {
            this.Tablas = Tablas;
            this.Campos = Campos;
            this.Comparacion = Comparacion;
            this.OrderBy = OrderBy;
            this.GroupBy = GroupBy;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
