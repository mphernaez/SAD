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
    public partial class EndorserIn : Form
    {

        public int id;
        public int value;
        Inventory inv { get; set; }
        MySqlConnection conn = new MySqlConnection();
        public EndorserIn(Inventory parent)
        {
            InitializeComponent();
            inv = parent;
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshEnd();
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


                conn.Close();
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void OK1_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                if (eID != 0)
                {
                    String date = tbYear.Text + "-" + (cbMonth.SelectedIndex + 1).ToString() + "-" + cbDay.Text + "-";
                    MySqlCommand comm = new MySqlCommand("UPDATE items SET quantity = quantity + " + value + " WHERE itemID = " + id, conn);
                    comm.ExecuteNonQuery();
                    MySqlCommand com = new MySqlCommand("INSERT INTO stocktransaction VALUES( transactionID, " + id + ", " + value + ", '" + date + "', 'In', " + eID + ", '"+tbReason.Text+"')", conn);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Item Updated");
                    inv.refreshSI();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Please Enter an Employee");
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        int eID;

        private void dgvEnd_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvEnd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvEnd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvEnd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eID = int.Parse(dgvEnd.Rows[e.RowIndex].Cells["employeeID"].Value.ToString());
        }
    }
}
