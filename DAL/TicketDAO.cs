﻿using System;
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

        /*public List<Ticket> getTicketsByUserid(int id)
        {

        }*/


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

            return new Ticket(id, ticketedBy, reportedBy, subject, date, ticketType, priority, deadline, description, status);
        }
/*        public List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            var documents = GetListOfDocuments("Ticket");

            foreach (var doc in documents)
                tickets.Add(getTicket(doc));

            return tickets;
        }*/

        public List<Ticket> GetFilteredTicketByEmail(string filterEmail)
        {
            List<Ticket> tickets = new List<Ticket>();
            var documents = GetListOfFilteredDocuments("Ticket", "Email", filterEmail);

            foreach (var doc in documents)
                tickets.Add(getTicket(doc));

            return tickets;
        }

        public string CountTicketsperUser(int userId)
        {
            return executeMatchCountQuery("Ticket", "reportedBy", userId);

        }

    }
}
