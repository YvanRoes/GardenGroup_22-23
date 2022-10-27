using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Logic;
using Model;

namespace UI
{
    public partial class TicketView : Form
    {
        TicketService ticketService = new TicketService();
       
        public TicketView()
        {
            InitializeComponent();
            LoadTicketListView();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void LoadTicketListView()
        {
            List<Ticket> allTickets = ticketService.GetAllTickets();
            foreach (Ticket ticket in allTickets)
            {
                string[] output = {ticket.get_id().ToString(), ticket.get_reportedBy().ToString(), ticket.get_subject().ToString(),ticket.get_date().ToString(), ticket.get_status().ToString()};
                ListViewItem list = new ListViewItem(output);
                listView_Tickets.Items.Add(list);
            }
        }

        private void button_Filter_Click(object sender, EventArgs e)
        {

        }
    }
}
