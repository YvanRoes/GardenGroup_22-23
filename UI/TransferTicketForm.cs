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
        public TransferTicketForm()
        {
            _transferTicketService = new TransferTicketService();   
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            Departments_cmboBox.Items.Clear();

            Departments_cmboBox.Items.Add(Departments.HR);
            Departments_cmboBox.Items.Add(Departments.Finance);
            Departments_cmboBox.Items.Add(Departments.Logistic);
            Departments_cmboBox.Items.Add(Departments.Sales);
            Departments_cmboBox.Items.Add(Departments.Administration);
            Departments_cmboBox.Items.Add(Departments.Production);
            Departments_cmboBox.Items.Add(Departments.ServiceDesk);
        }
    }
}
