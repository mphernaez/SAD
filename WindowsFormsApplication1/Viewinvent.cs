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
  
    public partial class Viewinvent : Form
    {
        Employee emp { get; set; }
        public MySqlConnection conn;
        public Viewinvent()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand com = new MySqlCommand("SELECT productName, description, quantity, minQuantity FROM items", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);


                dgvViewAct.DataSource = dt;

                dgvViewAct.Columns["productName"].HeaderText = "Product Name";
                dgvViewAct.Columns["description"].HeaderText = "Description";
                dgvViewAct.Columns["quantity"].HeaderText = "Quantity";
                dgvViewAct.Columns["minQuantity"].HeaderText = "Minimum Quantity";
                dgvViewAct.Columns["productName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewAct.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewAct.Columns["quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewAct.Columns["minQuantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }
    }
}
