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

namespace UI
{
    public partial class AddUserViewForm : Form
    {
        public AddUserViewForm()
        {
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

        }
    }
}
