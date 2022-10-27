using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TicketDao : MongoHelper
    {
        public List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            var document = GetListOfDocuments("Ticket");

            foreach (var info in document)
            {
                int id = (int)info["ID"];
                int ticketedBy = (int)info["ticketedBy"];
                int reportedBy = (int)info["reportedBy"];
                string subject = info["subject"].ToString();
                TicketType ticketType = (TicketType)Enum.Parse(typeof(TicketType), info["ticketType"].ToString());
                Priority priority = (Priority)Enum.Parse(typeof(Priority), info["priority"].ToString());
                Deadline deadline = (Deadline)Enum.Parse(typeof(Deadline), info["deadline"].ToString());
                DateTime date = (DateTime)info["date"];
                string description = info["description"].ToString();
                Status status = (Status)Enum.Parse(typeof(Status), info["status"].ToString());
                
                Ticket ticket = new Ticket(id, ticketedBy, reportedBy, subject, DateTime.Today, ticketType, priority, deadline, description,status);
                tickets.Add(ticket);
            }
           
            return tickets;
        }

        //public String GetNameByID(int UserId)
        //{

        //}

    }
}