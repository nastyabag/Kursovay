using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP_Kursovay
{
    public partial class Form1 : Form
    {
        // собственно список, пока пустой
        Emitter emitter; // добавили эмиттер
        Circle circle;
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            float radius = 100;
            // а тут теперь вручную создаем
            emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 270,
                Spreading = 50,
                SpeedMin = 15,
                SpeedMax = 15,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 20,
                X = picDisplay.Width / 2 - radius,
                Y = picDisplay.Height / 2,
            };

            circle = new Circle(picDisplay.Width / 2, picDisplay.Height / 2, radius, emitter);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // тут теперь обновляем эмиттер
            circle.UpdateState();
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
                circle.Render(g);
            }
            picDisplay.Invalidate();
        }
    }
}
