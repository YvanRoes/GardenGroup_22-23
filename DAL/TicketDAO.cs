using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class TicketDAO : MongoHelper
    {
        IMongoCollection<Ticket> collection;

        //Yvan Roes
        public List<Ticket> getTickets()
        {
            collection = database.GetCollection<Ticket>("Ticket");
            return collection.AsQueryable().ToList();
        }

        public List<Ticket> getOpenAndPendingTickets()
        {
            List<Ticket> tickets = collection.Aggregate().Match(x => (int)x.get_status() == 1 || (int)x.get_status() == 2).ToList<Ticket>();
            return tickets;
        }

        public async Task<List<Ticket>> getTicketByStatusAsync(TicketStatus status) 
        {
            BsonDocument pipe  = new BsonDocument();
            if(status != TicketStatus.unknown)
                pipe.Add(new BsonDocument { { "status", (int)status } });

            var query = collection.Aggregate()
                        .Match(pipe);
            var results = await query.ToListAsync();
            return results.AsQueryable().ToList();
        }

        public List<Ticket> getTicketSortedByPriority()
        {
            List<Ticket> tickets = collection.Aggregate().Sort("{priority: -1}").ToList<Ticket>();
            return tickets;
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

        public List<Ticket> GetFilteredTicketsByUserId(int userId)
        {
            //var filter = Builders<BsonDocument>.Filter.Eq("reportedBy", userId);
            var filter = Builders<Ticket>.Filter.Eq(ticket => ticket.get_reportedBy(), userId);
            List<Ticket> filteredTickets = collection.Find(filter).ToList();

            return filteredTickets;
        }

        public void UpdateTicket(Ticket ticket)
        {
            var filter = Builders<Ticket>.Filter.Eq("ID", ticket.get_id());

                var update = Builders<Ticket>.Update.Set("ID" , ticket.get_id()).Set("ticketedBy", ticket.get_ticketedBy()).Set("reportedBy", ticket.get_reportedBy()).Set("subject", ticket.get_subject())
                .Set("date", ticket.get_date()).Set("ticketType",(int)ticket.get_ticketType()).Set("priority",(int)ticket.get_priority()).Set("deadline", (int)ticket.get_deadline())
                .Set("description",ticket.get_description()).Set("status",(int)ticket.get_status());

            collection.UpdateOneAsync(filter, update);

        }
        public void DeleteDocument(int id)
        {
            var filter = Builders<Ticket>.Filter.Eq("ID" ,id);
            
            var personDeleteResult = collection.DeleteOne(filter);
        }

        public void UpdateTicketStatus(int ticketid, int status)
        {

            var filter = Builders<Ticket>.Filter.Eq("ID", ticketid);
            var update = Builders<Ticket>.Update.Set("status", status);
            collection.UpdateOne(filter, update);
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
