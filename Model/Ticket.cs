using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        private int _id;
        private int _ticketedBy;
        private int _reportedBy;
        private string _subject;
        private DateTime _date;
        private ticketType _ticketType;
        private Priority _priority;
        private Deadline _deadline;
        private string _description;


        public int get_id() { return _id; }
        public int get_ticketedBy() { return _ticketedBy; }
        public int get_reportedBy() { return _reportedBy; }
        public string get_subject() { return _subject; }
        public DateTime get_date() { return _date; }
        public ticketType get_ticketType() { return _ticketType; }
        public Priority get_priority() { return _priority; }
        public Deadline get_deadline() { return _deadline; }
        public string get_description() { return _description; }
    }
}
