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
        private MongoServer server = MongoServer.Create(ConfigurationSettings.AppSettings["MongoDBConnection"].ToString());
        //public MongoServer Server { get { return this.server; } private set { server = value; } }
        public MongoDatabase DataBase { get { return this.server.GetDatabase(ConfigurationSettings.AppSettings["MongoDataBase"].ToString()); } }

        public void Open()
        {
            server.Connect();
        }

        static DataBaseControl()
        {
            BsonClassMap.RegisterClassMap<Anunciante>();
            BsonClassMap.RegisterClassMap<Oferta>();
            BsonClassMap.RegisterClassMap<Comprador>();
        }

    }
}
