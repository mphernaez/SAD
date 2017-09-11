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
        public Point mouseLocation;
        public Dog dog;
        public Employee emp;
        public Inventory inv;
        public empty()
        {
            InitializeComponent();
            use = Color.FromArgb(253, 208, 174);
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if(dog.Visible)
                dog.trig();
            if (inv.Visible)
                inv.trig();
            emp.back = this;
            ep.BackColor = Color.FromArgb(251, 162, 80);
            ip.BackColor = Color.FromArgb(2, 170, 145);
            dp.BackColor = Color.FromArgb(2, 170, 145);
            hp.BackColor = Color.FromArgb(2, 170, 145);
            emp.adminID = this.adminID;
            emp.Location = new Point(this.Location.X, this.Location.Y + 112);
            emp.Show();
            */

            //int i = 453;//360, 5
            openEmp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* if (dog.Visible)
                 dog.trig();
             if (emp.Visible)
                 emp.trig();
             inv.back = this;
             inv.Location = new Point(this.Location.X, this.Location.Y + 112);
             inv.adminID = this.adminID;
             inv.Show();
             ip.BackColor = Color.FromArgb(251, 162, 80);
             ep.BackColor = Color.FromArgb(2, 170, 145);
             dp.BackColor = Color.FromArgb(2, 170, 145);
             hp.BackColor = Color.FromArgb(2, 170, 145);

             */
            //int i = 541;//360, 5
            openInv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* (emp.Visible)
                emp.trig();
            dog.back = this;
            dog.adminID = this.adminID;
            dog.Show();
            dog.Location = new Point(this.Location.X, this.Location.Y + 112);
            dp.BackColor = Color.FromArgb(251, 162, 80);
            ip.BackColor = Color.FromArgb(2, 170, 145);
            ep.BackColor = Color.FromArgb(2, 170, 145);
            hp.BackColor = Color.FromArgb(2, 170, 145);

            //int i = 360;//360, 5
            */
            openDog();

        }

        public void openDog()
        {
            if (odog == false)
            {
                dog = new Dog(this);
                odog = true;
            }
            dog.back = this;
            dog.adminID = this.adminID;
            dog.Show();
            this.Hide();
        }
        public void openEmp()
        {
            if (oemp == false)
            {
                emp = new Employee(this);
                oemp = true;
            }
            emp.back = this;
            emp.adminID = this.adminID;
            emp.Show();
            this.Hide();
        }

        public void openInv()
        {
            if (oinv == false)
            {
                inv = new Inventory(this);
                oinv = true;
            }
            inv.back = this;
            inv.adminID = this.adminID;
            inv.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            /*button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            pe.BackColor = Color.FromArgb(251, 162, 80);
            //int i = 615;
            */

            Login log = new Login();
            log.hom = this;
            log.Show();
            this.Close();
            dog.trig();
            emp.trig();
            inv.trig();
            
        }
        bool odog, oinv, oemp = false;
        private void Home_Load(object sender, EventArgs e)
        {
            namelabel.Text = dispUser;
            //this.TopMost = true;
            //this.Top = 0; // 150
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

               MySqlCommand com = new MySqlCommand("SELECT COUNT(*) FROM items WHERE quantity != 0 AND quantity <= minQuantity ", conn);
               MySqlDataAdapter adp = new MySqlDataAdapter(com);
               DataTable dt = new DataTable();
               adp.Fill(dt);
               int warning;
               warning = int.Parse(dt.Rows[0]["COUNT(*)"].ToString());

                MySqlCommand comm = new MySqlCommand("SELECT COUNT(*) FROM items WHERE quantity = 0", conn);
                MySqlDataAdapter adpp = new MySqlDataAdapter(comm);
                DataTable dtt = new DataTable();
                adpp.Fill(dtt);
                int empty;
                empty = int.Parse(dtt.Rows[0]["COUNT(*)"].ToString());
                tbwarning.Text = (warning + " Item/s need your attenion");
                tbempty.Text = (empty + " Item/s have ran out");
                if(warning > 0)
                {
                    warningPanel.Visible = true;
                }
                if(empty > 0)
                {
                    emptyPanel.Visible = true;
                }
                if (warning == 0)
                {
                    warningPanel.Visible = false;
                }
                if (empty == 0)
                {
                    emptyPanel.Visible = false;
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
        
        private void button5_Click(object sender, EventArgs e)
        {
            dog.trig();
            emp.trig();
            inv.trig();
            //int i = 261;
            hp.BackColor = Color.FromArgb(251, 162, 80);
            ip.BackColor = Color.FromArgb(2, 170, 145);
            ep.BackColor = Color.FromArgb(2, 170, 145);
            dp.BackColor = Color.FromArgb(2, 170, 145);
            refreshNotif();


        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            warningPanel.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            emptyPanel.Visible = false;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            warningPanel.Visible = false;
        }

        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
                Point mousePoss = Control.MousePosition;
                mousePoss.Offset(mouseLocation.X, mouseLocation.Y+112);
                dog.Location = mousePoss;
                emp.Location = mousePoss;
                inv.Location = mousePoss;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void empty_Activated(object sender, EventArgs e)
        {
            BringToFront();
        }
    }
}
