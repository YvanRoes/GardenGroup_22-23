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

namespace UI
{
    public partial class UserManagementView : Form
    {
        public UserManagementView()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserManagementView_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            foreach (var doc in userService.GetAllUsers())
            {

                ListViewItem li = new ListViewItem(doc.get_id().ToString());
                li.SubItems.Add(doc.get_name());
                li.SubItems.Add(doc.get_name());
                li.SubItems.Add(doc.get_phone().ToString());
                li.SubItems.Add(doc.get_location().ToString());
                li.Tag = doc;
                User_lstView.Items.Add(li);
            }
        }

        private void AddUser_bttn_Click(object sender, EventArgs e)
        {

        }
    }
}
