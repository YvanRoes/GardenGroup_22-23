﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB.Bson;

namespace Logic
{
    public class TicketService
    {
        TicketDAO ticketDB; 

        public TicketService()
        {
            ticketDB = new TicketDAO();
        }
/*        public List<Ticket> GetAllTickets()
        {
            return ticketDB.GetAllTickets();
        }*/

        public List<Ticket> GetFilteredTicketsByUserId(int userId)
        {
            return ticketDB.GetFilteredTicketsByUserId(userId);
        }

        public List<Ticket> getTickets() => ticketDB.getTickets();

        public List<Ticket> getOpenAndPendingTickets() => ticketDB.getOpenAndPendingTickets();  

        public async Task<List<Ticket>> getTicketsByStatusAsync(TicketStatus status) => await ticketDB.getTicketByStatusAsync(status);

        public List<Ticket>[] getTicketsBeforeAndPastDeadline()
        {
            List<Ticket> unfilteredTickets = getTickets();
            List<Ticket> pastDeadlinetickets = new List<Ticket>();
            List<Ticket> beforeDeadlineTickets = new List<Ticket>();
            unfilteredTickets.ForEach(ticket =>
            {
                //if deadline passed add to passedDeadline list else add to beforeDeadline
                DateTime deadline = ticket.get_date().AddDays((int)ticket.get_deadline());
                if (deadline > DateTime.Now)
                    pastDeadlinetickets.Add(ticket);
                beforeDeadlineTickets.Add(ticket);

            });
            return new List<Ticket>[] { beforeDeadlineTickets,pastDeadlinetickets};
        }
        public void CreateTickets()
        {
            for(int i = 0; i < 50; i++)
            {
                UserService userService = new UserService();
                int max = userService.getNewID();
                int id = ticketDB.getNewTicketId();
                int ticketedBy = new Random().Next(1000, max);
                int reportedBy = new Random().Next(1000, max);
                string subject = "Some Subject";
                DateTime date = DateTime.Now;
                int ticketType = new Random().Next(1, 5);
                int priority = new Random().Next(1, 4);
                int deadline = new Random().Next(1, 4);
                string description = "Some desscription about the subject";
                int status = new Random().Next(1, 5);

                BsonDocument bdoc = new BsonDocument { { "ID", id},
                {"ticketedBy", ticketedBy }, {"reportedBy", reportedBy},
                {"subject", subject }, {"ticketType", ticketType},
                {"priority", priority }, {"deadline", deadline},
                {"description", description}, {"status", status}};
                ticketDB.CreateDocument("Ticket", bdoc);
            }
            
        }
        
        public int getNewTicketId()
        {
            return ticketDB.getNewTicketId();
        }
        
        public void UpdateTicket(Ticket ticket)
        {
            ticketDB.UpdateTicket(ticket);
        }

    }
}
