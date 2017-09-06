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
                dgvin.Columns["productName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvin.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvin.Columns["quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvin.Columns["minQuantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvin.ClearSelection();

                conn.Close();
            }
            catch(Exception ex)
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
                dgvo.Columns["productName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvo.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvo.Columns["quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvo.Columns["minQuantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                if (tbname.Text != "Product Name" && tbdesc.Text != "Product Type" && msBy.Text != "Measured by")
                {
                    if (hasExp == true)
                    {
                        
                    }
                    else if (hasExp == false)
                    {
                        MySqlCommand comm = new MySqlCommand("INSERT INTO items VALUES (itemID, '" + tbname.Text + "', '" + tbdesc.Text + "', 0, " + nudmin.Value.ToString() + ", '')", conn);
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Item Added");
                        refreshCreate();
                    }
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
        private void inv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
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
                if (int.Parse(nubo.Text) <= qua)
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
                */
           
            endO.id = itemID;
            endO.Show(); 
           
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
                end.id = itemID;
                end.Show();
            try{
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT measuredBy FROM items WHERE itemID = " + itemID.ToString(), conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                end.amtLabel.Text = "Amount by " + dt.Rows[0]["measuredBy"].ToString();
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
            if (e.RowIndex < 0)
            {

            } else
            {
                itemID = int.Parse(dgvin.Rows[e.RowIndex].Cells["itemID"].Value.ToString());
            }
            
           
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

        private void label10_Click(object sender, EventArgs e)
        {

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tbdesc_TextChanged(object sender, EventArgs e)
        {

        }

        bool hasExp = true;

        private void button14_Click(object sender, EventArgs e)
        {
            if (hasExp == true)
            {
                hasExp = false;
                
            } else
            {
                hasExp = true;
                
            }
        }

        private void dgvin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
