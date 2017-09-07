using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;


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
        public empty back { get; set; }
        
        public MySqlConnection conn;
        empty home;
        
        public Dog(empty parent)
        {
            InitializeComponent();
            use = Color.FromArgb(253, 208, 174);
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
            home = parent;
        }

        private void AddDog_Load(object sender, EventArgs e)
        {
            
           // this.Top = 112; //262
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
            cbOperation.Items.Clear();
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

                    MySqlCommand com = new MySqlCommand("SELECT COUNT(*) FROM dogprofile WHERE dogprofile.status = 'unclaimed'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adp.Fill(dt);
                   
                    int y = int.Parse(dt.Rows[0]["COUNT(*)"].ToString());
                    Boolean stop = false;
                    for(int x = 0; x < y && stop == false; x++)
                    {
                        MySqlCommand comm = new MySqlCommand("SELECT breed, color, gender, otherDesc FROM dogprofile WHERE dogprofile.status = 'unclaimed'", conn);
                        MySqlDataAdapter adpt = new MySqlDataAdapter(comm);
                        System.Data.DataTable data = new System.Data.DataTable();
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
              try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT dogID, gender, breed, color, UCASE(size), otherDesc FROM (dogprofile INNER JOIN dogoperation ON dogprofile.operationID = dogoperation.operationID) INNER JOIN location ON location.locationID = dogoperation.locationID WHERE breed LIKE '" + tbBreedSearch.Text + "%' AND color LIKE '" + tbColorSearch.Text + "%' AND dogprofile.status = 'unclaimed'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adp.Fill(dt);
                    
                    dgvProfiles.DataSource = dt;

                    dgvProfiles.Columns["dogID"].Visible = false;
                    dgvProfiles.Columns["breed"].HeaderText = "Breed";
                    dgvProfiles.Columns["color"].HeaderText = "Color";
                    dgvProfiles.Columns["gender"].HeaderText = "Gender";
                    dgvProfiles.Columns["otherDesc"].HeaderText = "Markings";
                    dgvProfiles.Columns["UCASE(size)"].HeaderText = "Size";
                    dgvProfiles.Columns["breed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvProfiles.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvProfiles.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvProfiles.Columns["UCASE(size)"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvProfiles.Columns["otherDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
           
        }

        public void refreshAdoption()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT dogID, breed, color, gender, size FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID WHERE dogprofile.status = 'unclaimed' AND date > DATE_ADD(NOW(), INTERVAL -3 DAY)", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                System.Data.DataTable dt = new System.Data.DataTable();
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
                MySqlCommand comm = new MySqlCommand("SELECT dogID, color, gender, size, breed, otherDesc FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID WHERE date <= DATE_ADD(NOW(), INTERVAL -3 DAY) AND dogprofile.status = 'unclaimed'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                System.Data.DataTable dt = new System.Data.DataTable();
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
            if (dogID != 0)
            {
                try
                {
                    conn.Open();

                    MySqlCommand comm = new MySqlCommand("UPDATE dogprofile SET dogprofile.status = 'euthanized' WHERE dogID = " + dogID, conn);
                    comm.ExecuteNonQuery();
                    

                    comm = new MySqlCommand("UPDATE items SET quantity=quantity-1 WHERE itemID = 2", conn);
                    comm.ExecuteNonQuery();

                    String messbox = "";

                    comm = new MySqlCommand("SELECT quantity FROM items WHERE itemID = 2", conn);
                    MySqlDataReader read = comm.ExecuteReader();
                    while (read.Read())
                    {
                        int quantity = int.Parse(read[0].ToString());
                        messbox = "Successfully Euthanized. Injection for Euthanasia quantity is now: " + quantity.ToString();
                    }
                    MessageBox.Show(messbox.ToString());
                    conn.Close();
                    refreshArchive();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a dog");
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
            repclaimpan.Visible = true;
            a.Visible = false;
            s.Visible = false;
            ad.Visible = false;
            et.Visible = false;
            r.Visible = true;
            claimreportdgv.Visible = true;

            try
            {
                conn.Open();

                MySqlCommand com = new MySqlCommand("SELECT breed, gender, size, color, otherDesc, description, SUBSTRING(date, 1, 11) AS date, CONCAT(timeStart, '-', timeEnd) AS time, dogprofile.status AS status FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID INNER JOIN location ON location.locationID = dogoperation.locationID", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                System.Data.DataTable dt = new System.Data.DataTable();
                adp.Fill(dt);


                claimreportdgv.DataSource = dt;

                claimreportdgv.Columns["breed"].HeaderText = "Breed";
                claimreportdgv.Columns["gender"].HeaderText = "Gender";
                claimreportdgv.Columns["size"].HeaderText = "Size";
                claimreportdgv.Columns["color"].HeaderText = "Color";
                claimreportdgv.Columns["otherDesc"].HeaderText = "Other Description";
                claimreportdgv.Columns["description"].HeaderText = "Location Caught";
                claimreportdgv.Columns["date"].HeaderText = "Date Caught";
                claimreportdgv.Columns["time"].HeaderText = "Time Caught";
                claimreportdgv.Columns["status"].HeaderText = "Status";


                claimreportdgv.Columns["breed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                claimreportdgv.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                claimreportdgv.Columns["size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                claimreportdgv.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                claimreportdgv.Columns["otherDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                claimreportdgv.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                claimreportdgv.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                claimreportdgv.Columns["time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                claimreportdgv.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
            
        }
        private void report()
        {
            
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

                MySqlCommand comm = new MySqlCommand("SELECT operationID, CONCAT(timeStart, ' - ', timeEnd) AS time, MONTH(date) as month, YEAR(date) as year, DAY(date) as day, description FROM dogoperation INNER JOIN location on dogoperation.locationID = location.locationID", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                System.Data.DataTable dt = new System.Data.DataTable();
                adp.Fill(dt);
                int j = 0;

                opid = new int[dt.Rows.Count - 1];       //modify global array 'opid'

                for (int i = dt.Rows.Count - 1; i >= 1; i--)
                {
                    opid[j] = int.Parse(dt.Rows[i]["operationID"].ToString());  //assign opid index to operationID (array index = combobox index [synced]) 
                    string date = dt.Rows[i]["month"].ToString() + '-' + dt.Rows[i]["day"].ToString() + '-' + dt.Rows[i]["year"].ToString();
                    string time = dt.Rows[i]["time"].ToString();
                    string loc = dt.Rows[i]["description"].ToString();
                    cbOperation.Items.Add(date + "  " + time + ",  " + "Brgy. " + loc);    //add necessary cherbs to combobox
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

                MySqlCommand comm = new MySqlCommand("UPDATE dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID SET dogprofile.status = 'euthanized' WHERE date <= DATE_ADD(NOW(), INTERVAL -3 DAY) AND dogprofile.status = 'unclaimed'", conn);
                comm.ExecuteNonQuery();
                
                int num = dgvArchive.Rows.Count;
                comm = new MySqlCommand("UPDATE items SET quantity=quantity-" + num + " WHERE itemID = 2", conn);
                comm.ExecuteNonQuery();
                String messbox = "";
                comm = new MySqlCommand("SELECT quantity FROM items WHERE itemID = 2", conn);
                MySqlDataReader read = comm.ExecuteReader();
                while (read.Read())
                {
                    int quantity = int.Parse(read[0].ToString());
                    messbox = "Successfully Euthanized All. Injection for Euthanasia Quantity is now: " + quantity.ToString();
                }
                MessageBox.Show(messbox);
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

        private void tbBreedSearch_TextChanged(object sender, EventArgs e)
        {
            refreshSearch();
        }

        private void tbColorSearch_TextChanged(object sender, EventArgs e)
        {
            refreshSearch();
        }

        private void cbGenderSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshSearch();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            home.openEmp();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.hom = home;
            log.Show();
            this.trig();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            home.openInv();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }

        private void claimreportdgv_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bit = new Bitmap(this.claimreportdgv.Width, this.claimreportdgv.Height);
            claimreportdgv.DrawToBitmap(bit, new System.Drawing.Rectangle(0, 0, this.claimreportdgv.Width, this.claimreportdgv.Height));
            e.Graphics.DrawString("Dog Summary Report", new System.Drawing.Font("Arial", 24, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(200, 100));
            e.Graphics.DrawImage(bit, 15, 80);
        }
        private void print()
        {
            printPreviewDialog1.Document = printDocument1;
            if (DialogResult.OK == printPreviewDialog1.ShowDialog())
            {
                printDocument1.DocumentName = "Dog Summary Report";
                printDocument1.Print();
            }
        }

        private void claimreportdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filt.Text == "All")
            {
                try
                {
                    conn.Open();

                    MySqlCommand com = new MySqlCommand("SELECT breed, gender, size, color, otherDesc, description, SUBSTRING(date, 1, 11) AS date, CONCAT(timeStart, '-', timeEnd) AS time, dogprofile.status AS status FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID INNER JOIN location ON location.locationID = dogoperation.locationID", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adp.Fill(dt);


                    claimreportdgv.DataSource = dt;

                    claimreportdgv.Columns["breed"].HeaderText = "Breed";
                    claimreportdgv.Columns["gender"].HeaderText = "Gender";
                    claimreportdgv.Columns["size"].HeaderText = "Size";
                    claimreportdgv.Columns["color"].HeaderText = "Color";
                    claimreportdgv.Columns["otherDesc"].HeaderText = "Other Description";
                    claimreportdgv.Columns["description"].HeaderText = "Location Caught";
                    claimreportdgv.Columns["date"].HeaderText = "Date Caught";
                    claimreportdgv.Columns["time"].HeaderText = "Time Caught";
                    claimreportdgv.Columns["status"].HeaderText = "Status";


                    claimreportdgv.Columns["breed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["otherDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            } else if (filt.Text == "Claimed")
            {
                try
                {
                    conn.Open();
                    //where status = claimed
                    MySqlCommand com = new MySqlCommand("SELECT breed, gender, size, color, otherDesc, description, SUBSTRING(date, 1, 11) AS date, CONCAT(timeStart, '-', timeEnd) AS time, dogprofile.status AS status FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID INNER JOIN location ON location.locationID = dogoperation.locationID  WHERE dogprofile.status = 'claimed'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adp.Fill(dt);


                    claimreportdgv.DataSource = dt;

                    claimreportdgv.Columns["breed"].HeaderText = "Breed";
                    claimreportdgv.Columns["gender"].HeaderText = "Gender";
                    claimreportdgv.Columns["size"].HeaderText = "Size";
                    claimreportdgv.Columns["color"].HeaderText = "Color";
                    claimreportdgv.Columns["otherDesc"].HeaderText = "Other Description";
                    claimreportdgv.Columns["description"].HeaderText = "Location Caught";
                    claimreportdgv.Columns["date"].HeaderText = "Date Caught";
                    claimreportdgv.Columns["time"].HeaderText = "Time Caught";
                    claimreportdgv.Columns["status"].HeaderText = "Status";


                    claimreportdgv.Columns["breed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["otherDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            } else if (filt.Text == "Euthanized")
            {
                try
                {
                    conn.Open();
                    //where status = euthanized
                    MySqlCommand com = new MySqlCommand("SELECT breed, gender, size, color, otherDesc, description, SUBSTRING(date, 1, 11) AS date, CONCAT(timeStart, '-', timeEnd) AS time, dogprofile.status AS status FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID INNER JOIN location ON location.locationID = dogoperation.locationID  WHERE dogprofile.status = 'euthanized'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adp.Fill(dt);


                    claimreportdgv.DataSource = dt;

                    claimreportdgv.Columns["breed"].HeaderText = "Breed";
                    claimreportdgv.Columns["gender"].HeaderText = "Gender";
                    claimreportdgv.Columns["size"].HeaderText = "Size";
                    claimreportdgv.Columns["color"].HeaderText = "Color";
                    claimreportdgv.Columns["otherDesc"].HeaderText = "Other Description";
                    claimreportdgv.Columns["description"].HeaderText = "Location Caught";
                    claimreportdgv.Columns["date"].HeaderText = "Date Caught";
                    claimreportdgv.Columns["time"].HeaderText = "Time Caught";
                    claimreportdgv.Columns["status"].HeaderText = "Status";


                    claimreportdgv.Columns["breed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["otherDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            } else if (filt.Text == "Adopted")
            {
                try
                {
                    conn.Open();
                    //where status = adopted
                    MySqlCommand com = new MySqlCommand("SELECT breed, gender, size, color, otherDesc, description, SUBSTRING(date, 1, 11) AS date, CONCAT(timeStart, '-', timeEnd) AS time, dogprofile.status AS status FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID INNER JOIN location ON location.locationID = dogoperation.locationID  WHERE dogprofile.status = 'adopted'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adp.Fill(dt);


                    claimreportdgv.DataSource = dt;

                    claimreportdgv.Columns["breed"].HeaderText = "Breed";
                    claimreportdgv.Columns["gender"].HeaderText = "Gender";
                    claimreportdgv.Columns["size"].HeaderText = "Size";
                    claimreportdgv.Columns["color"].HeaderText = "Color";
                    claimreportdgv.Columns["otherDesc"].HeaderText = "Other Description";
                    claimreportdgv.Columns["description"].HeaderText = "Location Caught";
                    claimreportdgv.Columns["date"].HeaderText = "Date Caught";
                    claimreportdgv.Columns["time"].HeaderText = "Time Caught";
                    claimreportdgv.Columns["status"].HeaderText = "Status";


                    claimreportdgv.Columns["breed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["otherDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    claimreportdgv.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            } else
            {
                MessageBox.Show("Please select type");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            print();
        }
    }
}
