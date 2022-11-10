using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Model
{
    [BsonIgnoreExtraElements]
    public class User
    {
        private int _id;
        private string _name;
        private string _email;
        private long _phone;
        private Location _location;
        private UserType _userType;
        private string _password;
        [BsonId]
        public ObjectId ObjectId { get; set; }

        [BsonElement("ID")]
        public int Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Email")]
        [BsonIgnoreIfNull]
        public string Email { get; set; }


        [BsonElement("Phone")]
        public long Phone { get; set; }


        [BsonElement("Location")]
        public Location Location { get; set; }


        [BsonElement("UserType")]
        public UserType UserType { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        public User(int id, string name, string email, long phone, int usertype, int location)
        {
            _id = id;
            _name = name;
            _email = email;
            _phone = phone;
            _userType = (UserType)usertype;
            _location = (Location)location;

        }
    }
}
