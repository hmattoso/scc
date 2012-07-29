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
            IServicoOferta servicoOferta = FactoryService.getInstance.criarServicoOferta();
            servicoOferta.ListarCupomsPorComprador(cpf);
            throw new NotImplementedException();
        }

        public int TotalizarCuponsPorComprador(string cpf)
        {
            IServicoOferta servicoOferta = FactoryService.getInstance.criarServicoOferta();
            return servicoOferta.TotalizarCuponsPorComprador(cpf);
        }
    }
}
