using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ServicioWcf
{
    [ServiceContract]
    public interface InterfazDeControl
    {
        [OperationContract]
        String Agregar();

        [OperationContract]
        String Modificar();

        [OperationContract]
        String Eliminar();
    }
}
