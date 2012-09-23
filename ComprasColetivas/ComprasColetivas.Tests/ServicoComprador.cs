using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Domain.Service.Services.Interfaces;
using ComprasColetivas.Domain.Service.Factories;
using ComprasColetivas.Domain.Service.Helper;

namespace ComprasColetivas.Tests
{
    [TestClass]
    class ServicoComprador
    {
        [TestMethod]
        public void cadastrar_comprador()
        {
            Comprador comprador = new Comprador()
            {
                CPF = "99999999999",
                FiliacaoMae = "SCC",
                FiliacaoPai = "SCC",
                Nascimento = DateTime.Now,
                Nome = "SCC",
                OrgaoEmissor = "SCC",
                RecebeEmailOferta = true,
                RG = "999999999",
                Endereco = new Endereco() { Bairro = "Centro", CEP = "99999999", Logradouro = "Rua São José", Numero = "90", cidade = new Cidade() { Nome = "RIO", Sigla = "RJ", Estado = new Estado { Nome = "RIO", Sigla = "RJ" } } },
                Contato = new Contato() { Email = "contato@publique.com.br", TelefoneCelular = "2178510959", TelefoneFixo = "2126972802" },
                Login = new Login() { Usuario = "fdowsley", Senha = "54321", Bloqueado = false }
            };

            IServicoComprador servicoComprador = FactoryService.getInstance.criarServicoComprador();
            servicoComprador.CadastrarComprador(comprador);

            Comprador compradorGravado = ConsultaService.ObterUm<Comprador>(c => c.Login.Usuario == "hmattoso");

            Assert.AreEqual(comprador.Id, compradorGravado.Id);

        }

    }
}
