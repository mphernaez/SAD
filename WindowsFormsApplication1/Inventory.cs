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
        public int itemID = 0;
        EndorserIn end { get; set; }
        public empty back { get; set; }
        EndorserOut endO { get; set; }
        empty home;
        int[] retprod;
        int[] retemp;
        public Inventory(empty parent)
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
            y = -40;
            use = Color.FromArgb(253, 208, 174);
            home = parent;
            end = new EndorserIn(this);
            endO = new EndorserOut(this);
        }
        public void trig()
        {
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            panelTrans.Visible = false;
            a.Visible = true;
            i.Visible = false;
            r.Visible = false;
            newitem.Visible = true;
            inv.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            panelTrans.Visible = false;
            a.Visible = false;
            i.Visible = false;
            r.Visible = false;
            panelTrans.Visible = true;
            inv.Visible = false;
            newitem.Visible = false;

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            //this.Top = 112; //262
            refreshSI();
            refreshSO();
            dgvo.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvin.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
        }

        public void refreshSI()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM items", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvin.DataSource = dt;

                dgvin.Columns["itemID"].Visible = false;
                dgvin.Columns["productName"].HeaderText = "Product Name";
                dgvin.Columns["description"].HeaderText = "Description";
                dgvin.Columns["quantity"].HeaderText = "Quantity";
                dgvin.Columns["minQuantity"].HeaderText = "Minimum Quantity";
                dgvin.Columns["measuredBy"].HeaderText = "Measured By";
                dgvin.Columns["productName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvin.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvin.Columns["quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvin.Columns["minQuantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvin.Columns["measuredBy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvin.ClearSelection();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }


        public void refreshSO()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM items", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvo.DataSource = dt;

                dgvo.Columns["itemID"].Visible = false;
                dgvo.Columns["productName"].HeaderText = "Product Name";
                dgvo.Columns["description"].HeaderText = "Description";
                dgvo.Columns["quantity"].HeaderText = "Quantity";
                dgvo.Columns["minQuantity"].HeaderText = "Minimum Quantity";
                dgvo.Columns["measuredBy"].HeaderText = "Measured By";
                dgvo.Columns["productName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvo.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvo.Columns["quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvo.Columns["minQuantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvo.Columns["measuredBy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvo.ClearSelection();

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
            pictureBox1.Visible = false;
            panelTrans.Visible = false;
            a.Visible = false;
            i.Visible = true;
            r.Visible = false;
            inv.Visible = true;
            newitem.Visible = false;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            panelReturn.Visible = false;
            dgvout.Visible = true;
            Sout.Visible = false;
            button5.BackColor = Color.FromArgb(2, 170, 145);
            button16.BackColor = Color.FromArgb(251, 162, 80);
            refreshSI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelReturn.Visible = false;
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
                if (tbname.Text != "Product Name" && tbdesc.Text != "Product Type" && msBy.Text != "Measured by")
                {

                    MySqlCommand comm = new MySqlCommand("INSERT INTO items VALUES (itemID, '" + tbname.Text + "', '" + tbdesc.Text + "', 0, " + nudmin.Value.ToString() + ", '')", conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Item Added");
                    refreshCreate();

                }
                else
                {
                    MessageBox.Show("Please Enter Required Fields");
                }
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
        private void refreshCreate()
        {
            tbname.Text = "Product Name";
            tbdesc.Text = "Product Type";
            nudmin.Value = 0;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            endO.id = itemID;
            endO.Show();
        }

        private void dgvo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                itemID = int.Parse(dgvo.Rows[e.RowIndex].Cells["itemID"].Value.ToString());
            }
        }

        private void OK1_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();

                MySqlCommand com = new MySqlCommand("SELECT COUNT(*), requestID FROM stockrequest WHERE delivered = 0 AND stockID = " + itemID, conn);
                MySqlDataAdapter adpp = new MySqlDataAdapter(com);
                DataTable dtt = new DataTable();
                adpp.Fill(dtt);

                if (int.Parse(dtt.Rows[0]["COUNT(*)"].ToString()) >= 1)
                {
                    end.id = itemID;
                    end.Show();
                    end.rq = dtt.Rows[0]["requestID"].ToString();
                    MySqlCommand comm = new MySqlCommand("SELECT measuredBy FROM items WHERE itemID = " + itemID.ToString(), conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    end.amtLabel.Text = "Amount by " + dt.Rows[0]["measuredBy"].ToString();
                   
                } else
                {
                    MessageBox.Show("No Prior Stock Request Found");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void dgvin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.RowIndex < 0)
                {

                }
                else
                {
                    itemID = int.Parse(dgvin.Rows[e.RowIndex].Cells["itemID"].Value.ToString());
                }
            }

        }
        private void checkMin(int id, int min, int quan, string prod)
        {
            if (quan < min)
            {
                MessageBox.Show("Item in scarse! Request stocks immediately for: " + prod);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Viewinvent inv = new Viewinvent();
            inv.Show();
            inv.TopMost = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            home.openDog();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            home.openEmp();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
            home.refreshNotif();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.hom = home;
            log.Show();
            this.trig();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }

        bool hasExp = true;
        private void button14_Click(object sender, EventArgs e)
        {
            if (hasExp == true) hasExp = false;
            else hasExp = true;
        }

        private void cbTransType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransType.SelectedIndex == 0)
            {
                refreshTransIn();
            }
            else if (cbTransType.SelectedIndex == 1)
            {
                refreshTransOut();
            }
            else if (cbTransType.SelectedIndex == 2)
            {
                refreshReturns();
            }
        }
        private void refreshReturns()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT CONCAT(productName, '-', description) AS Product, stocktransaction.quantity AS 'Quantity', date AS 'Date', CONCAT(lastname, ' ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS 'Endorsed by', reason AS 'Reason of Returning' FROM dogpound.stocktransaction INNER JOIN profile ON stocktransaction.employeeID = profile.personID INNER JOIN items ON stocktransaction.stockID = items.itemID WHERE type = 'Return'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                System.Data.DataTable dt = new System.Data.DataTable();
                adp.Fill(dt);

                dgvTrans.DataSource = dt;
                dgvTrans.Columns["Product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Endorsed by"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Reason of Returning"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }
        private void refreshTransIn()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT CONCAT(productName, '-', description) AS Product, stocktransaction.quantity AS 'Quantity Added', date AS 'Date', CONCAT(lastname, ' ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS 'Endorsed by', reason AS 'Reason of Endorsement', expiration AS 'Product Expiration' FROM dogpound.stocktransaction INNER JOIN profile ON stocktransaction.employeeID = profile.personID INNER JOIN items ON stocktransaction.stockID = items.itemID WHERE type = 'In'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                System.Data.DataTable dt = new System.Data.DataTable();
                adp.Fill(dt);

                dgvTrans.DataSource = dt;
                dgvTrans.Columns["Product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Quantity Added"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Endorsed by"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Reason of Endorsement"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Product Expiration"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }

        }
        private void refreshTransOut()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT CONCAT(productName, '-', description) AS Product, stocktransaction.quantity AS 'Quantity Deducted', date AS 'Date', CONCAT(lastname, ' ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS 'Deducted by', reason AS 'Reason of Deduction' FROM dogpound.stocktransaction INNER JOIN profile ON stocktransaction.employeeID = profile.personID INNER JOIN items ON stocktransaction.stockID = items.itemID WHERE type = 'Out'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                System.Data.DataTable dt = new System.Data.DataTable();
                adp.Fill(dt);

                dgvTrans.DataSource = dt;
                dgvTrans.Columns["Product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Quantity Deducted"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Deducted by"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Reason of Deduction"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            panelTrans.Visible = true;
            a.Visible = false;
            i.Visible = false;
            r.Visible = false;
            inv.Visible = false;
            newitem.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (prodret.Text != "Product Name" && empret.Text != "Endorser" && quanret.Value != 0 && reasonret.Text != "Reason")
            {
                try
                {
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("INSERT INTO stocktransaction(stockID, employeeID, quantity, date, type, reason) VALUES("+retprod[prodret.SelectedIndex]+", "+retemp[empret.SelectedIndex]+", "+quanret.Value+", '"+date+"', 'Return', '"+reasonret.Text+"')", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
                prodret.Items.Clear();
                empret.Items.Clear();
                reasonret.Text = "Reason";
            }
            else
            {
                MessageBox.Show("Please enter required fields");
            }
                
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panelReturn.Visible = true;
            dgvout.Visible = false;
            Sout.Visible = false;
            prodret.Items.Clear();
            empret.Items.Clear();
            reasonret.Text = "Reason";
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT itemID, CONCAT(productName, ' (', description, ')') AS product FROM items", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                System.Data.DataTable dt = new System.Data.DataTable();
                adp.Fill(dt);
                retprod = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    retprod[i] = int.Parse(dt.Rows[i]["itemID"].ToString());
                    prodret.Items.Add(dt.Rows[i]["product"].ToString());
                }

                MySqlCommand commm = new MySqlCommand("SELECT employeeID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS employee FROM employee INNER JOIN profile ON profile.personID = employee.employeeID", conn);
                MySqlDataAdapter adpt = new MySqlDataAdapter(commm);
                System.Data.DataTable dta = new System.Data.DataTable();
                adpt.Fill(dta);
                retemp = new int[dta.Rows.Count];
                for (int i = 0; i < dta.Rows.Count; i++)
                {
                    retemp[i] = int.Parse(dta.Rows[i]["employeeID"].ToString());
                    empret.Items.Add(dta.Rows[i]["employee"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void reasonret_Enter(object sender, EventArgs e)
        {
            reasonret.Text = "";
        }
    }
}
