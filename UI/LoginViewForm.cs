using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(textBoxUsername.Text == "" || textBoxPassword.Text == "")
                labelIndicator.Text = "Please fill the username and password";
            else
            {
                UserService userService = new UserService();
                UserService user = userService.GetUser
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
