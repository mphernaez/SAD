namespace WindowsFormsApplication1
{
    partial class Claim
    {//11
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Claim));
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.tbnumber = new System.Windows.Forms.TextBox();
            this.tbadd = new System.Windows.Forms.TextBox();
            this.tbIDtype = new System.Windows.Forms.TextBox();
            this.tbIDnum = new System.Windows.Forms.TextBox();
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbmname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tblname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbDay = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.breed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelPayment = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.breeds = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.impounddogpoundDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.impounddogpoundDataSet = new WindowsFormsApplication1.impounddogpoundDataSet();
            this.printPreviewDialogCR = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentCR = new System.Drawing.Printing.PrintDocument();
            this.claimRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impounddogpoundDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impounddogpoundDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimRBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label19.Location = new System.Drawing.Point(281, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(141, 46);
            this.label19.TabIndex = 16;
            this.label19.Text = "CLAIM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(162)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(254, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 41);
            this.button1.TabIndex = 18;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(283, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "CLAIMER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Firstname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Contact Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(310, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(310, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Valid ID Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(310, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Valid ID Number";
            // 
            // tbfname
            // 
            this.tbfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfname.Location = new System.Drawing.Point(115, 15);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(180, 26);
            this.tbfname.TabIndex = 22;
            // 
            // tbnumber
            // 
            this.tbnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnumber.Location = new System.Drawing.Point(137, 136);
            this.tbnumber.Name = "tbnumber";
            this.tbnumber.Size = new System.Drawing.Size(158, 26);
            this.tbnumber.TabIndex = 25;
            // 
            // tbadd
            // 
            this.tbadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbadd.Location = new System.Drawing.Point(384, 13);
            this.tbadd.Multiline = true;
            this.tbadd.Name = "tbadd";
            this.tbadd.Size = new System.Drawing.Size(246, 67);
            this.tbadd.TabIndex = 26;
            // 
            // tbIDtype
            // 
            this.tbIDtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDtype.Location = new System.Drawing.Point(441, 96);
            this.tbIDtype.Name = "tbIDtype";
            this.tbIDtype.Size = new System.Drawing.Size(189, 26);
            this.tbIDtype.TabIndex = 27;
            // 
            // tbIDnum
            // 
            this.tbIDnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDnum.Location = new System.Drawing.Point(441, 136);
            this.tbIDnum.Name = "tbIDnum";
            this.tbIDnum.Size = new System.Drawing.Size(189, 26);
            this.tbIDnum.TabIndex = 28;
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox.Location = new System.Drawing.Point(314, 178);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(122, 24);
            this.checkbox.TabIndex = 29;
            this.checkbox.Text = "Avail Vaccine";
            this.checkbox.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Middlename";
            // 
            // tbmname
            // 
            this.tbmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmname.Location = new System.Drawing.Point(115, 54);
            this.tbmname.Name = "tbmname";
            this.tbmname.Size = new System.Drawing.Size(180, 26);
            this.tbmname.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Lastname";
            // 
            // tblname
            // 
            this.tblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblname.Location = new System.Drawing.Point(115, 95);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(180, 26);
            this.tblname.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.tbDay);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.tbYear);
            this.panel2.Controls.Add(this.cbMonth);
            this.panel2.Controls.Add(this.tblname);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.tbmname);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.checkbox);
            this.panel2.Controls.Add(this.tbIDnum);
            this.panel2.Controls.Add(this.tbIDtype);
            this.panel2.Controls.Add(this.tbadd);
            this.panel2.Controls.Add(this.tbnumber);
            this.panel2.Controls.Add(this.tbfname);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(23, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 217);
            this.panel2.TabIndex = 17;
            // 
            // tbDay
            // 
            this.tbDay.Enabled = false;
            this.tbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDay.FormattingEnabled = true;
            this.tbDay.Location = new System.Drawing.Point(244, 172);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(51, 28);
            this.tbDay.TabIndex = 34;
            this.tbDay.Text = "Day";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Birthdate";
            // 
            // tbYear
            // 
            this.tbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYear.Location = new System.Drawing.Point(92, 173);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(65, 26);
            this.tbYear.TabIndex = 32;
            this.tbYear.Text = "Year";
            this.tbYear.TextChanged += new System.EventHandler(this.tbYear_TextChanged);
            this.tbYear.Enter += new System.EventHandler(this.tbYear_Enter);
            // 
            // cbMonth
            // 
            this.cbMonth.Enabled = false;
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.ForeColor = System.Drawing.Color.Black;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
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
            this.cbMonth.Location = new System.Drawing.Point(161, 172);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(77, 28);
            this.cbMonth.TabIndex = 31;
            this.cbMonth.Text = "Month";
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // breed
            // 
            this.breed.AutoSize = true;
            this.breed.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breed.Location = new System.Drawing.Point(70, 43);
            this.breed.Name = "breed";
            this.breed.Size = new System.Drawing.Size(0, 18);
            this.breed.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(19, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender:";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.Location = new System.Drawing.Point(94, 70);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(48, 22);
            this.color.TabIndex = 11;
            this.color.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(18, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Size:";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.Location = new System.Drawing.Point(94, 97);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(40, 22);
            this.size.TabIndex = 12;
            this.size.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(321, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Caught:";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(94, 42);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(62, 22);
            this.gender.TabIndex = 13;
            this.gender.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color:";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.Location = new System.Drawing.Point(457, 12);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(71, 22);
            this.location.TabIndex = 14;
            this.location.Text = "Location";
            this.location.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(321, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location Caught:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(457, 37);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(43, 22);
            this.date.TabIndex = 15;
            this.date.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breed:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(454, 65);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(45, 22);
            this.time.TabIndex = 17;
            this.time.Text = "Time";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.breed);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 603);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panel3.CausesValidation = false;
            this.panel3.Controls.Add(this.lblRemarks);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.labelPayment);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.breeds);
            this.panel3.Controls.Add(this.color);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.size);
            this.panel3.Controls.Add(this.time);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.gender);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.location);
            this.panel3.Controls.Add(this.date);
            this.panel3.Location = new System.Drawing.Point(23, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 149);
            this.panel3.TabIndex = 31;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRemarks.Location = new System.Drawing.Point(456, 117);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(50, 16);
            this.lblRemarks.TabIndex = 24;
            this.lblRemarks.Text = "Remarks";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(457, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 22);
            this.label20.TabIndex = 23;
            this.label20.Text = "P";
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayment.Location = new System.Drawing.Point(471, 95);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(70, 22);
            this.labelPayment.TabIndex = 22;
            this.labelPayment.Text = "Payment";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label18.Location = new System.Drawing.Point(322, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 20);
            this.label18.TabIndex = 21;
            this.label18.Text = "Payment:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(322, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Time Caught:";
            // 
            // breeds
            // 
            this.breeds.AutoSize = true;
            this.breeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breeds.Location = new System.Drawing.Point(94, 14);
            this.breeds.Name = "breeds";
            this.breeds.Size = new System.Drawing.Size(52, 20);
            this.breeds.TabIndex = 19;
            this.breeds.Text = "Breed";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(313, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 31);
            this.label16.TabIndex = 21;
            this.label16.Text = "DOG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancel_music;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(679, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 20);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // impounddogpoundDataSetBindingSource
            // 
            this.impounddogpoundDataSetBindingSource.DataSource = this.impounddogpoundDataSet;
            this.impounddogpoundDataSetBindingSource.Position = 0;
            // 
            // impounddogpoundDataSet
            // 
            this.impounddogpoundDataSet.DataSetName = "impounddogpoundDataSet";
            this.impounddogpoundDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printPreviewDialogCR
            // 
            this.printPreviewDialogCR.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogCR.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogCR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialogCR.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogCR.Enabled = true;
            this.printPreviewDialogCR.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogCR.Icon")));
            this.printPreviewDialogCR.Name = "printPreviewDialogCR";
            this.printPreviewDialogCR.ShowIcon = false;
            this.printPreviewDialogCR.Visible = false;
            // 
            // printDocumentCR
            // 
            this.printDocumentCR.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentCR_PrintPage);
            // 
            // claimRBindingSource
            // 
            this.claimRBindingSource.DataSource = typeof(WindowsFormsApplication1.ClaimR);
            // 
            // Claim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 602);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Claim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Claim_FormClosing);
            this.Load += new System.EventHandler(this.Claim_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impounddogpoundDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impounddogpoundDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimRBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.TextBox tbnumber;
        private System.Windows.Forms.TextBox tbadd;
        private System.Windows.Forms.TextBox tbIDtype;
        private System.Windows.Forms.TextBox tbIDnum;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbmname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tblname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label breed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label breeds;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogCR;
        private System.Drawing.Printing.PrintDocument printDocumentCR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox tbDay;
        private System.Windows.Forms.BindingSource impounddogpoundDataSetBindingSource;
        private impounddogpoundDataSet impounddogpoundDataSet;
        private System.Windows.Forms.BindingSource claimRBindingSource;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblRemarks;
    }
}