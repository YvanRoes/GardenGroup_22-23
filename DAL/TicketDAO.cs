using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class ItemDAO : MongoHelper
    {
        public List<Ticket> GetAllTickets()
        {
            List<Ticket> list = new List<Ticket>();
            var doc = GetListOfDocuments("Ticket");
            doc.ForEach(t =>
            {
                int id = (int)t["ID"];
                int ticketedBy = (int)t["ticketedBy"];
                int reportedBy = (int)t["reportedBy"];
                string subject = (string)t["subject"];
                string date = (string)t["date"];
                TicketType ticketType = (TicketType)(int)t["ticketType"];
                Priority priority = (Priority)(int)t["priority"];
                Deadline deadline = (Deadline)(int)t["deadline"];
                string description = (string)t["description"];
                string status = (string)t["status"];

                list.Add(new Ticket(id, ticketedBy, reportedBy, subject, date, ticketType, priority, deadline, description, getTicketStatusFromString(status)));
            });
            return list;
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

        public int CountTicketsperUser(int userId)
        {
            return executeMatchCountQuery("Ticket", "reportedBy", userId);

        }
    }
}
