namespace QuanlyCanHoGiangTran
{
    partial class ShowInfoApart
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
            this.dtgvApartInfo = new System.Windows.Forms.DataGridView();
            this.btnAdd = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.btnRemove = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.btnExpire = new QuanlyCanHoGiangTran.Custom.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvApartInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(675, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFORMATION OF ALL APARTMENT";
            // 
            // dtgvApartInfo
            // 
            this.dtgvApartInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvApartInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvApartInfo.Location = new System.Drawing.Point(12, 198);
            this.dtgvApartInfo.Name = "dtgvApartInfo";
            this.dtgvApartInfo.RowHeadersWidth = 82;
            this.dtgvApartInfo.RowTemplate.Height = 41;
            this.dtgvApartInfo.Size = new System.Drawing.Size(2144, 680);
            this.dtgvApartInfo.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 40;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(224, 966);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(300, 80);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRemove.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRemove.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemove.BorderRadius = 40;
            this.btnRemove.BorderSize = 0;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(929, 966);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(300, 80);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextColor = System.Drawing.Color.White;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExpire
            // 
            this.btnExpire.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExpire.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExpire.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExpire.BorderRadius = 40;
            this.btnExpire.BorderSize = 0;
            this.btnExpire.FlatAppearance.BorderSize = 0;
            this.btnExpire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpire.ForeColor = System.Drawing.Color.White;
            this.btnExpire.Location = new System.Drawing.Point(1582, 966);
            this.btnExpire.Name = "btnExpire";
            this.btnExpire.Size = new System.Drawing.Size(300, 80);
            this.btnExpire.TabIndex = 4;
            this.btnExpire.Text = "Expire";
            this.btnExpire.TextColor = System.Drawing.Color.White;
            this.btnExpire.UseVisualStyleBackColor = false;
            this.btnExpire.Click += new System.EventHandler(this.btnExpire_Click);
            // 
            // ShowInfoApart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2168, 1104);
            this.Controls.Add(this.btnExpire);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvApartInfo);
            this.Controls.Add(this.label1);
            this.Name = "ShowInfoApart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Info Apart";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvApartInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dtgvApartInfo;
        private Custom.RJButton btnAdd;
        private Custom.RJButton btnRemove;
        private Custom.RJButton btnExpire;
    }
}