using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using MongoDB.Driver;

namespace CosmosDB.MongoDB
{
    public class MongoDBOperations
    {
        string CosmoDBuri = ConfigurationManager.AppSettings["MongoDBUri"];
        string connectionString = @"mongodb://azure-cosmodb-mongodb-api:xTF4pDBtjZi3h8dZKY892Y1lLafyN9uGqqvcJtdZ5WVx9w6xagCIP4MFalVaVTyX02ttNi9HyfDHrcLtJJlRBg==@azure-cosmodb-mongodb-api.mongo.cosmos.azure.com:10255/?ssl=true&replicaSet=globaldb&retrywrites=false&maxIdleTimeMS=120000&appName=@azure-cosmodb-mongodb-api@";
        MongoClientSettings settings = null;
        MongoClient mongoClient = null;

        public MongoDBOperations()
        {
            settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            settings.SslSettings =
              new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
            mongoClient = new MongoClient(settings);
        }

        public async Task GetAllDatabases()
        {
            var response = mongoClient.ListDatabases().ToList();
            
            ////foreach (MongoDB.Bson.BsonDocument d in response)
            ////{
            ////    Console.WriteLine(d.ToString());
            ////}

            ////foreach (var item in response.Result.ToList())
            ////{
            ////    Console.WriteLine(item.ToString());
            ////}
        }
    }
}
