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
    public partial class UserManagementViewForm : Form
    {
        private UserService userService;
        public UserManagementViewForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void UserManagementView_Load(object sender, EventArgs e)
        {
            FillListView(userService.GetAllUsers());
        }

        private void FillListView(List<User> users)
        {
            User_lstView.Items.Clear();

            foreach (var user in users)
            {
                ListViewItem li = new ListViewItem(user.get_id().ToString());
                li.SubItems.Add(user.get_email());
                li.SubItems.Add(user.get_name());
                li.SubItems.Add(user.get_location().ToString());
                li.SubItems.Add(userService.countTicketsperUser(user.get_id()).ToString());
                li.Tag = user;
                User_lstView.Items.Add(li);
            }
        }
        private void AddUser_bttn_Click(object sender, EventArgs e)
        {
            AddUserViewForm AddUser = new AddUserViewForm();
            AddUser.ShowDialog();
            FillListView(userService.GetAllUsers());
        }

        private void Filter_bttn_Click(object sender, EventArgs e)
        {
            string filterTxt = filter_txtbox.Text;
            List<User> users = new List<User>();

            if (filter_txtbox.Text == null || filter_txtbox.Text == "")
                users = userService.GetAllUsers();
            else
            users = userService.GetFilteredUsersByEmail(filterTxt);

            FillListView(users);
        }

        private void ticketManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketViewForm ticketViewForm = new TicketViewForm();
            ticketViewForm.ShowDialog();
            this.Close();
        }
    }
}
