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
        Employee emp = new Employee();
        public Home()
        {
            InitializeComponent();
            use = Color.FromArgb(253, 208, 174);
            conn = new MySqlConnection("Server=localhost;Database=impounddogpound;Uid=root;Pwd=root;");
            label2.Text = DateTime.Now.ToString("HH:mm tt");
            label3.Text = DateTime.Now.ToString("MMMM d, yyyy");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dog.Visible)
                dog.trig();
            emp.back = this;
            emp.adminID = this.adminID;
            emp.Show();
            button2.BackColor = use;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            selectButton.Visible = true;
            int i = 453;//360, 5
            selectButton.Location = new Point(i, 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emp.Visible)
                emp.trig();
            dog.back = this;
            dog.adminID = this.adminID;
            dog.Show();
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button1.BackColor = use;
            selectButton.Visible = true;
            int i = 360;//360, 5
            selectButton.Location = new Point(i, 5);
            
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
            emp.trig();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            namelabel.Text = dispUser;
            this.Top = 150;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dog.trig();
            emp.trig();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
