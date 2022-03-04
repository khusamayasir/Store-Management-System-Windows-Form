using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management_System
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91IR7TI\\TEW_SQLEXPRESS;Initial Catalog=Store_Management_System;Integrated Security=True");
            string sel = "select distinct username from SShoping";
            SqlDataAdapter ad = new SqlDataAdapter(sel, conn);
            conn.Open();
            DataSet dt = new DataSet();
            ad.Fill(dt,"Customer");

            cmbcustomer.DisplayMember = "username";
            cmbcustomer.ValueMember = "username";
            cmbcustomer.DataSource = dt.Tables["Customer"];
            conn.Close();

            progressBar1.Hide();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 2000000;
            for (int i = 0; i <= 2000000; i++)
            {
                progressBar1.Value = i;
            }

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91IR7TI\\TEW_SQLEXPRESS;Initial Catalog=Store_Management_System;Integrated Security=True");
            string sel = "select username ,cphone,pproductname ,productqty  from SShoping where username ='"+ cmbcustomer.Text + "'";
            SqlDataAdapter ad = new SqlDataAdapter(sel, conn);
            conn.Open();
            DataSet dt = new DataSet();
            ad.Fill(dt, "Customer");
            dataGridView1.DataSource = dt.Tables["Customer"];
            conn.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            fm.Show();
            this.Hide();
        }
    }
}
