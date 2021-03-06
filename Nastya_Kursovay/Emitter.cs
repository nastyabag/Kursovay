using System;
using System.Collections.Generic;
using System.Drawing;

namespace TP_Kursovay
{
    //Эмиттер, генерирующий частицы
    public class Emitter
    {
        //Список частиц, порожденные данным эммитером
        List<Particle> particles = new List<Particle>();

        public float GravitationX = 0; // Гравитация X
        public float GravitationY = 0; // Гравитация Y

        public int ParticlesCount = 1500; //Максимальное количество частиц, генерируемое эммитером

        public double X; // координата X эмиттера
        public double Y; // координата Y эмиттера
        public float Direction = 0; // вектор направления в градусах куда сыпет эмиттер
        public int Spreading = 360; // разброс частиц относительно Direction
        public int SpeedMin = 1; // начальная минимальная скорость движения частицы
        public int SpeedMax = 10; // начальная максимальная скорость движения частицы
        public int RadiusMin = 2; // минимальный радиус частицы
        public int RadiusMax = 10; // максимальный радиус частицы
        public int LifeMin = 20; // минимальное время жизни частицы
        public int LifeMax = 100; // максимальное время жизни частицы
        public int ParticlesPerTick = 10; //Частиц в тик

        public Color ColorFrom = Color.White; // начальный цвет частицы
        public Color ColorTo = Color.FromArgb(0, Color.Black); // конечный цвет частиц

        //Обновляет положение всех частиц
        public void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1f; 
                if (particle.Life <= 0)
                {
                    ResetParticle(particle); //Телепортируем частицы в точку эммитера, когда истекла жизнь
                }
                else
                {
                    //Обновляем положение частицы
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;

                    //Обновляем положение частицы, так как существует гравитация
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;
                }
            }

            // генерируем не более ParticlesPerTick частиц за тик
            for (var i = 0; i < ParticlesPerTick; ++i)
            {
                if (particles.Count < ParticlesCount)
                {
                    var particle = CreateParticle(); //Создание частицы
                    ResetParticle(particle); //Перенос частицы в точку эммитера
                    particles.Add(particle);
                }
                else
                {
                    break;
                }
            }
        }

        //Отрисовывает все частицы
        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }

        //Телепортирует частицу в точку эммитера
        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = Particle.rand.Next(LifeMin, LifeMax);

            particle.X = (float)X;
            particle.Y = (float)Y;

            var direction = Direction
                + (double)Particle.rand.Next(Spreading)
                - Spreading / 2;

            var speed = Particle.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);
            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
        }

        //Создает частицу
        public virtual Particle CreateParticle()
        {
            var particle = new Particle();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

            return particle;
        }
    }
}
