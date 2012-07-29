using ComprasColetivas.Domain.Repository.Factories;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Infrastructure.DAO.Factories;
using ComprasColetivas.Domain.Repository.Repositories.Interfaces;
using ComprasColetivas.Infrastructure.IDAO;


namespace ComprasColetivas.Domain.Repository.Repositories
{
    public class RepositorioAnunciante : RepositoryBase<Anunciante>, IRepositorioAnunciante
    {

        public RepositorioAnunciante(): base()
        {
            dao = FactoryDAO.getInstance.CriarAnuncianteDAO();
        }


        public Anunciante ObterAnunciante(string cnpj)
        {
            return (dao as IAnuncianteDAO).ObterUm<Anunciante>(anunciante => anunciante.CNPJ == cnpj);
        }
    }

}