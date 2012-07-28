using System;
using MongoDB.Driver;
namespace ComprasColetivas.Infrastructure.MongoDbHelper
{
    public interface IDataBaseControl
    {
        MongoDatabase Context { get; }
    }
}
