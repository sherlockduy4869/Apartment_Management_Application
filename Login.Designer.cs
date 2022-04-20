namespace QuanlyCanHoGiangTran
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnUserName = new System.Windows.Forms.Panel();
            this.pnUnderUserName = new System.Windows.Forms.Panel();
            this.picUserName = new System.Windows.Forms.PictureBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.pnUnderPassword = new System.Windows.Forms.Panel();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.btnLogin = new QuanlyCanHoGiangTran.Custom.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserName)).BeginInit();
            this.pnPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(477, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1017, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 84);
            this.btnExit.TabIndex = 12;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pnUserName
            // 
            this.pnUserName.Controls.Add(this.pnUnderUserName);
            this.pnUserName.Controls.Add(this.picUserName);
            this.pnUserName.Controls.Add(this.txbUserName);
            this.pnUserName.Location = new System.Drawing.Point(151, 438);
            this.pnUserName.Name = "pnUserName";
            this.pnUserName.Size = new System.Drawing.Size(805, 98);
            this.pnUserName.TabIndex = 13;
            // 
            // pnUnderUserName
            // 
            this.pnUnderUserName.BackColor = System.Drawing.Color.White;
            this.pnUnderUserName.Location = new System.Drawing.Point(16, 73);
            this.pnUnderUserName.Name = "pnUnderUserName";
            this.pnUnderUserName.Size = new System.Drawing.Size(770, 1);
            this.pnUnderUserName.TabIndex = 11;
            // 
            // picUserName
            // 
            this.picUserName.Image = ((System.Drawing.Image)(resources.GetObject("picUserName.Image")));
            this.picUserName.Location = new System.Drawing.Point(16, 14);
            this.picUserName.Name = "picUserName";
            this.picUserName.Size = new System.Drawing.Size(61, 70);
            this.picUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserName.TabIndex = 11;
            this.picUserName.TabStop = false;
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txbUserName.Location = new System.Drawing.Point(83, 28);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(703, 37);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.Text = "admin1";
            this.txbUserName.Click += new System.EventHandler(this.txbUserName_Click);
            // 
            // pnPassword
            // 
            this.pnPassword.Controls.Add(this.pnUnderPassword);
            this.pnPassword.Controls.Add(this.picPassword);
            this.pnPassword.Controls.Add(this.txbPassWord);
            this.pnPassword.Location = new System.Drawing.Point(151, 579);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(805, 91);
            this.pnPassword.TabIndex = 14;
            // 
            // pnUnderPassword
            // 
            this.pnUnderPassword.BackColor = System.Drawing.Color.White;
            this.pnUnderPassword.Location = new System.Drawing.Point(16, 68);
            this.pnUnderPassword.Name = "pnUnderPassword";
            this.pnUnderPassword.Size = new System.Drawing.Size(770, 1);
            this.pnUnderPassword.TabIndex = 12;
            // 
            // picPassword
            // 
            this.picPassword.Image = ((System.Drawing.Image)(resources.GetObject("picPassword.Image")));
            this.picPassword.Location = new System.Drawing.Point(16, 11);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(61, 70);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassword.TabIndex = 12;
            this.picPassword.TabStop = false;
            // 
            // txbPassWord
            // 
            this.txbPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txbPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPassWord.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txbPassWord.Location = new System.Drawing.Point(82, 25);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(704, 37);
            this.txbPassWord.TabIndex = 1;
            this.txbPassWord.Text = "123456";
            this.txbPassWord.UseSystemPasswordChar = true;
            this.txbPassWord.Click += new System.EventHandler(this.txbPassWord_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 40;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(397, 739);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 80);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1107, 1109);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnUserName);
            this.Controls.Add(this.pnPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnUserName.ResumeLayout(false);
            this.pnUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserName)).EndInit();
            this.pnPassword.ResumeLayout(false);
            this.pnPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnExit;
        private Panel pnUserName;
        private Panel pnUnderUserName;
        private PictureBox picUserName;
        private TextBox txbUserName;
        private Panel pnPassword;
        private Panel pnUnderPassword;
        private PictureBox picPassword;
        private TextBox txbPassWord;
        private Custom.RJButton btnLogin;
    }
}