using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ComprasColetivas.Application.APIContract.OperationContract;
using ComprasColetivas.Application.APIContract.DataContract;
using ComprasColetivas.Domain.Service.Services.Interfaces;
using ComprasColetivas.Domain.Service.Factories;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Cross_Cutting.Authentication;

namespace ComprasColetivas.Application.API
{
    public class ServicosDoComprador : IServicosDoComprador
    {
        public void CadastrarComprador(CompradorContract compradorContract)
        {
            Comprador comprador = new Comprador(compradorContract.Nome, compradorContract.CPF, compradorContract.FiliacaoMae, compradorContract.FiliacaoPai, compradorContract.Nascimento, compradorContract.OrgaoEmissor, compradorContract.RecebeEmailOferta, compradorContract.RG);
            IServicoComprador servicoComprador = FactoryService.getInstance.criarServicoComprador();
            servicoComprador.CadastrarComprador(comprador);
        }

        public List<CupomContract> ObterCupomsPorComprador(string cpf)
        {
            List<CupomContract> cupoms = new List<CupomContract>();
            IServicoOferta servicoOferta = FactoryService.getInstance.criarServicoOferta();
            var cupomsPorComprador = servicoOferta.ListarCupomsPorComprador(cpf);
            foreach (var item in cupomsPorComprador)
                cupoms.Add(new CupomContract(item));
            return cupoms;
        }

        public int TotalizarCuponsPorComprador(string cpf)
        {
            IServicoOferta servicoOferta = FactoryService.getInstance.criarServicoOferta();
            return servicoOferta.TotalizarCuponsPorComprador(cpf);
        }


        public bool Logar(string usuario, string senha)
        {
            SSO authentication = new SSO();
            return authentication.Autenticar(usuario, senha);
        }
    }
}
