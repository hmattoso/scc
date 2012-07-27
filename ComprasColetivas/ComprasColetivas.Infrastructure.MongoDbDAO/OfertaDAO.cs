using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Infrastructure.MongoDbDAO
{
    class OfertaDAO:BaseDAO<Oferta>
    {
        public List<Oferta> ListarOfertasPorAnunciante(Anunciante anunciante)
        {
            return persister.GetCollection<Oferta>("Oferta").FindAll().ToList<Oferta>();
        }
    }
}
