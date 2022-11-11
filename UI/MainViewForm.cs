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
            pnlDashBoard.Visible = true;
            UserManagement_Pnl.Visible = false;
            TicketView_Pnl.Visible = false;
        }

        // Dashboard (Yvan)
        private void createGraphicPie(float width, float height, float posX, float posY, int TotalItems, int partOne, int partTwo, Panel panel, PaintEventArgs e)
        {
            /*
             * this function serves the purpose of creating a piechart containing upto 3 different partitions,
             * if 2 partitions complete the pie, partition 3 is obsolete
             */

            //set stepSize and increment
            float sweepStepAngle = 360.0f / TotalItems;
            float startAngle = 0.0f;
            //currently limited to only 3 partitions of PieChart
            float ang1 = partOne * sweepStepAngle;
            float ang2 = ang1 + partTwo * sweepStepAngle;
            float rest = ang1 + ang2 + (TotalItems - partOne - partTwo) * sweepStepAngle;

            //graphic component for draw
            using (Graphics g = panel.CreateGraphics())
            {
                //init brush
                SolidBrush brush = new SolidBrush(Color.Red);

                //iter trough steps and draw rect as pie
                for (int i = 0; i < TotalItems; i++)
                {
                    if (startAngle >= 360.0f)
                        break;

                    float newAngle = startAngle + sweepStepAngle;
                    //variable brush color based on partitions
                    colorBrushColorChange(brush, ang1, ang2, rest, newAngle);

                    Rectangle rect = new Rectangle((int)posX, (int)posY, (int)width, (int)height);
                    g.FillPie(brush, rect, newAngle, sweepStepAngle);
                    startAngle += sweepStepAngle;
                }

                //add vorder
                Pen p = new Pen(Color.Black);
                g.DrawEllipse(p, (float)posX, (float)posY, (float)width, (float)height);
            }
        }
        private void createGraphicPie(float width, float height, float posX, float posY, int TotalItems, int partOne, int partTwo, int partThree, Panel panel, PaintEventArgs e)
        {
            /*
             * Overloaded fucntion with extra pie partition fucntionality
             * 
             * this function serves the purpose of creating a piechart containing upto 4 different partitions,
             * if 3 partitions complete the pie, partition 4 is obsolete
             */


            //set stepSize and increment
            float sweepStepAngle = 360.0f / TotalItems;
            float startAngle = 0.0f;
            //currently limited to only 3 partitions of PieChart
            float ang1 = partOne * sweepStepAngle;
            float ang2 = ang1 + partTwo * sweepStepAngle;
            float ang3 = ang1 + ang2 + partThree * sweepStepAngle;
            float rest = ang1 + ang2 + ang3 + (TotalItems - partOne - partTwo - partThree) * sweepStepAngle;

            //graphic component for draw
            using (Graphics g = panel.CreateGraphics())
            {
                //init brush
                SolidBrush brush = new SolidBrush(Color.Red);

                //iter trough steps and draw rect as pie
                for (int i = 0; i < TotalItems; i++)
                {
                    if (startAngle >= 360.0f)
                        break;

                    float newAngle = startAngle + sweepStepAngle;
                    //variable brush color based on partitions
                    colorBrushColorChange(brush, ang1, ang2, ang3, rest, newAngle);

                    Rectangle rect = new Rectangle((int)posX, (int)posY, (int)width, (int)height);
                    g.FillPie(brush, rect, newAngle, sweepStepAngle);
                    startAngle += sweepStepAngle;
                }

                //add vorder
                Pen p = new Pen(Color.Black);
                g.DrawEllipse(p, (float)posX, (float)posY, (float)width, (float)height);
            }
        }

        private void colorBrushColorChange(SolidBrush b, float angle1, float angle2, float angle3, float newAngle)
        {
            /*
             * works with non overloaded function createGraphicPie
             */
            if (newAngle < angle1) //unresolved
                b.Color = Color.FromArgb(224, 20, 76);
            if (newAngle > angle1 && newAngle < angle2) //inProgress
                b.Color = Color.FromArgb(255, 178, 0);
            if (newAngle > angle2 && newAngle < angle3) //obsolete or optional
                b.Color = Color.Empty;
        }
        private void colorBrushColorChange(SolidBrush b, float angle1, float angle2, float angle3, float angle4, float newAngle)
        {
            /*
             * Works with overloaded createGraphicPie fucntion to assign colors for PieChart
             */
            if (newAngle < angle1) //unresolved
                b.Color = Color.FromArgb(224, 20, 76);
            if (newAngle > angle1 && newAngle < angle2) //inProgress
                b.Color = Color.FromArgb(255, 178, 0);
            if (newAngle > angle2 && newAngle < angle3) //resolved
                b.Color = Color.FromArgb(60, 207, 78);
            if (newAngle > angle3 && newAngle < angle4) //obsolete or optional
                b.Color = Color.Empty;

        }
        private void DrawPieChart(int total, int pie1, int pie2, int pie3, Panel panel)
        {
            PaintEventArgs e = new PaintEventArgs(panel.CreateGraphics(), panel.DisplayRectangle);
            createGraphicPie(200, 200, 0, 0, total, pie1, pie2, pie3, panel, e);
        }
        private void DrawPieChart(int total, int pie1, int pie2, Panel panel)
        {
            PaintEventArgs e = new PaintEventArgs(panel.CreateGraphics(), panel.DisplayRectangle);
            createGraphicPie(200, 200, 0, 0, total, pie1, pie2, panel, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlDashBoard.Visible = false;
        }

        private async Task loadDashBoardAsync()
        {
            UserManagement_Pnl.Visible = false;
            TicketView_Pnl.Visible = false;
            pnlDashBoard.Visible = true;
            pnlDashBoard.Dock = DockStyle.Fill;
            TicketService ticketService = new TicketService();
            int totalTickets = ticketService.getTickets().Count;
            int unresolvedTickets = (await ticketService.getTicketsByStatusAsync(TicketStatus.unresolved)).Count;
            int inProgressTickets = (await ticketService.getTicketsByStatusAsync(TicketStatus.inProgress)).Count;
            int resolvedTickets = totalTickets - unresolvedTickets - inProgressTickets;
            int pastDeadline = 12;
            //unresolved, inProgress, resolved
            DrawPieChart(totalTickets, unresolvedTickets, inProgressTickets, resolvedTickets, PieChartWrapper);


            //draw unresolved and pastdeadline
            DrawPieChart(unresolvedTickets + pastDeadline, unresolvedTickets, pastDeadline, PieChartWrapper);
            lblTest.Text = $"unresolved tickets: {unresolvedTickets}\ntickets in progress: {inProgressTickets}\nclosed tickets: {resolvedTickets}";
        }

        private void DashBoardMenuItem_Click(object sender, EventArgs e)
        {
            _ = loadDashBoardAsync();
        }

        //User Management (Andy)

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadUserManagement();
        }

        private void loadUserManagement()
        {
            TicketView_Pnl.Visible = false;
            pnlDashBoard.Visible = false;
            UserManagement_Pnl.Visible = true;
            UserManagement_Pnl.Dock = DockStyle.Fill;

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
