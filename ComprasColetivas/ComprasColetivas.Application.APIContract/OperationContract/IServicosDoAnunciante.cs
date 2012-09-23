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
        List<OfertaContract> ObterOfertasPorAnunciante(string cnpj);
        [OperationContract]
        int TotalizarCuponsPorAnunciante(string cnpj);
        [OperationContract]
        void BaixarCupom(string CodigoCupom);
        [OperationContract]
        bool Logar(string usuario, string senha);
    }
}
