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
    public partial class EndorserOut : Form
    {
        MySqlConnection conn = new MySqlConnection();
        int eID = 0;
        public int value;
        public int id;
        Inventory inv { get; set; }
        public EndorserOut(Inventory parent)
        {
            InitializeComponent();
            inv = parent;
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
        }

        private void OK1_Click(object sender, EventArgs e)
        {
            if (amtOut.Value != 0)
            {
                try
                {
                    conn.Open();
                    MySqlCommand co = new MySqlCommand("SELECT quantity FROM items WHERE itemID = " + id, conn);
                    MySqlDataAdapter a = new MySqlDataAdapter(co);
                    DataTable d = new DataTable();
                    a.Fill(d);
                    if (int.Parse(d.Rows[0]["quantity"].ToString()) - int.Parse(amtOut.Text) >= 0)
                    {
                        if (eID != 0)
                        {
                            String date = DateTime.Now.ToString("yyyy-MM-dd");
                            MySqlCommand comm = new MySqlCommand("UPDATE items SET quantity = quantity - " + int.Parse(amtOut.Text) + " WHERE itemID = " + id, conn);
                            comm.ExecuteNonQuery();
                            MySqlCommand com = new MySqlCommand("INSERT INTO stocktransaction(stockID, quantity, date, type, employeeID, reason) VALUES(" + id + ", " + int.Parse(amtOut.Text) + ", '" + date + "', 'Out', " + eID + ", '" + tbReason.Text + "')", conn);
                            com.ExecuteNonQuery();
                            MessageBox.Show("Item Updated");
                            this.Hide();
                            inv.refreshSO();
                            
                            tbReason.Text = "";
                            amtOut.Value = 0;
                            label3.Text = "Amount";
                        }
                        else
                        {
                            conn.Close();
                            MessageBox.Show("Please Enter an Employee");
                        }
                    } else
                    {
                        MessageBox.Show("Please enter valid value to stockout");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid Amount");
            }
        }
        public void refreshEnd()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT employeeID, firstname, lastname FROM employee join profile on employeeID = personID WHERE status = 'Active'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvEnd.DataSource = dt;

                dgvEnd.Columns["employeeID"].Visible = false;
                dgvEnd.Columns["firstname"].HeaderText = "Firstname";
                dgvEnd.Columns["lastname"].HeaderText = "Lastname";
                dgvEnd.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEnd.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEnd.ClearSelection();

                comm = new MySqlCommand("SELECT measuredBy FROM items WHERE itemID = " + id, conn);
                adp = new MySqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);

                label3.Text = "Amount by " + dt.Rows[0]["measuredBy"].ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvEnd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                eID = int.Parse(dgvEnd.Rows[e.RowIndex].Cells["employeeID"].Value.ToString());
            }
        }

        private void EndorserOut_Load(object sender, EventArgs e)
        {
            refreshEnd();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EndorserOut_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
