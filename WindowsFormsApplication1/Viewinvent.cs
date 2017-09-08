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
                int i = 0;
                while (i < dgvViewAct.RowCount)
                {
                    if (dgvViewAct.Rows[i].Cells["quantity"].Value.ToString() == "0")
                    {
                        
                        dgvViewAct.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(244, 156, 156);
                    }
                    else if (int.Parse(dgvViewAct.Rows[i].Cells["quantity"].Value.ToString()) <= int.Parse(dgvViewAct.Rows[i].Cells["minQuantity"].Value.ToString()))
                    {
                        dgvViewAct.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 140);
                    }
                    i++;
                }
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
