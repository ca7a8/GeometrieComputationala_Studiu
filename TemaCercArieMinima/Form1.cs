using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaCercArieMinima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen albastru = new Pen(Color.Blue, 2), rosu = new Pen(Color.Red, 2);
            Random rnd = new Random();

            int n = 5; //rnd.Next(2, 5);
            float raza = 1;
            
            float[] x_coordinate = new float[n];
            float[] y_coordinate = new float[n];

            for (int i = 0; i < n; i++)
            {
                float x = rnd.Next(200, panel1.Width - 200);
                float y = rnd.Next(100, panel1.Height - 100);
                g.DrawEllipse(albastru, x - raza, y - raza, raza * 2, raza * 2);
                x_coordinate[i] = x;
                y_coordinate[i] = y;
            }

            float minx = x_coordinate.Min();
            float maxx = x_coordinate.Max();
            float miny = y_coordinate.Min();
            float maxy = y_coordinate.Max();

            float diametru = Math.Max((float)Math.Sqrt(Math.Pow(maxx - minx, 2)), (float)Math.Sqrt(Math.Pow(maxy - miny, 2)));
            
            //g.DrawEllipse(rosu, minx, miny, diametru, diametru);
            //g.DrawRectangle(albastru, minx, miny, maxx - minx, maxy - miny);
            //g.DrawEllipse(albastru, minx, miny, diametru, diametru);
            g.DrawLine(rosu, minx, miny, maxx, maxy);
            g.DrawLine(rosu, minx, maxy, maxx, miny);
            //g.DrawLine(rosu, minx, miny, maxx, miny);
        }
    }
}
