using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class TicketService
    {
        TicketDAO ticketDB; 

        public TicketService()
        {
            ticketDB = new TicketDAO();
        }

        public List<Ticket> getAllTickets()
        {
            return ticketDB.getTickets();
        }


    }
}
