using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaConvexHull
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Point> points = new List<Point>();
        List<Point> varfuri = new List<Point>();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            #region Random
            Random rnd = new Random();
            int n = rnd.Next(50);
            #endregion
            #region Pen
            Pen randomPen = new Pen(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
            Pen bluePen = new Pen(Color.Blue, 3);
            #endregion
            #region Points Generator
            for (int i = 0; i < n; i++)
            {
                Point p = new Point(rnd.Next(10, this.panel1.Width - 10), rnd.Next(10, this.panel1.Height - 10));
                points.Add(p);
                g.DrawEllipse(bluePen, p.X, p.Y, 2, 2);
            }
            // test
            #endregion


        }
    }
}
