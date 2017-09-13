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
        String ts, te;
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
                ts = dt.Rows[0]["timeStart"].ToString();
                te = dt.Rows[0]["timeEnd"].ToString();
                
                string y = date.Substring(6, 4);
                string m = date.Substring(3, 2);
                string d = date.Substring(0, 2);

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
                    teh = (int.Parse(teh) - 12).ToString();
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
        String ndate, nts, nte;
        int nl;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cbOpMonth.Text != "Month" && tbOpDay.Text != "Day" && tbOpYear.Text != "Year" && tbStarth.Text != "00" && tbEndh.Text != "00" && cbLocation.Text != "Location" && cbAMPMend.Text != "AM/PM" && cbAMPMstart.Text != "AM/PM")
            {
                ndate = tbOpYear.Text + "-" + (cbOpMonth.SelectedIndex + 1).ToString() + "-" + tbOpDay.Text;

                int hs = int.Parse(tbStarth.Text), he = int.Parse(tbEndh.Text);
                string hss; string hee;
                if (cbAMPMstart.SelectedIndex == 1)
                {
                    hs = hs + 12;
                }
                if (cbAMPMend.SelectedIndex == 1)
                {
                    he = he + 12;
                }
                if (hs < 10)
                {
                    hss = "0" + hs.ToString();
                }
                else
                    hss = hs.ToString();
                if (he < 10)
                {
                    hee = "0" + he.ToString();
                }
                else
                    hee = he.ToString();


                if (int.Parse(tbStartm.Text) < 10 && tbStartm.Text.Substring(0, 1) != "0")
                {
                    tbStartm.Text = "0" + tbStartm.Text;
                }

                if (int.Parse(tbEndm.Text) < 10 && tbEndm.Text.Substring(0, 1) != "0")
                {
                    tbEndm.Text = "0" + tbEndm.Text;
                }
                nts = hss + ":" + tbStartm.Text;
                nte = hee + ":" + hee;
                nl = cbLocation.SelectedIndex;

                cTeam.Rows.Clear();
                aEmp.Rows.Clear();

                string dd = ndate + " " + nts;
                DateTime myDate = Convert.ToDateTime(dd);
                DateTime cD = DateTime.Now;
                int result = DateTime.Compare(myDate, cD);
                if (result > 0)
                {

                    {
                        panel2.Enabled = true;
                        panel1.Enabled = false;
                        getTeam();
                        getEmps();
                        
                    }

                }
                else
                {
                    MessageBox.Show("Please Input Valid Date & Time");
                }


               

            }
        }


        private void getTeam()
        {
            List<int> nums = new List<int>();
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT DISTINCT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS Name FROM dogoperation JOIN operationteam ON dogoperation.teamID = operationteam.teamID JOIN profile on employeeID = personID WHERE operationteam.teamID = " + tID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    int pid = int.Parse(dt.Rows[x]["personID"].ToString());
                    string name = dt.Rows[x]["name"].ToString();
                    cTeam.Rows.Add(pid.ToString(), name);
                }
                if (DateTime.Now.ToString("yyy-MM-dd") == Convert.ToDateTime(ndate).ToString("yyy-MM-dd"))
                {
                    MySqlCommand com = new MySqlCommand("SELECT employeeID FROM attendance WHERE date = '"+ ndate + "' AND type = 1", conn);
                    MySqlDataAdapter adpp = new MySqlDataAdapter(com);
                    DataTable dtt = new DataTable();
                    adpp.Fill(dtt);

                   
                    cTeam.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    for (int i = 0; i < dtt.Rows.Count; i++)
                    {
                        nums.Add(int.Parse(dtt.Rows[i]["employeeID"].ToString()));
                    }
                    for (int i = 0; i < cTeam.Rows.Count; i++)
                    {

                        for (int j = 0; j < nums.Count; j++)
                        {
                            if (int.Parse(cTeam.Rows[i].Cells["pID"].Value.ToString()) == nums[j])
                            {
                                cTeam.Rows[i].DefaultCellStyle.BackColor = Color.White;
                                break;
                            }
                            else
                            {
                                cTeam.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(229, 99, 82);
                            }
                        }
                        if(nums.Count == 0)
                        {
                            for (int j = 0; j < cTeam.Rows.Count; j++)
                            {
                               cTeam.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(229, 99, 82);

                            }
                        }

                    }

                }

                
                cTeam.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                cTeam.ClearSelection();

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
                convert();
                conn.Open();
                MySqlCommand comm;
                if (DateTime.Now.ToString("yyy-MM-dd") != Convert.ToDateTime(ndate).ToString("yyy-MM-dd"))
                {
                    comm = new MySqlCommand("SELECT DISTINCT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS name from operationteam JOIN profile ON personID = operationteam.employeeID  JOIN employee ON employee.employeeID = personID WHERE position = 'Catcher' AND employee.status = 'Active'  AND personID NOT IN (SELECT personID FROM profile  JOIN employee ON profile.personID = employee.employeeID JOIN operationteam ON employee.employeeID = operationteam.employeeID  JOIN dogoperation ON dogoperation.teamID = operationteam.teamID  WHERE CASE WHEN (date = '"+ndate+"') THEN (timeEnd > '" + ts + "' AND timestart < '" + te + "') OR (timeEnd >= '" + te + "' AND timestart <= '" + ts + "' )  END OR operationteam.teamID = " + tID + ")   UNION SELECT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS name FROM profile JOIN employee ON profile.personID = employee.employeeID WHERE employeeID NOT IN(SELECT employeeID FROM operationteam) AND position = 'Catcher' AND employee.status = 'Active'", conn);
                }
                else
                {
                    comm = new MySqlCommand("SELECT DISTINCT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS name from operationteam JOIN profile ON personID = operationteam.employeeID  JOIN employee ON employee.employeeID = personID JOIN attendance ON attendance.employeeID = personID WHERE position = 'Catcher' AND employee.status = 'Active'  AND personID NOT IN (SELECT personID FROM profile  JOIN employee ON profile.personID = employee.employeeID JOIN operationteam ON employee.employeeID = operationteam.employeeID  JOIN dogoperation ON dogoperation.teamID = operationteam.teamID  WHERE CASE WHEN (date = '" + ndate + "')THEN (timeEnd > '" + ts + "' AND timestart < '" + te + "') OR (timeEnd >= '" + te + "' AND timestart <= '" + ts + "' )  END OR operationteam.teamID = " + tID + " ) AND attendance.date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND type = 1  AND personID NOT IN (SELECT employeeID FROM attendance WHERE date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND type = 0) UNION SELECT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS name FROM profile JOIN employee ON profile.personID = employee.employeeID JOIN attendance ON attendance.employeeID = personID WHERE personID NOT IN(SELECT employeeID FROM operationteam) AND position = 'Catcher' AND employee.status = 'Active' AND attendance.date = '" + ndate + "' AND type = 0 AND personID NOT IN (SELECT employeeID FROM attendance WHERE date = '" + ndate + "' AND type = 0)", conn);
                }
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    int pid = int.Parse(dt.Rows[x]["personID"].ToString());
                    string name = dt.Rows[x]["name"].ToString();
                    aEmp.Rows.Add(pid.ToString(), name);
                }
                aEmp.Columns["Name1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                aEmp.ClearSelection();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }


        private void convert()
        {
            if (int.Parse(tsh) < 10)
            {
                tsh = "0" + tsh.ToString();
            }
            if (int.Parse(teh) < 10)
            {
                teh = "0" + teh.ToString();
            }



            if (int.Parse(tbStartm.Text) < 10 && tbStartm.Text.Substring(0, 1) != "0")
            {
                tbStartm.Text = "0" + tbStartm.Text;
            }

            if (int.Parse(tbEndm.Text) < 10 && tbEndm.Text.Substring(0, 1) != "0")
            {
                tbEndm.Text = "0" + tbEndm.Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (okct)
            {


                if(cTeam.Rows[rft].DefaultCellStyle.BackColor != Color.FromArgb(229, 99, 82))
                {
                    this.aEmp.Rows.Add(ti1, n1);
                }

                    cTeam.Rows.RemoveAt(rft);


                cTeam.ClearSelection();
                aEmp.ClearSelection();
                okct = false;
            } else
            {
                MessageBox.Show("Please Select an Employee");
            }


        }

        private void button19_Click(object sender, EventArgs e)
        {
            cTeam.ClearSelection();
            aEmp.ClearSelection();

            if (okae)
            {



                this.cTeam.Rows.Add(ti2, n2);

                    aEmp.Rows.RemoveAt(att);

                
                okct = false;
            }
            else
            {
                MessageBox.Show("Please Select an Employee");
            }
        }

        int rft, att;
        bool okct = false, okae = false;
        private void aEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                att = e.RowIndex;
                okae = true;
                ti2 = int.Parse(aEmp.Rows[e.RowIndex].Cells["pID1"].Value.ToString());
                n2 = aEmp.Rows[e.RowIndex].Cells["Name1"].Value.ToString();

            }
        }

        private void OK1_Click(object sender, EventArgs e)
        {
            updateOp();
        }

        private void updateOp()
        {

          
            try
            {
                conn.Open();
                MySqlCommand co;
                MySqlCommand com = new MySqlCommand("SELECT MAX(teamID) FROM operationteam", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                int nt = int.Parse(dt.Rows[0]["MAX(teamID)"].ToString()) +1;
                MessageBox.Show(nt.ToString());
                int idd;
                 for(int i = 0; i < cTeam.Rows.Count; i++)
                {
                    idd = int.Parse(cTeam.Rows[i].Cells["pID"].Value.ToString());
                    co = new MySqlCommand("INSERT INTO operationteam VALUES(id, "+idd+", "+nt+")",conn);
                    co.ExecuteNonQuery();
                }


                MySqlCommand comm = new MySqlCommand("Update dogoperation SET date = '"+ndate+"', locationID = "+nl+", timeStart = '"+nts+"', teamID = "+nt+", timeEnd = '"+nte+"' WHERE operationID = " + id, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Changes Saved");
                conn.Close();
                this.Dispose();
                emp.opOpen = false;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void cTeam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                rft = e.RowIndex;
                okct = true;
                ti1 = int.Parse(cTeam.Rows[e.RowIndex].Cells["pID"].Value.ToString());
                n1 = cTeam.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
        }

        int ti1, ti2;
        String n1, n2;
        private void cTeam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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
            this.Dispose();
            emp.opOpen = false;
        }
    }
}
