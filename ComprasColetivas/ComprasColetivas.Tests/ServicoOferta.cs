using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Domain.Service.Services.Interfaces;
using ComprasColetivas.Domain.Service.Factories;
using ComprasColetivas.Domain.Service.Helper;

namespace ComprasColetivas.Tests
{
    /// <summary>
    /// Summary description for ServicoOferta
    /// </summary>
    [TestClass]
    public class ServicoOferta
    {

        [TestMethod]
        public void publicar_oferta()
        {
            Oferta oferta = new Oferta()
            {
                anunciante = new Anunciante()
                      {
                          CNPJ = "03.847.655/0001-98",
                          Nome = "PUBLICADOR S/A",
                          NomeFantasia = "PUBLIQUE",
                          InscricaoEstadual = "12345",
                          InscricaoMunicipal = "123456",
                          WebSite = "www.publique.com.br",
                          Contato = new Contato() { Email = "contato@publique.com.br", TelefoneCelular = "2178510959", TelefoneFixo = "2126972802" },
                          Login = new Login() { Usuario = "hmattoso", Senha = "54321", Bloqueado = false }
                      },
                Descritivo = "SCC",
                Titulo = "SCC",
                tipoOferta = TipoOferta.SERVICO
            };

            IServicoOferta servicoOferta = FactoryService.getInstance.criarServicoOferta();
            servicoOferta.PublicarOferta(oferta);

            Oferta ofertaPulicada = ConsultaService.ObterUm<Oferta>(o => o.Descritivo == "SCC" && o.Titulo == "SCC");

            Assert.AreEqual(oferta.Id, ofertaPulicada.Id);


        }
    }
}
