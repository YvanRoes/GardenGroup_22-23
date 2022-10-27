﻿using System;
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

        public void AddUser(User user)
        {
            userDb.AddUser(user);
        }
    }
}
