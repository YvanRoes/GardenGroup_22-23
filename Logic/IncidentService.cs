using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic
{
    public class IncidentService
    {
        IncidentDAO IncidentDb;

        public IncidentService()
        {
            IncidentDb = new IncidentDAO();
        }
        public void AddIncident(Incident incident)
        {
            IncidentDb.AddIncident(incident);
        }
        
    }
}
