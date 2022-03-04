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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(DateTime.Now.ToString("MM/dd/yyyy"));
            progressBar1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            bool check = dal.login(textBox1.Text, textBox2.Text);
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
                Form3 fm = new Form3();
                fm.Show();
            }
            else
            {
                MessageBox.Show(" Invalid user name and/or password ........");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
