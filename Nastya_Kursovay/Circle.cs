using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TP_Kursovay
{
    public class Circle
    {
        public float X;
        public float Y;
        public float Radius;

        public Circle(float x, float y, float radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public void Render(Graphics g)
        {
            // буду рисовать окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Radius,
                   Y - Radius,
                   Radius * 2,
                   Radius * 2
               );
        }
    }
}
