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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(DateTime.Now.ToString("MM/dd/yyyy"));
            progressBar1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
            this.Hide();
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
            DAL dal = new DAL();
            dal.insertC(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text);
            MessageBox.Show("Successfully SignUp.");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            Form6 fm = new Form6();
            fm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
