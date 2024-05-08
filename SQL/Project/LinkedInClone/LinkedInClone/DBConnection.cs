using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LinkedInClone
{
    public class DBConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        private string conn;

        public string MyConnection()
        {
            conn = @"Data Source = LAPTOP-1U3PBG58\SQLEXPRESS ; Initial Catalog = LinkedIn ; Integrated Security = true";
            return conn;
        }
    }
}
