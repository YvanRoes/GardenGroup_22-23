using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;

namespace DAL
{
    public class TicketDAO : MongoHelper
    {
        private Ticket getTicket(BsonDocument doc)
        {
           
                int id = (int)doc["ID"];
                int ticketedBy = (int)doc["ticketedBy"];
                int reportedBy = (int)doc["reportedBy"];
                string subject = (string)doc["subject"];
                DateTime date = (DateTime)doc["date"];
                TicketType ticketType = (TicketType)(int)doc["ticketType"];
                Priority priority = (Priority)(int)doc["priority"];
                Deadline deadline = (Deadline)(int)doc["deadline"];
                string description = (string)doc["description"];
                string status = (string)doc["status"];

                return new Ticket(id, ticketedBy, reportedBy, subject, date, ticketType, priority, deadline, description, getTicketStatusFromString(status));
            
        }
        public List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            var documents = GetListOfDocuments("Ticket");

            foreach (var doc in documents)
                tickets.Add(getTicket(doc));

            return tickets;
        }

        private TicketStatus getTicketStatusFromString(string status)
        {
            switch (status)
            {
                case "open" : return TicketStatus.open;
                case "waiting" : return TicketStatus.waiting;
                case "closed": return TicketStatus.closed;
                default : return TicketStatus.unknown;
            }
        }

        public string CountTicketsperUser(int userId)
        {
            return executeMatchCountQuery2("Ticket", "reportedBy", userId);

        }
        public List<Ticket> GetFilteredTicketByEmail(string filterEmail)
        {
            List<Ticket> tickets = new List<Ticket>();
            var documents = GetListOfFilteredDocuments("Ticket", "Email", filterEmail);

            foreach (var doc in documents)
                tickets.Add(getTicket(doc));

            return tickets;
        }
    }
}
