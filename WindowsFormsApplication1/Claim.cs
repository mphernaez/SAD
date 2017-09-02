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
    public partial class Claim : Form
    {
        public int dogID;
        public int adminID;
        public MySqlConnection conn;
        public Dog dog { get; set; }
        public Claim()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
            dataGridView.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dog.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Preview();

            if (tbfname.Text != "" && tbmname.Text != "" && tblname.Text != "" && tbadd.Text != "" && tbIDnum.Text != "" && tbIDtype.Text != "" && cbMonth.Text != "Month" && tbDay.Text != "Day" && tbYear.Text != "Year")
            {
                String fname = tbfname.Text;
                String mname = tbmname.Text;
                String lname = tblname.Text;
                String add = tbadd.Text;
                String idnum = tbIDnum.Text;
                String idtype = tbIDtype.Text;
                String num = tbnumber.Text;
                String date = DateTime.Now.ToString("yyyy-MM-dd");
                String month = (cbMonth.SelectedIndex + 1).ToString();
                String day = tbDay.Text;
                String year = tbDay.Text;
                String bday = year + '-' + month + '-' + day;
                int vaccine = 0;
                if (checkbox.Checked)
                {
                    vaccine = 1;
                }
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("INSERT INTO profile(firstname, middlename, lastname, contactNumber, address, birthdate) VALUES('" + fname + "', '" + mname + "','" + lname + "', '" + num + "', '" + add + "' , '" + bday + "')", conn);
                    comm.ExecuteNonQuery();

                    comm = new MySqlCommand("SELECT MAX(personID) FROM profile", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    int personID = int.Parse(dt.Rows[0]["MAX(personID)"].ToString());

                    comm = new MySqlCommand("INSERT INTO client(personID, validIDType, validIDNumber) VALUES(" + personID + ", '" + idtype + "', '" + idnum + "')", conn);
                    comm.ExecuteNonQuery();

                    comm = new MySqlCommand("INSERT INTO dogtransaction(personID, dogID, date, payment, vaccine, type) VALUES(" + personID + ", " + dogID + ", '" + date + "', " + "250" + ", " + vaccine + ", '" + "claim" + "')", conn);
                    comm.ExecuteNonQuery();

                    comm = new MySqlCommand("UPDATE dogprofile SET status = 'claimed' WHERE dogID = " + dogID, conn);
                    comm.ExecuteNonQuery();
                    if (vaccine == 1)
                    {
                        comm = new MySqlCommand("UPDATE items SET quantity=quantity-1 WHERE itemID =  1", conn);
                        comm.ExecuteNonQuery();
                    }
                    MessageBox.Show("Successfully CLaimed!");
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
            
        }
        
        private void Claim_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT time, breed, color, size, gender, description, date FROM (dogoperation INNER JOIN dogprofile ON dogprofile.operationID = dogoperation.operationID) INNER JOIN location on dogoperation.locationID = location.locationID WHERE dogID = " + dogID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                breeds.Text = dt.Rows[0]["breed"].ToString();
                color.Text = dt.Rows[0]["color"].ToString();
                size.Text = dt.Rows[0]["size"].ToString();
                gender.Text = dt.Rows[0]["gender"].ToString();
                location.Text = "Brgy. " + dt.Rows[0]["description"].ToString();
                date.Text = dt.Rows[0]["date"].ToString();
                time.Text = dt.Rows[0]["time"].ToString();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void Claim_FormClosing(object sender, FormClosingEventArgs e)
        {
            dog.refreshSearch();
            dog.tbBreedSearch.Text = "";
            dog.tbColorSearch.Text = "";
            dog.cbGenderSearch.SelectedIndex = 0;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbIDnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tbIDtype_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void color_Click(object sender, EventArgs e)
        {

        }
        
        private void Preview()
        {
            printPreviewDialogCR.Document = printDocumentCR;
            printPreviewDialogCR.ShowDialog();
            this.TopMost = true;
        }
        private void printDocumentCR_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.home;


            e.Graphics.DrawString("Claimer's Name: " + tbfname.Text + tblname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString("Contact Number: " + tbnumber.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Address: " + tbadd.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("Valid ID Type: " + tbIDtype.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 240));
            e.Graphics.DrawString("Valid ID Number: " + tbIDnum.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 260));
            if (checkbox.Checked)
            {
                e.Graphics.DrawString("Availed Vaccine", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 280));
            } else
            {
                e.Graphics.DrawString("No Vaccine", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 280));
            }
            // put line separator

            e.Graphics.DrawString("Dog Claimed: " + breeds.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 320));
            e.Graphics.DrawString("Color:" + color.Text + tblname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 340));
            e.Graphics.DrawString("Size: " + size.Text + tblname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 360));
            e.Graphics.DrawString("Gender: " + gender.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 380));
            e.Graphics.DrawString("Location: " + location.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 400));
            e.Graphics.DrawString("Date and Time Caught " + date.Text + "," + time.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 420));
        }
                
        private void tbfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDay_Enter(object sender, EventArgs e)
        {
            tbDay.Text = "";
        }

        private void tbYear_Enter(object sender, EventArgs e)
        {
            tbYear.Text = "";
        }
    }
}
