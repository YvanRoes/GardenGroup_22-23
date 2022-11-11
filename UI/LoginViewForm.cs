using Logic;
using Microsoft.VisualBasic.ApplicationServices;
using Model;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginViewForm : Form
    {
        Model.User user;
        public LoginViewForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            paneForgotPassword.Visible = false;
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
                        WriteIntoAFile(user);
                    }
                    MainViewForm mvf = new MainViewForm(user);
                    mvf.Show();
                    this.Hide();

                }
                labelIndicator.Text = "Your username and password combination are wrong";
            }
        }
        private void WriteIntoAFile(Model.User user)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("LoginedUser.txt", true);
                //Write a line of text
                sw.WriteLine(user._id + ',' + user._name + ',' + user._email + ',' + user._phone + ',' + user._userType + ',' + user._location + ',' + user._password);
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        private void LoginViewForm_Load(object sender, EventArgs e)
        {
            paneForgotPassword.Visible = false;
            string path = "LoginedUser.txt";
            string line;
            try
            {
                if (File.Exists(path))
                {
                    List<Model.User> users = new List<Model.User>();
                    StreamReader streamReader = new StreamReader(path);
                    line = streamReader.ReadLine();
                    Model.User user;
                    string[] strArray;
                    var lineCOunt = File.ReadAllLines(path).Count();
                    while (lineCOunt > 0)
                    {
                        strArray = line.Split(',');
                        user = new Model.User();
                        user._id = int.Parse(strArray[0]);
                        user._name = strArray[1];
                        user._email = strArray[2];
                        user._phone = long.Parse(strArray[3]);
                        user._userType = (int)(UserType)Enum.Parse(typeof(UserType), strArray[4], true);
                        user._location = (int)(Location)Enum.Parse(typeof(Location), strArray[5], true);
                        user._password = strArray[6];
                        users.Add(user);
                        lineCOunt--;
                    }
                }

            }
            catch (Exception)
            {
                
            }
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            paneForgotPassword.Visible = true;
            textBoxForgetPassowrdNewPassword.Visible= false;
            labelIndicator.Text = "";
            labelForgotPasswordNewPassword.Visible = false;
            buttonSetNewPassword.Visible = false;
            if (textBoxEmail.Text == "" || textBoxUserId.Text == "")
                labelIndicator.Text = "Please fill the Email and UserId";
            else
            {
                UserService userService = new UserService();
                Model.User user = userService.GetFilteredUsersByEmailAndId(textBoxEmail.Text,int.Parse(textBoxUserId.Text));
                if (user != null)
                {
                    this.user = user;
                    buttonSetNewPassword.Visible = true;
                    labelForgotPasswordNewPassword.Visible = true;
                    textBoxForgetPassowrdNewPassword.Visible= true;
                }
            }

        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSetNewPassword_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            if (textBoxForgetPassowrdNewPassword.Text == "")
                labelIndicator.Text = "Please fill the new password";
            else
            {
                userService.SetnewPassowrd(textBoxForgetPassowrdNewPassword.Text, user._email, user._id);
            }
        }
    }
}