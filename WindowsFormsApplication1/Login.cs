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
        public Home hom { get; set; }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
                        Home home = new Home();
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
                }
                conn.Close();
            }
            catch (Exception ex) {
                
                MessageBox.Show(ex.ToString());
                conn.Close();
            }

        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
    }
}
