using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class TicketDAO : MongoHelper
    {

        //Yvan Roes
        public List<Ticket> getTickets()
        {
            IMongoCollection<Ticket> collection = database.GetCollection<Ticket>("Ticket");
            return collection.AsQueryable().ToList();
        }

        public List<Ticket> getOpenAndPendingTickets()
        {
            IMongoCollection<Ticket> collection = database.GetCollection<Ticket>("Ticket");
            List<Ticket> tickets = collection.Aggregate().Match(x => x._status == 1 || x._status == 2).ToList<Ticket>();
            return tickets;
        }

        public async Task<List<Ticket>> getTicketByStatusAsync(TicketStatus status) 
        {
            BsonDocument pipe  = new BsonDocument();
            if(status != TicketStatus.unknown)
                pipe.Add(new BsonDocument { { "status", (int)status } });

            IMongoCollection<Ticket> collection = database.GetCollection<Ticket>("Ticket");
            var query = collection.Aggregate()
                        .Match(pipe);
            var results = await query.ToListAsync();
            return results.AsQueryable().ToList();
        }

        public int getNewTicketId()
        {
            List<Ticket> tickets = getTickets();
            int max = 0;
            tickets.ForEach(t =>
            {
                if(t.get_id() > max)
                    max = t.get_id();
            });
            return max + 1;
        }

        //Aleks

        private Ticket getTicket(BsonDocument doc)
        {

            int id = (int)doc["ID"];
            int ticketedBy = (int)doc["ticketedBy"];
            int reportedBy = (int)doc["reportedBy"];
            string subject = (string)doc["subject"];
            DateTime date = DateTime.Now; //(DateTime)doc["date"];
            TicketType ticketType = (TicketType)(int)doc["ticketType"];
            Priority priority = (Priority)(int)doc["priority"];
            Deadline deadline = (Deadline)(int)doc["deadline"];
            string description = (string)doc["description"];
            TicketStatus status = (TicketStatus)(int)doc["status"];
            string comment = (string)doc["comment"];

            return new Ticket(id, ticketedBy, reportedBy, subject, date, ticketType, priority, deadline, description, status);
        }

        public List<Ticket> GetFilteredTicketsByUserId(int userId)
        {
            IMongoCollection<Ticket> collection = database.GetCollection<Ticket>("Ticket");

            //var filter = Builders<BsonDocument>.Filter.Eq("reportedBy", userId);
            var filter = Builders<Ticket>.Filter.Eq(ticket => ticket._reportedBy, userId);
            List<Ticket> filteredTickets = collection.Find(filter).ToList();

            return filteredTickets;
        }
        
        //Andy's 

        public string CountTicketsperUser(int userId)
        {
            string result = executeMatchCountQuery("Ticket", "reportedBy", userId);
            string nrOfTickets = "";

            if (result == "NULL")
                nrOfTickets = "0";

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsDigit(result[i]))
                    nrOfTickets += result[i];
            }

            return nrOfTickets;
        }

    }
}
