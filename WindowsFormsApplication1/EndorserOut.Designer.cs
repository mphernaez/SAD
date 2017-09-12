namespace WindowsFormsApplication1
{
    partial class EndorserOut
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
            this.OK1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.dgvEnd = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.amtOut = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amtOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OK1
            // 
            this.OK1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.OK1.FlatAppearance.BorderSize = 0;
            this.OK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK1.ForeColor = System.Drawing.Color.White;
            this.OK1.Location = new System.Drawing.Point(134, 575);
            this.OK1.Name = "OK1";
            this.OK1.Size = new System.Drawing.Size(124, 42);
            this.OK1.TabIndex = 92;
            this.OK1.Text = "OK";
            this.OK1.UseVisualStyleBackColor = false;
            this.OK1.Click += new System.EventHandler(this.OK1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(21, 455);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 91;
            this.label15.Text = "Reason";
            // 
            // tbReason
            // 
            this.tbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReason.ForeColor = System.Drawing.Color.Gray;
            this.tbReason.Location = new System.Drawing.Point(25, 478);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(347, 30);
            this.tbReason.TabIndex = 88;
            this.tbReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dgvEnd.Size = new System.Drawing.Size(368, 401);
            this.dgvEnd.TabIndex = 87;
            this.dgvEnd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnd_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(21, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 102;
            this.label3.Text = "Amount";
            // 
            // amtOut
            // 
            this.amtOut.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtOut.Location = new System.Drawing.Point(25, 543);
            this.amtOut.Name = "amtOut";
            this.amtOut.Size = new System.Drawing.Size(150, 26);
            this.amtOut.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(141, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 103;
            this.label1.Text = "Stock Out";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancel_music;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(357, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EndorserOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(393, 627);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amtOut);
            this.Controls.Add(this.OK1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.dgvEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndorserOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EndorserOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amtOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.DataGridView dgvEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown amtOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}