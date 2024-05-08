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
    public partial class Form9 : Form
    {
        public int Userid { get; set; }
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public Form9()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (Userid != -1)
            {
                if (text_InstituteName.Text == "")
                {
                    MessageBox.Show("Institution  name cannot be empty. Please enter your institution name.",
                        "Empty Field", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (text_Degree.Text == "")
                {
                    MessageBox.Show("Degree name cannot be empty. Please enter your Degree.",
                        "Empty Field", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (text_Sdate.Text == "")
                {
                    MessageBox.Show("Ending date cannot be empty. Please enter Ending date.",
                        "Empty Field", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (text_Edate.Text == "")
                {
                    MessageBox.Show("Ending date cannot be empty. Please enter Ending date.",
                        "Empty Field", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                cn.Open();
                String Query = "SELECT * FROM User_Profile " +
                               "WHERE UserID = " + Userid.ToString() + " ; ";
                cmd = new SqlCommand(Query, cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                int pid = Convert.ToInt32(dr["Profile_id"]);
                    cn.Close();
                    dr.Close();
                    Query = "INSERT INTO User_Education (Profile_id , Institute_Name , Degree , Starting_date , Ending_date) " +
                            "VALUES (@profileid , @inst , @degree , @sd , @ed) ;";
                    cn.Open();
                    cmd = new SqlCommand(Query, cn);
                    cmd.Parameters.AddWithValue("@inst", text_InstituteName.Text);
                    cmd.Parameters.AddWithValue("@Degree", text_Degree.Text);
                    cmd.Parameters.AddWithValue("@profileid", pid.ToString());
                    cmd.Parameters.AddWithValue("@sd", DateTime.ParseExact(text_Sdate.Text, "dd-MM-yyyy", null));
                    cmd.Parameters.AddWithValue("@ed", DateTime.ParseExact(text_Edate.Text, "dd-MM-yyyy", null));
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Education has been added succesfully", "Education Addition Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Warning no active users found.",
                    "Invalid Session", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp SP = new SignUp();
            SP.ShowDialog();
            this.Hide();
        }
    }
}
