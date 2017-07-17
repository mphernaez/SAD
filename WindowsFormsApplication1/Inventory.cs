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
            inv.Visible = true;
            selectButton.Visible = true;
            selectButton.Location = new Point(y, 6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inv.Visible = false;
            button1.BackColor = Color.Transparent;
            button2.BackColor = use;
            selectButton.Visible = true;
            selectButton.Location = new Point(y, 76);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.Top = 278;
        }
    }
}
