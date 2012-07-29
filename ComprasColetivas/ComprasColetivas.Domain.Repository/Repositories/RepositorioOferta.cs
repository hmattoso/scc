using ComprasColetivas.Domain.Repository.Factories;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Infrastructure.DAO.Factories;
using System.Collections.Generic;
using ComprasColetivas.Infrastructure.IDAO;
using ComprasColetivas.Domain.Repository.Repositories.Interfaces;
using ComprasColetivas.Domain.Specification;
using System.Linq;

namespace ComprasColetivas.Domain.Repository.Repositories
{
    public class RepositorioOferta : RepositoryBase<Oferta>, IRepositorioOferta
    {

        public RepositorioOferta()
            : base()
        {
            dao = FactoryDAO.getInstance.CriarOfertaDAO();
        }

        public IList<Oferta> ListarOfertasPorAnunciante(Anunciante anunciante)
        {
            return (dao as IOfertaDAO).ListarOfertasPorAnunciante(anunciante);
        }

        public IList<Oferta> ListarOfertasPorTipoDeOferta(TipoOferta tipoOferta)
        {
            return (dao as IOfertaDAO).ObterTodos<Oferta>(oferta => oferta.tipoOferta == tipoOferta);
        }

        public IList<Cupom> ListarCupomsPorComprador(Comprador comprador)
        {
            return (dao as IOfertaDAO).ObterTodos<Cupom>(cupom => cupom.comprador == comprador);
        }

        public IList<Cupom> ListarCupomsPorMes(int mes, int ano)
        {
            return (dao as IOfertaDAO).ObterTodos<Cupom>(cupom => cupom.Emissao.Month == mes && cupom.Emissao.Year == ano);
        }

        public IList<Cupom> ListarCupomsPorOferta(Oferta oferta)
        {
            return (dao as IOfertaDAO).ObterTodos<Cupom>(cupom => cupom.oferta == oferta);
        }
    }

}