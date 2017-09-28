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
    
    public partial class EditAct : Form
    {
        public Employee emp { get; set; }
        public MySqlConnection conn = new MySqlConnection();
        public EditAct()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
        }

        public int actID;
        string employeename;
        string activity;
        int[] ids;
        string[] employees;
        private void EditAct_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                MySqlCommand commm = new MySqlCommand("UPDATE activity SET status = 'Hold' WHERE activityID = " + actID, conn);
                commm.ExecuteNonQuery();
                MySqlCommand comm = new MySqlCommand("SELECT DISTINCT employee.employeeID AS emp, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS name, position "
                                                    + "FROM employee "
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
                                                    + " WHERE dogoperation.status = 'OnGoing') "
                                                    + "AND employee.employeeID NOT IN (SELECT employeeID FROM activity WHERE status = 'OnGoing')", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                ids = new int[dt.Rows.Count];
                employees = new string[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    employees[i] = dt.Rows[i]["name"].ToString() + " - " + dt.Rows[i]["position"].ToString();
                    cbemp.Items.Add(employees[i]);
                    ids[i] = int.Parse(dt.Rows[i]["emp"].ToString());
                }

                comm = new MySqlCommand("SELECT type AS Type, CONCAT(lastname, ', ', firstname, ' ', SUBSTRING(middlename, 1, 1), '.') AS Name, position FROM activity INNER JOIN profile ON profile.personID = activity.employeeID INNER JOIN employee ON employee.employeeID = activity.employeeID WHERE activityID = " + actID, conn);
                adp = new MySqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);

                activity = dt.Rows[0]["Type"].ToString();
                employeename = dt.Rows[0]["Name"].ToString() + " - " + dt.Rows[0]["position"].ToString();

                cbact.SelectedIndex = cbact.FindString(activity);
                cbemp.SelectedIndex = cbemp.FindString(employeename);

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand commm = new MySqlCommand("UPDATE activity SET status = 'OnGoing' WHERE activityID = " + actID, conn);
                commm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
            this.Dispose();

        }

        private void button38_Click(object sender, EventArgs e)
        {
            try{
                conn.Open();
                MySqlCommand comm = new MySqlCommand("UPDATE activity SET status = 'OnGoing', employeeID = "+ids[cbemp.SelectedIndex]+", type = '"+cbact.Text+"' WHERE activityID = " + actID, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Activity Successfully Edited");
                
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
            emp.refreshUpAct();
            this.Dispose();
        }
    }
}
