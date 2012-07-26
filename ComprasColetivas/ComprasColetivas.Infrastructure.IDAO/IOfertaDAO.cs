using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Infrastructure.IDAO
{
    public interface IOfertaDAO: IBaseDAO<Oferta>
    {
        IList<Oferta> ListarOfertasPorAnunciante(Anunciante anunciante);
    }
}
