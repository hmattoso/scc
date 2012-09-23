using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Repository.Factories;
using ComprasColetivas.Domain.Repository.Repositories;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Domain.Service.Services.Interfaces;
using ComprasColetivas.Domain.Repository.Repositories.Interfaces;

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
                repo.FinalizarTransacao();
            }
            catch (Exception)
            {
                repo.CancelarTransacao();
                throw;
            }

        }

        public Anunciante ObterPorCNPJ(string cnpj)
        {
            IRepositorioAnunciante repo = FactoryRepository.getInstance.criarRepositorioAnunciante();
            return repo.ObterAnunciante(cnpj);
        }
    }
}
