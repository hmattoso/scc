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
    public interface IServicosDoComprador
    {        
        [OperationContract]
        void CadastrarComprador(CompradorContract comprador);
        [OperationContract]
        List<CupomContract> ObterCupomsPorComprador(string cpf);
        [OperationContract]
        int TotalizarCuponsPorComprador(string cpf);
        [OperationContract]
        bool Logar(string usuario, string senha);
    }
}
