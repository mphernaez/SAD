namespace WindowsFormsApplication1
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.namelabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pe = new System.Windows.Forms.Panel();
            this.ip = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dp = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.hp = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.claimreportdgv = new System.Windows.Forms.DataGridView();
            this.euthanuzereportdgv = new System.Windows.Forms.DataGridView();
            this.catchingreportdgv = new System.Windows.Forms.DataGridView();
            this.reportdgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.ip.SuspendLayout();
            this.ep.SuspendLayout();
            this.dp.SuspendLayout();
            this.hp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimreportdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.euthanuzereportdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catchingreportdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pe);
            this.panel1.Controls.Add(this.ip);
            this.panel1.Controls.Add(this.ep);
            this.panel1.Controls.Add(this.dp);
            this.panel1.Controls.Add(this.hp);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 112);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.Color.Transparent;
            this.namelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.Color.White;
            this.namelabel.Location = new System.Drawing.Point(198, 30);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(196, 39);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "(username)";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.open_exit_door;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(979, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pe
            // 
            this.pe.Location = new System.Drawing.Point(964, 0);
            this.pe.Name = "pe";
            this.pe.Size = new System.Drawing.Size(106, 168);
            this.pe.TabIndex = 8;
            // 
            // ip
            // 
            this.ip.Controls.Add(this.button3);
            this.ip.Location = new System.Drawing.Point(858, 0);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(106, 168);
            this.ip.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.archive_black_box;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(18, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ep
            // 
            this.ep.Controls.Add(this.button2);
            this.ep.Location = new System.Drawing.Point(752, 0);
            this.ep.Name = "ep";
            this.ep.Size = new System.Drawing.Size(106, 168);
            this.ep.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.user_silhouette;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(21, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dp
            // 
            this.dp.Controls.Add(this.button1);
            this.dp.Location = new System.Drawing.Point(646, 1);
            this.dp.Name = "dp";
            this.dp.Size = new System.Drawing.Size(106, 168);
            this.dp.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.paw_print_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(18, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 80);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hp
            // 
            this.hp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(162)))), ((int)(((byte)(80)))));
            this.hp.Controls.Add(this.button5);
            this.hp.Location = new System.Drawing.Point(544, 0);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(106, 168);
            this.hp.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.home1;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(11, 17);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 80);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(783, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 76);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time";
            // 
            // claimreportdgv
            // 
            this.claimreportdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.claimreportdgv.Location = new System.Drawing.Point(0, 114);
            this.claimreportdgv.Name = "claimreportdgv";
            this.claimreportdgv.Size = new System.Drawing.Size(240, 150);
            this.claimreportdgv.TabIndex = 9;
            this.claimreportdgv.Visible = false;
            // 
            // euthanuzereportdgv
            // 
            this.euthanuzereportdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.euthanuzereportdgv.Location = new System.Drawing.Point(237, 114);
            this.euthanuzereportdgv.Name = "euthanuzereportdgv";
            this.euthanuzereportdgv.Size = new System.Drawing.Size(240, 150);
            this.euthanuzereportdgv.TabIndex = 10;
            this.euthanuzereportdgv.Visible = false;
            // 
            // catchingreportdgv
            // 
            this.catchingreportdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catchingreportdgv.Location = new System.Drawing.Point(0, 270);
            this.catchingreportdgv.Name = "catchingreportdgv";
            this.catchingreportdgv.Size = new System.Drawing.Size(240, 150);
            this.catchingreportdgv.TabIndex = 11;
            this.catchingreportdgv.Visible = false;
            // 
            // reportdgv
            // 
            this.reportdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportdgv.Location = new System.Drawing.Point(237, 270);
            this.reportdgv.Name = "reportdgv";
            this.reportdgv.Size = new System.Drawing.Size(240, 150);
            this.reportdgv.TabIndex = 12;
            this.reportdgv.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 710);
            this.Controls.Add(this.reportdgv);
            this.Controls.Add(this.catchingreportdgv);
            this.Controls.Add(this.euthanuzereportdgv);
            this.Controls.Add(this.claimreportdgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ip.ResumeLayout(false);
            this.ep.ResumeLayout(false);
            this.dp.ResumeLayout(false);
            this.hp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.claimreportdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.euthanuzereportdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catchingreportdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pe;
        private System.Windows.Forms.Panel ip;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel ep;
        private System.Windows.Forms.Panel dp;
        private System.Windows.Forms.Panel hp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView claimreportdgv;
        private System.Windows.Forms.DataGridView euthanuzereportdgv;
        private System.Windows.Forms.DataGridView catchingreportdgv;
        private System.Windows.Forms.DataGridView reportdgv;
    }
}