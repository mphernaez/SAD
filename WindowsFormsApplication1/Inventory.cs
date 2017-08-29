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
        public int itemID;
        public empty back { get; set; }
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
            this.Top = 112; //262
            refreshSI();
            refreshSO();
            dgvo.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvin.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void refreshSI()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT itemID, productName, description, quantity, minQuantity FROM items", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvin.DataSource = dt;

                dgvin.Columns["itemID"].Visible = false;
                dgvin.Columns["productName"].HeaderText = "Product Name";
                dgvin.Columns["description"].HeaderText = "Decription";
                dgvin.Columns["quantity"].HeaderText = "Quantity";
                dgvin.Columns["minQuantity"].HeaderText = "Minimum Quantity";

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }
        private void refreshSO()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT itemID, productName, description, quantity, minQuantity FROM items", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvo.DataSource = dt;

                dgvo.Columns["itemID"].Visible = false;
                dgvo.Columns["productName"].HeaderText = "Product Name";
                dgvo.Columns["description"].HeaderText = "Decription";
                dgvo.Columns["quantity"].HeaderText = "Quantity";
                dgvo.Columns["minQuantity"].HeaderText = "Minimum Quantity";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
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
            dgvout.Visible = true;
            Sout.Visible = false;
            button5.BackColor = Color.FromArgb(2, 170, 145);
            button16.BackColor = Color.FromArgb(251, 162, 80) ;
            refreshSI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvout.Visible = false;
            Sout.Visible = true;
            button16.BackColor = Color.FromArgb(2, 170, 145);
            button5.BackColor = Color.FromArgb(251, 162, 80);
            refreshSO();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("INSERT INTO items VALUES (itemID, '"+ tbname.Text + "', '" + tbdesc.Text + "', 0, "+ nudmin.Value.ToString() + ")" , conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Item Added");
                conn.Close();
                refreshSI();
                refreshSO();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void inv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                MySqlCommand com = new MySqlCommand("SELECT * FROM items WHERE itemID = " + itemID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                int qua = int.Parse(dt.Rows[0]["quantity"].ToString());
                string prod = dt.Rows[0]["productName"].ToString();
                int id = int.Parse(dt.Rows[0]["itemID"].ToString());
                int min = int.Parse(dt.Rows[0]["minQuantity"].ToString());
                if (int.Parse(nubo.Text) < qua)
                {
                    MySqlCommand comm = new MySqlCommand("UPDATE items SET quantity = quantity - '" + nubo.Value.ToString() + "' WHERE itemID = '" + itemID + "'", conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Item Updated");
                }
                else
                {
                    MessageBox.Show("Invalid Value");
                }
                com = new MySqlCommand("SELECT quantity FROM items WHERE itemID = " + itemID, conn);
                adp = new MySqlDataAdapter(com);
                dt = new DataTable();
                adp.Fill(dt);

                int quan = int.Parse(dt.Rows[0]["quantity"].ToString());

                conn.Close();
                refreshSO();
                checkMin(id, min, quan, prod);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void dgvo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemID = int.Parse(dgvo.Rows[e.RowIndex].Cells["itemID"].Value.ToString());
        }

        private void Sout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OK1_Click(object sender, EventArgs e)
        {
            if (itemID != 0)
            {
                try
                {

                    conn.Open();
                    int quan = int.Parse(nubi.Text);

                    if (quan > 0)
                    {
                        MySqlCommand comm = new MySqlCommand("UPDATE items SET quantity = quantity + " + nubi.Value.ToString() + " WHERE itemID = " + itemID, conn);
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Item Updated");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number");
                    }
                    conn.Close();
                    refreshSI();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an item");
            }
        }

        private void dgvin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemID = int.Parse(dgvin.Rows[e.RowIndex].Cells["itemID"].Value.ToString());
           
        }

        private void nubi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkMin(int id, int min, int quan, string prod)
        {
            if (quan < min)
            {
                MessageBox.Show("Item in scarse! Request stocks immediately for: " + prod);
            }
        }
    }
}
