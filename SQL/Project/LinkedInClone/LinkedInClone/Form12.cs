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
    public partial class Form12 : Form
    {
        public int Userid { get; set; }
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public int pid = 0;
        public Form12()
        {
            InitializeComponent();
            cn=new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'linkedInDataSet6.User_ProfessionalSkills' table. You can move, or remove it, as needed.
            this.user_ProfessionalSkillsTableAdapter.Fill(this.linkedInDataSet6.User_ProfessionalSkills);
            cn.Open();
            string Query = "SELECT * FROM User_ProfessionalSkills U " +
                           "LEFT JOIN User_Profile UP " +
                           "ON U.Profile_id = UP.Profile_id " +
                           "WHERE UP.UserID = " + Userid.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(Query, cn);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtbl;
            cn.Close();

            cn.Open();
            Query = "SELECT * FROM User_ProfessionalSkills U " +
                    "LEFT JOIN User_Profile UP " +
                    "ON U.Profile_id = UP.Profile_id " +
                    "WHERE UP.UserID = " + Userid.ToString();
            cmd = new SqlCommand(Query, cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                pid = Convert.ToInt32(dr["Profile_id"].ToString());
            }
            cn.Close();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (Userid != -1)
            {
                cn.Open();
                String Query1 = "SELECT * FROM User_ProfessionalSkills " +
                               " WHERE Profession_id = " + text_ProfessionID.Text + " ;";
                cmd = new SqlCommand(Query1, cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    int pid2 = Convert.ToInt32(dr["Profile_id"].ToString());
                    cn.Close();
                    dr.Close();
                    if (pid == pid2)
                    {
                        int count = 0;
                        if (text_CompanyName.Text != "")
                        {
                            cn.Open();
                            string Query = "UPDATE User_ProfessionalSkills " +
                                           "SET Company_Name = " + text_CompanyName.Text +
                                           " WHERE Profession_id = " + text_ProfessionID.Text;
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            count++;
                        }

                        if (text_JobPostion.Text != "")
                        {
                            cn.Open();
                            string Query = "UPDATE User_ProfessionalSkills " +
                                           "SET JobPosition = " + text_JobPostion.Text +
                                           " WHERE Profession_id = " + text_ProfessionID.Text;
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            count++;
                        }

                        if (text_JobDescription.Text == "")
                        {
                            cn.Open();
                            string Query = "UPDATE User_ProfessionalSkills " +
                                           "SET JobDescription = " + text_JobDescription.Text +
                                           " WHERE Profession_id = " + text_ProfessionID.Text;
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            count++;
                        }
                        if (text_Sdate.Text != "")
                        {
                            cn.Open();
                            string Query = "UPDATE User_ProfessionalSkills " +
                                           "SET Starting_date = " + DateTime.ParseExact(text_Sdate.Text, "dd-MM-yyyy", null) +
                                           " WHERE Profession_id = " + text_ProfessionID.Text;
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            count++;
                        }

                        if (text_Edate.Text != "")
                        {
                            cn.Open();
                            string Query = "UPDATE User_ProfessionalSkills " +
                                           "SET Ending_date = " + DateTime.ParseExact(text_Edate.Text, "dd-MM-yyyy", null) +
                                           " WHERE Profession_id = " + text_ProfessionID.Text;
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            count++;
                        }

                        if (count > 0)
                        {
                            MessageBox.Show("Skill Profile Edited");
                        }
                        else
                        {
                            MessageBox.Show("Fields cannot be empty to edit Professional skill Profile.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot edit Professional skills profiles other than your own.");
                    }
                }
                else
                {
                    cn.Close();
                    dr.Close();
                    MessageBox.Show("Cannot edit Professional skills as it does not exist.", "Professional skills Profile does not exist",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Warning no active users found.",
                    "Invalid Session", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (Userid != -1)
            {
                cn.Open();
                String Query1 = "SELECT * FROM User_ProfessionalSkills " +
                                "WHERE Profession_id = " + text_ProfessionID.Text + " ;";
                cmd = new SqlCommand(Query1, cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    int pid2 = Convert.ToInt32(dr["Profile_id"].ToString());
                    cn.Close();
                    dr.Close();
                    if (pid == pid2)
                    {
                        cn.Open();
                        Query1 = "DELETE FROM User_ProfessionalSkills " +
                                 "WHERE Profession_id = " + text_ProfessionID.Text + " ;";
                        cmd = new SqlCommand(Query1, cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();

                        MessageBox.Show("Skill profile Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete Skill profiles other than your own.");
                    }
                }
                else
                {
                    cn.Close();
                    dr.Close();
                    MessageBox.Show("Cannot delete education profile as it does not exist.", "Education Profile does not exist",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Warning no active users found.",
                    "Invalid Session", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile SP = new UserProfile();
            SP.ShowDialog();
            this.Hide();
        }
    }
}
