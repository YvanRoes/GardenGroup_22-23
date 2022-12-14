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
    public partial class TransferTicketForm : Form
    {
        //Andy's Extra Functionality
        TransferTicketService _transferTicketService;
        Ticket _ticket;
        User _loggedUser;
        public TransferTicketForm(Ticket ticket, User user)
        {
            _transferTicketService = new TransferTicketService();
            _ticket = ticket;
            _loggedUser = user;

            InitializeComponent();

            Employee_cmboBox.Visible = false;
            Employee_lbl.Visible = false;
            Transfer_bttn.Enabled = false;
            

            FillDepartmentComboBox();
        }

        private void FillDepartmentComboBox()
        {
            Departments_cmboBox.Items.Clear();

            foreach (int index in Departments.GetValues(typeof(Departments)))
                Departments_cmboBox.Items.Add((Departments)index);
        }

        private void Cancel_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Departments_cmboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transfer_bttn.Enabled = true;
            Departments selectedDepartment = (Departments)Departments_cmboBox.SelectedIndex;

            if (selectedDepartment == Departments.ServiceDesk)
            {
                Employee_cmboBox.Visible = true;
                Employee_lbl.Visible = true;

                FillEmployeeComboBox(_transferTicketService.GetListOfUsers(UserType.ServiceDesk));
            }
            else
            {
                Employee_cmboBox.Visible = false;
                Employee_lbl.Visible = false;
            }
               
        }

        private void FillEmployeeComboBox(List<User> Employees)
        {
            Employee_cmboBox.Items.Clear();
   
            Employee_cmboBox.ValueMember = "_id";
            Employee_cmboBox.DataSource = Employees;

            Employee_cmboBox.Items.Remove(_loggedUser); 
        }

        private void Transfer_bttn_Click(object sender, EventArgs e)
        {

            User selectedUser = (User)Employee_cmboBox.SelectedItem;
            string comment = comment_txtBox.Text;
            Departments selectedDepartment = (Departments)Departments_cmboBox.SelectedIndex;

            try
            {
                if (selectedDepartment == Departments.ServiceDesk)
                    _transferTicketService.UpdateTicketedBy(_ticket, selectedUser);
                else
                {
                    _transferTicketService.UpdateStatusToTransferred(_ticket);
                }

                if (comment.Length > 0)
                    comment = ": " + comment;

                _transferTicketService.CreateTransferDetailComment(_ticket, selectedDepartment, selectedUser, _loggedUser, comment);


                string transferDetails = _transferTicketService.GetTransferDetails(_ticket);

                throw new Exception(transferDetails);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_transferTicketService.GetTransferDetails(_ticket));
        }
    }
}
