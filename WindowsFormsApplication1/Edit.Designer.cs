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
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.cbposition = new System.Windows.Forms.ComboBox();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.tbmname = new System.Windows.Forms.TextBox();
            this.tblname = new System.Windows.Forms.TextBox();
            this.tbcontactNumber = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.Edit = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbbday
            // 
            this.tbbday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbbday.Location = new System.Drawing.Point(155, 89);
            this.tbbday.Name = "tbbday";
            this.tbbday.Size = new System.Drawing.Size(308, 26);
            this.tbbday.TabIndex = 45;
            this.tbbday.Text = "Birthday (yyyy-mm-dd)";
            // 
            // cbstatus
            // 
            this.cbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "Active",
            "Incative"});
            this.cbstatus.Location = new System.Drawing.Point(311, 190);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(152, 28);
            this.cbstatus.TabIndex = 49;
            this.cbstatus.Text = "Status";
            // 
            // cbposition
            // 
            this.cbposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbposition.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbposition.FormattingEnabled = true;
            this.cbposition.Items.AddRange(new object[] {
            "Catcher",
            "Admin",
            "Janitor"});
            this.cbposition.Location = new System.Drawing.Point(156, 190);
            this.cbposition.Name = "cbposition";
            this.cbposition.Size = new System.Drawing.Size(149, 28);
            this.cbposition.TabIndex = 48;
            this.cbposition.Text = "Position";
            // 
            // tbfname
            // 
            this.tbfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbfname.Location = new System.Drawing.Point(311, 57);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(152, 26);
            this.tbfname.TabIndex = 43;
            this.tbfname.Text = "Firstname";
            // 
            // tbmname
            // 
            this.tbmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbmname.Location = new System.Drawing.Point(156, 57);
            this.tbmname.Name = "tbmname";
            this.tbmname.Size = new System.Drawing.Size(149, 26);
            this.tbmname.TabIndex = 42;
            this.tbmname.Text = "Middlename";
            // 
            // tblname
            // 
            this.tblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tblname.Location = new System.Drawing.Point(9, 57);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(141, 26);
            this.tblname.TabIndex = 41;
            this.tblname.Text = "Lastname";
            // 
            // tbcontactNumber
            // 
            this.tbcontactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontactNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbcontactNumber.Location = new System.Drawing.Point(9, 190);
            this.tbcontactNumber.Name = "tbcontactNumber";
            this.tbcontactNumber.Size = new System.Drawing.Size(141, 26);
            this.tbcontactNumber.TabIndex = 47;
            this.tbcontactNumber.Text = "Contact Number";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.button;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(354, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 38);
            this.button4.TabIndex = 50;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbaddress
            // 
            this.tbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbaddress.Location = new System.Drawing.Point(9, 121);
            this.tbaddress.Multiline = true;
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(454, 63);
            this.tbaddress.TabIndex = 46;
            this.tbaddress.Text = "Address";
            // 
            // cbgender
            // 
            this.cbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgender.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(9, 87);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(140, 28);
            this.cbgender.TabIndex = 44;
            this.cbgender.Text = "Gender";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.White;
            this.Edit.Controls.Add(this.label1);
            this.Edit.Controls.Add(this.tbbday);
            this.Edit.Controls.Add(this.tblname);
            this.Edit.Controls.Add(this.cbstatus);
            this.Edit.Controls.Add(this.cbgender);
            this.Edit.Controls.Add(this.cbposition);
            this.Edit.Controls.Add(this.tbaddress);
            this.Edit.Controls.Add(this.tbfname);
            this.Edit.Controls.Add(this.button4);
            this.Edit.Controls.Add(this.tbmname);
            this.Edit.Controls.Add(this.tbcontactNumber);
            this.Edit.Location = new System.Drawing.Point(12, 43);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(470, 321);
            this.Edit.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 27);
            this.label1.TabIndex = 51;
            this.label1.Text = "Edit Employee";
            // 
            // EditEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(494, 433);
            this.Controls.Add(this.Edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEmp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbbday;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.ComboBox cbposition;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.TextBox tbmname;
        private System.Windows.Forms.TextBox tblname;
        private System.Windows.Forms.TextBox tbcontactNumber;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.Panel Edit;
        private System.Windows.Forms.Label label1;
    }
}