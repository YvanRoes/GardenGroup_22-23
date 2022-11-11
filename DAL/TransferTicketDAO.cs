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
        public List<User> GetListOfEmployees(Departments department)
        {
            var filter = Builders<User>.Filter.Eq("UserType", (int)department);
            List<User> users = _userCollection.Find(filter).ToList();

            return users;
        }

        public void UpdateTicketedBy(Ticket ticket, User user)
        {
            var filter = Builders<Ticket>.Filter.Eq("ID", ticket.get_id());
            var update = Builders<Ticket>.Update.Set("ticketedBy", user.get_id());
            _ticketCollection.UpdateOne(filter, update);
        }

        public void UpdateStatusToTransfer(Ticket ticket)
        {
            var filter = Builders<Ticket>.Filter.Eq("ID", ticket.get_id());
            var update = Builders<Ticket>.Update.Set("status", (int)TicketStatus.transfered);
            _ticketCollection.UpdateOne(filter, update);
        }
        public void CreateTransferDetailComment(Ticket ticket, Departments department, User user, User loggedUser, string inputComment)
        {
            string comment;

            if (department == Departments.ServiceDesk)
                comment = $"Ticket transfered to Employee {user} By {loggedUser} " + inputComment;
            else
                comment = $"Ticket transfered to Department {department} By {loggedUser} " + inputComment;

            var filter = Builders<Ticket>.Filter.Eq("ID", ticket.get_id());
            var update = Builders<Ticket>.Update.Set("TransferDetails", comment);

            _ticketCollection.UpdateOneAsync(filter, update);
        }

        public string GetTransferDetailCommentById(Ticket ticktet)
        {

            var filter = Builders<Ticket>.Filter.Eq("ID", ticktet.get_id());
            var field = Builders<Ticket>.Projection.Include("TransferDetails");
            var result = _ticketCollection.Find(filter).Project<Ticket>(field).FirstOrDefault();

            return result.get_transferDetails();
        }
    }
}
