using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using System.Configuration;
using MongoDB.Bson.Serialization;
using ComprasColetivas.Domain.Model;
using MongoDB.Bson.Serialization.Conventions;
namespace ComprasColetivas.Infrastructure.MongoDbHelper
{
    public class DataBaseControl : IDisposable, IDataBaseControl
    {
        private MongoServer server
        {
            get
            {
                return MongoServer.Create();
            }
        }

        private MongoDatabase context
        {
            get
            {
                return this.server.GetDatabase(ConfigurationSettings.AppSettings["MongoDataBase"].ToString());
            }
        }

        public MongoDatabase Context { get { return this.context; } }

        static DataBaseControl()
        {
            BsonClassMap.RegisterClassMap<Anunciante>(c => c.AutoMap());
            BsonClassMap.RegisterClassMap<Oferta>(c => c.AutoMap());
            BsonClassMap.RegisterClassMap<Comprador>(c => c.AutoMap());
            BsonClassMap.RegisterClassMap<CartaoCreditoInfo>(c => c.AutoMap());
            BsonClassMap.RegisterClassMap<Cidade>(c => c.AutoMap());
            BsonClassMap.RegisterClassMap<Contato>(c => c.AutoMap());
            BsonClassMap.RegisterClassMap<Cupom>(c => c.AutoMap());
            BsonClassMap.RegisterClassMap<Endereco>(c => c.AutoMap());
            BsonClassMap.RegisterClassMap<Estado>(c => c.AutoMap());
            BsonClassMap.RegisterClassMap<Login>(c => c.AutoMap());
            BsonClassMap.RegisterClassMap<PaypalInfo>(c => c.AutoMap());
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
