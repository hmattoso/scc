using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Infrastructure.IDAO;
using NHibernate;

namespace ComprasColetivas.Infrastructure.NHDAO
{
    public class OfertaDAO : BaseDAO<Oferta>, IOfertaDAO
    {

        public IList<Oferta> ListarOfertasPorAnunciante(Anunciante anunciante)
        {
            IQuery qryHQL = persister.CreateQuery("from Oferta o where Anunciante = :Anunciante");            
            qryHQL.SetParameter("Anunciante", anunciante);
            return qryHQL.List<Oferta>();
        }

        void IBaseDAO<Oferta>.IniciarTransacao()
        {
            throw new NotImplementedException();
        }

        void IBaseDAO<Oferta>.FinalizarTransacao()
        {
            throw new NotImplementedException();
        }

        void IBaseDAO<Oferta>.CancelarTransacao()
        {
            throw new NotImplementedException();
        }

        void IBaseDAO<Oferta>.Salvar(Oferta entity)
        {
            throw new NotImplementedException();
        }

        void IBaseDAO<Oferta>.Excluir(Oferta entity)
        {
            throw new NotImplementedException();
        }

        Oferta IBaseDAO<Oferta>.ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        X IBaseDAO<Oferta>.ObterUm<X>(Func<X, bool> criterio)
        {
            throw new NotImplementedException();
        }

        List<Oferta> IBaseDAO<Oferta>.ObterTodos()
        {
            throw new NotImplementedException();
        }

        List<X> IBaseDAO<Oferta>.ObterTodos<X>(Func<X, bool> criterio)
        {
            throw new NotImplementedException();
        }
    }
}
