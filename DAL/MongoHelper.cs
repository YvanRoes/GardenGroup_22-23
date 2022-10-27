using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Model;

namespace DAL
{
    public class MongoHelper
    {
        protected static MongoClient _client;
        protected static MongoHelper _helper;
        protected IMongoDatabase database;

        protected MongoHelper() { _client = new MongoClient("mongodb+srv://gg3:gg3@cluster0.mhym582.mongodb.net/?retryWrites=true&w=majority"); database = _client.GetDatabase("NoSqlProjectDatabase"); }

        public static MongoHelper getInstance()
        {
            if (_helper == null)
                _helper = new MongoHelper();
            return _helper;
        }

        public List<DatabaseModel> getAllDbs()
        {
            List<DatabaseModel> dbs = new List<DatabaseModel>();
            foreach (BsonDocument db in _client.ListDatabases().ToList())
                dbs.Add(BsonSerializer.Deserialize<DatabaseModel>(db));
            return dbs;
        }
        protected List<BsonDocument> GetListOfDocuments(string collectionName)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Empty;
            var documents = collection.Find(filter).ToList();

            return documents;
        }

        protected List<BsonDocument> GetListOfFilteredDocuments(string collectionName, string searchValue, string atribute)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(searchValue, atribute);
            var documents = collection.Find(filter).ToList();

            return documents;
        }

        protected void CreateDocument(string collectionName, BsonDocument document)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            collection.InsertOne(document);
        }
    }
}