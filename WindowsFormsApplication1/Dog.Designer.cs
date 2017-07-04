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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dog));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.PictureBox();
            this.addDog = new System.Windows.Forms.Panel();
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
            this.dgvAdoption = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.euthanizeDog = new System.Windows.Forms.Panel();
            this.btnDone = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.dgvArchive = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectButton)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(92, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(148)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.selectButton);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 785);
            this.panel1.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(52, 454);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 80);
            this.button6.TabIndex = 37;
            this.button6.Text = "Euthanise";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Adopt;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(52, 314);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 97);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(54, 166);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 97);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._new;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(52, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 97);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // selectButton
            // 
            this.selectButton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.selects;
            this.selectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectButton.Location = new System.Drawing.Point(20, 298);
            this.selectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(156, 128);
            this.selectButton.TabIndex = 2;
            this.selectButton.TabStop = false;
            this.selectButton.Visible = false;
            // 
            // addDog
            // 
            this.addDog.Controls.Add(this.tbColor);
            this.addDog.Controls.Add(this.cbSize);
            this.addDog.Controls.Add(this.cbOperation);
            this.addDog.Controls.Add(this.tbBreed);
            this.addDog.Controls.Add(this.button4);
            this.addDog.Controls.Add(this.tbDesc);
            this.addDog.Controls.Add(this.cbGender);
            this.addDog.Controls.Add(this.label2);
            this.addDog.Location = new System.Drawing.Point(195, 9);
            this.addDog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addDog.Name = "addDog";
            this.addDog.Size = new System.Drawing.Size(910, 588);
            this.addDog.TabIndex = 2;
            this.addDog.Visible = false;
            // 
            // tbColor
            // 
            this.tbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColor.Location = new System.Drawing.Point(129, 175);
            this.tbColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(306, 35);
            this.tbColor.TabIndex = 11;
            this.tbColor.Text = "Color";
            this.tbColor.Enter += new System.EventHandler(this.textBox3_Enter);
            // 
            // cbSize
            // 
            this.cbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Extra Small (less than 1ft)",
            "Small (1ft)",
            "Large (2ft)",
            "Extra Large (more than 2ft)"});
            this.cbSize.Location = new System.Drawing.Point(129, 329);
            this.cbSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(306, 37);
            this.cbSize.TabIndex = 5;
            this.cbSize.TabStop = false;
            this.cbSize.Text = "Size";
            // 
            // cbOperation
            // 
            this.cbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Items.AddRange(new object[] {
            "February 27, 2016, Matina",
            "February 27, 2017, Ma-a",
            "February 28, 2017, Buhangin",
            "February 28, 2017, Bangkerohan",
            "March 1, 2017, Jacinto",
            "February 21, 2017, Roxas"});
            this.cbOperation.Location = new System.Drawing.Point(129, 120);
            this.cbOperation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(622, 37);
            this.cbOperation.TabIndex = 1;
            this.cbOperation.Text = "Operation Date and Location";
            // 
            // tbBreed
            // 
            this.tbBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBreed.Location = new System.Drawing.Point(129, 280);
            this.tbBreed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBreed.Name = "tbBreed";
            this.tbBreed.Size = new System.Drawing.Size(306, 35);
            this.tbBreed.TabIndex = 4;
            this.tbBreed.Text = "Breed";
            this.tbBreed.Enter += new System.EventHandler(this.tbBreed_Enter);
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
            this.button4.Location = new System.Drawing.Point(590, 383);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 58);
            this.button4.TabIndex = 10;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbDesc
            // 
            this.tbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc.Location = new System.Drawing.Point(446, 175);
            this.tbDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(306, 196);
            this.tbDesc.TabIndex = 6;
            this.tbDesc.Text = "Other Descriptions";
            this.tbDesc.Enter += new System.EventHandler(this.tbDesc_Enter);
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(129, 228);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(306, 37);
            this.cbGender.TabIndex = 3;
            this.cbGender.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(120, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 61);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dog Profiling";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(64, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 61);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search Dog";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvProfiles
            // 
            this.dgvProfiles.AllowUserToAddRows = false;
            this.dgvProfiles.AllowUserToDeleteRows = false;
            this.dgvProfiles.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfiles.Location = new System.Drawing.Point(64, 149);
            this.dgvProfiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.ReadOnly = true;
            this.dgvProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfiles.Size = new System.Drawing.Size(770, 352);
            this.dgvProfiles.TabIndex = 20;
            this.dgvProfiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfiles_CellClick);
            // 
            // searchDog
            // 
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
            this.searchDog.Location = new System.Drawing.Point(182, 29);
            this.searchDog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchDog.Name = "searchDog";
            this.searchDog.Size = new System.Drawing.Size(910, 588);
            this.searchDog.TabIndex = 11;
            this.searchDog.Visible = false;
            this.searchDog.Paint += new System.Windows.Forms.PaintEventHandler(this.searchDog_Paint);
            // 
            // cbGenderSearch
            // 
            this.cbGenderSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenderSearch.FormattingEnabled = true;
            this.cbGenderSearch.Items.AddRange(new object[] {
            "",
            "Male\t",
            "Female"});
            this.cbGenderSearch.Location = new System.Drawing.Point(666, 91);
            this.cbGenderSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGenderSearch.Name = "cbGenderSearch";
            this.cbGenderSearch.Size = new System.Drawing.Size(115, 37);
            this.cbGenderSearch.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(588, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 26);
            this.label6.TabIndex = 36;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 30;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Breed";
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
            this.button7.Location = new System.Drawing.Point(794, 95);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(26, 33);
            this.button7.TabIndex = 28;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tbColorSearch
            // 
            this.tbColorSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColorSearch.Location = new System.Drawing.Point(399, 95);
            this.tbColorSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbColorSearch.Name = "tbColorSearch";
            this.tbColorSearch.Size = new System.Drawing.Size(166, 35);
            this.tbColorSearch.TabIndex = 2;
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
            this.button3.Location = new System.Drawing.Point(670, 509);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 58);
            this.button3.TabIndex = 23;
            this.button3.Text = "Claim";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tbBreedSearch
            // 
            this.tbBreedSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBreedSearch.Location = new System.Drawing.Point(128, 95);
            this.tbBreedSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBreedSearch.Name = "tbBreedSearch";
            this.tbBreedSearch.Size = new System.Drawing.Size(200, 35);
            this.tbBreedSearch.TabIndex = 1;
            // 
            // adoptDog
            // 
            this.adoptDog.Controls.Add(this.label8);
            this.adoptDog.Controls.Add(this.button9);
            this.adoptDog.Controls.Add(this.dgvAdoption);
            this.adoptDog.Controls.Add(this.label12);
            this.adoptDog.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adoptDog.Location = new System.Drawing.Point(190, 17);
            this.adoptDog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adoptDog.Name = "adoptDog";
            this.adoptDog.Size = new System.Drawing.Size(910, 588);
            this.adoptDog.TabIndex = 40;
            this.adoptDog.Visible = false;
            this.adoptDog.Paint += new System.Windows.Forms.PaintEventHandler(this.adoptDog_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(322, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = "List of Dogs Available for Adoption";
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
            this.button9.Location = new System.Drawing.Point(670, 492);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(164, 58);
            this.button9.TabIndex = 23;
            this.button9.Text = "Adopt";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dgvAdoption
            // 
            this.dgvAdoption.AllowUserToAddRows = false;
            this.dgvAdoption.AllowUserToDeleteRows = false;
            this.dgvAdoption.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvAdoption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdoption.Location = new System.Drawing.Point(64, 122);
            this.dgvAdoption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAdoption.Name = "dgvAdoption";
            this.dgvAdoption.ReadOnly = true;
            this.dgvAdoption.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdoption.Size = new System.Drawing.Size(770, 357);
            this.dgvAdoption.TabIndex = 20;
            this.dgvAdoption.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdoption_CellClick);
            this.dgvAdoption.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdoption_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(64, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(323, 61);
            this.label12.TabIndex = 11;
            this.label12.Text = "Adopt A Dog";
            // 
            // euthanizeDog
            // 
            this.euthanizeDog.Controls.Add(this.btnDone);
            this.euthanizeDog.Controls.Add(this.label7);
            this.euthanizeDog.Controls.Add(this.button10);
            this.euthanizeDog.Controls.Add(this.dgvArchive);
            this.euthanizeDog.Controls.Add(this.label11);
            this.euthanizeDog.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euthanizeDog.Location = new System.Drawing.Point(186, 22);
            this.euthanizeDog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.euthanizeDog.Name = "euthanizeDog";
            this.euthanizeDog.Size = new System.Drawing.Size(910, 588);
            this.euthanizeDog.TabIndex = 37;
            this.euthanizeDog.Visible = false;
            this.euthanizeDog.Paint += new System.Windows.Forms.PaintEventHandler(this.euthanizeDog_Paint);
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
            this.btnDone.Location = new System.Drawing.Point(676, 514);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(164, 58);
            this.btnDone.TabIndex = 25;
            this.btnDone.Text = "Done to All";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(69, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Dogs that need to be euthanized";
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.button;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(506, 514);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(164, 58);
            this.button10.TabIndex = 23;
            this.button10.Text = "Euthanize";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dgvArchive
            // 
            this.dgvArchive.AllowUserToAddRows = false;
            this.dgvArchive.AllowUserToDeleteRows = false;
            this.dgvArchive.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchive.Location = new System.Drawing.Point(70, 132);
            this.dgvArchive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvArchive.Name = "dgvArchive";
            this.dgvArchive.ReadOnly = true;
            this.dgvArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArchive.Size = new System.Drawing.Size(770, 372);
            this.dgvArchive.TabIndex = 20;
            this.dgvArchive.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArchive_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(64, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(372, 61);
            this.label11.TabIndex = 11;
            this.label11.Text = "Euthanize Dog";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Dog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(208)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1110, 628);
            this.Controls.Add(this.searchDog);
            this.Controls.Add(this.euthanizeDog);
            this.Controls.Add(this.addDog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adoptDog);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDog";
            this.Load += new System.EventHandler(this.AddDog_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectButton)).EndInit();
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
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.DataGridView dgvProfiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox selectButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.TextBox tbBreed;
        public System.Windows.Forms.Panel searchDog;
        private System.Windows.Forms.TextBox tbColor;
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
    }
}