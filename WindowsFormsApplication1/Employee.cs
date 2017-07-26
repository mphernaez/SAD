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
    public partial class Employee : Form
    {
        public int adminID;
        private int y;
        private Color use;
        
        public Home back { get; set; }
        public MySqlConnection conn = new MySqlConnection();
       EditEmp emp;
        public Employee()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
            y = -40;
            use = Color.FromArgb(253, 208, 174);
            emp = new EditEmp(this);
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

        private void btnDone_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = true;
            act.Visible = false;
            attendance.Visible = false;
            admin.Visible = false;

            button14.BackColor = Color.Transparent;
            button1.BackColor = use;
            button2.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            selectButton.Visible = true;
            button8.BackColor = Color.Transparent;

            selectButton.Location = new Point(y, 7);
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
            admin.Visible = false;
            button14.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button2.BackColor = use;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            selectButton.Visible = true;
            button8.BackColor = Color.Transparent;

            selectButton.Location = new Point(y, 70);

            refreshAttendance();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = false;
            act.Visible = true;
            attendance.Visible = false;;
            admin.Visible = false;

            button14.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button5.BackColor = use;
            button6.BackColor = Color.Transparent;
            selectButton.Visible = true;

            button8.BackColor = Color.Transparent;

            selectButton.Location = new Point(y, 134);

            refreshActivity();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = false;
            act.Visible = false;
            attendance.Visible = false;
            admin.Visible = true;

            button14.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = use;
            selectButton.Visible = true;

            button8.BackColor = Color.Transparent;

            selectButton.Location = new Point(y, 196);

            refreshAdmin();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            this.Top = 278;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = false;
            panel1.VerticalScroll.Visible = false;
            panel1.AutoScroll = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
    
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = false;
            addEmployee.Visible = false;
            act.Visible = false;
            attendance.Visible = false;
            admin.Visible = false;

            button14.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button8.BackColor = use;
            selectButton.Visible = true;

            selectButton.Location = new Point(y,327);
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
            tbbday.Clear();
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
                MySqlCommand comm = new MySqlCommand("SELECT personID, lastname, firstname, middlename, gender, contactNumber, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE status = 'Active' AND employee.employeeID NOT IN (SELECT attendance.employeeID FROM attendance)", conn); //missing: refresh everyday (in restrictions, date should be now)
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvAttendanceIn.DataSource = dt;

                dgvAttendanceIn.Columns["personID"].Visible = false;
                dgvAttendanceIn.Columns["lastname"].HeaderText = "Lastname";
                dgvAttendanceIn.Columns["firstname"].HeaderText = "Firstname";
                dgvAttendanceIn.Columns["middlename"].HeaderText = "Middlename";
                dgvAttendanceIn.Columns["gender"].HeaderText = "Gender";
                dgvAttendanceIn.Columns["contactNumber"].HeaderText = "Contact No.";
                dgvAttendanceIn.Columns["position"].HeaderText = "Position";
                dgvAttendanceIn.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAttendanceIn.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAttendanceIn.Columns["middlename"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void refreshAdmin()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT personID, lastname, firstname, middlename, gender, birthdate, contactNumber, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE status = 'Active' AND employee.employeeID NOT IN (SELECT admin.employeeID FROM admin)", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvAdmin.DataSource = dt;

                dgvAdmin.Columns["personID"].Visible = false;
                dgvAdmin.Columns["lastname"].HeaderText = "Lastname";
                dgvAdmin.Columns["firstname"].HeaderText = "Firstname";
                dgvAdmin.Columns["middlename"].HeaderText = "Middlename";
                dgvAdmin.Columns["gender"].HeaderText = "Gender";
                dgvAdmin.Columns["birthdate"].HeaderText = "Gender";
                dgvAdmin.Columns["contactNumber"].HeaderText = "Contact No.";
                dgvAdmin.Columns["position"].HeaderText = "Position";
                dgvAdmin.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAdmin.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAdmin.Columns["middlename"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAdmin.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAdmin.Columns["contactNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAdmin.Columns["position"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAdmin.Columns["birthdate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Clear();
        }

        private void refreshActivity()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT personID, lastname, firstname, middlename, gender, birthdate, contactNumber, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE status = 'Active'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvActivities.DataSource = dt;

                dgvActivities.Columns["personID"].Visible = false;
                dgvActivities.Columns["lastname"].HeaderText = "Lastname";
                dgvActivities.Columns["firstname"].HeaderText = "Firstname";
                dgvActivities.Columns["middlename"].HeaderText = "Middlename";
                dgvActivities.Columns["gender"].HeaderText = "Gender";
                dgvActivities.Columns["birthdate"].HeaderText = "Gender";
                dgvActivities.Columns["contactNumber"].HeaderText = "Contact No.";
                dgvActivities.Columns["position"].HeaderText = "Position";
                dgvActivities.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvActivities.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvActivities.Columns["middlename"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            button3.BackColor = Color.MistyRose;
            button10.BackColor = Color.FromArgb(240, 148, 80);
            dgvAttendanceIn.Visible = true;
            dgvAttendanceOut.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.MistyRose;
            button3.BackColor = Color.FromArgb(240, 148, 80);
            dgvAttendanceIn.Visible = false;
            dgvAttendanceOut.Visible = true;

            refreshAttendanceOut();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(253, 208, 174);
            button12.BackColor = Color.FromArgb(240, 148, 80);
            addPanel.Visible = true;
            editPanel.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(253, 208, 174);
            button11.BackColor = Color.FromArgb(240, 148, 80);
            addPanel.Visible = false;
            editPanel.Visible = true;
            refreshEdit();
        }
        
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private int teamempid;
        private string teamfname;
        private string teamlname;
        private string teammname;
        private void button17_Click(object sender, EventArgs e)
        {

            this.newTeam.Rows.Add(teamfname, teammname, teamlname);

            newTeam.Columns["Lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            newTeam.Columns["Firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            newTeam.Columns["Middlename"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.FromArgb(253, 208, 174);
            button21.BackColor = Color.FromArgb(240, 148, 80);
            button15.BackColor = Color.FromArgb(240, 148, 80);
            team.Visible = true;
            newOperation.Visible = false;
            Operations.Visible = false;

            refreshTeam();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.FromArgb(253, 208, 174);
            button21.BackColor = Color.FromArgb(240, 148, 80);
            button16.BackColor = Color.FromArgb(240, 148, 80);
            team.Visible = false;
            newOperation.Visible = true;
            Operations.Visible = false;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.FromArgb(253, 208, 174);
            button15.BackColor = Color.FromArgb(240, 148, 80);
            button16.BackColor = Color.FromArgb(240, 148, 80);
            team.Visible = false;
            newOperation.Visible = false;
            Operations.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DogCatchingOperation.Visible = true;
            addEmployee.Visible = false;
            act.Visible = false;
            attendance.Visible = false; ;
            admin.Visible = false;

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button14.BackColor = use;
            selectButton.Visible = true;

            button8.BackColor = Color.Transparent;

            selectButton.Location = new Point(y, 263);

           
        }
        public void addOperation()
        {
            if (opDateTime.Text != "" || cbLocation.Text != "")
            {
                string date = "";
                string datetimes = opDateTime.Value.ToString();
                string time = "";
                if (datetimes.Substring(1) == "/" && datetimes.Substring(3) == "/") //m-d-yyy
                {
                    date = datetimes.Substring(4, 8) + "-" + datetimes.Substring(0) + "-" + datetimes.Substring(2);
                    time = datetimes.Substring(9, 19);
                }
                else if (datetimes.Substring(2) == "/" && datetimes.Substring(4) == "/") //mm-d-yyy
                {
                    date = datetimes.Substring(5, 9) + "-" + datetimes.Substring(0, 2) + "-" + datetimes.Substring(3);
                    time = datetimes.Substring(10, 20);
                }
                else if (datetimes.Substring(1) == "/" && datetimes.Substring(4) == "/") //m-dd-yyy
                {
                    date = datetimes.Substring(5, 9) + "-" + datetimes.Substring(0) + "-" + datetimes.Substring(2, 4);
                    time = datetimes.Substring(10, 20);
                }
                else if (datetimes.Substring(2) == "/" && datetimes.Substring(5) == "/") //mm-dd-yyyy
                {
                    date = datetimes.Substring(4, 8) + "-" + datetimes.Substring(0) + "-" + datetimes.Substring(2);
                    time = datetimes.Substring(11, 21);
                }
                
                
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT locationID FROM location WHERE description = '" + cbLocation.Text + "'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    int locID = int.Parse(dt.Rows[0]["locationID"].ToString());

                    comm = new MySqlCommand("INSERT INTO dogoperation(teamID, locationID, date, time) VALUES ('" + opDateTime.Text + "' , '" + locID + "', '" + date + "')" , conn);
                    comm.ExecuteNonQuery();

                    
                    adp = new MySqlDataAdapter(comm);
                    dt = new DataTable();
                    adp.Fill(dt);

                    dgAddOperations.DataSource = dt;

                    dgAddOperations.Columns["operationID"].Visible = false;
                    dgAddOperations.Columns["teamID"].HeaderText = "Team";
                    dgAddOperations.Columns["locationID"].HeaderText = "Location";
                    dgAddOperations.Columns["date"].HeaderText = "Date";
                    dgAddOperations.Columns["time"].HeaderText = "Time";
                    dgAddOperations.Columns["teamID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgAddOperations.Columns["locationID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgAddOperations.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgAddOperations.Columns["time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    MessageBox.Show("Operation Added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
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
                MySqlCommand comm = new MySqlCommand("SELECT personID, lastname, firstname, middlename, gender, birthdate, contactNumber, status, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID", conn);
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
                    emp.cbstatus.Text = dt.Rows[0]["status"].ToString();
                    emp.cbposition.Text = dt.Rows[0]["position"].ToString();
                    emp.tblname.Text = dt.Rows[0]["lastname"].ToString();
                    emp.tbfname.Text = dt.Rows[0]["firstname"].ToString();
                    emp.tbmname.Text = dt.Rows[0]["middlename"].ToString();
                    emp.tbcontactNumber.Text = dt.Rows[0]["contactNumber"].ToString();
                    emp.id = int.Parse(dt.Rows[0]["personID"].ToString());
                    emp.tbaddress.Text = dt.Rows[0]["address"].ToString();
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
                MessageBox.Show("Please select an employee");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
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
            string bday = tbbday.Text;
            string position = cbposition.Text;
            string status = cbstatus.Text;

            if (tblname.Text != "Lastname" && tbmname.Text != "Middlename" && tbfname.Text != "Firstname" && tbaddress.Text != "Address" && cbgender.Text != "Gender" && tbcontactNumber.Text != "Contact Number" && cbposition.Text != "Position" && cbstatus.Text != "Status" && tbbday.Text != "Birthday (mm-dd-yyyy)")
            {
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

                    comm = new MySqlCommand("INSERT INTO employee(employeeID, position, status) VALUES('" + personID + "', '" + position + "', '" + status + "')", conn);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Profile Added Successfully");

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
            else if (tbbday.Text.Substring(4) != "-" || tbbday.Text.Substring(7) != "-")
            {
                MessageBox.Show("Please use valid birthdate format");
            }
            else
            {
                MessageBox.Show("Please Enter Required Fields");
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            addOperation();
            refreshOperation();
        }


        private void refreshAttendanceOut()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT personID, lastname, firstname, middlename, gender, contactNumber, position FROM profile INNER JOIN employee ON profile.personID = employee.employeeID WHERE status = 'Active' AND employee.employeeID IN (SELECT attendance.employeeID FROM attendance)", conn); //missing: refresh everyday (in restrictions, date should be now)
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvAttendanceOut.DataSource = dt;

                dgvAttendanceOut.Columns["personID"].Visible = false;
                dgvAttendanceOut.Columns["lastname"].HeaderText = "Lastname";
                dgvAttendanceOut.Columns["firstname"].HeaderText = "Firstname";
                dgvAttendanceOut.Columns["middlename"].HeaderText = "Middlename";
                dgvAttendanceOut.Columns["gender"].HeaderText = "Gender";
                dgvAttendanceOut.Columns["contactNumber"].HeaderText = "Contact No.";
                dgvAttendanceOut.Columns["position"].HeaderText = "Position";
                dgvAttendanceOut.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAttendanceOut.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAttendanceOut.Columns["middlename"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void tblname_TextChanged(object sender, EventArgs e)
        {

           

        }
        private void tbmname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbfname_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tblname_MouseClick(object sender, MouseEventArgs e)
        {

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

        }

        private void cbgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbbday_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tbaddress_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tbcontactNumber_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cbposition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newOperation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refreshOperation()
        {
            
        }
        private void refreshTeam()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT personID, firstname, lastname, middlename FROM profile INNER JOIN employee ON employee.employeeID = profile.personID WHERE status = 'Active' AND position = 'Catcher' ", conn);
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
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void allEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            teamempid = int.Parse(allEmployees.Rows[e.RowIndex].Cells["personID"].Value.ToString());
            teamfname = allEmployees.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
            teamlname = allEmployees.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
            teammname = allEmployees.Rows[e.RowIndex].Cells["middlename"].Value.ToString();
        }

        private void team_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}

