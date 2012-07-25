using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Infrastructure.IDAO;
using ComprasColetivas.Infrastructure.NHibernateHelper;
using NHibernate;


namespace ComprasColetivas.Infrastructure.NHDAO
{
    public abstract class BaseDAO<T> : IBaseDAO<T>
    {

        protected DatabaseControl SessionManager;

        protected ISession persister;

        public BaseDAO()
        {
            SessionManager = DatabaseControl.TPersister();
            SessionManager.Open();
            persister = SessionManager.Session;
        }

        public void Salvar(T entity)
        {
            persister.Save(entity);
        }

        public void Excluir(T entity)
        {
            persister.Delete(entity);
        }

        public T ObterPorId(int id)
        {
            return persister.Load<T>(id);
        }

        public List<T> ObterTodos()
        {
            var lista = persister.CreateCriteria(typeof(T)).List<T>();
            return lista.ToList();
        }

        public void IniciarTransacao()
        {
            SessionManager.BeginTransaction();
        }

        public void FinalizarTransacao()
        {
            SessionManager.CommitTransaction();
        }

        public void CancelarTransacao()
        {
            SessionManager.Rollback();
        }
    }
}
