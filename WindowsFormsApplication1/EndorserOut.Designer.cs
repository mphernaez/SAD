﻿namespace WindowsFormsApplication1
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // OK1
            // 
            this.OK1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.OK1.FlatAppearance.BorderSize = 0;
            this.OK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK1.ForeColor = System.Drawing.Color.White;
            this.OK1.Location = new System.Drawing.Point(124, 528);
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
            this.dgvEnd.Location = new System.Drawing.Point(12, 13);
            this.dgvEnd.Name = "dgvEnd";
            this.dgvEnd.RowHeadersVisible = false;
            this.dgvEnd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnd.Size = new System.Drawing.Size(368, 424);
            this.dgvEnd.TabIndex = 87;
            this.dgvEnd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnd_CellClick);
            // 
            // EndorserOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(393, 582);
            this.Controls.Add(this.OK1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.dgvEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndorserOut";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EndorserOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.DataGridView dgvEnd;
    }
}