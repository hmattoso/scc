using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Infrastructure.IDAO;

namespace ComprasColetivas.Infrastructure.MongoDbDAO
{
    class OfertaDAO : BaseDAO<Oferta>, IOfertaDAO
    {        
        public IList<Oferta> ListarOfertasPorAnunciante(Anunciante anunciante)
        {
            return base.ObterTodos<Oferta>(oferta => oferta.anunciante == anunciante);
        }
    }
}
