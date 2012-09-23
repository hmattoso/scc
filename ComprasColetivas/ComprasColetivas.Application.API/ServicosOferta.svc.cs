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
            IServicoOferta servicoOferta = FactoryService.getInstance.criarServicoOferta();
            Anunciante anunciante = FactoryService.getInstance.criarServicoAnunciante().ObterPorCNPJ(ofertaContract.CnpjAnunciante);
            Endereco endereco = new Endereco(ofertaContract.Logradouro, ofertaContract.Numero, ofertaContract.Complemento, ofertaContract.CEP, ofertaContract.Bairro);
            Oferta oferta = new Oferta(anunciante, ofertaContract.tipoOferta, endereco, ofertaContract.Inicio, ofertaContract.Fim, ofertaContract.Titulo, ofertaContract.Descritivo, ofertaContract.Imagem);
            servicoOferta.PublicarOferta(oferta);
        }

        public List<OfertaContract> PesquisarPorTipoDeOferta(int tipoOferta)
        {
            List<OfertaContract> ofertas = new List<OfertaContract>();
            IServicoOferta servicoOferta = FactoryService.getInstance.criarServicoOferta();
            var ofertasPorTipo = servicoOferta.PesquisarPorTipoDeOferta(tipoOferta);
            foreach (var item in ofertasPorTipo)
                ofertas.Add(new OfertaContract(item));

            return ofertas;
        }

        public List<OfertaContract> ListarTodasOfertas()
        {
            List<OfertaContract> ofertas = new List<OfertaContract>();
            IServicoOferta servicoOferta = FactoryService.getInstance.criarServicoOferta();
            var ofertasPorTipo = servicoOferta.ListarTodasOfertas();
            foreach (var item in ofertasPorTipo)
                ofertas.Add(new OfertaContract(item));

            return ofertas;
        }

        public double CalcularRepassePorOferta(string CodigoOferta)
        {
            throw new NotImplementedException();
        }

        public List<OfertaContract> PesquisarOfertaPorRegiaoDoAnunciante(string CodigoCidade)
        {
            List<OfertaContract> ofertas = new List<OfertaContract>();
            IServicoOferta servicoOferta = FactoryService.getInstance.criarServicoOferta();
            var ofertasPorTipo = servicoOferta.PesquisarOfertaPorRegiaoDoAnunciante(CodigoCidade);
            foreach (var item in ofertasPorTipo)
                ofertas.Add(new OfertaContract(item));

            return ofertas;
        }

        public int TotalizarCuponsPorMes(int Mes, int Ano)
        {
            IServicoOferta servicoOferta = FactoryService.getInstance.criarServicoOferta();
            return servicoOferta.TotalizarCuponsPorMes(Mes, Ano);
        }
    }
}
