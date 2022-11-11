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
        TransferTicketService _transferTicketService;
        Ticket ticket;
        public TransferTicketForm(Ticket ticket)
        {
            _transferTicketService = new TransferTicketService();
            this.ticket = ticket;

            InitializeComponent();

            Employee_cmboBox.Visible = false;
            Employee_lbl.Visible = false;
            Transfer_bttn.Enabled = false;
            

            FillDepartmentComboBox();
        }

        private void FillDepartmentComboBox()
        {
            Departments_cmboBox.Items.Clear();

            Departments_cmboBox.Items.Add(Departments.HR);
            Departments_cmboBox.Items.Add(Departments.Logistic);
            Departments_cmboBox.Items.Add(Departments.Finance);
            Departments_cmboBox.Items.Add(Departments.Sales);
            Departments_cmboBox.Items.Add(Departments.Administration);
            Departments_cmboBox.Items.Add(Departments.Production);
            Departments_cmboBox.Items.Add(Departments.ServiceDesk);
        }

        private void Cancel_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Departments_cmboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transfer_bttn.Enabled = true;
            if (Departments_cmboBox.SelectedIndex.Equals((int)Departments.ServiceDesk))
            {
                Employee_cmboBox.Visible = true;
                Employee_lbl.Visible = true;

                FillEmployeeComboBox(_transferTicketService.GetListOfUsers((int)UserType.ServiceDesk));
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
                
                //Employee_cmboBox.Items.Add($"{e._name} ({e.get_id()})");
            
        }

        private void Transfer_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Departments_cmboBox.SelectedIndex == (int)Departments.ServiceDesk))
                {
                    User selectedUser = (User)Employee_cmboBox.SelectedItem;

                    _transferTicketService.UpdateTicketedBy(ticket.get_id(), selectedUser._id);

                    if (comment_txtBox.Text.Length > 0)
                    {
                        _transferTicketService.UpdateComment(ticket.get_id(), comment_txtBox.Text);
                    }
                }

                throw new Exception("Ticket Transfered Succesfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();

        }
    }
}
