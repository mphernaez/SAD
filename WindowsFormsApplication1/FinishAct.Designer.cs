namespace WindowsFormsApplication1
{
    partial class FinishAct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishAct));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.lblMesBy = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.button38 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancel_music;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.label1.Name = "label1";
            // 
            // cbItems
            // 
            resources.ApplyResources(this.cbItems, "cbItems");
            this.cbItems.ForeColor = System.Drawing.Color.Black;
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Name = "cbItems";
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // lblMesBy
            // 
            resources.ApplyResources(this.lblMesBy, "lblMesBy");
            this.lblMesBy.BackColor = System.Drawing.Color.Transparent;
            this.lblMesBy.ForeColor = System.Drawing.Color.Black;
            this.lblMesBy.Name = "lblMesBy";
            // 
            // num
            // 
            resources.ApplyResources(this.num, "num");
            this.num.Name = "num";
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(145)))));
            resources.ApplyResources(this.button38, "button38");
            this.button38.FlatAppearance.BorderSize = 0;
            this.button38.ForeColor = System.Drawing.Color.White;
            this.button38.Name = "button38";
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // FinishAct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ControlBox = false;
            this.Controls.Add(this.button38);
            this.Controls.Add(this.num);
            this.Controls.Add(this.lblMesBy);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FinishAct";
            this.Load += new System.EventHandler(this.FinishAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMesBy;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.ComboBox cbItems;
    }
}