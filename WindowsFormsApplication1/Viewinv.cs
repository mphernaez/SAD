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
    public partial class viewInv : Form
    {
        Inventory inv { get; set; }
        public MySqlConnection conn;
        public viewInv()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewInv_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand com = new MySqlCommand("SELECT productName, description, quantity, minQuantity FROM items", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);


                dgvViewInv.DataSource = dt;

                dgvViewInv.Columns["productName"].HeaderText = "Product Namr";
                dgvViewInv.Columns["description"].HeaderText = "Description";
                dgvViewInv.Columns["quantity"].HeaderText = "Quantity";
                dgvViewInv.Columns["minQuantity"].HeaderText = "Minimum Quantity";
                dgvViewInv.Columns["productName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewInv.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewInv.Columns["quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewInv.Columns["minQuantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
