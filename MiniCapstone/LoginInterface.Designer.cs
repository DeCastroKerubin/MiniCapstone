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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new ReaLTaiizor.Controls.Button();
            this.txtBoxUsername = new ReaLTaiizor.Controls.BigTextBox();
            this.txtBoxPassword = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLogin.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogin.Image = null;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnLogin.Location = new System.Drawing.Point(131, 360);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLogin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnLogin.Size = new System.Drawing.Size(260, 57);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxUsername.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBoxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxUsername.Image = null;
            this.txtBoxUsername.Location = new System.Drawing.Point(81, 181);
            this.txtBoxUsername.MaxLength = 32767;
            this.txtBoxUsername.Multiline = false;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.ReadOnly = false;
            this.txtBoxUsername.Size = new System.Drawing.Size(365, 41);
            this.txtBoxUsername.TabIndex = 5;
            this.txtBoxUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxUsername.UseSystemPasswordChar = false;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxPassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBoxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxPassword.Image = null;
            this.txtBoxPassword.Location = new System.Drawing.Point(81, 276);
            this.txtBoxPassword.MaxLength = 32767;
            this.txtBoxPassword.Multiline = false;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.ReadOnly = false;
            this.txtBoxPassword.Size = new System.Drawing.Size(365, 41);
            this.txtBoxPassword.TabIndex = 6;
            this.txtBoxPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxPassword.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bigLabel1.Location = new System.Drawing.Point(173, 36);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(180, 46);
            this.bigLabel1.TabIndex = 7;
            this.bigLabel1.Text = "Staff Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(526, 87);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 8;
            this.panel1.Text = "panel1";
            // 
            // LoginInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(524, 485);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginInterface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.Button btnLogin;
        private ReaLTaiizor.Controls.BigTextBox txtBoxUsername;
        private ReaLTaiizor.Controls.BigTextBox txtBoxPassword;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.Panel panel1;
    }
}

