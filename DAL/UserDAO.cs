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

        private IMongoCollection<User> collection;
        public UserDAO()
        {
            MongoClient mongoClient = new MongoClient("mongodb+srv://gg3:gg3@cluster0.mhym582.mongodb.net/test");
            IMongoDatabase database = mongoClient.GetDatabase("NoSqlProjectDatabase");
            collection = database.GetCollection<User>("User");

        }
        private User getUser(BsonDocument doc)
        {
            int id = (int)doc["ID"];
            string name = doc["Name"].ToString();
            string email = doc["Email"].ToString();
            long phone = (long)doc["Phone"];
            int userType = (int)(doc["UserType"]);
            int location = (int)doc["Location"];
            string password = doc["Password"].ToString();

            return new User(id, name, email, phone, userType, location, password);
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            var documents = GetListOfDocuments("User");

            foreach (var doc in documents)
                users.Add(getUser(doc));

            return users;
        }
        public User GetUserByUsernameAndPassword(string email, string password)
        {
            var filter = Builders<User>.Filter.Eq(u => u._email, email) & Builders<User>.Filter.Eq(u => u._password, password);
            var user = collection.Find(filter).FirstOrDefault();

            return user;
        }

        public List<User> GetFilteredUserByEmail(string filterEmail)
        {
            List<User> users = new List<User>();
            var documents = GetListOfFilteredDocuments("User", "Email", filterEmail);

            foreach (var doc in documents)
                users.Add(getUser(doc));

            return users;
        }

        public void AddUser(User user)
        {
            var document = new BsonDocument { { "ID", getNewId() }, { "Name", user.get_name() }, { "Email", user.get_email() }, { "Phone", user.get_phone() }, { "Location", (int)user.get_location() }, { "UserType", (int)user.get_userType() }, { "Password", user.get_password() } };
            CreateDocument("User", document);
        }

        private int getNewId()
        {
            int id = 0;
            List<User> users = GetAllUsers();

            users.ForEach(user =>
            {
                if (user.get_id() > id)
                    id = user.get_id();
            });
            return id + 1;
        }
        private string getPassword(int id, string name)
        {
            string[] separateName = name.Split(' ');
            return id + separateName[0];
        }
        public int generateId()
        {
            return getNewId();
        }
        public string generatePassword(int id, string name)
        {
            return getPassword(id, name);
        }
    }
}

