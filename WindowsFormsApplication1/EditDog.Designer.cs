namespace WindowsFormsApplication1
{
    partial class EditDog
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbBreed = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbSub = new System.Windows.Forms.TextBox();
            this.tbMarkings = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(175, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 53;
            this.label1.Text = "Edit Dog";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancel_music;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(456, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbBreed
            // 
            this.cbBreed.DropDownHeight = 100;
            this.cbBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBreed.ForeColor = System.Drawing.Color.Gray;
            this.cbBreed.FormattingEnabled = true;
            this.cbBreed.IntegralHeight = false;
            this.cbBreed.Items.AddRange(new object[] {
            "Affenpinscher",
            "Akita",
            "Australian",
            "Azawakh",
            "Basenji",
            "Beagle",
            "Beauceron",
            "Bergamasco",
            "Bichon Frise",
            "Bloodhound",
            "Bolognese",
            "Borzoi",
            "Bouvier des Flandres",
            "Boxer",
            "Briard",
            "Brittany",
            "Bulldog",
            "Bullmastiff",
            "Cattle Dog",
            "Chihuahua",
            "Chin",
            "Chinook",
            "Chow Chow",
            "Collie",
            "Coonhound",
            "Corgi",
            "Coton De Tulear",
            "Crested",
            "Dachshund",
            "Dalmatian",
            "Dingo",
            "Elkhound",
            "Eskimo Dog",
            "Field Spaniel",
            "Foxhound",
            "German Shepherd",
            "Giant Schnauzer",
            "Golden Retriever",
            "Gordon Setter",
            "Great Dane",
            "Great Pyrenees",
            "Greyhound",
            "Griffon",
            "Harrier",
            "Havanese",
            "Hokkaido",
            "Hound",
            "Husky",
            "Japanese Spitz",
            "Keeshond",
            "Klee Kai",
            "Komondor",
            "Kuvasz",
            "Labrador",
            "Labradoodle",
            "Heeler",
            "Leonberger",
            "Leopard Dog",
            "Lhasa Apso",
            "Lowchen",
            "Lundehund",
            "Malamute",
            "Malinois",
            "Maltese",
            "Mastiff",
            "Miniature Schnauzer",
            "Mongrel",
            "Mountain Dog",
            "Newfoundland",
            "Otterhound",
            "Papillon",
            "Pekingese",
            "Pinscher",
            "Pit Bull",
            "Plott",
            "Pointer",
            "Pomeranian",
            "Poodle",
            "Pug",
            "Puli",
            "Ridgeback",
            "Rottweiler",
            "Saint Bernard",
            "Saluki",
            "Samoyed",
            "Setter",
            "Shar-Pei",
            "Sheepdog",
            "Shiba Inu",
            "Shih Tzu",
            "Sloughi",
            "Springer Spaniel",
            "Terrier",
            "Tervuren",
            "Toy Spaniel",
            "Vallhund",
            "Vizsla",
            "Water Dog",
            "Water Spaniel",
            "Weimaraner",
            "Whippet",
            "Xoloitzcuintli (Xolo)",
            "Yorkshire",
            "UNIDENTIFIED"});
            this.cbBreed.Location = new System.Drawing.Point(154, 160);
            this.cbBreed.Name = "cbBreed";
            this.cbBreed.Size = new System.Drawing.Size(245, 28);
            this.cbBreed.TabIndex = 113;
            this.cbBreed.TabStop = false;
            // 
            // cbGender
            // 
            this.cbGender.DropDownHeight = 100;
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.ForeColor = System.Drawing.Color.Gray;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.IntegralHeight = false;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(154, 84);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(245, 28);
            this.cbGender.TabIndex = 111;
            // 
            // cbSize
            // 
            this.cbSize.DropDownHeight = 100;
            this.cbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.ForeColor = System.Drawing.Color.Gray;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.IntegralHeight = false;
            this.cbSize.Items.AddRange(new object[] {
            "Extra Small (less than 1ft)",
            "Small (1ft)",
            "Large (2ft)",
            "Extra Large (more than 2ft)"});
            this.cbSize.Location = new System.Drawing.Point(154, 122);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(245, 28);
            this.cbSize.TabIndex = 112;
            this.cbSize.TabStop = false;
            // 
            // tbColor
            // 
            this.tbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbColor.ForeColor = System.Drawing.Color.Gray;
            this.tbColor.Location = new System.Drawing.Point(154, 198);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(245, 26);
            this.tbColor.TabIndex = 114;
            // 
            // tbSub
            // 
            this.tbSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSub.ForeColor = System.Drawing.Color.Gray;
            this.tbSub.Location = new System.Drawing.Point(154, 235);
            this.tbSub.Name = "tbSub";
            this.tbSub.Size = new System.Drawing.Size(245, 26);
            this.tbSub.TabIndex = 115;
            // 
            // tbMarkings
            // 
            this.tbMarkings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarkings.ForeColor = System.Drawing.Color.Gray;
            this.tbMarkings.Location = new System.Drawing.Point(154, 273);
            this.tbMarkings.Multiline = true;
            this.tbMarkings.Name = "tbMarkings";
            this.tbMarkings.Size = new System.Drawing.Size(245, 81);
            this.tbMarkings.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(87, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 117;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(110, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 118;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(98, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "Breed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(104, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 120;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(57, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 121;
            this.label6.Text = "Sublocation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(77, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 122;
            this.label7.Text = "Markings";
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(150)))), ((int)(((byte)(128)))));
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(154, 379);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(171, 38);
            this.button19.TabIndex = 123;
            this.button19.Text = "Save";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // EditDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 441);
            this.ControlBox = false;
            this.Controls.Add(this.button19);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMarkings);
            this.Controls.Add(this.tbSub);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.cbBreed);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "EditDog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditDog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbBreed;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbSub;
        private System.Windows.Forms.TextBox tbMarkings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button19;
    }
}