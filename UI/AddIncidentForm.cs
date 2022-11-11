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
        User _loggedUser;
        Incident _reportedIncident;
        MainViewForm mainViewForm;

        //initializes the form for service desk employee
        public AddIncidentForm(User user, Incident incident)
        {
            InitializeComponent();
            _loggedUser = user;
            _reportedIncident = incident;
            fillInComboBoxes();
            SetStyleOfServiceDeskEmployeeForm();
            


        }

        //initializes the form for regular employee
        public AddIncidentForm(User user)
        {
            InitializeComponent();
            _loggedUser = user;
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
        private void SetStyleOfServiceDeskEmployeeForm()
        {
            labelDateTimeValue.Text = _reportedIncident.get_date().ToString();
            textBoxSubject.Text = _reportedIncident.get_subject();
            textBoxDescription.Text = _reportedIncident.get_description();

        }
        private void SetStyleOfRegularEmployeeForm()
        {
            labelDateTime.Visible = false;
            labelDateTimeValue.Visible = false;
            labelPriority.Visible = false;
            comboBox_Priority.Visible = false;
            labelDeadline.Visible = false;
            comboBox_Deadline.Visible = false;
            labelType.Visible = false;
            comboBox_IncidentType.Visible = false;
            labelDescription.Location = new Point(163, 296);
            textBoxDescription.Location = new Point(418, 296);

        }
        //Adds Incidents created by regular employees
        private void AddIncident()
        {
            try
            {
                int id = ticketService.getNewTicketId();
                string subject = textBoxSubject.Text;
                DateTime dateTime = DateTime.Now;
                string description = textBoxDescription.Text;
                Incident incident = new Incident(ticketService.getNewTicketId(), _loggedUser.get_id() , subject, dateTime, description, TicketStatus.unresolved);
                incidentService.AddIncident(incident);

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        private void AddTicket()
        {

            TicketType ticketType = (TicketType)Enum.Parse(typeof(TicketType), comboBox_IncidentType.SelectedItem.ToString());
            Priority priority = (Priority)Enum.Parse(typeof(Priority), comboBox_Priority.SelectedItem.ToString());
            Deadline deadline = (Deadline)Enum.Parse(typeof(Deadline), comboBox_Deadline.SelectedItem.ToString());


            Ticket ticket = new Ticket(_reportedIncident.get_id(),_loggedUser.get_id(),_reportedIncident.get_reportedBy(),_reportedIncident.get_subject(),_reportedIncident.get_date(),
                                       (int)ticketType,(int)priority,(int)deadline,_reportedIncident.get_description(),(int)TicketStatus.inProgress);
            ticketService.UpdateTicket(ticket);
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(_loggedUser.get_userType()==UserType.Employee)
            {
                AddIncident();
            }
            else
            {
                AddTicket();
            }
            this.Close();
            MainViewForm mainViewForm = new MainViewForm(_loggedUser);
            mainViewForm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            mainViewForm = new MainViewForm(_loggedUser);
            mainViewForm.Show();
        }
    }
}

