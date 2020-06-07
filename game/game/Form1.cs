using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class over : Form
    {
        public over()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(4);
            enemy(2);
            gameover();
            coins(2);
            coinscollection();
        }

        void gameover()
        {
            if (car.Bounds.IntersectsWith(car1.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(car2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(car3.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(car4.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
        }

        Random r = new Random();
        int x;
        void enemy(int speed)
        {
            if (car1.Top >= 500)
            {
                x = r.Next(20, 200);
                car1.Location = new Point(x, 0);
            }
            else
            {
                car1.Top += speed;
            }
            if (car2.Top >= 500)
            {
                x = r.Next(20, 340);
                car2.Location = new Point(x, 0);
            }
            else
            {
                car2.Top += speed;
            }
            if (car3.Top >= 500)
            {
                x = r.Next(20, 340);
                car3.Location = new Point(x, 0);
            }
            else
            {
                car3.Top += speed;
            }
            if (car4.Top >= 500)
            {
                x = r.Next(200, 340);
                car4.Location = new Point(x, 0);
            }
            else
            {
                car4.Top += speed;
            }
        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(20, 200);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 500)
            {
                x = r.Next(20, 200);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = r.Next(20, 200);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
            if (coin4.Top >= 500)
            {
                x = r.Next(20, 200);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
            if (coin5.Top >= 500)
            {
                x = r.Next(20, 200);
                coin5.Location = new Point(x, 0);
            }
            else
            {
                coin5.Top += speed;
            }
        }

        int collectedcoin = 0;

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                totalcoins.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(20, 200);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                totalcoins.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(20, 200);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                totalcoins.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(20, 200);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                totalcoins.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(20, 200);
                coin4.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin5.Bounds))
            {
                collectedcoin++;
                totalcoins.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(20, 200);
                coin5.Location = new Point(x, 0);
            }
        }
            void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }

        int gamespeed = 0;

        private void over_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 20)
                    car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 365)
                    car.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                    gamespeed++;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed > 0)
                    gamespeed--;
            }
        }
    }
}
