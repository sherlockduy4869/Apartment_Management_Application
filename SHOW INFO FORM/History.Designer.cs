namespace QuanlyCanHoGiangTran
{
    partial class History
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
            this.dtgvHistory = new System.Windows.Forms.DataGridView();
            this.btnExit = new QuanlyCanHoGiangTran.Custom.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(608, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1009, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFORMATION OF EXPIRED APARTMENT";
            // 
            // dtgvHistory
            // 
            this.dtgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistory.Location = new System.Drawing.Point(12, 197);
            this.dtgvHistory.Name = "dtgvHistory";
            this.dtgvHistory.RowHeadersWidth = 82;
            this.dtgvHistory.RowTemplate.Height = 41;
            this.dtgvHistory.Size = new System.Drawing.Size(2144, 680);
            this.dtgvHistory.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 40;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(963, 922);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 80);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2168, 1043);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtgvHistory);
            this.Controls.Add(this.label1);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dtgvHistory;
        private Custom.RJButton btnExit;
    }
}