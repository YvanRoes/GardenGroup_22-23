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
    public partial class TicketViewForm : Form
    {
        TicketService ticketService = new TicketService();
        User loggedInUser = new User(9000, "John Snow", "JohnSnow", 78903142, 0, 2, "1");


        public TicketViewForm()
        {
            InitializeComponent();
            if (loggedInUser.get_userType() == UserType.Employee)
            {
                LoadTicketListViewForRegularEmployee();
            }
            else
            {
                LoadTicketListViewForServiceDeskEmployee();
            }

        }

        private void LoadTicketListViewForRegularEmployee()
        {


            List<Ticket> allTickets = ticketService.getTickets();
            foreach (Ticket ticket in allTickets)
            {
                string[] output = { ticket.get_id().ToString(), ticket.get_reportedBy().ToString(), ticket.get_subject().ToString(), ticket.get_date().ToString(), ticket.get_status().ToString() };
                ListViewItem list = new ListViewItem(output);
                list.Tag = Id;
                listView_Tickets.Items.Add(list);
            }
        }

        private void LoadTicketListViewForServiceDeskEmployee()
        {
            List<Ticket> filteredTickets = new List<Ticket>();
            filteredTickets = ticketService.GetFilteredTicketsByEmail(loggedInUser.get_email());
           // FillListView(users);

            List<Ticket> allTickets = ticketService.getTickets();
            foreach (Ticket ticket in allTickets)
            {
                string[] output = { ticket.get_id().ToString(), ticket.get_reportedBy().ToString(), ticket.get_subject().ToString(), ticket.get_date().ToString(), ticket.get_status().ToString() };
                ListViewItem list = new ListViewItem(output);
                list.Tag = Id;
                listView_Tickets.Items.Add(list);
            }
        }
        private void button_CreateIncident_Click(object sender, EventArgs e)
        {

            AddIncidentForm addIncidentForm = new AddIncidentForm();
            addIncidentForm.ShowDialog();
        }

        private void TicketViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}