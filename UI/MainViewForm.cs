using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace UI
{
    public partial class MainViewForm : Form
    {
        private UserService _userService;
        private User _loggedUser;
        private TicketService _ticketService;
        private IncidentService _incidentService;
        public MainViewForm(User user)
        {
            InitializeComponent();
            start();
            this.Size = new Size(1060, 640);

            _userService = new UserService();
            _loggedUser = user;
            _ticketService = new TicketService();
            _incidentService = new IncidentService();

            if (_loggedUser.get_userType() != UserType.ServiceDesk)
                userManagementToolStripMenuItem.Enabled = false;
        }

        void start()
        {
            loadDashBoard();
            UserManagement_Pnl.Visible = false;
            TicketView_Pnl.Visible = false;
        }

        // Dashboard (Yvan)

        private void SwitchPanel(string name)
        {
            switch (name)
            {
                case "Dashboard":
                    UserManagement_Pnl.Visible = false;
                    TicketView_Pnl.Visible = false;
                    pnlDashBoard.Visible = true;
                    pnlDashBoard.Dock = DockStyle.Fill;
                    break;
                case "userManagement":
                    TicketView_Pnl.Visible = false;
                    pnlDashBoard.Visible = false;
                    UserManagement_Pnl.Visible = true;
                    UserManagement_Pnl.Dock = DockStyle.Fill;
                    break;
            }
        }

        private void loadDashBoard()
        {
            SwitchPanel("Dashboard");
            
            if(_loggedUser.get_userType() != UserType.ServiceDesk)
                _ = LoadServiceDeskEmployeeDashboardAsync();
        }

        private async Task LoadServiceDeskEmployeeDashboardAsync()
        {
            TicketService ticketService = new TicketService();
            List<Ticket> unresolvedTickets = await ticketService.getTicketsByStatusAsync(TicketStatus.unresolved);
            List<Ticket> inProgressTickets = await ticketService.getTicketsByStatusAsync(TicketStatus.inProgress);
            List<Ticket> resolvedTickets = await ticketService.getTicketsByStatusAsync(TicketStatus.resolved);

            List<Ticket> resolvedAndInProgressTickets = new List<Ticket>();
            resolvedAndInProgressTickets.AddRange(unresolvedTickets);
            resolvedAndInProgressTickets.AddRange(inProgressTickets);
            List<Ticket>[] ticketArr = ticketService.getTicketsBeforeAndPastDeadline(resolvedAndInProgressTickets);
            int withinDeadline = ticketArr[0].Count;
            int pastDeadline = ticketArr[1].Count;
            int totalResolvedInProgressUnresolved = unresolvedTickets.Count + inProgressTickets.Count + resolvedTickets.Count;
            //draw unresolved, inProgress, resolved
            ChartGraphicComponent.DrawPieChart(totalResolvedInProgressUnresolved, unresolvedTickets.Count, inProgressTickets.Count, resolvedTickets.Count, pnlChartWrapperMain);

            //draw unresolved and past deadline
            ChartGraphicComponent.DrawPieChart(withinDeadline + pastDeadline, withinDeadline, pastDeadline, pnlChartWrapperSecondary);

            //set component data tickets

            setGroupBoxData(unresolvedTickets.Count, inProgressTickets.Count, resolvedTickets.Count, withinDeadline, pastDeadline);
        }

        private void setGroupBoxData(int unresolvedTickets, int inProgressTickets, int resolvedTickets, int withinDeadline, int pastDeadline)
        {
            pbunResolved.BackColor = Color.FromArgb(224, 20, 76);
            pbInProgress.BackColor = Color.FromArgb(255, 178, 0);
            pbResolved.BackColor = Color.FromArgb(60, 207, 78);
            lblunResolved.Text = $"Unresolved: {unresolvedTickets}";
            lblInProgress.Text = $"In progress: {inProgressTickets}";
            lblResolved.Text = $"Resolved: {resolvedTickets}";

            //set component data ticket deadlines
            pbWithinDeadline.BackColor = Color.FromArgb(41, 52, 98);
            pbPastDeadline.BackColor = Color.FromArgb(214, 28, 78);
            lblWithinDeadline.Text = $"deadline: {withinDeadline}";
            lblPastDeadline.Text = $"Past deadline: {pastDeadline}";
        }

        private void DashBoardMenuItem_Click(object sender, EventArgs e)
        {
            loadDashBoard();
        }

        //User Management (Andy)

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadUserManagement();
        }

        private void loadUserManagement()
        {
            SwitchPanel("userManagement");

            FillUserManagementListView(_userService.GetAllUsers());

        }

        private void FillUserManagementListView(List<User> users)
        {
            User_lstView.Items.Clear();

            foreach (var user in users)
            {
                ListViewItem li = new ListViewItem(user.get_id().ToString());
                li.SubItems.Add(user.get_email());
                li.SubItems.Add(user.get_name());
                li.SubItems.Add(user.get_location().ToString());
                li.SubItems.Add(_userService.countTicketsperUser(user.get_id()));
                li.Tag = user;
                User_lstView.Items.Add(li);
            }
        }

        private void AddUser_btn_Click(object sender, EventArgs e)
        {
            AddUserViewForm AddUser = new AddUserViewForm();
            AddUser.ShowDialog();
            FillUserManagementListView(_userService.GetAllUsers());
        }

        private void FilterUsersByEmail_bttn_Click(object sender, EventArgs e)
        {
            string filterTxt = filter_txtbox.Text;
            List<User> users = new List<User>();

            if (filter_txtbox.Text == null || filter_txtbox.Text == "")
                users = _userService.GetAllUsers();
            else
                users = _userService.GetFilteredUsersByEmail(filterTxt);

            FillUserManagementListView(users);
        }

        private void TransferTicket_bttn_Click(object sender, EventArgs e)
        {
            Ticket selectedTicket = (Ticket)listView_Tickets.SelectedItems[0].Tag;

            TransferTicketForm transferTicketForm = new TransferTicketForm(selectedTicket);
            transferTicketForm.ShowDialog();

            loadTicketView();
        }

        private void listView_Tickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            TransferTicket_bttn.Enabled = true;
        }
        //Ticket View (Aleksandra)

        private void ticketManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTicketView();
        }

        private void loadTicketView()
        {
            pnlDashBoard.Visible = false;
            UserManagement_Pnl.Visible = false;
            TicketView_Pnl.Visible = true;
            TicketView_Pnl.Dock = DockStyle.Fill;

            if (_loggedUser.get_userType() == 0)
            {
                TransferTicket_bttn.Visible = false;
                label_overview.Text = "Incident Overview";
                button_CreateIncident.Text = "Create Incident";
                LoadTicketListViewForRegularEmployee();

            }
            else
            {
                TransferTicket_bttn.Enabled = false;
                label_overview.Text = "Ticket Overview";
                button_CreateIncident.Text = "Create Ticket";
                LoadTicketListViewForServiceDeskEmployee();
            }
        }

        private void LoadTicketListViewForRegularEmployee()
        {
            
            List<Ticket> filteredTickets = new List<Ticket>();
            listView_Tickets.Items.Clear();
            listView_Tickets.Visible = true;
            listView_ServiceDesk.Visible = false;
            filteredTickets = _ticketService.GetFilteredTicketsByUserId(_loggedUser.get_id());

            foreach (Ticket ticket in filteredTickets)
            {
                string[] output = { ticket.get_id().ToString(), ticket.get_reportedBy().ToString(), ticket.get_subject().ToString(), ticket.get_date().ToString(), ticket.get_status().ToString(), ticket.get_description() };
                ListViewItem list = new ListViewItem(output);
                list.Tag = ticket;
                listView_Tickets.Items.Add(list);
            }
        }

        private void LoadTicketListViewForServiceDeskEmployee()
        {

            List<Ticket> allTickets = _ticketService.getTickets();
            listView_Tickets.Visible = false;
            listView_ServiceDesk.Visible = true;
            listView_ServiceDesk.Items.Clear();
            foreach (Ticket ticket in allTickets)
            {
                string[] output = { ticket.get_id().ToString(), ticket.get_reportedBy().ToString(), ticket.get_subject().ToString(), ticket.get_date().ToString(), ticket.get_status().ToString(), ticket._description, ticket.get_priority().ToString(), ticket.get_deadline().ToString()  };
                ListViewItem list = new ListViewItem(output);
                list.Tag = ticket;
                listView_ServiceDesk.Items.Add(list);
            }
        }

        private void button_CreateIncident_Click_1(object sender, EventArgs e)
        {
            AddIncidentForm addIncidentForm;
            int id;
            Incident selectedIncident;
            List<Incident> incidents = _incidentService.getAllIncidents();

            this.Close();
            if (_loggedUser.get_userType() == 0)
            {
                addIncidentForm = new AddIncidentForm(_loggedUser);
                addIncidentForm.Show();
            }
            else
            {
                
                    id = int.Parse(listView_ServiceDesk.SelectedItems[0].Text);
                    foreach (Incident incident in incidents)
                    {

                        if (incident.get_id() == id)
                        {
                            selectedIncident = new Incident(incident.get_id(), incident.get_reportedBy(), incident.get_subject(), incident.get_date(),  incident.get_description(), incident.get_status());
                            addIncidentForm = new AddIncidentForm(_loggedUser, selectedIncident);
                            addIncidentForm.Show();
                        }
                    }
                
            }
        }

        private void button_PrioritySort_Click(object sender, EventArgs e)
        {
            List<Ticket> sortedTickets = _ticketService.getTicketSortedByPriority();
            listView_Tickets.Visible = false;
            listView_ServiceDesk.Visible = true;
            listView_ServiceDesk.Items.Clear();
            foreach (Ticket ticket in sortedTickets)
            {
                string[] output = { ticket.get_id().ToString(), ticket.get_reportedBy().ToString(), ticket.get_subject().ToString(), ticket.get_date().ToString(), ticket.get_status().ToString(), ticket._description, ticket.get_priority().ToString(), ticket.get_deadline().ToString() };
                ListViewItem list = new ListViewItem(output);
                list.Tag = ticket;
                listView_ServiceDesk.Items.Add(list);
            }

        }

        private void button_deleteTicket_Click(object sender, EventArgs e)
        {
            int id = int.Parse(listView_ServiceDesk.SelectedItems[0].Text);
            _ticketService.DeleteTicket(id);
            LoadTicketListViewForServiceDeskEmployee();
        }
    }
}
