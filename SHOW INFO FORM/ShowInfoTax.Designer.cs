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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowInfoTax));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvApartTax = new System.Windows.Forms.DataGridView();
            this.btnMarkDone = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.btnReDo = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.btnNextCycle = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.btnRefresh = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.btnFinanceDetail = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.btnInformationDetail = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvApartTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(291, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1111, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIST APARTMENT NEED TO COLLECT MONEY";
            // 
            // dtgvApartTax
            // 
            this.dtgvApartTax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvApartTax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvApartTax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvApartTax.Location = new System.Drawing.Point(12, 272);
            this.dtgvApartTax.Name = "dtgvApartTax";
            this.dtgvApartTax.RowHeadersWidth = 82;
            this.dtgvApartTax.RowTemplate.Height = 41;
            this.dtgvApartTax.Size = new System.Drawing.Size(1759, 595);
            this.dtgvApartTax.TabIndex = 1;
            this.dtgvApartTax.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvApartTax_CellFormatting);
            // 
            // btnMarkDone
            // 
            this.btnMarkDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnMarkDone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnMarkDone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMarkDone.BorderRadius = 40;
            this.btnMarkDone.BorderSize = 0;
            this.btnMarkDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkDone.FlatAppearance.BorderSize = 0;
            this.btnMarkDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkDone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMarkDone.ForeColor = System.Drawing.Color.White;
            this.btnMarkDone.Image = ((System.Drawing.Image)(resources.GetObject("btnMarkDone.Image")));
            this.btnMarkDone.Location = new System.Drawing.Point(143, 936);
            this.btnMarkDone.Name = "btnMarkDone";
            this.btnMarkDone.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.btnMarkDone.Size = new System.Drawing.Size(231, 191);
            this.btnMarkDone.TabIndex = 2;
            this.btnMarkDone.Text = "Mark Done";
            this.btnMarkDone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarkDone.TextColor = System.Drawing.Color.White;
            this.btnMarkDone.UseVisualStyleBackColor = false;
            this.btnMarkDone.Click += new System.EventHandler(this.btnMarkDone_Click);
            // 
            // btnReDo
            // 
            this.btnReDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnReDo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnReDo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReDo.BorderRadius = 40;
            this.btnReDo.BorderSize = 0;
            this.btnReDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReDo.FlatAppearance.BorderSize = 0;
            this.btnReDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReDo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnReDo.Image = ((System.Drawing.Image)(resources.GetObject("btnReDo.Image")));
            this.btnReDo.Location = new System.Drawing.Point(703, 936);
            this.btnReDo.Name = "btnReDo";
            this.btnReDo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.btnReDo.Size = new System.Drawing.Size(231, 191);
            this.btnReDo.TabIndex = 3;
            this.btnReDo.Text = "Redo";
            this.btnReDo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReDo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnReDo.UseVisualStyleBackColor = false;
            this.btnReDo.Click += new System.EventHandler(this.btnReDo_Click);
            // 
            // btnNextCycle
            // 
            this.btnNextCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnNextCycle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnNextCycle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNextCycle.BorderRadius = 40;
            this.btnNextCycle.BorderSize = 0;
            this.btnNextCycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextCycle.FlatAppearance.BorderSize = 0;
            this.btnNextCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCycle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextCycle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnNextCycle.Image = ((System.Drawing.Image)(resources.GetObject("btnNextCycle.Image")));
            this.btnNextCycle.Location = new System.Drawing.Point(1245, 936);
            this.btnNextCycle.Name = "btnNextCycle";
            this.btnNextCycle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.btnNextCycle.Size = new System.Drawing.Size(231, 191);
            this.btnNextCycle.TabIndex = 4;
            this.btnNextCycle.Text = "Next Cycle";
            this.btnNextCycle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNextCycle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnNextCycle.UseVisualStyleBackColor = false;
            this.btnNextCycle.Click += new System.EventHandler(this.btnNextCycle_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefresh.BorderRadius = 40;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(12, 204);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(173, 62);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFinanceDetail
            // 
            this.btnFinanceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinanceDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnFinanceDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnFinanceDetail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFinanceDetail.BorderRadius = 40;
            this.btnFinanceDetail.BorderSize = 0;
            this.btnFinanceDetail.FlatAppearance.BorderSize = 0;
            this.btnFinanceDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceDetail.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinanceDetail.ForeColor = System.Drawing.Color.White;
            this.btnFinanceDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceDetail.Image")));
            this.btnFinanceDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceDetail.Location = new System.Drawing.Point(1530, 191);
            this.btnFinanceDetail.Name = "btnFinanceDetail";
            this.btnFinanceDetail.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFinanceDetail.Size = new System.Drawing.Size(241, 75);
            this.btnFinanceDetail.TabIndex = 6;
            this.btnFinanceDetail.Text = "Finance Detail";
            this.btnFinanceDetail.TextColor = System.Drawing.Color.White;
            this.btnFinanceDetail.UseVisualStyleBackColor = false;
            this.btnFinanceDetail.Click += new System.EventHandler(this.btnFinanceDetail_Click);
            // 
            // btnInformationDetail
            // 
            this.btnInformationDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInformationDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnInformationDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnInformationDetail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInformationDetail.BorderRadius = 40;
            this.btnInformationDetail.BorderSize = 0;
            this.btnInformationDetail.FlatAppearance.BorderSize = 0;
            this.btnInformationDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformationDetail.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInformationDetail.ForeColor = System.Drawing.Color.White;
            this.btnInformationDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnInformationDetail.Image")));
            this.btnInformationDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformationDetail.Location = new System.Drawing.Point(1286, 191);
            this.btnInformationDetail.Name = "btnInformationDetail";
            this.btnInformationDetail.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInformationDetail.Size = new System.Drawing.Size(241, 75);
            this.btnInformationDetail.TabIndex = 7;
            this.btnInformationDetail.Text = "Information Detail";
            this.btnInformationDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInformationDetail.TextColor = System.Drawing.Color.White;
            this.btnInformationDetail.UseVisualStyleBackColor = false;
            this.btnInformationDetail.Click += new System.EventHandler(this.btnInformationDetail_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1074, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // txbSearch
            // 
            this.txbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearch.Font = new System.Drawing.Font("Arial Narrow", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbSearch.Location = new System.Drawing.Point(496, 178);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(572, 38);
            this.txbSearch.TabIndex = 29;
            this.txbSearch.Text = "Search apartment...";
            this.txbSearch.Click += new System.EventHandler(this.txbSearch_Click);
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1690, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 84);
            this.btnExit.TabIndex = 53;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ShowInfoTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1783, 1193);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnInformationDetail);
            this.Controls.Add(this.btnFinanceDetail);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNextCycle);
            this.Controls.Add(this.btnReDo);
            this.Controls.Add(this.btnMarkDone);
            this.Controls.Add(this.dtgvApartTax);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowInfoTax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Info Tax";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvApartTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Custom.RJButton btnFinanceDetail;
        private Custom.RJButton btnInformationDetail;
        private PictureBox pictureBox1;
        private TextBox txbSearch;
        private Button btnExit;
    }
}