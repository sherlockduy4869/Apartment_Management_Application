namespace QuanlyCanHoGiangTran.OTHERS_FUNCTION_FORM
{
    partial class InformationDetail
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
            this.btnDetailInformation = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMaCanHo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetailInformation
            // 
            this.btnDetailInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetailInformation.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDetailInformation.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDetailInformation.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDetailInformation.BorderRadius = 40;
            this.btnDetailInformation.BorderSize = 0;
            this.btnDetailInformation.FlatAppearance.BorderSize = 0;
            this.btnDetailInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailInformation.ForeColor = System.Drawing.Color.White;
            this.btnDetailInformation.Location = new System.Drawing.Point(228, 330);
            this.btnDetailInformation.Name = "btnDetailInformation";
            this.btnDetailInformation.Size = new System.Drawing.Size(300, 80);
            this.btnDetailInformation.TabIndex = 7;
            this.btnDetailInformation.Text = "Detail Information";
            this.btnDetailInformation.TextColor = System.Drawing.Color.White;
            this.btnDetailInformation.UseVisualStyleBackColor = false;
            this.btnDetailInformation.Click += new System.EventHandler(this.btnDetailInformation_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txbMaCanHo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(79, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 163);
            this.panel1.TabIndex = 6;
            // 
            // txbMaCanHo
            // 
            this.txbMaCanHo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMaCanHo.ForeColor = System.Drawing.Color.Black;
            this.txbMaCanHo.Location = new System.Drawing.Point(194, 45);
            this.txbMaCanHo.Name = "txbMaCanHo";
            this.txbMaCanHo.Size = new System.Drawing.Size(370, 39);
            this.txbMaCanHo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma can ho";
            // 
            // InformationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 476);
            this.Controls.Add(this.btnDetailInformation);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(805, 547);
            this.Name = "InformationDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information Detail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.RJButton btnDetailInformation;
        private Panel panel1;
        private TextBox txbMaCanHo;
        private Label label1;
    }
}