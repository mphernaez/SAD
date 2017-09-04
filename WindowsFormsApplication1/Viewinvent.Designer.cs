namespace WindowsFormsApplication1
{
    partial class Viewinvent
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
            this.dgvViewAct = new System.Windows.Forms.DataGridView();
            this.bgworkerEmployee = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewAct
            // 
            this.dgvViewAct.AllowUserToAddRows = false;
            this.dgvViewAct.AllowUserToResizeColumns = false;
            this.dgvViewAct.AllowUserToResizeRows = false;
            this.dgvViewAct.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewAct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAct.GridColor = System.Drawing.Color.White;
            this.dgvViewAct.Location = new System.Drawing.Point(13, 43);
            this.dgvViewAct.Name = "dgvViewAct";
            this.dgvViewAct.RowHeadersVisible = false;
            this.dgvViewAct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewAct.Size = new System.Drawing.Size(1105, 597);
            this.dgvViewAct.TabIndex = 14;
            // 
            // bgworkerEmployee
            // 
            this.bgworkerEmployee.WorkerReportsProgress = true;
            this.bgworkerEmployee.WorkerSupportsCancellation = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancel_music;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1094, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Viewinvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1130, 655);
            this.Controls.Add(this.dgvViewAct);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Viewinvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewAct;
        private System.ComponentModel.BackgroundWorker bgworkerEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}