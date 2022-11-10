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
    public partial class DashboardViewForm : Form
    {
        public DashboardViewForm()
        {
            InitializeComponent();
            start();
            this.Size = new Size(960, 540);
            panel1.Visible = false;
        }

        void start()
        {
            TicketService ticketService = new TicketService();
            int totalTickets = ticketService.getTickets().Count;
            int unResolvedTickets = ticketService.getTicketsByStatus(TicketStatus.unresolved).Count;
            int inProgressTickets = ticketService.getTicketsByStatus(TicketStatus.inProgress).Count;
            int resolvedTickets = totalTickets - unResolvedTickets - inProgressTickets;
            lblTest.Text = $"unresolved tickets: {unResolvedTickets}\npending tickets: {inProgressTickets}\nclosed tickets: {resolvedTickets}";
        }

        private void createGraphicPie(float width, float height, float posX, float posY, int TotalItems, int partOne, int partTwo, PaintEventArgs e)
        {
            //set stepSize and increment
            float sweepStepAngle = 360.0f / TotalItems;
            float startAngle = 0.0f;
            //currently limited to only 3 partitions of PieChart
            float ang1 = partOne * sweepStepAngle;
            float ang2 = ang1 + partTwo * sweepStepAngle;
            float rest = ang1 + ang2 + (TotalItems - partOne - partTwo) * sweepStepAngle;
            
            //graphic component for draw
            using (Graphics g = PieChartWrapper.CreateGraphics())
            {
                //init brush
                SolidBrush brush = new SolidBrush(Color.Red);

                //iter trough steps and draw rect as pie
                for(int i = 0; i < TotalItems; i++)
                {
                    if (startAngle >= 360.0f)
                        break;
                    float newAngle = startAngle + sweepStepAngle;
                    //variable brush color based on partitions
                    colorBrushColorChange(brush, ang1, ang2, rest, newAngle);
                    Rectangle rect = new Rectangle((int)posX, (int)posY, (int)width, (int)height);
                    g.FillPie(brush, rect, newAngle, sweepStepAngle);
                    startAngle += sweepStepAngle;
                }

                //add vorder
                Pen p = new Pen(Color.Black);
                g.DrawEllipse(p, (float)posX, (float)posY, (float)width, (float)height);
            }
        }

        private void colorBrushColorChange(SolidBrush b, float angle1, float angle2, float angle3, float newAngle)
        {
            //change brush color based on partitions
            if (newAngle < angle1) //unresolved
                b.Color = Color.FromArgb(224, 20, 76);
            if (newAngle > angle1 && newAngle < angle2) //inProgress
                b.Color = Color.FromArgb(255, 178, 0);
            if (newAngle > angle2 && newAngle < angle3) //resolved
                b.Color = Color.FromArgb(60, 207, 78);
            
        }

        private void DrawPieChart()
        {
            PaintEventArgs e = new PaintEventArgs(PieChartWrapper.CreateGraphics(), PieChartWrapper.DisplayRectangle);
            TicketService ticketService = new TicketService();
            int totalTickets = ticketService.getTickets().Count;
            int openTickets = ticketService.getTicketsByStatus(TicketStatus.unresolved).Count;
            int pendingTickets = ticketService.getTicketsByStatus(TicketStatus.inProgress).Count;
            //width, height, x, y, TotalNumberOfItems, open, pending
            createGraphicPie(200, 200, 0, 0, totalTickets, openTickets, pendingTickets, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDashBoard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;   
        }

        private void loadDashBoard()
        {
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;
            DrawPieChart();
        }
    }
}
