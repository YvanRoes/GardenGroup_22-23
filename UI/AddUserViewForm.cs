using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace UI
{ 
    public partial class AddUserViewForm : Form
    {
        private UserService _userService;
        public AddUserViewForm()
        {
            _userService = new UserService();
            InitializeComponent();
            FillConboBoxes();
        }

        private void FillConboBoxes()
        {
            TypeUser_cmbBox.Items.Clear();
            foreach (int index in UserType.GetValues(typeof(UserType)))
                TypeUser_cmbBox.Items.Add((UserType)index);


            Location_cmbBox.Items.Clear();
            foreach (int index in Model.Location.GetValues(typeof(Location)))
                Location_cmbBox.Items.Add((Location)index);
        }

        private void Cancel_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = _userService.getNewID();
                string name = Name_TxtBox.Text;
                int uType = TypeUser_cmbBox.SelectedIndex;
                string email = Email_TxtBox.Text;
                long phone = long.Parse(Phone_TxtBox.Text);
                int location = Location_cmbBox.SelectedIndex + 1;
                string password;

                if (Password_CheckBox.Checked)
                    password = _userService.generatePassword(id, name);
                else
                    password = "";

                User user = new User(id, name, email, phone, uType, location, password);
                _userService.addNewUser(user);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
