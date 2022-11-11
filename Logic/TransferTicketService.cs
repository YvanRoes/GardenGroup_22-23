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
        TransferTicketDAO _transferTicketDAO;

        public TransferTicketService()
        {
            _transferTicketDAO = new TransferTicketDAO();
        }

        public List<User> GetListOfUsers(int userType)
        {
            return _transferTicketDAO.GetListOfEmployees(userType);
        }

        public void UpdateComment(int ticketId, string comment)
        {
            _transferTicketDAO.UpdateComment(ticketId, comment);
        }

        public void UpdateTicketedBy(int ticketId, int userId)
        {
            _transferTicketDAO.UpdateTicketedBy(ticketId, userId);
        }
    }
}
