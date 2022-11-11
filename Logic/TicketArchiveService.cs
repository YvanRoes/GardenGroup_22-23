using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MongoDB.Bson;

namespace Logic
{
    public class TicketArchiveService
    {
        private TicketArchiveDAO archivedb;

        public TicketArchiveService() => archivedb = new TicketArchiveDAO();
        public void AddTicketsToArchive(List<Ticket> tickets, int months)
        {
            List<BsonDocument> bdocs = new List<BsonDocument>();
            tickets.ForEach(ticket =>
            {
                //if not older than x months
                if (!(ticket.get_date() < DateTime.Today.AddMonths(-months)))
                    return;

                //create bson
                BsonDocument bdoc = new BsonDocument { { "ID", ticket.get_id()},
                {"ticketedBy", ticket.get_ticketedBy()}, {"reportedBy", ticket.get_reportedBy()},
                {"subject", ticket.get_subject()},{"date", ticket.get_date() }, {"ticketType", (int)ticket.get_ticketType()},
                {"priority", (int)ticket.get_priority() }, {"deadline", (int)ticket.get_deadline()},
                {"description", ticket.get_description()}, {"status", (int)ticket.get_status()}};
                bdocs.Add(bdoc);

                //delete tickets from main ticket collection
                TicketService ticketService = new TicketService();
                ticketService.DeleteTicket(ticket.get_id());
            });
            archivedb.addToArchive(bdocs);
        }
    }
}
