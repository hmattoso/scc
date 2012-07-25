using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComprasColetivas.Infrastructure.IDAO
{
    public interface IBaseDAO<T>
    {
        void IniciarTransacao();
        void FinalizarTransacao();
        void CancelarTransacao();
        void Salvar(T entity);
        void Excluir(T entity);
        T ObterPorId(int id);
        List<T> ObterTodos();
    }
}
