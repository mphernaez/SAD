namespace WindowsFormsApplication1
{
    partial class Viewdog
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
            this.dgvViewDog = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewDog
            // 
            this.dgvViewDog.AllowUserToAddRows = false;
            this.dgvViewDog.AllowUserToDeleteRows = false;
            this.dgvViewDog.AllowUserToResizeRows = false;
            this.dgvViewDog.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewDog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewDog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewDog.Location = new System.Drawing.Point(13, 46);
            this.dgvViewDog.Name = "dgvViewDog";
            this.dgvViewDog.ReadOnly = true;
            this.dgvViewDog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewDog.Size = new System.Drawing.Size(1105, 597);
            this.dgvViewDog.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancel_music;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1094, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Viewdog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1130, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvViewDog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Viewdog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Viewdog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewDog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}