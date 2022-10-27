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
    }
}
