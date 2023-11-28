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
        int score = 0, heart = 3;
        int brickRow = 6, brickColumn = 6, brickPadding = 30, brickSetTop = 50, brickSetLeft = 80, i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (score == 36)
            {
                label1.Visible = true;
                label1.Text = ("YOU WIN");
                timer1.Stop();
            }
            pictureBox_ball.Left += dx;
            pictureBox_ball.Top += dy;
            if (pictureBox_ball.Top+ pictureBox_ball.Height >= this.Height)
            {
                if (heart == 1)
                {

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
                sp2.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
