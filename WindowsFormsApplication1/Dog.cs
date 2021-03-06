﻿using System;
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


namespace WindowsFormsApplication1
{
    //HAI
    public partial class Dog : Form
    {
        //45   
        //55
        EditDog editdogform;
        DataTable dtclaim;
        DataTable dtadopt;
        DataTable dteut;
        private Color use;
        public int dogID;
        public int adminID;
        public int adoptID;
        public int[] empids;
        Boolean btnhold = false;
        int i = -40;
        int[] opid; //id for every combobox item
        int editdog;
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

        public void dogRep()
        {
            addDog.Visible = true;
            a.Visible = true;
            addOperationsItems();
            
        }
        private void AddDog_Load(object sender, EventArgs e)
        {
            dgvArchive.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvArchive.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvAdoption.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvAdoption.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvProfiles.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvProfiles.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            claimreportdgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            claimreportdgv.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvVacc.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvVacc.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            claimreportdgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            claimreportdgv.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            // this.Top = 112; //262
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cbOperation.Text = "Operation Date and Location";
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
            repclaimpan.Visible = false;
            cbOperation.Items.Clear();
            addOperationsItems();
            pnlAddDog.Visible = true;
            pnlEditDog.Visible = false;
            add.BackColor = Color.FromArgb(251, 162, 80);
            edit.BackColor = Color.FromArgb(2, 170, 145);

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
            repclaimpan.Visible = false;

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

            if (!cbOperation.Text.Equals("Operation Date and Location") && tbColor.Text != "Color" && cbGender.Text != "Gender" && cbSize.Text != "Size" && tbDesc.Text != "Markings")
            {
                adminID = back.adminID;
                //operationID = cbOperation.SelectedIndex + 1;
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
                    for (int x = 0; x < y && stop == false; x++)
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

                        if (data.Rows[x]["breed"].ToString() == tbBreed.Text && data.Rows[x]["color"].ToString() == tbColor.Text && genders == cbGender.SelectedIndex && data.Rows[x]["OtherDesc"].ToString() == tbDesc.Text)
                        {
                            stop = true;
                            MessageBox.Show("It seems like there is an exact copy of the dog in the profiles. Please change or add more to the dog's description/s.");
                        }
                    }


                    if (stop == false)
                    {
                        MySqlCommand comm = new MySqlCommand("INSERT INTO dogprofile(operationID, color, gender, size, otherDesc, breed, status, sublocation) VALUES(" + operationID + ",'" + color + "', '" + gender + "', '" + size + "', '" + other + "', '" + breed + "', '" + "unclaimed" + "', '"+subloc.Text+"')", conn);
                        comm.ExecuteNonQuery();

                        cbGender.Text = "Gender";
                        cbSize.Text = "Size";
                        tbBreed.Text = "Breed";
                        tbColor.Text = "Color";
                        tbDesc.Text = "Other Description";
                        subloc.Text = "Sublocation";
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

        private void dgvProfiles_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex != -1)
            {
                dogID = int.Parse(dgvProfiles.Rows[e.RowIndex].Cells["dogID"].Value.ToString());
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dogID != 0)
            {
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
            repclaimpan.Visible = false;

            refreshAdoption();
            dgvAdoption.ClearSelection();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (adoptID != 0)
            {
                Adopt adopt = new Adopt();
                adopt.dogID = this.adoptID;
                adopt.adminID = this.adminID;
                adopt.dog = this;
                adopt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a dog");
            }
        }

        private void dgvAdoption_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                adoptID = int.Parse(dgvAdoption.Rows[e.RowIndex].Cells["dogID"].Value.ToString());
            }
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
            repclaimpan.Visible = false;

            refreshArchive();
            dgvArchive.ClearSelection();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dogID != 0 && cbEmps.Text != "Euthanized by")
            {
                try
                {
                    conn.Open();
                    MySqlCommand commm = new MySqlCommand("SELECT quantity FROM items WHERE description = 'Euthanasia Injection' OR description = 'Syringe'", conn);
                    MySqlDataAdapter adptt = new MySqlDataAdapter(commm);
                    DataTable dtt = new DataTable();
                    adptt.Fill(dtt);
                    if (int.Parse(dtt.Rows[0]["quantity"].ToString()) > 0 && int.Parse(dtt.Rows[0]["quantity"].ToString()) > 0) {
                        MySqlCommand comm = new MySqlCommand("UPDATE dogprofile SET dogprofile.status = 'euthanized' WHERE dogID = " + dogID, conn);
                        comm.ExecuteNonQuery();

                        comm = new MySqlCommand("UPDATE items SET quantity=quantity-1 WHERE description = 'Euthanasia Injection'", conn);
                        comm.ExecuteNonQuery();

                        comm = new MySqlCommand("UPDATE items SET quantity=quantity-1 WHERE description = 'Syringe'", conn);
                        comm.ExecuteNonQuery();

                        string date = DateTime.Now.ToString("yyyy-MM-dd");

                        comm = new MySqlCommand("INSERT INTO stocktransaction(stockID, quantity, date, reason, type, employeeID) VALUES(2, 1, '" + date + "', 'Euthanasia', 'Out', " + empids[cbEmps.SelectedIndex] + ")", conn);
                        comm.ExecuteNonQuery();

                        comm = new MySqlCommand("INSERT INTO dogtransaction(personID, dogID, date, payment, type, vaccine) VALUES(" + empids[cbEmps.SelectedIndex] + ", " + dogID + ", '" + date + "', 0, 'euthanize', 1)", conn);
                        comm.ExecuteNonQuery();

                        comm = new MySqlCommand("INSERT INTO activity(date, employeeID, type) VALUES('" + date + "', " + empids[cbEmps.SelectedIndex] + ", 'Euthanasia' )", conn);
                        comm.ExecuteNonQuery();
                        String messbox = "";
                        string nl = Environment.NewLine;
                        comm = new MySqlCommand("SELECT quantity FROM items WHERE description = 'Euthanasia Injection'", conn);
                        MySqlDataAdapter adpt = new MySqlDataAdapter(comm);
                        DataTable dtttt = new DataTable();
                        adpt.Fill(dtttt);
                        comm = new MySqlCommand("SELECT quantity FROM items WHERE description = 'Syringe'", conn);
                        MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                        DataTable dttt = new DataTable();
                        adp.Fill(dttt);

                        messbox = "Successfully Euthanized Dog. " + nl + "Injection for Euthanasia Quantity is now: " + dtttt.Rows[0]["quantity"].ToString() + nl + "Syringe Quantity is now: " + dttt.Rows[0]["quantity"].ToString();

                        MessageBox.Show(messbox);
                        conn.Close();
                        refreshArchive();
                    }
                    else
                    {
                        MessageBox.Show("Running Out of Euthanasia Injection/Syringe. Cannot Euthanize Dog", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
            else if (dogID == 0)
            {
                MessageBox.Show("Please select a dog");
            }
            else
            {
                MessageBox.Show("Please Select an Employee");
            }
        }

        private void dgvArchive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dogID = int.Parse(dgvArchive.Rows[e.RowIndex].Cells["dogID"].Value.ToString());
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            y1.Text = DateTime.Now.ToString("yyyy");
            y2.Text = DateTime.Now.ToString("yyyy");

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
            refreshfilters();
        }

        private void refreshfilters()
        {
            filt.Text = "Status";
            y1.Text = DateTime.Now.ToString("yyyy");
            m1.Text = "Month";
            d1.Items.Clear();
            d1.Text = "Day";
            y2.Text = DateTime.Now.ToString("yyyy");
            m2.Text = "Month";
            d2.Items.Clear();
            d2.Text = "Day";
            m1.Enabled = true;
            d1.Enabled = false;
            m2.Enabled = true;
            d2.Enabled = false;
        }
        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            subloc.Items.Clear();
            if (cbOperation.Text != "Operation Date and Location")
            {
                cbOperation.ForeColor = Color.Black;
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.Text != "Gender")
            {
                cbGender.ForeColor = Color.Black;
            }
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSize.Text != "Size")
            {
                cbSize.ForeColor = Color.Black;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Viewdog view = new Viewdog();
            view.Show();
            view.TopMost = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (cbEmps.Text != "Euthanized by")
            {
                try
                {
                    conn.Open();
                    MySqlCommand commm = new MySqlCommand("SELECT quantity FROM items WHERE description = 'Euthanasia Injection' OR description = 'Syringe'", conn);
                    MySqlDataAdapter adptt = new MySqlDataAdapter(commm);
                    DataTable dtt = new DataTable();
                    adptt.Fill(dtt);
                    if (int.Parse(dtt.Rows[0]["quantity"].ToString()) > dgvArchive.Rows.Count && int.Parse(dtt.Rows[1]["quantity"].ToString()) > dgvArchive.Rows.Count) {
                        MySqlCommand comm = new MySqlCommand("UPDATE dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID SET dogprofile.status = 'euthanized' WHERE date <= DATE_ADD(NOW(), INTERVAL -3 DAY) AND dogprofile.status = 'unclaimed'", conn);
                        comm.ExecuteNonQuery();
                        int num = dgvArchive.Rows.Count;
                        for (int i = 0; i < num; i++)
                        {
                            int dogid = int.Parse(dgvArchive.Rows[i].Cells["dogID"].Value.ToString());
                            comm = new MySqlCommand("INSERT INTO dogtransaction(personID, dogID, date, payment, type, vaccine) VALUES(" + empids[cbEmps.SelectedIndex] + ", " + dogid + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "', 0, 'euthanize', 1)", conn);
                            comm.ExecuteNonQuery();
                        }
                        comm = new MySqlCommand("UPDATE items SET quantity=quantity-" + num + " WHERE description = 'Euthanasia Injection'", conn);
                        comm.ExecuteNonQuery();
                        comm = new MySqlCommand("UPDATE items SET quantity=quantity-" + num + " WHERE description = 'Syringe'", conn);
                        comm.ExecuteNonQuery();
                        string date = DateTime.Now.ToString("yyyy-MM-dd");
                        comm = new MySqlCommand("INSERT INTO stocktransaction(stockID, quantity, date, reason, type, employeeID) VALUES(2, " + num + ", '" + date + "', 'Euthanasia', 'Out', " + empids[cbEmps.SelectedIndex] + ")", conn);
                        comm.ExecuteNonQuery();
                        comm = new MySqlCommand("INSERT INTO activity(date, employeeID, type) VALUES('" + date + "', " + empids[cbEmps.SelectedIndex] + ", 'Euthanasia' )", conn);
                        comm.ExecuteNonQuery();
                        String messbox = "";
                        string nl = Environment.NewLine;
                        comm = new MySqlCommand("SELECT quantity FROM items WHERE description = 'Euthanasia Injection'", conn);
                        MySqlDataAdapter adpt = new MySqlDataAdapter(comm);
                        DataTable dtttt = new DataTable();
                        adpt.Fill(dtttt);
                        comm = new MySqlCommand("SELECT quantity FROM items WHERE description = 'Syringe'", conn);
                        MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                        DataTable dttt = new DataTable();
                        adp.Fill(dttt);

                        messbox = "Successfully Euthanized All. " + nl + "Injection for Euthanasia Quantity is now: " + dtttt.Rows[0]["quantity"].ToString() + nl + "Syringe Quantity is now: " + dttt.Rows[0]["quantity"].ToString();

                        MessageBox.Show(messbox);
                        conn.Close();
                        refreshArchive();
                    }
                    else
                    {
                        MessageBox.Show("Running Out of Euthanasia Injection/Syringe. Cannot Euthanize Dog", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Select an Employee");
            }
        }

        private void tbBreedSearch_TextChanged(object sender, EventArgs e)
        {
            refreshSearch();
            if(cbGenderSearch.Text != "") refreshSearchWithGender();
        }

        private void tbColorSearch_TextChanged(object sender, EventArgs e)
        {
            refreshSearch();
            if (cbGenderSearch.Text != "") refreshSearchWithGender();
        }

        private void cbGenderSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshSearchWithGender();
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
            home.refreshNotif();
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string f = "Arial";
            int fsize = 14;
            e.Graphics.DrawString("Republic of the Philippines", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(300, 50));
            e.Graphics.DrawString("City of Davao", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(355, 70));
            e.Graphics.DrawString("DAVAO CITY DOG POUND", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(235, 100));
            e.Graphics.DrawString("MONTHLY CONSOLIDATED ACCOMPLISHMENT REPORT", new System.Drawing.Font(f, 18, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(65, 130));
            e.Graphics.DrawString("For the Month of  " + m1.Text + " " + d1.Text + ", " + y1.Text + " - " + m2.Text + " " + d2.Text + ", " + y2.Text, new System.Drawing.Font(f, 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(100, 170));

            e.Graphics.DrawString("Total number of heads impounded:   ", new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(195, 240));
            e.Graphics.DrawString("Total number of heads claimed:     ", new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(195, 280));
            e.Graphics.DrawString("Total number of heads adopted:     ", new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(195, 320));
            e.Graphics.DrawString("Total amount from transactions:    ", new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(195, 360));
            e.Graphics.DrawString("Total number of heads euthanized:  ", new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(195, 400));
            e.Graphics.DrawString("Total number of heads alive:       ", new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(195, 440));
            e.Graphics.DrawString("Total number of heads vaccinated:  ", new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(195, 480));
            e.Graphics.DrawString("Vaccinators: ", new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(200, 520));

            int x = 520;
            for (int i = 0; i < vaccinators.Length; i++)
            {
                x = x + 20;
                e.Graphics.DrawString(vaccinators[i], new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(315, x));
                e.Graphics.DrawString(vaccinecount[i].ToString(), new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(540, x));
            }

            e.Graphics.DrawString("No. of clients served:    ", new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(195, x + 40));
            e.Graphics.DrawString("* Remarks: ", new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(195, x + 80));

            e.Graphics.DrawString("" + impounded, new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(565, 240));
            e.Graphics.DrawString("" + claimed, new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(565, 280));
            e.Graphics.DrawString("" + adopted, new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(565, 320));
            e.Graphics.DrawString("" + amount, new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(565, 360));
            e.Graphics.DrawString("" + euthanized, new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(565, 400));
            e.Graphics.DrawString("" + alive, new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(565, 440));
            e.Graphics.DrawString("" + vaccinated, new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(565, 480));
            e.Graphics.DrawString("" + clients, new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(565, x + 40));
            e.Graphics.DrawString("", new System.Drawing.Font(f, fsize, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(565, x + 80));

        }
        //IMPOUNDING SUMMARY REPORT
        int impounded, claimed, adopted, amount, euthanized, alive, vaccinated, clients;
        string[] vaccinators; //employees
        int[] vaccinecount;   //vaccine count per employee
                              //EX. vaccinators[i] has vaccinecount[i] vaccines for the specified date range
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button16.Visible = true;
            if (filt.Text != "Status" && m1.Text != "Month" && m2.Text != "Month" && y1.Text != "Year" && d1.Text != "Day")
            {
                int year = int.Parse(DateTime.Now.ToString("yyyy"));
                int month = int.Parse(DateTime.Now.ToString("MM"));
                int day = int.Parse(DateTime.Now.ToString("dd"));
                string datestart = y1.Text + "-" + (m1.SelectedIndex + 1).ToString() + "-" + d1.Text;
                string dateend = y1.Text + "-" + (m2.SelectedIndex + 1).ToString() + "-" + d2.Text;
                try
                {
                    MySqlCommand comm;
                    MySqlDataAdapter adp;
                    System.Data.DataTable dt = new System.Data.DataTable(); ;

                    conn.Open();
                    
                    if (filt.SelectedIndex == 0) //Claimed
                    {
                        button16.Enabled = true;
                        claimreportdgv.Visible = true;
                        panelSummary.Visible = false;
                        comm = new MySqlCommand("SELECT CONCAT(firstname, ' ', SUBSTRING(middlename, 1, 1), '.', ' ', lastname) AS 'Claimer', breed AS Breed, color AS Color, dogprofile.gender AS Gender, otherDesc AS Markings, dogprofile.size AS Size, SUBSTRING(dogoperation.date, 1, 11) AS 'Date Caught', "
                                        + "CONCAT(dogoperation.timeStart, '-', dogoperation.timeEnd) AS 'Time Caught', sublocation AS Location, "
                                        + "contactNumber AS 'Contact Number', address AS Address "
                                        + "FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID "
                                        + "INNER JOIN location ON dogoperation.locationID = location.locationID "
                                        + "INNER JOIN dogtransaction ON dogprofile.dogID = dogtransaction.dogID "
                                        + "INNER JOIN profile ON dogtransaction.personID = profile.personID "
                                        + "WHERE dogprofile.status = 'claimed' AND dogoperation.date BETWEEN '" + datestart + "' AND '" + dateend + "' ORDER BY dogtransaction.date", conn);
                        adp = new MySqlDataAdapter(comm);
                        dtclaim = new DataTable();
                        adp.Fill(dtclaim);
                        claimreportdgv.DataSource = dtclaim;
                    }
                    else if (filt.SelectedIndex == 1) //Adopted
                    {
                        button16.Enabled = true;
                        claimreportdgv.Visible = true;
                        panelSummary.Visible = false;
                        comm = new MySqlCommand("SELECT CONCAT(firstname, ' ', SUBSTRING(middlename, 1, 1), '.', ' ', lastname) AS 'Adopter', breed AS Breed, color AS Color, dogprofile.gender AS Gender, otherDesc AS Markings, dogprofile.size AS Size, SUBSTRING(dogoperation.date, 1, 11) AS 'Date Caught', "
                                        + "CONCAT(dogoperation.timeStart, '-', dogoperation.timeEnd) AS 'Time Caught', sublocation AS Location, "
                                        + "contactNumber AS 'Contact Number', address AS Address "
                                        + "FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID "
                                        + "INNER JOIN location ON dogoperation.locationID = location.locationID "
                                        + "INNER JOIN dogtransaction ON dogprofile.dogID = dogtransaction.dogID "
                                        + "INNER JOIN profile ON dogtransaction.personID = profile.personID "
                                        + "WHERE dogprofile.status = 'adopted' AND dogoperation.date BETWEEN '" + datestart + "' AND '" + dateend + "' ORDER BY dogtransaction.date", conn);
                        adp = new MySqlDataAdapter(comm);
                        dtadopt = new DataTable();
                        adp.Fill(dtadopt);
                        claimreportdgv.DataSource = dtadopt;
                    }
                    else if (filt.SelectedIndex == 2)//Euthanized
                    {
                        button16.Enabled = true;
                        claimreportdgv.Visible = true;
                        panelSummary.Visible = false;
                        comm = new MySqlCommand("SELECT breed AS Breed, color AS Color, size AS Size, dogprofile.gender AS Gender, otherDesc AS Markings, "
                                                +"SUBSTRING(dogoperation.date, 1, 11) AS 'Date Caught', CONCAT(timeStart, '-', timeEnd) AS 'Time Caught', "
                                                + "sublocation AS Location, CONCAT(firstname, ' ', SUBSTRING(middlename, 1, 1), '. ', lastname) AS Employee, "
                                                + "SUBSTRING(dogtransaction.date, 1, 11) AS 'Date Euthanized' "
                                                + "FROM dogprofile "
                                                + "INNER JOIN dogoperation ON dogprofile.operationID = dogoperation.operationID "
                                                + "INNER JOIN location ON location.locationID = dogoperation.locationID "
                                                + "INNER JOIN dogtransaction ON dogtransaction.dogID = dogprofile.dogID "
                                                + "INNER JOIN profile ON dogtransaction.personID = profile.personID "
                                                + "WHERE dogprofile.status = 'euthanized' AND dogoperation.date "
                                                + "BETWEEN '" + datestart+"' AND '"+dateend+ "' "
                                                + "ORDER BY dogoperation.date DESC", conn);
                        adp = new MySqlDataAdapter(comm);
                        dteut = new DataTable();
                        adp.Fill(dteut);
                        claimreportdgv.DataSource = dteut;

                        comm = new MySqlCommand("SELECT ");
                    }
                    else if (filt.SelectedIndex == 3)
                    {
                        button16.Enabled = true;
                        MySqlCommand commm = new MySqlCommand("SELECT COUNT(dogID) AS c FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID "
                                                                + "WHERE dogoperation.date  BETWEEN '" + datestart + "' AND '" + dateend + "'", conn);
                        MySqlDataAdapter adpp = new MySqlDataAdapter(commm); System.Data.DataTable dtt = new System.Data.DataTable(); adpp.Fill(dtt);
                        impounded = int.Parse(dtt.Rows[0]["c"].ToString());

                        MySqlCommand commmm = new MySqlCommand("SELECT COUNT(dogID) AS c FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID "
                                                                + "WHERE dogoperation.date  BETWEEN '" + datestart + "' AND '" + dateend + "' "
                                                                + "AND dogprofile.status = 'claimed'", conn);
                        adpp = new MySqlDataAdapter(commmm); dtt = new System.Data.DataTable(); adpp.Fill(dtt);
                        claimed = int.Parse(dtt.Rows[0]["c"].ToString());

                        MySqlCommand commmmm = new MySqlCommand("SELECT COUNT(dogID) AS c FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID "
                                                                + "WHERE dogoperation.date  BETWEEN '" + datestart + "' AND '" + dateend + "' "
                                                                + "AND dogprofile.status = 'adopted'", conn);
                        adpp = new MySqlDataAdapter(commmmm); dtt = new System.Data.DataTable(); adpp.Fill(dtt);
                        adopted = int.Parse(dtt.Rows[0]["c"].ToString());

                        MySqlCommand commmmmm = new MySqlCommand("SELECT SUM(payment) AS c FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID "
                                                                + "INNER JOIN dogtransaction ON dogtransaction.dogID = dogprofile.dogID WHERE dogtransaction.date  "
                                                                + "BETWEEN '" + datestart + "' AND '" + dateend + "'", conn);
                        adpp = new MySqlDataAdapter(commmmmm); dtt = new System.Data.DataTable(); adpp.Fill(dtt);
                        amount = int.Parse(dtt.Rows[0]["c"].ToString());

                        MySqlCommand commmmmmm = new MySqlCommand("SELECT COUNT(dogID) AS c FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID "
                                                                    + "WHERE dogoperation.date  BETWEEN '" + datestart + "' AND '" + dateend + "' "
                                                                    + "AND dogprofile.status = 'euthanized'", conn);
                        adpp = new MySqlDataAdapter(commmmmmm); dtt = new System.Data.DataTable(); adpp.Fill(dtt);
                        euthanized = int.Parse(dtt.Rows[0]["c"].ToString());

                        MySqlCommand commmmmmmm = new MySqlCommand("SELECT COUNT(dogID) AS c FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID "
                                                                    + "WHERE dogoperation.date  BETWEEN '" + datestart + "' AND '" + dateend + "' "
                                                                    + "AND dogprofile.status = 'unclaimed'", conn);
                        adpp = new MySqlDataAdapter(commmmmmmm); dtt = new System.Data.DataTable(); adpp.Fill(dtt);
                        alive = int.Parse(dtt.Rows[0]["c"].ToString());

                        MySqlCommand commmmmmmmm = new MySqlCommand("SELECT COUNT(dogID) AS c FROM dogtransaction WHERE date BETWEEN '" + datestart + "' AND '" + dateend + "' AND vaccine = 1", conn);
                        adpp = new MySqlDataAdapter(commmmmmmmm); dtt = new System.Data.DataTable(); adpp.Fill(dtt);
                        vaccinated = int.Parse(dtt.Rows[0]["c"].ToString());

                        MySqlCommand commmmmmmmmm = new MySqlCommand("SELECT CONCAT(firstname, ' ', SUBSTRING(middlename, 1, 1), '. ', lastname) AS name, "
                                                                    + "COUNT(profile.lastname) AS Vaccinations "
                                                                    + "FROM profile "
                                                                    + "INNER JOIN employee ON employee.employeeID = profile.personID "
                                                                    + "INNER JOIN activity ON activity.employeeID = employee.employeeID "
                                                                    + "WHERE date BETWEEN '" + datestart + "' AND '" + dateend + "' AND type = 'Vaccination' "
                                                                    + "GROUP BY name "
                                                                    + "ORDER BY Vaccinations DESC", conn);
                        adp = new MySqlDataAdapter(commmmmmmmmm);
                        System.Data.DataTable dta = new System.Data.DataTable();
                        adp.Fill(dta);
                        vaccinators = new string[dta.Rows.Count];
                        vaccinecount = new int[dta.Rows.Count];
                        for (int i = 0; i < dta.Rows.Count; i++)
                        {
                            vaccinators[i] = dta.Rows[i]["name"].ToString();
                            vaccinecount[i] = int.Parse(dta.Rows[i]["Vaccinations"].ToString());
                        }

                        MySqlCommand commmmmmmmmmm = new MySqlCommand("SELECT COUNT(client.personID) AS c FROM client "
                                                                        + "INNER JOIN dogtransaction ON dogtransaction.personID = client.personID "
                                                                        + "WHERE date BETWEEN '" + datestart + "' AND '" + dateend + "'", conn);
                        adpp = new MySqlDataAdapter(commmmmmmmmmm); dtt = new System.Data.DataTable(); adpp.Fill(dtt);
                        clients = int.Parse(dtt.Rows[0]["c"].ToString());

                        claimreportdgv.Visible = false;
                        panelSummary.Visible = true;

                        claim.Text = claimed.ToString();
                        adopt.Text = adopted.ToString();
                        euth.Text = euthanized.ToString();
                        imp.Text = impounded.ToString();
                        amt.Text = amount.ToString();
                        uncl.Text = alive.ToString();
                        vacc.Text = vaccinated.ToString();
                        client.Text = clients.ToString();
                        dgvVacc.DataSource = dta;
                    }
                    else if (filt.SelectedIndex == 4) //Unclaimed
                    {
                        button16.Enabled = false;
                        button16.Enabled = true;
                        claimreportdgv.Visible = true;
                        panelSummary.Visible = false;
                        comm = new MySqlCommand("SELECT breed AS Breed, color AS Color, size AS Size, gender AS Gender, date AS Date, "
                                                 + "CONCAT(timeStart, '-', timeEnd) AS Time, sublocation, otherDesc "
                                                 + "FROM dogprofile "
                                                 + "INNER JOIN dogoperation ON dogprofile.operationID = dogoperation.operationID "
                                                 + "WHERE dogprofile.status = 'unclaimed'", conn);
                        adp = new MySqlDataAdapter(comm);
                        DataTable dta = new DataTable();
                        adp.Fill(dta);
                        claimreportdgv.DataSource = dta;
                    }

                    claimreportdgv.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, GraphicsUnit.Pixel);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please enter required fields in correct format/value");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            print();
            claim1 = 0;
            noheader1 = false;
            adopt1 = 0;
            noheader2 = false;
            euth1 = 0;
            noheader3 = false;
        }

        //FUNCTIONS

        private void print()
        {
            if (filt.SelectedIndex == 0)
            {
                printDocument2.DefaultPageSettings.Landscape = false;
                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = printDocument2;
                ((Form)dlg).WindowState = FormWindowState.Maximized;
                dlg.ShowDialog();
            }
            else if (filt.SelectedIndex == 1)
            {
                printDocument3.DefaultPageSettings.Landscape = false;
                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = printDocument3;
                ((Form)dlg).WindowState = FormWindowState.Maximized;
                dlg.ShowDialog();
            }
            else if (filt.SelectedIndex == 2)
            {
                printDocument4.DefaultPageSettings.Landscape = false;
                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = printDocument4;
                ((Form)dlg).WindowState = FormWindowState.Maximized;
                dlg.ShowDialog();
            }
            else if (filt.SelectedIndex == 3)
            {
                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = printDocument1;
                ((Form)dlg).WindowState = FormWindowState.Maximized;
                dlg.ShowDialog();
            }
            else
            {

            }
        }


        private void addOperationsItems()
        {
            try
            {
                conn.Open();

                MySqlCommand comm = new MySqlCommand("SELECT operationID, CONCAT(timeStart, ' - ', timeEnd) AS time, MONTH(date) as month, YEAR(date) as year, DAY(date) as day, description FROM dogoperation INNER JOIN location on dogoperation.locationID = location.locationID WHERE status = 'Finished' AND DATEDIFF(NOW(), SUBSTRING(date, 1, 11)) <= 60 ORDER BY date ", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                System.Data.DataTable dt = new System.Data.DataTable();
                adp.Fill(dt);


                opid = new int[dt.Rows.Count];      //modify global array 'opid'
                int j = 0;
                for (int i = dt.Rows.Count; i >= 1; i--)
                {
                    opid[j] = int.Parse(dt.Rows[i - 1]["operationID"].ToString());  //assign opid index to operationID (array index = combobox index [synced]) 
                    string date = dt.Rows[i - 1]["month"].ToString() + '-' + dt.Rows[i - 1]["day"].ToString() + '-' + dt.Rows[i - 1]["year"].ToString();
                    string time = dt.Rows[i - 1]["time"].ToString();
                    string loc = dt.Rows[i - 1]["description"].ToString();
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

        public void refreshArchive()
        {
            cbEmps.Items.Clear();
            cbEmps.Text = "Euthanized by";
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT dogID, breed, color, gender, size, otherDesc FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID WHERE date <= DATE_ADD(NOW(), INTERVAL -3 DAY) AND dogprofile.status = 'unclaimed'", conn);
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
                dgvArchive.Columns["otherDesc"].HeaderText = "Markings";
                dgvArchive.Columns["otherDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                comm = new MySqlCommand("SELECT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS name FROM profile INNER JOIN employee ON employee.employeeID = profile.personID WHERE employee.status = 'Active'", conn);
                adp = new MySqlDataAdapter(comm);
                dt = new System.Data.DataTable();
                adp.Fill(dt);
                empids = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    empids[i] = int.Parse(dt.Rows[i]["personID"].ToString());
                    cbEmps.Items.Add(dt.Rows[i]["name"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }


        }

        public void refreshSearch()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT dogID, gender, breed, color, UCASE(size), otherDesc FROM (dogprofile INNER JOIN dogoperation ON dogprofile.operationID = dogoperation.operationID) INNER JOIN location ON location.locationID = dogoperation.locationID WHERE breed LIKE '" + tbBreedSearch.Text + "%' AND color LIKE '" + tbColorSearch.Text + "%' AND dogprofile.status = 'unclaimed' AND dogID NOT IN (SELECT dogID FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID WHERE date <= DATE_ADD(NOW(), INTERVAL -3 DAY) AND dogprofile.status = 'unclaimed')", conn);
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
                dgvProfiles.ClearSelection();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }

        }

        private void refreshSearchWithGender()
        {
            char gender;
            if (cbGenderSearch.SelectedIndex == 0) gender = 'M';
            else gender = 'F';
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT dogID, gender, breed, color, UCASE(size), otherDesc FROM (dogprofile INNER JOIN dogoperation ON dogprofile.operationID = dogoperation.operationID) INNER JOIN location ON location.locationID = dogoperation.locationID WHERE breed LIKE '" + tbBreedSearch.Text + "%' AND color LIKE '" + tbColorSearch.Text + "%' AND dogprofile.status = 'unclaimed' AND gender = '"+gender+"' AND dogID NOT IN (SELECT dogID FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID WHERE date <= DATE_ADD(NOW(), INTERVAL -3 DAY) AND dogprofile.status = 'unclaimed')", conn);
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
                dgvProfiles.ClearSelection();
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
                MySqlCommand comm = new MySqlCommand("SELECT dogID, breed, color, gender, size, otherDesc FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID WHERE dogprofile.status = 'unclaimed' AND date < DATE_ADD(NOW(), INTERVAL -3 DAY)", conn);
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
                dgvAdoption.Columns["otherDesc"].HeaderText = "Markings";
                dgvAdoption.Columns["otherDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();

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

        public void trig()
        {
            this.Close();
        }




        private void cbTransType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cbEmps_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(empids[cbEmps.SelectedIndex].ToString());
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            repclaimpan.Visible = false;
            searchDog.Visible = false;
            addDog.Visible = false;
            adoptDog.Visible = false;
            euthanizeDog.Visible = false;
            a.Visible = false;
            s.Visible = false;
            ad.Visible = false;
            et.Visible = false;
            r.Visible = false;

        }

        private void btnClearDog_Click(object sender, EventArgs e)
        {
            cbGender.Text = "Gender";
            cbSize.Text = "Size";
            tbBreed.Text = "Breed";
            tbColor.Text = "Color";
            tbDesc.Text = "Other Description";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (y1.Text.Length == 4)
            {
                m1.Enabled = true;
            }
        }

        private void m1_SelectedIndexChanged(object sender, EventArgs e)
        {
            d1.Enabled = true;
            d1.Items.Clear();
            responsiveDay(int.Parse(y1.Text));
        }
        private void m2_SelectedIndexChanged(object sender, EventArgs e)
        {
            d2.Enabled = true;
            d2.Items.Clear();
            responsiveDay2(int.Parse(y2.Text));
        }
        private void responsiveDay(int year)
        {
            int x;
            if (m1.Text == "January" || m1.Text == "March" || m1.Text == "May" || m1.Text == "July" || m1.Text == "August" || m1.Text == "October" || m1.Text == "December") loopDay(31);
            else if (m1.Text == "February") { if (year % 4 == 0) loopDay(29); else loopDay(28); }
            else loopDay(30);
        }
        private void responsiveDay2(int year)
        {
            int x;
            if (m2.Text == "January" || m2.Text == "March" || m2.Text == "May" || m2.Text == "July" || m2.Text == "August" || m2.Text == "October" || m2.Text == "December") loopDay2(31);
            else if (m2.Text == "February") { if (year % 4 == 0) loopDay2(29); else loopDay2(28); }
            else loopDay2(30);
        }
        private void loopDay(int x)
        {
            int i = 1;
            while (i <= x)
            {
                d1.Items.Add(i.ToString());
                i++;
            }
        }

        private void panelSummary_Paint(object sender, PaintEventArgs e)
        {

        }
        int claim1 = 0;
        Boolean noheader1 = false;
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int ad;
            int dog;
            //claim
            if (noheader1 == false)
            {
                e.Graphics.DrawString("Republic of the Philippines", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(300, 50));
                e.Graphics.DrawString("City of Davao", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(355, 70));
                e.Graphics.DrawString("DAVAO CITY DOG POUND", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(235, 100));
                e.Graphics.DrawString("CLAIMED DOGS SUMMARY REPORT", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(200, 130));
                e.Graphics.DrawString("For the Month of  " + m1.Text + " " + d1.Text + ", " + y1.Text + " - " + m2.Text + " " + d2.Text + ", " + y2.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(130, 170));
                e.Graphics.DrawString("Claimer", new Font("Arial", 16, FontStyle.Underline), Brushes.Black, new Point(50, 220));
                e.Graphics.DrawString("Dog", new Font("Arial", 16, FontStyle.Underline), Brushes.Black, new Point(360, 220));
                ad = 240; dog = 240;
            }
            else
            {
                e.Graphics.DrawString("Claimer", new Font("Arial", 16, FontStyle.Underline), Brushes.Black, new Point(50, 40));
                e.Graphics.DrawString("Dog", new Font("Arial", 16, FontStyle.Underline), Brushes.Black, new Point(375, 40));
                ad = 60; dog = 60;
            }

            for (int i = 0; i < dtclaim.Rows.Count && claim1 < dtclaim.Rows.Count; i++)
            {
                
                int len = dtclaim.Rows[claim1]["Address"].ToString().Length;
                string address = dtclaim.Rows[claim1]["Address"].ToString();
                ad = dog + 10; dog = dog + 10;
                e.Graphics.DrawString("______________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, ad));
                ad = ad + 30; dog = dog + 30;
                e.Graphics.DrawString(dtclaim.Rows[claim1]["Claimer"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, ad));
                ad = ad + 20;
                e.Graphics.DrawString("Contact Number: " + dtclaim.Rows[claim1]["Contact Number"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, ad));
                ad = ad + 20;
                e.Graphics.DrawString("Address: ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, ad));
                
                int y = 0; //35
                Boolean notdone = true;
                while (notdone)
                {
                    if (len < 1) notdone = false;
                    else if (len < 25) e.Graphics.DrawString(address.Substring(y, len), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(110, ad));
                    else e.Graphics.DrawString(address.Substring(y, 25) + '-', new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(110, ad));
                    len = len - 25;
                    y = y + 25;
                    ad = ad + 20;
                }
                ad = ad + 20;
                e.Graphics.DrawString("Breed: " + dtclaim.Rows[claim1]["Breed"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(360, dog));
                e.Graphics.DrawString("Location: " + dtclaim.Rows[claim1]["Location"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(535, dog));
                dog = dog + 20;
                e.Graphics.DrawString("Color: " + dtclaim.Rows[claim1]["Color"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(360, dog));
                e.Graphics.DrawString("Date Caught: " + dtclaim.Rows[claim1]["Date Caught"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(535, dog));
                dog = dog + 20;
                e.Graphics.DrawString("Size: " + dtclaim.Rows[claim1]["Size"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(360, dog));
                e.Graphics.DrawString("Time Caught: " + dtclaim.Rows[claim1]["Time Caught"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(535, dog));
                dog = dog + 20;
                e.Graphics.DrawString("Gender: " + dtclaim.Rows[claim1]["Gender"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(360, dog));
                e.Graphics.DrawString("Markings: " + dtclaim.Rows[claim1]["Markings"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(535, dog));
                
                claim1++;
                if (ad > 1000 || dog > 1000)
                {
                    ad = ad + 10; dog = dog + 10;
                    e.Graphics.DrawString("______________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, ad));
                    e.HasMorePages = true;
                    noheader1 = true;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
                
        }
        string date;
        string time;
        string location;
        string[] employees; //employee team
        string[] sublocations; //sublocations
        DataTable dtoperation; //dogs
        private void button11_Click(object sender, EventArgs e)
        {
            op1 = 0;
            noheader4 = false;
            int operationID = -1;
            if (cbOperation.SelectedIndex >= 0)
                 operationID = opid[cbOperation.SelectedIndex];

            if (operationID >= 0)
            {
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT description AS Location, SUBSTRING(date, 1, 11) AS Date, CONCAT(timeStart, '-', timeEnd) AS Time FROM dogpound.dogoperation INNER JOIN location ON location.locationID = dogoperation.locationID WHERE dogoperation.operationID = " + opid[cbOperation.SelectedIndex], conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adp.Fill(dt);
                    location = dt.Rows[0]["Location"].ToString();
                    time = dt.Rows[0]["Time"].ToString();
                    date = dt.Rows[0]["Date"].ToString();

                    comm = new MySqlCommand("SELECT DISTINCT CONCAT(firstname, ' ', SUBSTRING(middlename, 1, 1), '.', lastname) AS Name, position AS Position FROM employee INNER JOIN profile ON profile.personID = employee.employeeID INNER JOIN operationteam ON employee.employeeID = operationTeam.employeeID INNER JOIN dogoperation ON operationteam.teamID = dogoperation.teamID WHERE dogoperation.operationID = " + opid[cbOperation.SelectedIndex] + " ORDER BY position DESC", conn);
                    adp = new MySqlDataAdapter(comm);
                    dt = new System.Data.DataTable();
                    adp.Fill(dt);

                    employees = new string[dt.Rows.Count];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        employees[i] = dt.Rows[i]["Name"].ToString() + " - " + dt.Rows[i]["Position"].ToString();
                    }

                    comm = new MySqlCommand("SELECT breed AS Breed, color AS Color, UPPER(size) AS Size, gender AS Gender, otherDesc AS Markings, sublocation AS 'Location' FROM dogprofile INNER JOIN dogoperation ON dogprofile.operationID = dogoperation.operationID WHERE dogoperation.operationID = " + opid[cbOperation.SelectedIndex], conn);
                    adp = new MySqlDataAdapter(comm);
                    dtoperation = new System.Data.DataTable();
                    adp.Fill(dtoperation);

                    MySqlCommand commm = new MySqlCommand("SELECT DISTINCT sublocation "
                                            + "FROM dogprofile "
                                            + "INNER JOIN dogoperation ON dogprofile.operationID = dogoperation.operationID "
                                            + "WHERE dogprofile.operationID = " + opid[cbOperation.SelectedIndex] + " "
                                            + "ORDER BY sublocation", conn);
                    MySqlDataAdapter adpt = new MySqlDataAdapter(commm);
                    DataTable dtt = new System.Data.DataTable();
                    adpt.Fill(dtt);
                    sublocations = new string[dtt.Rows.Count];
                    for (int i = 0; i < dtt.Rows.Count; i++)
                    {
                        sublocations[i] = dtt.Rows[i]["sublocation"].ToString();
                    }

                    conn.Close();

                    printDocument5.DefaultPageSettings.Landscape = false;
                    PrintPreviewDialog fin = new PrintPreviewDialog();
                    fin.Document = printDocument5;
                    ((Form)fin).WindowState = FormWindowState.Maximized;
                    fin.ShowDialog();

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
            } else
            {
                MessageBox.Show("Choose Operation");
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
        int adopt1 = 0;
        Boolean noheader2 = false;
        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int ad, dog;
            if (noheader2 == false) {
                e.Graphics.DrawString("Republic of the Philippines", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(300, 50));
                e.Graphics.DrawString("City of Davao", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(355, 70));
                e.Graphics.DrawString("DAVAO CITY DOG POUND", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(235, 100));
                e.Graphics.DrawString("ADOPTED DOGS SUMMARY REPORT", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(185, 130));
                e.Graphics.DrawString("For the Month of  " + m1.Text + " " + d1.Text + ", " + y1.Text + " - " + m2.Text + " " + d2.Text + ", " + y2.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(160, 170));
                e.Graphics.DrawString("Adoptor", new Font("Arial", 16, FontStyle.Underline), Brushes.Black, new Point(50, 220));
                e.Graphics.DrawString("Dog", new Font("Arial", 16, FontStyle.Underline), Brushes.Black, new Point(360, 220));
                ad = 240; dog = 240;
            }
            else
            {
                e.Graphics.DrawString("Adoptor", new Font("Arial", 16, FontStyle.Underline), Brushes.Black, new Point(50, 40));
                e.Graphics.DrawString("Dog", new Font("Arial", 16, FontStyle.Underline), Brushes.Black, new Point(375, 40));
                ad = 60; dog = 60;
            }

            for (int i = 0; i < dtadopt.Rows.Count && adopt1 < dtadopt.Rows.Count; i++)
            {
                string address = dtadopt.Rows[adopt1]["Address"].ToString();
                int len = address.Length;
                ad = dog + 10; dog = dog + 10;
                e.Graphics.DrawString("______________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, ad));
                ad = dog + 30; dog = dog + 30;
                e.Graphics.DrawString(dtadopt.Rows[adopt1]["Adopter"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, ad));
                ad = ad + 20;
                e.Graphics.DrawString("Contact Number: "+dtadopt.Rows[adopt1]["Contact Number"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, ad));
                ad = ad + 20;
                e.Graphics.DrawString("Address: ", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, ad));
                
                int y = 0; //35
                Boolean notdone = true;
                while (notdone) {
                    if (len < 1) notdone = false;
                    else if(len < 25) e.Graphics.DrawString(address.Substring(y, len), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(110, ad));
                    else e.Graphics.DrawString(address.Substring(y, 25) + '-', new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(110, ad));
                    len = len - 25;
                    y = y + 25;
                    ad = ad + 20;
                }
                ad = ad + 20;
                e.Graphics.DrawString("Breed: "+dtadopt.Rows[adopt1]["Breed"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(360, dog));
                e.Graphics.DrawString("Location: " + dtadopt.Rows[adopt1]["Location"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(535, dog));
                dog = dog + 20;
                e.Graphics.DrawString("Color: "+dtadopt.Rows[adopt1]["Color"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(360, dog));
                e.Graphics.DrawString("Date Caught: " + dtadopt.Rows[adopt1]["Date Caught"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(535, dog));
                dog = dog + 20;
                e.Graphics.DrawString("Size: "+dtadopt.Rows[adopt1]["Size"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(360, dog));
                e.Graphics.DrawString("Time Caught: " + dtadopt.Rows[adopt1]["Time Caught"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(535, dog));
                dog = dog + 20;
                e.Graphics.DrawString("Gender: "+dtadopt.Rows[adopt1]["Gender"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(360, dog));
                e.Graphics.DrawString("Markings: " + dtadopt.Rows[adopt1]["Markings"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(535, dog));
                
                adopt1++;
                if (ad > 1000 || dog > 1000)
                {
                    ad = ad + 10; dog = dog + 10;
                    e.Graphics.DrawString("______________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, ad));
                    e.HasMorePages = true;
                    noheader2 = true;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
            
        }
        int euth1 = 0;
        Boolean noheader3 = false;
        private void printDocument4_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int dog, op;
            if (noheader3 == false) {
                e.Graphics.DrawString("Republic of the Philippines", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(300, 50));
                e.Graphics.DrawString("City of Davao", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(355, 70));
                e.Graphics.DrawString("DAVAO CITY DOG POUND", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(235, 100));
                e.Graphics.DrawString("EUTHANIZED DOGS SUMMARY REPORT", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(190, 130));
                e.Graphics.DrawString("For the Month of  " + m1.Text + " " + d1.Text + ", " + y1.Text + " - " + m2.Text + " " + d2.Text + ", " + y2.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(150, 170));
                dog = 200; op = 200;
            }
            else
            {
                dog = 40; op = 40;
            }
            
            for (int i = 0; i < dteut.Rows.Count && euth1 < dteut.Rows.Count; i++)
            {
                dog = op + 30; op = op + 30;
                e.Graphics.DrawString("______________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, dog));
                dog = dog + 30; op = op + 30;
                e.Graphics.DrawString("Breed: " + dteut.Rows[euth1]["Breed"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, dog));
                dog = dog + 20;
                e.Graphics.DrawString("Gender: " + dteut.Rows[euth1]["Gender"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, dog));
                dog = dog + 20;
                e.Graphics.DrawString("Size:" + dteut.Rows[euth1]["Size"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, dog));
                dog = dog + 20;
                e.Graphics.DrawString("Color: " + dteut.Rows[euth1]["Color"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, dog));
                dog = dog + 20;
                e.Graphics.DrawString("Markings: " + dteut.Rows[euth1]["Markings"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, dog));
                dog = dog + 20;
                e.Graphics.DrawString("Location: " + dteut.Rows[euth1]["Location"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(420, op));
                op = op + 20;
                e.Graphics.DrawString("Date Caught: " + dteut.Rows[euth1]["Date Caught"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(420, op));
                op = op + 20;
                e.Graphics.DrawString("Time Caught: " + dteut.Rows[euth1]["Time Caught"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(420, op));
                op = op + 20;
                e.Graphics.DrawString("Euthanized By: " + dteut.Rows[euth1]["Employee"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(420, op));
                op = op + 20;
                e.Graphics.DrawString("Date Euthanized: " + dteut.Rows[euth1]["Date Euthanized"].ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(420, op));
                euth1++;
                if (op > 1000 || dog > 1000)
                {
                    dog = dog + 10; op = op + 10;
                    e.Graphics.DrawString("______________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, dog));
                    e.HasMorePages = true;
                    noheader3 = true;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }

            }
        }
        int op1 = 0;
        Boolean noheader4 = false;
        private void printDocument5_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string f = "Arial";
            int x;
            if (noheader4 == false) {
                e.Graphics.DrawString("Republic of the Philippines", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(300, 50));
                e.Graphics.DrawString("City of Davao", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(355, 70));
                e.Graphics.DrawString("DAVAO CITY DOG POUND", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(235, 100));
                e.Graphics.DrawString("Operation Details", new Font("Arial", 16, FontStyle.Underline), Brushes.Black, new Point(335, 150));
                e.Graphics.DrawString("Location: BRGY. " + location, new System.Drawing.Font(f, 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(100, 220));
                e.Graphics.DrawString("Sublocations: ", new System.Drawing.Font(f, 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(100, 250));
                int z = 285;
                int v = 0;
                while (v < sublocations.Length)
                {
                    e.Graphics.DrawString(sublocations[v], new System.Drawing.Font(f, 14, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(115, z));
                    v++;
                    z = z + 25;
                }
                e.Graphics.DrawString("Date:  " + date, new System.Drawing.Font(f, 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(100, 190));
                e.Graphics.DrawString("Time:  " + time, new System.Drawing.Font(f, 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(450, 190));
                e.Graphics.DrawString("Employees Involved:  ", new System.Drawing.Font(f, 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(450, 220));
                int l = 255;
                for (int i = 0; i < employees.Length; i++)
                {
                    e.Graphics.DrawString(employees[i], new System.Drawing.Font(f, 14, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(465, l));
                    l = l + 25;
                }
                if (z >= l) x = z + 40;
                else x = l + 40;
                e.Graphics.DrawString("Dogs Caught", new Font("Arial", 16, FontStyle.Underline), Brushes.Black, new Point(340, x));
                x = x + 40;
            }
            else
            {
                x = 40;
            }

            while(op1 < dtoperation.Rows.Count)
            {
                
                e.Graphics.DrawString("Breed: " + dtoperation.Rows[op1]["Breed"].ToString(), new System.Drawing.Font(f, 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, x));
                e.Graphics.DrawString("Color: " + dtoperation.Rows[op1]["Color"].ToString(), new System.Drawing.Font(f, 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(260, x));
                e.Graphics.DrawString("Markings: " + dtoperation.Rows[op1]["Markings"].ToString(), new System.Drawing.Font(f, 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(440, x));
                x = x + 20;
                e.Graphics.DrawString("Gender: " + dtoperation.Rows[op1]["Gender"].ToString(), new System.Drawing.Font(f, 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, x));
                e.Graphics.DrawString("Size: " + dtoperation.Rows[op1]["Size"].ToString(), new System.Drawing.Font(f, 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(260, x));
                e.Graphics.DrawString("Location: " + dtoperation.Rows[op1]["Location"].ToString(), new System.Drawing.Font(f, 12, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(440, x));
                x = x + 50;
                op1++;

                if (x>1000)
                {
                    e.HasMorePages = true;
                    noheader4 = true;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
            
        }
        

        private void addDog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            if (addSub.Text != "Add Sublocation") {
                subloc.Items.Add(addSub.Text);
                addSub.Text = "Add Sublocation";
            }
        }

        private void addSub_Enter(object sender, EventArgs e)
        {
            addSub.Text = "";
        }
        private void printDocument5_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void tbColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !((Keys)e.KeyChar == Keys.Space) && !((Keys)e.KeyChar == Keys.Back);
        }

        private void m1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void d1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void m2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void d2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void filt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbGenderSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbOperation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbEmps_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void y1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !((Keys)e.KeyChar == Keys.Back);
        }

        private void y2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !((Keys)e.KeyChar == Keys.Back);
        }

        private void tbBreedSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !((Keys)e.KeyChar == Keys.Space) && !((Keys)e.KeyChar == Keys.Back);
        }

        private void tbColorSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !((Keys)e.KeyChar == Keys.Space) && !((Keys)e.KeyChar == Keys.Back);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            Viewdog v = new Viewdog();
            v.ShowDialog();
        }

        private void add_Click(object sender, EventArgs e)
        {
            add.BackColor = Color.FromArgb(251, 162, 80);
            edit.BackColor = Color.FromArgb(2, 170, 145);
            pnlEditDog.Visible = false;
            pnlAddDog.Visible = true;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            edit.BackColor = Color.FromArgb(251, 162, 80);
            add.BackColor = Color.FromArgb(2, 170, 145);
            pnlAddDog.Visible = false;
            pnlEditDog.Visible = true;
            refreshEditDog();
        }
        public void refreshEditDog()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT dogID, breed, UCASE(size), gender, color, otherDesc, sublocation FROM dogprofile Where status = 'unclaimed' ", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvEditDog.DataSource = dt;

                dgvEditDog.Columns["dogID"].Visible = false;
                dgvEditDog.Columns["breed"].HeaderText = "Breed";
                dgvEditDog.Columns["color"].HeaderText = "Color";
                dgvEditDog.Columns["gender"].HeaderText = "Gender";
                dgvEditDog.Columns["otherDesc"].HeaderText = "Markings";
                dgvEditDog.Columns["UCASE(size)"].HeaderText = "Size";
                dgvEditDog.Columns["sublocation"].HeaderText = "Sublocation";
                dgvEditDog.Columns["breed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEditDog.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEditDog.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEditDog.Columns["UCASE(size)"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEditDog.Columns["otherDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEditDog.Columns["sublocation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEditDog.ClearSelection();

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvEditDog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editdog = int.Parse(dgvEditDog.Rows[e.RowIndex].Cells["dogID"].Value.ToString());
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (editdog != 0)
            {
                editdogform = new EditDog(this);
                editdogform.dogID = this.editdog;
                editdogform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a dog");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {



        }

        private void y1_Enter(object sender, EventArgs e)
        {
            y1.Text = "";
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
            y2.Text = "";
        }

        private void searchDog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHistory_Paint(object sender, PaintEventArgs e)
        {

        }
        private void finish()
        {
            
        }
    }
}

