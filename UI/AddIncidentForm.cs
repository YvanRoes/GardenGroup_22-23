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
    public partial class AddIncidentForm : Form
    {
        public AddIncidentForm()
        {
            InitializeComponent();
            fillInComboBoxes();
        }

        private void fillInComboBoxes()
        {
            comboBox_Priority.Items.Clear();
            comboBox_Deadline.Items.Clear();
            comboBox_IncidentType.Items.Clear();
            foreach (int index in Priority.GetValues(typeof(Priority)))
            {
                comboBox_Priority.Items.Add((Priority)index);
            }

            foreach (int index in Deadline.GetValues(typeof(Deadline)))
            {
                comboBox_Deadline.Items.Add((Deadline)index);
            }

            foreach (int index in TicketType.GetValues(typeof(TicketType)))
            {
                comboBox_IncidentType.Items.Add((TicketType)index);
            }

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardViewForm dashboardViewForm = new DashboardViewForm();
            dashboardViewForm.Show();
            this.Hide();
        }

        private void ticketManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketViewForm ticketViewForm = new TicketViewForm();
            ticketViewForm.Show();
            this.Hide();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagementViewForm userManagementViewForm = new UserManagementViewForm();
            userManagementViewForm.Show();
            this.Hide();
        }
    }
}
