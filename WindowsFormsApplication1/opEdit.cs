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
    public partial class opEdit : Form
    {
        public int id;
        MySqlConnection conn = new MySqlConnection();
       Employee emp { get; set; }
        public opEdit(Employee parent)
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
            emp = parent;
        }

        private void opEdit_Load(object sender, EventArgs e)
        {
            getInfo();
        }

        String y, m, d = null;
        int tID;
        String tsh, tsm, teh, tem = null;
        String date;
        private void getInfo()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM dogoperation WHERE operationID = " + id, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                int i = 1;
                date = dt.Rows[0]["date"].ToString();
                String ts = dt.Rows[0]["timeStart"].ToString();
                String te = dt.Rows[0]["timeEnd"].ToString();
                foreach (char a in date)
                {
                    if (a != '/' && i == 1)
                    {
                        m += a;

                    }
                    else if (a != '/' && i == 2)
                    {
                        d += a;

                    }
                    else if (a != '/' && i == 3 && a != ' ')
                    {
                        y += a;

                    }
                    else if (a == '/')
                    {
                        i++;
                    } else
                    {
                        break;
                    }


                }
                i = 0;
                
                foreach(char a in ts)
                {
                    if (i < 2)
                    {
                        tsh += a;
                    }
                    else if (i == 2)
                    {
                        i = 3;
                    }
                    else if (i < 6)
                    {
                        tsm += a;
                    }
                    i++;
                }

                i = 0;

                foreach (char a in te)
                {
                    if (i < 2)
                    {
                        teh += a;
                    }
                    else if (i == 2)
                    {
                        i = 3;
                    }
                    else if (i < 6)
                    {
                        tem += a;
                    }
                    i++;
                }
                
                tbOpYear.Text = y;
                cbOpMonth.SelectedIndex = int.Parse(m) - 1;
                responsiveDay(int.Parse(y));
                tbOpDay.SelectedIndex = int.Parse(d) - 1;
                cbLocation.SelectedIndex = int.Parse(dt.Rows[0]["locationID"].ToString()) - 1;
                tID = int.Parse(dt.Rows[0]["teamID"].ToString());

                if (int.Parse(tsh) > 12)
                {
                    cbAMPMstart.SelectedIndex = 1;
                    tsh = (int.Parse(tsh) - 12).ToString();
                }
                else
                    cbAMPMstart.SelectedIndex = 0;

                if (int.Parse(teh) > 12)
                {
                    cbAMPMend.SelectedIndex = 1;
                    te = (int.Parse(teh) - 12).ToString();
                }
                else
                    cbAMPMend.SelectedIndex = 0;

                tbStarth.Text = tsh;
                tbEndh.Text = teh;
                tbStartm.Text = tsm;
                tbEndm.Text = tem;
                conn.Close();
            } catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }

        }
        private void responsiveDay(int year)
        {
            int x;
            if (cbOpMonth.Text == "January" || cbOpMonth.Text == "March" || cbOpMonth.Text == "May" || cbOpMonth.Text == "July" || cbOpMonth.Text == "August" || cbOpMonth.Text == "October" || cbOpMonth.Text == "December") loopDay(31);
            else if (cbOpMonth.Text == "February") { if (year % 4 == 0) loopDay(29); else loopDay(28); }
            else loopDay(30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel1.Enabled = false;
            getTeam();
            getEmps();
        }


        private void getTeam()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT DISTINCT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS Name FROM dogoperation JOIN operationteam ON dogoperation.teamID = operationteam.teamID JOIN profile on employeeID = personID WHERE operationteam.teamID = " + tID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                cTeam.DataSource = dt;
                cTeam.Columns["personID"].Visible = false;
                cTeam.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();
                  
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void getEmps()
        {
            try
            {
                conn.Open();
                MySqlCommand comm;
                if (DateTime.Now.ToString("MM/dd/yyy") != date)
                {
                    comm = new MySqlCommand("SELECT DISTINCT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS Name FROM dogoperation JOIN operationteam ON dogoperation.teamID = operationteam.teamID JOIN profile on employeeID = personID WHERE personID NOT IN (SELECT personID FROM dogoperation JOIN operationteam ON dogoperation.teamID = operationteam.teamID JOIN profile on employeeID = personID WHERE operationteam.teamID = " + tID + ")", conn);

                }
                else
                {
                    comm = new MySqlCommand("SELECT DISTINCT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS Name FROM dogoperation JOIN operationteam ON dogoperation.teamID = operationteam.teamID JOIN profile on operationteam.employeeID = personID JOIN attendance ON attendance.employeeID = personID WHERE personID NOT IN (SELECT personID FROM dogoperation JOIN operationteam ON dogoperation.teamID = operationteam.teamID JOIN profile on employeeID = personID WHERE operationteam.teamID = " + tID + ") AND attendance.date = '"+date+"' AND type = 1", conn);
                }
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                aEmp.DataSource = dt;
                aEmp.Columns["personID"].Visible = false;
                aEmp.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            panel1.Enabled = true;
        }

        private void loopDay(int x)
        {
            int i = 1;
            while (i <= x)
            {
                tbOpDay.Items.Add(i.ToString());
                i++;
            }
        }
        private void tbOpYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbOpMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbOpDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
