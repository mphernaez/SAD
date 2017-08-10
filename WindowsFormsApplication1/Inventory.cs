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
    public partial class Inventory : Form
    {
        private int y;
        private Color use;
        public MySqlConnection conn = new MySqlConnection();
        public int adminID;
        public Home back { get; set; }
        public Inventory()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
            y = -40;
            use = Color.FromArgb(253, 208, 174);
        }
        public void trig()
        {
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a.Visible = true;
            i.Visible = false;
            r.Visible = false;
            newitem.Visible = true;
            inv.Visible = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.Visible = false;
            i.Visible = false;
            r.Visible = true;
            inv.Visible = false;
            newitem.Visible = false;

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.Top = 262;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.Visible = false;
            i.Visible = true;
            r.Visible = false;
            inv.Visible = true;
            newitem.Visible = false;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Sin.Visible = true;
            Sout.Visible = false;
            button5.BackColor = Color.FromArgb(2, 170, 145);
            button16.BackColor = Color.FromArgb(251, 162, 80) ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sin.Visible = false;
            Sout.Visible = true;
            button16.BackColor = Color.FromArgb(2, 170, 145);
            button5.BackColor = Color.FromArgb(251, 162, 80);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void inv_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
