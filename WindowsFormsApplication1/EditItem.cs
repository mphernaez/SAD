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
    public partial class EditItem : Form
    {
        Inventory inv { get; set; }
        public int id;
        MySqlConnection conn;
        public EditItem(Inventory parent)
        {
            InitializeComponent();
            inv = parent;
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");

        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            getStuff();
        }

        private void getStuff()
        {

            try
            {

                conn.Open();


                MySqlCommand comm = new MySqlCommand("SELECT * FROM items WHERE itemID = " + id, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                tbname.Text = dt.Rows[0]["productName"].ToString();
                tbdesc.Text = dt.Rows[0]["description"].ToString();
                nudmin.Value = int.Parse(dt.Rows[0]["minQuantity"].ToString());
                msBy.SelectedIndex = msBy.Items.IndexOf(dt.Rows[0]["measuredBy"].ToString());



                conn.Close();


            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }

        }

        private void updateItem()
        {
            try
            {

                conn.Open();


                MySqlCommand comm = new MySqlCommand("UPDATE items SET productName = '" + tbname.Text + "', description = '" + tbdesc.Text + "', minQuantity = " + nudmin.Value + ", measuredBy = '"+msBy.Text+"' WHERE itemID = " + id, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Item Updated");



                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            inv.eiOpen = false;
            inv.refreshEdit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateItem();
            this.Close();
            inv.refreshEdit();
            inv.eiOpen = false;
        }

        private void msBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
