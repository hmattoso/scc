using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Infrastructure.IDAO;
using ComprasColetivas.Infrastructure.NHibernateHelper;
using NHibernate;
using NHibernate.Linq;
using ComprasColetivas.Domain.Model;


namespace ComprasColetivas.Infrastructure.NHDAO
{
    public abstract class BaseDAO<T> : IBaseDAO<T> where T: ClasseBase
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

        public X ObterUm<X>(Func<X, bool> criterio) 
        {
            return persister.Query<X>().FirstOrDefault(criterio);
        }

        public List<T> ObterTodos()
        {
            var lista = persister.CreateCriteria(typeof(T)).List<T>();
            return lista.ToList();
        }

        public List<X> ObterTodos<X>(Func<X, bool> criterio)
        {

            return persister.Query<X>().Where(criterio).ToList();

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
