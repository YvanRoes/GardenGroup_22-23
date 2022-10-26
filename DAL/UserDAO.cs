using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace DAL
{
    public class UserDAO : MongoHelper
    {
        //public User GetUser()
        //{
        //    return new User()
        //    {
        //        Id = 0,
        //        Name = "",
        //        Password = "",
        //        Email = "",
        //        Phone = 0,
        //        UserType = 0,
        //        Location = 0,
        //    };
        //}

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            var document = GetListOfDocuments("User");

            foreach (var info in document)
            {
                int id = (int)info["ID"];
                string name = info["Name"].ToString();
                string email = info["Email"].ToString();
                long phone = (long)info["Phone"];
                int userType = (int)(info["UserType"]);
                int location = (int)info["Location"];
                
                User u = new User(id, name, email, phone, userType, location);
                users.Add(u);
            }

                return users;
        }

        public List<User> GetfilteredUser()
        {
            List<User> users = new List<User>();
            //I have to fix the attribute change back to string
            var document = GetListOfFilteredDocuments("User", "Location", 1);

            foreach (var info in document)
            {
                int id = (int)info["ID"];
                string name = info["Name"].ToString();
                string email = info["Email"].ToString();
                long phone = (long)info["Phone"];
                int userType = (int)(info["UserType"]);
                int location = (int)info["Location"];

                User u = new User(id, name, email, phone, userType, location);
                users.Add(u);
            }

            return users;
        }
    }
}

