namespace WindowsFormsApplication1
{
    partial class opEdit
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
            this.cTeam = new System.Windows.Forms.DataGridView();
            this.pID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aEmp = new System.Windows.Forms.DataGridView();
            this.pID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbOpDay = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbOpMonth = new System.Windows.Forms.ComboBox();
            this.tbOpYear = new System.Windows.Forms.TextBox();
            this.cbAMPMend = new System.Windows.Forms.ComboBox();
            this.cbAMPMstart = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEndm = new System.Windows.Forms.TextBox();
            this.tbStartm = new System.Windows.Forms.TextBox();
            this.tbEndh = new System.Windows.Forms.TextBox();
            this.tbStarth = new System.Windows.Forms.TextBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.OK1 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aEmp)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cTeam
            // 
            this.cTeam.AllowUserToAddRows = false;
            this.cTeam.AllowUserToDeleteRows = false;
            this.cTeam.AllowUserToResizeColumns = false;
            this.cTeam.AllowUserToResizeRows = false;
            this.cTeam.BackgroundColor = System.Drawing.Color.White;
            this.cTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pID,
            this.Name,
            this.pos});
            this.cTeam.GridColor = System.Drawing.Color.White;
            this.cTeam.Location = new System.Drawing.Point(311, 56);
            this.cTeam.Name = "cTeam";
            this.cTeam.ReadOnly = true;
            this.cTeam.RowHeadersVisible = false;
            this.cTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cTeam.Size = new System.Drawing.Size(207, 183);
            this.cTeam.TabIndex = 1;
            this.cTeam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cTeam_CellClick);
            this.cTeam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cTeam_CellContentClick);
            // 
            // pID
            // 
            this.pID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pID.HeaderText = "Column1";
            this.pID.Name = "pID";
            this.pID.ReadOnly = true;
            this.pID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pID.Visible = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pos
            // 
            this.pos.HeaderText = "";
            this.pos.Name = "pos";
            this.pos.ReadOnly = true;
            // 
            // aEmp
            // 
            this.aEmp.AllowUserToAddRows = false;
            this.aEmp.AllowUserToDeleteRows = false;
            this.aEmp.AllowUserToResizeColumns = false;
            this.aEmp.AllowUserToResizeRows = false;
            this.aEmp.BackgroundColor = System.Drawing.Color.White;
            this.aEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pID1,
            this.Name1,
            this.pos1});
            this.aEmp.GridColor = System.Drawing.Color.White;
            this.aEmp.Location = new System.Drawing.Point(24, 56);
            this.aEmp.Name = "aEmp";
            this.aEmp.ReadOnly = true;
            this.aEmp.RowHeadersVisible = false;
            this.aEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aEmp.Size = new System.Drawing.Size(207, 183);
            this.aEmp.TabIndex = 2;
            this.aEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aEmp_CellClick);
            this.aEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aEmp_CellContentClick);
            // 
            // pID1
            // 
            this.pID1.HeaderText = "Column1";
            this.pID1.Name = "pID1";
            this.pID1.ReadOnly = true;
            this.pID1.Visible = false;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            this.Name1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pos1
            // 
            this.pos1.HeaderText = "";
            this.pos1.Name = "pos1";
            this.pos1.ReadOnly = true;
            // 
            // tbOpDay
            // 
            this.tbOpDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOpDay.ForeColor = System.Drawing.Color.Black;
            this.tbOpDay.FormattingEnabled = true;
            this.tbOpDay.Location = new System.Drawing.Point(213, 35);
            this.tbOpDay.Name = "tbOpDay";
            this.tbOpDay.Size = new System.Drawing.Size(52, 28);
            this.tbOpDay.TabIndex = 90;
            this.tbOpDay.Text = "Day";
            this.tbOpDay.SelectedIndexChanged += new System.EventHandler(this.tbOpDay_SelectedIndexChanged);
            this.tbOpDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOpDay_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 89;
            this.label9.Text = "Operation Date";
            // 
            // cbOpMonth
            // 
            this.cbOpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpMonth.ForeColor = System.Drawing.Color.Black;
            this.cbOpMonth.FormattingEnabled = true;
            this.cbOpMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbOpMonth.Location = new System.Drawing.Point(78, 35);
            this.cbOpMonth.Name = "cbOpMonth";
            this.cbOpMonth.Size = new System.Drawing.Size(128, 28);
            this.cbOpMonth.TabIndex = 88;
            this.cbOpMonth.Text = "Month";
            this.cbOpMonth.SelectedIndexChanged += new System.EventHandler(this.cbOpMonth_SelectedIndexChanged);
            this.cbOpMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOpDay_KeyPress);
            // 
            // tbOpYear
            // 
            this.tbOpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOpYear.ForeColor = System.Drawing.Color.Black;
            this.tbOpYear.Location = new System.Drawing.Point(8, 36);
            this.tbOpYear.Name = "tbOpYear";
            this.tbOpYear.Size = new System.Drawing.Size(65, 27);
            this.tbOpYear.TabIndex = 87;
            this.tbOpYear.Text = "Year";
            this.tbOpYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOpYear.TextChanged += new System.EventHandler(this.tbOpYear_TextChanged);
            this.tbOpYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStarth_KeyPress);
            // 
            // cbAMPMend
            // 
            this.cbAMPMend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAMPMend.FormattingEnabled = true;
            this.cbAMPMend.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbAMPMend.Location = new System.Drawing.Point(456, 62);
            this.cbAMPMend.Name = "cbAMPMend";
            this.cbAMPMend.Size = new System.Drawing.Size(73, 28);
            this.cbAMPMend.TabIndex = 86;
            this.cbAMPMend.Text = "AM/PM";
            this.cbAMPMend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOpDay_KeyPress);
            // 
            // cbAMPMstart
            // 
            this.cbAMPMstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAMPMstart.FormattingEnabled = true;
            this.cbAMPMstart.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbAMPMstart.Location = new System.Drawing.Point(456, 30);
            this.cbAMPMstart.Name = "cbAMPMstart";
            this.cbAMPMstart.Size = new System.Drawing.Size(73, 28);
            this.cbAMPMstart.TabIndex = 85;
            this.cbAMPMstart.Text = "AM/PM";
            this.cbAMPMstart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOpDay_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(398, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 20);
            this.label16.TabIndex = 84;
            this.label16.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(398, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 20);
            this.label15.TabIndex = 83;
            this.label15.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(270, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 82;
            this.label14.Text = "Time End";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(270, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 81;
            this.label10.Text = "Time Start";
            // 
            // tbEndm
            // 
            this.tbEndm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndm.ForeColor = System.Drawing.Color.Gray;
            this.tbEndm.Location = new System.Drawing.Point(412, 63);
            this.tbEndm.MaxLength = 2;
            this.tbEndm.Name = "tbEndm";
            this.tbEndm.Size = new System.Drawing.Size(34, 26);
            this.tbEndm.TabIndex = 80;
            this.tbEndm.Text = "00";
            this.tbEndm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEndm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStarth_KeyPress);
            // 
            // tbStartm
            // 
            this.tbStartm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartm.ForeColor = System.Drawing.Color.Gray;
            this.tbStartm.Location = new System.Drawing.Point(412, 32);
            this.tbStartm.MaxLength = 2;
            this.tbStartm.Name = "tbStartm";
            this.tbStartm.Size = new System.Drawing.Size(34, 26);
            this.tbStartm.TabIndex = 79;
            this.tbStartm.Text = "00";
            this.tbStartm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStartm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStarth_KeyPress);
            // 
            // tbEndh
            // 
            this.tbEndh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndh.ForeColor = System.Drawing.Color.Gray;
            this.tbEndh.Location = new System.Drawing.Point(362, 64);
            this.tbEndh.MaxLength = 2;
            this.tbEndh.Name = "tbEndh";
            this.tbEndh.Size = new System.Drawing.Size(35, 26);
            this.tbEndh.TabIndex = 78;
            this.tbEndh.Text = "00";
            this.tbEndh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEndh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStarth_KeyPress);
            // 
            // tbStarth
            // 
            this.tbStarth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStarth.ForeColor = System.Drawing.Color.Gray;
            this.tbStarth.Location = new System.Drawing.Point(362, 32);
            this.tbStarth.MaxLength = 2;
            this.tbStarth.Name = "tbStarth";
            this.tbStarth.Size = new System.Drawing.Size(35, 26);
            this.tbStarth.TabIndex = 77;
            this.tbStarth.Text = "00";
            this.tbStarth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStarth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStarth_KeyPress);
            // 
            // cbLocation
            // 
            this.cbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "1-A",
            "2-A",
            "3-A",
            "4-A",
            "5-A",
            "6-A",
            "7-A",
            "8-A",
            "9-A",
            "10-A",
            "11-B",
            "12-B",
            "13-B",
            "14-B",
            "15-B",
            "16-B",
            "17-B",
            "18-B",
            "19-B",
            "20-B",
            "21-C",
            "22-C",
            "23-C",
            "24-C",
            "25-C",
            "26-C",
            "27-C",
            "28-C",
            "29-C",
            "30-C",
            "31-D",
            "32-D",
            "33-D",
            "34-D",
            "35-D",
            "36-D",
            "37-D",
            "38-D",
            "39-D",
            "40-D",
            "Acacia",
            "Agdao Proper",
            "Alambre",
            "Alejandra Navarro (Lasang)",
            "Alfonso Angliongto Sr.a",
            "Angalan",
            "Atan-Awe",
            "Baganihan",
            "Bago Aplaya",
            "Bago Gallera",
            "Bago Oshiro",
            "Baguio Proper",
            "Balengaeng",
            "Baliok",
            "Bangkas Heights",
            "Bantol",
            "Baracatan",
            "Bato",
            "Bayabas",
            "Biao Escuela",
            "Biao Guianga",
            "Biao Joaquin",
            "Binugao",
            "Bucana",
            "Buda",
            "Buhangin Proper",
            "Bunawan Proper",
            "Cabantian",
            "Cadalian",
            "Calinan Proper",
            "Callawa",
            "Camansi",
            "Carmen",
            "Catalunan Grande",
            "Catalunan PequeÃ~+mn~o",
            "Catigan",
            "Cawayan",
            "Centro (San Juan)",
            "Colosas",
            "Communal",
            "Crossing Bayabas",
            "Dacudao",
            "Dalag",
            "Dalagdag",
            "Daliao",
            "Daliaon Plantation",
            "Datu Salumay",
            "Dominga",
            "Dumoy",
            "Eden",
            "Fatima (Benowang)",
            "Gatungan",
            "Gov. Paciano Bangoy",
            "Gov. Vicente Duterte",
            "Gumalang",
            "Gumitan",
            "Ilang",
            "Inayangan",
            "Indangan",
            "Kap. Tomas Monteverde, Sr.",
            "Kilate",
            "Lacson",
            "Lamanan",
            "Lampianao",
            "Langub",
            "Lapu-Lapu",
            "Leon Garcia",
            "Lizada",
            "Los Amigos",
            "Lubogan",
            "Lumiad",
            "Ma-a",
            "Mabuhay",
            "Magsaysay",
            "Magtuod",
            "Mahayag",
            "Malabog",
            "Malagos",
            "Malamba",
            "Manambulan",
            "Mandug",
            "Manuel Guianga",
            "Mapula",
            "Marapangi",
            "Marilog Proper",
            "Matina Aplaya",
            "Matina Biao",
            "Matina Crossing",
            "Matina Pangi",
            "Megkawayan",
            "Mintal",
            "Mudiang",
            "Mulig",
            "New Carmen",
            "New Valencia",
            "Pampanga",
            "Panacan",
            "Panalum",
            "Pandaitan",
            "Pangyan",
            "Paquibato Proper",
            "Paradise Embak",
            "Rafael Castillo",
            "Riverside",
            "Salapawan",
            "Salaysay",
            "Saloy",
            "San Antonio",
            "San Isidro (Licanan)",
            "Santo NiÃ~+mn~o",
            "Sasa",
            "Sibulan",
            "Sirawan",
            "Sirib",
            "Suawan (Tuli)",
            "Subasta",
            "Sumimao",
            "Tacunan",
            "Tagakpan",
            "Tagluno",
            "Tagurano",
            "Talandang",
            "Talomo Proper",
            "Talomo River",
            "Tamayong",
            "Tambubong",
            "Tamugan",
            "Tapak",
            "Tawan-Tawan",
            "Tibuloy",
            "Tibungco",
            "Tigatto",
            "Toril Proper",
            "Tugbok Proper",
            "Tungkalan",
            "Ubalde",
            "Ula",
            "Vicente Hizon Sr.a",
            "Waan",
            "Wangan",
            "Wilfredo Aquino",
            "Wines"});
            this.cbLocation.Location = new System.Drawing.Point(8, 69);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(229, 28);
            this.cbLocation.TabIndex = 76;
            this.cbLocation.Text = " ";
            this.cbLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOpDay_KeyPress);
            // 
            // OK1
            // 
            this.OK1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.OK1.FlatAppearance.BorderSize = 0;
            this.OK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK1.ForeColor = System.Drawing.Color.White;
            this.OK1.Location = new System.Drawing.Point(179, 254);
            this.OK1.Name = "OK1";
            this.OK1.Size = new System.Drawing.Size(180, 42);
            this.OK1.TabIndex = 91;
            this.OK1.Text = "Save Changes";
            this.OK1.UseVisualStyleBackColor = false;
            this.OK1.Click += new System.EventHandler(this.OK1_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(249, 97);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(45, 32);
            this.button19.TabIndex = 93;
            this.button19.Text = "▶";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(249, 135);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(45, 32);
            this.button17.TabIndex = 92;
            this.button17.Text = "◀";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbOpMonth);
            this.panel1.Controls.Add(this.cbLocation);
            this.panel1.Controls.Add(this.tbStarth);
            this.panel1.Controls.Add(this.tbOpDay);
            this.panel1.Controls.Add(this.tbEndh);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbStartm);
            this.panel1.Controls.Add(this.tbEndm);
            this.panel1.Controls.Add(this.tbOpYear);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbAMPMend);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cbAMPMstart);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(28, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 151);
            this.panel1.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(220, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 96;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.OK1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.aEmp);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.cTeam);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(28, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 312);
            this.panel2.TabIndex = 95;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(249, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 32);
            this.button5.TabIndex = 96;
            this.button5.Text = "▲";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 106;
            this.label1.Text = "Available";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(357, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 105;
            this.label3.Text = "Final Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(236, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 107;
            this.label2.Text = "Edit Operation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancel_music;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(565, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // opEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(601, 569);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.opEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aEmp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView cTeam;
        private System.Windows.Forms.DataGridView aEmp;
        private System.Windows.Forms.ComboBox tbOpDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbOpMonth;
        private System.Windows.Forms.TextBox tbOpYear;
        private System.Windows.Forms.ComboBox cbAMPMend;
        private System.Windows.Forms.ComboBox cbAMPMstart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEndm;
        private System.Windows.Forms.TextBox tbStartm;
        private System.Windows.Forms.TextBox tbEndh;
        private System.Windows.Forms.TextBox tbStarth;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Button OK1;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
    }
}