using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace BU_Logica
{
    [ServiceContract]
    public interface ArregloLista
    {
        
        [OperationContract]
        List<string> GenerarListado(); 
    }
}
