using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public static class ChartGraphicComponent
    {
        //generate piecharts
        private static void createGraphicPie(float width, float height, float posX, float posY, int TotalItems, int partOne, int partTwo, Panel panel, PaintEventArgs e)
        {
            /*
             * this function serves the purpose of creating a piechart containing upto 3 different partitions,
             * if 2 partitions complete the pie, partition 3 is obsolete
             */

            //set stepSize and increment
            float sweepStepAngle = 360.0f / TotalItems;
            float startAngle = 0.0f;
            //currently limited to only 3 partitions of PieChart
            float ang1 = partOne * sweepStepAngle;
            float ang2 = ang1 + partTwo * sweepStepAngle;
            float rest = ang1 + ang2 + (TotalItems - partOne - partTwo) * sweepStepAngle;

            //graphic component for draw
            using (System.Drawing.Graphics g = panel.CreateGraphics())
            {
                //init brush
                SolidBrush brush = new SolidBrush(Color.Red);

                //iter trough steps and draw rect as pie
                for (int i = 0; i < TotalItems; i++)
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
        private static void createGraphicPie(float width, float height, float posX, float posY, int TotalItems, int partOne, int partTwo, int partThree, Panel panel, PaintEventArgs e)
        {
            /*
             * Overloaded fucntion with extra pie partition fucntionality
             * 
             * this function serves the purpose of creating a piechart containing upto 4 different partitions,
             * if 3 partitions complete the pie, partition 4 is obsolete
             */


            //set stepSize and increment
            float sweepStepAngle = 360.0f / TotalItems;
            float startAngle = 0.0f;
            //currently limited to only 3 partitions of PieChart
            float ang1 = partOne * sweepStepAngle;
            float ang2 = ang1 + partTwo * sweepStepAngle;
            float ang3 = ang1 + ang2 + partThree * sweepStepAngle;
            float rest = ang1 + ang2 + ang3 + (TotalItems - partOne - partTwo - partThree) * sweepStepAngle;

            //graphic component for draw
            using (Graphics g = panel.CreateGraphics())
            {
                //init brush
                SolidBrush brush = new SolidBrush(Color.Red);

                //iter trough steps and draw rect as pie
                for (int i = 0; i < TotalItems; i++)
                {
                    if (startAngle >= 360.0f)
                        break;

                    float newAngle = startAngle + sweepStepAngle;
                    //variable brush color based on partitions
                    colorBrushColorChange(brush, ang1, ang2, ang3, rest, newAngle);

                    Rectangle rect = new Rectangle((int)posX, (int)posY, (int)width, (int)height);
                    g.FillPie(brush, rect, newAngle, sweepStepAngle);
                    startAngle += sweepStepAngle;
                }

                //add vorder
                Pen p = new Pen(Color.Black);
                g.DrawEllipse(p, (float)posX, (float)posY, (float)width, (float)height);
            }
        }
        //pie chart colors
        private static void colorBrushColorChange(SolidBrush b, float angle1, float angle2, float angle3, float newAngle)
        {
            /*
             * works with non overloaded function createGraphicPie
             */
            if (newAngle < angle1) //within deadline
                b.Color = Color.FromArgb(41, 52, 98);
            if (newAngle > angle1 && newAngle < angle2) //past deadline
                b.Color = Color.FromArgb(214, 28, 78);

        }
        private static void colorBrushColorChange(SolidBrush b, float angle1, float angle2, float angle3, float angle4, float newAngle)
        {
            /*
             * Works with overloaded createGraphicPie fucntion to assign colors for PieChart
             */
            if (newAngle < angle1) //unresolved
                b.Color = Color.FromArgb(224, 20, 76);
            if (newAngle > angle1 && newAngle < angle2) //inProgress
                b.Color = Color.FromArgb(255, 178, 0);
            if (newAngle > angle2 && newAngle < angle3) //resolved
                b.Color = Color.FromArgb(60, 207, 78);
            if (newAngle > angle3 && newAngle < angle4) //obsolete or optional
                b.Color = Color.Empty;

        }
        //access components
        public static void DrawPieChart(int total, int pie1, int pie2, int pie3, Panel panel)
        {
            PaintEventArgs e = new PaintEventArgs(panel.CreateGraphics(), panel.DisplayRectangle);
            createGraphicPie(200, 200, 0, 0, total, pie1, pie2, pie3, panel, e);
        }
        public static void DrawPieChart(int total, int pie1, int pie2, Panel panel)
        {
            PaintEventArgs e = new PaintEventArgs(panel.CreateGraphics(), panel.DisplayRectangle);
            createGraphicPie(200, 200, 0, 0, total, pie1, pie2, panel, e);
        }
    }
}
