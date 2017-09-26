namespace WindowsFormsApplication1
{
    partial class EndorserIn
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
            this.dgvEnd = new System.Windows.Forms.DataGridView();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.OK1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.cbDa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMo = new System.Windows.Forms.ComboBox();
            this.tbYr = new System.Windows.Forms.TextBox();
            this.amtLabel = new System.Windows.Forms.Label();
            this.amtIn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amtIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnd
            // 
            this.dgvEnd.AllowUserToAddRows = false;
            this.dgvEnd.AllowUserToDeleteRows = false;
            this.dgvEnd.AllowUserToResizeColumns = false;
            this.dgvEnd.AllowUserToResizeRows = false;
            this.dgvEnd.BackgroundColor = System.Drawing.Color.White;
            this.dgvEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnd.GridColor = System.Drawing.Color.White;
            this.dgvEnd.Location = new System.Drawing.Point(12, 43);
            this.dgvEnd.Name = "dgvEnd";
            this.dgvEnd.ReadOnly = true;
            this.dgvEnd.RowHeadersVisible = false;
            this.dgvEnd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnd.Size = new System.Drawing.Size(368, 332);
            this.dgvEnd.TabIndex = 0;
            this.dgvEnd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnd_CellClick);
            // 
            // cbDay
            // 
            this.cbDay.Enabled = false;
            this.cbDay.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDay.ForeColor = System.Drawing.Color.Gray;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDay.Location = new System.Drawing.Point(310, 410);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(63, 30);
            this.cbDay.TabIndex = 84;
            this.cbDay.Text = "Day";
            this.cbDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMonth_KeyPress);
            // 
            // cbMonth
            // 
            this.cbMonth.Enabled = false;
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.ForeColor = System.Drawing.Color.Gray;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.Location = new System.Drawing.Point(99, 412);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(205, 28);
            this.cbMonth.TabIndex = 83;
            this.cbMonth.Text = "Month";
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            this.cbMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMonth_KeyPress);
            // 
            // tbYear
            // 
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYear.ForeColor = System.Drawing.Color.Gray;
            this.tbYear.Location = new System.Drawing.Point(28, 412);
            this.tbYear.Multiline = true;
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(65, 30);
            this.tbYear.TabIndex = 82;
            this.tbYear.Text = "Year";
            this.tbYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbYear.TextChanged += new System.EventHandler(this.tbYear_TextChanged);
            this.tbYear.Enter += new System.EventHandler(this.tbYear_Enter);
            this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYr_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(23, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 85;
            this.label15.Text = "Delivery Date";
            // 
            // OK1
            // 
            this.OK1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.OK1.FlatAppearance.BorderSize = 0;
            this.OK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK1.ForeColor = System.Drawing.Color.White;
            this.OK1.Location = new System.Drawing.Point(134, 621);
            this.OK1.Name = "OK1";
            this.OK1.Size = new System.Drawing.Size(124, 42);
            this.OK1.TabIndex = 86;
            this.OK1.Text = "OK";
            this.OK1.UseVisualStyleBackColor = false;
            this.OK1.Click += new System.EventHandler(this.OK1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(23, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Reason";
            // 
            // tbReason
            // 
            this.tbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReason.ForeColor = System.Drawing.Color.Gray;
            this.tbReason.Location = new System.Drawing.Point(27, 468);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(347, 30);
            this.tbReason.TabIndex = 92;
            this.tbReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbDa
            // 
            this.cbDa.Enabled = false;
            this.cbDa.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDa.ForeColor = System.Drawing.Color.Gray;
            this.cbDa.FormattingEnabled = true;
            this.cbDa.Location = new System.Drawing.Point(310, 531);
            this.cbDa.Name = "cbDa";
            this.cbDa.Size = new System.Drawing.Size(63, 30);
            this.cbDa.TabIndex = 98;
            this.cbDa.Text = "Day";
            this.cbDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMonth_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(24, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 96;
            this.label2.Text = "Expiration Date";
            // 
            // cbMo
            // 
            this.cbMo.Enabled = false;
            this.cbMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMo.ForeColor = System.Drawing.Color.Gray;
            this.cbMo.FormattingEnabled = true;
            this.cbMo.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMo.Location = new System.Drawing.Point(99, 531);
            this.cbMo.Name = "cbMo";
            this.cbMo.Size = new System.Drawing.Size(205, 28);
            this.cbMo.TabIndex = 95;
            this.cbMo.Text = "Month";
            this.cbMo.SelectedIndexChanged += new System.EventHandler(this.cbMo_SelectedIndexChanged);
            this.cbMo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMonth_KeyPress);
            // 
            // tbYr
            // 
            this.tbYr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYr.ForeColor = System.Drawing.Color.Gray;
            this.tbYr.Location = new System.Drawing.Point(28, 530);
            this.tbYr.Multiline = true;
            this.tbYr.Name = "tbYr";
            this.tbYr.Size = new System.Drawing.Size(65, 30);
            this.tbYr.TabIndex = 94;
            this.tbYr.Text = "Year";
            this.tbYr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbYr.TextChanged += new System.EventHandler(this.tbYr_TextChanged);
            this.tbYr.Enter += new System.EventHandler(this.tbYr_Enter);
            this.tbYr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYr_KeyPress);
            // 
            // amtLabel
            // 
            this.amtLabel.AutoSize = true;
            this.amtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.amtLabel.Location = new System.Drawing.Point(24, 562);
            this.amtLabel.Name = "amtLabel";
            this.amtLabel.Size = new System.Drawing.Size(65, 20);
            this.amtLabel.TabIndex = 102;
            this.amtLabel.Text = "Amount";
            // 
            // amtIn
            // 
            this.amtIn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtIn.Location = new System.Drawing.Point(28, 585);
            this.amtIn.Name = "amtIn";
            this.amtIn.Size = new System.Drawing.Size(150, 26);
            this.amtIn.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(154, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 104;
            this.label3.Text = "Stock In";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancel_music;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(357, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EndorserIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(393, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amtLabel);
            this.Controls.Add(this.amtIn);
            this.Controls.Add(this.cbDa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMo);
            this.Controls.Add(this.tbYr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.OK1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.dgvEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "EndorserIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.EndorserIn_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amtIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEnd;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button OK1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.ComboBox cbDa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMo;
        private System.Windows.Forms.TextBox tbYr;
        private System.Windows.Forms.NumericUpDown amtIn;
        public System.Windows.Forms.Label amtLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}