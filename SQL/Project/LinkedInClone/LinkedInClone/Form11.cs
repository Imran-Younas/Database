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
    public partial class Form11 : Form
    {
        public int Userid { get; set; }
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public Form11()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (Userid != -1)
            {
                if (text_CompanyName.Text == "")
                {
                    MessageBox.Show("Company  name cannot be empty. Please enter your Company name.",
                        "Empty Field", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (text_JobPostion.Text == "")
                {
                    MessageBox.Show("Job Position cannot be empty. Please enter your Job Position.",
                        "Empty Field", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (text_Sdate.Text == "")
                {
                    MessageBox.Show("Starting date cannot be empty. Please enter Starting date.",
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

                if (text_JobDescription.Text == "")
                {
                    MessageBox.Show("Job description cannot be empty. Please enter Job description.",
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
                Query = "INSERT INTO User_ProfessionalSkills (Profile_id , Company_Name , JobPosition , JobDescription , Starting_date , Ending_date) " +
                        "VALUES (@profileid , @cname , @position , @jobdescription , @sd , @ed) ;";
                cn.Open();
                cmd = new SqlCommand(Query, cn);
                cmd.Parameters.AddWithValue("@cname", text_CompanyName.Text);
                cmd.Parameters.AddWithValue("@position", text_JobPostion.Text);
                cmd.Parameters.AddWithValue("@jobdescription",text_JobDescription.Text);
                cmd.Parameters.AddWithValue("@profileid", pid.ToString());
                cmd.Parameters.AddWithValue("@sd", DateTime.ParseExact(text_Sdate.Text, "dd-MM-yyyy", null));
                cmd.Parameters.AddWithValue("@ed", DateTime.ParseExact(text_Edate.Text, "dd-MM-yyyy", null));
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Professional skill has been added succesfully", "Professional skill Addition Successful",
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
            UserProfile UP = new UserProfile();
            UP.ShowDialog();
            this.Hide();
        }
    }
}
