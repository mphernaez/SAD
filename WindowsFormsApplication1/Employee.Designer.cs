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
            this.attendance = new System.Windows.Forms.Panel();
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAdoption = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Panel();
            this.addEmployee = new System.Windows.Forms.Panel();
            this.lname = new System.Windows.Forms.TextBox();
            this.contactNumber = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.eGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.position = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.idSearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
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
            this.act.Location = new System.Drawing.Point(97, 5);
            this.act.Name = "act";
            this.act.Size = new System.Drawing.Size(607, 383);
            this.act.TabIndex = 45;
            this.act.Visible = false;
            // 
            // attendance
            // 
            this.attendance.Controls.Add(this.button7);
            this.attendance.Controls.Add(this.idSearch);
            this.attendance.Controls.Add(this.button3);
            this.attendance.Controls.Add(this.dgvProfiles);
            this.attendance.Controls.Add(this.label3);
            this.attendance.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendance.Location = new System.Drawing.Point(90, 3);
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(607, 382);
            this.attendance.TabIndex = 44;
            this.attendance.Visible = false;
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
            this.label12.Size = new System.Drawing.Size(243, 39);
            this.label12.TabIndex = 11;
            this.label12.Text = "Administarator";
            // 
            // admin
            // 
            this.admin.Controls.Add(this.textBox2);
            this.admin.Controls.Add(this.textBox1);
            this.admin.Controls.Add(this.button9);
            this.admin.Controls.Add(this.dgvAdoption);
            this.admin.Controls.Add(this.label12);
            this.admin.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(94, 6);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(607, 382);
            this.admin.TabIndex = 46;
            this.admin.Visible = false;
            // 
            // addEmployee
            // 
            this.addEmployee.Controls.Add(this.status);
            this.addEmployee.Controls.Add(this.position);
            this.addEmployee.Controls.Add(this.dateTimePicker1);
            this.addEmployee.Controls.Add(this.fname);
            this.addEmployee.Controls.Add(this.mname);
            this.addEmployee.Controls.Add(this.lname);
            this.addEmployee.Controls.Add(this.contactNumber);
            this.addEmployee.Controls.Add(this.button4);
            this.addEmployee.Controls.Add(this.address);
            this.addEmployee.Controls.Add(this.eGender);
            this.addEmployee.Controls.Add(this.label2);
            this.addEmployee.Location = new System.Drawing.Point(94, 5);
            this.addEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(607, 382);
            this.addEmployee.TabIndex = 43;
            this.addEmployee.Visible = false;
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(79, 104);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(163, 26);
            this.lname.TabIndex = 11;
            this.lname.Text = "Lastname";
            this.lname.TextChanged += new System.EventHandler(this.lname_TextChanged);
            // 
            // contactNumber
            // 
            this.contactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumber.Location = new System.Drawing.Point(78, 216);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(164, 26);
            this.contactNumber.TabIndex = 4;
            this.contactNumber.Text = "Contact Number";
            this.contactNumber.TextChanged += new System.EventHandler(this.contactNumber_TextChanged);
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(248, 142);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(332, 63);
            this.address.TabIndex = 6;
            this.address.Text = "Address";
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // eGender
            // 
            this.eGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eGender.FormattingEnabled = true;
            this.eGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.eGender.Location = new System.Drawing.Point(78, 142);
            this.eGender.Name = "eGender";
            this.eGender.Size = new System.Drawing.Size(164, 28);
            this.eGender.TabIndex = 3;
            this.eGender.Text = "Gender";
            this.eGender.SelectedIndexChanged += new System.EventHandler(this.eGender_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 41;
            // 
            // mname
            // 
            this.mname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mname.Location = new System.Drawing.Point(248, 104);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(163, 26);
            this.mname.TabIndex = 12;
            this.mname.Text = "Middlename";
            this.mname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(417, 104);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(163, 26);
            this.fname.TabIndex = 13;
            this.fname.Text = "Firstname";
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 26);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "Catcher",
            "Admin",
            "Janitor"});
            this.position.Location = new System.Drawing.Point(248, 214);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(164, 28);
            this.position.TabIndex = 15;
            this.position.Text = "Position";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Active",
            "Incative"});
            this.status.Location = new System.Drawing.Point(416, 214);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(164, 28);
            this.status.TabIndex = 16;
            this.status.Text = "Status";
            // 
            // idSearch
            // 
            this.idSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idSearch.Location = new System.Drawing.Point(397, 60);
            this.idSearch.Name = "idSearch";
            this.idSearch.Size = new System.Drawing.Size(112, 26);
            this.idSearch.TabIndex = 2;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(35, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Username";
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
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.admin;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(14, 229);
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
            this.selectButton.Location = new System.Drawing.Point(-57, 146);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(141, 70);
            this.selectButton.TabIndex = 2;
            this.selectButton.TabStop = false;
            this.selectButton.Visible = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
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
            // button4
            // 
            this.button4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.button;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(471, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 38);
            this.button4.TabIndex = 10;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
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
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(208)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(738, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attendance);
            this.Controls.Add(this.act);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.admin);
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
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox contactNumber;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.ComboBox eGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.TextBox idSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}