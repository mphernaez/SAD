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
        public string rq;
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
            tbYear.Text = DateTime.Now.ToString("yyyy");
            tbYr.Text = DateTime.Now.ToString("yyyy");
            cbMonth.SelectedIndex = int.Parse(DateTime.Now.ToString("MM")) - 1;
            cbDay.SelectedIndex = int.Parse(DateTime.Now.ToString("dd")) - 1;
            refreshEnd();
            dgvEnd.ClearSelection();

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

                comm = new MySqlCommand("SELECT measuredBy FROM items WHERE itemID = " + id, conn);
                adp = new MySqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);

                amtLabel.Text = "Amount by " + dt.Rows[0]["measuredBy"].ToString();

                

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
            if (amtIn.Value != 0)
            {
                try
                {
                    if (eID != 0)
                    {
                        conn.Open();
                        String expiration = tbYr.Text + "-" + (cbMo.SelectedIndex + 1).ToString() + "-" + cbDa.Text + "-";
                        String date = tbYear.Text + "-" + (cbMonth.SelectedIndex + 1).ToString() + "-" + cbDay.Text + "-";
                        MySqlCommand comm = new MySqlCommand("UPDATE items SET quantity = quantity + " + int.Parse(amtIn.Text) + " WHERE itemID = " + id, conn);
                        comm.ExecuteNonQuery();
                        MySqlCommand com = new MySqlCommand("INSERT INTO stocktransaction VALUES( transactionID, " + id + ", " + int.Parse(amtIn.Text) + ", '" + date + "', 'In', " + eID + ", '" + tbReason.Text + "', '" + expiration + "', "+rq+" )", conn);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Item Updated");
                        this.Hide();
                        comm = new MySqlCommand("UPDATE stockrequest SET delivered = 1 WHERE stockID = " + id, conn);
                        comm.ExecuteNonQuery();
                        
                        conn.Close();
                        inv.refreshSI();
                        
                        tbYear.Text = DateTime.Now.ToString("yyyy");
                        cbMonth.Text = "Month";
                        cbDay.Text = "Day";
                        cbDay.Items.Clear();
                        tbReason.Text = "";
                        tbYr.Text = DateTime.Now.ToString("yyyy");
                        cbMo.Text = "Month";
                        cbDa.Text = "Day";
                        cbDa.Items.Clear();
                        amtIn.Value = 0;
                        amtLabel.Text = "Amount";
                    }
                    else
                    {
                        MessageBox.Show("Please Enter an Employee");
                    }
                    

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

        int eID;
        
        private void dgvEnd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                eID = int.Parse(dgvEnd.Rows[e.RowIndex].Cells["employeeID"].Value.ToString());
            }
        }

        private void tbYr_TextChanged(object sender, EventArgs e)
        {
            if (tbYr.Text.Length == 4) cbMo.Enabled = true;
        }

        private void responsiveDay(int year)
        {
            int x;
            if (cbMo.Text == "January" || cbMo.Text == "March" || cbMo.Text == "May" || cbMo.Text == "July" || cbMo.Text == "August" || cbMo.Text == "October" || cbMo.Text == "December") { loopDayExp(31); }
            else if (cbMo.Text == "February"){ if (year % 4 == 0) loopDayExp(29); else loopDayExp(28); }
            else { loopDayExp(30); }
        }

        private void loopDayExp(int x)
        {
            int i = 1;
            while (i <= x)
            {
                cbDa.Items.Add(i.ToString());
                i++;
            }
        }

        private void cbMo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDa.Enabled = true;
            cbDa.Items.Clear();
            responsiveDay(int.Parse(tbYr.Text));
        }

        private void tbYr_Enter(object sender, EventArgs e)
        {
            tbYr.Text = "";
        }

        private void tbYear_Enter(object sender, EventArgs e)
        {
            tbYear.Text = "";
        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
            if (tbYear.Text.Length == 4) cbMonth.Enabled = true;
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDay.Enabled = true;
            cbDay.Items.Clear();
            responsiveDel(int.Parse(tbYear.Text));
        }
        private void loopDayDel(int x)
        {
            int i = 1;
            while (i <= x)
            {
                cbDay.Items.Add(i.ToString());
                i++;
            }
        }

        private void responsiveDel(int year)
        {
            if (cbMonth.Text == "January" || cbMonth.Text == "March" || cbMonth.Text == "May" || cbMonth.Text == "July" || cbMonth.Text == "August" || cbMonth.Text == "October" || cbMonth.Text == "December") { loopDayDel(31); }
            else if (cbMonth.Text == "February") { if (year % 4 == 0) loopDayDel(29); else loopDayDel(28); }
            else { loopDayDel(30); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbYr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EndorserIn_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
