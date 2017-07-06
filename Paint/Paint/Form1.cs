using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : Form
    {
        List<TPoint> TPoint = new List<TPoint> { };
        int X = 0;
        int Y = 0;
        int X1 = 0;
        int Y1 = 0;
        Color CurrentColor = Color.Black; 
        bool isPressed;
     

        public Paint()
        {
            InitializeComponent();
            
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(CurrentColor);
            e.Graphics.DrawLine(pen, new Point(X, Y), new Point(X1, Y1));
            foreach (var p in TPoint)
            {
                e.Graphics.DrawLine(pen, p.X, p.Y);
            }
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            X = e.X;
            Y = e.Y;

        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                X1 = e.X;
                Y1 = e.Y;
                (sender as Panel).Invalidate();
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
            TPoint.Add(new TPoint(new Point (X,Y), new Point(X1,Y1)));
            
        }

     

        private void Clear_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
        }
    }


}
