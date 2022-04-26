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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMaCanHo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoneNegotiation
            // 
            this.btnDoneNegotiation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoneNegotiation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnDoneNegotiation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.btnDoneNegotiation.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDoneNegotiation.BorderRadius = 40;
            this.btnDoneNegotiation.BorderSize = 0;
            this.btnDoneNegotiation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoneNegotiation.FlatAppearance.BorderSize = 0;
            this.btnDoneNegotiation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoneNegotiation.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDoneNegotiation.ForeColor = System.Drawing.Color.White;
            this.btnDoneNegotiation.Location = new System.Drawing.Point(263, 135);
            this.btnDoneNegotiation.Name = "btnDoneNegotiation";
            this.btnDoneNegotiation.Size = new System.Drawing.Size(239, 76);
            this.btnDoneNegotiation.TabIndex = 3;
            this.btnDoneNegotiation.Text = "Done Negotiation";
            this.btnDoneNegotiation.TextColor = System.Drawing.Color.White;
            this.btnDoneNegotiation.UseVisualStyleBackColor = false;
            this.btnDoneNegotiation.Click += new System.EventHandler(this.btnDoneNegotiation_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDoneNegotiation, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 231);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txbMaCanHo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(72, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 109);
            this.panel1.TabIndex = 5;
            // 
            // txbMaCanHo
            // 
            this.txbMaCanHo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbMaCanHo.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMaCanHo.ForeColor = System.Drawing.Color.Black;
            this.txbMaCanHo.Location = new System.Drawing.Point(228, 45);
            this.txbMaCanHo.Name = "txbMaCanHo";
            this.txbMaCanHo.Size = new System.Drawing.Size(370, 40);
            this.txbMaCanHo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aparment code";
            // 
            // DoneNegotiation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DoneNegotiation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Done Negotiation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.RJButton btnDoneNegotiation;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox txbMaCanHo;
        private Label label1;
    }
}