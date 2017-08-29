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
    public partial class Adopt : Form
    {
        public MySqlConnection conn;
        public int dogID;
        public int adminID;
        public Dog dog { get; set; } 
        public Adopt()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
        }
        //n mnbnm
        private void Adopt_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT breed, color, size, gender, location, date FROM (dogoperation INNER JOIN dogprofile ON dogprofile.operationID = dogoperation.operationID) INNER JOIN location on dogoperation.locationID = location.locationID WHERE dogID = " + dogID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                breeds.Text = dt.Rows[0]["breed"].ToString();
                color.Text = dt.Rows[0]["color"].ToString();
                size.Text = dt.Rows[0]["size"].ToString();
                gender.Text = dt.Rows[0]["gender"].ToString();
                location.Text = dt.Rows[0]["location"].ToString();
                date.Text = dt.Rows[0]["date"].ToString();


                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dog.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbfname.Text != "" && tbmname.Text != "" && tblname.Text !="" && tbadd.Text != "" && tbIDnum.Text != "" && tbIDtype.Text != "")
            {
                String fname = tbfname.Text;
                String mname = tbmname.Text;
                String lname = tblname.Text;
                String add = tbadd.Text;
                String idnum = tbIDnum.Text;
                String idtype = tbIDtype.Text;
                String num = tbnumber.Text;
                String date = DateTime.Now.ToString("yyyy-mm-dd");
                int vaccine = 0;
                //if (checkbox.Checked)
                //{
                //    vaccine = 1;
                //}
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("INSERT INTO client(name, contactNumber, validIDtype, validIDnumber, address) VALUES('" + fname + "', '" + num + "', '" + idtype + "', '" + idnum + "', '" + add + "')", conn);
                    comm.ExecuteNonQuery();

                    comm = new MySqlCommand("SELECT clientID FROM client WHERE validIDType = '" + idtype + "' AND validIDNumber = '" + idnum + "'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    int clientID = int.Parse(dt.Rows[0]["clientID"].ToString());
                    
                    
                    comm = new MySqlCommand("INSERT INTO dogtransaction(clientID, dogID, date, payment, vaccine, type) VALUES(" + clientID +", " + dogID + ", '" + date + "', " + "1000" + ", " + vaccine + ", '" + "adopt" + "')", conn);
                    comm.ExecuteNonQuery();

                    comm = new MySqlCommand("UPDATE dogprofile SET status = 'adopted' WHERE dogID = " + dogID, conn);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Successfully Adopted!");
                    dog.Show();
                    this.Close();
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
                MessageBox.Show("Please enter required fields");
            }
        }

        private void Adopt_FormClosing(object sender, FormClosingEventArgs e)
        {
            dog.refreshAdoption();
        }

        private void location_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialogAdt.Document = printDocumentAdt;
            printPreviewDialogAdt.ShowDialog();
        }

        private void printDocumentAdt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Adopter's Name: " + tbfname.Text + tblname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString("Contact Number: " + tbnumber.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 190));
            e.Graphics.DrawString("Address: " + tbadd.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Valid ID Type: " + tbIDtype.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 210));
            e.Graphics.DrawString("Valid ID Number: " + tbIDnum.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 210));
            if (checkBox1.Checked)
            {
                e.Graphics.DrawString("Availed Vaccine", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            }
            else
            {
                e.Graphics.DrawString("No Vaccine", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            }
            // LINE SEPARATOR

            e.Graphics.DrawString("Dog Claimed: " + breeds.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("Color:" + color.Text + tblname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 260));
            e.Graphics.DrawString("Size: " + size.Text + tblname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));
            e.Graphics.DrawString("Gender: " + gender.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 280));
            e.Graphics.DrawString("Location: " + location.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 290));
            e.Graphics.DrawString("Date and Time Caught " + date.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 300));

        }
    }
}
