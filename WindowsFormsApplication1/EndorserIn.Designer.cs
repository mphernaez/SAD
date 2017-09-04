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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnd)).BeginInit();
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
            this.dgvEnd.Location = new System.Drawing.Point(13, 13);
            this.dgvEnd.Name = "dgvEnd";
            this.dgvEnd.RowHeadersVisible = false;
            this.dgvEnd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnd.Size = new System.Drawing.Size(368, 362);
            this.dgvEnd.TabIndex = 0;
            this.dgvEnd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnd_CellClick);
            this.dgvEnd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnd_CellContentClick);
            this.dgvEnd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnd_CellDoubleClick);
            this.dgvEnd.DoubleClick += new System.EventHandler(this.dgvEnd_DoubleClick);
            // 
            // cbDay
            // 
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
            this.cbDay.Location = new System.Drawing.Point(126, 413);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(52, 30);
            this.cbDay.TabIndex = 84;
            this.cbDay.Text = "Day";
            // 
            // cbMonth
            // 
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
            this.cbMonth.Location = new System.Drawing.Point(27, 413);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(93, 28);
            this.cbMonth.TabIndex = 83;
            this.cbMonth.Text = "Month";
            // 
            // tbYear
            // 
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYear.ForeColor = System.Drawing.Color.Gray;
            this.tbYear.Location = new System.Drawing.Point(184, 414);
            this.tbYear.Multiline = true;
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(65, 30);
            this.tbYear.TabIndex = 82;
            this.tbYear.Text = "Year";
            this.tbYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(23, 390);
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
            this.OK1.Location = new System.Drawing.Point(125, 528);
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
            this.label1.Location = new System.Drawing.Point(23, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Reason";
            // 
            // tbReason
            // 
            this.tbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReason.ForeColor = System.Drawing.Color.Gray;
            this.tbReason.Location = new System.Drawing.Point(27, 478);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(347, 30);
            this.tbReason.TabIndex = 92;
            this.tbReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EndorserIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(393, 582);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnd)).EndInit();
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
    }
}