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
    public partial class viewAct : Form
    {
        Employee emp { get; set; }
        public MySqlConnection conn;
        public viewAct()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand com = new MySqlCommand("SELECT date, lastname, firstname, type FROM activity JOIN profile ON activity.employeeID = profile.personID ORDER BY date", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);


                dgvViewAct.DataSource = dt;

                dgvViewAct.Columns["date"].HeaderText = "Date";
                dgvViewAct.Columns["lastname"].HeaderText = "Lastame";
                dgvViewAct.Columns["firstname"].HeaderText = "Firstname";
                dgvViewAct.Columns["type"].HeaderText = "Type of Activity";
                dgvViewAct.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewAct.Columns["lastname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewAct.Columns["firstname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewAct.Columns["type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void bgworkerEmployee_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
