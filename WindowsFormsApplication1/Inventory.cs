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
        DataTable dtclaim;
        EndorserIn end { get; set; }
        public empty back { get; set; }
        EndorserOut endO { get; set; }
        EditItem eItem { get; set; }
        empty home;
        int[] retprod;
        int[] retemp;
        int[] request; //itemID of items that need to be requested
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

            newitem.Visible = true;
            inv.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            panelTrans.Visible = false;
            a.Visible = false;
            i.Visible = false;

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
            dgvEdit.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvEdit.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvin.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvTrans.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvTrans.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
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

            inv.Visible = true;
            newitem.Visible = false;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            panelRequest.Visible = false;
            panelReturn.Visible = false;
            dgvout.Visible = true;
            Sout.Visible = false;
            button5.BackColor = Color.FromArgb(2, 170, 145);
            button16.BackColor = Color.FromArgb(251, 162, 80);
            button15.BackColor = Color.FromArgb(2, 170, 145);
            button19.BackColor = Color.FromArgb(2, 170, 145);
            refreshSI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelRequest.Visible = false;
            panelReturn.Visible = false;
            dgvout.Visible = false;
            Sout.Visible = true;
            button16.BackColor = Color.FromArgb(2, 170, 145);
            button5.BackColor = Color.FromArgb(251, 162, 80);
            button15.BackColor = Color.FromArgb(2, 170, 145);
            button19.BackColor = Color.FromArgb(2, 170, 145);
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
            endO.ShowDialog();
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
                    end.ShowDialog();
                    end.rq = dtt.Rows[0]["requestID"].ToString();
                    MySqlCommand comm = new MySqlCommand("SELECT measuredBy FROM items WHERE itemID = " + itemID.ToString(), conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    end.amtLabel.Text = "Amount by " + dt.Rows[0]["measuredBy"].ToString();

                }
                else
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
                button2.Enabled = false;
            }
            else
            {
                refreshRequests();
                button2.Enabled = false;
            }
        }
        DataTable dtRet;

        private void refreshRequests()
        {
            string datestart = y1.Text + '-' + (m1.SelectedIndex + 1).ToString() + '-' + d1.Text;
            string dateend = y2.Text + '-' + (m2.SelectedIndex + 1).ToString() + '-' + d2.Text;
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT date AS Date, CONCAT(productName, ' (', description, ')') AS Item FROM stockrequest INNER JOIN items ON stockrequest.stockID = items.itemID WHERE date BETWEEN '"+datestart+"' AND '"+dateend+"'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dtReq = new System.Data.DataTable();
                adp.Fill(dtReq);

                dgvTrans.DataSource = dtReq;
                dgvTrans.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTrans.Columns["Item"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }
        private void refreshReturns()
        {
            string datestart = y1.Text + '-' + (m1.SelectedIndex + 1).ToString() + '-' + d1.Text;
            string dateend = y2.Text + '-' + (m2.SelectedIndex + 1).ToString() + '-' + d2.Text;
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT CONCAT(productName, '-', description) AS Product, stocktransaction.quantity AS 'Quantity', SUBSTRING(date, 1, 11) AS 'Date', CONCAT(lastname, ' ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS 'Endorsed by', reason AS 'Reason of Returning' FROM dogpound.stocktransaction INNER JOIN profile ON stocktransaction.employeeID = profile.personID INNER JOIN items ON stocktransaction.stockID = items.itemID WHERE date BETWEEN '"+datestart+"' AND '" + dateend + "' AND type = 'Return'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                dtRet = new System.Data.DataTable();
                adp.Fill(dtRet);

                dgvTrans.DataSource = dtRet;
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
        DataTable dtTrans;
        private void refreshTransIn()
        {
            string datestart = y1.Text + '-' + (m1.SelectedIndex+1).ToString() + '-' + d1.Text;
            string dateend = y2.Text + '-' + (m2.SelectedIndex + 1).ToString() + '-' + d2.Text;
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT CONCAT(productName, '-', description) AS Product, stocktransaction.quantity AS 'Quantity Added', SUBSTRING(date, 1, 11) AS 'Date', CONCAT(lastname, ' ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS 'Endorsed by', reason AS 'Reason of Endorsement', SUBSTRING(expiration, 1, 11) AS 'Product Expiration' FROM dogpound.stocktransaction INNER JOIN profile ON stocktransaction.employeeID = profile.personID INNER JOIN items ON stocktransaction.stockID = items.itemID WHERE stocktransaction.date BETWEEN '" + datestart + "' AND '" + dateend + "' AND  type = 'In'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                dtTrans = new DataTable();
                adp.Fill(dtTrans);
                dgvTrans.DataSource = dtTrans;

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
        DataTable dtOut;
        private void refreshTransOut()
        {
            string datestart = y1.Text + '-' + (m1.SelectedIndex + 1).ToString() + '-' + d1.Text;
            string dateend = y2.Text + '-' + (m2.SelectedIndex + 1).ToString() + '-' + d2.Text;
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT CONCAT(productName, '-', description) AS Product, stocktransaction.quantity AS 'Quantity Deducted', SUBSTRING(date, 1, 11) AS 'Date', CONCAT(lastname, ' ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS 'Deducted by', reason AS 'Reason of Deduction' FROM dogpound.stocktransaction INNER JOIN profile ON stocktransaction.employeeID = profile.personID INNER JOIN items ON stocktransaction.stockID = items.itemID WHERE stocktransaction.date BETWEEN '" + datestart + "' AND '" + dateend + "' AND  type = 'Out'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                dtOut= new DataTable();
                adp.Fill(dtOut);
                dgvTrans.DataSource = dtOut;
                dgvTrans.DataSource = dtOut;
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
            y1.Text = DateTime.Now.ToString("yyyy");
            y2.Text = DateTime.Now.ToString("yyyy");
            pictureBox1.Visible = true;
            panelTrans.Visible = true;
            a.Visible = false;
            i.Visible = false;

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
                    MySqlCommand comm = new MySqlCommand("INSERT INTO stocktransaction(stockID, employeeID, quantity, date, type, reason) VALUES(" + retprod[prodret.SelectedIndex] + ", " + retemp[empret.SelectedIndex] + ", " + quanret.Value + ", '" + date + "', 'Return', '" + reasonret.Text + "')", conn);
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
                prodret.Text = "Product Name";
                empret.Text = "Endorser";
                quanret.Value = 0;
                reasonret.Text = "Reason";
            }
            else
            {
                MessageBox.Show("Please enter required fields");
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            panelRequest.Visible = false;
            panelReturn.Visible = true;
            dgvout.Visible = false;
            Sout.Visible = false;
            prodret.Items.Clear();
            empret.Items.Clear();
            button15.BackColor = Color.FromArgb(251, 162, 80);
            button16.BackColor = Color.FromArgb(2, 170, 145);
            button5.BackColor = Color.FromArgb(2, 170, 145);
            button19.BackColor = Color.FromArgb(2, 170, 145);
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            add.Visible = true;
            Edit.Visible = false;
            panelReturn.Visible = false;
            button6.BackColor = Color.FromArgb(251, 162, 80);
            button31.BackColor = Color.FromArgb(2, 170, 145);

        }

        private void button31_Click(object sender, EventArgs e)
        {
            Edit.Visible = true;
            add.Visible = false;
            panelReturn.Visible = false;
            button31.BackColor = Color.FromArgb(251, 162, 80);
            button6.BackColor = Color.FromArgb(2, 170, 145);

            refreshEdit();
        }

        int eID;
        bool ei = false;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                eID = int.Parse(dgvEdit.Rows[e.RowIndex].Cells["itemID"].Value.ToString());
                ei = true;

            }
        }

        public void refreshEdit()
        {
            try
            {
                conn.Open();


                MySqlCommand comm = new MySqlCommand("SELECT itemID, productName, description, CONCAT(minQuantity, ' ', measuredBy) AS min FROM items", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvEdit.DataSource = dt;

                dgvEdit.Columns["itemID"].Visible = false;

                dgvEdit.Columns["productName"].HeaderText = "Product";
                dgvEdit.Columns["description"].HeaderText = "Description";
                dgvEdit.Columns["min"].HeaderText = "Minimum Quantity";

                dgvEdit.Columns["productName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEdit.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEdit.Columns["min"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEdit.ClearSelection();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        public bool eiOpen = false;
        private void button7_Click(object sender, EventArgs e)
        {
            if (ei)
            {
                if (!eiOpen)
                {
                    eItem = new EditItem(this);
                    eiOpen = true;

                }

                eItem.id = eID;
                eItem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an item");
            }
        }

        private void reportEm()
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = printDocument1;
            ((Form)dlg).WindowState = FormWindowState.Maximized;
            dlg.ShowDialog();
        }
        int rowcount = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Republic of the Philippines", new Font("Times New Roman", 16, FontStyle.Regular), Brushes.Black, new Point(450, 50));
            e.Graphics.DrawString("City of Davao", new Font("Times New Roman", 16, FontStyle.Regular), Brushes.Black, new Point(500, 70));
            e.Graphics.DrawString("OFFICE OF THE CITY VETERINARIAN", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new Point(300, 100));
            e.Graphics.DrawString("INVENTORY", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(475, 130));

            if (cbTransType.Text == "Stock In")
            {
                string footer = string.Empty;
                int columnCount = dgvTrans.Columns.Count;
                int maxRows = dgvTrans.Rows.Count;

                using (Graphics g = e.Graphics)
                {
                    Brush brush = new SolidBrush(Color.Black);
                    Pen pen = new Pen(brush);
                    Font font = new Font("Arial", 12);
                    SizeF size;

                    int x = 25, y = 200, width = 180;
                    float xPadding;

                    // Writes out all column names in designated locations, aligned as a table
                    foreach (DataColumn column in dtTrans.Columns)
                    {
                        size = g.MeasureString(column.ColumnName, font);
                        xPadding = (width - size.Width) / 2;
                        g.DrawString(column.ColumnName, font, brush, x + xPadding, y + 10);
                        x += width;
                    }

                    x = 25;
                    y += 50;
                    int rowcount = 0;
                    // Process each row and place each item under correct column.
                    foreach (DataRow row in dtTrans.Rows)
                    {
                        rowcount++;

                        for (int i = 0; i < columnCount; i++)
                        {
                            size = g.MeasureString(row[i].ToString(), font);
                            xPadding = (width - size.Width) / 2;

                            g.DrawString(row[i].ToString(), font, brush, x + xPadding, y + 10);
                            x += width;
                        }

                        e.HasMorePages = rowcount - 1 < maxRows;

                        x = 25;
                        y += 50;
                    }
                }
            }

            else if (cbTransType.Text == "Stock Out")
            {
                //e.Graphics.DrawString("Stock Out Summary Report", new System.Drawing.Font("Arial", 20, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(25, 150));

                string footer = string.Empty;
                int columnCount = dgvTrans.Columns.Count;
                int maxRows = dgvTrans.Rows.Count;

                using (Graphics g = e.Graphics)
                {
                    Brush brush = new SolidBrush(Color.Black);
                    Pen pen = new Pen(brush);
                    Font font = new Font("Arial", 12);
                    SizeF size;

                    int x = 25, y = 200, width = 180;
                    float xPadding;

                    // Writes out all column names in designated locations, aligned as a table
                    foreach (DataColumn column in dtOut.Columns)
                    {
                        size = g.MeasureString(column.ColumnName, font);
                        xPadding = (width - size.Width) / 2;
                        g.DrawString(column.ColumnName, font, brush, x + xPadding, y + 10);
                        x += width;
                    }

                    x = 25;
                    y += 50;
                    int rowcount = 0;
                    // Process each row and place each item under correct column.
                    foreach (DataRow row in dtOut.Rows)
                    {
                        rowcount++;

                        for (int i = 0; i < columnCount; i++)
                        {
                            size = g.MeasureString(row[i].ToString(), font);
                            xPadding = (width - size.Width) / 2;

                            g.DrawString(row[i].ToString(), font, brush, x + xPadding, y + 10);
                            x += width;
                        }

                        e.HasMorePages = rowcount - 1 < maxRows;

                        x = 25;
                        y += 50;
                    }
                }
            }
            else
            {
                e.Graphics.DrawString("Returns Summary Report", new System.Drawing.Font("Arial", 20, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(25, 150));

                string footer = string.Empty;
                int columnCount = dgvTrans.Columns.Count;
                int maxRows = dgvTrans.Rows.Count;

                using (Graphics g = e.Graphics)
                {
                    Brush brush = new SolidBrush(Color.Black);
                    Pen pen = new Pen(brush);
                    Font font = new Font("Arial", 12);
                    SizeF size;

                    int x = 25, y = 200, width = 180;
                    float xPadding;

                    // Writes out all column names in designated locations, aligned as a table
                    foreach (DataColumn column in dtRet.Columns)
                    {
                        size = g.MeasureString(column.ColumnName, font);
                        xPadding = (width - size.Width) / 2;
                        g.DrawString(column.ColumnName, font, brush, x + xPadding, y + 10);
                        x += width;
                    }

                    x = 25;
                    y += 50;
                    int rowcount = 0;
                    // Process each row and place each item under correct column.
                    foreach (DataRow row in dtRet.Rows)
                    {
                        rowcount++;

                        for (int i = 0; i < columnCount; i++)
                        {
                            size = g.MeasureString(row[i].ToString(), font);
                            xPadding = (width - size.Width) / 2;

                            g.DrawString(row[i].ToString(), font, brush, x + xPadding, y + 10);
                            x += width;
                        }

                        e.HasMorePages = rowcount - 1 < maxRows;

                        x = 25;
                        y += 50;
                    }
                }
            }
            
        }
        
        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (cbTransType.Text != "Transaction Type") reportEm();
            else MessageBox.Show("Please Select a Transaction");
            

        }

        private void button19_Click(object sender, EventArgs e)
        {
            panelRequest.Visible = true;
            panelReturn.Visible = false;
            dgvout.Visible = false;
            Sout.Visible = false;
            button5.BackColor = Color.FromArgb(2, 170, 145);
            button16.BackColor = Color.FromArgb(2, 170, 145);
            button15.BackColor = Color.FromArgb(2, 170, 145);
            button19.BackColor = Color.FromArgb(251, 162, 80);
            button9.BackColor = Color.FromArgb(2, 170, 145);

            refreshRequest();
        }
        DataTable dtReq;
        private void refreshRequest()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT itemID, productName AS 'Product Name', description AS 'Product Description', quantity AS 'Quantity' FROM items WHERE quantity < minQuantity", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                dtReq = new DataTable();
                adp.Fill(dtReq);
                dgvRequest.DataSource = dtReq;
                dgvRequest.Columns["itemID"].Visible = false;
                dgvRequest.Columns["Product Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRequest.Columns["Product Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRequest.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            request = new int[dgvRequest.Rows.Count];
            for (int i = 0; i < dgvRequest.Rows.Count; i++)
            {
                request[i] = int.Parse(dgvRequest.Rows[i].Cells[0].Value.ToString());

            }
        }
        private void y1_TextChanged(object sender, EventArgs e)
        {
            if (y1.Text.Length == 4)
            {
                m1.Enabled = true;
            }
        }

        private void y2_TextChanged(object sender, EventArgs e)
        {
            if (y2.Text.Length == 4)
            {
                m2.Enabled = true;
            }
        }

        private void y2_Enter(object sender, EventArgs e)
        {
            
        }

        private void y1_Enter(object sender, EventArgs e)
        {
            
        }

        private void m1_SelectedIndexChanged(object sender, EventArgs e)
        {
            d1.Enabled = true;
            d1.Items.Clear();
            responsiveDay1(int.Parse(y1.Text));
        }

        private void m2_SelectedIndexChanged(object sender, EventArgs e)
        {
            d2.Enabled = true;
            d2.Items.Clear();
            responsiveDay2(int.Parse(y2.Text));
        }
        private void responsiveDay1(int year)
        {
            int x;
            if (m1.Text == "January" || m1.Text == "March" || m1.Text == "May" || m1.Text == "July" || m1.Text == "August" || m1.Text == "October" || m1.Text == "December") loopDay1(31);
            else if (m1.Text == "February") { if (year % 4 == 0) loopDay1(29); else loopDay1(28); }
            else loopDay1(30);
        }
        private void responsiveDay2(int year)
        {
            int x;
            if (m2.Text == "January" || m2.Text == "March" || m2.Text == "May" || m2.Text == "July" || m2.Text == "August" || m2.Text == "October" || m2.Text == "December") loopDay2(31);
            else if (m2.Text == "February") { if (year % 4 == 0) loopDay2(29); else loopDay2(28); }
            else loopDay2(30);
        }
        private void loopDay1(int x)
        {
            int i = 1;
            while (i <= x)
            {
                d1.Items.Add(i.ToString());
                i++;
            }
        }
        private void loopDay2(int x)
        {
            int i = 1;
            while (i <= x)
            {
                d2.Items.Add(i.ToString());
                i++;
            }
        }

        private void y1_Enter_1(object sender, EventArgs e)
        {
            y1.Text = "";
        }

        private void y2_Enter_1(object sender, EventArgs e)
        {
            y2.Text = "";
        }

        private void m1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            d1.Enabled = true;
            d1.Items.Clear();
            responsiveDay1(int.Parse(y1.Text));
        }

        private void m2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            d2.Enabled = true;
            d2.Items.Clear();
            responsiveDay2(int.Parse(y2.Text));
        }

        private void y1_TextChanged_1(object sender, EventArgs e)
        {
            if (y1.Text.Length == 4) m1.Enabled = true;
        }

        private void y2_TextChanged_1(object sender, EventArgs e)
        {
            if (y2.Text.Length == 4) m2.Enabled = true;
        }
    }
}
