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
        }

        //generating PieChart
        protected override void OnPaint(PaintEventArgs e)
        {
            //width, height, x, y, TotalNumberOfItems, open, pending, Rest
            createGraphicPie(200, 200, 20, 20, 600, 125, 350, 0, e);
        }

        void start()
        {
            TicketService ticketService = new TicketService();
            List<Ticket> t = ticketService.getAllTickets();
            lblTest.Text = t.Count.ToString();
        }


        private void createGraphicPie(float width, float height, float posX, float posY, int TotalItems, int partOne, int partTwo, int partThree, PaintEventArgs e)
        {
            //set stepSize and increment
            float sweepStepAngle = 360.0f / TotalItems;
            float startAngle = 0.0f;
            //currently limited to only 3 partitions of PieChart
            float ang1 = partOne * sweepStepAngle;
            float ang2 = ang1 + partTwo * sweepStepAngle;
            float rest = ang1 + ang2 + (TotalItems - partOne - partTwo) * sweepStepAngle;
            
            base.OnPaint(e);
            //graphic component for draw
            using (Graphics g = this.CreateGraphics())
            {
                //init brush
                SolidBrush brush = new SolidBrush(Color.Red);

                //iter trough steps and draw rect as pie
                for(int i = 0; i < TotalItems; i++)
                {
                    float newAngle = startAngle + sweepStepAngle;
                    //variable brush color based on partitions
                    colorBrushColorChange(brush, ang1, ang2, rest, newAngle);
                    Rectangle rect = new Rectangle((int)posX, (int)posY, (int)width, (int)height);
                    g.FillPie(brush, rect, newAngle, sweepStepAngle);
                    startAngle += sweepStepAngle;
                }
            }
        }

        private void colorBrushColorChange(SolidBrush b, float angle1, float angle2, float angle3, float newAngle)
        {
            //change brush color based on partitions
            if (newAngle < angle1)
                b.Color = Color.FromArgb(39, 123, 192);
            if (newAngle > angle1 && newAngle < angle2)
                b.Color = Color.FromArgb(255, 178, 0);
            if(newAngle > angle2 && newAngle < angle3)
                b.Color = Color.Empty;
        }
    }
}
