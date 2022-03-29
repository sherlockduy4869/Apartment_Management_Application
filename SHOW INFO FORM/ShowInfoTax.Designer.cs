namespace QuanlyCanHoGiangTran
{
    partial class ShowInfoTax
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
            this.dtgvApartTax = new System.Windows.Forms.DataGridView();
            this.btnMarkDone = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.btnReDo = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.btnNextCycle = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.btnRefresh = new QuanlyCanHoGiangTran.Custom.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvApartTax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(370, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1111, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIST APARTMENT NEED TO COLLECT MONEY";
            // 
            // dtgvApartTax
            // 
            this.dtgvApartTax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvApartTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvApartTax.Location = new System.Drawing.Point(12, 192);
            this.dtgvApartTax.Name = "dtgvApartTax";
            this.dtgvApartTax.RowHeadersWidth = 82;
            this.dtgvApartTax.RowTemplate.Height = 41;
            this.dtgvApartTax.Size = new System.Drawing.Size(1759, 744);
            this.dtgvApartTax.TabIndex = 1;
            this.dtgvApartTax.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvApartTax_CellFormatting);
            // 
            // btnMarkDone
            // 
            this.btnMarkDone.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMarkDone.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMarkDone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMarkDone.BorderRadius = 40;
            this.btnMarkDone.BorderSize = 0;
            this.btnMarkDone.FlatAppearance.BorderSize = 0;
            this.btnMarkDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkDone.ForeColor = System.Drawing.Color.White;
            this.btnMarkDone.Location = new System.Drawing.Point(179, 1020);
            this.btnMarkDone.Name = "btnMarkDone";
            this.btnMarkDone.Size = new System.Drawing.Size(300, 80);
            this.btnMarkDone.TabIndex = 2;
            this.btnMarkDone.Text = "Mark Done";
            this.btnMarkDone.TextColor = System.Drawing.Color.White;
            this.btnMarkDone.UseVisualStyleBackColor = false;
            this.btnMarkDone.Click += new System.EventHandler(this.btnMarkDone_Click);
            // 
            // btnReDo
            // 
            this.btnReDo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReDo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReDo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReDo.BorderRadius = 40;
            this.btnReDo.BorderSize = 0;
            this.btnReDo.FlatAppearance.BorderSize = 0;
            this.btnReDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReDo.ForeColor = System.Drawing.Color.White;
            this.btnReDo.Location = new System.Drawing.Point(756, 1020);
            this.btnReDo.Name = "btnReDo";
            this.btnReDo.Size = new System.Drawing.Size(300, 80);
            this.btnReDo.TabIndex = 3;
            this.btnReDo.Text = "Redo";
            this.btnReDo.TextColor = System.Drawing.Color.White;
            this.btnReDo.UseVisualStyleBackColor = false;
            this.btnReDo.Click += new System.EventHandler(this.btnReDo_Click);
            // 
            // btnNextCycle
            // 
            this.btnNextCycle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNextCycle.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNextCycle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNextCycle.BorderRadius = 40;
            this.btnNextCycle.BorderSize = 0;
            this.btnNextCycle.FlatAppearance.BorderSize = 0;
            this.btnNextCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCycle.ForeColor = System.Drawing.Color.White;
            this.btnNextCycle.Location = new System.Drawing.Point(1304, 1020);
            this.btnNextCycle.Name = "btnNextCycle";
            this.btnNextCycle.Size = new System.Drawing.Size(300, 80);
            this.btnNextCycle.TabIndex = 4;
            this.btnNextCycle.Text = "Next Cycle";
            this.btnNextCycle.TextColor = System.Drawing.Color.White;
            this.btnNextCycle.UseVisualStyleBackColor = false;
            this.btnNextCycle.Click += new System.EventHandler(this.btnNextCycle_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRefresh.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefresh.BorderRadius = 40;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(57, 96);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(149, 60);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ShowInfoTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1783, 1142);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNextCycle);
            this.Controls.Add(this.btnReDo);
            this.Controls.Add(this.btnMarkDone);
            this.Controls.Add(this.dtgvApartTax);
            this.Controls.Add(this.label1);
            this.Name = "ShowInfoTax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Info Tax";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvApartTax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dtgvApartTax;
        private Custom.RJButton btnMarkDone;
        private Custom.RJButton btnReDo;
        private Custom.RJButton btnNextCycle;
        private Custom.RJButton btnRefresh;
    }
}