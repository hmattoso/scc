using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Infrastructure.IDAO;
using ComprasColetivas.Domain.Model;
using MongoDB.Driver;
using ComprasColetivas.Infrastructure.MongoDbHelper;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace ComprasColetivas.Infrastructure.MongoDbDAO
{
    public class BaseDAO<T> : IBaseDAO<T> where T : ClasseBase
    {

        protected MongoDatabase persister;

        protected DataBaseControl SessionManager;

        public BaseDAO()
        {
            SessionManager = new DataBaseControl();
            persister = SessionManager.Context;
        }

        public void IniciarTransacao()
        {
            throw new NotImplementedException();
        }

        public void FinalizarTransacao()
        {
            throw new NotImplementedException();
        }

        public void CancelarTransacao()
        {
            throw new NotImplementedException();
        }

        public void Salvar(T entity)
        {
            persister.GetCollection<T>(typeof(T).Name).Save(entity);
        }

        public void Excluir(T entity)
        {
            var query = Query.EQ("_id", entity.Id);
            persister.GetCollection<T>(typeof(T).Name).Remove(query);
        }

        public T ObterPorId(Guid id)
        {
            return persister.GetCollection<T>(typeof(T).Name).AsQueryable<T>().Where(x => x.Id == id).FirstOrDefault();            
        }

        public X ObterUm<X>(Func<X, bool> criterio)
        {
            return persister.GetCollection<X>(typeof(T).Name).AsQueryable<X>().Where(criterio).FirstOrDefault();
        }

        public List<T> ObterTodos()
        {
            return persister.GetCollection<T>(typeof(T).Name).AsQueryable<T>().ToList();
        }

        public List<X> ObterTodos<X>(Func<X, bool> criterio)
        {
            return persister.GetCollection<T>(typeof(T).Name).AsQueryable<X>().Where(criterio).ToList();
        }
    }
}
