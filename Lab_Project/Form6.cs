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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(DateTime.Now.ToString("MM/dd/yyyy"));
            progressBar1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            bool check = dal.loginC(textBox1.Text, textBox2.Text);
            if (check == true)
            {
                progressBar1.Show();
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 2000000;
                for (int i = 0; i <= 2000000; i++)
                {
                    progressBar1.Value = i;
                }
                this.Hide();
                Form7 fm = new Form7();
                fm.Show();
            }
            else
            {
                MessageBox.Show(" Invalid user name and/or password ........");
                textBox1.Clear();
                textBox2.Clear();
            }
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
            Form8 fm = new Form8();
            fm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
