using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using ClassLibrary;
using System.Drawing;
using System.Drawing.Drawing2D;


// SERVER 

namespace WindowsForms_SWA_Assignment2
{
	public partial class Form1 : Form
	{
		// random signal text init
		private List<string> signalsList = new List<string>() { "strait line", "triangle", "ball", "tree"};
		Random rand = new Random();


		// for drawing 
		private bool line;
		private bool rect;
		private bool circle;
		private Point start;
		private Point end;
		private Pen pen;
		private int nLine;
		private int nRect;
		private int nCircle;
		private int i;
		private int thick;
		private bool isSolid;
		private MyLines[] myLines;
		private MyCircle[] myCircles;
		private MyRect[] myRects;


		// for socket 
		private NetworkStream networkStream;
		private TcpListener listener;

		private byte[] sendBuffer = new byte[1024 * 4];
		private byte[] readBuffer = new byte[1024 * 4];

		private bool isClientOn = false;

		private Thread thread;

		// 
		public Login loginClass;
		public Send sendClass;

		public Form1()
		{
			InitializeComponent();
			setupVar();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			thread = new Thread(new ThreadStart(run));
			thread.Start();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			listener.Stop();
			networkStream.Close();
			thread.Abort();
		}

		public void run()
		{
			listener = new TcpListener(7777);
			listener.Start();

			if (!isClientOn)
			{
				Invoke(new MethodInvoker(delegate ()
				{
					txtIdConn.Text += "";
				}));
			}

			TcpClient client = listener.AcceptTcpClient();
			if (client.Connected)
			{
				isClientOn = true;
				Invoke(new MethodInvoker(delegate ()
				{
					MessageBox.Show("client is connecting...");
					txtIdConn.Text += "";
				}));

				networkStream = client.GetStream();
			}

			int read = 0;

			while (isClientOn)
			{
				try
				{
					read = 0;
					read = networkStream.Read(readBuffer, 0, 1024 * 4);
				}
				catch
				{
					isClientOn = false;
					networkStream = null;
				}

				Package package = (Package)Package.desserialize(readBuffer);
				
				// login case 
				switch ((int)package.type)
				{
					case (int)PackageType.login:
					{
						loginClass = (Login)Package.desserialize(readBuffer);
						Invoke(new MethodInvoker(delegate ()
						{
							// receive forwarding of loginText ID from client
							txtIdConn.Text += loginClass.strId;

							// make current textBox readonly
							txtIdConn.ReadOnly = true;

							// add random signal in Signal textBox
							getRandomSignalText();

							/*int index = rand.Next(signalsList.Count);
							txtSignal.Text += signalsList[index].ToString();*/
						}));
						break;
					}

					// send case
					case (int)PackageType.send:
					{
						sendClass = (Send)Package.desserialize(readBuffer);
						Invoke(new MethodInvoker(delegate ()
						{
							if (sendClass.answer == txtSignal.Text)
							{
								MessageBox.Show("정답입니다!!!");
								// 정답이면 한번더 재밌게 할까요?
								getRandomSignalText();
							}
							else
							{
								MessageBox.Show("오답입니다 :(");
								return;
							}
						}));
						break;
					}

				}
			}
		}

		// helper function to get current random signal text
		private void getRandomSignalText()
		{
			int index = rand.Next(signalsList.Count);

			// if it is 정답
			// then we need to erase the current text for the next player
			if (txtSignal.Text == " " || string.IsNullOrEmpty(txtSignal.Text))
				txtSignal.Text += signalsList[index].ToString();
			else
			{
				txtSignal.Text = "";
				txtSignal.Text += signalsList[index].ToString();
			}

			// make current textBox readonly
			txtSignal.ReadOnly = true;

		}

		/// <summary>
		/// drawing events handling & helper functions
		// ** 프로그램 진행잘 되었지만 갑자기 bug이 생거셔 toolbar에 있는 line3Button comment 했습니다.
		// 시간이 늦었으리깐 안 추가하고 제출합니다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button == newButton)
			{
				this.lineButton.Pushed = false;
				this.rectButton.Pushed = false;
				this.circleButton.Pushed = false;

				setupVar();
				panel1.Refresh();
			}

			if (e.Button == lineButton)
			{
				line = true;
				rect = false;
				circle = false;

				this.lineButton.Pushed = true;
				this.rectButton.Pushed = false;
				this.circleButton.Pushed = false;
			}
			
			if (e.Button == rectButton)
			{
				line = false;
				rect = true;
				circle = false;

				this.lineButton.Pushed = false;
				this.rectButton.Pushed = true;
				this.circleButton.Pushed = false;
			}

			if (e.Button == circleButton)
			{
				line = false;
				rect = false;
				circle = true;
			}

			if (e.Button == line0Button)
			{
				isSolid = false;
				thick = 1;

				this.line0Button.Pushed = true;
				this.line1Button.Pushed = false;
				this.line2Button.Pushed = false;
				// this.line3Button.Pushed = false;
			}

			if (e.Button == line1Button)
			{
				thick = 1;
				isSolid = true;

				this.line0Button.Pushed = false;
				this.line1Button.Pushed = true;
				this.line2Button.Pushed = false;
				// this.line3Button.Pushed = false;
			}

			if (e.Button == line1Button)
			{
				thick = 1;
				isSolid = true;

				this.line0Button.Pushed = false;
				this.line1Button.Pushed = true;
				this.line2Button.Pushed = false;
				// this.line3Button.Pushed = false;
			}

			if (e.Button == line2Button)
			{
				thick = 3;
				isSolid = true;

				this.line0Button.Pushed = false;
				this.line1Button.Pushed = false;
				this.line2Button.Pushed = true;
				// this.line3Button.Pushed = false;
			}

			if (e.Button == line3Button)
			{
				thick = 5;
				isSolid = true;

				this.line0Button.Pushed = false;
				this.line1Button.Pushed = false;
				this.line2Button.Pushed = false;
				// this.line3Button.Pushed = true;
			}
		}

		private void setupVar()
		{
			i = 0;
			thick = 1;
			isSolid = true;
			line = false;
			rect = false;
			circle = false;
			start = new Point(0, 0);
			end = new Point(0, 0);
			pen = new Pen(Color.Black);
			myLines = new MyLines[100];
			myRects = new MyRect[100];
			myCircles = new MyCircle[100];
			nLine = 0;
			nRect = 0;
			nCircle = 0;

			line0Button.Pushed = false;
			line1Button.Pushed = true;
			line2Button.Pushed = false;
			// line3Button.Pushed = false;

			setupMine();
		}

		private void setupMine()
		{
			for (int i = 0; i < 100; ++i)
				myLines[i] = new MyLines();
			for (int i = 0; i < 100; ++i)
				myCircles[i] = new MyCircle();
			for (int i = 0; i < 100; ++i)
				myRects[i] = new MyRect();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			for (i = 0; i <= nLine; i++)
			{
				if (!myLines[i].getSolid())
				{
					pen.Width = 1;
					pen.DashStyle = DashStyle.Dot;
				}
				else
				{
					pen.Width = myLines[i].getThick();
					pen.Width = 1;
					pen.DashStyle = DashStyle.Solid;
				}

				e.Graphics.DrawLine(pen, myLines[i].getPoint1(), myLines[i].getPoint2());
			} 

			for (i = 0; i <= nRect; ++i)
			{
				if (!myRects[i].getSolid())
				{
					pen.Width = 1;
					pen.DashStyle = DashStyle.Solid;
				}
				else
				{
					pen.Width = myRects[i].getThick();
					pen.DashStyle = DashStyle.Solid;
				}

				e.Graphics.DrawRectangle(pen, myRects[i].getRect());
			} 

			for (i = 0; i <= nCircle; ++i)
			{
				if (!myCircles[i].getSolid())
				{
					pen.Width = 1;
					pen.DashStyle = DashStyle.Solid;
				}
				else
				{
					pen.Width = myCircles[i].getThick();
					pen.DashStyle = DashStyle.Solid;
				}

				e.Graphics.DrawEllipse(pen, myCircles[i].GetRectC());
			}

			pen.Width = thick;
			pen.DashStyle = DashStyle.Solid;
		}

		private void panel2_MouseUp(object sender, MouseEventArgs e)
		{
			if (line == true) 
				nLine++;

			if (rect == true)
				nRect++;

			if (circle == true)
				nCircle++;

			start.X = 0;
			start.Y = 0;
			end.X = 0;
			end.Y = 0;
		}

		private void panel2_MouseMove(object sender, MouseEventArgs e)
		{
			if ((start.X == 0) && (start.Y == 0))
				return;

			end.X = e.X;
			end.Y = e.Y;

			if (line == true)
				myLines[nLine].setPoint(start, end, thick, isSolid);

			if (rect == true)
				myRects[nRect].setRect(start, end, thick, isSolid);

			if (circle == true)
				myCircles[nCircle].setRectC(start, end, thick, isSolid);

			panel2.Invalidate(true);
			panel2.Update();
		}

		private void panel2_MouseDown(object sender, MouseEventArgs e)
		{
			start.X = e.X;
			start.Y = e.Y;
		}
	}
}
