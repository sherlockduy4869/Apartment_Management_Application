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
            this.btnTax = new System.Windows.Forms.Button();
            this.btnApart = new System.Windows.Forms.Button();
            this.pnCick = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnLeft.Controls.Add(this.btnHistory);
            this.pnLeft.Controls.Add(this.btnTax);
            this.pnLeft.Controls.Add(this.btnApart);
            this.pnLeft.Controls.Add(this.pnCick);
            this.pnLeft.Controls.Add(this.btnHome);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(349, 881);
            this.pnLeft.TabIndex = 0;
            // 
            // btnTax
            // 
            this.btnTax.FlatAppearance.BorderSize = 0;
            this.btnTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTax.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTax.ForeColor = System.Drawing.Color.White;
            this.btnTax.Image = ((System.Drawing.Image)(resources.GetObject("btnTax.Image")));
            this.btnTax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTax.Location = new System.Drawing.Point(12, 425);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(318, 110);
            this.btnTax.TabIndex = 55;
            this.btnTax.Text = "Taxes";
            this.btnTax.UseVisualStyleBackColor = true;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // btnApart
            // 
            this.btnApart.FlatAppearance.BorderSize = 0;
            this.btnApart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApart.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApart.ForeColor = System.Drawing.Color.White;
            this.btnApart.Image = ((System.Drawing.Image)(resources.GetObject("btnApart.Image")));
            this.btnApart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApart.Location = new System.Drawing.Point(12, 309);
            this.btnApart.Name = "btnApart";
            this.btnApart.Size = new System.Drawing.Size(318, 110);
            this.btnApart.TabIndex = 1;
            this.btnApart.Text = "Apart";
            this.btnApart.UseVisualStyleBackColor = true;
            this.btnApart.Click += new System.EventHandler(this.btnApart_Click);
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
            // btnHistory
            // 
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistory.Location = new System.Drawing.Point(12, 541);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(318, 110);
            this.btnHistory.TabIndex = 56;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 881);
            this.Controls.Add(this.pnLeft);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.pnLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnLeft;
        private Button btnTax;
        private Button btnApart;
        private Panel pnCick;
        private Button btnHome;
        private Button btnHistory;
    }
}