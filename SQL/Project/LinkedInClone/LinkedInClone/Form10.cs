using System;
using System.Collections;
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
    public partial class Form10 : Form
    {
        public int Userid { get; set; }
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public int pid = 0;
        public Form10()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'linkedInDataSet6.User_Education' table. You can move, or remove it, as needed.
            this.user_EducationTableAdapter.Fill(this.linkedInDataSet6.User_Education);
            cn.Open();
            string Query = "SELECT * FROM User_Education U " +
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
            Query = "SELECT * FROM User_Education U " +
                           "LEFT JOIN User_Profile UP " +
                           "ON U.Profile_id = UP.Profile_id " +
                           "WHERE UP.UserID = " + Userid.ToString();
           cmd = new SqlCommand(Query,cn);
           dr=cmd.ExecuteReader();
           dr.Read();
           if (dr.HasRows)
           {
               pid = Convert.ToInt32(dr["Profile_id"].ToString());
           }
           cn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp SP = new SignUp();
            SP.ShowDialog();
            this.Hide();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (Userid != -1)
            {
                cn.Open();
                String Query1 = "SELECT * FROM User_Education " +
                               "WHERE Education_id = " + text_EducationID.Text + " ;";
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
                        if (text_Degree.Text != "")
                        {
                            cn.Open();
                            string Query = "UPDATE User_Education " +
                                           "SET Degree = " + text_Degree.Text +
                                            " WHERE Education_id = " + text_EducationID.Text + " ;";
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            count++;
                        }

                        if (text_InstituteName.Text != "")
                        {
                            cn.Open();
                            string Query = "UPDATE User_Education " +
                                           "SET Institute_Name = " + text_InstituteName.Text +
                                            "WHERE Education_id = " + text_EducationID.Text + " ;";
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            count++;
                        }

                        if (text_Sdate.Text != "")
                        {
                            cn.Open();
                            string Query = "UPDATE User_Education " +
                                           "SET Starting_date = " + DateTime.ParseExact(text_Sdate.Text, "dd-MM-yyyy", null) +
                                           " WHERE Education_id = " + text_EducationID.Text + " ;";
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            count++;
                        }

                        if (text_Edate.Text != "")
                        {
                            cn.Open();
                            string Query = "UPDATE User_Education " +
                                           "SET Ending_date = " + DateTime.ParseExact(text_Edate.Text, "dd-MM-yyyy", null) +
                                           " WHERE Education_id = " + text_EducationID.Text + " ;";
                            cmd.ExecuteNonQuery();
                            cn.Close();
                            count++;
                        }

                        if (count > 0)
                        {
                            MessageBox.Show("Education Profile Edited");
                        }
                        else
                        {
                            MessageBox.Show("Fields cannot be empty to edit Education Profile.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot edit education profiles othe than your own.");
                    }
                }
                else
                {
                    cn.Close();
                    dr.Close();
                    MessageBox.Show("Cannot edit education as it does not exist.", "Education Profile does not exist",
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

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (Userid != -1)
            {
                cn.Open();
                String Query1 = "SELECT * FROM User_Education " +
                               "WHERE Education_id = " + text_EducationID.Text + " ;";
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
                        Query1 = "DELETE FROM User_Education  " +
                                 "WHERE Education_id = " + text_EducationID.Text + " ;";
                        cmd = new SqlCommand(Query1, cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();

                        MessageBox.Show("Education Profile Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete education profiles other than your own.");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
