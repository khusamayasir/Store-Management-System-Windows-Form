using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Store_Management_System
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-91IR7TI\\TEW_SQLEXPRESS;Initial Catalog=Store_Management_System;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select productname from product", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();

            label8.Text = Convert.ToString(DateTime.Now.ToString("MM/dd/yyyy"));
            progressBar1.Hide();
        }
        int count = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                string ab = textBox3.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-91IR7TI\\TEW_SQLEXPRESS;Initial Catalog=Store_Management_System;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from customer where username='" + ab + "'";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {

                    textBox1.Text = ds.Tables[0].Rows[0][1].ToString();
                    textBox2.Text = ds.Tables[0].Rows[0][2].ToString();


                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    MessageBox.Show("Invalid Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            progressBar1.Show();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 2000000;
            for (int i = 0; i <= 2000000; i++)
            {
                progressBar1.Value = i;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                    string cname = textBox1.Text;
                    int phone = Convert.ToInt32(textBox2.Text);
                    string product = comboBox1.Text;
                    int Quantity = Convert.ToInt32(textBox4.Text);


                SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-91IR7TI\\TEW_SQLEXPRESS;Initial Catalog=Store_Management_System;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into SShoping(username,cphone,pproductname,productqty)values('" + cname + "','" + phone + "','" + product + "','" + Quantity + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("product Issue", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Invalid No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            fm.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
