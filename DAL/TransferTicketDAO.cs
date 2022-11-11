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

        private IMongoCollection<User> _userCollection;
        private IMongoCollection<Ticket> _ticketCollection;
        public TransferTicketDAO()
        {
            MongoClient mongoClient = new MongoClient("mongodb+srv://gg3:gg3@cluster0.mhym582.mongodb.net/test");
            IMongoDatabase database = mongoClient.GetDatabase("NoSqlProjectDatabase");
            _userCollection = database.GetCollection<User>("User");
            _ticketCollection = database.GetCollection<Ticket>("Ticket");
        }
        public List<User> GetListOfEmployees(int userType)
        {
            var filter = Builders<User>.Filter.Eq("UserType", userType);
            List<User> users = _userCollection.Find(filter).ToList();

            return users;
        }

        public void UpdateTicketedBy(int ticketid, int userId)
        {

            var filter = Builders<Ticket>.Filter.Eq("ID", ticketid);
            var update = Builders<Ticket>.Update.Set("ticketedBy", userId);
            _ticketCollection.UpdateOne(filter, update);
        }

        public void UpdateComment(int ticketid, string comment)
        {
            var filter = Builders<Ticket>.Filter.Eq("ID", ticketid);
            var update = Builders<Ticket>.Update.Set("Comment", comment);
            _ticketCollection.UpdateOneAsync(filter, update);
        }
    }
}
