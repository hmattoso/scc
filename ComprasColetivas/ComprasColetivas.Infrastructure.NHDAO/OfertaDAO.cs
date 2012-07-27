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

    }
}
