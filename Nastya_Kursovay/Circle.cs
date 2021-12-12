using System;
using System.Drawing;
using System.Windows;

namespace TP_Kursovay
{
    //Класс окружности
    public class Circle
    {
        public float X;
        public float Y;
        public float Radius;
        public Emitter Emitter; //Эммитер, прикрепленный к окружности
        public Vector vector; //Вспомогательный вектор, для вычисления новой координаты, лежащей на окружности
        public float DirectionOffset; //Скорость изменения направления движения частиц эммитером

        //Конструктор окружности
        public Circle(float x, float y, float radius, Emitter emitter)
        {
            X = x;
            Y = y;
            Radius = radius;
            Emitter = emitter;
            DirectionOffset = 5;
        }

        //Обновляет положение эммитера, сдвигая его по часовой на DirectionOffset градусов
        public void UpdateState()
        {
            vector = new Vector(Emitter.X - X, Emitter.Y - Y); //Вычисляем вектор от центра окружности до эммитера
            double module = Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);

            //Подкручиваем гравитацию, чтобы интересно было
            Emitter.GravitationX = (float)(vector.X / module);
            Emitter.GravitationY = (float)(vector.Y / module);

            Emitter.Direction -= DirectionOffset % 360; //Смещаем направление выброса частиц

            //Поворачиваем вектор на 5 градусов по часовой стрелке
            float cs = (float)Math.Cos(5f / 180f * Math.PI);
            float sn = (float)Math.Sin(5f / 180f * Math.PI);

            vector.X = vector.X * cs - vector.Y * sn;
            vector.Y = vector.X * sn + vector.Y * cs;
            //====================================================

            double epsilon; //Восстановление вектора после поворота (Устранение погрешности)
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

            //Превращаем вектор в точку (Новая позиция эммитера по окружности)
            vector.X += X;
            vector.Y += Y;

            //Перемещаем эммитер в новую позицию
            Emitter.X = vector.X;
            Emitter.Y = vector.Y;
        }

        //Отрисовка окружности
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
