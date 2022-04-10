namespace QuanlyCanHoGiangTran.SHOW_INFO_FORM
{
    partial class Negotiation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Negotiation));
            this.dtgvNegotiateApart = new System.Windows.Forms.DataGridView();
            this.btnDone = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.btnRedoNegotiation = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.btnSkip = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new QuanlyCanHoGiangTran.Custom.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNegotiateApart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvNegotiateApart
            // 
            this.dtgvNegotiateApart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNegotiateApart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNegotiateApart.Location = new System.Drawing.Point(3, 211);
            this.dtgvNegotiateApart.Name = "dtgvNegotiateApart";
            this.dtgvNegotiateApart.RowHeadersWidth = 82;
            this.dtgvNegotiateApart.RowTemplate.Height = 41;
            this.dtgvNegotiateApart.Size = new System.Drawing.Size(1831, 690);
            this.dtgvNegotiateApart.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDone.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDone.BorderRadius = 40;
            this.btnDone.BorderSize = 0;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(321, 946);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(300, 80);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done Negotiation";
            this.btnDone.TextColor = System.Drawing.Color.White;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnRedoNegotiation
            // 
            this.btnRedoNegotiation.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRedoNegotiation.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRedoNegotiation.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRedoNegotiation.BorderRadius = 40;
            this.btnRedoNegotiation.BorderSize = 0;
            this.btnRedoNegotiation.FlatAppearance.BorderSize = 0;
            this.btnRedoNegotiation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedoNegotiation.ForeColor = System.Drawing.Color.White;
            this.btnRedoNegotiation.Location = new System.Drawing.Point(803, 946);
            this.btnRedoNegotiation.Name = "btnRedoNegotiation";
            this.btnRedoNegotiation.Size = new System.Drawing.Size(300, 80);
            this.btnRedoNegotiation.TabIndex = 2;
            this.btnRedoNegotiation.Text = "Redo Negotiation";
            this.btnRedoNegotiation.TextColor = System.Drawing.Color.White;
            this.btnRedoNegotiation.UseVisualStyleBackColor = false;
            this.btnRedoNegotiation.Click += new System.EventHandler(this.btnRedoNegotiation_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSkip.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSkip.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSkip.BorderRadius = 40;
            this.btnSkip.BorderSize = 0;
            this.btnSkip.FlatAppearance.BorderSize = 0;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(1254, 946);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(300, 80);
            this.btnSkip.TabIndex = 3;
            this.btnSkip.Text = "Skip";
            this.btnSkip.TextColor = System.Drawing.Color.White;
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1492, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "LIST OF ALL APARTMENT NEED TO NEGOTIATE ABOUT CONTRACT";
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
            this.btnRefresh.Location = new System.Drawing.Point(28, 112);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(149, 71);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1007, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txbSearch
            // 
            this.txbSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbSearch.Location = new System.Drawing.Point(680, 45);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(321, 39);
            this.txbSearch.TabIndex = 27;
            this.txbSearch.Text = "Search apartment...";
            this.txbSearch.Click += new System.EventHandler(this.txbSearch_Click);
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // Negotiation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 1059);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnRedoNegotiation);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.dtgvNegotiateApart);
            this.Name = "Negotiation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Negotiation";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNegotiateApart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgvNegotiateApart;
        private Custom.RJButton btnDone;
        private Custom.RJButton btnRedoNegotiation;
        private Custom.RJButton btnSkip;
        private Label label1;
        private Custom.RJButton btnRefresh;
        private PictureBox pictureBox1;
        private TextBox txbSearch;
    }
}