namespace WindowsFormsApplication1
{
    partial class EditEmp
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
            this.tbbday = new System.Windows.Forms.TextBox();
            this.cbposition = new System.Windows.Forms.ComboBox();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.tbmname = new System.Windows.Forms.TextBox();
            this.tblname = new System.Windows.Forms.TextBox();
            this.tbcontactNumber = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.Edit = new System.Windows.Forms.Panel();
            this.pnlAdminEdit = new System.Windows.Forms.Panel();
            this.tbUserEdit = new System.Windows.Forms.TextBox();
            this.tbPassEdit = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit.SuspendLayout();
            this.pnlAdminEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbbday
            // 
            this.tbbday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbday.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbbday.Location = new System.Drawing.Point(258, 191);
            this.tbbday.Multiline = true;
            this.tbbday.Name = "tbbday";
            this.tbbday.Size = new System.Drawing.Size(374, 38);
            this.tbbday.TabIndex = 45;
            this.tbbday.Text = "Birthday (yyyy-mm-dd)";
            // 
            // cbposition
            // 
            this.cbposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbposition.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbposition.FormattingEnabled = true;
            this.cbposition.Items.AddRange(new object[] {
            "Catcher",
            "Admin",
            "Janitor"});
            this.cbposition.Location = new System.Drawing.Point(258, 322);
            this.cbposition.Name = "cbposition";
            this.cbposition.Size = new System.Drawing.Size(190, 28);
            this.cbposition.TabIndex = 48;
            this.cbposition.Text = "Position";
            this.cbposition.SelectedIndexChanged += new System.EventHandler(this.cbposition_SelectedIndexChanged);
            this.cbposition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbgender_KeyPress);
            // 
            // tbfname
            // 
            this.tbfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbfname.Location = new System.Drawing.Point(454, 150);
            this.tbfname.Multiline = true;
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(178, 36);
            this.tbfname.TabIndex = 43;
            this.tbfname.Text = "Firstname";
            // 
            // tbmname
            // 
            this.tbmname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbmname.Location = new System.Drawing.Point(258, 150);
            this.tbmname.Multiline = true;
            this.tbmname.Name = "tbmname";
            this.tbmname.Size = new System.Drawing.Size(190, 36);
            this.tbmname.TabIndex = 42;
            this.tbmname.Text = "Middlename";
            // 
            // tblname
            // 
            this.tblname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tblname.Location = new System.Drawing.Point(62, 150);
            this.tblname.Multiline = true;
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(190, 36);
            this.tblname.TabIndex = 41;
            this.tblname.Text = "Lastname";
            // 
            // tbcontactNumber
            // 
            this.tbcontactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbcontactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontactNumber.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbcontactNumber.Location = new System.Drawing.Point(61, 324);
            this.tbcontactNumber.Name = "tbcontactNumber";
            this.tbcontactNumber.Size = new System.Drawing.Size(191, 26);
            this.tbcontactNumber.TabIndex = 47;
            this.tbcontactNumber.Text = "Contact Number";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(162)))), ((int)(((byte)(80)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(444, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 38);
            this.button4.TabIndex = 50;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbaddress
            // 
            this.tbaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaddress.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbaddress.Location = new System.Drawing.Point(61, 235);
            this.tbaddress.Multiline = true;
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(571, 81);
            this.tbaddress.TabIndex = 46;
            this.tbaddress.Text = "Address";
            // 
            // cbgender
            // 
            this.cbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgender.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(62, 191);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(176, 28);
            this.cbgender.TabIndex = 44;
            this.cbgender.Text = "Gender";
            this.cbgender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbgender_KeyPress);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.Edit.Controls.Add(this.pnlAdminEdit);
            this.Edit.Controls.Add(this.pictureBox1);
            this.Edit.Controls.Add(this.label2);
            this.Edit.Controls.Add(this.label1);
            this.Edit.Controls.Add(this.tbbday);
            this.Edit.Controls.Add(this.tblname);
            this.Edit.Controls.Add(this.cbgender);
            this.Edit.Controls.Add(this.cbposition);
            this.Edit.Controls.Add(this.tbaddress);
            this.Edit.Controls.Add(this.tbfname);
            this.Edit.Controls.Add(this.button4);
            this.Edit.Controls.Add(this.tbmname);
            this.Edit.Controls.Add(this.tbcontactNumber);
            this.Edit.Location = new System.Drawing.Point(0, -2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(715, 719);
            this.Edit.TabIndex = 51;
            // 
            // pnlAdminEdit
            // 
            this.pnlAdminEdit.Controls.Add(this.tbUserEdit);
            this.pnlAdminEdit.Controls.Add(this.tbPassEdit);
            this.pnlAdminEdit.Location = new System.Drawing.Point(256, 366);
            this.pnlAdminEdit.Name = "pnlAdminEdit";
            this.pnlAdminEdit.Size = new System.Drawing.Size(376, 31);
            this.pnlAdminEdit.TabIndex = 54;
            // 
            // tbUserEdit
            // 
            this.tbUserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserEdit.ForeColor = System.Drawing.Color.Gray;
            this.tbUserEdit.Location = new System.Drawing.Point(2, 1);
            this.tbUserEdit.Multiline = true;
            this.tbUserEdit.Name = "tbUserEdit";
            this.tbUserEdit.Size = new System.Drawing.Size(183, 29);
            this.tbUserEdit.TabIndex = 46;
            this.tbUserEdit.Text = "Username";
            // 
            // tbPassEdit
            // 
            this.tbPassEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassEdit.ForeColor = System.Drawing.Color.Gray;
            this.tbPassEdit.Location = new System.Drawing.Point(191, 1);
            this.tbPassEdit.Multiline = true;
            this.tbPassEdit.Name = "tbPassEdit";
            this.tbPassEdit.Size = new System.Drawing.Size(183, 29);
            this.tbPassEdit.TabIndex = 47;
            this.tbPassEdit.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancel_music;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(678, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 20);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(529, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "yyyy-mm-dd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(214, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 46);
            this.label1.TabIndex = 51;
            this.label1.Text = "Edit Employee";
            // 
            // EditEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(714, 715);
            this.Controls.Add(this.Edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEmp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditEmp_Load);
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            this.pnlAdminEdit.ResumeLayout(false);
            this.pnlAdminEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel Edit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbbday;
        public System.Windows.Forms.ComboBox cbposition;
        public System.Windows.Forms.TextBox tbfname;
        public System.Windows.Forms.TextBox tbmname;
        public System.Windows.Forms.TextBox tblname;
        public System.Windows.Forms.TextBox tbcontactNumber;
        public System.Windows.Forms.TextBox tbaddress;
        public System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel pnlAdminEdit;
        public System.Windows.Forms.TextBox tbUserEdit;
        public System.Windows.Forms.TextBox tbPassEdit;
    }
}