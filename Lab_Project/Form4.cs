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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            label8.Text = Convert.ToString(DateTime.Now.ToString("MM/dd/yyyy"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.insert(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            MessageBox.Show("Your Order is Placed.");
            textBox1.Clear();
            textBox2.Clear(); 
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }
    }
}
