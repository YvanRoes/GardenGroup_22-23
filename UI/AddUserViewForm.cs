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
            TypeUser_cmbBox.Items.Add(UserType.Employee);
            TypeUser_cmbBox.Items.Add(UserType.ServiceDesk);


            Location_cmbBox.Items.Clear();
            Location_cmbBox.Items.Add(Model.Location.Haarlem);
            Location_cmbBox.Items.Add(Model.Location.Amsterdam);
            Location_cmbBox.Items.Add(Model.Location.HQ);
            Location_cmbBox.Items.Add(Model.Location.Knuppeldam);
        }

        private void Cancel_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = _userService.generateId();
                string name = Name_TxtBox.Text;
                int uType = TypeUser_cmbBox.SelectedIndex;
                string email = Email_TxtBox.Text;
                long phone = long.Parse(Phone_TxtBox.Text);
                int location = Location_cmbBox.SelectedIndex + 1;

                User user = new User(id, name, email, phone, uType, location);
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
