namespace 打磚塊
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label_game = new System.Windows.Forms.Label();
            this.board = new System.Windows.Forms.PictureBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_ball
            // 
            this.pictureBox_ball.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ball.Image")));
            this.pictureBox_ball.Location = new System.Drawing.Point(171, 310);
            this.pictureBox_ball.Name = "pictureBox_ball";
            this.pictureBox_ball.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ball.TabIndex = 0;
            this.pictureBox_ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // heart1
            // 
            this.heart1.Image = ((System.Drawing.Image)(resources.GetObject("heart1.Image")));
            this.heart1.Location = new System.Drawing.Point(752, 12);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(40, 40);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 1;
            this.heart1.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.Image = ((System.Drawing.Image)(resources.GetObject("heart2.Image")));
            this.heart2.Location = new System.Drawing.Point(706, 12);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(40, 40);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 2;
            this.heart2.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.Image = ((System.Drawing.Image)(resources.GetObject("heart3.Image")));
            this.heart3.Location = new System.Drawing.Point(660, 12);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(40, 40);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 3;
            this.heart3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(360, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Level 1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.Lime;
            this.score.Location = new System.Drawing.Point(17, 18);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(57, 19);
            this.score.TabIndex = 7;
            this.score.Text = "score";
            // 
            // label_game
            // 
            this.label_game.AutoSize = true;
            this.label_game.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_game.ForeColor = System.Drawing.Color.Red;
            this.label_game.Location = new System.Drawing.Point(341, 233);
            this.label_game.Name = "label_game";
            this.label_game.Size = new System.Drawing.Size(131, 37);
            this.label_game.TabIndex = 8;
            this.label_game.Text = "label1";
            // 
            // board
            // 
            this.board.Image = ((System.Drawing.Image)(resources.GetObject("board.Image")));
            this.board.Location = new System.Drawing.Point(96, 407);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(150, 20);
            this.board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.board.TabIndex = 9;
            this.board.TabStop = false;
            this.board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.board_MouseMove);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.board);
            this.Controls.Add(this.label_game);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.pictureBox_ball);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label_game;
        private System.Windows.Forms.PictureBox board;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

