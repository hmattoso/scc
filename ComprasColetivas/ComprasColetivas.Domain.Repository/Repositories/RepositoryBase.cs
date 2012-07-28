using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Infrastructure.IDAO;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Domain.Repository.Repositories
{
    public class RepositoryBase<T>: IRepository<T> where T:ClasseBase
    {

        protected IBaseDAO<T> dao;

        public RepositoryBase()
        {

        }

        public void Salvar(T entity)
        {
            dao.Salvar(entity);
        }

        public void Excluir(T entity)
        {
            dao.Excluir(entity);
        }

        public T ObterPorId(Guid id)
        {
            return dao.ObterPorId(id);
        }

        public List<T> ObterTodos()
        {
            return dao.ObterTodos();
        }

        public void IniciarTransacao()
        {
            dao.IniciarTransacao();
        }

        public void FinalizarTransacao()
        {
            dao.FinalizarTransacao();
        }

        public void CancelarTransacao()
        {
            dao.CancelarTransacao();
        }

        public X ObterUm<X>(Func<X, bool> criterio)
        {
            return dao.ObterUm<X>(criterio);
        }

        public List<X> ObterTodos<X>(Func<X, bool> criterio)
        {
            return dao.ObterTodos<X>(criterio);
        }

    }
}
