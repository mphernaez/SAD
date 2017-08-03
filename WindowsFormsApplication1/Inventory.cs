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
            button1.BackColor = use;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            newitem.Visible = true;
            inv.Visible = false;
            
            selectButton.Visible = true;
            selectButton.Location = new Point(y, 6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inv.Visible = false;
            button1.BackColor = Color.Transparent;
            button2.BackColor = use;
            button3.BackColor = Color.Transparent;
            selectButton.Visible = true;
            newitem.Visible = false;
            selectButton.Location = new Point(y, 145);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.Top = 278;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button3.BackColor = use;
            button2.BackColor = Color.Transparent;
            inv.Visible = true;
            newitem.Visible = false;
            selectButton.Visible = true;
            selectButton.Location = new Point(y, 76);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Sin.Visible = true;
            Sout.Visible = false;
            button5.BackColor = Color.FromArgb(240, 148, 80);
            button16.BackColor = use;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sin.Visible = false;
            Sout.Visible = true;
            button16.BackColor = Color.FromArgb(240, 148, 80);
            button5.BackColor = use;
        }
    }
}
