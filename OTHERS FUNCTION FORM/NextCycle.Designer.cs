namespace QuanlyCanHoGiangTran
{
    partial class NextCycle
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
            this.btnNextCyle = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaCanHo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNextCyle
            // 
            this.btnNextCyle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNextCyle.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNextCyle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNextCyle.BorderRadius = 40;
            this.btnNextCyle.BorderSize = 0;
            this.btnNextCyle.FlatAppearance.BorderSize = 0;
            this.btnNextCyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCyle.ForeColor = System.Drawing.Color.White;
            this.btnNextCyle.Location = new System.Drawing.Point(234, 242);
            this.btnNextCyle.Name = "btnNextCyle";
            this.btnNextCyle.Size = new System.Drawing.Size(300, 80);
            this.btnNextCyle.TabIndex = 3;
            this.btnNextCyle.Text = "NextCycle";
            this.btnNextCyle.TextColor = System.Drawing.Color.White;
            this.btnNextCyle.UseVisualStyleBackColor = false;
            this.btnNextCyle.Click += new System.EventHandler(this.btnNextCyle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMaCanHo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(79, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 111);
            this.panel1.TabIndex = 2;
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
            // txbMaCanHo
            // 
            this.txbMaCanHo.Location = new System.Drawing.Point(221, 45);
            this.txbMaCanHo.Name = "txbMaCanHo";
            this.txbMaCanHo.Size = new System.Drawing.Size(390, 39);
            this.txbMaCanHo.TabIndex = 1;
            // 
            // NextCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.btnNextCyle);
            this.Controls.Add(this.panel1);
            this.Name = "NextCycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NextCycle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.RJButton btnNextCyle;
        private Panel panel1;
        private Label label1;
        private TextBox txbMaCanHo;
    }
}