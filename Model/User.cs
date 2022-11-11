using MongoDB.Bson;
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
        [BsonId] public ObjectId ObjectId;
        [BsonElement("ID")] public int _id;
        [BsonElement("Name")] public string _name;
        [BsonElement("Email")] public string _email;
        [BsonElement("Phone")] public long _phone;
        [BsonElement("Location")] public int _location;
        [BsonElement("UserType")] public int _userType;
        [BsonElement("Password")][BsonIgnoreIfNull] public string _password;

        //private int _id;
        //private string _name;
        //private string _email;
        //private long _phone;
        //private int _location;
        //private int _userType;
        //private string _password;


        public int get_id() { return _id; }
        public string get_name() { return _name; }
        public string get_email() { return _email; }
        public long get_phone() { return _phone; }
        public Location get_location() { return (Location)_location; }
        public UserType get_userType() { return (UserType)_userType; }
        public string get_password() { return _password; }

        public User(int id, string name, string email, long phone, int usertype, int location, string password)
        {
            _id = id;
            _name = name;
            _email = email;
            _phone = phone;
            _userType = usertype;
            _location = location;
            _password = password;

        }

        public override string ToString()
        {
            return $"{this._name} ({this._id})";
        }
    }
}
