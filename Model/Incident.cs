using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Incident
    {
        private int _id;
        private int _reportedBy;
        private string _subject;
        private DateTime _date;
        private TicketType _ticketType;
        private string _description;
        private TicketStatus _status;


        public int get_id() { return _id; }
        public int get_reportedBy() { return _reportedBy; }
        public string get_subject() { return _subject; }
        public DateTime get_date() { return _date; }
        public TicketType get_ticketType() { return _ticketType; }
        public string get_description() { return _description; }
        public TicketStatus get_status() { return _status; }

        public Incident(int _id,  int _reportedBy, string _subject, DateTime _date, TicketType _ticketType, string _description, TicketStatus _status)
        {
            this._id = _id;
            this._reportedBy = _reportedBy;
            this._subject = _subject;
            this._date = _date;
            this._ticketType = _ticketType;
            this._description = _description;
            this._status = _status;
        }
    }
}
