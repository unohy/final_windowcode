using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;

namespace 打磚塊
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
        SoundPlayer sp2 = new SoundPlayer("board.wav");
        SoundPlayer sp3 = new SoundPlayer("brick.wav");
        public Form1()
        {
            InitializeComponent();
        }
        int dx = 30, dy = 30;
        int sc = 0, heart = 3;
        int brickRow = 6, brickColumn = 6, brickPadding = 30, brickSetTop = 50, brickSetLeft = 80, i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sc == 36)
            {
                label_game.Visible = true;
                label_game.Text = ("YOU WIN");
                timer1.Stop();
            }
            pictureBox_ball.Left += dx;
            pictureBox_ball.Top += dy;
            if (pictureBox_ball.Top+ pictureBox_ball.Height >= this.Height)
            {
                if (heart == 1)
                {
                    heart3.Visible = false;
                    label_game.Visible = true;
                    label_game.Text = "Game over";
                    timer1.Stop();
                }
                else if (heart == 2)
                {
                    heart--;
                    heart2.Visible = false;
                    pictureBox_ball.Top = 500; pictureBox_ball.Left = board.Left;
                    dx = 20; dy = 20;
                }
                else if (heart == 3)
                {
                    heart--;
                    heart1.Visible = false;
                    pictureBox_ball.Top = 500; pictureBox_ball.Left = board.Left;
                    dx = 20; dy = 20;
                }
            }

            score.Text = "Score:" + sc;

            foreach (Control x in this.Controls)
            {
                if (x.Tag == "brick" && pictureBox_ball.Bounds.IntersectsWith(x.Bounds))
                {
                    //sp3.Play();
                    this.Controls.Remove(x);
                    sc++;
                    dy = -dy;
                }
            }
            if (pictureBox_ball.Left <= 0 || pictureBox_ball.Left + pictureBox_ball.Width >= this.Width)
            {
                dx = -dx;
            }
            if (pictureBox_ball.Top <= 0)
            {
                dy = -dy;
            }
            if(pictureBox_ball.Bounds.IntersectsWith(board.Bounds))
            {
                dy = -dy;
                //sp2.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 820;
            this.Height = 500;
            timer1.Start();
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void board_MouseMove(object sender, MouseEventArgs e)
        {
            Label[] brick = new Label[36];
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && board.Left > 0) { board.Left -= 20; }
            if (e.KeyCode == Keys.Right && board.Left+board.Width<this.Width) { board.Left += 20; }
            if (e.KeyCode == Keys.Escape) { Application.Exit(); }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            board.Left = e.X;
        }
    }
}
