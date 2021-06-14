
namespace Client
{
	partial class Form1
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.lbl_Id = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.lbl_Ip = new System.Windows.Forms.Label();
			this.txtIp = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(241, 12);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lbl_Id
			// 
			this.lbl_Id.AutoSize = true;
			this.lbl_Id.Location = new System.Drawing.Point(12, 18);
			this.lbl_Id.Name = "lbl_Id";
			this.lbl_Id.Size = new System.Drawing.Size(16, 12);
			this.lbl_Id.TabIndex = 1;
			this.lbl_Id.Text = "ID";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(67, 12);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(159, 21);
			this.txtId.TabIndex = 2;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(241, 49);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = " Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// lbl_Ip
			// 
			this.lbl_Ip.AutoSize = true;
			this.lbl_Ip.Location = new System.Drawing.Point(12, 55);
			this.lbl_Ip.Name = "lbl_Ip";
			this.lbl_Ip.Size = new System.Drawing.Size(16, 12);
			this.lbl_Ip.TabIndex = 1;
			this.lbl_Ip.Text = "IP";
			// 
			// txtIp
			// 
			this.txtIp.Location = new System.Drawing.Point(67, 49);
			this.txtIp.Name = "txtIp";
			this.txtIp.Size = new System.Drawing.Size(159, 21);
			this.txtIp.TabIndex = 2;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(241, 87);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "정답";
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point(67, 87);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(159, 21);
			this.txtAnswer.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 130);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(797, 349);
			this.panel1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 482);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtAnswer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIp);
			this.Controls.Add(this.lbl_Ip);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.lbl_Id);
			this.Controls.Add(this.btnLogin);
			this.Name = "Form1";
			this.Text = "Client";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lbl_Id;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Label lbl_Ip;
		private System.Windows.Forms.TextBox txtIp;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Panel panel1;
	}
}

