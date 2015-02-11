using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ServicioWcf.TablasYCampos
{
    [ServiceContract]
    public interface InterfazBaseDeDatos
    {
        [OperationContract]
        List<string> ListaTablas();

        [OperationContract]
        List<string> CamposPorTabla(string Tabla);
    }
}
