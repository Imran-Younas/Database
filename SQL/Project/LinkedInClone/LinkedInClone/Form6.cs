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
    public partial class Form6 : Form
    {
        public int Userid { get; set; }
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public Form6()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'linkedInDataSet6.User_ProfessionalSkills' table. You can move, or remove it, as needed.
            this.user_ProfessionalSkillsTableAdapter.Fill(this.linkedInDataSet6.User_ProfessionalSkills);
            cn.Open();
            String Query = "SELECT * FROM User_Profile ;";
            cmd = new SqlCommand(Query , cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (Userid == Int32.Parse(dr["UserID"].ToString()))
                {
                    text_FirstName.Text = dr["First_Name"].ToString();
                    text_LastName.Text = dr["Last_Name"].ToString();
                    text_Location.Text = dr["User_Location"].ToString();
                    text_PhoneNo.Text = dr["PhoneNo"].ToString();
                    cn.Close();
                    dr.Close();

                    cn.Open();
                    Query = "SELECT * FROM User_Education U " +
                            "LEFT JOIN User_Profile UP " +
                            "ON U.Profile_id = UP.Profile_id " +
                            "WHERE UP.UserID = " + Userid.ToString();
                    cmd = new SqlCommand(Query, cn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        text_InstituteName.Text = dr["Institute_Name"].ToString();
                        text_Degree.Text = dr["Degree"].ToString();
                        text_Edate.Text = dr["Ending_date"].ToString();
                        text_Sdate.Text = dr["Starting_date"].ToString();
                        cn.Close();
                        dr.Close();
                    }
                    else
                    {
                        cn.Close();
                        dr.Close();
                        MessageBox.Show("No user education data",
                            "Empty Data", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    cn.Open();
                    Query = "SELECT * FROM User_ProfessionalSkills U " +
                            "LEFT JOIN User_Profile UP " +
                            "ON U.Profile_id = UP.Profile_id " +
                            "WHERE UP.UserID = " + Userid.ToString();
                    SqlDataAdapter adapter = new SqlDataAdapter(Query, cn);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);

                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dtbl;
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Warning no active users found.",
                        "Invalid Session", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    cn.Close();
                    dr.Close();
                    this.Close();
                }
            }
            else
            {
                cn.Close();
                dr.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile up = new UserProfile();
            up.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
