namespace QuanlyCanHoGiangTran.OTHERS_FUNCTION_FORM
{
    partial class DoneNegotiation
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
            this.btnDoneNegotiation = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMaCanHo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoneNegotiation
            // 
            this.btnDoneNegotiation.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDoneNegotiation.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDoneNegotiation.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDoneNegotiation.BorderRadius = 40;
            this.btnDoneNegotiation.BorderSize = 0;
            this.btnDoneNegotiation.FlatAppearance.BorderSize = 0;
            this.btnDoneNegotiation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoneNegotiation.ForeColor = System.Drawing.Color.White;
            this.btnDoneNegotiation.Location = new System.Drawing.Point(226, 261);
            this.btnDoneNegotiation.Name = "btnDoneNegotiation";
            this.btnDoneNegotiation.Size = new System.Drawing.Size(300, 80);
            this.btnDoneNegotiation.TabIndex = 3;
            this.btnDoneNegotiation.Text = "Done Negotiation";
            this.btnDoneNegotiation.TextColor = System.Drawing.Color.White;
            this.btnDoneNegotiation.UseVisualStyleBackColor = false;
            this.btnDoneNegotiation.Click += new System.EventHandler(this.btnDoneNegotiation_Click);
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
            // DoneNegotiation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoneNegotiation);
            this.Controls.Add(this.panel1);
            this.Name = "DoneNegotiation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Done Negotiation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.RJButton btnDoneNegotiation;
        private Panel panel1;
        private TextBox txbMaCanHo;
        private Label label1;
    }
}