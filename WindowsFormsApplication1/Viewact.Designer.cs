namespace WindowsFormsApplication1
{
    partial class viewAct
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bgworkerEmployee = new System.ComponentModel.BackgroundWorker();
            this.dgvViewAct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAct)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancel_music;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1093, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // bgworkerEmployee
            // 
            this.bgworkerEmployee.WorkerReportsProgress = true;
            this.bgworkerEmployee.WorkerSupportsCancellation = true;
            // 
            // dgvViewAct
            // 
            this.dgvViewAct.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewAct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAct.Location = new System.Drawing.Point(12, 44);
            this.dgvViewAct.Name = "dgvViewAct";
            this.dgvViewAct.Size = new System.Drawing.Size(1105, 597);
            this.dgvViewAct.TabIndex = 12;
            // 
            // viewAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1130, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvViewAct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "viewAct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker bgworkerEmployee;
        private System.Windows.Forms.DataGridView dgvViewAct;
    }
}