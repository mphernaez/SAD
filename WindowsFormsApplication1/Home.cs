using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    
    public partial class Home : Form
    {
        private Color use;
        public MySqlConnection conn;
        public int adminID;
        public String dispUser;
        public Login log { get; set; }
        Dog dog = new Dog();
        public Home()
        {
            InitializeComponent();
            use = Color.FromArgb(253, 208, 174);
            conn = new MySqlConnection("Server=localhost;Database=impounddogpound;Uid=root;Pwd=root;");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dog.back = this;
            dog.adminID = this.adminID;
            dog.Show();
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button1.BackColor = use;
            selectButton.Visible = true;
            int i = 300;
            selectButton.Location = new Point(i, 10);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;

            selectButton.Visible = true;
            button4.BackColor = use;
            int i = 615;
            selectButton.Location = new Point(i, 10);

            Login log = new Login();
            log.hom = this;
            log.Show();
            this.Close();
            dog.trig();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            namelabel.Text = dispUser;
            this.Top = 150;
        }
    }
}
