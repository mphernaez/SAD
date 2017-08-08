namespace WindowsFormsApplication1
{
    partial class Dog
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.PictureBox();
            this.et = new System.Windows.Forms.PictureBox();
            this.s = new System.Windows.Forms.PictureBox();
            this.a = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addDog = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.tbBreed = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.searchDog = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbGenderSearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.tbColorSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbBreedSearch = new System.Windows.Forms.TextBox();
            this.adoptDog = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvAdoption = new System.Windows.Forms.DataGridView();
            this.euthanizeDog = new System.Windows.Forms.Panel();
            this.btnDone = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.dgvArchive = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.et)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ad)).BeginInit();
            this.addDog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            this.searchDog.SuspendLayout();
            this.adoptDog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdoption)).BeginInit();
            this.euthanizeDog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(162)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.r);
            this.panel1.Controls.Add(this.et);
            this.panel1.Controls.Add(this.s);
            this.panel1.Controls.Add(this.a);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.ad);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 84);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // r
            // 
            this.r.BackColor = System.Drawing.Color.Transparent;
            this.r.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.triangle_512;
            this.r.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.r.Location = new System.Drawing.Point(891, 69);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(28, 31);
            this.r.TabIndex = 43;
            this.r.TabStop = false;
            this.r.Visible = false;
            // 
            // et
            // 
            this.et.BackColor = System.Drawing.Color.Transparent;
            this.et.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.triangle_512;
            this.et.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.et.Location = new System.Drawing.Point(831, 69);
            this.et.Name = "et";
            this.et.Size = new System.Drawing.Size(28, 31);
            this.et.TabIndex = 42;
            this.et.TabStop = false;
            this.et.Visible = false;
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.triangle_512;
            this.s.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.s.Location = new System.Drawing.Point(710, 70);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(28, 31);
            this.s.TabIndex = 40;
            this.s.TabStop = false;
            this.s.Visible = false;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.triangle_512;
            this.a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a.Location = new System.Drawing.Point(648, 70);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(28, 31);
            this.a.TabIndex = 39;
            this.a.TabStop = false;
            this.a.Visible = false;
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
            this.button8.Location = new System.Drawing.Point(878, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 55);
            this.button8.TabIndex = 38;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.Color.Transparent;
            this.ad.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.triangle_512;
            this.ad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ad.Location = new System.Drawing.Point(770, 70);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(28, 31);
            this.ad.TabIndex = 41;
            this.ad.TabStop = false;
            this.ad.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.euthanize;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(817, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 55);
            this.button6.TabIndex = 37;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            this.button6.MouseHover += new System.EventHandler(this.button6_MouseHover);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.adoptt;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(756, 15);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(55, 55);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.searchh;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(695, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.addd;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(634, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // addDog
            // 
            this.addDog.BackColor = System.Drawing.Color.White;
            this.addDog.Controls.Add(this.button11);
            this.addDog.Controls.Add(this.label9);
            this.addDog.Controls.Add(this.tbColor);
            this.addDog.Controls.Add(this.cbSize);
            this.addDog.Controls.Add(this.cbOperation);
            this.addDog.Controls.Add(this.tbBreed);
            this.addDog.Controls.Add(this.button4);
            this.addDog.Controls.Add(this.tbDesc);
            this.addDog.Controls.Add(this.cbGender);
            this.addDog.Controls.Add(this.label2);
            this.addDog.Location = new System.Drawing.Point(27, 84);
            this.addDog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addDog.Name = "addDog";
            this.addDog.Size = new System.Drawing.Size(1015, 536);
            this.addDog.TabIndex = 2;
            this.addDog.Visible = false;
            this.addDog.Paint += new System.Windows.Forms.PaintEventHandler(this.addDog_Paint_1);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(82)))));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(389, 349);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(260, 38);
            this.button11.TabIndex = 26;
            this.button11.Text = "Reset";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.label9.Location = new System.Drawing.Point(435, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Add a new dog";
            // 
            // tbColor
            // 
            this.tbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColor.ForeColor = System.Drawing.Color.Gray;
            this.tbColor.Location = new System.Drawing.Point(438, 183);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(205, 26);
            this.tbColor.TabIndex = 11;
            this.tbColor.Text = "Color";
            this.tbColor.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            this.tbColor.Enter += new System.EventHandler(this.textBox3_Enter);
            // 
            // cbSize
            // 
            this.cbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.ForeColor = System.Drawing.Color.Gray;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Extra Small (less than 1ft)",
            "Small (1ft)",
            "Large (2ft)",
            "Extra Large (more than 2ft)"});
            this.cbSize.Location = new System.Drawing.Point(221, 228);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(205, 28);
            this.cbSize.TabIndex = 5;
            this.cbSize.TabStop = false;
            this.cbSize.Text = "Size";
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // cbOperation
            // 
            this.cbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperation.ForeColor = System.Drawing.Color.Gray;
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(221, 147);
            this.cbOperation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(422, 28);
            this.cbOperation.TabIndex = 1;
            this.cbOperation.Text = "Operation Date and Location";
            this.cbOperation.SelectedIndexChanged += new System.EventHandler(this.cbOperation_SelectedIndexChanged);
            // 
            // tbBreed
            // 
            this.tbBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBreed.ForeColor = System.Drawing.Color.Gray;
            this.tbBreed.Location = new System.Drawing.Point(438, 228);
            this.tbBreed.Name = "tbBreed";
            this.tbBreed.Size = new System.Drawing.Size(205, 26);
            this.tbBreed.TabIndex = 4;
            this.tbBreed.Text = "Breed";
            this.tbBreed.Enter += new System.EventHandler(this.tbBreed_Enter);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(389, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 38);
            this.button4.TabIndex = 10;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbDesc
            // 
            this.tbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc.ForeColor = System.Drawing.Color.Gray;
            this.tbDesc.Location = new System.Drawing.Point(650, 145);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(205, 109);
            this.tbDesc.TabIndex = 6;
            this.tbDesc.Text = "Other Descriptions";
            this.tbDesc.Enter += new System.EventHandler(this.tbDesc_Enter);
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.ForeColor = System.Drawing.Color.Gray;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(221, 183);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(205, 28);
            this.cbGender.TabIndex = 3;
            this.cbGender.Text = "Gender";
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(385, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dog Profiling";
            this.toolTip1.SetToolTip(this.label2, "Add a new dog");
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(419, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search Dog";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvProfiles
            // 
            this.dgvProfiles.AllowUserToAddRows = false;
            this.dgvProfiles.AllowUserToDeleteRows = false;
            this.dgvProfiles.BackgroundColor = System.Drawing.Color.White;
            this.dgvProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfiles.Location = new System.Drawing.Point(15, 114);
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.ReadOnly = true;
            this.dgvProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfiles.Size = new System.Drawing.Size(982, 319);
            this.dgvProfiles.TabIndex = 20;
            this.dgvProfiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfiles_CellClick);
            // 
            // searchDog
            // 
            this.searchDog.BackColor = System.Drawing.Color.White;
            this.searchDog.Controls.Add(this.label10);
            this.searchDog.Controls.Add(this.cbGenderSearch);
            this.searchDog.Controls.Add(this.label6);
            this.searchDog.Controls.Add(this.label5);
            this.searchDog.Controls.Add(this.label4);
            this.searchDog.Controls.Add(this.button7);
            this.searchDog.Controls.Add(this.tbColorSearch);
            this.searchDog.Controls.Add(this.button3);
            this.searchDog.Controls.Add(this.dgvProfiles);
            this.searchDog.Controls.Add(this.tbBreedSearch);
            this.searchDog.Controls.Add(this.label3);
            this.searchDog.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDog.Location = new System.Drawing.Point(27, 84);
            this.searchDog.Name = "searchDog";
            this.searchDog.Size = new System.Drawing.Size(1015, 536);
            this.searchDog.TabIndex = 11;
            this.searchDog.Visible = false;
            this.searchDog.Paint += new System.Windows.Forms.PaintEventHandler(this.searchDog_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(879, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "view all";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cbGenderSearch
            // 
            this.cbGenderSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenderSearch.FormattingEnabled = true;
            this.cbGenderSearch.Items.AddRange(new object[] {
            "Male\t",
            "Female"});
            this.cbGenderSearch.Location = new System.Drawing.Point(608, 79);
            this.cbGenderSearch.Name = "cbGenderSearch";
            this.cbGenderSearch.Size = new System.Drawing.Size(89, 30);
            this.cbGenderSearch.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Color";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Breed";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
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
            this.button7.Location = new System.Drawing.Point(705, 82);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 27);
            this.button7.TabIndex = 28;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tbColorSearch
            // 
            this.tbColorSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColorSearch.Location = new System.Drawing.Point(426, 83);
            this.tbColorSearch.Name = "tbColorSearch";
            this.tbColorSearch.Size = new System.Drawing.Size(112, 26);
            this.tbColorSearch.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(765, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 38);
            this.button3.TabIndex = 23;
            this.button3.Text = "Claim";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tbBreedSearch
            // 
            this.tbBreedSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBreedSearch.Location = new System.Drawing.Point(245, 83);
            this.tbBreedSearch.Name = "tbBreedSearch";
            this.tbBreedSearch.Size = new System.Drawing.Size(135, 26);
            this.tbBreedSearch.TabIndex = 1;
            // 
            // adoptDog
            // 
            this.adoptDog.BackColor = System.Drawing.Color.White;
            this.adoptDog.Controls.Add(this.label8);
            this.adoptDog.Controls.Add(this.button9);
            this.adoptDog.Controls.Add(this.label12);
            this.adoptDog.Controls.Add(this.dgvAdoption);
            this.adoptDog.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adoptDog.Location = new System.Drawing.Point(27, 84);
            this.adoptDog.Name = "adoptDog";
            this.adoptDog.Size = new System.Drawing.Size(1015, 536);
            this.adoptDog.TabIndex = 40;
            this.adoptDog.Visible = false;
            this.adoptDog.Paint += new System.Windows.Forms.PaintEventHandler(this.adoptDog_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.label8.Location = new System.Drawing.Point(375, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "List of Dogs Available for Adoption";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(765, 454);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(232, 38);
            this.button9.TabIndex = 23;
            this.button9.Text = "Adopt";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(373, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 39);
            this.label12.TabIndex = 11;
            this.label12.Text = "Adopt A Dog";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dgvAdoption
            // 
            this.dgvAdoption.AllowUserToAddRows = false;
            this.dgvAdoption.AllowUserToDeleteRows = false;
            this.dgvAdoption.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdoption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdoption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdoption.Location = new System.Drawing.Point(15, 114);
            this.dgvAdoption.Name = "dgvAdoption";
            this.dgvAdoption.ReadOnly = true;
            this.dgvAdoption.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdoption.Size = new System.Drawing.Size(982, 319);
            this.dgvAdoption.TabIndex = 20;
            this.dgvAdoption.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdoption_CellClick);
            this.dgvAdoption.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdoption_CellContentClick);
            // 
            // euthanizeDog
            // 
            this.euthanizeDog.BackColor = System.Drawing.Color.White;
            this.euthanizeDog.Controls.Add(this.btnDone);
            this.euthanizeDog.Controls.Add(this.label7);
            this.euthanizeDog.Controls.Add(this.button10);
            this.euthanizeDog.Controls.Add(this.dgvArchive);
            this.euthanizeDog.Controls.Add(this.label11);
            this.euthanizeDog.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euthanizeDog.Location = new System.Drawing.Point(27, 84);
            this.euthanizeDog.Name = "euthanizeDog";
            this.euthanizeDog.Size = new System.Drawing.Size(1015, 536);
            this.euthanizeDog.TabIndex = 37;
            this.euthanizeDog.Visible = false;
            this.euthanizeDog.Paint += new System.Windows.Forms.PaintEventHandler(this.euthanizeDog_Paint);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(82)))));
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(85)))), ((int)(((byte)(70)))));
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(820, 454);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(177, 38);
            this.btnDone.TabIndex = 25;
            this.btnDone.Text = "Euthanize All";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.label7.Location = new System.Drawing.Point(385, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Dogs that need to be euthanized";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(637, 454);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(177, 38);
            this.button10.TabIndex = 23;
            this.button10.Text = "Euthanize";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dgvArchive
            // 
            this.dgvArchive.AllowUserToAddRows = false;
            this.dgvArchive.AllowUserToDeleteRows = false;
            this.dgvArchive.BackgroundColor = System.Drawing.Color.White;
            this.dgvArchive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchive.Location = new System.Drawing.Point(15, 114);
            this.dgvArchive.Name = "dgvArchive";
            this.dgvArchive.ReadOnly = true;
            this.dgvArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArchive.Size = new System.Drawing.Size(982, 319);
            this.dgvArchive.TabIndex = 20;
            this.dgvArchive.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArchive_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(373, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 39);
            this.label11.TabIndex = 11;
            this.label11.Text = "Euthanize Dog";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Dog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1070, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDog);
            this.Controls.Add(this.searchDog);
            this.Controls.Add(this.euthanizeDog);
            this.Controls.Add(this.adoptDog);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDog";
            this.Load += new System.EventHandler(this.AddDog_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.et)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ad)).EndInit();
            this.addDog.ResumeLayout(false);
            this.addDog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            this.searchDog.ResumeLayout(false);
            this.searchDog.PerformLayout();
            this.adoptDog.ResumeLayout(false);
            this.adoptDog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdoption)).EndInit();
            this.euthanizeDog.ResumeLayout(false);
            this.euthanizeDog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel addDog;
        private System.Windows.Forms.DataGridView dgvProfiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Panel searchDog;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Panel adoptDog;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dgvAdoption;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cbGenderSearch;
        public System.Windows.Forms.TextBox tbColorSearch;
        public System.Windows.Forms.TextBox tbBreedSearch;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Panel euthanizeDog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dgvArchive;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.TextBox tbBreed;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox a;
        private System.Windows.Forms.PictureBox r;
        private System.Windows.Forms.PictureBox et;
        private System.Windows.Forms.PictureBox s;
        private System.Windows.Forms.PictureBox ad;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}