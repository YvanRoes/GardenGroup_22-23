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
    public partial class AddIncidentForm : Form
    {
        public AddIncidentForm()
        {
            InitializeComponent();
        }

        private void AddIncidentForm_Load(object sender, EventArgs e)
        {

        }

        private void GetFormCredentials()
        {
            string subject = textBoxSubject.Text;
            //TicketType type = (TicketType)Enum.Parse(typeof(TicketType), listBoxType.SelectedItem.ToString());
            string description = textBoxDescription.Text;
            //Priority priority = (Priority)Enum.Parse(typeof(Priority), listBoxPriority.SelectedItem.ToString());
           // Deadline deadline = (Deadline)Enum.Parse(typeof(Deadline), listBoxDeadline.SelectedItem.ToString());
        }
    }
}
