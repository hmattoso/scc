using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Infrastructure.IDAO;
using ComprasColetivas.Domain.Model;
using MongoDB.Driver;
using ComprasColetivas.Infrastructure.MongoDbHelper;
using MongoDB.Driver.Builders;

namespace ComprasColetivas.Infrastructure.MongoDbDAO
{
    public class BaseDAO<T> : IBaseDAO<T> where T : ClasseBase
    {

        protected MongoDatabase persister;

        protected DataBaseControl SessionManager;

        public BaseDAO()
        {
            SessionManager = new DataBaseControl();
            SessionManager.Open();
            persister = SessionManager.DataBase;
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
            persister.GetCollection<T>(entity.GetType().FullName).Save(entity);
        }

        public void Excluir(T entity)
        {
            var query = Query.EQ("_id", entity.Id);
            persister.GetCollection<T>(entity.GetType().FullName).Remove(query);
        }

        public T ObterPorId(int id)
        {
            var query = Query.EQ("_id", id);
            var entity = persister.GetCollection<T>("").FindOne(query);
            return (T)entity;
        }

        public X ObterUm<X>(Func<X, bool> criterio)
        {
            throw new NotImplementedException();
        }

        public List<T> ObterTodos()
        {
            return persister.GetCollection<T>("").FindAll().ToList<T>();
        }

        public List<X> ObterTodos<X>(Func<X, bool> criterio)
        {
            throw new NotImplementedException();
        }
    }
}
