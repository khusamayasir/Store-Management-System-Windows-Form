using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Store_Management_System
{
    class DAL
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91IR7TI\\TEW_SQLEXPRESS;Initial Catalog=Store_Management_System;Integrated Security=True");
        public bool login(string myusername, string mypass)
        {
            string loginvalue = "select username,pass from [owner] where username='" + myusername + "'and pass= '" + mypass + "'";
            conn.Open();
            SqlCommand com = new SqlCommand(loginvalue, conn);
            SqlDataReader rdr;
            rdr = com.ExecuteReader();
            return rdr.Read();
        }
         
        public void insert(int modelnumber, string productname, int retailcost, int wholesalecost, int quantity)
        {
            string insrt = "insert into product values('" + modelnumber + "','" + productname+ "','" + retailcost + "','" + wholesalecost + "','" + quantity + "')";
            SqlCommand com = new SqlCommand(insrt, conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }

        public bool loginC(string myusername, string mypass)
        {
            string loginvalue = "select username,pass from [customer] where username='" + myusername + "'and pass= '" + mypass + "'";
            conn.Open();
            SqlCommand com = new SqlCommand(loginvalue, conn);
            SqlDataReader rdr;
            rdr = com.ExecuteReader();
            return rdr.Read();
        }

        public void insertC(string username, int cphone, string pass)
        {
            string insrt = "insert into customer values('" + username + "','" + cphone + "','" + pass + "')";
            SqlCommand com = new SqlCommand(insrt, conn);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
    }
}
