namespace WindowsFormsApplication1
{
    partial class Inventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.inv = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.dgvout = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.nubi = new System.Windows.Forms.NumericUpDown();
            this.OK1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvin = new System.Windows.Forms.DataGridView();
            this.Sout = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.OK2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvo = new System.Windows.Forms.DataGridView();
            this.nubo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbdesc = new System.Windows.Forms.TextBox();
            this.newitem = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nudmin = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.i = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.inv.SuspendLayout();
            this.dgvout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvin)).BeginInit();
            this.Sout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubo)).BeginInit();
            this.newitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(162)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.i);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.a);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.r);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 84);
            this.panel1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(427, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 40);
            this.label12.TabIndex = 11;
            this.label12.Text = "Inventory";
            // 
            // inv
            // 
            this.inv.BackColor = System.Drawing.Color.White;
            this.inv.Controls.Add(this.button9);
            this.inv.Controls.Add(this.button5);
            this.inv.Controls.Add(this.button16);
            this.inv.Controls.Add(this.label12);
            this.inv.Controls.Add(this.dgvout);
            this.inv.Controls.Add(this.Sout);
            this.inv.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv.Location = new System.Drawing.Point(24, 84);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(1016, 543);
            this.inv.TabIndex = 52;
            this.inv.Visible = false;
            this.inv.Paint += new System.Windows.Forms.PaintEventHandler(this.inv_Paint);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(210, 82);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 32);
            this.button9.TabIndex = 56;
            this.button9.Text = "View All";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(110, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 32);
            this.button5.TabIndex = 33;
            this.button5.Text = "Stock Out";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(10, 82);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 32);
            this.button16.TabIndex = 32;
            this.button16.Text = "Stock In";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // dgvout
            // 
            this.dgvout.Controls.Add(this.label6);
            this.dgvout.Controls.Add(this.nubi);
            this.dgvout.Controls.Add(this.OK1);
            this.dgvout.Controls.Add(this.checkBox1);
            this.dgvout.Controls.Add(this.button6);
            this.dgvout.Controls.Add(this.numericUpDown2);
            this.dgvout.Controls.Add(this.label7);
            this.dgvout.Controls.Add(this.dgvin);
            this.dgvout.Location = new System.Drawing.Point(11, 114);
            this.dgvout.Name = "dgvout";
            this.dgvout.Size = new System.Drawing.Size(982, 319);
            this.dgvout.TabIndex = 34;
            this.dgvout.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(439, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 31);
            this.label6.TabIndex = 58;
            this.label6.Text = "Stock-In";
            // 
            // nubi
            // 
            this.nubi.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nubi.Location = new System.Drawing.Point(702, 267);
            this.nubi.Name = "nubi";
            this.nubi.Size = new System.Drawing.Size(120, 26);
            this.nubi.TabIndex = 49;
            this.nubi.ValueChanged += new System.EventHandler(this.nubi_ValueChanged);
            // 
            // OK1
            // 
            this.OK1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.OK1.FlatAppearance.BorderSize = 0;
            this.OK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK1.ForeColor = System.Drawing.Color.White;
            this.OK1.Location = new System.Drawing.Point(840, 259);
            this.OK1.Name = "OK1";
            this.OK1.Size = new System.Drawing.Size(124, 42);
            this.OK1.TabIndex = 45;
            this.OK1.Text = "OK";
            this.OK1.UseVisualStyleBackColor = false;
            this.OK1.Click += new System.EventHandler(this.OK1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.checkBox1.Location = new System.Drawing.Point(169, 329);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 30);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "Damaged";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(445, 321);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 38);
            this.button6.TabIndex = 43;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(301, 326);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(138, 32);
            this.numericUpDown2.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(16, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 31);
            this.label7.TabIndex = 41;
            this.label7.Text = "Items";
            // 
            // dgvin
            // 
            this.dgvin.AllowUserToAddRows = false;
            this.dgvin.AllowUserToDeleteRows = false;
            this.dgvin.BackgroundColor = System.Drawing.Color.White;
            this.dgvin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvin.Location = new System.Drawing.Point(12, 53);
            this.dgvin.Name = "dgvin";
            this.dgvin.ReadOnly = true;
            this.dgvin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvin.Size = new System.Drawing.Size(952, 203);
            this.dgvin.TabIndex = 20;
            this.dgvin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvin_CellClick);
            // 
            // Sout
            // 
            this.Sout.Controls.Add(this.label4);
            this.Sout.Controls.Add(this.OK2);
            this.Sout.Controls.Add(this.button7);
            this.Sout.Controls.Add(this.numericUpDown1);
            this.Sout.Controls.Add(this.label5);
            this.Sout.Controls.Add(this.dgvo);
            this.Sout.Controls.Add(this.nubo);
            this.Sout.Location = new System.Drawing.Point(11, 114);
            this.Sout.Name = "Sout";
            this.Sout.Size = new System.Drawing.Size(982, 319);
            this.Sout.TabIndex = 44;
            this.Sout.Visible = false;
            this.Sout.Paint += new System.Windows.Forms.PaintEventHandler(this.Sout_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(425, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 31);
            this.label4.TabIndex = 57;
            this.label4.Text = "Stock-Out";
            // 
            // OK2
            // 
            this.OK2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.OK2.FlatAppearance.BorderSize = 0;
            this.OK2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK2.ForeColor = System.Drawing.Color.White;
            this.OK2.Location = new System.Drawing.Point(840, 259);
            this.OK2.Name = "OK2";
            this.OK2.Size = new System.Drawing.Size(124, 42);
            this.OK2.TabIndex = 47;
            this.OK2.Text = "OK";
            this.OK2.UseVisualStyleBackColor = false;
            this.OK2.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(373, 321);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 38);
            this.button7.TabIndex = 46;
            this.button7.Text = "OK";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(229, 326);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(138, 32);
            this.numericUpDown1.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "Items";
            // 
            // dgvo
            // 
            this.dgvo.AllowUserToAddRows = false;
            this.dgvo.AllowUserToDeleteRows = false;
            this.dgvo.BackgroundColor = System.Drawing.Color.White;
            this.dgvo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvo.Location = new System.Drawing.Point(12, 53);
            this.dgvo.Name = "dgvo";
            this.dgvo.ReadOnly = true;
            this.dgvo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvo.Size = new System.Drawing.Size(952, 200);
            this.dgvo.TabIndex = 20;
            this.dgvo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvo_CellClick);
            this.dgvo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvo_CellContentClick);
            // 
            // nubo
            // 
            this.nubo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nubo.Location = new System.Drawing.Point(702, 267);
            this.nubo.Name = "nubo";
            this.nubo.Size = new System.Drawing.Size(120, 26);
            this.nubo.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(396, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "Add Item";
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(282, 146);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(405, 38);
            this.tbname.TabIndex = 12;
            this.tbname.Text = "Product Name";
            this.tbname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbdesc
            // 
            this.tbdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdesc.Location = new System.Drawing.Point(282, 198);
            this.tbdesc.Multiline = true;
            this.tbdesc.Name = "tbdesc";
            this.tbdesc.Size = new System.Drawing.Size(405, 38);
            this.tbdesc.TabIndex = 13;
            this.tbdesc.Text = "Product Type";
            this.tbdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newitem
            // 
            this.newitem.BackColor = System.Drawing.Color.White;
            this.newitem.Controls.Add(this.label3);
            this.newitem.Controls.Add(this.nudmin);
            this.newitem.Controls.Add(this.button4);
            this.newitem.Controls.Add(this.tbdesc);
            this.newitem.Controls.Add(this.tbname);
            this.newitem.Controls.Add(this.label2);
            this.newitem.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newitem.Location = new System.Drawing.Point(21, 84);
            this.newitem.Name = "newitem";
            this.newitem.Size = new System.Drawing.Size(1016, 543);
            this.newitem.TabIndex = 53;
            this.newitem.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(369, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 31);
            this.label3.TabIndex = 42;
            this.label3.Text = "Minimum Quantity";
            // 
            // nudmin
            // 
            this.nudmin.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudmin.Location = new System.Drawing.Point(329, 284);
            this.nudmin.Name = "nudmin";
            this.nudmin.Size = new System.Drawing.Size(303, 38);
            this.nudmin.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(375, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 49);
            this.button4.TabIndex = 24;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.triangle_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(770, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 31);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.addd;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(756, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 55);
            this.button8.TabIndex = 57;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // i
            // 
            this.i.BackColor = System.Drawing.Color.Transparent;
            this.i.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.triangle_512;
            this.i.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.i.Location = new System.Drawing.Point(831, 71);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(28, 31);
            this.i.TabIndex = 55;
            this.i.TabStop = false;
            this.i.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.items;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(817, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.rep;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(878, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.triangle_512;
            this.a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a.Location = new System.Drawing.Point(710, 71);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(28, 31);
            this.a.TabIndex = 54;
            this.a.TabStop = false;
            this.a.Visible = false;
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
            this.button1.Location = new System.Drawing.Point(695, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // r
            // 
            this.r.BackColor = System.Drawing.Color.Transparent;
            this.r.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.triangle_512;
            this.r.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.r.Location = new System.Drawing.Point(891, 71);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(28, 31);
            this.r.TabIndex = 56;
            this.r.TabStop = false;
            this.r.Visible = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1070, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inv);
            this.Controls.Add(this.newitem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(27, 84);
            this.MaximizeBox = false;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.inv.ResumeLayout(false);
            this.inv.PerformLayout();
            this.dgvout.ResumeLayout(false);
            this.dgvout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvin)).EndInit();
            this.Sout.ResumeLayout(false);
            this.Sout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubo)).EndInit();
            this.newitem.ResumeLayout(false);
            this.newitem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Panel inv;
        private System.Windows.Forms.DataGridView dgvin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel dgvout;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Sout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbdesc;
        public System.Windows.Forms.Panel newitem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudmin;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox i;
        private System.Windows.Forms.PictureBox a;
        private System.Windows.Forms.PictureBox r;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button OK2;
        private System.Windows.Forms.Button OK1;
        private System.Windows.Forms.NumericUpDown nubo;
        private System.Windows.Forms.NumericUpDown nubi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}