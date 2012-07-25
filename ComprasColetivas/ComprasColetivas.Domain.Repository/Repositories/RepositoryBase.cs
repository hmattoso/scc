using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Infrastructure.IDAO;

namespace ComprasColetivas.Domain.Repository.Repositories
{
    public class RepositoryBase<T>: IRepository<T>
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

        public T ObterPorId(int id)
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
    }
}
