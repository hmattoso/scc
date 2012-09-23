using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Domain.Repository.Repositories.Interfaces
{
    public interface IRepositorioOferta: IRepository<Oferta>
    {
        IList<Oferta> ListarOfertasPorAnunciante(Anunciante anunciante);
        IList<Oferta> ListarOfertasPorTipoDeOferta(int tipoOferta);
        IList<Cupom> ListarCupomsPorComprador(Comprador comprador);
        IList<Cupom> ListarCupomsPorMes(int mes,int ano);
        IList<Cupom> ListarCupomsPorOferta(Oferta oferta);        
    }
}
