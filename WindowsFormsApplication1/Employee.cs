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
        int[] empact;
        int[] matact;
        public int adminempid;
        public int adminID;
        private int y;
        private Color use;
        private int teamempid;
        private string teamname;
        private string teampos;
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
        DataTable dtatt;
        DataTable dtact;
        DataTable dtop;
        int[] repop;
        string[] subloc;
        int[] countsub;
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
            editOperation.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvOperationsView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvViewAct.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvViewAct.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvAttendanceIn.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvAttendanceIn.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvAttendanceOut.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvAttendanceOut.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvReactivate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvReactivate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvEdit.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvEdit.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            dgvOpSumm.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);
            repEmp.DefaultCellStyle.SelectionBackColor = Color.FromArgb(110, 159, 173);


            //this.Top = 112;// 262

        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            refreshStatus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            y1.Text = DateTime.Now.ToString("yyyy");
            y2.Text = DateTime.Now.ToString("yyyy");
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
            DialogResult result = MessageBox.Show("Record Attendance In?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes) {
                try
                {
                    conn.Open();
                    employeeID = int.Parse(dgvAttendanceIn.Rows[e.RowIndex].Cells["personID"].Value.ToString());
                    string att = DateTime.Now.ToString("yyyy-MM-dd");
                    string time = DateTime.Now.ToString("HH:mm");
                    MySqlCommand comm = new MySqlCommand("INSERT INTO attendance(date, employeeID, type, time) VALUES('" + att + "', " + employeeID + ", " + "1" + ", '" + time + "') ", conn);
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
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(2, 170, 145);
            button3.BackColor = Color.FromArgb(251, 162, 80);
            lblIn.Visible = false;
            lblout.Visible = false;
            dgvAttendanceIn.Visible = true;
            dgvAttendanceOut.Visible = false;
            panelAtt.Visible = false;
            refreshAttendance();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(2, 170, 145);
            button10.BackColor = Color.FromArgb(251, 162, 80);
            lblIn.Visible = false;
            lblout.Visible = false;
            dgvAttendanceIn.Visible = false;
            dgvAttendanceOut.Visible = true;
            panelAtt.Visible = false;

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
                    this.newTeam.Rows.Add(teamempid, teamname, teampos);
                    foreach (DataGridViewRow row in allEmployees.SelectedRows)
                    {
                        allEmployees.Rows.RemoveAt(row.Index);
                    }
                    newTeam.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    newTeam.Columns["pos1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    count = count + 1;
                    empty = false;
                    teamname = "";
                    teamempid = 0;
                    teampos = "";

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
            tbOpYear.Text = DateTime.Now.ToString("yyyy");

            button15.BackColor = Color.FromArgb(251, 162, 80);
            button21.BackColor = Color.FromArgb(2, 170, 145);
            button31.BackColor = Color.FromArgb(2, 170, 145);
            button33.BackColor = Color.FromArgb(2, 170, 145);
            button36.BackColor = Color.FromArgb(2, 170, 145);
            panelViewAct.Visible = false;
            Edit.Visible = false;
            newOperation.Visible = true;
            pnlActivity.Visible = false;

            Operations.Visible = false;


        }

        private void button21_Click(object sender, EventArgs e)
        {
            tbviewyear.Text = DateTime.Now.ToString("yyyy");

            button21.BackColor = Color.FromArgb(251, 162, 80);
            button15.BackColor = Color.FromArgb(2, 170, 145);
            button33.BackColor = Color.FromArgb(2, 170, 145);
            button31.BackColor = Color.FromArgb(2, 170, 145);
            button36.BackColor = Color.FromArgb(2, 170, 145);
            Edit.Visible = false;
            newOperation.Visible = false;
            pnlActivity.Visible = false;
            Operations.Visible = true;
            panelViewAct.Visible = false;

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
                emp.ShowDialog();
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
        private void addEmp()
        {
            string lname = tblname.Text;
            string mname = tbmname.Text;
            string fname = tbfname.Text;
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


            string bday = tbYear.Text + '-' + (cbMonth.SelectedIndex + 1).ToString() + '-' + cbDay.Text;
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
        private void button4_Click_1(object sender, EventArgs e)
        {
            string lname = tblname.Text;
            string mname = tbmname.Text;
            string fname = tbfname.Text;
            if (tblname.Text != "Lastname" && tblname.Text != "" && tbmname.Text != "Middlename" && tbmname.Text != "" && tbfname.Text != "Firstname" && tbfname.Text != "" && tbaddress.Text != "Address" && tbaddress.Text != "" && cbgender.Text != "Gender" && tbcontactNumber.Text != "Contact Number" && tbcontactNumber.Text != "" && cbposition.Text != "Position" && cbDay.Text != "Day" && tbYear.Text != "Year" && cbMonth.Text != "Month")
            {
                if (cbposition.Text != "Admin")
                {
                    if (checkIfEmployeeExists(lname, mname, fname) == false) addEmp();
                    else MessageBox.Show("Error: Employee already exists");
                }
                else if (cbposition.Text == "Admin" && tbUser.Text != "Username" && tbPass.Text != "Password")
                {
                    if (checkIfEmployeeExists(lname, mname, fname) == false) addEmp();
                    else MessageBox.Show("Error: Employee already exists");
                }
                else MessageBox.Show("Please enter required fields");
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
            cbDay.Text = "Day";
            cbDay.Items.Clear();
            cbMonth.Text = "Month";
            tbYear.Text = "Year";
            tbaddress.Text = "Address";
            tbcontactNumber.Text = "Contact Number";
            cbposition.Text = "Position";

            cbposition.ForeColor = tbcontactNumber.ForeColor = tbaddress.ForeColor = cbDay.ForeColor = tbYear.ForeColor = cbMonth.ForeColor = cbgender.ForeColor = tbfname.ForeColor = tblname.ForeColor = tbmname.ForeColor = Color.Gray;
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
                MySqlCommand comm;
                if (DateTime.Now.ToString("yyyy-MM-dd") != Convert.ToDateTime(d).ToString("yyyy-MM-dd"))
                {
                    comm = new MySqlCommand("SELECT DISTINCT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS name, position from operationteam JOIN profile ON personID = operationteam.employeeID  JOIN employee ON employee.employeeID = personID WHERE (position = 'Catcher' OR position = 'Driver') AND employee.status = 'Active'  AND personID NOT IN (SELECT personID FROM profile  JOIN employee ON profile.personID = employee.employeeID JOIN operationteam ON employee.employeeID = operationteam.employeeID  JOIN dogoperation ON dogoperation.teamID = operationteam.teamID  WHERE CASE WHEN (date = '" + date + "') THEN (timeEnd > '" + ts + "' AND timestart < '" + te + "') OR (timeEnd >= '" + te + "' AND timestart <= '" + ts + "' )  END)   UNION SELECT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS name, position FROM profile JOIN employee ON profile.personID = employee.employeeID WHERE employeeID NOT IN(SELECT employeeID FROM operationteam) AND (position = 'Catcher' OR position = 'Driver') AND employee.status = 'Active'", conn);
                }
                else
                {
                    MessageBox.Show(d);
                    comm = new MySqlCommand("SELECT DISTINCT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS name, position from operationteam JOIN profile ON personID = operationteam.employeeID  JOIN employee ON employee.employeeID = personID JOIN attendance ON attendance.employeeID = personID WHERE position = ('Catcher' OR position = 'Driver') AND employee.status = 'Active'  AND personID NOT IN (SELECT personID FROM profile  JOIN employee ON profile.personID = employee.employeeID JOIN operationteam ON employee.employeeID = operationteam.employeeID  JOIN dogoperation ON dogoperation.teamID = operationteam.teamID  WHERE CASE WHEN (date = '" + d + "')THEN (timeEnd > '" + ts + "' AND timestart < '" + te + "') OR (timeEnd >= '" + te + "' AND timestart <= '" + ts + "' )  END ) AND attendance.date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND type = 1  AND personID NOT IN (SELECT employeeID FROM attendance WHERE date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND type = 0) UNION SELECT personID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS name, position FROM profile JOIN employee ON profile.personID = employee.employeeID JOIN attendance ON attendance.employeeID = personID WHERE personID NOT IN(SELECT employeeID FROM operationteam) AND (position = 'Catcher' OR position = 'Driver') AND employee.status = 'Active' AND attendance.date = '" + d + "' AND type = 0 AND personID NOT IN (SELECT employeeID FROM attendance WHERE date = '" + d + "' AND type = 0)", conn);
                }
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    int pid = int.Parse(dt.Rows[x]["personID"].ToString());
                    string pos = dt.Rows[x]["position"].ToString();
                    string name = dt.Rows[x]["name"].ToString();
                    allEmployees.Rows.Add(pid.ToString(), name, pos);
                }
                allEmployees.Columns["empname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                allEmployees.Columns["pos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                    teampos = allEmployees.Rows[e.RowIndex].Cells["pos"].Value.ToString();
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
                MySqlCommand c = new MySqlCommand("SELECT DISTINCT operationID FROM dogoperation JOIN operationteam ON operationteam.teamID = dogoperation.teamID JOIN attendance ON attendance.employeeID = operationteam.employeeiD WHERE dogoperation.date = '"+daten+"' AND attendance.employeeID NOT IN (select employeeID from attendance where date = '"+daten+"' AND type != 0)", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(c);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                    MySqlCommand comm = new MySqlCommand("UPDATE dogoperation SET status = 'OnGoing' WHERE date = '" + daten + "' AND status != 'finished' AND status != 'OnGoing' AND (timeStart = '" + timen + "' OR timeStart < '" + timen + "')", conn);
                    comm.ExecuteNonQuery();
                    MySqlCommand com = new MySqlCommand("UPDATE dogoperation SET status = 'Finished' WHERE date = '" + daten + "' AND status != 'finished' AND (timeEnd = '" + timen + "' OR timeEnd < '" + timen + "')", conn);
                    com.ExecuteNonQuery();
                    MySqlCommand co = new MySqlCommand("UPDATE dogoperation SET status = 'Finished' WHERE date < '" + daten + "' AND status != 'finished'", conn);
                    co.ExecuteNonQuery();
                if (dt.Rows.Count != 0)
                {
                    List<int> ids = new List<int>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ids.Add(int.Parse(dt.Rows[i]["operationID"].ToString()));
                    }
                    for (int i = 0; i < ids.Count; i++)
                    {
                        MySqlCommand m = new MySqlCommand("UPDATE dogoperation SET status = 'Pending' WHERE date = '"+daten+"' AND operationID = " + ids[i], conn);
                        m.ExecuteNonQuery();
                    }
                    for (int i = 0; i < dgvOperationsView.Rows.Count; i++)
                    {
                        for (int j = 0; j < ids.Count; j++)
                            if (dgvOperationsView.Rows[i].Cells["operationID"].Value.ToString() == ids[j].ToString())
                            {
                                dgvOperationsView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(242, 139, 123);
                            }
                    }
                }
                conn.Close();

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
                refreshStatus();
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


        private void button20_Click_1(object sender, EventArgs e)
        {
            tbOpDay.Items.Clear();
            empty = true;
            int teamid = 0;
            int empID = 0;
            int xCount = newTeam.Rows.Cast<DataGridViewRow>().Select(row => row.Cells["pos1"].Value.ToString()).Count(s => s == "Driver");
            if (xCount == 1) {
                List<int> empss = new List<int>();
                for (int i = 0; i < newTeam.Rows.Count; i++)
                {
                    empID = int.Parse(newTeam.Rows[i].Cells["personID"].Value.ToString());
                    empss.Add(empID);
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
            else if(xCount > 1)
            {
                MessageBox.Show("Choose ONLY 1 Driver");
            }
            else
            {
                MessageBox.Show("Choose 1 Driver");
            }
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

        public int checkIfTeamExists(int[] emps, int max) //emps = new operation team
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
            home.refreshNotif();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int year = int.Parse(tbviewyear.Text);
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
                        MySqlCommand comm = new MySqlCommand("UPDATE dogoperation SET status = 'OnGoing', timeStart = '" + DateTime.Now.ToString("HH:mm") + "', timeEnd = '"+ DateTime.Now.AddHours(3).ToString("HH:mm") + "', date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE operationID = " + operation, conn);

                        comm.ExecuteNonQuery();
                    }
                    else if (dgvOperationsView.Rows[e.RowIndex].Cells["opStatus"].Value.ToString() == "OnGoing")
                    {
                        MySqlCommand comm = new MySqlCommand("UPDATE dogoperation SET status = 'Finished', timeEnd = '" + DateTime.Now.ToString("HH:mm") + "', date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE operationID = " + operation, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        this.Hide();
                        home.repDog();
                    }

                
                conn.Close();
                refreshStatus();
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
                te = hee + ":" + tbEndm.Text;

                location = cbLocation.SelectedIndex + 1;
                String da = d + " " + ts;
                DateTime myDate = Convert.ToDateTime(da);
                DateTime cD = DateTime.Now;
                DateTime t = Convert.ToDateTime(d + " " + te);
                int resul = DateTime.Compare(t, myDate);
                int result = DateTime.Compare(myDate, cD);
                MySqlCommand con = new MySqlCommand("SELECT COUNT(*) FROM dogoperation WHERE date = '"+d+"' AND locationID = " + location, conn);
                MySqlDataAdapter adt = new MySqlDataAdapter(con);
                DataTable dtt = new DataTable();
                adt.Fill(dtt);
                if (int.Parse(dtt.Rows[0]["COUNT(*)"].ToString()) == 0)
                {
                    if (result > 0 && resul > 0)
                    {

                        {
                            pteam.Enabled = true;
                            pOperation.Enabled = false;
                            newTeam.Rows.Clear();


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
                    MessageBox.Show("The same location is recorded for the same date entered. \n Please Enter Different Location");
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
            DialogResult result = MessageBox.Show("Record Attendance Out?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    employeeID = int.Parse(dgvAttendanceOut.Rows[e.RowIndex].Cells["personID"].Value.ToString());
                    string att = DateTime.Now.ToString("yyyy-MM-dd");
                    string time = DateTime.Now.ToString("HH:mm");
                    MySqlCommand comm = new MySqlCommand("INSERT INTO attendance(date, employeeID, type, time) VALUES('" + att + "', " + employeeID + ", " + "0" + ", '" + time + "') ", conn);
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
        }


        string backpos;
        private void newTeam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (int.Parse(newTeam.Rows[e.RowIndex].Cells["personID"].Value.ToString()) != 0)
                {
                    backID = int.Parse(newTeam.Rows[e.RowIndex].Cells["personID"].Value.ToString());
                    backname = newTeam.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    backpos = newTeam.Rows[e.RowIndex].Cells["pos1"].Value.ToString();
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
                this.allEmployees.Rows.Add(backID, backname, backpos);
                foreach (DataGridViewRow row in newTeam.SelectedRows)
                {
                    newTeam.Rows.RemoveAt(row.Index);
                }
                backname = "";
                backID = 0;
                backpos = "";

            }
            allEmployees.ClearSelection();
            newTeam.ClearSelection();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.BackColor = Color.FromArgb(251, 162, 80);
            button21.BackColor = Color.FromArgb(2, 170, 145);
            button15.BackColor = Color.FromArgb(2, 170, 145);
            button33.BackColor = Color.FromArgb(2, 170, 145);
            button36.BackColor = Color.FromArgb(2, 170, 145);
            newOperation.Visible = false;
            pnlActivity.Visible = true;
            Edit.Visible = false;
            panelViewAct.Visible = false;
            Operations.Visible = false;;
            refreshActivity();

        }

        private void refreshActivity()
        {
            cbempact.Enabled = true;
            cbmatact.Enabled = true;
            cbact.Enabled = true;
            numact.Value = 0;
            cbact.Text = "Activity";
            cbempact.Text = "To be done by";
            cbmatact.Text = "Materials(If Applicable)";
            measBy.Text = "";
            cbempact.Items.Clear();
            cbmatact.Items.Clear();
            try
            {
                conn.Open();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                MySqlCommand comm = new MySqlCommand("SELECT DISTINCT employee.employeeID AS emp, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS name "
                                                    +"FROM employee "
                                                    + "INNER JOIN profile ON profile.personID = employee.employeeID "
                                                    + "INNER JOIN attendance ON attendance.employeeID = employee.employeeID "
                                                    + "WHERE employee.employeeID "
                                                    + "NOT IN(SELECT employeeID FROM attendance WHERE date = '" + date + "' AND type = 0) "
                                                    + "AND employee.employeeID "
                                                    + "IN(SELECT employeeID FROM attendance WHERE date = '" + date + "' AND type = 1) "
                                                    + "AND employee.employeeID "
                                                    + "NOT IN "
                                                    + "(SELECT employee.employeeID "
                                                    + "FROM operationteam "
                                                    + "INNER JOIN dogoperation ON dogoperation.teamID = operationteam.teamID "
                                                    + "INNER JOIN employee ON operationteam.employeeID = employee.employeeID "
                                                    + " WHERE dogoperation.status = 'OnGoing')", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                empact = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    empact[i] = int.Parse(dt.Rows[i]["emp"].ToString());
                    cbempact.Items.Add(dt.Rows[i]["name"].ToString());
                }
                
                MySqlCommand commm = new MySqlCommand("SELECT itemID AS item, CONCAT(productName, ' (', description, ')') as product FROM items", conn);
                MySqlDataAdapter adpt = new MySqlDataAdapter(commm);
                DataTable dta = new DataTable();
                adpt.Fill(dta);
                
                matact = new int[dta.Rows.Count];
                for (int i = 0; i < dta.Rows.Count; i++)
                {
                    matact[i] = int.Parse(dta.Rows[i]["item"].ToString());
                    cbmatact.Items.Add(dta.Rows[i]["product"].ToString());
                }
                cbmatact.Items.Add("None");
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }

        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            pteam.Enabled = false;
            pOperation.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int[] repEmpArr;
        private void choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m2.Text != "Month" && m1.Text != "Month" && y1.Text != "Day" && y2.Text != "Day") {
                if (choice.SelectedIndex == 0)
                {
                    dgvOpSumm.Visible = false;
                    cbFilt.Visible = true;
                    repEmp.Visible = true;
                    if (cbFilt.Checked && cbEmpFilt.Text == "Employee") MessageBox.Show("Please select an employee");
                    else repAttendance();

                }
                else if (choice.SelectedIndex == 1)
                {
                    dgvOpSumm.Visible = false;
                    cbFilt.Visible = true;
                    repEmp.Visible = true;
                    if (cbFilt.Checked && cbEmpFilt.Text == "Employee") MessageBox.Show("Please select an employee");
                    else repActivity();

                }
                else if (choice.SelectedIndex == 2)
                {
                    dgvOpSumm.Visible = true;
                    repEmp.Visible = false;
                    cbFilt.Visible = false;
                    pnlEmpFilt.Visible = false;
                    repOperation();
                }
            }
            else
            {
                MessageBox.Show("Please enter dates");
            }
        }
        private void loadEmpRep()
        {
            cbEmpFilt.Items.Clear();
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT employeeID, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS name, position FROM employee INNER JOIN profile ON personID = employeeID ORDER BY lastname, firstname" , conn);
                MySqlDataAdapter adpt = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                repEmpArr = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string load = dt.Rows[i]["name"].ToString() + " - " + dt.Rows[i]["position"].ToString();
                    cbEmpFilt.Items.Add(load);
                    repEmpArr[i] = int.Parse(dt.Rows[i]["employeeID"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }
        string[] actdates;
        int[] countdate;
        private void repActivity()
        {
            string datestart = y1.Text + "-" + (m1.SelectedIndex + 1).ToString() + "-" + d1.Text;
            string dateend = y2.Text + "-" + (m2.SelectedIndex + 1).ToString() + "-" + d2.Text;
            try
            {
                conn.Open();
                MySqlCommand comm;
                if (cbFilt.Checked && cbEmpFilt.Text != "Employee")
                {
                    comm = new MySqlCommand("SELECT SUBSTRING(date,1, 11) AS Date, timeEnd AS 'Time Recorded', type AS Type FROM dogpound.activity INNER JOIN profile on personID = employeeID WHERE date BETWEEN '"+datestart+ "' AND '" + dateend + "' AND employeeID = " + repEmpArr[cbEmpFilt.SelectedIndex] + " ORDER BY date, timeEnd, type", conn);
                    MySqlCommand commm = new MySqlCommand("SELECT CONCAT(lastname, ', ', firstname, ' ', middlename)  AS name, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE profile.personID = " + repEmpArr[cbEmpFilt.SelectedIndex], conn);
                    MySqlDataAdapter adpt = new MySqlDataAdapter(commm);
                    DataTable dta = new DataTable();
                    adpt.Fill(dta);
                    employeefilteractivity = dta.Rows[0]["name"].ToString();
                    employeeposact = dta.Rows[0]["position"].ToString();
                }
                else
                {
                    comm = new MySqlCommand("SELECT SUBSTRING(date, 1, 11) AS Date, type AS Type, timeEnd AS 'Time Recorded', CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS 'Employee Name' FROM dogpound.activity INNER JOIN profile on personID = employeeID WHERE date BETWEEN '" + datestart + "' AND '" + dateend + "' ORDER BY date, timeEnd, lastname, firstname, type", conn);
                }

                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                dtact = new DataTable();
                adp.Fill(dtact);

                MySqlCommand com = new MySqlCommand("SELECT DISTINCT SUBSTRING(date, 1, 11) AS date FROM activity INNER JOIN profile on personID = employeeID WHERE date BETWEEN '"+datestart+"' AND '"+dateend+"' ORDER BY date", conn);
                MySqlDataAdapter adptt = new MySqlDataAdapter(com);
                DataTable dtt = new DataTable();
                adptt.Fill(dtt);
                countdate = new int[dtt.Rows.Count];
                actdates = new string[dtt.Rows.Count];
                for (int i = 0; i < dtt.Rows.Count; i++)
                {
                    actdates[i] = dtt.Rows[i]["date"].ToString();
                }
                
                for (int i = 0; i < actdates.Length; i++)
                {
                    MySqlCommand commmm = new MySqlCommand("SELECT COUNT(*) as c FROM dogpound.activity INNER JOIN profile on personID = employeeID WHERE SUBSTRING(date, 1, 11) = '"+actdates[i]+"'", conn);
                    MySqlDataAdapter adpttt = new MySqlDataAdapter(commmm);
                    DataTable dttt = new DataTable();
                    adpttt.Fill(dttt);
                    countdate[i] = int.Parse(dttt.Rows[0]["c"].ToString());
                    
                }

                repEmp.DataSource = dtact;
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }
        string employeefilterattendance; //name of filtered employee
        string employeefilteractivity;
        string employeeposact;
        string employeeposatt;
        string[] attdates;
        int[] countdates;
        private void repAttendance()
        {
            string datestart = y1.Text + "-" + (m1.SelectedIndex + 1).ToString() + "-" + d1.Text;
            string dateend = y2.Text + "-" + (m2.SelectedIndex + 1).ToString() + "-" + d2.Text;
            try
            {
                conn.Open();
                MySqlCommand comm;
                if (cbFilt.Checked && cbEmpFilt.Text != "Employee")
                {
                    comm = new MySqlCommand("SELECT SUBSTRING(date, 1, 11) AS Date, time AS Time, "
                                            + "CASE type WHEN 0 THEN 'Out' WHEN 1 THEN 'In' END AS Type "
                                            + "FROM attendance INNER JOIN profile on profile.personID = attendance.employeeID "
                                            + "INNER JOIN employee ON profile.personID = employee.employeeID "
                                            + "WHERE date BETWEEN '" + datestart + "' AND '" + dateend + "' AND attendance.employeeID = " + repEmpArr[cbEmpFilt.SelectedIndex] + " ORDER BY date, type", conn);
                    MySqlCommand commm = new MySqlCommand("SELECT CONCAT(lastname, ', ', firstname, ' ', middlename) AS name, position FROM profile INNER JOIN employee ON employee.employeeID = profile.personID WHERE profile.personID = " + repEmpArr[cbEmpFilt.SelectedIndex], conn);
                    MySqlDataAdapter adpt = new MySqlDataAdapter(commm);
                    DataTable dta = new DataTable();
                    adpt.Fill(dta);
                    employeefilterattendance = dta.Rows[0]["name"].ToString();
                    employeeposatt = dta.Rows[0]["position"].ToString();
                }
                else
                {
                    comm = new MySqlCommand("SELECT SUBSTRING(date, 1, 11) AS Date, time AS Time, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1)) AS 'Employee Name', position AS Position, contactNumber AS ContactNumber, "
                                            + "CASE type WHEN 0 THEN 'Out' WHEN 1 THEN 'In' END AS Type "
                                            + "FROM attendance INNER JOIN profile on profile.personID = attendance.employeeID "
                                            + "INNER JOIN employee ON profile.personID = employee.employeeID "
                                            + "WHERE date BETWEEN '" + datestart + "' AND '" + dateend + "' ORDER BY date, lastname, firstname, type", conn);
                }

                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                dtatt = new DataTable();
                adp.Fill(dtatt);

                MySqlCommand commmm = new MySqlCommand("SELECT DISTINCT SUBSTRING(date, 1, 11) AS Date "
                                            + "FROM attendance INNER JOIN profile on profile.personID = attendance.employeeID "
                                            + "INNER JOIN employee ON profile.personID = employee.employeeID "
                                            + "WHERE date BETWEEN '" + datestart + "' AND '" + dateend + "' ORDER BY date, 'Employee Name', type", conn);
                MySqlDataAdapter adptt = new MySqlDataAdapter(commmm);
                DataTable dtt = new DataTable();
                adptt.Fill(dtt);
                attdates = new string[dtt.Rows.Count];
                countdates = new int[dtt.Rows.Count];
                for (int i = 0; i < dtt.Rows.Count; i++)
                {
                    attdates[i] = dtt.Rows[i]["Date"].ToString();
                    MySqlCommand com = new MySqlCommand("SELECT COUNT(*) AS c FROM attendance WHERE date = '"+attdates[i]+"'", conn);
                    MySqlDataAdapter adpttt = new MySqlDataAdapter(com);
                    DataTable dttt = new DataTable();
                    adpttt.Fill(dttt);
                    countdates[i] = int.Parse(dttt.Rows[0]["c"].ToString());
                }

               
                repEmp.DataSource = dtatt;
                
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }
        private void repOperation()
        {
            string datestart = y1.Text + "-" + (m1.SelectedIndex+1).ToString() + "-" + d1.Text;
            string dateend = y2.Text + "-" + (m2.SelectedIndex+1).ToString() + "-" + d2.Text;
            try
            {
                conn.Open();

                MySqlCommand comm = new MySqlCommand("SELECT teamID, operationID, SUBSTRING(date, 1, 11) as date, CONCAT(timeStart, '-', timeEnd) AS time, description, status FROM dogoperation INNER JOIN location ON location.locationID = dogoperation.locationID WHERE date BETWEEN '" + datestart+ "' AND '" + dateend + "' AND status = 'Finished' ORDER BY  date, timeStart", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                subloc = new string[dt.Rows.Count];
                repop = new int[dt.Rows.Count];
                countsub = new int[dt.Rows.Count];
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    repop[x] = int.Parse(dt.Rows[x]["operationID"].ToString());
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
                    string loc = "Brgy. " + dt.Rows[x]["description"].ToString();
                    string date = dt.Rows[x]["date"].ToString();
                    string time = dt.Rows[x]["time"].ToString(); 
                    string status = dt.Rows[x]["status"].ToString();
                    commm = new MySqlCommand("SELECT COUNT(dogID) AS imp FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID WHERE dogprofile.operationID = " + opID, conn);
                    adpt = new MySqlDataAdapter(commm);
                    dta = new DataTable();
                    adpt.Fill(dta);
                    int imp = int.Parse(dta.Rows[0]["imp"].ToString());
                    dgvOpSumm.Rows.Add(loc, time, date, team, imp);
                }

                dgvOpSumm.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvOpSumm.Columns["team"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvOpSumm.Columns["loc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvOpSumm.Columns["date1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvOpSumm.Columns["time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvOpSumm.Columns["team"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvOpSumm.Columns["imp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
                loadsubloc();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void button28_Click_1(object sender, EventArgs e)
        {
            print();
            noheader = false;
            noheader2 = false;
            noheader3 = false;
            countt = 0; //Attendance
            act = 0; //Activities
            it = 0; //Operations
            
        }

        private void specLoc_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button32_Click(object sender, EventArgs e)
        {
           
               
        }
        
        private void button6_Click_1(object sender, EventArgs e)
        {
            dgvAttendanceIn.Visible = false;
            dgvAttendanceOut.Visible = false;
            lblIn.Visible = true;
            lblout.Visible = true;
            print();

            panelAtt.Visible = true;
            refreshAttView();
        }
        private void refreshAttView()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS Employee, position AS Position, time AS Time FROM attendance INNER JOIN profile ON profile.personID = attendance.employeeID INNER JOIN employee ON employee.employeeID = profile.personID WHERE type = 1 AND date = '"+date+"'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvViewattin.DataSource = dt;

                MySqlCommand commm = new MySqlCommand("SELECT CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS Employee, position AS Position, time AS Time FROM attendance INNER JOIN profile ON profile.personID = attendance.employeeID INNER JOIN employee ON employee.employeeID = profile.personID WHERE type = 0 AND date = '" + date + "'", conn);
                MySqlDataAdapter adpt = new MySqlDataAdapter(commm);
                DataTable dta = new DataTable();
                adpt.Fill(dta);

                dgvViewattout.DataSource = dta;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvAttendanceIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        DataTable dtOp;
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
                    dtOp = new DataTable();
                    adp.Fill(dtOp);
                    dgvOperationsView.DataSource = dtOp;

                    for (int x = 0; x < dtOp.Rows.Count; x++)
                    {
                        int teamID = int.Parse(dtOp.Rows[x]["teamID"].ToString());
                        int opID = int.Parse(dtOp.Rows[x]["operationID"].ToString());
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
                        string loc = dtOp.Rows[x]["description"].ToString();
                        string date = dtOp.Rows[x]["date"].ToString();
                        string start = dtOp.Rows[x]["timeStart"].ToString();
                        string end = dtOp.Rows[x]["timeEnd"].ToString();
                        string status = dtOp.Rows[x]["status"].ToString();
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
            tbedityear.Text = DateTime.Now.ToString("yyyy");
            Edit.Visible = true;
            button33.BackColor = Color.FromArgb(251, 162, 80);
            button21.BackColor = Color.FromArgb(2, 170, 145);
            button31.BackColor = Color.FromArgb(2, 170, 145);
            button15.BackColor = Color.FromArgb(2, 170, 145);
            button36.BackColor = Color.FromArgb(2, 170, 145);

            newOperation.Visible = false;
            pnlActivity.Visible = false;
            panelViewAct.Visible = false;
            Operations.Visible = false;
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
                op.ShowDialog();
                                
            }
        }

        public void refreshEditop()
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

        private void actyr_Enter(object sender, EventArgs e)
        {
            
        }

        private void cbmatact_SelectedIndexChanged(object sender, EventArgs e)
        {
            numact.Visible = true;
            measBy.Visible = true;
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT measuredBy FROM items WHERE itemID = " + matact[cbmatact.SelectedIndex],conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                measBy.Text = "Amount by " + dt.Rows[0]["measuredBy"].ToString() + ":";
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void panelviewatt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            if (cbact.Text!="Activity" && cbempact.Text!="To be done by")
            {
                string time = DateTime.Now.ToString("HH:mm");
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                try
                {
                    conn.Open();
                    MySqlCommand comm;
                    MySqlCommand commm;
                    MySqlCommand commmm;
                    
                    if (cbmatact.Text != "Materials(If Applicable)")
                    {
                        if (checkavailability(int.Parse(numact.Value.ToString()), matact[cbmatact.SelectedIndex]) == true) {
                            
                            if (numact.Value != 0 && cbmatact.Text != "None")
                            {
                                comm = new MySqlCommand("INSERT INTO activity(timeEnd, employeeID, date, type) VALUES('" + time + "', " + empact[cbempact.SelectedIndex] + ", '" + date + "', '" + cbact.Text + "')", conn);
                                comm.ExecuteNonQuery();
                                commm = new MySqlCommand("UPDATE items SET quantity = quantity - " + numact.Value + " WHERE itemID = " + matact[cbmatact.SelectedIndex], conn);
                                commm.ExecuteNonQuery();
                                commmm = new MySqlCommand("INSERT INTO stocktransaction(stockID, quantity, date, type, employeeID, reason) VALUES(" + matact[cbmatact.SelectedIndex] + ", " + numact.Value + ", '" + date + "', 'Out', " + empact[cbempact.SelectedIndex] + ", 'Activity: " + cbact.Text + "')", conn);
                                commmm.ExecuteNonQuery();
                                MessageBox.Show("Activity Recorded!");
                                conn.Close();
                                refreshActivity();
                            }
                            else
                            {
                                conn.Close();
                                MessageBox.Show("Quantity not valid");
                            }
                        }
                        else
                        {
                            conn.Close();
                            MessageBox.Show("Quantity not valid. Item is running out");
                        }
                    }
                    else
                    {
                        comm = new MySqlCommand("INSERT INTO activity(timeEnd, employeeID, date, type) VALUES('" + time + "', " + empact[cbempact.SelectedIndex] + ", '" + date + "', '" + cbact.Text + "')", conn);
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Activity Recorded!");
                        conn.Close();
                        refreshActivity();
                    }
                    
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please enter required fields");
            }
        }

        private Boolean checkavailability(int q, int id)
        {
            try
            {
                
                MySqlCommand comm = new MySqlCommand("SELECT quantity FROM items WHERE itemID = " + id, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (int.Parse(dt.Rows[0]["quantity"].ToString()) < q)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.FromArgb(251, 162, 80);
            button21.BackColor = Color.FromArgb(2, 170, 145);
            button31.BackColor = Color.FromArgb(2, 170, 145);
            button33.BackColor = Color.FromArgb(2, 170, 145);
            button15.BackColor = Color.FromArgb(2, 170, 145);
            panelViewAct.Visible = true;
            newOperation.Visible = false;
            pnlActivity.Visible = false;
            Edit.Visible = false;
            Operations.Visible = false;
            refreshViewAct();
        }
        private void refreshViewAct()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT CONCAT(lastname, ', ',firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS Name, CONCAT(items.productName, ' (', items.description, ')') AS Product, CONCAT(stocktransaction.quantity, ' (', items.measuredBy, ')') AS 'Used', activity.type AS Activity, activity.date AS Date, activity.timeEnd AS 'Time Ended' FROM profile INNER JOIN activity ON activity.employeeID = profile.personID INNER JOIN stocktransaction ON stocktransaction.employeeID = profile.personID INNER JOIN items ON stocktransaction.stockID = items.itemID GROUP BY activity.activityID ORDER BY activity.timeEnd", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvViewAct.DataSource = dt;
                dgvViewAct.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewAct.Columns["Product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewAct.Columns["Used"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewAct.Columns["Activity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewAct.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewAct.Columns["Time Ended"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbFilt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFilt.Checked)
            {
                pnlEmpFilt.Visible = true;
                loadEmpRep();
            }
            else
            {
                pnlEmpFilt.Visible = false;
            }
        }

        private void y1_TextChanged(object sender, EventArgs e)
        {
            if (y1.Text.Length == 4)
            {
                m1.Enabled = true;
            }
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

        private void y1_Enter(object sender, EventArgs e)
        {
            y1.Text = "";
        }

        private void m1_SelectedIndexChanged(object sender, EventArgs e)
        {
            d1.Enabled = true;
            d1.Items.Clear();
            responsiveDay1(int.Parse(y1.Text));
        }

        private void m2_SelectedIndexChanged(object sender, EventArgs e)
        {
            d2.Enabled = true;
            d2.Items.Clear();
            responsiveDay2(int.Parse(y2.Text));
        }
        private void responsiveDay1(int year)
        {
            int x;
            if (m1.Text == "January" || m1.Text == "March" || m1.Text == "May" || m1.Text == "July" || m1.Text == "August" || m1.Text == "October" || m1.Text == "December") loopDay1(31);
            else if (m1.Text == "February") { if (year % 4 == 0) loopDay1(29); else loopDay1(28); }
            else loopDay1(30);
        }
        private void responsiveDay2(int year)
        {
            int x;
            if (m2.Text == "January" || m2.Text == "March" || m2.Text == "May" || m2.Text == "July" || m2.Text == "August" || m2.Text == "October" || m2.Text == "December") loopDay2(31);
            else if (m2.Text == "February") { if (year % 4 == 0) loopDay2(29); else loopDay2(28); }
            else loopDay2(30);
        }
        private void loopDay1(int x)
        {
            int i = 1;
            while (i <= x)
            {
                d1.Items.Add(i.ToString());
                i++;
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

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void print()
        {
            if(choice.SelectedIndex == 0)
            {
                printDocument1.DefaultPageSettings.Landscape = false;
                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = printDocument1;
                ((Form)dlg).WindowState = FormWindowState.Maximized;
                dlg.ShowDialog();

            } else if (choice.SelectedIndex == 1)
            {
                printDocument2.DefaultPageSettings.Landscape = false;
                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = printDocument2;
                ((Form)dlg).WindowState = FormWindowState.Maximized;
                dlg.ShowDialog();

            } else if (choice.SelectedIndex == 2)
            {
                printDocument3.DefaultPageSettings.Landscape = false;
                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = printDocument3;
                ((Form)dlg).WindowState = FormWindowState.Maximized;
                dlg.ShowDialog();
            }
        }
        int it = 0;
        Boolean noheader = false;
        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            int x;
            if (noheader == false) {
                it = 0;
                e.Graphics.DrawString("Republic of the Philippines", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(280, 50));
                e.Graphics.DrawString("City of Davao", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(335, 70));
                e.Graphics.DrawString("DAVAO CITY DOG POUND", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(230, 100));
                e.Graphics.DrawString("OPERATIONS REPORT", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(270, 130));
                e.Graphics.DrawString("For the Month of  " + m1.Text + " " + d1.Text + ", " + y1.Text + " - " + m2.Text + " " + d2.Text + ", " + y2.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(120, 170));
                x = 240;
            }
            else
            {
                x = 40;
            }
            int rows = 0;
            while(it < dgvOpSumm.Rows.Count)
            {
                e.Graphics.DrawString("Date:  " + dgvOpSumm.Rows[it].Cells["date1"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, x));
                e.Graphics.DrawString("Location:  " + dgvOpSumm.Rows[it].Cells["loc"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, x));
                e.Graphics.DrawString("Employees involved: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(545, x));
                x = x + 25;
                e.Graphics.DrawString("Time:  " + dgvOpSumm.Rows[it].Cells["time"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, x));
                e.Graphics.DrawString("Sublocations: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, x));
                e.Graphics.DrawString(dgvOpSumm.Rows[it].Cells["team"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(565, x));
                x = x + 25;
                e.Graphics.DrawString("Number of heads caught:  "+dgvOpSumm.Rows[it].Cells["imp"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, x));
                e.Graphics.DrawString(subloc[it], new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(320, x));
                rows++;
                int numemp = dgvOpSumm.Rows[it].Cells["team"].Value.ToString().Split('\n').Length;
                if (countsub[it] > numemp - 1)
                {
                    if (countsub[it] > 2) x = x + (25 * (countsub[it]));
                    else x = x + 50;
                }
                else if (countsub[it] < numemp - 1)
                {
                    if (numemp > 4) x = x + (25 * (numemp-2));
                    else x = x + 50;
                }
                else
                {
                    if (countsub[it] >= 2) x = x + (25 * (countsub[it]));
                }
                
                it++;
                if (x >= 1100)
                {
                    rows = 0;
                    e.HasMorePages = true;
                    noheader = true;
                    return;
                }
                else
                {
                    rows++;
                    e.HasMorePages = false;
                }
                
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            refreshEdit();
        }

        private void tbStarth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbedityear.Text == "Year")
            {
                tbedityear.Text = "";
            }
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox7.Text == "Day")
            {
                textBox7.Text = "";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox3.Text == "Day")
            {
                textBox3.Text = "";
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
           if(tbviewyear.Text == "Year")
            {
                tbviewyear.Text = "";
            }
        }
        int countt = 0;
        Boolean noheader3 = false;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x;
            if (noheader3 == false) {
                e.Graphics.DrawString("Republic of the Philippines", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(310, 50));
                e.Graphics.DrawString("City of Davao", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(365, 70));
                e.Graphics.DrawString("OFFICE OF THE CITY VETERINARIAN", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(150, 100));
                e.Graphics.DrawString("ATTENDANCE REPORT", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(230, 130));
                e.Graphics.DrawString("For the Month of  " + m1.Text + " " + d1.Text + ", " + y1.Text + " - " + m2.Text + " " + d2.Text + ", " + y2.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(130, 170));
                x = 240;
            }
            else
            {
                x = 40;
            }
            if (cbFilt.Checked && employeefilterattendance!="")
            {
                e.Graphics.DrawString(employeefilterattendance + " - " + employeeposatt, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(100, 220));
                x = 280;
                for (int i = 0; i < dtatt.Rows.Count; i = i + 2)
                {
                    string date = dtatt.Rows[i]["Date"].ToString();
                    e.Graphics.DrawString(date, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, x));
                    e.Graphics.DrawString(dtatt.Rows[i + 0]["Type"].ToString() + ": " + dtatt.Rows[i + 0]["Time"].ToString() + "   " + dtatt.Rows[i + 1]["Type"].ToString() + ": " + dtatt.Rows[i + 1]["Time"].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(250, x));
                    x = x + 30;
                    
                }
            }
            else
            {
                for (int j = 0; countt < dtatt.Rows.Count; j++) {
                    if (countt != 0 && dtatt.Rows.Count - countt != 0 && dtatt.Rows[countt]["Date"].ToString() != dtatt.Rows[countt-1]["Date"].ToString())
                    {
                        x = x + 40;
                        e.Graphics.DrawString(dtatt.Rows[countt]["Date"].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, x));
                        x = x + 35;
                    }
                    if (countt == 0)
                    {
                        x = x + 40;
                        e.Graphics.DrawString(dtatt.Rows[countt]["Date"].ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, x));
                        x = x + 35;
                    }
                    string time = dtatt.Rows[countt]["Time"].ToString();
                    string emp = dtatt.Rows[countt]["Employee Name"].ToString();
                    string pos = dtatt.Rows[countt]["Position"].ToString();
                    string contact = dtatt.Rows[countt]["ContactNumber"].ToString();
                    string type = dtatt.Rows[countt]["Type"].ToString();
                    if (countt > 0) {
                        if (emp != dtatt.Rows[countt - 1]["Employee Name"].ToString()) {
                             e.Graphics.DrawString(emp + " - " + pos + "   ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, x));
                             e.Graphics.DrawString(type + ": " + time, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(500, x));
                            countt++;
                            x = x + 15;
                            
                        }
                        else //Out
                        {
                            e.Graphics.DrawString(type + ": " + time, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(600, x-15));
                            countt++;
                            x = x + 15;
                            if (x >= 950)
                            {
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
                    else
                    {
                            e.Graphics.DrawString(emp + " - " + pos + "   ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, x));
                            e.Graphics.DrawString(type + ": " + time, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(500, x));
                            countt++;
                        x = x + 15;
                    }
                    
                    
                }
                
            }


        }
        int act = 0;
        int f = 0;
        Boolean noheader2 = false;
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void m1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbOpMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbmatact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbbdaymonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void loadsubloc()
        {
            string nl = Environment.NewLine;
            try {
                conn.Open();
                for (int i = 0; i < repop.Length; i++)
                {
                    MySqlCommand comm = new MySqlCommand("SELECT DISTINCT sublocation FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID WHERE dogprofile.operationID = "+repop[i]+" ORDER by sublocation", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    countsub[i] = dt.Rows.Count;
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        subloc[i] = subloc[i] + dt.Rows[j]["sublocation"].ToString() + nl;
                    }
                    
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void printDocument2_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x;
            if (noheader2 == false)
            {
                act = 0;
                f = 0;
                e.Graphics.DrawString("Republic of the Philippines", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(280, 50));
                e.Graphics.DrawString("City of Davao", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(335, 70));
                e.Graphics.DrawString("DAVAO CITY DOG POUND", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(230, 100));
                e.Graphics.DrawString("ACTIVITIES REPORT", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(270, 130));
                e.Graphics.DrawString("For the Month of  " + m1.Text + " " + d1.Text + ", " + y1.Text + " - " + m2.Text + " " + d2.Text + ", " + y2.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(120, 170));

                if (employeefilteractivity != "" && cbFilt.Checked)
                {
                    e.Graphics.DrawString(employeefilteractivity + " - " + employeeposact, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(100, 220));
                    e.Graphics.DrawString("Date", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(120, 270));
                    e.Graphics.DrawString("Time Recorded", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(320, 270));
                    e.Graphics.DrawString("Activity", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(500, 270));
                    x = 310;
                }
                else
                {
                    x = 220;
                }
            }
            else
            {
                if (employeefilteractivity != "" && cbFilt.Checked)
                {
                    e.Graphics.DrawString("Date", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(100, 40));
                    e.Graphics.DrawString("Time Recorded", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(300, 40));
                    e.Graphics.DrawString("Activity", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(480, 40));
                    x = 80;
                }
                else
                {
                    x = 40;
                }
            }

            if (employeefilteractivity != "" && cbFilt.Checked) //if filter by employee
            {
                while (act < dtact.Rows.Count)
                {
                    e.Graphics.DrawString(dtact.Rows[act]["Date"].ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, x));
                    e.Graphics.DrawString(dtact.Rows[act]["Time Recorded"].ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(320, x));
                    e.Graphics.DrawString(dtact.Rows[act]["Type"].ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(500, x));

                    if (x >= 1100)
                    {
                        e.HasMorePages = true;
                        noheader2 = true;
                        return;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                    x = x + 25;
                    act++;
                }
            }
            else //If no filter (date)
            {

                for (int j = 0; act < repEmp.Rows.Count; j++)
                {
                    if (repEmp.Rows.Count - j != 0 && act != 0 && repEmp.Rows[act].Cells["Date"].Value.ToString() != repEmp.Rows[act - 1].Cells["Date"].Value.ToString())
                    {
                        x = x + 30;
                        e.Graphics.DrawString(repEmp.Rows[act].Cells["Date"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, x));
                    }
                    if (act == 0)
                    {
                        x = x + 30;
                        e.Graphics.DrawString(repEmp.Rows[act].Cells["Date"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(120, x));
                    }
                    e.Graphics.DrawString(repEmp.Rows[act].Cells["Employee Name"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(250, x));
                    e.Graphics.DrawString(repEmp.Rows[act].Cells["Time Recorded"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(450, x));
                    e.Graphics.DrawString(repEmp.Rows[act].Cells["Type"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(520, x));
                    if (x >= 1000)
                    {
                        e.HasMorePages = true;
                        noheader2 = true;
                        return;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                    x = x + 25;
                    act++;
                }



            }
        }

        private void cbEmpFilt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choice.Text != "Type")
            {
                if (choice.SelectedIndex == 0) repAttendance();
                else if (choice.SelectedIndex == 1) repActivity();

            }
        }

        private void cbLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbbdaymonth_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void m1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbmname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tblname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbcontactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
            if (tbYear.Text.Length == 4)
            {
                cbMonth.Enabled = true;
            }
        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDay.Items.Clear();
            cbDay.Enabled = true;
            int x;
            if (cbMonth.Text == "January" || cbMonth.Text == "March" || cbMonth.Text == "May" || cbMonth.Text == "July" || cbMonth.Text == "August" || cbMonth.Text == "October" || cbMonth.Text == "December") loopDays(31);
            else if (cbMonth.Text == "February") { if (int.Parse(tbYear.Text) % 4 == 0) loopDays(29); else loopDays(28); }
            else loopDays(30);
        }

        private void loopDays(int x)
        {
            for (int i = 0; i <= x; i++)
            {
                cbDay.Items.Add(i.ToString());
            }
        }

        private void tbYear_Enter(object sender, EventArgs e)
        {
            tbYear.Text = "";
        }

        private void y1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void y2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbOpYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}



