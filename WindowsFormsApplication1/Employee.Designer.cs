namespace WindowsFormsApplication1
{
    partial class Employee
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
            this.activities = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.act = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.attendance = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.idSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAdoption = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Panel();
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activities)).BeginInit();
            this.act.SuspendLayout();
            this.attendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdoption)).BeginInit();
            this.admin.SuspendLayout();
            this.addEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectButton)).BeginInit();
            this.SuspendLayout();
            // 
            // activities
            // 
            this.activities.AllowUserToAddRows = false;
            this.activities.AllowUserToDeleteRows = false;
            this.activities.BackgroundColor = System.Drawing.Color.MistyRose;
            this.activities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activities.Location = new System.Drawing.Point(40, 64);
            this.activities.Name = "activities";
            this.activities.ReadOnly = true;
            this.activities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activities.Size = new System.Drawing.Size(513, 193);
            this.activities.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(36, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 39);
            this.label11.TabIndex = 11;
            this.label11.Text = "Activity";
            // 
            // act
            // 
            this.act.Controls.Add(this.comboBox1);
            this.act.Controls.Add(this.btnDone);
            this.act.Controls.Add(this.activities);
            this.act.Controls.Add(this.label11);
            this.act.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.act.Location = new System.Drawing.Point(100, 2);
            this.act.Name = "act";
            this.act.Size = new System.Drawing.Size(607, 383);
            this.act.TabIndex = 45;
            this.act.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(388, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 30);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Text = "Type of Activity";
            // 
            // btnDone
            // 
            this.btnDone.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.button;
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(444, 303);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(109, 38);
            this.btnDone.TabIndex = 25;
            this.btnDone.Text = "Add";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // attendance
            // 
            this.attendance.Controls.Add(this.button7);
            this.attendance.Controls.Add(this.idSearch);
            this.attendance.Controls.Add(this.button3);
            this.attendance.Controls.Add(this.dgvProfiles);
            this.attendance.Controls.Add(this.label3);
            this.attendance.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendance.Location = new System.Drawing.Point(100, 5);
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(607, 382);
            this.attendance.TabIndex = 44;
            this.attendance.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.magnifying_glass;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(520, 59);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 27);
            this.button7.TabIndex = 28;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // idSearch
            // 
            this.idSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idSearch.Location = new System.Drawing.Point(397, 60);
            this.idSearch.Name = "idSearch";
            this.idSearch.Size = new System.Drawing.Size(112, 26);
            this.idSearch.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.button;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(440, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 38);
            this.button3.TabIndex = 23;
            this.button3.Text = "Present";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvProfiles
            // 
            this.dgvProfiles.AllowUserToAddRows = false;
            this.dgvProfiles.AllowUserToDeleteRows = false;
            this.dgvProfiles.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfiles.Location = new System.Drawing.Point(36, 96);
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.ReadOnly = true;
            this.dgvProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfiles.Size = new System.Drawing.Size(513, 229);
            this.dgvProfiles.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(36, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Attendance";
            // 
            // dgvAdoption
            // 
            this.dgvAdoption.AllowUserToAddRows = false;
            this.dgvAdoption.AllowUserToDeleteRows = false;
            this.dgvAdoption.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvAdoption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdoption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdoption.Location = new System.Drawing.Point(36, 78);
            this.dgvAdoption.Name = "dgvAdoption";
            this.dgvAdoption.ReadOnly = true;
            this.dgvAdoption.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdoption.Size = new System.Drawing.Size(513, 221);
            this.dgvAdoption.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(29, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(224, 39);
            this.label12.TabIndex = 11;
            this.label12.Text = "Administrator";
            // 
            // admin
            // 
            this.admin.Controls.Add(this.textBox2);
            this.admin.Controls.Add(this.textBox1);
            this.admin.Controls.Add(this.button9);
            this.admin.Controls.Add(this.dgvAdoption);
            this.admin.Controls.Add(this.label12);
            this.admin.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(97, 5);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(607, 380);
            this.admin.TabIndex = 46;
            this.admin.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(205, 309);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 26);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(35, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Username";
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.button;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(440, 305);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 38);
            this.button9.TabIndex = 23;
            this.button9.Text = "Set as Admin";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // addEmployee
            // 
            this.addEmployee.Controls.Add(this.tbbday);
            this.addEmployee.Controls.Add(this.cbstatus);
            this.addEmployee.Controls.Add(this.cbposition);
            this.addEmployee.Controls.Add(this.tbfname);
            this.addEmployee.Controls.Add(this.tbmname);
            this.addEmployee.Controls.Add(this.tblname);
            this.addEmployee.Controls.Add(this.tbcontactNumber);
            this.addEmployee.Controls.Add(this.button4);
            this.addEmployee.Controls.Add(this.tbaddress);
            this.addEmployee.Controls.Add(this.cbgender);
            this.addEmployee.Controls.Add(this.label2);
            this.addEmployee.Location = new System.Drawing.Point(103, 8);
            this.addEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(607, 382);
            this.addEmployee.TabIndex = 43;
            this.addEmployee.Visible = false;
            // 
            // tbbday
            // 
            this.tbbday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbday.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbbday.Location = new System.Drawing.Point(248, 143);
            this.tbbday.Name = "tbbday";
            this.tbbday.Size = new System.Drawing.Size(331, 26);
            this.tbbday.TabIndex = 15;
            this.tbbday.Text = "Birthday (mm-dd-yyyy)";
            this.tbbday.Click += new System.EventHandler(this.tbbday_Click);
            // 
            // cbstatus
            // 
            this.cbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "Active",
            "Incative"});
            this.cbstatus.Location = new System.Drawing.Point(415, 245);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(164, 28);
            this.cbstatus.TabIndex = 19;
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
            this.cbposition.Location = new System.Drawing.Point(247, 245);
            this.cbposition.Name = "cbposition";
            this.cbposition.Size = new System.Drawing.Size(164, 28);
            this.cbposition.TabIndex = 18;
            this.cbposition.Text = "Position";
            // 
            // tbfname
            // 
            this.tbfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbfname.Location = new System.Drawing.Point(417, 104);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(163, 26);
            this.tbfname.TabIndex = 13;
            this.tbfname.Text = "Firstname";
            this.tbfname.Click += new System.EventHandler(this.tbfname_Click);
            this.tbfname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // tbmname
            // 
            this.tbmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbmname.Location = new System.Drawing.Point(248, 104);
            this.tbmname.Name = "tbmname";
            this.tbmname.Size = new System.Drawing.Size(163, 26);
            this.tbmname.TabIndex = 12;
            this.tbmname.Text = "Middlename";
            this.tbmname.Click += new System.EventHandler(this.tbmname_Click);
            this.tbmname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tblname
            // 
            this.tblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tblname.Location = new System.Drawing.Point(79, 104);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(163, 26);
            this.tblname.TabIndex = 11;
            this.tblname.Text = "Lastname";
            this.tblname.Click += new System.EventHandler(this.tblname_Click);
            this.tblname.TextChanged += new System.EventHandler(this.lname_TextChanged);
            // 
            // tbcontactNumber
            // 
            this.tbcontactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontactNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbcontactNumber.Location = new System.Drawing.Point(77, 245);
            this.tbcontactNumber.Name = "tbcontactNumber";
            this.tbcontactNumber.Size = new System.Drawing.Size(164, 26);
            this.tbcontactNumber.TabIndex = 17;
            this.tbcontactNumber.Text = "Contact Number";
            this.tbcontactNumber.Click += new System.EventHandler(this.tbcontactNumber_Click);
            this.tbcontactNumber.TextChanged += new System.EventHandler(this.contactNumber_TextChanged);
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
            this.button4.Location = new System.Drawing.Point(470, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 38);
            this.button4.TabIndex = 20;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbaddress
            // 
            this.tbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbaddress.Location = new System.Drawing.Point(77, 176);
            this.tbaddress.Multiline = true;
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(502, 63);
            this.tbaddress.TabIndex = 16;
            this.tbaddress.Text = "Address";
            this.tbaddress.Click += new System.EventHandler(this.tbaddress_Click);
            this.tbaddress.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // cbgender
            // 
            this.cbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgender.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(78, 142);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(164, 28);
            this.cbgender.TabIndex = 14;
            this.cbgender.Text = "Gender";
            this.cbgender.SelectedIndexChanged += new System.EventHandler(this.eGender_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(73, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Profiling";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(148)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.selectButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 510);
            this.panel1.TabIndex = 42;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.rep;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(14, 293);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 55);
            this.button8.TabIndex = 38;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.admin;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(14, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 55);
            this.button6.TabIndex = 37;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.act;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(14, 152);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(55, 55);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Untitled_1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(14, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.employees;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(14, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectButton
            // 
            this.selectButton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.selects;
            this.selectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectButton.Location = new System.Drawing.Point(-57, 285);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(141, 70);
            this.selectButton.TabIndex = 2;
            this.selectButton.TabStop = false;
            this.selectButton.Visible = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 41;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(208)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(738, 390);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.act);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.attendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activities)).EndInit();
            this.act.ResumeLayout(false);
            this.act.PerformLayout();
            this.attendance.ResumeLayout(false);
            this.attendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdoption)).EndInit();
            this.admin.ResumeLayout(false);
            this.admin.PerformLayout();
            this.addEmployee.ResumeLayout(false);
            this.addEmployee.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox selectButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView activities;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Panel act;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DataGridView dgvAdoption;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Panel admin;
        public System.Windows.Forms.Panel attendance;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvProfiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel addEmployee;
        private System.Windows.Forms.TextBox tblname;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbmname;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.ComboBox cbposition;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.TextBox idSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbbday;
        private System.Windows.Forms.TextBox tbcontactNumber;
        private System.Windows.Forms.Button button8;
    }
}