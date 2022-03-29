namespace QuanlyCanHoGiangTran
{
    partial class RemindApart
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
            this.dtgvRemindApart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRemindApart)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRemindApart
            // 
            this.dtgvRemindApart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRemindApart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRemindApart.Location = new System.Drawing.Point(2, 174);
            this.dtgvRemindApart.Name = "dtgvRemindApart";
            this.dtgvRemindApart.RowHeadersWidth = 82;
            this.dtgvRemindApart.RowTemplate.Height = 41;
            this.dtgvRemindApart.Size = new System.Drawing.Size(1808, 712);
            this.dtgvRemindApart.TabIndex = 0;
            // 
            // RemindApart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 1053);
            this.Controls.Add(this.dtgvRemindApart);
            this.Name = "RemindApart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remind Apart";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRemindApart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgvRemindApart;
    }
}