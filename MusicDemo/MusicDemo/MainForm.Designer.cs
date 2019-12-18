namespace MusicDemo
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.musicPanel = new System.Windows.Forms.Panel();
			this.myProgressBar1 = new MusicDemo.MyProgressBar();
			this.n_time = new System.Windows.Forms.Label();
			this.t_time = new System.Windows.Forms.Label();
			this.playandpause = new System.Windows.Forms.PictureBox();
			this.previewSong = new System.Windows.Forms.PictureBox();
			this.NextSong = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Close = new System.Windows.Forms.Label();
			this.small = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txtPageNum = new System.Windows.Forms.Label();
			this.prepage = new System.Windows.Forms.PictureBox();
			this.nextpage = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.musicPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.playandpause)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.previewSong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NextSong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.prepage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nextpage)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// musicPanel
			// 
			this.musicPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.musicPanel.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.musicPanel.Controls.Add(this.myProgressBar1);
			this.musicPanel.Controls.Add(this.n_time);
			this.musicPanel.Controls.Add(this.t_time);
			this.musicPanel.Controls.Add(this.playandpause);
			this.musicPanel.Controls.Add(this.previewSong);
			this.musicPanel.Controls.Add(this.NextSong);
			this.musicPanel.Controls.Add(this.pictureBox1);
			this.musicPanel.Cursor = System.Windows.Forms.Cursors.Default;
			this.musicPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.musicPanel.Location = new System.Drawing.Point(0, 425);
			this.musicPanel.Name = "musicPanel";
			this.musicPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.musicPanel.Size = new System.Drawing.Size(545, 62);
			this.musicPanel.TabIndex = 1;
			// 
			// myProgressBar1
			// 
			this.myProgressBar1.BackColor = System.Drawing.Color.Transparent;
			this.myProgressBar1.BackgroundColor = System.Drawing.Color.White;
			this.myProgressBar1.FontColor = System.Drawing.Color.Black;
			this.myProgressBar1.FontSize = 9F;
			this.myProgressBar1.ForegroundColor = System.Drawing.Color.Gray;
			this.myProgressBar1.Location = new System.Drawing.Point(72, 0);
			this.myProgressBar1.Name = "myProgressBar1";
			this.myProgressBar1.SetRectColor = System.Drawing.Color.Black;
			this.myProgressBar1.ShowPercentTag = false;
			this.myProgressBar1.Size = new System.Drawing.Size(403, 24);
			this.myProgressBar1.TabIndex = 22;
			this.myProgressBar1.Value = 0D;
			// 
			// n_time
			// 
			this.n_time.AutoSize = true;
			this.n_time.Location = new System.Drawing.Point(19, 9);
			this.n_time.Name = "n_time";
			this.n_time.Size = new System.Drawing.Size(47, 15);
			this.n_time.TabIndex = 14;
			this.n_time.Text = "00:00";
			// 
			// t_time
			// 
			this.t_time.AutoSize = true;
			this.t_time.Location = new System.Drawing.Point(474, 9);
			this.t_time.Name = "t_time";
			this.t_time.Size = new System.Drawing.Size(47, 15);
			this.t_time.TabIndex = 13;
			this.t_time.Text = "00:00";
			// 
			// playandpause
			// 
			this.playandpause.BackColor = System.Drawing.Color.Transparent;
			this.playandpause.Image = global::MusicDemo.Properties.Resources.play_down;
			this.playandpause.Location = new System.Drawing.Point(239, 26);
			this.playandpause.Name = "playandpause";
			this.playandpause.Size = new System.Drawing.Size(41, 33);
			this.playandpause.TabIndex = 11;
			this.playandpause.TabStop = false;
			this.playandpause.Click += new System.EventHandler(this.playandpause_Click);
			// 
			// previewSong
			// 
			this.previewSong.BackColor = System.Drawing.Color.Transparent;
			this.previewSong.Image = global::MusicDemo.Properties.Resources.preview_down;
			this.previewSong.Location = new System.Drawing.Point(166, 26);
			this.previewSong.Name = "previewSong";
			this.previewSong.Size = new System.Drawing.Size(40, 33);
			this.previewSong.TabIndex = 9;
			this.previewSong.TabStop = false;
			this.previewSong.Click += new System.EventHandler(this.previewSong_Click);
			// 
			// NextSong
			// 
			this.NextSong.BackColor = System.Drawing.Color.Transparent;
			this.NextSong.Image = global::MusicDemo.Properties.Resources.next_down;
			this.NextSong.Location = new System.Drawing.Point(315, 26);
			this.NextSong.Name = "NextSong";
			this.NextSong.Size = new System.Drawing.Size(39, 33);
			this.NextSong.TabIndex = 8;
			this.NextSong.TabStop = false;
			this.NextSong.Click += new System.EventHandler(this.NextSong_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::MusicDemo.Properties.Resources.list_down;
			this.pictureBox1.Location = new System.Drawing.Point(483, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 33);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
			// 
			// Close
			// 
			this.Close.AutoSize = true;
			this.Close.BackColor = System.Drawing.Color.Transparent;
			this.Close.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Close.ForeColor = System.Drawing.Color.White;
			this.Close.Location = new System.Drawing.Point(515, 3);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(19, 20);
			this.Close.TabIndex = 6;
			this.Close.Text = "X";
			this.Close.Click += new System.EventHandler(this.label2_Click);
			// 
			// small
			// 
			this.small.AutoSize = true;
			this.small.BackColor = System.Drawing.Color.Transparent;
			this.small.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.small.ForeColor = System.Drawing.Color.White;
			this.small.Location = new System.Drawing.Point(474, 3);
			this.small.Name = "small";
			this.small.Size = new System.Drawing.Size(25, 20);
			this.small.TabIndex = 7;
			this.small.Text = "—";
			this.small.Click += new System.EventHandler(this.small_Click);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Transparent;
			this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
			this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel6.Controls.Add(this.txtPageNum);
			this.panel6.Controls.Add(this.prepage);
			this.panel6.Controls.Add(this.nextpage);
			this.panel6.Controls.Add(this.label9);
			this.panel6.Controls.Add(this.label8);
			this.panel6.Controls.Add(this.label7);
			this.panel6.Controls.Add(this.label6);
			this.panel6.Controls.Add(this.label5);
			this.panel6.Location = new System.Drawing.Point(13, 210);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(521, 209);
			this.panel6.TabIndex = 19;
			// 
			// txtPageNum
			// 
			this.txtPageNum.AutoSize = true;
			this.txtPageNum.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtPageNum.Location = new System.Drawing.Point(242, 172);
			this.txtPageNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txtPageNum.Name = "txtPageNum";
			this.txtPageNum.Size = new System.Drawing.Size(25, 25);
			this.txtPageNum.TabIndex = 10;
			this.txtPageNum.Text = "1";
			// 
			// prepage
			// 
			this.prepage.Image = ((System.Drawing.Image)(resources.GetObject("prepage.Image")));
			this.prepage.Location = new System.Drawing.Point(171, 172);
			this.prepage.Margin = new System.Windows.Forms.Padding(4);
			this.prepage.Name = "prepage";
			this.prepage.Size = new System.Drawing.Size(39, 28);
			this.prepage.TabIndex = 8;
			this.prepage.TabStop = false;
			this.prepage.Click += new System.EventHandler(this.prepage_Click);
			// 
			// nextpage
			// 
			this.nextpage.Image = ((System.Drawing.Image)(resources.GetObject("nextpage.Image")));
			this.nextpage.Location = new System.Drawing.Point(302, 172);
			this.nextpage.Margin = new System.Windows.Forms.Padding(4);
			this.nextpage.Name = "nextpage";
			this.nextpage.Size = new System.Drawing.Size(39, 28);
			this.nextpage.TabIndex = 7;
			this.nextpage.TabStop = false;
			this.nextpage.Click += new System.EventHandler(this.nextpage_Click);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label9.Location = new System.Drawing.Point(27, 140);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(459, 29);
			this.label9.TabIndex = 4;
			this.label9.Tag = "4";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(27, 110);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(459, 29);
			this.label8.TabIndex = 3;
			this.label8.Tag = "3";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(27, 80);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(459, 29);
			this.label7.TabIndex = 2;
			this.label7.Tag = "2";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(27, 50);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(459, 29);
			this.label6.TabIndex = 1;
			this.label6.Tag = "1";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(27, 20);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(459, 29);
			this.label5.TabIndex = 0;
			this.label5.Tag = "0";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Location = new System.Drawing.Point(13, 27);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(521, 165);
			this.panel1.TabIndex = 20;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label14.Location = new System.Drawing.Point(27, 120);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(459, 29);
			this.label14.TabIndex = 4;
			this.label14.Tag = "4";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label4.Location = new System.Drawing.Point(4, 90);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(506, 29);
			this.label4.TabIndex = 3;
			this.label4.Tag = "3";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label16.Location = new System.Drawing.Point(27, 60);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(459, 29);
			this.label16.TabIndex = 2;
			this.label16.Tag = "2";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.White;
			this.label18.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label18.Location = new System.Drawing.Point(50, 15);
			this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(409, 29);
			this.label18.TabIndex = 0;
			this.label18.Tag = "0";
			this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			this.timer2.Interval = 990;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MusicDemo.Properties.Resources._4;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(545, 487);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.small);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.musicPanel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "本地音乐播放器";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.musicPanel.ResumeLayout(false);
			this.musicPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.playandpause)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.previewSong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NextSong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.prepage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nextpage)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel musicPanel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label Close;
		private System.Windows.Forms.Label small;
		private System.Windows.Forms.PictureBox NextSong;
		private System.Windows.Forms.PictureBox previewSong;
		private System.Windows.Forms.PictureBox playandpause;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label txtPageNum;
		private System.Windows.Forms.PictureBox prepage;
		private System.Windows.Forms.PictureBox nextpage;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label t_time;
		private System.Windows.Forms.Label n_time;
		private System.Windows.Forms.Timer timer1;
		private MyProgressBar myProgressBar1;
		private System.Windows.Forms.Timer timer2;
	}
}