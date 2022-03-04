using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management_System
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(DateTime.Now.ToString("MM/dd/yyyy"));
            progressBar1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 2000000;
            for (int i = 0; i <= 2000000; i++)
            {
                progressBar1.Value = i;
            }
            this.Hide();
            Form9 fm = new Form9();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 2000000;
            for (int i = 0; i <= 2000000; i++)
            {
                progressBar1.Value = i;
            }
            this.Hide();
            Form11 fm = new Form11();
            fm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
            this.Hide();
        }
    }
}
