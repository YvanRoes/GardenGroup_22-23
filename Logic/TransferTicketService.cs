using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace Logic
{
    public class TransferTicketService
    {
        //Andy' Extra Functionality

        TransferTicketDAO _transferTicketDAO;

        public TransferTicketService()
        {
            _transferTicketDAO = new TransferTicketDAO();
        }

        public List<User> GetListOfUsers(int userType)
        {
            return _transferTicketDAO.GetListOfEmployees(userType);
        }

        public void CreateTransferDetailComment(Ticket ticket, Departments department, User user, User loggedUser, string inputComment)
        {
            _transferTicketDAO.CreateTransferDetailComment(ticket, department, user, loggedUser, inputComment);
        }

        public void UpdateStatusToTransferred(int ticketId)
        {
            _transferTicketDAO.UpdateStatus(ticketId);
        }
        public void UpdateTicketedBy(int ticketId, int userId)
        {
            _transferTicketDAO.UpdateTicketedBy(ticketId, userId);
        }
        public string GetTransferDetails(Ticket ticket)
        {
            return _transferTicketDAO.GetTransferDetailCommentById(ticket);

        }
    }
}
