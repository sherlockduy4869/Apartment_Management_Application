namespace QuanlyCanHoGiangTran
{
    partial class MarkDone
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMaCanHo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMarkDone = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txbMaCanHo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(79, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 137);
            this.panel1.TabIndex = 0;
            // 
            // txbMaCanHo
            // 
            this.txbMaCanHo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMaCanHo.ForeColor = System.Drawing.Color.Black;
            this.txbMaCanHo.Location = new System.Drawing.Point(194, 45);
            this.txbMaCanHo.Name = "txbMaCanHo";
            this.txbMaCanHo.Size = new System.Drawing.Size(389, 39);
            this.txbMaCanHo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma can ho";
            // 
            // btnMarkDone
            // 
            this.btnMarkDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkDone.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMarkDone.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMarkDone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMarkDone.BorderRadius = 40;
            this.btnMarkDone.BorderSize = 0;
            this.btnMarkDone.FlatAppearance.BorderSize = 0;
            this.btnMarkDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkDone.ForeColor = System.Drawing.Color.White;
            this.btnMarkDone.Location = new System.Drawing.Point(231, 303);
            this.btnMarkDone.Name = "btnMarkDone";
            this.btnMarkDone.Size = new System.Drawing.Size(300, 80);
            this.btnMarkDone.TabIndex = 1;
            this.btnMarkDone.Text = "MarkDone";
            this.btnMarkDone.TextColor = System.Drawing.Color.White;
            this.btnMarkDone.UseVisualStyleBackColor = false;
            this.btnMarkDone.Click += new System.EventHandler(this.btnMarkDone_Click);
            // 
            // MarkDone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 476);
            this.Controls.Add(this.btnMarkDone);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(805, 547);
            this.Name = "MarkDone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarkDone";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txbMaCanHo;
        private Label label1;
        private Custom.RJButton btnMarkDone;
    }
}