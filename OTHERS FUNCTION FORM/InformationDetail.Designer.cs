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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txbMaCanHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetailInformation
            // 
            this.btnDetailInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetailInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(114)))));
            this.btnDetailInformation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(114)))));
            this.btnDetailInformation.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDetailInformation.BorderRadius = 40;
            this.btnDetailInformation.BorderSize = 0;
            this.btnDetailInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailInformation.FlatAppearance.BorderSize = 0;
            this.btnDetailInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailInformation.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDetailInformation.ForeColor = System.Drawing.Color.White;
            this.btnDetailInformation.Location = new System.Drawing.Point(141, 63);
            this.btnDetailInformation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDetailInformation.Name = "btnDetailInformation";
            this.btnDetailInformation.Size = new System.Drawing.Size(129, 36);
            this.btnDetailInformation.TabIndex = 7;
            this.btnDetailInformation.Text = "Detail Information";
            this.btnDetailInformation.TextColor = System.Drawing.Color.White;
            this.btnDetailInformation.UseVisualStyleBackColor = false;
            this.btnDetailInformation.Click += new System.EventHandler(this.btnDetailInformation_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDetailInformation, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 57);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 108);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.49367F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.50633F));
            this.tableLayoutPanel2.Controls.Add(this.txbMaCanHo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(373, 45);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // txbMaCanHo
            // 
            this.txbMaCanHo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbMaCanHo.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMaCanHo.ForeColor = System.Drawing.Color.Black;
            this.txbMaCanHo.Location = new System.Drawing.Point(150, 10);
            this.txbMaCanHo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txbMaCanHo.Name = "txbMaCanHo";
            this.txbMaCanHo.Size = new System.Drawing.Size(201, 24);
            this.txbMaCanHo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aparment code";
            // 
            // InformationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "InformationDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information Detail";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.RJButton btnDetailInformation;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txbMaCanHo;
        private Label label2;
    }
}