using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ComprasColetivas.Application.APIContract.OperationContract;
using ComprasColetivas.Application.APIContract.DataContract;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Domain.Service.Services.Interfaces;
using ComprasColetivas.Domain.Service.Factories;


namespace ComprasColetivas.Application.API
{

    public class ServicosDoAnunciante : IServicosDoAnunciante
    {

        public void CadastrarAnunciante(AnuncianteContract anuncianteContract)
        {
            Anunciante anunciante = new Anunciante(anuncianteContract.CNPJ, anuncianteContract.NomeFantasia, anuncianteContract.Nome, anuncianteContract.InscricaoMunicipal, anuncianteContract.InscricaoEstadual, anuncianteContract.WebSite);
            IServicoAnunciante servicoAnunciante = FactoryService.getInstance.criarServicoAnunciante();
            servicoAnunciante.CadastrarAnunciante(anunciante);
        }

        public string ObterOfertasPorAnunciante(string cpf)
        {
            IServicoOferta servicoOferta = FactoryService.getInstance.criarServicoOferta();
            servicoOferta.ListarOfertasPorAnunciante(cpf);
            throw new NotImplementedException();
        }
    }
}
