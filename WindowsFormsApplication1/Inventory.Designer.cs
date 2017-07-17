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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.inv = new System.Windows.Forms.Panel();
            this.dgvAdoption = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectButton)).BeginInit();
            this.inv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdoption)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(148)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.selectButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 510);
            this.panel1.TabIndex = 48;
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
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.items;
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
            this.selectButton.Location = new System.Drawing.Point(-57, 76);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(141, 70);
            this.selectButton.TabIndex = 2;
            this.selectButton.TabStop = false;
            this.selectButton.Visible = false;
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
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(29, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 39);
            this.label12.TabIndex = 11;
            this.label12.Text = "Inventory";
            // 
            // inv
            // 
            this.inv.Controls.Add(this.dgvAdoption);
            this.inv.Controls.Add(this.label12);
            this.inv.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv.Location = new System.Drawing.Point(97, 5);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(607, 380);
            this.inv.TabIndex = 52;
            this.inv.Visible = false;
            // 
            // dgvAdoption
            // 
            this.dgvAdoption.AllowUserToAddRows = false;
            this.dgvAdoption.AllowUserToDeleteRows = false;
            this.dgvAdoption.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvAdoption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdoption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdoption.Location = new System.Drawing.Point(27, 66);
            this.dgvAdoption.Name = "dgvAdoption";
            this.dgvAdoption.ReadOnly = true;
            this.dgvAdoption.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdoption.Size = new System.Drawing.Size(558, 291);
            this.dgvAdoption.TabIndex = 20;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(208)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(738, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectButton)).EndInit();
            this.inv.ResumeLayout(false);
            this.inv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdoption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox selectButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Panel inv;
        private System.Windows.Forms.DataGridView dgvAdoption;
    }
}