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
    public partial class Viewdog : Form
    {
        public Dog dog { get; set; }
        public MySqlConnection conn;
        public Viewdog()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Viewdog_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand com = new MySqlCommand("SELECT breed, gender, size, color, otherDesc, description, date, CONCAT(timeStart , ' - ', timeEnd) AS time, dogprofile.status FROM dogprofile INNER JOIN dogoperation ON dogoperation.operationID = dogprofile.operationID INNER JOIN location ON location.locationID = dogoperation.locationID WHERE dogprofile.status = 'unclaimed' ORDER BY date", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);


                dgvViewDog.DataSource = dt;

                dgvViewDog.Columns["breed"].HeaderText = "Breed";
                dgvViewDog.Columns["gender"].HeaderText = "Gender";
                dgvViewDog.Columns["size"].HeaderText = "Size";
                dgvViewDog.Columns["color"].HeaderText = "Color";
                dgvViewDog.Columns["otherDesc"].HeaderText = "Other Description";
                dgvViewDog.Columns["description"].HeaderText = "Location Caught";
                dgvViewDog.Columns["date"].HeaderText = "Date Caught";
                dgvViewDog.Columns["time"].HeaderText = "Time Caught";
                dgvViewDog.Columns["status"].HeaderText = "Status";


                dgvViewDog.Columns["breed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewDog.Columns["gender"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewDog.Columns["size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewDog.Columns["color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewDog.Columns["otherDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewDog.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewDog.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewDog.Columns["time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvViewDog.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


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
