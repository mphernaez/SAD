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
    public partial class EditDog : Form
    {
        Dog dog {get;set;}
        public int dogID;
        public MySqlConnection conn;
        public EditDog(Dog parent)
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
            dog = parent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditDog_Load(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT dogID, breed, size, gender, color, otherDesc, sublocation FROM dogprofile Where status = 'unclaimed' AND dogID = " + dogID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                cbBreed.SelectedIndex = cbBreed.Items.IndexOf(dt.Rows[0]["breed"].ToString());

                string size = dt.Rows[0]["size"].ToString();
                if (size == "xs") cbSize.SelectedIndex = 0;
                else if (size == "s") cbSize.SelectedIndex = 1;
                else if (size == "l") cbSize.SelectedIndex = 2;
                else if (size == "xl") cbSize.SelectedIndex = 3;

                string gender = dt.Rows[0]["gender"].ToString();
                if (gender == "F") cbGender.SelectedIndex = 1;
                else if (gender == "M") cbGender.SelectedIndex = 0;

                tbColor.Text = dt.Rows[0]["color"].ToString();
                tbMarkings.Text = dt.Rows[0]["otherDesc"].ToString();
                tbSub.Text = dt.Rows[0]["sublocation"].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (cbGender.Text != "" && cbBreed.Text != "" && cbSize.Text != "" && tbColor.Text != "" && tbMarkings.Text != "" && tbSub.Text != "") {
                try
                {
                    conn.Open();
                    string size = "";
                    if (cbSize.SelectedIndex == 0) size = "xs";
                    else if (cbSize.SelectedIndex == 1) size = "s";
                    else if (cbSize.SelectedIndex == 1) size = "l";
                    else if (cbSize.SelectedIndex == 1) size = "xl";

                    string gender = "";
                    if (cbGender.SelectedIndex == 1) gender = "F";
                    else if (cbGender.SelectedIndex == 0) gender = "M";
                    MySqlCommand comm = new MySqlCommand("UPDATE dogprofile SET breed = '" + cbBreed.Text + "', gender = '" + gender + "', size = '" + size + "', color = '" + tbColor.Text + "', otherDesc = '" + tbMarkings.Text + "', sublocation = '" + tbSub.Text + "' WHERE dogID = " + dogID , conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Dog Profile Updated");
                    dog.refreshEditDog();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
