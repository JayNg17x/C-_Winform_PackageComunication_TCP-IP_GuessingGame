
namespace WindowsForms_SWA_Assignment2
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.newButton = new System.Windows.Forms.ToolBarButton();
			this.lineButton = new System.Windows.Forms.ToolBarButton();
			this.rectButton = new System.Windows.Forms.ToolBarButton();
			this.circleButton = new System.Windows.Forms.ToolBarButton();
			this.line0Button = new System.Windows.Forms.ToolBarButton();
			this.line1Button = new System.Windows.Forms.ToolBarButton();
			this.line2Button = new System.Windows.Forms.ToolBarButton();
			this.line7Button = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSend = new System.Windows.Forms.Button();
			this.lbl_signal = new System.Windows.Forms.Label();
			this.lbl_Id = new System.Windows.Forms.Label();
			this.txtSignal = new System.Windows.Forms.TextBox();
			this.txtIdConn = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.newButton,
            this.lineButton,
            this.rectButton,
            this.circleButton,
            this.line0Button,
            this.line1Button,
            this.line2Button,
            this.line7Button});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(800, 28);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// newButton
			// 
			this.newButton.ImageIndex = 0;
			this.newButton.Name = "newButton";
			// 
			// lineButton
			// 
			this.lineButton.ImageIndex = 1;
			this.lineButton.Name = "lineButton";
			// 
			// rectButton
			// 
			this.rectButton.ImageIndex = 2;
			this.rectButton.Name = "rectButton";
			// 
			// circleButton
			// 
			this.circleButton.ImageIndex = 3;
			this.circleButton.Name = "circleButton";
			// 
			// line0Button
			// 
			this.line0Button.ImageIndex = 4;
			this.line0Button.Name = "line0Button";
			// 
			// line1Button
			// 
			this.line1Button.ImageIndex = 5;
			this.line1Button.Name = "line1Button";
			// 
			// line2Button
			// 
			this.line2Button.ImageIndex = 6;
			this.line2Button.Name = "line2Button";
			// 
			// line7Button
			// 
			this.line7Button.ImageIndex = 7;
			this.line7Button.Name = "line7Button";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "new_image.png");
			this.imageList1.Images.SetKeyName(1, "line_image.png");
			this.imageList1.Images.SetKeyName(2, "rect_image.png");
			this.imageList1.Images.SetKeyName(3, "circle_image.png");
			this.imageList1.Images.SetKeyName(4, "line0_image.png");
			this.imageList1.Images.SetKeyName(5, "line1_image.png");
			this.imageList1.Images.SetKeyName(6, "line2_image.png");
			this.imageList1.Images.SetKeyName(7, "line3_image.png");
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSend);
			this.panel1.Controls.Add(this.lbl_signal);
			this.panel1.Controls.Add(this.lbl_Id);
			this.panel1.Controls.Add(this.txtSignal);
			this.panel1.Controls.Add(this.txtIdConn);
			this.panel1.Location = new System.Drawing.Point(0, 34);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 53);
			this.panel1.TabIndex = 1;
			// 
			// btnSend
			// 
			this.btnSend.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSend.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSend.Location = new System.Drawing.Point(652, 14);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 2;
			this.btnSend.Text = "전송";
			this.btnSend.UseVisualStyleBackColor = false;
			// 
			// lbl_signal
			// 
			this.lbl_signal.AutoSize = true;
			this.lbl_signal.Location = new System.Drawing.Point(303, 19);
			this.lbl_signal.Name = "lbl_signal";
			this.lbl_signal.Size = new System.Drawing.Size(41, 12);
			this.lbl_signal.TabIndex = 1;
			this.lbl_signal.Text = "제시어";
			// 
			// lbl_Id
			// 
			this.lbl_Id.AutoSize = true;
			this.lbl_Id.Location = new System.Drawing.Point(12, 19);
			this.lbl_Id.Name = "lbl_Id";
			this.lbl_Id.Size = new System.Drawing.Size(44, 12);
			this.lbl_Id.TabIndex = 1;
			this.lbl_Id.Text = "접속 ID";
			// 
			// txtSignal
			// 
			this.txtSignal.Location = new System.Drawing.Point(361, 16);
			this.txtSignal.Name = "txtSignal";
			this.txtSignal.Size = new System.Drawing.Size(135, 21);
			this.txtSignal.TabIndex = 0;
			// 
			// txtIdConn
			// 
			this.txtIdConn.Location = new System.Drawing.Point(86, 16);
			this.txtIdConn.Name = "txtIdConn";
			this.txtIdConn.ReadOnly = true;
			this.txtIdConn.Size = new System.Drawing.Size(139, 21);
			this.txtIdConn.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Location = new System.Drawing.Point(0, 105);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 344);
			this.panel2.TabIndex = 1;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
			this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolBar1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton newButton;
		private System.Windows.Forms.ToolBarButton lineButton;
		private System.Windows.Forms.ToolBarButton rectButton;
		private System.Windows.Forms.ToolBarButton circleButton;
		private System.Windows.Forms.ToolBarButton line0Button;
		private System.Windows.Forms.ToolBarButton line1Button;
		private System.Windows.Forms.ToolBarButton line2Button;
		private System.Windows.Forms.ToolBarButton line3Button;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Label lbl_signal;
		private System.Windows.Forms.Label lbl_Id;
		private System.Windows.Forms.TextBox txtSignal;
		private System.Windows.Forms.TextBox txtIdConn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolBarButton line7Button;
	}
}

