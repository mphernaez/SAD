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
    public partial class Login : Form
    {
        public MySqlConnection conn;
        public empty hom { get; set; }
        public Login()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            usernameTextBox.ForeColor = Color.Gray;
            if (usernameTextBox.Text == "")
                usernameTextBox.ForeColor = Color.LightGray;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM admin" , conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    String user = dt.Rows[i]["username"].ToString();
                    String pass = dt.Rows[i]["password"].ToString();
                    if (usernameTextBox.Text == user && passwordTextBox.Text == pass)
                    {
                        empty home = new empty();
                        home.dispUser = user;
                        home.adminID = int.Parse(dt.Rows[0]["adminID"].ToString());
                        home.log = this;
                        this.Hide();
                        home.Show();
                        flag = true;
                        break;
                    }
                }

                if(flag == false)
                {
                    label2.Text = "Incorrect username and/or password";
                    label2.ForeColor = Color.White;
                }
                conn.Close();
            }
            catch (Exception ex) {
                
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.ForeColor = Color.Gray;
            if (passwordTextBox.Text == "")
                passwordTextBox.ForeColor = Color.LightGray;
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•';
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string yesterday = DateTime.Now.Date.AddDays(-6).ToString("yyyy-MM-dd");
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT employeeID FROM employee", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                int[] emps = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    emps[i] = int.Parse(dt.Rows[i]["employeeID"].ToString());
                }

                comm = new MySqlCommand("SELECT employee.employeeID AS emp FROM employee WHERE employee.employeeID NOT IN(SELECT employee.employeeID FROM employee INNER JOIN attendance ON attendance.employeeID = employee.employeeID WHERE date = '"+yesterday+ "' AND type = 0) AND employee.employeeID IN (SELECT employee.employeeID FROM employee INNER JOIN attendance ON attendance.employeeID = employee.employeeID WHERE date = '"+yesterday+"' AND type = 1)", conn); 
                adp = new MySqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MySqlCommand com = new MySqlCommand("INSERT INTO attendance(date, employeeID, type, time) VALUES('"+yesterday+"', "+int.Parse(dt.Rows[i]["emp"].ToString())+", '0', '16:00')", conn);
                    com.ExecuteNonQuery();
                }



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
