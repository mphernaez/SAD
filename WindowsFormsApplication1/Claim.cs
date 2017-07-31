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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dog.Show();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbfname.Text != "" && tbmname.Text != "" && tblname.Text != "" && tbadd.Text != "" && tbIDnum.Text != "" && tbIDtype.Text != "")
            {
                String fname = tbfname.Text;
                String mname = tbmname.Text;
                String lname = tblname.Text;
                String add = tbadd.Text;
                String idnum = tbIDnum.Text;
                String idtype = tbIDtype.Text;
                String num = tbnumber.Text;
                String date = DateTime.Now.ToString("yyyy-MM-dd");
                int vaccine = 0;
                if (checkbox.Checked)
                {
                    vaccine = 1;
                }
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("INSERT INTO profile(firstname, middlename, lastname, contactNumber, address) VALUES('" + fname + "', '" + mname + "','" + lname + "', '" + num + "', '" + add + "')", conn);
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
            else
            {
                MessageBox.Show("Please enter required fields");
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

                breed.Text = dt.Rows[0]["breed"].ToString();
                color.Text = dt.Rows[0]["color"].ToString();
                size.Text = dt.Rows[0]["size"].ToString();
                gender.Text = dt.Rows[0]["gender"].ToString();
                location.Text = "Brgy. " + dt.Rows[0]["description"].ToString();
                date.Text = dt.Rows[0]["date"].ToString().Substring(0, 10);
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
    }
}
