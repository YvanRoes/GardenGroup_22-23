using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Model
{
    public class Ticket
    {
        private int _id;
        private int _ticketedBy;
        private int _reportedBy;
        private string _subject;
        private DateTime _date;
        private TicketType _ticketType;
        private Priority _priority;
        private Deadline _deadline;
        private string _description;
        private Status _status;


        public int get_id() { return _id; }
        public int get_ticketedBy() { return _ticketedBy; }
        public int get_reportedBy() { return _reportedBy; }
        public string get_subject() { return _subject; }
        public DateTime get_date() { return _date; }
        public TicketType get_ticketType() { return _ticketType; }
        public Priority get_priority() { return _priority; }
        public Deadline get_deadline() { return _deadline; }
        public string get_description() { return _description; }
        public Status get_status() { return _status; }


        //load on cmMapCreator
        [BsonConstructor]
        public Ticket(int _id, int _ticketedBy, int _reportedBy, string _subject, DateTime _date, int _ticketType, int _priority, int _deadline, string _description, Status status)
        {
            this._id = _id;
            this._ticketedBy = _ticketedBy;
            this._reportedBy = _reportedBy;
            this._subject = _subject;
            this._date = _date;
            this._ticketType = (TicketType)_ticketType;
            this._priority = (Priority)_priority;
            this._deadline = (Deadline)_deadline;
            this._description = _description;
            this._status = status;
        }

        public Ticket(int _id, int _ticketedBy, int _reportedBy, string _subject, DateTime _date, TicketType _ticketType, Priority _priority, Deadline _deadline, string _description, Status status)
        {
            this._id = _id;
            this._ticketedBy = _ticketedBy;
            this._reportedBy = _reportedBy;
            this._subject = _subject;
            this._date = _date;
            this._ticketType = _ticketType;
            this._priority = _priority;
            this._deadline = _deadline;
            this._description = _description;
            this._status = status;
        }

    }
}
