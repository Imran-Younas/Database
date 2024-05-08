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

namespace LinkedInClone
{
    public partial class Form16 : Form
    {
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cm = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public Form16()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                /* string query = "SELECT FirstName FROM Users WHERE UserID = @userID";
                 SqlCommand command = new SqlCommand(query, cn);
                 command.Parameters.AddWithValue("@userID", ); 

                 SqlDataReader reader = command.ExecuteReader();

                 if (reader.Read())
                 {
                     string firstName = reader["FirstName"].ToString();
                     textBox1.Text = firstName;
                 }*/


                cm = new SqlCommand("select * from Users where FirstName = @first and LastName = @last and Email=@email", cn);
                cm.Parameters.AddWithValue("@first", textBox1.Text);
                cm.Parameters.AddWithValue("@last", textBox2.Text);
                cm.Parameters.AddWithValue("@email", textBox3.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {

                    DateTime applicationDate = DateTime.Now;


                    string eemail = textBox3.Text;

                    string query = "SELECT UserID FROM Users WHERE Email = @Email";
                    cn.Close();
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, cn))

                        cmd.Parameters.AddWithValue("@Email", eemail);

                    object result = cm.ExecuteScalar();

                    int UserID = 0;
                    if (result != null)
                    {
                         UserID = Convert.ToInt32(result);

                    }
                    cn.Close();
                    cn.Open();
                    string query1 = "INSERT INTO JobApplication (UserID, JOBID,Profile_id,Resume_CV,CoverLetter,ApplyDate) " +
                               "VALUES (@UserID, @JobID, @Pro,@CV,@Cover,@date)";
                    SqlCommand command = new SqlCommand(query1, cn);
                    command.Parameters.AddWithValue("@UserID", UserID.ToString());
                    command.Parameters.AddWithValue("@JobID", textBox4.Text);
                    command.Parameters.AddWithValue("@Pro", textBox6.Text);
                    command.Parameters.AddWithValue("@CV", textBox5.Text);
                    command.Parameters.AddWithValue("@Cover", textBox7.Text);
                    command.Parameters.AddWithValue("@date", applicationDate);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Application Submitted!", "Succeed", MessageBoxButtons.OK);
                }
                else
                {

                    MessageBox.Show("Wrong Information", "Failed", MessageBoxButtons.OK);
                }

                

                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dr.Close();
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hm  = new Homepage();
            hm.ShowDialog();
            this.Hide();
        }
    }
}
