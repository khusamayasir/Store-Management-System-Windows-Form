using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Store_Management_System
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(DateTime.Now.ToString("MM/dd/yyyy"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91IR7TI\\TEW_SQLEXPRESS;Initial Catalog=Store_Management_System;Integrated Security=True");
            string sel = "select * from inv_detail";
            SqlDataAdapter ad = new SqlDataAdapter(sel, conn);
            conn.Open();
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
