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
        public Emitter Emitter;
        public Vector vector;
        public float DirectionOffset;
        public float SpeedOffset;
        public Circle(float x, float y, float radius, Emitter emitter)
        {
            X = x;
            Y = y;
            Radius = radius;
            Emitter = emitter;
            DirectionOffset = 5;
            SpeedOffset = 5;
        }

        public void UpdateState()
        {
            vector = new Vector(Emitter.X - X, Emitter.Y - Y);

            double module = Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            Emitter.GravitationX = (float)(vector.X / module);
            Emitter.GravitationY = (float)(vector.Y / module);

            Emitter.Direction -= DirectionOffset % 360; //Смещение направления

            float cs = (float)Math.Cos(5f / 180f * Math.PI); //Скорость изменения положения эммитера
            float sn = (float)Math.Sin(5f / 180f * Math.PI);

            vector.X = vector.X * cs - vector.Y * sn;
            vector.Y = vector.X * sn + vector.Y * cs;

            double epsilon; //Восстановление вектора после поворота (Устранениеи погрешности)
            do
            {
                epsilon = Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y) - Radius;
                if (epsilon >= 0)
                {
                    vector *= 0.99;
                }
                else
                {
                    vector *= 1.01;
                }
            }
            while (Math.Abs(epsilon) >= 1.0);

            vector.X += X;
            vector.Y += Y;

            Emitter.X = vector.X;
            Emitter.Y = vector.Y;
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
