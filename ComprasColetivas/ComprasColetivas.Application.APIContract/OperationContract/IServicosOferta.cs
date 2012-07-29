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
    public interface IServicosOferta
    {
        [OperationContract]
        void EnviarMalaDiretaOferta(OfertaContract ofertaContract);

        [OperationContract]
        void PublicarOferta(OfertaContract ofertaContract);

        [OperationContract]
        List<OfertaContract> PesquisarPorTipoDeOferta(int tipoOferta);

        [OperationContract]
        List<OfertaContract> ListarTodasOfertas();

        [OperationContract]
        double CalcularRepassePorOferta(string CodigoOferta);

        [OperationContract]
        List<OfertaContract> PesquisarOfertaPorRegiaoDoAnunciante(string CodigoCidade);

        [OperationContract]
        int TotalizarCuponsPorMes(int Mes, int Ano);
    }
}
