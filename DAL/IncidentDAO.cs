using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;

namespace DAL
{
    public class IncidentDAO : MongoHelper
    {
        private Incident getIncident(BsonDocument doc)
        {

            int id = (int)doc["ID"];
            int reportedBy = (int)doc["reportedBy"];
            string subject = (string)doc["subject"];
            DateTime date = (DateTime)doc["date"];
            string description = (string)doc["description"];
            int status = (int)doc["status"];


            return new Incident(id, reportedBy, subject, date, description, (TicketStatus)status);

        }
        public List<Incident> GetAllIncidents()
        {
            List<Incident> incidents = new List<Incident>();
            var documents = GetListOfDocuments("Ticket");

            foreach (var doc in documents)
                incidents.Add(getIncident(doc));

            return incidents;
        }
        private TicketStatus getTicketStatusFromString(string status)
        {
            switch (status.ToLower())
            {
                case "resolved": return TicketStatus.resolved;
                case "unresolved": return TicketStatus.unresolved;
                case "inprogress": return TicketStatus.inProgress;
                default: return TicketStatus.unknown;
            }
        }
       
        public void AddIncident(Incident incident)
        {
            var document = new BsonDocument { { "ID", incident.get_id() }, {"reportedBy", incident.get_reportedBy()}, { "subject", incident.get_subject() }, {"date", incident.get_date() }, { "status", (int)incident.get_status() }, { "description", incident.get_description()} };
            CreateDocument("Ticket", document);
        }
    }
}
