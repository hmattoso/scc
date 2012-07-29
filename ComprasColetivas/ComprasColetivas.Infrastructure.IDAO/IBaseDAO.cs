using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Infrastructure.IDAO
{
    public interface IBaseDAO<T> where T: ClasseBase
    {
        void IniciarTransacao();
        void FinalizarTransacao();
        void CancelarTransacao();
        void Salvar(T entity);
        void Excluir(T entity);        
        T ObterPorId(Guid id);
        X ObterUm<X>(Func<X, bool> criterio);
        List<T> ObterTodos();
        List<X> ObterTodos<X>(Func<X, bool> criterio);
    }
}
