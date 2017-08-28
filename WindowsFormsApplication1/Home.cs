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
    
    public partial class empty : Form
    {
        private Color use;
        public MySqlConnection conn;
        public int adminID;
        public String dispUser;
        public Login log { get; set; }
        Dog dog = new Dog();
        Employee emp = new Employee();
        Inventory inv = new Inventory();
        public empty()
        {
            InitializeComponent();
            use = Color.FromArgb(253, 208, 174);
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dog.Visible)
                dog.trig();
            if (inv.Visible)
                inv.trig();
            emp.back = this;
            ep.BackColor = Color.FromArgb(251, 162, 80);
            ip.BackColor = Color.FromArgb(2, 170, 145);
            dp.BackColor = Color.FromArgb(2, 170, 145);
            hp.BackColor = Color.FromArgb(2, 170, 145);
            emp.adminID = this.adminID;
            emp.Show();
            emp.TopMost = true;

            int i = 453;//360, 5

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dog.Visible)
                dog.trig();
            if (emp.Visible)
                emp.trig();
            inv.back = this;
            inv.adminID = this.adminID;
            inv.Show();
            ip.BackColor = Color.FromArgb(251, 162, 80);
            ep.BackColor = Color.FromArgb(2, 170, 145);
            dp.BackColor = Color.FromArgb(2, 170, 145);
            hp.BackColor = Color.FromArgb(2, 170, 145);
            inv.TopMost = true;

            int i = 541;//360, 5

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emp.Visible)
                emp.trig();
            dog.back = this;
            dog.adminID = this.adminID;
            dog.Show();
            dog.TopMost = true;
            dp.BackColor = Color.FromArgb(251, 162, 80);
            ip.BackColor = Color.FromArgb(2, 170, 145);
            ep.BackColor = Color.FromArgb(2, 170, 145);
            hp.BackColor = Color.FromArgb(2, 170, 145);

            int i = 360;//360, 5

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            pe.BackColor = Color.FromArgb(251, 162, 80);
            int i = 615;


            Login log = new Login();
            log.hom = this;
            log.Show();
            this.Close();
            dog.trig();
            emp.trig();
            inv.trig();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            namelabel.Text = dispUser;
//this.TopMost = true;
            this.Top = 150;
            Timer tmr = new Timer();
            tmr.Interval = 1000;//ticks every 1 second
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
            refreshNotif();
        }

        private void refreshNotif()
        {
            try
            {
               conn.Open();

               MySqlCommand com = new MySqlCommand("SELECT COUNT(*), itemID FROM items WHERE quantity != 0 AND quantity <= minQuantity ", conn);
               MySqlDataAdapter adp = new MySqlDataAdapter(com);
               DataTable dt = new DataTable();
               adp.Fill(dt);
               int warning;
               warning = int.Parse(dt.Rows[0]["COUNT(*)"].ToString());
                MySqlCommand comm = new MySqlCommand("SELECT COUNT(*), itemID FROM items WHERE quantity = 0", conn);
                MySqlDataAdapter adpp = new MySqlDataAdapter(comm);
                DataTable dtt = new DataTable();
                adp.Fill(dtt);
                int empty;
                empty = int.Parse(dtt.Rows[0]["COUNT(*)"].ToString());

                tbwarning.Text = (warning + " Items need your attenion");
                tbempty.Text = (empty + " Items have ran out");
                if(warning > 0)
                {
                    tbwarning.Visible = true;
                }
                if(empty > 0)
                {
                    tbempty.Visible = true;
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");

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
            inv.trig();
            int i = 261;
            hp.BackColor = Color.FromArgb(251, 162, 80);
            ip.BackColor = Color.FromArgb(2, 170, 145);
            ep.BackColor = Color.FromArgb(2, 170, 145);
            dp.BackColor = Color.FromArgb(2, 170, 145);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            warningPanel.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            emptyPanel.Visible = false;
        }
    }
}
