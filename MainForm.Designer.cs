namespace QuanlyCanHoGiangTran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnCick = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnClubMemberInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnLeft.Controls.Add(this.button1);
            this.pnLeft.Controls.Add(this.btnClubMemberInfo);
            this.pnLeft.Controls.Add(this.pnCick);
            this.pnLeft.Controls.Add(this.btnHome);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(349, 881);
            this.pnLeft.TabIndex = 0;
            // 
            // pnCick
            // 
            this.pnCick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnCick.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnCick.Location = new System.Drawing.Point(12, 183);
            this.pnCick.Name = "pnCick";
            this.pnCick.Size = new System.Drawing.Size(25, 110);
            this.pnCick.TabIndex = 54;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(9, 183);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(318, 110);
            this.btnHome.TabIndex = 53;
            this.btnHome.Text = "   Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnClubMemberInfo
            // 
            this.btnClubMemberInfo.FlatAppearance.BorderSize = 0;
            this.btnClubMemberInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClubMemberInfo.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClubMemberInfo.ForeColor = System.Drawing.Color.White;
            this.btnClubMemberInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnClubMemberInfo.Image")));
            this.btnClubMemberInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClubMemberInfo.Location = new System.Drawing.Point(12, 309);
            this.btnClubMemberInfo.Name = "btnClubMemberInfo";
            this.btnClubMemberInfo.Size = new System.Drawing.Size(318, 110);
            this.btnClubMemberInfo.TabIndex = 1;
            this.btnClubMemberInfo.Text = "        Member ";
            this.btnClubMemberInfo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(12, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 110);
            this.button1.TabIndex = 55;
            this.button1.Text = "        Member ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 881);
            this.Controls.Add(this.pnLeft);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnLeft;
        private Button button1;
        private Button btnClubMemberInfo;
        private Panel pnCick;
        private Button btnHome;
    }
}