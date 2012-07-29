using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Service.Services.Interfaces;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Domain.Repository.Repositories.Interfaces;
using ComprasColetivas.Domain.Repository.Factories;

namespace ComprasColetivas.Domain.Service.Services
{
    class ServicoComprador:IServicoComprador
    {
        public void CadastrarComprador(Comprador comprador)
        {

            IRepositorioComprador repo = FactoryRepository.getInstance.criarRepositorioComprador();

            repo.IniciarTransacao();
            try
            {
                repo.Salvar(comprador);
                repo.FinalizarTransacao();
            }
            catch (Exception)
            {
                repo.CancelarTransacao();
                throw;
            }

        }
    }
}
