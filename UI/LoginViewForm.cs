using Logic;
using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginViewForm : Form
    {
        public LoginViewForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
                labelIndicator.Text = "Please fill the username and password";
            else
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                UserService userService = new UserService();
                Model.User user = userService.GetUserByUsernameAndPassword(username, password);
                if (user != null)
                {
                    DashboardViewForm dashboardViewForm = new DashboardViewForm();
                    dashboardViewForm.Show();
                    this.Hide();
                }
                labelIndicator.Text = "Your username and password combination are wrong";
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void LoginViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
