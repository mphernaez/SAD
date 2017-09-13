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
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{
    public partial class Employee : Form
    {
        public int adminempid;
        public int adminID;
        private int y;
        private Color use;
        private int teamempid;
        private string teamname;
        private int count;
        private Boolean empty = true;
        string date;
        String d;
        String ts;
        String te;
        int location;
        int backID;
        string backname;
        int raempID;
        public empty back { get; set; }
        public MySqlConnection conn = new MySqlConnection();
        public opEdit op { get; set; }
        EditEmp emp;
        empty home;
        int actemployeeID = 0;

        public Employee(empty parent)
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
            y = -40;
            use = Color.FromArgb(253, 208, 174);
            emp = new EditEmp(this);
            home = parent;
        }

        public void trig()
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = true;

            attendance.Visible = false;

            panel2.Visible = false;
            ne.Visible = true;
            a.Visible = false;
            o.Visible = false;
            r.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = false;

            attendance.Visible = true;

            panel2.Visible = false;
            ne.Visible = false;
            a.Visible = true;
            o.Visible = false;
            r.Visible = false;


            refreshAttendance();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = false;

            attendance.Visible = false; ;

            panel2.Visible = false;
            ne.Visible = false;
            a.Visible = false;
            o.Visible = false;
            r.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = false;

            attendance.Visible = false;

            panel2.Visible = false;
            ne.Visible = false;
            a.Visible = false;
            o.Visible = false;
            r.Visible = false;

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            Timer tmr = new Timer();
            tmr.Interval = 10000;//ticks every 1 second
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
            refreshStatus();
            //this.Top = 112;// 262

        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            refreshStatus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = false;
            attendance.Visible = false;
            panel2.Visible = true;
            ne.Visible = false;
            a.Visible = false;
            o.Visible = false;
            r.Visible = true;
            repEmp.Visible = true;
        }

        private void toExcelEmp()
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = null;
            excel.Visible = true;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "From gridview";

            for (int i = 1; i < repEmp.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = repEmp.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < repEmp.Rows.Count - 1; i++)
            {
                for (int j = 0; j < repEmp.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = repEmp.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            excel.Quit();
        }

        private void tblname_Click(object sender, EventArgs e)
        {
            tblname.Clear();
        }

        private void tbmname_Click(object sender, EventArgs e)
        {
            tbmname.Clear();
        }

        private void tbfname_Click(object sender, EventArgs e)
        {
            tbfname.Clear();
        }

        private void tbbday_Click(object sender, EventArgs e)
        {
            tbbdayday.Clear();
            tbbdayyear.Clear();
        }

        private void tbaddress_Click(object sender, EventArgs e)
        {
            tbaddress.Clear();
        }

        private void tbcontactNumber_Click(object sender, EventArgs e)
        {
            tbcontactNumber.Clear();
        }

        private void refreshAttendance()
        {
            try
            {
                conn.Open();
                String date = DateTime.Now.ToString("yyyy-MM-dd");
                MySqlCommand comm = new MySqlCommand("SELECT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS name, gender, contactNumber, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE status = 'Active' AND employee.employeeID NOT IN (SELECT DISTINCT attendance.employeeID FROM attendance WHERE SUBSTRING(date, 1, 10) = '" + date + "' ORDER BY employeeID) ORDER BY lastname ASC", conn); //missing: refresh everyday (in restrictions, date should be now)
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvAttendanceIn.DataSource = dt;

                dgvAttendanceIn.Columns["personID"].Visible = false;

                dgvAttendanceIn.Columns["name"].HeaderText = "Name";
                dgvAttendanceIn.Columns["gender"].HeaderText = "Gender";
                dgvAttendanceIn.Columns["contactNumber"].HeaderText = "Contact No.";
                dgvAttendanceIn.Columns["position"].HeaderText = "Position";
                dgvAttendanceIn.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAttendanceIn.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAttendanceIn.Columns["contactNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAttendanceIn.Columns["position"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }
        private int employeeID;
        private void dgvProfiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conn.Open();
                employeeID = int.Parse(dgvAttendanceIn.Rows[e.RowIndex].Cells["personID"].Value.ToString());
                string att = DateTime.Now.ToString("yyyy-MM-dd");
                string time = DateTime.Now.ToString("HH:mm");
                MySqlCommand comm = new MySqlCommand("INSERT INTO attendance(date, employeeID, type, time) VALUES('" + att + "', " + employeeID + ", " + "1" + ", '"+time+"') ", conn);
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully Recorded Attendance!");
                refreshAttendance();
            }
            catch (ArgumentOutOfRangeException)
            {
                conn.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(2, 170, 145);
            button3.BackColor = Color.FromArgb(251, 162, 80);
            dgvAttendanceIn.Visible = true;
            dgvAttendanceOut.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(2, 170, 145);
            button10.BackColor = Color.FromArgb(251, 162, 80);

            dgvAttendanceIn.Visible = false;
            dgvAttendanceOut.Visible = true;

            refreshAttendanceOut();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(251, 162, 80);
            button12.BackColor = Color.FromArgb(2, 170, 145);
            button30.BackColor = Color.FromArgb(2, 170, 145);
            addPanel.Visible = true;
            editPanel.Visible = false;
            pnlArchive.Visible = false;
            rePopAddEmp();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(251, 162, 80);
            button11.BackColor = Color.FromArgb(2, 170, 145);
            button30.BackColor = Color.FromArgb(2, 170, 145);
            addPanel.Visible = false;
            editPanel.Visible = true;
            pnlArchive.Visible = false;
            refreshEdit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Boolean done = false;

            if (teamname == "")
            {
                MessageBox.Show("Please select an employee");
            }
            else
            {
                if (done == false)
                {
                    this.newTeam.Rows.Add(teamempid, teamname);
                    foreach (DataGridViewRow row in allEmployees.SelectedRows)
                    {
                        allEmployees.Rows.RemoveAt(row.Index);
                    }
                    newTeam.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    count = count + 1;
                    empty = false;
                    teamname = "";
                    teamempid = 0;

                }
                allEmployees.ClearSelection();
                newTeam.ClearSelection();
            }



        }

        private void button16_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.FromArgb(2, 170, 145);
            button15.BackColor = Color.FromArgb(2, 170, 145);
            button31.BackColor = Color.FromArgb(2, 170, 145);
            newOperation.Visible = true;
            pnlActivity.Visible = false;
            Operations.Visible = false;

            refreshTeam();
        }
        Boolean doneclick = false;
        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.FromArgb(251, 162, 80);
            button21.BackColor = Color.FromArgb(2, 170, 145);
            button31.BackColor = Color.FromArgb(2, 170, 145);
            newOperation.Visible = true;
            pnlActivity.Visible = false;

            Operations.Visible = false;


        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.FromArgb(251, 162, 80);
            button15.BackColor = Color.FromArgb(2, 170, 145);
            newOperation.Visible = false;
            pnlActivity.Visible = false;
            Operations.Visible = true;

            refreshOperationsView();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = true;
            addEmployee.Visible = false;

            attendance.Visible = false; ;

            ne.Visible = false;
            a.Visible = false;
            o.Visible = true;
            r.Visible = false;

        }

        public void addOperation(int teamIDs)
        {
            if (tbOpDay.Text != "Day" && tbOpYear.Text != "Year" && cbOpMonth.Text != "Month" && cbLocation.Text != "Location" && tbStarth.Text != "Time Start (hh:mm)" && tbEndh.Text != "Time End (hh:mm)")
            {
                string date = tbOpYear.Text + '-' + (cbOpMonth.SelectedIndex + 1).ToString() + "-" + tbOpDay.Text;
                string timeStart = tbStarth.Text + ":" + tbStartm.Text + cbAMPMstart.Text;
                string timeEnd = tbEndh.Text + ":" + tbEndm.Text + cbAMPMend.Text;
                string time = tbStarth.Text + ":" + tbStartm.Text + cbAMPMstart.Text + "-" + tbEndh.Text + ":" + tbEndm.Text + cbAMPMend.Text;
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT locationID FROM location WHERE description = '" + cbLocation.Text + "'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    int locID = int.Parse(dt.Rows[0]["locationID"].ToString());

                    comm = new MySqlCommand("INSERT INTO dogoperation(teamID, locationID, date, timeStart, timeEnd, status) VALUES (" + teamIDs + " , " + locID + ", '" + date + "', '" + ts + "', '" + te + "', 'Pending')", conn);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Operation Added Successfully");
                    allEmployees.Rows.Clear();
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
                MessageBox.Show("Please Enter Required Fields");
            }

        }

        public int editemployeeID;
        private void dgvEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                editemployeeID = int.Parse(dgvEdit.Rows[e.RowIndex].Cells["personID"].Value.ToString());
            }
        }

        public void refreshEdit()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT personID, lastname, firstname, middlename, gender, birthdate, contactNumber, status, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE status = 'Active' ORDER BY lastname", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvEdit.DataSource = dt;

                dgvEdit.Columns["personID"].Visible = false;
                dgvEdit.Columns["lastname"].HeaderText = "Lastname";
                dgvEdit.Columns["firstname"].HeaderText = "Firstname";
                dgvEdit.Columns["middlename"].HeaderText = "Middlename";
                dgvEdit.Columns["gender"].HeaderText = "Gender";
                dgvEdit.Columns["birthdate"].HeaderText = "Gender";
                dgvEdit.Columns["contactNumber"].HeaderText = "Contact No.";
                dgvEdit.Columns["position"].HeaderText = "Position";
                dgvEdit.Columns["status"].HeaderText = "Status";
                dgvEdit.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEdit.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEdit.Columns["middlename"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEdit.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEdit.Columns["contactNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEdit.Columns["position"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEdit.Columns["birthdate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEdit.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {


            if (editemployeeID != 0)
            {
                emp.Show();
                emp.employeeID = this.editemployeeID;
                emp.TopMost = true;
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT personID, address, gender, MONTH(birthdate), DAY(birthdate), YEAR(birthdate), status, position, lastname, middlename, firstname, contactNumber FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE employee.employeeID = " + editemployeeID, conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    string gender = dt.Rows[0]["gender"].ToString();
                    if (gender == "F")
                    {
                        emp.cbgender.Text = "Female";
                    }
                    else
                    {
                        emp.cbgender.Text = "Male";
                    }

                    emp.cbgender.Text = dt.Rows[0]["gender"].ToString();
                    emp.tbbday.Text = dt.Rows[0]["YEAR(birthdate)"].ToString() + "-" + dt.Rows[0]["MONTH(birthdate)"].ToString() + "-" + dt.Rows[0]["DAY(birthdate)"].ToString();

                    emp.cbposition.Text = dt.Rows[0]["position"].ToString();
                    emp.tblname.Text = dt.Rows[0]["lastname"].ToString();
                    emp.tbfname.Text = dt.Rows[0]["firstname"].ToString();
                    emp.tbmname.Text = dt.Rows[0]["middlename"].ToString();
                    emp.tbcontactNumber.Text = dt.Rows[0]["contactNumber"].ToString();
                    emp.id = int.Parse(dt.Rows[0]["personID"].ToString());
                    emp.tbaddress.Text = dt.Rows[0]["address"].ToString();
                    if (dt.Rows[0]["position"].ToString() == "Admin")
                    {
                        comm = new MySqlCommand("SELECT username, password FROM admin WHERE employeeID = " + editemployeeID, conn);
                        adp = new MySqlDataAdapter(comm);
                        DataTable dta = new DataTable();
                        adp.Fill(dta);

                        emp.tbUserEdit.Text = dta.Rows[0]["username"].ToString();
                        emp.tbPassEdit.Text = dta.Rows[0]["password"].ToString();
                    }
                    else
                    {
                        emp.pnlAdminEdit.Visible = false;
                    }

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
                refreshEdit();
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string lname = tblname.Text;
            string mname = tbmname.Text;
            string fname = tbfname.Text;

            if (tblname.Text != "Lastname" && tbmname.Text != "Middlename" && tbfname.Text != "Firstname" && tbaddress.Text != "Address" && cbgender.Text != "Gender" && tbcontactNumber.Text != "Contact Number" && cbposition.Text != "Position" && tbbdayday.Text != "Day" && tbbdayyear.Text != "Year" && cbbdaymonth.Text != "Month")
            {
                if (checkIfEmployeeExists(lname, mname, fname) == false)
                {
                    char gender;
                    if (cbgender.Text == "Female")
                    {
                        gender = 'F';
                    }
                    else
                    {
                        gender = 'M';
                    }
                    string address = tbaddress.Text;
                    string contact = tbcontactNumber.Text;


                    string bday = tbbdayyear.Text + '-' + (cbbdaymonth.SelectedIndex + 1).ToString() + '-' + tbbdayday.Text;
                    string position = cbposition.Text;

                    try
                    {
                        conn.Open();

                        MySqlCommand comm = new MySqlCommand("INSERT INTO profile(lastname, middlename, firstname, gender, address, birthdate, contactNumber) VALUES('" + lname + "', '" + mname + "', '" + fname + "', '" + gender + "', '" + address + "', '" + bday + "', '" + contact + "')", conn);
                        comm.ExecuteNonQuery();

                        comm = new MySqlCommand("SELECT MAX(personID) FROM profile", conn);
                        MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        int personID = int.Parse(dt.Rows[0]["MAX(personID)"].ToString());

                        comm = new MySqlCommand("INSERT INTO employee(employeeID, position, status) VALUES('" + personID + "', '" + position + "', 'Active')", conn);
                        comm.ExecuteNonQuery();

                        comm = new MySqlCommand("INSERT INTO admin(username, password, employeeID) VALUES('" + tbUser.Text + "', '" + tbPass.Text + "', " + personID + ")", conn);
                        comm.ExecuteNonQuery();

                        MessageBox.Show("Profile Added Successfully");
                        rePopAddEmp();

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
                    MessageBox.Show("Error: Employee already exists");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Required Fields");
            }
        }

        private void rePopAddEmp()
        {
            tblname.Text = "Lastname";
            tbmname.Text = "Middlename";
            tbfname.Text = "Firstname";
            cbgender.Text = "Gender";
            tbbdayday.Text = "Day";
            tbbdayyear.Text = "Year";
            cbbdaymonth.Text = "Month";
            tbaddress.Text = "Address";
            tbcontactNumber.Text = "Contact Number";
            cbposition.Text = "Position";

            cbposition.ForeColor = tbcontactNumber.ForeColor = tbaddress.ForeColor = tbbdayday.ForeColor = tbbdayyear.ForeColor = cbbdaymonth.ForeColor = cbgender.ForeColor = tbfname.ForeColor = tblname.ForeColor = tbmname.ForeColor = Color.Gray;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //addOperation();
        }

        private void refreshAttendanceOut()
        {
            try
            {
                conn.Open();
                String date = DateTime.Now.ToString("yyyy-MM-dd");
                MySqlCommand comm = new MySqlCommand("SELECT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS name, gender, contactNumber, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE status = 'Active' AND employee.employeeID IN (SELECT DISTINCT attendance.employeeID FROM attendance WHERE type = 1 AND SUBSTRING(date, 1, 11) = '" + date + "') AND employee.employeeID NOT IN (SELECT DISTINCT attendance.employeeID FROM attendance WHERE type = 0 AND SUBSTRING(date, 1, 11) = '" + date + "') ORDER BY lastname", conn); //missing: refresh everyday (in restrictions, date should be now)
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvAttendanceOut.DataSource = dt;

                dgvAttendanceOut.Columns["personID"].Visible = false;
                dgvAttendanceOut.Columns["name"].HeaderText = "Name";
                dgvAttendanceOut.Columns["gender"].HeaderText = "Gender";
                dgvAttendanceOut.Columns["contactNumber"].HeaderText = "Contact No.";
                dgvAttendanceOut.Columns["position"].HeaderText = "Position";
                dgvAttendanceOut.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAttendanceOut.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAttendanceOut.Columns["contactNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAttendanceOut.Columns["position"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());

            }

        }

        private void tbmname_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbmname.Text == "Middlename")
            {
                tbmname.Text = "";
                tbmname.ForeColor = Color.Black;
            }
        }

        private void tbfname_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbfname.Text == "Firstname")
            {
                tbfname.Text = "";
                tbfname.ForeColor = Color.Black;
            }
        }

        private void cbgender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbgender.Text != "Gender")
            {
                cbgender.ForeColor = Color.Black;
            }
        }

        private void tbaddress_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbaddress.Text == "Address")
            {
                tbaddress.Text = "";
                tbaddress.ForeColor = Color.Black;
            }
        }

        private void tbcontactNumber_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbcontactNumber.Text == "Contact Number")
            {
                tbcontactNumber.Text = "";
                tbcontactNumber.ForeColor = Color.Black;
            }
        }

        private void cbposition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbposition.Text != "Position") cbposition.ForeColor = Color.Black;
            if (cbposition.Text == "Admin") pnlAdmin.Visible = true;
            else pnlAdmin.Visible = false;

        }

        private void refreshTeam()
        {
            try
            {
                conn.Open();
                allEmployees.Rows.Clear();
                MySqlCommand comm = new MySqlCommand("SELECT DISTINCT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS name from operationteam JOIN profile ON personID = operationteam.employeeID  JOIN employee ON employee.employeeID = personID WHERE position = 'Catcher' AND employee.status = 'Active'  AND personID NOT IN (SELECT personID FROM profile  JOIN employee ON profile.personID = employee.employeeID JOIN operationteam ON employee.employeeID = operationteam.employeeID  JOIN dogoperation ON dogoperation.teamID = operationteam.teamID  WHERE CASE WHEN (date = '" + d + "')THEN (timeEnd > '" + ts + "' AND timestart < '" + te + "') OR (timeEnd >= '" + te + "' AND timestart <= '" + ts + "' )  END AND dogoperation.status = 'Finished')   UNION SELECT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS name FROM profile JOIN employee ON profile.personID = employee.employeeID WHERE employeeID NOT IN(SELECT employeeID FROM operationteam) AND position = 'Catcher' AND employee.status = 'Active'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    int pid = int.Parse(dt.Rows[x]["personID"].ToString());
                    string name = dt.Rows[x]["name"].ToString();
                    allEmployees.Rows.Add(pid.ToString(), name);
                }

                allEmployees.Columns["empname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                int i = 0;
                int empid;

                allEmployees.ClearSelection();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());

            }
        }

        private void allEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (int.Parse(allEmployees.Rows[e.RowIndex].Cells["pID"].Value.ToString()) != 0)
                {
                    teamempid = int.Parse(allEmployees.Rows[e.RowIndex].Cells["pID"].Value.ToString());
                    teamname = allEmployees.Rows[e.RowIndex].Cells["empname"].Value.ToString();
                }
            }
        }

        private void tblname_MouseClick(object sender, MouseEventArgs e)
        {

            if (tblname.Text == "Lastname")
            {
                tblname.Text = "";
                tblname.ForeColor = Color.Black;
            }
        }


        private void tbOpDate_Click(object sender, EventArgs e)
        {
            tbOpDay.Text = "";
            tbOpDay.ForeColor = Color.Black;
        }

        private void tbStart_Click(object sender, EventArgs e)
        {
            tbStarth.Text = "";
            tbStarth.ForeColor = Color.Black;
        }

        private void tbEnd_Click(object sender, EventArgs e)
        {
            tbEndh.Text = "";
            tbEndh.ForeColor = Color.Black;
        }

        private void newOperation_VisibleChanged(object sender, EventArgs e)
        {
            doneclick = false;

        }

        private void refreshStatus()
        {
            try
            {
                conn.Open();
                // GROUP_CONCAT(CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.')) AS team,
                String daten = DateTime.Now.ToString("yyyy-MM-dd");
                String timen = DateTime.Now.ToString("HH:mm");
                MySqlCommand comm = new MySqlCommand("UPDATE dogoperation SET status = 'OnGoing' WHERE date = '" + daten + "' AND status != 'finished' AND status != 'OnGoing' AND (timeStart = '" + timen + "' OR timeStart < '" + timen + "')", conn);
                comm.ExecuteNonQuery();
                MySqlCommand com = new MySqlCommand("UPDATE dogoperation SET status = 'Finished' WHERE date = '" + daten + "' AND status != 'finished' AND (timeEnd = '" + timen + "' OR timeEnd < '" + timen + "')", conn);
                com.ExecuteNonQuery();
                MySqlCommand co = new MySqlCommand("UPDATE dogoperation SET status = 'Finished' WHERE date < '" + daten + "' AND status != 'finished'", conn);
                co.ExecuteNonQuery();
                conn.Close();

                refreshOperationsView();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void refreshOperationsView()
        {
            dgvOperationsView.Rows.Clear();
            try
            {


                conn.Open();
                // GROUP_CONCAT(CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.')) AS team,
                MySqlCommand comm;
                if (date == null)
                {
                    comm = new MySqlCommand("SELECT teamID, operationID, SUBSTRING(date, 1, 11) as date, timeStart, timeEnd, description, status FROM dogoperation INNER JOIN location ON location.locationID = dogoperation.locationID ORDER BY date, timeStart", conn);
                }
                else
                {
                    comm = new MySqlCommand("SELECT teamID, operationID, SUBSTRING(date, 1, 11) as date, timeStart, timeEnd, description, status FROM dogoperation INNER JOIN location ON location.locationID = dogoperation.locationID WHERE date = '" + date + "' ORDER BY  date, timeStart", conn);
                    date = null;
                }

                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                //dgvOperationsView.DataSource = dt;

                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    int teamID = int.Parse(dt.Rows[x]["teamID"].ToString());
                    int opID = int.Parse(dt.Rows[x]["operationID"].ToString());
                    MySqlCommand commm = new MySqlCommand("SELECT CONCAT(lastname, ', ', Firstname) AS emp FROM operationteam INNER JOIN profile on profile.personID = operationteam.employeeID WHERE teamID = " + teamID.ToString(), conn);
                    MySqlDataAdapter adpt = new MySqlDataAdapter(commm);
                    DataTable dta = new DataTable();
                    adpt.Fill(dta);
                    string team = "";
                    for (int j = 0; j < dta.Rows.Count; j++)
                    {
                        string nl = Environment.NewLine;
                        team = team + dta.Rows[j]["emp"].ToString() + nl;
                    }
                    string loc = dt.Rows[x]["description"].ToString();
                    string date = dt.Rows[x]["date"].ToString();
                    string start = dt.Rows[x]["timeStart"].ToString();
                    string end = dt.Rows[x]["timeEnd"].ToString();
                    string status = dt.Rows[x]["status"].ToString();
                    dgvOperationsView.Rows.Add(teamID.ToString(), opID.ToString(), loc, date, start, end, team, status);
                }

                dgvOperationsView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvOperationsView.Columns["opTeam"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvOperationsView.Columns["opLocation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvOperationsView.Columns["opDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvOperationsView.Columns["opStart"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvOperationsView.Columns["opEnd"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvOperationsView.Columns["opTeam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvOperationsView.Columns["opStatus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                int i = 0;
                while (i < dgvOperationsView.RowCount)
                {

                    if (dgvOperationsView.Rows[i].Cells["opStatus"].Value.ToString() == "Pending")
                    {
                        dgvOperationsView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 140);
                    }
                    else if (dgvOperationsView.Rows[i].Cells["opStatus"].Value.ToString() == "OnGoing")
                    {
                        dgvOperationsView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(146, 232, 191);
                    }
                    i++;
                }

                dgvOperationsView.ClearSelection();


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            viewAct view = new viewAct();
            view.Show();
            view.TopMost = true;
        }

        private Boolean checkIfEmployeeExists(string lastname, string middlename, string firstname)
        {
            Boolean exist = false;
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT COUNT(*) FROM profile INNER JOIN employee ON employee.employeeID = profile.personID WHERE lastname = '" + lastname + "' AND middlename = '" + middlename + "' AND firstname = '" + firstname + "'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                int num = int.Parse(dt.Rows[0]["COUNT(*)"].ToString());

                if (num != 0)
                {
                    exist = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
            return exist;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Viewemp view = new Viewemp();
            view.Show();
            view.TopMost = true;
        }

        private void tbStartm_Enter(object sender, EventArgs e)
        {
            tbStartm.Text = "";
        }

        private void tbEndm_Enter(object sender, EventArgs e)
        {
            tbEndm.Text = "";
        }

        private void tbUser_Enter(object sender, EventArgs e)
        {
            tbUser.Text = "";
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            tbPass.Text = "";
        }

        private void tbbdayday_Enter(object sender, EventArgs e)
        {
            tbbdayday.Text = "";
        }

        private void tbbdayyear_Enter(object sender, EventArgs e)
        {
            tbbdayyear.Text = "";
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            tbOpDay.Items.Clear();
            empty = true;
            int teamid = 0;
            int empID = 0;
            List<int> empss = new List<int>();
            for (int i = 0; i < newTeam.Rows.Count; i++)
            {
                empID = int.Parse(newTeam.Rows[i].Cells["personID"].Value.ToString());
                empss.Add(empID); ;
            }
            int[] emps = empss.ToArray();
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT COUNT(*) FROM operationteam", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                int count = int.Parse(dt.Rows[0]["COUNT(*)"].ToString());
                Boolean flag = false;

                if (count > 0) //naay existing team
                {
                    MySqlCommand commm = new MySqlCommand("SELECT MAX(teamID) FROM operationteam", conn);
                    MySqlDataAdapter adpt = new MySqlDataAdapter(commm);
                    DataTable dta = new DataTable();
                    adpt.Fill(dta);
                    teamid = int.Parse(dta.Rows[0]["MAX(teamID)"].ToString()) + 1;
                    conn.Close();
                    int check = checkIfTeamExists(emps, teamid - 1); //number of team
                    int parameter = 0;

                    if (check != 0) //team exists
                    {
                        parameter = check;
                        conn.Close();
                        addOperation(parameter);
                    }
                    else if (check == 0)
                    { //team doesnt exist yet
                        conn.Open();
                        MySqlCommand commmm;
                        Array.Sort(emps);
                        for (int i = 0; i < emps.Length; i++)
                        {
                            commmm = new MySqlCommand("INSERT INTO operationteam(teamID, employeeID) VALUES(" + teamid + ", " + emps[i] + ")", conn);
                            commmm.ExecuteNonQuery();
                        }
                        conn.Close();
                        addOperation(teamid);
                    }
                    conn.Close();
                }
                else
                {
                    MySqlCommand commm;
                    for (int i = 0; i < emps.Length; i++)
                    {
                        commm = new MySqlCommand("INSERT INTO operationteam(teamID, employeeID) VALUES(1, " + emps[i] + ")", conn);
                        commm.ExecuteNonQuery();
                    }
                }
                newTeam.Rows.Clear();
                allEmployees.DataSource = null;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
            clearAddOperation();

        }

        private void clearAddOperation()
        {
            allEmployees.Refresh();
            pOperation.Enabled = true;
            pteam.Enabled = false;
            tbOpYear.Text = "Year";
            cbOpMonth.Text = "Month";
            tbOpDay.Items.Clear();
            tbOpDay.Text = "Day";
            cbLocation.Text = "Location";
            tbStarth.Text = "00";
            tbStartm.Text = "00";
            tbEndh.Text = "00";
            tbEndm.Text = "00";
            cbAMPMend.Text = "AM/PM";
            cbAMPMstart.Text = "AM/PM";
            cbOpMonth.Enabled = false;
            tbOpDay.Enabled = false;
        }

        private int checkIfTeamExists(int[] emps, int max) //emps = new operation team
        {
            try
            {
                MySqlCommand comm = new MySqlCommand("SELECT teamID, employeeID FROM operationteam GROUP BY teamID", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Boolean stop = false;
                Boolean same = true;
                Array.Sort(emps);
                int i = 1;
                MySqlCommand commm;
                MySqlDataAdapter adpt;
                DataTable dta;
                while (i <= max && stop == false)//counter for team
                {
                    //commm = new MySqlCommand("SELECT COUNT(*), employeeID FROM operationteam WHERE teamID = " + i, conn);
                    //adpt = new MySqlDataAdapter(commm);
                    //dta = new DataTable();
                    //int empnum = int.Parse(dta.Rows[0]["COUNT(*)"].ToString());

                    commm = new MySqlCommand("SELECT DISTINCT employeeID FROM operationteam WHERE teamID = " + i, conn);
                    adpt = new MySqlDataAdapter(commm);
                    dta = new DataTable();
                    adpt.Fill(dta);

                    int[] employees = new int[10];
                    for (int j = 0; j < dta.Rows.Count; j++) //counter for employees inside the team
                    {
                        employees[j] = int.Parse(dta.Rows[0]["employeeID"].ToString());
                    }
                    Array.Sort(employees);
                    Array.Sort(emps);

                    if (employees.Length != emps.Length)
                    {
                        stop = true;
                        same = false;
                        return 0;
                    }
                    else
                    {
                        for (int y = 0; y < dta.Rows.Count && same == true; y++)
                        {
                            if (employees[y] == emps[y]) same = true;
                            else same = false;
                        }
                    }
                    i++;

                }
                if (same == true) { stop = true; return i; }
                else return 0;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return 0;
            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            home.openDog();
            this.Hide();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            home.openInv();
            this.Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.hom = home;
            log.Show();
            this.trig();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int year = int.Parse(textBox2.Text);
            int month = comboBox2.SelectedIndex + 1;
            int day = int.Parse(textBox3.Text);
            date = year + "-" + month + "-" + day;
            refreshOperationsView();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            dgvOperationsView.Rows.Clear();
            refreshOperationsView();
            refreshStatus();
        }

        private void dgvOperationsView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int operation;
            try
            {
                conn.Open();
                operation = int.Parse(dgvOperationsView.Rows[e.RowIndex].Cells["operationID"].Value.ToString());

                if (dgvOperationsView.Rows[e.RowIndex].Cells["opStatus"].Value.ToString() == "Pending")
                {
                    MySqlCommand comm = new MySqlCommand("UPDATE dogoperation SET status = 'OnGoing', timeStart = '" + DateTime.Now.ToString("HH:mm") + "' WHERE operationID = " + operation, conn);

                    comm.ExecuteNonQuery();
                }
                else if (dgvOperationsView.Rows[e.RowIndex].Cells["opStatus"].Value.ToString() == "OnGoing")
                {
                    MySqlCommand comm = new MySqlCommand("UPDATE dogoperation SET status = 'Finished', timeEnd = '" + DateTime.Now.ToString("HH:mm") + "' WHERE operationID = " + operation, conn);
                    comm.ExecuteNonQuery();
                }

                conn.Close();
                refreshOperationsView();
            }
            catch (ArgumentOutOfRangeException)
            {
                conn.Close();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (cbOpMonth.Text != "Month" && tbOpDay.Text != "Day" && tbOpYear.Text != "Year" && tbStarth.Text != "00" && tbEndh.Text != "00" && cbLocation.Text != "Location" && cbAMPMend.Text != "AM/PM" && cbAMPMstart.Text != "AM/PM")
            {
                d = tbOpYear.Text + "-" + (cbOpMonth.SelectedIndex + 1).ToString() + "-" + tbOpDay.Text;

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

                ts = hss + ":" + tbStartm.Text;
                te = hee + ":" + hee;
                location = cbLocation.SelectedIndex;
                String da = d + " " + ts;
                DateTime myDate = Convert.ToDateTime(da);
                DateTime cD = DateTime.Now;
                int result = DateTime.Compare(myDate, cD);
                if (result > 0)
                {

                    {
                        pteam.Enabled = true;
                        pOperation.Enabled = false;


                        //MessageBox.Show(d + ts + te + location);

                        refreshTeam();
                    }

                }
                else
                {
                    MessageBox.Show("Please Input Valid Date & Time");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Required Fields");
            }

        }

        private void tbOpDate_Enter(object sender, EventArgs e)
        {
            tbOpDay.Text = "";
        }

        private void tbOpYear_Enter(object sender, EventArgs e)
        {
            tbOpYear.Text = "";
            //responsiveDay();
        }

        private void tbStarth_Enter(object sender, EventArgs e)
        {
            tbStarth.Text = "";
        }

        private void tbEndh_Enter(object sender, EventArgs e)
        {
            tbEndh.Text = "";
        }

        private void tbStartm_Enter_1(object sender, EventArgs e)
        {
            tbStartm.Text = "";
        }

        private void tbEndm_Enter_1(object sender, EventArgs e)
        {
            tbEndm.Text = "";
        }

        private void dgvAttendanceOut_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                conn.Open();
                employeeID = int.Parse(dgvAttendanceIn.Rows[e.RowIndex].Cells["personID"].Value.ToString());
                string att = DateTime.Now.ToString("yyyy-MM-dd");
                string time = DateTime.Now.ToString("HH:mm");
                MySqlCommand comm = new MySqlCommand("INSERT INTO attendance(date, employeeID, type, time) VALUES('" + att + "', " + employeeID + ", " + "0" + ", '"+time+"') ", conn);
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully Recorded Attendance!");
                refreshAttendance();
            }
            catch (ArgumentOutOfRangeException)
            {
                conn.Close();
            }
        }

        private void cbOpMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbOpDay.Items.Clear();
            tbOpDay.Enabled = true;
            responsiveDay(int.Parse(tbOpYear.Text));
        }
        private void responsiveDay(int year)
        {
            int x;
            if (cbOpMonth.Text == "January" || cbOpMonth.Text == "March" || cbOpMonth.Text == "May" || cbOpMonth.Text == "July" || cbOpMonth.Text == "August" || cbOpMonth.Text == "October" || cbOpMonth.Text == "December") loopDay(31);
            else if (cbOpMonth.Text == "February") { if (year % 4 == 0) loopDay(29); else loopDay(28); }
            else loopDay(30);
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
            tbOpDay.Items.Clear();
            //responsiveDay(int.Parse(tbOpYear.Text));
            if (tbOpYear.Text.Length == 4)
            {
                cbOpMonth.Enabled = true;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(2, 170, 145);
            button12.BackColor = Color.FromArgb(2, 170, 145);
            button30.BackColor = Color.FromArgb(251, 162, 80);
            addPanel.Visible = false;
            editPanel.Visible = false;
            pnlArchive.Visible = true;

            refreshArchive();
        }

        private void refreshArchive()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS name, gender, address, birthdate, contactNumber, position FROM profile INNER JOIN employee ON employee.employeeID = profile.personID WHERE status = 'Inactive'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvReactivate.DataSource = dt;

                dgvReactivate.Columns["personID"].Visible = false;
                dgvReactivate.Columns["name"].HeaderText = "Name";
                dgvReactivate.Columns["gender"].HeaderText = "Gender";
                dgvReactivate.Columns["birthdate"].HeaderText = "Birthdate";
                dgvReactivate.Columns["contactNumber"].HeaderText = "Contact No.";
                dgvReactivate.Columns["address"].HeaderText = "Address";
                dgvReactivate.Columns["position"].HeaderText = "Position";
                dgvReactivate.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReactivate.Columns["Gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReactivate.Columns["Birthdate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReactivate.Columns["ContactNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReactivate.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvReactivate.Columns["Position"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            if (editemployeeID != 0)
            {
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("UPDATE employee SET status = 'Inactive' WHERE employeeID = " + editemployeeID, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
                MessageBox.Show("Successfully Inactivated");

                refreshEdit();
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (raempID != 0)
            {
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("UPDATE employee SET status = 'Active' WHERE employeeID = " + raempID.ToString(), conn);
                    comm.ExecuteNonQuery();
                    comm = new MySqlCommand("SELECT CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS name FROM profile WHERE personID = " + raempID.ToString(), conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    string name = dt.Rows[0]["name"].ToString();
                    MessageBox.Show(name + " Successfully Activated!");

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
                MessageBox.Show("Please select an employee");
            }

        }

        private void dgvReactivate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                raempID = int.Parse(dgvReactivate.Rows[e.RowIndex].Cells["personID"].Value.ToString());
            }
        }

        private void dgvAttendanceOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conn.Open();
                employeeID = int.Parse(dgvAttendanceOut.Rows[e.RowIndex].Cells["personID"].Value.ToString());
                string att = DateTime.Now.ToString("yyyy-MM-dd");
                string time = DateTime.Now.ToString("HH:mm");
                MySqlCommand comm = new MySqlCommand("INSERT INTO attendance(date, employeeID, type, time) VALUES('" + att + "', " + employeeID + ", " + "0" + ", '"+time+"') ", conn);
                comm.ExecuteNonQuery();

                string date = DateTime.Now.ToString("yyyy-MM-dd");
                MessageBox.Show("Successfully Recorded Attendance Out!");
                conn.Close();
                refreshAttendanceOut();
            }
            catch (ArgumentOutOfRangeException)
            {
                conn.Close();
            }
        }



        private void newTeam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (int.Parse(newTeam.Rows[e.RowIndex].Cells["personID"].Value.ToString()) != 0)
                {
                    backID = int.Parse(newTeam.Rows[e.RowIndex].Cells["personID"].Value.ToString());
                    backname = newTeam.Rows[e.RowIndex].Cells["name"].Value.ToString();
                }
            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            if (backname == "")
            {
                MessageBox.Show("Please select an employee");
            }
            else
            {
                this.allEmployees.Rows.Add(backID, backname);
                foreach (DataGridViewRow row in newTeam.SelectedRows)
                {
                    newTeam.Rows.RemoveAt(row.Index);
                }
                backname = "";
                backID = 0;

            }
            allEmployees.ClearSelection();
            newTeam.ClearSelection();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.BackColor = Color.FromArgb(251, 162, 80);
            button21.BackColor = Color.FromArgb(2, 170, 145);
            button15.BackColor = Color.FromArgb(2, 170, 145);
            newOperation.Visible = false;
            pnlActivity.Visible = true;

            Operations.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            pteam.Enabled = false;
            pOperation.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choice.Text == "Employees")
            {
                view.Text = "View Employee";
            }
            else if (choice.Text == "Operations")
            {
                view.Text = "View Operations";
            }
            else
            {
                MessageBox.Show("Please select type");

            }
        }

        private void button28_Click_1(object sender, EventArgs e)
        {

        }

        private void specLoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvAttendanceIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void view_Click(object sender, EventArgs e)
        {
            if (choice.Text == "Employees")
            {
                try
                {
                    conn.Open();

                    MySqlCommand com = new MySqlCommand("SELECT lastname, middlename, firstname, gender, birthdate, contactNumber, address, position, status FROM profile INNER JOIN employee ON employee.employeeID = profile.personID", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);


                    repEmp.DataSource = dt;

                    repEmp.Columns["lastname"].HeaderText = "Lastname";
                    repEmp.Columns["firstname"].HeaderText = "Firstname";
                    repEmp.Columns["middlename"].HeaderText = "Middlename";
                    repEmp.Columns["gender"].HeaderText = "Gender";
                    repEmp.Columns["birthdate"].HeaderText = "Birthdate";
                    repEmp.Columns["contactNumber"].HeaderText = "Contact No.";
                    repEmp.Columns["address"].HeaderText = "Address";
                    repEmp.Columns["position"].HeaderText = "Position";
                    repEmp.Columns["status"].HeaderText = "Status";

                    repEmp.Columns["Lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["Firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["Middlename"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["Gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["Birthdate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["ContactNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["Position"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
            else if (choice.Text == "Operations")
            {
                try
                {
                    conn.Open();
                    MySqlCommand comm;
                    if (date == null)
                    {
                        comm = new MySqlCommand("SELECT teamID, operationID, SUBSTRING(date, 1, 11) as date, timeStart, timeEnd, description, status FROM dogoperation INNER JOIN location ON location.locationID = dogoperation.locationID ORDER BY date, timeStart", conn);
                    }
                    else
                    {
                        comm = new MySqlCommand("SELECT teamID, operationID, SUBSTRING(date, 1, 11) as date, timeStart, timeEnd, description, status FROM dogoperation INNER JOIN location ON location.locationID = dogoperation.locationID WHERE date = '" + date + "' ORDER BY  date, timeStart", conn);
                        date = null;
                    }

                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    for (int x = 0; x < dt.Rows.Count; x++)
                    {
                        int teamID = int.Parse(dt.Rows[x]["teamID"].ToString());
                        int opID = int.Parse(dt.Rows[x]["operationID"].ToString());
                        MySqlCommand commm = new MySqlCommand("SELECT CONCAT(lastname, ', ', Firstname) AS emp FROM operationteam INNER JOIN profile on profile.personID = operationteam.employeeID WHERE teamID = " + teamID.ToString(), conn);
                        MySqlDataAdapter adpt = new MySqlDataAdapter(commm);
                        DataTable dta = new DataTable();
                        adpt.Fill(dta);
                        string team = "";
                        for (int j = 0; j < dta.Rows.Count; j++)
                        {
                            string nl = Environment.NewLine;
                            team = team + dta.Rows[j]["emp"].ToString() + nl;
                        }
                        string loc = dt.Rows[x]["description"].ToString();
                        string date = dt.Rows[x]["date"].ToString();
                        string start = dt.Rows[x]["timeStart"].ToString();
                        string end = dt.Rows[x]["timeEnd"].ToString();
                        string status = dt.Rows[x]["status"].ToString();
                        repEmp.Rows.Add(teamID.ToString(), opID.ToString(), loc, date, start, end, team, status);
                    }

                    repEmp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    repEmp.Columns["opTeam"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    repEmp.Columns["opLocation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["opDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["opStart"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["opEnd"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["opTeam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    repEmp.Columns["opStatus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    int i = 0;
                    while (i < repEmp.RowCount)
                    {

                        if (repEmp.Rows[i].Cells["opStatus"].Value.ToString() == "Pending")
                        {
                            repEmp.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 140);
                        }
                        else if (repEmp.Rows[i].Cells["opStatus"].Value.ToString() == "OnGoing")
                        {
                            repEmp.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(146, 232, 191);
                        }
                        i++;
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
                conn.Close();
                MessageBox.Show("Please select type of report");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Edit.Visible = true;
            refreshEditop();
        }

        int opId;
        public bool opOpen = false;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                opId = int.Parse(editOperation.Rows[e.RowIndex].Cells["eOperationID"].Value.ToString());

                if (opOpen == false)
                {
                    op = new opEdit(this);
                    opOpen = true;
                }
                op.id = opId;
                op.Show();
                                
            }
        }

        private void refreshEditop()
        {
            editOperation.Rows.Clear();
            try
            {


                conn.Open();
                // GROUP_CONCAT(CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.')) AS team,
                MySqlCommand comm;
                if (date == null)
                {
                    comm = new MySqlCommand("SELECT teamID, operationID, SUBSTRING(date, 1, 11) as date, timeStart, timeEnd, description, status FROM dogoperation INNER JOIN location ON location.locationID = dogoperation.locationID AND status = 'Pending' ORDER BY date, timeStart", conn);
                }
                else
                {
                    comm = new MySqlCommand("SELECT teamID, operationID, SUBSTRING(date, 1, 11) as date, timeStart, timeEnd, description, status FROM dogoperation INNER JOIN location ON location.locationID = dogoperation.locationID WHERE date = '" + date + "' AND status = 'Pending' ORDER BY  date, timeStart", conn);
                    date = null;
                }

                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                //dgvOperationsView.DataSource = dt;

                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    int teamID = int.Parse(dt.Rows[x]["teamID"].ToString());
                    int opID = int.Parse(dt.Rows[x]["operationID"].ToString());
                    MySqlCommand commm = new MySqlCommand("SELECT CONCAT(lastname, ', ', Firstname) AS emp FROM operationteam INNER JOIN profile on profile.personID = operationteam.employeeID WHERE teamID = " + teamID.ToString(), conn);
                    MySqlDataAdapter adpt = new MySqlDataAdapter(commm);
                    DataTable dta = new DataTable();
                    adpt.Fill(dta);
                    string team = "";
                    for (int j = 0; j < dta.Rows.Count; j++)
                    {
                        string nl = Environment.NewLine;
                        team = team + dta.Rows[j]["emp"].ToString() + nl;
                    }
                    string loc = dt.Rows[x]["description"].ToString();
                    string date = dt.Rows[x]["date"].ToString();
                    string start = dt.Rows[x]["timeStart"].ToString();
                    string end = dt.Rows[x]["timeEnd"].ToString();
                    string status = dt.Rows[x]["status"].ToString();
                    editOperation.Rows.Add(teamID.ToString(), opID.ToString(), loc, date, start, end, team, status);
                }
                
                editOperation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                editOperation.Columns["eTeamM"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                editOperation.Columns["eLocation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                editOperation.Columns["eOperationDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                editOperation.Columns["eTimeS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                editOperation.Columns["eTimeE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                editOperation.Columns["eTeamM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                editOperation.Columns["eStat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                


                editOperation.ClearSelection();


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

    }
}



