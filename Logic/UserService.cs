using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class UserService
    {
        UserDAO userDb;
        TicketDAO ticketDb; 

        public UserService()
        {
            userDb = new UserDAO();   
        }

        public List<User> GetAllUsers()
        {
            return userDb.GetAllUsers();
        }

        public List<User> GetFilteredUsersByEmail(string filterEmail)
        {
            return userDb.GetFilteredUserByEmail(filterEmail);
        }

        public int generateId()
        {
            return userDb.generateId();
        }
        public string generatePassword(int id, string name)
        {
            return userDb.generatePassword(id, name);
        }
        public void addNewUser(User user)
        {
            userDb.AddUser(user);
        }
        public int countTicketsperUser(int userId)
        {
            ticketDb = new TicketDAO();
            return ticketDb.CountTicketsperUser(userId);
        }
    }
}
