namespace WindowsFormsApplication1
{
    partial class EditItem
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
            this.tbdesc = new System.Windows.Forms.TextBox();
            this.msBy = new System.Windows.Forms.ComboBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.nudmin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbdesc
            // 
            this.tbdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdesc.Location = new System.Drawing.Point(41, 164);
            this.tbdesc.Multiline = true;
            this.tbdesc.Name = "tbdesc";
            this.tbdesc.Size = new System.Drawing.Size(377, 66);
            this.tbdesc.TabIndex = 45;
            this.tbdesc.Text = "Product Type";
            // 
            // msBy
            // 
            this.msBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msBy.FormattingEnabled = true;
            this.msBy.Items.AddRange(new object[] {
            "Item",
            "Sack",
            "Piece",
            "Dozen",
            "Bottle"});
            this.msBy.Location = new System.Drawing.Point(41, 296);
            this.msBy.Name = "msBy";
            this.msBy.Size = new System.Drawing.Size(121, 28);
            this.msBy.TabIndex = 49;
            this.msBy.Text = "Measured by";
            this.msBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msBy_KeyPress);
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(41, 132);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(230, 26);
            this.tbname.TabIndex = 44;
            this.tbname.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(41, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Minimum Quantity";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(136, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 42);
            this.button4.TabIndex = 46;
            this.button4.Text = "Save Changes";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nudmin
            // 
            this.nudmin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudmin.Location = new System.Drawing.Point(41, 256);
            this.nudmin.Name = "nudmin";
            this.nudmin.Size = new System.Drawing.Size(150, 26);
            this.nudmin.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(158, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 50;
            this.label2.Text = "Edit Item";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancel_music;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(426, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(462, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbdesc);
            this.Controls.Add(this.msBy);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.nudmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbdesc;
        private System.Windows.Forms.ComboBox msBy;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown nudmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}