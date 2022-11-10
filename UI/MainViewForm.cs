﻿using System;
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
        public MainViewForm(User user)
        {
            InitializeComponent();
            start();
            this.Size = new Size(1060, 640);

            _userService = new UserService();
            _loggedUser = user;
            _ticketService = new TicketService();

            if (_loggedUser.get_userType() != UserType.ServiceDesk)
                userManagementToolStripMenuItem.Enabled = false;
        }

        //Dashboard (Yvan)
        void start()
        {
            pnlDashBoard.Visible = false;
            UserManagement_Pnl.Visible = false;
            TicketView_Pnl.Visible = false;
        }

        private void createGraphicPie(float width, float height, float posX, float posY, int TotalItems, int partOne, int partTwo, PaintEventArgs e)
        {
            //set stepSize and increment
            float sweepStepAngle = 360.0f / TotalItems;
            float startAngle = 0.0f;
            //currently limited to only 3 partitions of PieChart
            float ang1 = partOne * sweepStepAngle;
            float ang2 = ang1 + partTwo * sweepStepAngle;
            float rest = ang1 + ang2 + (TotalItems - partOne - partTwo) * sweepStepAngle;

            //graphic component for draw
            using (Graphics g = PieChartWrapper.CreateGraphics())
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

        private void colorBrushColorChange(SolidBrush b, float angle1, float angle2, float angle3, float newAngle)
        {
            //change brush color based on partitions
            if (newAngle < angle1) //unresolved
                b.Color = Color.FromArgb(224, 20, 76);
            if (newAngle > angle1 && newAngle < angle2) //inProgress
                b.Color = Color.FromArgb(255, 178, 0);
            if (newAngle > angle2 && newAngle < angle3) //resolved
                b.Color = Color.FromArgb(60, 207, 78);

        }

        private void DrawPieChart(int totalTickets, int unresolvedTickets, int inProgressTickets)
        {
            PaintEventArgs e = new PaintEventArgs(PieChartWrapper.CreateGraphics(), PieChartWrapper.DisplayRectangle);
            //width, height, x, y, TotalNumberOfItems, open, pending
            createGraphicPie(200, 200, 0, 0, totalTickets, unresolvedTickets, inProgressTickets, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlDashBoard.Visible = false;
        }

        private void loadDashBoard()
        {
            TicketView_Pnl.Visible = false;
            UserManagement_Pnl.Visible = false;
            pnlDashBoard.Visible = true;
            pnlDashBoard.Dock = DockStyle.Fill;
            int totalTickets = _ticketService.getTickets().Count;
            int unresolvedTickets = _ticketService.getTicketsByStatus(TicketStatus.unresolved).Count;
            int inProgressTickets = _ticketService.getTicketsByStatus(TicketStatus.inProgress).Count;
            int resolvedTickets = totalTickets - unresolvedTickets - inProgressTickets;
            DrawPieChart(totalTickets, unresolvedTickets, inProgressTickets);
            lblTest.Text = $"unresolved tickets: {unresolvedTickets}\npending tickets: {inProgressTickets}\nclosed tickets: {resolvedTickets}";
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

        private void AddUser_bttn_Click(object sender, EventArgs e)
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

            if (_loggedUser.get_userType() == UserType.Employee)
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
            List<Ticket> filteredTickets = new List<Ticket>();
            filteredTickets = _ticketService.GetFilteredTicketsByUserId(_loggedUser.get_id());

            // FillListView(users);
            foreach (Ticket ticket in filteredTickets)
            {
                string[] output = { ticket.get_id().ToString(), ticket.get_reportedBy().ToString(), ticket.get_subject().ToString(), ticket.get_date().ToString(), ticket.get_status().ToString() };
                ListViewItem list = new ListViewItem(output);
                list.Tag = Id;
                listView_Tickets.Items.Add(list);
            }
        }

        private void LoadTicketListViewForServiceDeskEmployee()
        {
            List<Ticket> allTickets = _ticketService.getTickets();
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
    }
}
