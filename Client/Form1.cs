using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;


// CLIENT


namespace Client
{
	public partial class Form1 : Form
	{

		private NetworkStream networkStream;
		private TcpClient client;

		private byte[] sendBuffer = new byte[1024 * 4];
		private byte[] readBuffer = new byte[1024 * 4];

		private bool isConnect = false;

		public Initialize initializeClass;
		public Login loginClass;
		public Send sendClass;



		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{ }

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			client.Close();
			networkStream.Close();
		}

		public void send()
		{
			networkStream.Write(sendBuffer, 0, sendBuffer.Length);
			networkStream.Flush();

			for (int i = 0; i < 1024 * 4; ++i)
			{
				sendBuffer[i] = 0;
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (!isConnect)
				return;

			Login login = new Login();
			login.type = (int)PackageType.login;
			login.strId = txtId.Text;
			// handle login Id is blank or empty
			if (login.strId == " " || login.strId == string.Empty)
			{
				MessageBox.Show("login ID can not be empty! Please fill in something...");
				return;
			}

			Package.serialize(login).CopyTo(sendBuffer, 0);
			send();

			// getCurrentUserInfo(txtId.Text.ToString().Trim());
		}


		// helper funtion that forwarding the textBox.Text from client to server
		private void getCurrentUserInfo(string infor)
		{
			if (!isConnect)
				return;

			Login login = new Login();
			login.type = (int)PackageType.login;
			login.strId = infor;
			// handle login Id is blank or empty
			if (login.strId == " " || login.strId == string.Empty)
			{
				MessageBox.Show("login ID can not be empty! Please fill in something...");
				return;
			}

			Package.serialize(login).CopyTo(sendBuffer, 0);
			send();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			client = new TcpClient();
			try
			{
				client.Connect(txtIp.Text, 7777);
			}
			catch (Exception ex)
			{
				MessageBox.Show("btnConnect_Click: " + ex.Message);
				return;
			}

			isConnect = true;
			networkStream = client.GetStream();
			MessageBox.Show("successfully connected to server.");
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			if (!isConnect)
				return;

			Send _send = new Send();
			_send.type = (int)PackageType.send;
			
			_send.answer = txtAnswer.Text;
			// handle answer is blank or empty
			if (_send.answer == " " || _send.answer == string.Empty)
			{
				MessageBox.Show("ANSWER can not be empty! Please guess anything...");
				return;
			}

			Package.serialize(_send).CopyTo(sendBuffer, 0);
			send();
		}
	}
}
