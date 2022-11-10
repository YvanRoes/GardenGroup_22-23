using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private int _id;
        private string _name;
        private string _email;
        private long _phone;
        private Location _location;
        private UserType _userType;
        private string _password;

        public int get_id() { return _id; }
        public string get_name() { return _name; }
        public string get_email() { return _email; }
        public long get_phone() { return _phone; }
        public Location get_location() { return _location; }
        public UserType get_userType() { return _userType; }
        public string get_password() { return _password; }
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

        public User(int id, string name, string email, long phone, int usertype, int location, string password)
        {
            _id = id;
            _name = name;
            _email = email;
            _phone = phone;
            _userType = (UserType)usertype;
            _location = (Location)location;
            _password = password;

        }
    }
}
