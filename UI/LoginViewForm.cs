using Logic;
using Microsoft.VisualBasic.ApplicationServices;
using Model;
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
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
                labelIndicator.Text = "Please fill the username and password";
            else
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                UserService userService = new UserService();
                Model.User user = userService.GetUserByUsernameAndPassword(username, password);
                if (user != null)
                {
                    if (checkBoxRememberMe.Checked)
                    {
                        //Model.User LoginedUser = new Model.User(user.Id,user.Name,user.Email,user.Phone,user.get_userType(),user.Location,user.Password);
                    }
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

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
