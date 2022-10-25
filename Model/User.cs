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
        private string _phone;
        private string _location;
        private UserType userType;

        public int get_id() { return _id; }
        public string get_name() { return _name; }
        public string get_email() { return _email; }
        public string get_phone() { return _phone; }
        public string get_location() { return _location; }
        public UserType getUserType() { return userType; }
    }
}
