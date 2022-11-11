using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System.Collections;

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
            var Collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Empty;
            var Documents = Collection.Find(filter).ToList();

            return Documents;
        }

        protected List<BsonDocument> GetListOfFilteredDocuments(string collectionName, string field, string atribute)
        {
            var Collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(field, atribute);
            var Documents = Collection.Find(filter).ToList();

            return Documents;
        }

        public void CreateDocument(string collectionName, BsonDocument bdoc)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            collection.InsertOne(bdoc);
        }

        public void UpdateDocument(string collectionName, string filter, BsonDocument bdoc)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            collection.UpdateOne(filter, bdoc);
        }

        protected string executeMatchCountQuery(string collectionName, string field, int value)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);

            var pipelinestage1 = new BsonDocument
            {
                {"$match", new BsonDocument
                {
                    { field, value }
                } }
            };

            var pipelinestage2 = new BsonDocument
            {
                {"$count", "result" }
            };

            BsonDocument[] pipeline = new BsonDocument[]
            {
                pipelinestage1, pipelinestage2
            };

            var result = collection.Aggregate<BsonDocument>(pipeline).SingleOrDefault();

            if (result == null)
                return "NULL";

            
            return result.ToString();
        }
    }
}