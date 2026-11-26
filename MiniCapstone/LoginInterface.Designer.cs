namespace MiniCapstone
{
    partial class LoginInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginInterface));
            this.btnLogin = new ReaLTaiizor.Controls.Button();
            this.txtBoxUsername = new ReaLTaiizor.Controls.BigTextBox();
            this.txtBoxPassword = new ReaLTaiizor.Controls.BigTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.pbShowPass = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.EnteredBorderColor = System.Drawing.Color.White;
            this.btnLogin.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = null;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.Location = new System.Drawing.Point(103, 506);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedBorderColor = System.Drawing.Color.Black;
            this.btnLogin.PressedColor = System.Drawing.Color.Silver;
            this.btnLogin.Size = new System.Drawing.Size(235, 50);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxUsername.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtBoxUsername.Image = null;
            this.txtBoxUsername.Location = new System.Drawing.Point(38, 346);
            this.txtBoxUsername.MaxLength = 32767;
            this.txtBoxUsername.Multiline = false;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.PlaceholderText = "Email";
            this.txtBoxUsername.ReadOnly = false;
            this.txtBoxUsername.Size = new System.Drawing.Size(365, 47);
            this.txtBoxUsername.TabIndex = 5;
            this.txtBoxUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxUsername.UseSystemPasswordChar = false;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxPassword.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtBoxPassword.Image = null;
            this.txtBoxPassword.Location = new System.Drawing.Point(38, 416);
            this.txtBoxPassword.MaxLength = 32767;
            this.txtBoxPassword.Multiline = false;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PlaceholderText = "Password";
            this.txtBoxPassword.ReadOnly = false;
            this.txtBoxPassword.Size = new System.Drawing.Size(365, 48);
            this.txtBoxPassword.TabIndex = 6;
            this.txtBoxPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(143)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(993, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbShowPass);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.dungeonLabel1);
            this.panel1.Controls.Add(this.txtBoxPassword);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtBoxUsername);
            this.panel1.EdgeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(440, 644);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 11;
            this.panel1.Text = "panel1";
            // 
            // pbShowPass
            // 
            this.pbShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowPass.Image = global::MiniCapstone.Properties.Resources.eyeclosed;
            this.pbShowPass.Location = new System.Drawing.Point(364, 425);
            this.pbShowPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbShowPass.Name = "pbShowPass";
            this.pbShowPass.Size = new System.Drawing.Size(30, 28);
            this.pbShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowPass.TabIndex = 9;
            this.pbShowPass.TabStop = false;
            this.pbShowPass.Click += new System.EventHandler(this.pbShowPass_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 86);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 223);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.Black;
            this.dungeonLabel1.Location = new System.Drawing.Point(55, 38);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(330, 46);
            this.dungeonLabel1.TabIndex = 7;
            this.dungeonLabel1.Text = "Log in your Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MiniCapstone.Properties.Resources.LOGOLOST;
            this.pictureBox1.Location = new System.Drawing.Point(439, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 644);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LoginInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1044, 644);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "LoginInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginInterface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.Button btnLogin;
        private ReaLTaiizor.Controls.BigTextBox txtBoxUsername;
        private ReaLTaiizor.Controls.BigTextBox txtBoxPassword;
        private System.Windows.Forms.Button btnExit;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pbShowPass;
	}
}

