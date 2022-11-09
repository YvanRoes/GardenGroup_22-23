using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Model
{
    public class Ticket
    {

        [BsonId] public ObjectId objId;
        [BsonElement("ID")] public int _id;
        [BsonElement("ticketedBy")] public int _ticketedBy;
        [BsonElement("reportedBy")] public int _reportedBy;
        [BsonElement("subject")] public string _subject;
        [BsonElement("date")] public DateTime _date;
        [BsonElement("ticketType")] public int _ticketType;
        [BsonElement("priority")] public int _priority;
        [BsonElement("deadline")] public int _deadline;
        [BsonElement("description")] public string _description;
        [BsonElement("status")] public int _status;


        public int get_id() { return _id; }
        public int get_ticketedBy() { return _ticketedBy; }
        public int get_reportedBy() { return _reportedBy; }
        public string get_subject() { return _subject; }
        public DateTime get_date() { return _date; }
        public TicketType get_ticketType() { return (TicketType)_ticketType; }
        public Priority get_priority() { return (Priority)_priority; }
        public Deadline get_deadline() { return (Deadline)_deadline; }
        public string get_description() { return _description; }
        public TicketStatus get_status()
        {
            switch (_status)
            {
                case 1: return TicketStatus.open;
                case 2: return TicketStatus.waiting;
                case 3: return TicketStatus.closed;
                default: return TicketStatus.unknown;
            }
        }

        public Ticket(int _id, int _ticketedBy, int _reportedBy, string _subject, DateTime _date, int _ticketType, int _priority, int _deadline, string _description, int _status)
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
            this._status = _status;
        }

        public Ticket(int _id, int _ticketedBy, int _reportedBy, string _subject, DateTime _date, TicketType _ticketType, Priority _priority, Deadline _deadline, string _description, TicketStatus _status)
        {
            this._id = _id;
            this._ticketedBy = _ticketedBy;
            this._reportedBy = _reportedBy;
            this._subject = _subject;
            this._date = _date;
            this._ticketType = (int)_ticketType;
            this._priority = (int)_priority;
            this._deadline = (int)_deadline;
            this._description = _description;
            this._status = (int)_status;
        }
    }
}
