using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Infrastructure.IDAO;

namespace ComprasColetivas.Infrastructure.NHDAO
{
    public class AnuncianteDAO: BaseDAO<Anunciante>, IAnuncianteDAO
    {

        void IBaseDAO<Anunciante>.IniciarTransacao()
        {
            throw new NotImplementedException();
        }

        void IBaseDAO<Anunciante>.FinalizarTransacao()
        {
            throw new NotImplementedException();
        }

        void IBaseDAO<Anunciante>.CancelarTransacao()
        {
            throw new NotImplementedException();
        }

        void IBaseDAO<Anunciante>.Salvar(Anunciante entity)
        {
            throw new NotImplementedException();
        }

        void IBaseDAO<Anunciante>.Excluir(Anunciante entity)
        {
            throw new NotImplementedException();
        }

        Anunciante IBaseDAO<Anunciante>.ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        X IBaseDAO<Anunciante>.ObterUm<X>(Func<X, bool> criterio)
        {
            throw new NotImplementedException();
        }

        List<Anunciante> IBaseDAO<Anunciante>.ObterTodos()
        {
            throw new NotImplementedException();
        }

        List<X> IBaseDAO<Anunciante>.ObterTodos<X>(Func<X, bool> criterio)
        {
            throw new NotImplementedException();
        }
    }
}
