using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ComprasColetivas.Application.APIContract.OperationContract;

namespace ComprasColetivas.Application.API
{    
    public class ServicosOferta : IServicosOferta
    {

        public void EnviarMalaDiretaOferta(APIContract.DataContract.OfertaContract ofertaContract)
        {
            throw new NotImplementedException();
        }

        public void PublicarOferta(APIContract.DataContract.OfertaContract ofertaContract)
        {
            throw new NotImplementedException();
        }

        public List<APIContract.DataContract.OfertaContract> PesquisarPorTipoDeOferta(int tipoOferta)
        {
            throw new NotImplementedException();
        }

        public List<APIContract.DataContract.OfertaContract> ListarTodasOfertas()
        {
            throw new NotImplementedException();
        }

        public double CalcularRepassePorOferta(string CodigoOferta)
        {
            throw new NotImplementedException();
        }

        public List<APIContract.DataContract.OfertaContract> PesquisarOfertaPorRegiaoDoAnunciante(string CodigoCidade)
        {
            throw new NotImplementedException();
        }

        public int TotalizarCuponsPorMes(int Mes, int Ano)
        {
            throw new NotImplementedException();
        }
    }
}
