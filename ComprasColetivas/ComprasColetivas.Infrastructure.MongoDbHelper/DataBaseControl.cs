using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using System.Configuration;
using MongoDB.Bson.Serialization;
using ComprasColetivas.Domain.Model;
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
            BsonClassMap.RegisterClassMap<Anunciante>();
            BsonClassMap.RegisterClassMap<Oferta>();
            BsonClassMap.RegisterClassMap<Comprador>();
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
