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
            this.Size = new Size(1060, 640);

            _userService = new UserService();
            _loggedUser = user;
            _ticketService = new TicketService();
            _incidentService = new IncidentService();

            start();

            if (_loggedUser.get_userType() != UserType.ServiceDesk)
            {
                userManagementToolStripMenuItem.Enabled = false;
                btnArchive.Visible = false;
            }
        }

        public MainViewForm()
        {
            InitializeComponent();
            this.Size = new Size(1060, 640);

            _userService = new UserService();
            _loggedUser = new User(1000, "John Snow", "JohnSnow", 78903142, 0, 2, "1");
            _ticketService = new TicketService();
            _incidentService = new IncidentService();

            start();

            if (_loggedUser.get_userType() != UserType.ServiceDesk)
            {
                userManagementToolStripMenuItem.Enabled = false;
                btnArchive.Visible = false;
            }
        }
        void start()
        {
            loadDashBoard();
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
                case "ticketManagement":
                    pnlDashBoard.Visible = false;
                    UserManagement_Pnl.Visible = false;
                    TicketView_Pnl.Visible = true;
                    TicketView_Pnl.Dock = DockStyle.Fill;
                    break;
            }
        }

        private void loadDashBoard()
        {
            SwitchPanel("Dashboard");

            if (_loggedUser.get_userType() == UserType.ServiceDesk)
                _ = LoadServiceDeskEmployeeDashboardAsync();
            if(_loggedUser.get_userType() == UserType.Employee)
                LoadRegularEmployeeDashboard();
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

            setGroupBoxDataServiceDesk(unresolvedTickets.Count, inProgressTickets.Count, resolvedTickets.Count, withinDeadline, pastDeadline);
        }

        private void LoadRegularEmployeeDashboard()
        {
            TicketService ticketService = new TicketService();
            List<Ticket> userTickets = ticketService.GetFilteredTicketsByUserId(_loggedUser.get_id());

            //get personal tickets
            List<Ticket> unresolvedTickets = ticketService.getTicketsByStatus(userTickets, TicketStatus.unresolved);
            List<Ticket> inProgressTickets = ticketService.getTicketsByStatus(userTickets, TicketStatus.inProgress);
            List<Ticket> resolvedTickets = ticketService.getTicketsByStatus(userTickets, TicketStatus.resolved);
            int totalResolvedInProgressUnresolved = unresolvedTickets.Count + inProgressTickets.Count + resolvedTickets.Count;

            //if no tickets display nothing
            if(totalResolvedInProgressUnresolved == 0)
                return;

            //gen sec chart
            List<Ticket> resolvedAndInProgressTickets = new List<Ticket>();
            List<Ticket>[] ticketArr = ticketService.getTicketsBeforeAndPastDeadline(resolvedAndInProgressTickets);
            resolvedAndInProgressTickets.AddRange(unresolvedTickets);
            resolvedAndInProgressTickets.AddRange(inProgressTickets);
            int withinDeadline = ticketArr[0].Count;
            int pastDeadline = ticketArr[1].Count;

            setGroupBoxDataRegularEmployee(unresolvedTickets.Count, inProgressTickets.Count, resolvedTickets.Count, withinDeadline, pastDeadline);
        }

        private void setGroupBoxDataRegularEmployee(int unresolvedTickets, int inProgressTickets, int resolvedTickets, int withinDeadline, int pastDeadline)
        {
            //add component data tickets
            lblunResolved.Text = $"Unresolved: {unresolvedTickets}";
            lblInProgress.Text = $"In progress: {inProgressTickets}";
            lblResolved.Text = $"Resolved {resolvedTickets}";
            pbunResolved.BackColor = Color.FromArgb(224, 20, 76);
            pbInProgress.BackColor = Color.FromArgb(255, 178, 0);
            pbResolved.BackColor = Color.FromArgb(60, 207, 78);
            //set component data ticket deadlines
            pbWithinDeadline.BackColor = Color.FromArgb(41, 52, 98);
            pbPastDeadline.BackColor = Color.FromArgb(214, 28, 78);
            lblWithinDeadline.Text = $"Within deadline: {withinDeadline}";
            lblPastDeadline.Text = $"Past deadline: {pastDeadline}";

            //move labels to dashboard

            Label userLabel = new Label();
            userLabel.Location = new Point(25, 25);
            userLabel.Font = new Font("Arial", 16);
            userLabel.Size = new Size(250, 50);
            userLabel.Text = $"{_loggedUser.get_name()}'s tickets";
            pnlDashBoard.Controls.Add(userLabel);

            pnlDashBoard.Controls.Add(pnlColorLegendMain);
            pnlDashBoard.Controls.Add(pnlColorLegendSecondary);
            pnlColorLegendMain.Location = new Point(25,100);
            pnlColorLegendSecondary.Location = new Point(250, 100);
            //remove group boxes
            pnlDashBoard.Controls.Remove(gbMainChart);
            pnlDashBoard.Controls.Remove(gbSecondaryChart);
        }

        private void setGroupBoxDataServiceDesk(int unresolvedTickets, int inProgressTickets, int resolvedTickets, int withinDeadline, int pastDeadline)
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
            lblWithinDeadline.Text = $"within deadline: {withinDeadline}";
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
            Ticket selectedTicket = (Ticket)listView_ServiceDesk.SelectedItems[0].Tag;

            TransferTicketForm transferTicketForm = new TransferTicketForm(selectedTicket, _loggedUser);
            transferTicketForm.ShowDialog();

            loadTicketView();
        }

        //Ticket View (Aleksandra)

        private void ticketManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchPanel("ticketManagement");

            loadTicketView();
        }

        private void loadTicketView()
        {

            if (_loggedUser.get_userType() == 0)
            {
                TransferTicket_bttn.Visible = false;
                label_overview.Text = "Incident Overview";
                button_CreateIncident.Text = "Create Incident";
                button_deleteTicket.Text = "Delete Incident";
                button_PrioritySort.Visible = false;
                btnArchive.Visible = false;
                LoadTicketListViewForRegularEmployee();

            }
            else
            {
                TransferTicket_bttn.Enabled = false;
                label_overview.Text = "Ticket Overview";
                button_CreateIncident.Text = "Create Ticket";
                button_deleteTicket.Text = "Delete Tcket";

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
                string[] output = { ticket.get_id().ToString(), ticket.get_reportedBy().ToString(), ticket.get_subject().ToString(), ticket.get_date().ToString(), ticket.get_status().ToString(), ticket.get_description(), ticket.get_priority().ToString(), ticket.get_deadline().ToString()  };
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

            //this.Close();

            try
            {
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
                            selectedIncident = new Incident(incident.get_id(), incident.get_reportedBy(), incident.get_subject(), incident.get_date(), incident.get_description(), incident.get_status());
                            addIncidentForm = new AddIncidentForm(_loggedUser, selectedIncident);
                            addIncidentForm.Show();
                        }
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                string[] output = { ticket.get_id().ToString(), ticket.get_reportedBy().ToString(), ticket.get_subject().ToString(), ticket.get_date().ToString(), ticket.get_status().ToString(), ticket.get_description(), ticket.get_priority().ToString(), ticket.get_deadline().ToString() };
                ListViewItem list = new ListViewItem(output);
                list.Tag = ticket;
                listView_ServiceDesk.Items.Add(list);
            }

        }

        private void button_deleteTicket_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(listView_ServiceDesk.SelectedItems[0].Text);
                _ticketService.DeleteTicket(id);
                LoadTicketListViewForServiceDeskEmployee();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void listView_ServiceDesk_SelectedIndexChanged(object sender, EventArgs e)
        {
            TransferTicket_bttn.Enabled = true;
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            TicketArchiveService archiveService = new TicketArchiveService();
            TicketService ticketService = new TicketService();
            //if ticket more than 2 months old
            archiveService.AddTicketsToArchive(ticketService.getTickets(), 2);
        }
    }
}
