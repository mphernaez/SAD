﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{
    //HAI
    public partial class Dog : Form
    {
        //45   
        //55
        private Color use;
        public int dogID;
        public int adminID;
        public int adoptID;
        int i = -40;
        int[] opid; //id for every combobox item
        public Home back { get; set; }
        public MySqlConnection conn;
        public Dog()
        {
            InitializeComponent();
            use = Color.FromArgb(253, 208, 174);
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
        }

        private void AddDog_Load(object sender, EventArgs e)
        {
            
            this.Top = 262;
        }
        public void trig()
        {
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            addDog.Visible = true;
            searchDog.Visible = false;
            adoptDog.Visible = false;
            euthanizeDog.Visible = false;
            a.Visible = true;
            s.Visible = false;
            ad.Visible = false;
            et.Visible = false;
            r.Visible = false;
            
            addOperationsItems();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            searchDog.Visible = true;
            addDog.Visible = false;
            adoptDog.Visible = false;
            euthanizeDog.Visible = false;
            a.Visible = false;
            s.Visible = true;
            ad.Visible = false;
            et.Visible = false;
            r.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void searchDog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int operationID;
            int adminID;
            String color = "";
            char gender;
            String size = "";
            String other = "";
            String breed = "";
            if (!cbOperation.Text.Equals("Operation Date and Location") && tbColor.Text != "Color" && cbGender.Text != "Gender" && cbSize.Text != "Size" && tbDesc.Text != "Other Description") {
                adminID = back.adminID;
                operationID = cbOperation.SelectedIndex + 1;
                color = tbColor.Text;
                breed = tbBreed.Text;

                if (cbGender.SelectedIndex == 0)
                    gender = 'M';
                else
                    gender = 'F';

                if (cbSize.SelectedIndex == 0)
                    size = "xs";
                else if (cbSize.SelectedIndex == 1)
                    size = "s";
                else if (cbSize.SelectedIndex == 2)
                    size = "l";
                else if (cbSize.SelectedIndex == 3)
                    size = "xl";

                other = tbDesc.Text;
                operationID = opid[cbOperation.SelectedIndex];
                try
                {
                    conn.Open();

                    MySqlCommand com = new MySqlCommand("SELECT COUNT(*) FROM dogprofile WHERE status = 'unclaimed'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                   
                    int y = int.Parse(dt.Rows[0]["COUNT(*)"].ToString());
                    Boolean stop = false;
                    for(int x = 0; x < y && stop == false; x++)
                    {
                        MySqlCommand comm = new MySqlCommand("SELECT breed, color, gender, otherDesc FROM dogprofile WHERE status = 'unclaimed'", conn);
                        MySqlDataAdapter adpt = new MySqlDataAdapter(comm);
                        DataTable data = new DataTable();
                        adpt.Fill(data);

                        int genders;

                        if (data.Rows[x]["gender"].ToString() == "F")
                        {
                            genders = 1;
                        }
                        else
                        {
                            genders = 0;
                        }

                        if(data.Rows[x]["breed"].ToString() == tbBreed.Text && data.Rows[x]["color"].ToString() == tbColor.Text && genders == cbGender.SelectedIndex && data.Rows[x]["OtherDesc"].ToString() == tbDesc.Text)
                        {
                            stop = true;
                            MessageBox.Show("It seems like there is an exact copy of the dog in the profiles. Please change or add more to the dog's description/s.");
                        }
                    }
                    

                    if (stop == false) {
                        MySqlCommand comm = new MySqlCommand("INSERT INTO dogprofile(operationID, color, gender, size, otherDesc, breed, status) VALUES(" + operationID + ",'" + color + "', '" + gender + "', '" + size + "', '" + other + "', '" + breed + "', '" + "unclaimed" + "')", conn);
                        comm.ExecuteNonQuery();
                        
                        cbGender.Text = "Gender";
                        cbOperation.Text = "Operation Date and Location";
                        cbSize.Text = "Size";
                        tbBreed.Text = "Breed";
                        tbColor.Text = "Color";
                        tbDesc.Text = "Other Description";

                        MessageBox.Show("Profile Added Successfully");
                    }
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

        private void rePopDog()
        {
            cbGender.Text = "Gender";
            cbOperation.Text = "Operation Date and Location";
            cbSize.Text = "Size";
            tbBreed.Text = "Breed";
            tbColor.Text = "Color";
            tbDesc.Text = "Description";
            cbGender.ForeColor = cbOperation.ForeColor = cbSize.ForeColor = tbBreed.ForeColor = tbColor.ForeColor = tbDesc.ForeColor = Color.Gray;
        }

        private void tbBreed_Enter(object sender, EventArgs e)
        {
            tbBreed.Text = "";
            tbBreed.ForeColor = Color.Black;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            tbColor.Text = "";
            tbColor.ForeColor = Color.Black;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            refreshSearch();
        }

        private void dgvProfiles_CellClick(object sender, DataGridViewCellEventArgs e)
            
        {
            dogID = int.Parse(dgvProfiles.Rows[e.RowIndex].Cells["dogID"].Value.ToString());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dogID != 0) {
                Claim claim = new Claim();
                claim.dogID = this.dogID;
                claim.adminID = this.adminID;
                claim.dog = this;
                claim.TopMost = true;
                claim.Show();
            }
            else
            {
                MessageBox.Show("Please select a dog");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Adopt adopt = new Adopt();
            adopt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            searchDog.Visible = true;
            addDog.Visible = false;


            button1.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
            searchDog.Visible = false;
            addDog.Visible = false;
            adoptDog.Visible = true;
            euthanizeDog.Visible = false;
            a.Visible = false;
            s.Visible = false;
            ad.Visible = true;
            et.Visible = false;
            r.Visible = false;


            refreshAdoption();
        }

        public void refreshSearch()
        {
            if (tbColorSearch.Text != "" || tbBreedSearch.Text != "" || cbGenderSearch.SelectedIndex != 0)
            {
                Char gender = ' ';

                if (cbGenderSearch.SelectedIndex == 1)
                    gender = 'M';
                else if (cbGenderSearch.SelectedIndex == 2)
                    gender = 'F';


                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT dogID, breed, date, description, size, otherDesc FROM (dogprofile INNER JOIN dogoperation ON dogprofile.operationID = dogoperation.operationID) INNER JOIN location ON location.locationID = dogoperation.locationID WHERE gender = '" + gender + "' AND breed LIKE '%" + tbBreedSearch.Text + "%' AND color LIKE '%" + tbColorSearch.Text + "%' AND status = 'unclaimed'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    dgvProfiles.DataSource = dt;

                    dgvProfiles.Columns["dogID"].Visible = false;
                    dgvProfiles.Columns["breed"].HeaderText = "Breed";
                    dgvProfiles.Columns["date"].HeaderText = "Date Caught";
                    dgvProfiles.Columns["description"].HeaderText = "Location Caught";
                    dgvProfiles.Columns["otherDesc"].HeaderText = "Other Description";
                    dgvProfiles.Columns["breed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvProfiles.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvProfiles.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvProfiles.Columns["otherDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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

        public void refreshAdoption()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT dogID, breed, color, gender, size FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID WHERE status = 'unclaimed' AND date > DATE_ADD(NOW(), INTERVAL -3 DAY)", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvAdoption.DataSource = dt;

                dgvAdoption.Columns["dogID"].Visible = false;
                dgvAdoption.Columns["breed"].HeaderText = "Breed";
                dgvAdoption.Columns["breed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAdoption.Columns["color"].HeaderText = "Color";
                dgvAdoption.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAdoption.Columns["gender"].HeaderText = "Gender";
                dgvAdoption.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAdoption.Columns["size"].HeaderText = "Size";
                dgvAdoption.Columns["size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (adoptID != 0) {
                Adopt adopt = new Adopt();
                adopt.dogID = this.adoptID;
                adopt.adminID = this.adminID;
                adopt.dog = this;
                adopt.TopMost = true;
                adopt.Show();
            }
            else
            {
                MessageBox.Show("Please select a dog");
            }
        }

        private void dgvAdoption_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            adoptID = int.Parse(dgvAdoption.Rows[e.RowIndex].Cells["dogID"].Value.ToString()); 
        }

        private void adoptDog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbDesc_Enter(object sender, EventArgs e)
        {
            tbDesc.Text = "";
            tbDesc.ForeColor = Color.Black;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            searchDog.Visible = false;
            addDog.Visible = false;
            adoptDog.Visible = false;
            euthanizeDog.Visible = true;
            a.Visible = false;
            s.Visible = false;
            ad.Visible = false;
            et.Visible = true;
            r.Visible = false;

            refreshArchive();
            
        }

        public void refreshArchive()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT dogID, color, gender, size, breed, otherDesc FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID WHERE date <= DATE_ADD(NOW(), INTERVAL -3 DAY) AND status = 'unclaimed'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvArchive.DataSource = dt;
                
                dgvArchive.Columns["dogID"].Visible = false;
                dgvArchive.Columns["color"].HeaderText = "Color";
                dgvArchive.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvArchive.Columns["gender"].HeaderText = "Gender";
                dgvArchive.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvArchive.Columns["size"].HeaderText = "Size";
                dgvArchive.Columns["size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvArchive.Columns["breed"].HeaderText = "Breed";
                dgvArchive.Columns["breed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvArchive.Columns["otherDesc"].HeaderText = "Other Description";
                dgvArchive.Columns["otherDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }


        }

        private void euthanizeDog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                
                MySqlCommand comm = new MySqlCommand("UPDATE dogprofile SET status = 'euthanized' WHERE dogID = " + dogID, conn);
                comm.ExecuteNonQuery();
                

                conn.Close();
                refreshArchive();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void dgvArchive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dogID = int.Parse(dgvArchive.Rows[e.RowIndex].Cells["dogID"].Value.ToString());
        }

        private void dgvAdoption_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void addDog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addDog_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            searchDog.Visible = false;
            addDog.Visible = false;
            adoptDog.Visible = false;
            euthanizeDog.Visible = false;
            a.Visible = false;
            s.Visible = false;
            ad.Visible = false;
            et.Visible = false;
            r.Visible = true;

            string dogExcel;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            dogExcel = "C:\\Desktop\\DogReport.xlxs";

            xlWorkBook = xlApp.Workbooks.Open("dogExcel", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlApp.Visible = true;

            xlWorkBook.Close();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tbColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbOperation.Text != "Operation Date and Location")
            {
                cbOperation.ForeColor = Color.Black;
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGender.Text != "Gender")
            {
                cbGender.ForeColor = Color.Black;
            }
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSize.Text != "Size")
            {
                cbSize.ForeColor = Color.Black;
            }
        }

        private void addOperationsItems()
        {
            try
            {
                conn.Open();

                MySqlCommand comm = new MySqlCommand("SELECT operationID, time, date, description FROM dogoperation INNER JOIN location on dogoperation.locationID = location.locationID", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                int j = 0;

                opid = new int[dt.Rows.Count - 1];       //modify global array 'opid'

                for (int i = dt.Rows.Count - 1; i >= 1; i--)
                {
                    opid[j] = int.Parse(dt.Rows[i]["operationID"].ToString());          //assign opid index to operationID (array index = combobox index [synced]) 
                    string date = dt.Rows[i]["date"].ToString().Substring(0, 10);
                    string time = dt.Rows[i]["time"].ToString();
                    string loc = dt.Rows[i]["description"].ToString();
                    cbOperation.Items.Add(time + " " + date + ", " + "Brgy. " + loc);    //add necessary cherbs to combobox
                    j++;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Viewdog view = new Viewdog();
            view.Show();
            view.TopMost = true;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand comm = new MySqlCommand("UPDATE dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID SET status = 'euthanized' WHERE date <= DATE_ADD(NOW(), INTERVAL -3 DAY) AND status = 'unclaimed'", conn);
                comm.ExecuteNonQuery();


                conn.Close();
                refreshArchive();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void dgvArchive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}
