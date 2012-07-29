using ComprasColetivas.Domain.Repository.Repositories.Interfaces;
using ComprasColetivas.Domain.Repository.Factories;
using ComprasColetivas.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using ComprasColetivas.Domain.Service.Services.Interfaces;
using ComprasColetivas.Infrastructure.SendMail.EnvioEmail.Interfaces;
using ComprasColetivas.Infrastructure.SendMail.Factories;
namespace ComprasColetivas.Domain.Service
{
    public class ServicoOferta : IServicoOferta
    {
        public void EnviarMalaDiretaOferta(Oferta oferta)
        {
            IEnviarEmailMalaDireta malaDireta = FactoryEnvioMail.getInstance.criarEnvioEmailMalaDireta();
            IRepositorioComprador repo = FactoryRepository.getInstance.criarRepositorioComprador();
            var compradores = repo.ObterTodos();
            malaDireta.EnviarEmail(oferta, compradores);
        }

        public void PublicarOferta(Oferta oferta)
        {
            IRepositorioOferta repo = FactoryRepository.getInstance.criarRepositorioOferta();

            repo.IniciarTransacao();
            try
            {
                repo.Salvar(oferta);
                repo.FinalizarTransacao();
            }
            catch (Exception)
            {
                repo.CancelarTransacao();
                throw;
            }
        }

        public List<Oferta> PesquisarPorTipoDeOferta(TipoOferta tipoOferta)
        {
            IRepositorioOferta repo = FactoryRepository.getInstance.criarRepositorioOferta();
            List<Oferta> ofertas = new List<Oferta>();
            var items = repo.ListarOfertasPorTipoDeOferta(tipoOferta);
            foreach (var item in items)
                if (item.IsVigente())
                    ofertas.Add(item);
            return ofertas;
        }

        public List<Oferta> ListarTodasOfertas()
        {
            IRepositorioOferta repo = FactoryRepository.getInstance.criarRepositorioOferta();
            List<Oferta> ofertas = new List<Oferta>();
            var items = repo.ObterTodos();
            foreach (var item in items)
                if (item.IsVigente())
                    ofertas.Add(item);
            return ofertas;
        }

        public double CalcularRepassePorOferta(string CodigoOferta)
        {
            throw new NotImplementedException();
        }

        public List<Oferta> PesquisarOfertaPorRegiaoDoAnunciante(string CodigoCidade)
        {
            IRepositorioOferta repo = FactoryRepository.getInstance.criarRepositorioOferta();
            return repo.ObterTodos<Oferta>(oferta => oferta.enderecoOferta.cidade.Sigla == CodigoCidade);
        }

        public int TotalizarCuponsPorMes(int Mes, int Ano)
        {
            IRepositorioOferta repo = FactoryRepository.getInstance.criarRepositorioOferta();
            var cupoms = repo.ListarCupomsPorMes(Mes, Ano);
            return cupoms.Count;
        }

        public int TotalizarCuponsPorAnunciante(string CNPJ)
        {
            int cupoms = 0;
            IRepositorioAnunciante repoAnunciante = FactoryRepository.getInstance.criarRepositorioAnunciante();
            var anunciante = repoAnunciante.ObterAnunciante(CNPJ);
            IRepositorioOferta repoOferta = FactoryRepository.getInstance.criarRepositorioOferta();
            var ofertas = repoOferta.ListarOfertasPorAnunciante(anunciante);
            foreach (var item in ofertas)
                cupoms += repoOferta.ListarCupomsPorOferta(item).Count;
            return cupoms;
        }

        public int TotalizarCuponsPorComprador(string CPF)
        {
            IRepositorioComprador repoComprador = FactoryRepository.getInstance.criarRepositorioComprador();
            IRepositorioOferta repoOferta = FactoryRepository.getInstance.criarRepositorioOferta();
            var comprador = repoComprador.ObterComprador(CPF);
            return repoOferta.ListarCupomsPorComprador(comprador).Count;
        }

        public void BaixarCupom(string CodigoCupom)
        {
            throw new NotImplementedException();
        }

        public List<Cupom> ListarCupomsPorComprador(Comprador comprador)
        {
            IRepositorioOferta repo = FactoryRepository.getInstance.criarRepositorioOferta();
            return repo.ListarCupomsPorComprador(comprador).ToList();
        }

        public IList<Oferta> ListarOfertasPorAnunciante(string CPF)
        {
            IRepositorioOferta repoOferta = FactoryRepository.getInstance.criarRepositorioOferta();
            IRepositorioAnunciante repoAnunciante = FactoryRepository.getInstance.criarRepositorioAnunciante();
            var anunciante = repoAnunciante.ObterAnunciante(CPF);
            return repoOferta.ListarOfertasPorAnunciante(anunciante);
        }
    }
}