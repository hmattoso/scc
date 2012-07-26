using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Domain.Repository.Repositories;
using ComprasColetivas.Domain.Service.Services;
using ComprasColetivas.Domain.Service.Factories;
using ComprasColetivas.Domain.Service.Helper;

namespace ComprasColetivas.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarServicoDeDominioAnunciante()
        {
            Anunciante anunciante = new Anunciante()
            {
                CNPJ = "03.847.655/0001-98",
                Nome = "PUBLICADOR S/A",
                NomeFantasia = "PUBLIQUE",
                InscricaoEstadual = "12345",
                InscricaoMunicipal = "123456",
                WebSite = "www.publique.com.br",
                Contato = new Contato() { Email = "contato@publique.com.br", TelefoneCelular = "2178510959", TelefoneFixo = "2126972802" },
                Login = new Login() { Usuario = "hmattoso", Senha = "54321", Bloqueado = false }
            };

            IServicoAnunciante servicoAnunciante = FactoryService.getInstance.criarServicoAnunciante();
            servicoAnunciante.CadastrarAnunciante(anunciante);

            Anunciante anuncianteGravado = ConsultaService.ObterUm<Anunciante>(a => a.Login.Usuario == "hmattoso");

            Assert.AreEqual(anunciante.Id, anuncianteGravado.Id);

        }
    }
}
