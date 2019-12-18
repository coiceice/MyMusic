using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MusicDemo
{
	public partial class MainForm : Form
	{
		static clsMCI cm = null;
		List<MusicFile> files;
		MusicFile file;
		Label musicInfo;
		static bool isplay = false;
		static bool ispause = false;
		static string[] names;//获取歌曲路径集合
		public MainForm()
		{
			InitializeComponent();
		}

		private void setNames()
		{
			int i = 0;
			files = MusicFileService.Instance().GetAllFiles();
			String[] k = new String[files.Count];


			foreach (var s in files)
			{
				k[i] = s.Name;
				i++;
			}
			names = k;
		}
		
		private void MainForm_Load(object sender, EventArgs e)
		{
			setNames();
			setMusicList(1);
			setControlEnter();
		}



		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void small_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void playandpause_Click(object sender, EventArgs e)
		{
			if (ispause == false)
			{
				if (isplay == false)
				{
					playMusic(0);
					//timer3.Enabled = true;
					playandpause.Image = Properties.Resources.pause_down;
					isplay = true;
				}
				else
				{
					playandpause.Image = Properties.Resources.play_down;
					pausePlay();
					//this.axWindowsMediaPlayer1.Ctlcontrols.pause();
					//timer3.Enabled = false;
					isplay = false;
					ispause = true;
				}
			}
			else
			{
				resumePlay();
				playandpause.Image = Properties.Resources.pause_down;
				isplay = true;
				ispause = false;
			}
		}

		void playMusic(int index)
		{
			file = MusicFileService.Instance().FindFile(names[index]);
			lrc1 = new string[2, 500];
			label14.Text = " ";
			label16.Text = " ";
			label4.Text = " ";
			count = false;
			setLrc();
			if (null == file)
			{
				return;
			}
			//停止旧的歌曲
			if (null != cm)
				cm.StopT();
			//播放
			cm = new clsMCI();
			cm.FileName = file.Path;
			cm.play();
			musicInfo = new Label();
			musicInfo.Location = new Point(42, 114);
			musicInfo.Size = new Size(350, 15);
			musicInfo.Text = file.Name;
			//songPanel.Controls.Add(musicInfo);
			isplay = true;
			index0 = index;
			string[] datas = file.Name.Split('.');
			label18.Text = datas[0];
			setT_time();			
		}
		
/*
		void playMusic(String music)
		{
			file = MusicFileService.Instance().FindFile(music);
			if (null == file)
			{
				return;
			}
			//停止旧的歌曲
			if (null != cm)
				cm.StopT();
			//播放
			cm = new clsMCI();
			cm.FileName = file.Path;
			cm.play();
			musicInfo = new Label();
			musicInfo.Location = new Point(42, 114);
			musicInfo.Size = new Size(350, 15);
			musicInfo.Text = file.Name;
			//songPanel.Controls.Add(musicInfo);
			isplay = true;

		}
*/
		void pausePlay()
		{
			if (null != cm)
				cm.Puase();
			isplay = false;
		}
		 void stopPlay()
		{
			if (null != cm)
				cm.StopT();
			isplay=false;
		}
		void resumePlay()
		{
			if (null != cm)
				cm.Resume();
			isplay = true;
		}


		/// <summary>
		/// 批量设置lable鼠标事件
		/// </summary>
		private void setControlEnter()
		{
			label5.MouseEnter += new EventHandler(label_MouseEnter);
			label6.MouseEnter += new EventHandler(label_MouseEnter);
			label7.MouseEnter += new EventHandler(label_MouseEnter);
			label8.MouseEnter += new EventHandler(label_MouseEnter);
			label9.MouseEnter += new EventHandler(label_MouseEnter);
			label5.DoubleClick += new EventHandler(lable_DoubleClick);
			label6.DoubleClick += new EventHandler(lable_DoubleClick);
			label7.DoubleClick += new EventHandler(lable_DoubleClick);
			label8.DoubleClick += new EventHandler(lable_DoubleClick);
			label9.DoubleClick += new EventHandler(lable_DoubleClick);
			label5.MouseLeave += new EventHandler(lable_MouseLeave);
			label6.MouseLeave += new EventHandler(lable_MouseLeave);
			label7.MouseLeave += new EventHandler(lable_MouseLeave);
			label8.MouseLeave += new EventHandler(lable_MouseLeave);
			label9.MouseLeave += new EventHandler(lable_MouseLeave);
		}

		//双击播放列表播放歌曲事件
		private void lable_DoubleClick(object sender, EventArgs e)
		{
			Label lb = (Label)sender;
			
			int label_index = Convert.ToInt32(System.Text.RegularExpressions.Regex.Replace(lb.Name, @"[^0-9]+", ""))-5;
			if (mpage > 1)
				label_index = label_index + (mpage-1) * 5;
			try
			{
				playMusic(label_index);
				setT_time();
				
			}
			catch (Exception)
			{

			}
		}
		private void setT_time()
		{
			int s = 0, m = 0;
			s = cm.Duration;
			if (s > 60)
			{
				m = m + s / 60;
				s = s % 60;
			}
			t_time.Text = m.ToString().PadLeft(2, '0') + ":" + s.ToString().PadLeft(2, '0');
		}

		private void label_MouseEnter(object sender, EventArgs e)
		{
			Label lb = (Label)sender;
			lb.Image = Properties.Resources.s;
		}
		private void lable_MouseLeave(object sender, EventArgs e)
		{
			Label lb = (Label)sender;
			lb.Image = null;
		}

		int pages = 1;//歌曲列表页数 每页5首
		int index0 = 0;//下标
		int noMusic;//取摸剩下的没有的歌曲
		private void setMusicList(int page)
		{
			if (names != null)
			{
				label5.Text = null;
				label6.Text = null;
				label7.Text = null;
				label8.Text = null;
				label9.Text = null;
				pages = (int)names.Length / 5;
				index0 = (page - 1) * 5;
				noMusic = names.Length % 5;
				try
				{
					label5.Text = names[index0 + 0];
					label6.Text = names[index0 + 1];
					label7.Text =names[index0 + 2];
					label8.Text =names[index0 + 3];
					label9.Text = names[index0 + 4];
				}
				catch (Exception)
				{
				}
				//}
				//txtPageCount.Text = (names.Length / 5 + 1).ToString();
			}
		}


		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			FolderBrowserDialog df = new FolderBrowserDialog();
			df.ShowDialog();
			string selectPath = df.SelectedPath;
			if ("" == selectPath)
			{
				return;
			}
			DirectoryInfo dInfo = new DirectoryInfo(selectPath);
			foreach (FileInfo f in dInfo.GetFiles("*.mp3"))
			{
				MusicFileService.Instance().AddFile(new MusicFile(f.Name, f.FullName, f.Length));
				//listBox1.Items.Add(f.Name);
			}
			MusicFileService.Instance().Save();
			setNames();
			setMusicList(1);
			//listBox1.SetSelected(0, true);
		}


		private void NextSong_Click(object sender, EventArgs e)
		{
			if (index0 == names.Length - 1)
			{
				playMusic(0);
				//file = MusicFileService.Instance().FindFile(names[0]);
				//index0 = 0;
			}
			else
			{
				playMusic(index0 + 1);
				//file = MusicFileService.Instance().FindFile(names[index0 + 1]);
				//index0 = index0 + 1;
			}
		}

		private void previewSong_Click(object sender, EventArgs e)
		{
			if (index0 > 0)
			{
				playMusic(index0 - 1);
				//	file = MusicFileService.Instance().FindFile(names[index0 - 1]);
				//	index0 = index0 - 1;
			}
			else
			{
				playMusic(names.Length - 1);
			}
		}

		/*

	*/

		#region 窗体拖动代码
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HTCAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
		}
		#endregion


		#region 歌词
		string[,] lrc1 = new string[2, 500];//保存歌词和当前进度
		public void setLrc()
		{
			try
			{
				//using:作用是使用完成后自动释放内存
				//StreamReader:作用是用特定的编码从字节流中读取字节
				using (StreamReader sr = new StreamReader("..\\..\\Lrc\\" + file.Name.Split('.')[0].Split('-')[1].Trim() + ".lrc", Encoding.UTF8))
				{
					String line;
					//循环读取每一行歌词
					while ((line = sr.ReadLine()) != null)
					{
						//将读取到的歌词存放到数组中
						for (int i = 0; i < 500; i++)
						{
							if (lrc1[0, i] == null)
							{
								lrc1[0, i] = line.Substring(10, line.Length - 10);
								break;
							}
						}
						//将读取到的歌词时间存放到数组中
						for (int i = 0; i < 500; i++)
						{
							if (lrc1[1, i] == null)
							{
								lrc1[1, i] = line.Substring(1, 5);
								break;
							}
						}
					}
				}
			}
			catch
			{
				label4.Text = "暂无本地歌词";
			}
		}
		bool count = false;
		public void ShowLrc()
		{
			if (isplay && label4.Text!= "暂无本地歌词")
			{
				try
				{
					/***********动态显示歌词***************/
					//获取播放器当前进度
					int m = 0, s = 0;
					s = cm.CurrentPosition;
					if (s > 60)
					{
						m = m + s / 60;
						s = s % 60;
					}
					string numss = m.ToString().PadLeft(2, '0') + ":" + s.ToString().PadLeft(2, '0');
					if (!count)
					{
						label16.Text = " ";
						label4.Text = lrc1[0,0];
						label14.Text = lrc1[0,1];
					}
					for (int i = 0; i < 500; i++)
						{
							if (lrc1[1, i].Equals(numss))
							{
								count = true;
								label16.Text = lrc1[0, i - 1];
								label4.Text = lrc1[0, i];
								label14.Text = lrc1[0, i + 1];
							}
						}
				}
				catch (Exception ex)
				{
					//MessageBox.Show("异常：" + ex.Message);
				}
			}
		}
		
		#endregion




		private void timer1_Tick(object sender, EventArgs e)
		{		
			if (cm != null)
			{
				int m = 0, s = 0;
				s = cm.CurrentPosition;
				if(!myProgressBar1.isdown)
					myProgressBar1.Value=Convert.ToDouble(s) / cm.Duration * myProgressBar1.Maximum;
				else
					cm.CurrentPosition = (int)(myProgressBar1.Value / myProgressBar1.Maximum * cm.Duration);
			
				//myProgressBar2.Value = cm.volume;
				if (s > 60)
				{
					m = m + s / 60;
					s = s % 60;
				}
				n_time.Text = m.ToString().PadLeft(2, '0') +":" + s.ToString().PadLeft(2, '0');
			}
			if (isplay)
			{
				playandpause.Image = Properties.Resources.pause_down;
			}
			else
			{
				playandpause.Image = Properties.Resources.play_down;
			}
		}
		int mpage = 1;
		private void nextpage_Click(object sender, EventArgs e)
		{
			if (mpage < (int)names.Length / 5 + 1)
			{
				setMusicList(mpage + 1);
				mpage++;
				txtPageNum.Text = mpage.ToString();
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			ShowLrc();

		}

		private void prepage_Click(object sender, EventArgs e)
		{
			if (mpage > 1)
			{
				setMusicList(mpage - 1);
				mpage--;
				txtPageNum.Text = mpage.ToString();
			}
		}
	}

	#region 自定义进度条
	public class MyProgressBar : ProgressBar
	{
		public MyProgressBar()
		{
			this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);

			//通过三个鼠标事件函数，让鼠标可以拖动控制条
			this.MouseDown += MyProgressBar_MouseDown;
			this.MouseMove += MyProgressBar_MouseMove;
			this.MouseUp += MyProgressBar_MouseUp;

			this.BackColor = Color.Transparent;
			this.maximum = 100;
			this.minimum = 0;
		}

		#region 定义变量，并对一些变量进行一些默认设置
		//已加载长度（灰色矩形）
		Rectangle foreRect;
		Color foregroundColor = Color.Gray;
		//总长度（底部白色矩形）
		Rectangle backRect;
		Color backgroundColor = Color.White;
		//控制块（黑色矩形）
		Rectangle setRect;
		Color setRectColor = Color.Black;

		//最大值
		int maximum = 100;
		//最小值
		int minimum = 0;
		//当前值
		double myValue = 0;
		//是否显示百分比
		bool showPercent;

		//进度条百分比的颜色 
		Color fontColor = Color.Black;
		//进度条百分比的字体大小
		float fontSize = 9;
		//进度条百分比的字体
		FontFamily myFontFamily = new FontFamily("宋体");
		#endregion

		#region 设置属性值
		[Category("进度条"), Description("显示百分比"), Browsable(true)]
		public bool ShowPercentTag
		{
			get { return showPercent; }
			set
			{
				showPercent = value;
				Invalidate();
			}
		}

		[Category("进度条"), Description("进度条的最大值"), Browsable(true)]
		public int Maximum
		{
			get { return maximum; }
			set
			{
				maximum = value;
				Invalidate();
			}
		}

		[Category("进度条"), Description("进度条的最小值"), Browsable(true)]
		public int Minimum
		{
			get { return minimum; }
			set
			{
				minimum = value;
				Invalidate();
			}
		}

		[Category("进度条"), Description("进度条的背景色，总长度（底部白色矩形）"), Browsable(true)]
		public Color BackgroundColor
		{
			get { return backgroundColor; }
			set
			{
				this.backgroundColor = value;
				Invalidate();
			}
		}

		[Category("进度条"), Description("进度条的前景色，已加载长度（灰色矩形）"), Browsable(true)]
		public Color ForegroundColor
		{
			get { return foregroundColor; }
			set
			{
				this.foregroundColor = value;
				Invalidate();
			}
		}

		[Category("进度条"), Description("进度条控制块的颜色（黑色矩形）"), Browsable(true)]
		public Color SetRectColor
		{
			get { return setRectColor; }
			set
			{
				this.setRectColor = value;
				Invalidate();
			}
		}

		[Category("进度条"), Description("进度条的百分比字体大小"), Browsable(true)]
		public float FontSize
		{
			get { return fontSize; }
			set
			{
				this.fontSize = value;
				Invalidate();
			}
		}

		[Category("进度条"), Description("进度条的百分比字体"), Browsable(true)]
		public FontFamily MyFontFamily
		{
			get { return myFontFamily; }
			set
			{
				this.myFontFamily = value;
				Invalidate();
			}
		}

		[Category("进度条"), Description("进度条的百分比字体颜色"), Browsable(true)]
		public Color FontColor
		{
			get { return fontColor; }
			set
			{
				this.fontColor = value;
				Invalidate();
			}
		}
		#endregion

		#region 确定控件的位置
		[Category("General"), Description("控件的宽度"), Browsable(true)]
		public new int Width
		{
			get { return base.Width; }
			set
			{
				base.Width = value;
				foreRect.X = backRect.X = base.Width / 20;
				backRect.Width = base.Width * 9 / 10;
				foreRect.Width = (int)(myValue / maximum * backRect.Width);
				setRect.X = (int)(foreRect.X + foreRect.Width - setRect.Width / 2);

				Invalidate();
			}
		}

		[Category("General"), Description("控件的高度"), Browsable(true)]
		public new int Height
		{
			get { return base.Height; }
			set
			{
				base.Height = value;
				setRect.Height = setRect.Width = base.Height * 2 / 3;
				foreRect.Height = backRect.Height = base.Height / 3;
				setRect.Y = base.Height / 6;
				foreRect.Y = backRect.Y = base.Height / 3;
				Invalidate();
			}
		}
		#endregion

		#region value值改变事件

		protected EventHandler OnValueChanged;
		//当外部为该事件添加了响应函数时，事件就会生效，否则为OnValueChanged的值为null
		public event EventHandler ValueChanged
		{
			add
			{
				if (OnValueChanged != null)
				{
					foreach (Delegate d in OnValueChanged.GetInvocationList())
					{
						if (object.ReferenceEquals(d, value)) { return; }
					}
				}
				OnValueChanged = (EventHandler)Delegate.Combine(OnValueChanged, value);
			}
			remove
			{
				OnValueChanged = (EventHandler)Delegate.Remove(OnValueChanged, value);
			}
		}
		#endregion

		#region 定义Value属性

		//当Value值改变的时候,重新设置矩形的进度，控制块的位置，并且重绘控件
		//Value属性内如果对进度条的值进行修改，使用myValue变量，而在其他地方，则用Value属性
		[Category("进度条"), Description("进度条的值"), Browsable(true)]
		public double Value
		{
			get { return myValue; }
			set
			{
				if (myValue < Minimum)
					throw new ArgumentException("小于最小值");
				if (myValue > Maximum)
					throw new ArgumentException("超过最大值");

				myValue = value;
				foreRect.Width = (int)(myValue / maximum * backRect.Width);

				if ((myValue - maximum) > 0)
				{
					foreRect.Width = backRect.Width;
				}

				setRect.X = (int)(foreRect.X + foreRect.Width - setRect.Width / 2);

				//如果添加了响应函数,则执行该函数
				if (OnValueChanged != null)
				{
					OnValueChanged(this, EventArgs.Empty);
				}

				Invalidate();
			}
		}
		#endregion

		#region 绘制控件
		//重载OnPaint方法对控件进行绘制
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			DrawRect(e.Graphics);
			if (ShowPercentTag)
			{
				DrawText(e.Graphics);
			}
		}

		//画进度条
		private void DrawRect(Graphics e)
		{
			Pen pen = new Pen(this.foregroundColor);

			e.FillRectangle(new SolidBrush(this.backgroundColor), backRect);
			e.DrawRectangle(new Pen(Color.Black), backRect);

			e.FillRectangle(new SolidBrush(this.foregroundColor), foreRect);
			e.DrawRectangle(new Pen(Color.Black), foreRect);

			e.FillEllipse(new SolidBrush(this.setRectColor), setRect.X, setRect.Y, setRect.Width, setRect.Height);
			e.DrawEllipse(new Pen(Color.Black), setRect.X, setRect.Y, setRect.Width, setRect.Height);
			//e.FillRectangle(new SolidBrush(this.setRectColor), setRect);
			//e.DrawRectangle(new Pen(Color.Black), setRect);
		}

		//画进度值
		private void DrawText(Graphics e)
		{
			Point point = new Point();
			point.X = this.backRect.X + this.backRect.Width * 3 / 7;
			point.Y = this.backRect.Y + this.backRect.Height / 3;

			SolidBrush brush = new SolidBrush(fontColor);
			Font font = new Font(myFontFamily, this.fontSize);
			string percent = ((int)this.myValue).ToString() + "%";

			StringFormat format = new StringFormat();
			format.Alignment = StringAlignment.Center;
			format.LineAlignment = StringAlignment.Center;

			e.DrawString(percent, font, brush, backRect, format);
		}
		#endregion

		#region 修改控件的大小
		//拖动边缘的箭头改变控件的大小时，控件也要做相应的改变时，就可以重载该方法，如果没有重载，就只有在修改完成后才更新控件
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Width = Width;
			this.Height = Height;
			Invalidate();
		}
		#endregion

		#region 拖动控制条
		//添加三个辅助变量，添加响应函数
		//当前鼠标位置
		Point originPoint;
		//当前控制块位置
		Point originsetRectPoint;
		//控制块是否点下
		bool setRectDown = false;

		public bool isdown
		{
			get { return setRectDown; }
		}

		//放开鼠标
		void MyProgressBar_MouseUp(object sender, MouseEventArgs e)
		{
			setRectDown = false;
		}

		//移动鼠标
		void MyProgressBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (setRectDown)
			{
				//移动长度
				int dd = e.Location.X - originPoint.X;
				//百分比
				double percent = (double)(originsetRectPoint.X + dd - this.backRect.X + setRect.Width / 2) / this.backRect.Width;
				if (percent < 0)
				{
					percent = 0;
				}
				else if (percent > 1)
				{

					percent = 1;
				}
				this.Value = percent * maximum;
				this.foreRect.Width = (int)(percent * this.backRect.Width);
				//this.setRect.X = originsetRectPoint.X + dd;
				this.setRect.X = (int)(foreRect.X + foreRect.Width - setRect.Width / 2);
				Invalidate();
			}
		}

		//点下鼠标
		void MyProgressBar_MouseDown(object sender, MouseEventArgs e)
		{
			if (setRect.Contains(e.Location))
			{
				this.originPoint = e.Location;
				originsetRectPoint = this.setRect.Location;
				this.setRectDown = true;
			}
		}
		#endregion
	}
	#endregion

}
