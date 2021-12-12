namespace TP_Kursovay
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TB_Direction = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Speed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Radius = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Direction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Radius)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(776, 371);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TB_Direction
            // 
            this.TB_Direction.Location = new System.Drawing.Point(222, 417);
            this.TB_Direction.Maximum = 360;
            this.TB_Direction.Minimum = 5;
            this.TB_Direction.Name = "TB_Direction";
            this.TB_Direction.Size = new System.Drawing.Size(102, 45);
            this.TB_Direction.TabIndex = 1;
            this.TB_Direction.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TB_Direction.Value = 5;
            this.TB_Direction.Scroll += new System.EventHandler(this.TB_Direction_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(218, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Направление";
            // 
            // TB_Speed
            // 
            this.TB_Speed.Location = new System.Drawing.Point(344, 417);
            this.TB_Speed.Minimum = 1;
            this.TB_Speed.Name = "TB_Speed";
            this.TB_Speed.Size = new System.Drawing.Size(104, 45);
            this.TB_Speed.TabIndex = 3;
            this.TB_Speed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TB_Speed.Value = 1;
            this.TB_Speed.Scroll += new System.EventHandler(this.TB_Speed_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(355, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Скорость";
            // 
            // TB_Radius
            // 
            this.TB_Radius.Location = new System.Drawing.Point(454, 417);
            this.TB_Radius.Maximum = 180;
            this.TB_Radius.Minimum = 50;
            this.TB_Radius.Name = "TB_Radius";
            this.TB_Radius.Size = new System.Drawing.Size(104, 45);
            this.TB_Radius.TabIndex = 5;
            this.TB_Radius.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TB_Radius.Value = 50;
            this.TB_Radius.Scroll += new System.EventHandler(this.TB_Radius_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(476, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Радиус";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Radius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Speed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Direction);
            this.Controls.Add(this.picDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система Частиц";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Direction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Radius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar TB_Direction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TB_Speed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TB_Radius;
        private System.Windows.Forms.Label label3;
    }
}

