﻿namespace QuanlyCanHoGiangTran
{
    partial class ExpireApart
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
            this.btnExpireApart = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMaCanHo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExpireApart
            // 
            this.btnExpireApart.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExpireApart.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExpireApart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExpireApart.BorderRadius = 40;
            this.btnExpireApart.BorderSize = 0;
            this.btnExpireApart.FlatAppearance.BorderSize = 0;
            this.btnExpireApart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpireApart.ForeColor = System.Drawing.Color.White;
            this.btnExpireApart.Location = new System.Drawing.Point(226, 261);
            this.btnExpireApart.Name = "btnExpireApart";
            this.btnExpireApart.Size = new System.Drawing.Size(300, 80);
            this.btnExpireApart.TabIndex = 3;
            this.btnExpireApart.Text = "Expire";
            this.btnExpireApart.TextColor = System.Drawing.Color.White;
            this.btnExpireApart.UseVisualStyleBackColor = false;
            this.btnExpireApart.Click += new System.EventHandler(this.btnExpireApart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMaCanHo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(79, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 111);
            this.panel1.TabIndex = 2;
            // 
            // txbMaCanHo
            // 
            this.txbMaCanHo.ForeColor = System.Drawing.Color.Black;
            this.txbMaCanHo.Location = new System.Drawing.Point(194, 45);
            this.txbMaCanHo.Name = "txbMaCanHo";
            this.txbMaCanHo.Size = new System.Drawing.Size(428, 39);
            this.txbMaCanHo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma can ho";
            // 
            // ExpireApart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExpireApart);
            this.Controls.Add(this.panel1);
            this.Name = "ExpireApart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expire Apart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.RJButton btnExpireApart;
        private Panel panel1;
        private TextBox txbMaCanHo;
        private Label label1;
    }
}