using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;
using DAL;

namespace UI
{
    public partial class AddIncidentForm : Form
    {
        TicketService ticketService = new TicketService();
        IncidentService incidentService = new IncidentService();
        User loggedInUser = new User(9000, "John Snow", "JohnSnow", 78903142, 0, 2, "1");
        public AddIncidentForm()
        {
            InitializeComponent();
            fillInComboBoxes();
            SetStyleOfRegularEmployeeForm();
        }

        private void fillInComboBoxes()
        {
            comboBox_Priority.Items.Clear();
            comboBox_Deadline.Items.Clear();
            comboBox_IncidentType.Items.Clear();
            foreach (int index in Priority.GetValues(typeof(Priority)))
            {
                comboBox_Priority.Items.Add((Priority)index);
            }

            foreach (int index in Deadline.GetValues(typeof(Deadline)))
            {
                comboBox_Deadline.Items.Add((Deadline)index);
            }

            foreach (int index in TicketType.GetValues(typeof(TicketType)))
            {
                comboBox_IncidentType.Items.Add((TicketType)index);
            }

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void labelReportedBy_Click(object sender, EventArgs e)
        {

        }

        private void SetStyleOfRegularEmployeeForm()
        {
            labelDateTime.Visible = false;
            labelDateTimeValue.Visible = false;
            labelReportedBy.Visible = false;
            comboBox_ReportedBy.Visible = false;
            comboBox_Deadline.Text = Deadline.deadline3.ToString();
            labelPriority.Visible = false;
            comboBox_Priority.Visible = false;
            labelDeadline.Visible = false;
            comboBox_Deadline.Visible = false;
            labelDescription.Location = new Point(163, 296);
            textBoxDescription.Location = new Point(418, 296);

        }
        //Adds Incidents created by regular employees
        private void AddIncident()
        {
            try
            {
                int id = ticketService.generateId();
                string subject = textBoxSubject.Text;
                DateTime dateTime = DateTime.Now;
                TicketType ticketType = (TicketType)Enum.Parse(typeof(TicketType), comboBox_IncidentType.SelectedItem.ToString());
                string description = textBoxDescription.Text;
                //napravi ticketedBy da e id-to na current usera
                Incident incident = new Incident(id, loggedInUser.get_id() , subject, dateTime, ticketType, description, TicketStatus.waiting);
                incidentService.AddIncident(incident);

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            AddIncident();
        }
    }
}

