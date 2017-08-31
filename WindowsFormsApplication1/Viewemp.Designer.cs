namespace WindowsFormsApplication1
{
    partial class Viewemp
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
            this.dgvViewEmp = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bgworkerEmployee = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewEmp
            // 
            this.dgvViewEmp.AllowUserToResizeColumns = false;
            this.dgvViewEmp.AllowUserToResizeRows = false;
            this.dgvViewEmp.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewEmp.GridColor = System.Drawing.Color.White;
            this.dgvViewEmp.Location = new System.Drawing.Point(13, 43);
            this.dgvViewEmp.Name = "dgvViewEmp";
            this.dgvViewEmp.RowHeadersVisible = false;
            this.dgvViewEmp.Size = new System.Drawing.Size(1105, 597);
            this.dgvViewEmp.TabIndex = 10;
            this.dgvViewEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancel_music;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1094, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bgworkerEmployee
            // 
            this.bgworkerEmployee.WorkerReportsProgress = true;
            this.bgworkerEmployee.WorkerSupportsCancellation = true;
            this.bgworkerEmployee.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgworkerEmployee_DoWork);
            this.bgworkerEmployee.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgworkerEmployee_ProgressChanged);
            this.bgworkerEmployee.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgworkerEmployee_RunWorkerCompleted);
            // 
            // Viewemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1130, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvViewEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Viewemp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Viewemp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvViewEmp;
        private System.ComponentModel.BackgroundWorker bgworkerEmployee;
    }
}