using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP_Kursovay
{
    //Основной Класс, отвечающий за работу формы
    public partial class Form1 : Form
    {
        private Emitter emitter; //Эммитер - это точка из которой создаются частицы
        private Circle circle; //Окружность
        private float Speed = 1; //Скорость перемещения частиц по кругу (Смотри timer1_Tick)

        //Конструктор формы. В нем Создается холст, на котором будут отрисовываться объекты
        //Также здесь создается наш единственный эммитер и круг в центре
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            float radius = 50; //радиус круга по умолчанию
            emitter = new Emitter
            {
                Direction = 270,
                Spreading = 50,
                SpeedMin = 15,
                SpeedMax = 15,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 20,
                X = picDisplay.Width / 2 - radius, //изначальное положение эммитера (левая часть окружности)
                Y = picDisplay.Height / 2,
            };

            circle = new Circle(picDisplay.Width / 2, picDisplay.Height / 2, radius, emitter);
        }

        //Таймер. Срабатывает каждые 40ms. Отрисовывает частицы и окружность
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // тут теперь обновляем эмиттер
            for(int i = 0; i < Speed; i++) {
                circle.UpdateState();
            }
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
                circle.Render(g);
            }
            picDisplay.Invalidate();
        }

        //Обработчик, срабатывающий, когда ползунок "Направление" изменился
        private void TB_Direction_Scroll(object sender, EventArgs e)
        {
            circle.DirectionOffset = ((TrackBar)sender).Value;
        }

        //Обработчик, срабатывающий, когда ползунок "Скорость" изменился
        private void TB_Speed_Scroll(object sender, EventArgs e)
        {
            Speed = ((TrackBar)sender).Value;
        }

        //Обработчик, срабатывающий, когда ползунок "Радиус" изменился
        private void TB_Radius_Scroll(object sender, EventArgs e)
        {

            circle.Radius = ((TrackBar)sender).Value;
        }
    }
}
