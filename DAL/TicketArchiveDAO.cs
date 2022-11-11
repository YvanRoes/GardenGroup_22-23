using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{ 
    public class TicketArchiveDAO
    {

        protected static MongoClient _client;
        protected IMongoDatabase database;

        public TicketArchiveDAO()
        {
            _client = new MongoClient("mongodb+srv://gg3:gg3@cluster0.mhym582.mongodb.net/?retryWrites=true&w=majority"); 
            database = _client.GetDatabase("NoSqlTicketArchive");
        }

        public void addToArchive(List<BsonDocument> bdocs) => bdocs.ForEach(bdoc => addDocumentToCollection(bdoc));

        private void addDocumentToCollection(BsonDocument bdoc)
        {
            var collection = database.GetCollection<BsonDocument>("TicketArchive");
            collection.InsertOne(bdoc);
        }
    }
}
