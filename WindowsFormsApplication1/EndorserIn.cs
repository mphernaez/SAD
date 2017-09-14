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

                    conn.Open();
                    if (eID != 0)
                    {
                        String expiration = tbYr.Text + "-" + (cbMo.SelectedIndex + 1).ToString() + "-" + cbDa.Text + "-";
                        String date = tbYear.Text + "-" + (cbMonth.SelectedIndex + 1).ToString() + "-" + cbDay.Text + "-";
                        MySqlCommand comm = new MySqlCommand("UPDATE items SET quantity = quantity + " + int.Parse(amtIn.Text) + " WHERE itemID = " + id, conn);
                        comm.ExecuteNonQuery();
                        MySqlCommand com = new MySqlCommand("INSERT INTO stocktransaction VALUES( transactionID, " + id + ", " + int.Parse(amtIn.Text) + ", '" + date + "', 'In', " + eID + ", '" + tbReason.Text + "', '" + expiration + "', "+rq+")", conn);
                        com.ExecuteNonQuery();
                        this.Hide();
                        comm = new MySqlCommand("UPDATE stockrequest SET delivered = 1 WHERE stockID = " + id, conn);
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Item Updated");
                        inv.refreshSI();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter an Employee");
                    }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter required fields");
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
    }
}
