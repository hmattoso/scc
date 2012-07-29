using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ComprasColetivas.Application.APIContract.DataContract;

namespace ComprasColetivas.Application.APIContract.OperationContract
{    
    [ServiceContract]
    public interface IServicosDoAnunciante
    {
        [OperationContract]
        void CadastrarAnunciante(AnuncianteContract anunciante);
        [OperationContract]
        string ObterOfertasPorAnunciante(string cpf);
    }
}
