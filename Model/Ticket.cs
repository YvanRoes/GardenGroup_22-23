using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Model
{
    public class Ticket
    {

        [BsonId] private ObjectId objId;
        [BsonElement("ID")] private int _id;
        [BsonElement("ticketedBy")] public int ticketedBy;
        [BsonElement("reportedBy")] public int reportedBy;
        [BsonElement("subject")] private string _subject;
        [BsonElement("date")] private DateTime _date;
        [BsonElement("ticketType")] private int _ticketType;
        [BsonElement("priority")] private int _priority;
        [BsonElement("deadline")] private int _deadline;
        [BsonElement("description")] private string _description;
        [BsonElement("status")] private int _status;
        [BsonElement("TransferDetails")] private string _transferDetails;

        public int get_id() { return _id; }
        public int get_ticketedBy() { return ticketedBy; }
        public int get_reportedBy() { return reportedBy; }
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
                case 1: return TicketStatus.unresolved;
                case 2: return TicketStatus.inProgress;
                case 3: return TicketStatus.resolved;
                case 4: return TicketStatus.transfered;
                default: return TicketStatus.unknown;
            }
        }
        public string get_transferDetails() { return _transferDetails; }

        public Ticket(int _id, int _ticketedBy, int _reportedBy, string _subject, DateTime _date, int _ticketType, int _priority, int _deadline, string _description, int _status)
        {
            this._id = _id;
            this.ticketedBy = _ticketedBy;
            this.reportedBy = _reportedBy;
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
            this.ticketedBy = _ticketedBy;
            this.reportedBy = _reportedBy;
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
