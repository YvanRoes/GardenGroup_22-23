using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DAL
{
    public class TransferTicketDAO : MongoHelper
    {
        //Andy's Extra Functionality

        private IMongoCollection<User> collection;
        public TransferTicketDAO()
        {
            MongoClient mongoClient = new MongoClient("mongodb+srv://gg3:gg3@cluster0.mhym582.mongodb.net/test");
            IMongoDatabase database = mongoClient.GetDatabase("NoSqlProjectDatabase");
            collection = database.GetCollection<User>("User");
        }
        public List<User> GetListOfEmployees(int userType)
        {
            var filter = Builders<User>.Filter.Eq("UserType", userType);
            List<User> users = collection.Find(filter).ToList();

            return users;
        }

    }
}
