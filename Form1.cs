using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int x_btn;
        private int y_btn;
        private int width_btn;
        private int height_btn;
        private int sizeX;
        private int sizeY;
        private Random r = new Random();
        private int randX;
        private int randY;
        public Form1()
        {
            InitializeComponentt();
            x_btn = button1.Location.X;
            y_btn = button1.Location.Y;
            width_btn = button1.Width;
            height_btn = button1.Height;
            sizeX = Size.Width;
            sizeY = Size.Height;
            randX = sizeX - button1.Width - 20;
            randY = sizeY - button1.Height - 20;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= x_btn - 1 && e.X <= x_btn + width_btn && e.Y >= y_btn - 1 && e.Y <= y_btn + height_btn)
            {

                x_btn = r.Next(0, randX);
                conversionX();
                y_btn = r.Next(0, randY);
                conversionY();
                BackColor = Color.FromArgb(x_btn, y_btn, 127);
            }
            button1.Location = new Point(x_btn, y_btn);
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            x_btn = r.Next(0, randX);
            y_btn = r.Next(0, randY);
            button1.Location = new Point(x_btn, y_btn);
        }
        void conversionX()
        {
            if (x_btn > 255) x_btn = x_btn % 255;
            if (x_btn > 255) conversionX();
        }
        void conversionY()
        {
            if (y_btn > 255) y_btn = y_btn % 255;
            if (y_btn > 255) conversionY();
        }
        private void InitializeComponentt()
        {
            button1 = new Button();
            SuspendLayout();
            button1.Location = new Point(332, 172);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.MouseMove += new MouseEventHandler(button1_MouseMove);
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 416);
            Controls.Add(button1);
            Name = nameof(Form1);
            Text = nameof(Form1);
            MouseMove += new MouseEventHandler(Form1_MouseMove);
            ResumeLayout(false);
        }
    }
}