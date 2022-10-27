using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using DAL;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TicketService
    {
        TicketDao ticketDb;

        public TicketService()
        {
            ticketDb = new TicketDao();
        }

        public List<Ticket> GetAllTickets()
        {
            return ticketDb.GetAllTickets();
        }
    }
}
