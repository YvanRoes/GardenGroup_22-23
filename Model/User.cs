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

        public int get_id() { return _id; }
        public string get_name() { return _name; }
        public string get_email() { return _email; }
        public long get_phone() { return _phone; }
        public Location get_location() { return _location; }
        public UserType get_userType() { return _userType; }

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
