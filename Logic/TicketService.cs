using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class TicketService
    {
        TicketDAO ticketDb;

        public TicketService()
        {
            ticketDb = new TicketDAO();
        }

        public List<Ticket> GetAllTickets()
        {
            return ticketDb.GetAllTickets();
        }
        public Priority getTicketPriorityFromString(string priority)
        {
            switch (priority.ToLower())
            {
                case "high": return Priority.high;
                case "low": return Priority.low;
                case "normal": return Priority.normal;
                default: return Priority.normal;
            }
        }

        public List<Ticket> GetFilteredTicketsByEmail(string filterEmail)
        {
            return ticketDb.GetFilteredTicketByEmail(filterEmail);
        }
    }


}
