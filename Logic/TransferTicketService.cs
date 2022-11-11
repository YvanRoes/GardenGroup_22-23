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

        public List<User> GetListOfUsers(Departments department)
        {
            return _transferTicketDAO.GetListOfEmployees(department);
        }

        public void CreateTransferDetailComment(Ticket ticket, Departments department, User user, User loggedUser, string inputComment)
        {
            _transferTicketDAO.CreateTransferDetailComment(ticket, department, user, loggedUser, inputComment);
        }

        public void UpdateStatusToTransferred(Ticket ticket)
        {
            _transferTicketDAO.UpdateStatusToTransfer(ticket);
        }
        public void UpdateTicketedBy(Ticket ticket, User user)
        {
            _transferTicketDAO.UpdateTicketedBy(ticket, user);
        }
        public string GetTransferDetails(Ticket ticket)
        {
            return _transferTicketDAO.GetTransferDetailCommentById(ticket);

        }
    }
}
