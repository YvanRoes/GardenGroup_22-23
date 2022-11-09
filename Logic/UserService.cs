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

        public int getNewID()
        {
            int id = 0;
            List<User> users = userDb.GetAllUsers();
            users.ForEach(user =>
            {
                if (user.get_id() > id)
                    id = user.get_id();
            });
            return id + 1;
        }
        public User GetUserByNameAndPassword(string username, string passowrd)
        {
            User user = userDb.GetUserByNameAndPassword(username,passowrd);
            return user;
        }
    }
}
