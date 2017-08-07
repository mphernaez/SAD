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
    public partial class Viewemp : Form
    {
        Employee emp { get; set; }
        public Viewemp()
        {
            InitializeComponent();
        }

        private void Viewemp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bgworkerEmployee_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgworkerEmployee_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgworkerEmployee_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
