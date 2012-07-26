using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Domain.Repository.Repositories
{
    public interface IRepositorioOferta: IRepository<Oferta>
    {
        IList<Oferta> ListarOfertasPorAnunciante(Anunciante anunciante);
    }
}
