using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Repository.Factories;
using ComprasColetivas.Domain.Repository.Repositories;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Domain.Service.Services
{
    public class ServicoAnunciante : IServicoAnunciante
    {

        public void CadastrarAnunciante(Anunciante anunciante)
        {
            IRepositorioAnunciante repo = FactoryRepository.getInstance.criarRepositorioAnunciante();
            repo.IniciarTransacao();
            try
            {
                repo.Salvar(anunciante);
            }
            catch (Exception)
            {
                repo.FinalizarTransacao();
                throw;
            }
        }

    }
}
