using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Employee : Form
    {
        public int adminID;
        private int y;
        private Color use;
        public Home back { get; set; }
        public Employee()
        {
            InitializeComponent();
            y = -40;
            use = Color.FromArgb(253, 208, 174);
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
            addEmployee.Visible = true;
            act.Visible = false;
            attendance.Visible = false;
            admin.Visible = false;

            button1.BackColor = use;
            button2.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            selectButton.Visible = true;

            selectButton.Location = new Point(y, 3);
        }

        private void selectButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addEmployee.Visible = false;
            act.Visible = false;
            attendance.Visible = true;
            admin.Visible = false;

            button1.BackColor = Color.Transparent;
            button2.BackColor = use;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            selectButton.Visible = true;

            selectButton.Location = new Point(y, 76);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addEmployee.Visible = false;
            act.Visible = true;
            attendance.Visible = false;;
            admin.Visible = false;

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button5.BackColor = use;
            button6.BackColor = Color.Transparent;
            selectButton.Visible = true;

            selectButton.Location = new Point(y, 146);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addEmployee.Visible = false;
            act.Visible = false;
            attendance.Visible = false;
            admin.Visible = true;

            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = use;
            selectButton.Visible = true;

            selectButton.Location = new Point(y, 221);
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            this.Top = 278;
        }
    }
}
