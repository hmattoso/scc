using ComprasColetivas.Domain.Repository.Factories;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Infrastructure.DAO.Factories;
using System.Collections.Generic;
using ComprasColetivas.Infrastructure.IDAO;
using ComprasColetivas.Domain.Repository.Repositories.Interfaces;


namespace ComprasColetivas.Domain.Repository.Repositories
{
    public class RepositorioOferta : RepositoryBase<Oferta>, IRepositorioOferta
    {

        public RepositorioOferta(): base()
        {
            dao = FactoryDAO.getInstance.CriarOfertaDAO();
        }

        public IList<Oferta> ListarOfertasPorAnunciante(Anunciante anunciante)
        {
            return (dao as IOfertaDAO).ListarOfertasPorAnunciante(anunciante);
        }
    }

}