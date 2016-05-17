using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Form1 : Form
    {
      
           
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pen myPen;
            Brush mybrush;
            myPen = new Pen(Color.Black, 2);
            
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(Pens.Black, 50, 300, 200, 300);
            g.DrawLine(Pens.Black, 50, 300, 50, 100);
            g.DrawLine(Pens.Black, 200, 300, 200, 100);
            g.DrawRectangle(Pens.Black, 150, 150, 40, 40);
            g.DrawPolygon(Pens.Black,new PointF[]{new Point(50,100),new Point(200,100),new Point(125,10)});
            g.FillPolygon(Brushes.Red, new PointF[] { new Point(50, 100), new Point(200, 100), new Point(125, 10) });
            g.FillEllipse(Brushes.Yellow, 250,20,80,80);
            g.DrawLine(Pens.Yellow, 290, 60, 300, 180);
            g.DrawLine(Pens.Yellow, 290, 60, 200, 60);
            g.DrawLine(Pens.Yellow, 290, 60, 200, 10);
            g.DrawLine(Pens.Yellow, 290, 60, 200, 130);
            g.DrawLine(Pens.Yellow, 290, 60, 400, 120);
            g.DrawLine(Pens.Yellow, 290, 60, 400, 60);
            g.DrawLine(Pens.Yellow, 290, 60, 400, 10);
            g.DrawLine(Pens.Yellow, 290, 60, 290, 0);

           
        }

     
    }
}
