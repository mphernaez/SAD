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
    public partial class FinishAct : Form
    {
        int[] itemIDs;
        string[] mesby;
        public int actID;
        public MySqlConnection conn = new MySqlConnection();
        public Employee emp { get; set; }
        public FinishAct()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void refresh()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT itemID, CONCAT(productName, ' - ', description) AS item, measuredBy FROM items", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                itemIDs = new int[dt.Rows.Count];
                mesby = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbItems.Items.Add(dt.Rows[i]["item"].ToString());
                    mesby[i] = dt.Rows[i]["measuredBy"].ToString();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
            lblMesBy.Text = "";
            num.Value = 0;
            cbItems.Text = "Item Used";
        }
        private void FinishAct_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMesBy.Text = " Quantity Used BY" + " " + mesby[cbItems.SelectedIndex].ToString().ToUpper();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (cbItems.Text == "Item Used" || num.Value == 0)
            {
                DialogResult result = MessageBox.Show("Are you sure no items were used in this activity?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    refresh();
                }
                else
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand comm = new MySqlCommand("UPDATE activity SET status = 'Finished', timeEnd = '"+DateTime.Now.ToString("HH:mm")+"' WHERE activityID = " + actID, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                try
                {
                    conn.Open();
                    MySqlCommand commm = new MySqlCommand("SELECT employeeID, type FROm activity WHERE activityID = " + actID, conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(commm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    string act = dt.Rows[0]["type"].ToString();
                    int emp = int.Parse(dt.Rows[0]["employeeID"].ToString());
                    MySqlCommand comm = new MySqlCommand("UPDATE activity SET status = 'Finished', timeEnd = '" + DateTime.Now.ToString("HH:mm") + "' WHERE activityID = " + actID, conn);
                    comm.ExecuteNonQuery();
                    comm = new MySqlCommand("INSERT INTO stocktransaction(stockID, quantity, date, type, employeeID, reason) VALUES("+itemIDs[cbItems.SelectedIndex]+", "+num.Value+", '"+DateTime.Now.ToString("yyyy-MM-dd")+"', 'Out', "+emp+", '"+act+"')", conn);
                    comm.ExecuteNonQuery();
                    comm = new MySqlCommand("UPDATE items SET quantity = quantity - " +num.Value+ " WHERE itemID = "+ itemIDs[cbItems.SelectedIndex], conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Activity Recorded");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
            }
            emp.refreshUpAct();
            this.Dispose();
        }
    }
}
