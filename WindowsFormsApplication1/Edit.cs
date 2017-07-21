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
    public partial class EditEmp : Form
    {
        public int id;
        public int employeeID;
        public Employee emp { get; set; }
        public MySqlConnection conn = new MySqlConnection();
        public EditEmp()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=dogpound;Uid=root;Pwd=root;");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
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

            if (tblname.Text != "" && tbmname.Text != "" && tbfname.Text != "" && tbaddress.Text != "" && cbgender.Text != "" && tbcontactNumber.Text != "" && cbposition.Text != "" && cbstatus.Text != "" && tbbday.Text != "")
            {
                try
                {
                    conn.Open();

                    MySqlCommand comm = new MySqlCommand("UPDATE profile SET lastname = '" + lname + "', middlename = '" + mname + "', firstname = '" + fname + "', gender = '" + gender + "', address = '" + address + "', contactNumber = '" + contact + "', birthdate = '" + bday + "' WHERE personID = " + id, conn);
                    comm.ExecuteNonQuery();

                    comm = new MySqlCommand("UPDATE employee SET position = '" + position + "', status = '" + status + "' WHERE employeeID = " + id, conn);
                    comm.ExecuteNonQuery();
                    
                    MessageBox.Show("Profile Edited Successfully");

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
            this.emp.refreshEdit();
        }

        private void EditEmp_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
