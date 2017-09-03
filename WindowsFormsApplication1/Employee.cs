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

        public empty back { get; set; }
        public MySqlConnection conn = new MySqlConnection();
        EditEmp emp;
        empty home;
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void eGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void contactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }
        int actemployeeID = 0;
        private void btnDone_Click(object sender, EventArgs e)
        {
            string datez = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("INSERT INTO activity(employeeID, type, date) VALUES(" + actemployeeID + ", '" + tbAct.Text + "', '" + datez + "')", conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Activity recorded successfully!");
                conn.Close();
                refreshActivity();
                tbAct.Text = "Type of Activity";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = true;
            act.Visible = false;
            attendance.Visible = false;
            
            panel2.Visible = false;
            ne.Visible = true;
            a.Visible = false;
            ac.Visible = false;
            o.Visible = false;
            r.Visible = false;


        }

        private void selectButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = false;
            act.Visible = false;
            attendance.Visible = true;
            
            panel2.Visible = false;
            ne.Visible = false;
            a.Visible = true;
            ac.Visible = false;
            o.Visible = false;
            r.Visible = false;


            refreshAttendance();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = false;
            act.Visible = true;
            attendance.Visible = false; ;
            
            panel2.Visible = false;
            ne.Visible = false;
            a.Visible = false;
            ac.Visible = true;
            o.Visible = false;
            r.Visible = false;

            refreshActivity();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = false;
            act.Visible = false;
            attendance.Visible = false;
           
            panel2.Visible = false;
            ne.Visible = false;
            a.Visible = false;
            ac.Visible = false;
            o.Visible = false;
            r.Visible = false;

}

        private void Employee_Load(object sender, EventArgs e)
        {
            //this.Top = 112;// 262

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = false;
            act.Visible = false;
            attendance.Visible = false;
            
            panel2.Visible = true;
            ne.Visible = false;
            a.Visible = false;
            ac.Visible = false;
            o.Visible = false;
            r.Visible = true;
            repEmp.Visible = true;

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
                MySqlCommand comm = new MySqlCommand("SELECT personID, CONCAT(lastname, ', ', firstname, ' ', middlename) AS name, gender, contactNumber, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE status = 'Active' AND employee.employeeID NOT IN (SELECT attendance.employeeID FROM attendance) ORDER BY lastname ASC", conn); //missing: refresh everyday (in restrictions, date should be now)
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
                string att = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                MySqlCommand comm = new MySqlCommand("INSERT INTO attendance(date, employeeID, type) VALUES('" + att + "', " + employeeID + ", " + "1" + ") ", conn);
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

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void refreshActivity()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT personID, CONCAT(lastname, ', ', firstname, ' ', middlename) AS name, gender, birthdate, contactNumber, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE status = 'Active'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvActivities.DataSource = dt;

                dgvActivities.Columns["personID"].Visible = false;
                dgvActivities.Columns["name"].HeaderText = "Name";
                dgvActivities.Columns["gender"].HeaderText = "Gender";
                dgvActivities.Columns["birthdate"].HeaderText = "Birthdate";
                dgvActivities.Columns["contactNumber"].HeaderText = "Contact No.";
                dgvActivities.Columns["position"].HeaderText = "Position";
                dgvActivities.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvActivities.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvActivities.Columns["contactNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvActivities.Columns["position"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvActivities.Columns["birthdate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(251, 162, 80);
            button12.BackColor = Color.FromArgb(2, 170, 145);
            addPanel.Visible = true;
            editPanel.Visible = false;
            pnlAdmin.Visible = false;
            rePopAddEmp();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(251, 162, 80);
            button11.BackColor = Color.FromArgb(2, 170, 145);
            addPanel.Visible = false;
            editPanel.Visible = true;
            refreshEdit();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int teamempid;
        private string teamfname;
        private string teamlname;
        private string teammname;
        private int count;
        private Boolean empty = true;
        private void button17_Click(object sender, EventArgs e)
        {
            Boolean done = false;

            if (teamfname == "")
            {
                MessageBox.Show("Please select an employee");
            }
            else
            {
                if (done == false)
                {
                    this.newTeam.Rows.Add(teamempid, teamfname, teammname, teamlname);
                    foreach (DataGridViewRow row in allEmployees.SelectedRows)
                    {
                        allEmployees.Rows.RemoveAt(row.Index);
                    }
                    newTeam.Columns["Lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    newTeam.Columns["Firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    newTeam.Columns["Middlename"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    count = count + 1;
                    empty = false;

                    teamfname = "";
                    teamlname = "";
                    teammname = "";
                    teamempid = 0;
                }
            }



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.FromArgb(2, 170, 145);
            button15.BackColor = Color.FromArgb(2, 170, 145);
            newOperation.Visible = true;
            
            Operations.Visible = false;

            refreshTeam();
        }
        Boolean doneclick = false;
        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.FromArgb(251, 162, 80);
            button21.BackColor = Color.FromArgb(2, 170, 145);
           newOperation.Visible = true;
            
            Operations.Visible = false;
            

        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.FromArgb(251, 162, 80);
            button15.BackColor = Color.FromArgb(2, 170, 145);
            newOperation.Visible = false;
            
            Operations.Visible = true;

            refreshOperationsView();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = true;
            addEmployee.Visible = false;
            act.Visible = false;
            attendance.Visible = false; ;
           
            ne.Visible = false;
            a.Visible = false;
            ac.Visible = false;
            o.Visible = true;
            r.Visible = false;



        }
        int teamIDs;
        public void addOperation()
        {
            if (tbOpDate.Text != "Date (yyyy-mm-dd)" && cbLocation.Text != "Location" && tbStarth.Text != "Time Start (hh:mm)" && tbEndh.Text != "Time End (hh:mm)")
            {
                string date = tbOpDate.Text;
                
                string time = tbStarth.Text + ":" + tbStartm.Text + cbAMPMstart.Text + "-" + tbEndh.Text + ":" + tbEndm.Text + cbAMPMend.Text;
                try
                    {
                        conn.Open();
                        MySqlCommand comm = new MySqlCommand("SELECT locationID FROM location WHERE description = '" + cbLocation.Text + "'", conn);
                        MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        int locID = int.Parse(dt.Rows[0]["locationID"].ToString());

                        comm = new MySqlCommand("INSERT INTO dogoperation(teamID, locationID, date, time) VALUES ('" + teamIDs + "' , '" + locID + "', '" + date + "', '" + time + "')", conn);
                        comm.ExecuteNonQuery();

                        MessageBox.Show("Operation Added Successfully");
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
            editemployeeID = int.Parse(dgvEdit.Rows[e.RowIndex].Cells["personID"].Value.ToString());
        }

        public void refreshEdit()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT personID, lastname, firstname, middlename, gender, birthdate, contactNumber, status, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE status = 'Active'", conn);
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

        private void dgvEdit_SelectionChanged(object sender, EventArgs e)
        {

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
                    if(dt.Rows[0]["position"].ToString() == "Admin")
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

                        comm = new MySqlCommand("INSERT INTO admin(username, password, employeeID) VALUES('" + tbUser.Text +"', '" + tbPass.Text + "', " + personID + ")", conn);
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
            addOperation();
        }


        private void refreshAttendanceOut()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT personID, CONCAT(lastname, ', ', firstname, ' ', middlename) AS name, gender, contactNumber, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE status = 'Active' AND employee.employeeID IN (SELECT attendance.employeeID FROM attendance) ORDER BY lastname", conn); //missing: refresh everyday (in restrictions, date should be now)
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
                MessageBox.Show(ex.ToString());
                conn.Close();
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
            if (cbposition.Text != "Position")
            {
                cbposition.ForeColor = Color.Black;
            }
            if(cbposition.Text == "Admin")
            {
                pnlAdmin.Visible = true;
            }
            else
            {
                pnlAdmin.Visible = false;
            }
        }

        
        private void refreshTeam()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT personID, firstname, lastname, middlename FROM profile INNER JOIN employee ON employee.employeeID = profile.personID WHERE status = 'Active' AND position = 'Catcher' ORDER BY lastname", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                allEmployees.DataSource = dt;
                allEmployees.Columns["personID"].Visible = false;
                allEmployees.Columns["lastname"].HeaderText = "Lastname";
                allEmployees.Columns["firstname"].HeaderText = "Firstname";
                allEmployees.Columns["middlename"].HeaderText = "Middlename";

                allEmployees.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                allEmployees.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                allEmployees.Columns["middlename"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void allEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (int.Parse(allEmployees.Rows[e.RowIndex].Cells["personID"].Value.ToString()) != 0)
            {
                teamempid = int.Parse(allEmployees.Rows[e.RowIndex].Cells["personID"].Value.ToString());
                teamfname = allEmployees.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
                teamlname = allEmployees.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
                teammname = allEmployees.Rows[e.RowIndex].Cells["middlename"].Value.ToString();
            }
        }

        private void team_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void tbaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbcontactNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void tblname_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void tbmname_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tbfname_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tblname_MouseClick(object sender, MouseEventArgs e)
        {

            if (tblname.Text == "Lastname")
            {
                tblname.Text = "";
                tblname.ForeColor = Color.Black;
            }
        }

       
        private void dgvTeams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tbOpDate_Click(object sender, EventArgs e)
        {
            tbOpDate.Text = "";
            tbOpDate.ForeColor = Color.Black;
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

        private void tbOpDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void newOperation_VisibleChanged(object sender, EventArgs e)
        {
            doneclick = false;
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbbdaymonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvAttendanceIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshOperationsView()
        {
            try
            {
                conn.Open();
               
                MySqlCommand comm;
                    if (date == null)
                    {
                         comm = new MySqlCommand("SELECT date, time, description FROM dogoperation INNER JOIN location ON location.locationID = dogoperation.locationID ORDER BY operationID", conn);
                    }
                    else
                    {
                        comm = new MySqlCommand("SELECT date, time, description FROM dogoperation INNER JOIN location ON location.locationID = dogoperation.locationID WHERE date = '" + date + "' ORDER BY  operationID", conn);
                        date = null;
                    }
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvOperationsView.DataSource = dt;

                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "View Team";
                col.Name = "viewTeam";
                dgvOperationsView.Columns.Add(col);

                dgvOperationsView.Columns["description"].HeaderText = "Location";
                dgvOperationsView.Columns["date"].HeaderText = "Date";
                dgvOperationsView.Columns["time"].HeaderText = "Time";

                dgvOperationsView.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvOperationsView.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvOperationsView.Columns["time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            tbAct.Text = "";
        }

        private void dgvActivities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            actemployeeID = int.Parse(dgvActivities.Rows[e.RowIndex].Cells["personID"].Value.ToString());
        }

        private void attendance_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            viewAct view = new viewAct();
            view.Show();
            view.TopMost = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            refreshTeam();
            newTeam.Rows.Clear();
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
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

        private void button24_Click(object sender, EventArgs e)
        {
            if (editemployeeID != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to inactivate selected employee? This action cannot be undone.", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
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
                }
                refreshEdit();
            }
            else
            {
                MessageBox.Show("Please select an employee");
            }
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
            empty = true;
            int teamid = 0;
            int empID = 0;
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT MAX(teamID) FROM operationteam", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                teamid = int.Parse(dt.Rows[0]["MAX(teamID)"].ToString()) + 1;

                for (int i = 0; i < newTeam.Rows.Count - 1; i++)
                {
                    empID = int.Parse(newTeam.Rows[i].Cells["personID"].Value.ToString());
                    MySqlCommand commm = new MySqlCommand("INSERT INTO operationteam(teamID, employeeID) VALUES(" + teamid + ", " + empID + ")", conn);
                    commm.ExecuteNonQuery();
                }
                
                conn.Close();
                refreshTeam();
                newTeam.Rows.Clear();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }


        }

        private void button25_Click(object sender, EventArgs e)
        {
            home.dog.Show();
            this.Hide();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            home.inv.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {

        }
        
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
      

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        string date;
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
            refreshOperationsView();
        }
    }
}

