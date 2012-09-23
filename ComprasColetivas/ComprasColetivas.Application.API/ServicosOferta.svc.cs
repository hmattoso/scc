using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ComprasColetivas.Application.APIContract.OperationContract;
using ComprasColetivas.Domain.Service.Factories;
using ComprasColetivas.Domain.Service.Services.Interfaces;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Application.APIContract.DataContract;

namespace ComprasColetivas.Application.API
{
    public class ServicosOferta : IServicosOferta
    {

        public void EnviarMalaDiretaOferta(OfertaContract ofertaContract, AnuncianteContract anuncianteContract)
        {
            IServicoOferta servicoOferta = FactoryService.getInstance.criarServicoOferta();
            Anunciante anunciante = FactoryService.getInstance.criarServicoAnunciante().ObterPorCNPJ(ofertaContract.CnpjAnunciante);
            Endereco endereco = new Endereco(ofertaContract.Logradouro, ofertaContract.Numero, ofertaContract.Complemento, ofertaContract.CEP, ofertaContract.Bairro);
            Oferta oferta = new Oferta(anunciante, ofertaContract.tipoOferta, endereco, ofertaContract.Inicio, ofertaContract.Fim, ofertaContract.Titulo, ofertaContract.Descritivo, ofertaContract.Imagem);
            servicoOferta.EnviarMalaDiretaOferta(oferta);
        }

        public void PublicarOferta(OfertaContract ofertaContract)
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
