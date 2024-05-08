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
    public partial class Form7 : Form
    {
        public int Userid { get; set; }
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public Form7()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void text_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (Userid != -1)
            {
                cn.Open();
                String Query1 = "SELECT * FROM User_Profile " +
                               "WHERE UserID = " + Userid.ToString() + " ;";
                cmd = new SqlCommand(Query1, cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    cn.Close();
                    dr.Close();
                    int count = 0;
                    if (text_FirstName.Text != "")
                    {
                        cn.Open();
                        string Query = "UPDATE User_Profile " +
                                       "SET First_Name = " + text_FirstName.Text +
                                       " WHERE UserID = " + Userid.ToString();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        count++;
                    }

                    if (text_LastName.Text != "")
                    {
                        cn.Open();
                        string Query = "UPDATE User_Profile " +
                                       "SET Last_Name = " + text_LastName.Text +
                                       " WHERE UserID = " + Userid.ToString();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        count++;
                    }

                    if (text_Location.Text != "")
                    {
                        cn.Open();
                        string Query = "UPDATE User_Profile " +
                                       "SET User_Location = " + text_Location.Text +
                                       " WHERE UserID = " + Userid.ToString();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        count++;
                    }

                    if (text_PhoneNo.Text != "")
                    {
                        cn.Open();
                        string Query = "UPDATE User_Profile " +
                                       "SET PhoneNo = " + text_PhoneNo.Text +
                                       " WHERE UserID = " + Userid.ToString();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        count++;
                    }

                    if (count > 0)
                    {
                        MessageBox.Show("Profile Edited");
                    }
                    else
                    {
                        MessageBox.Show("Fields cannot be empty to edit Profile.");
                    }
                }
                else
                {
                    cn.Close();
                    dr.Close();
                    MessageBox.Show("Cannot edit profile as it does not exist." , "Profile does not exist" ,
                        MessageBoxButtons.OK , MessageBoxIcon.Warning);
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
            UserProfile up = new UserProfile();
            up.ShowDialog();
            this.Hide();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (Userid != -1)
            {
                cn.Open();
                String Query1 = "SELECT * FROM User_Profile " +
                               "WHERE UserID = " + Userid.ToString() + " ;";
                cmd = new SqlCommand(Query1, cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                { 
                    int pid = Convert.ToInt32(dr["Profile_id"]);
                    cn.Close();
                    dr.Close();

                    cn.Open();
                    Query1 = "SELECT * FROM User_ProfessionalSkills " +
                                    "WHERE Profile_id = " + pid.ToString() + " ;";
                    cmd = new SqlCommand(Query1, cn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        cn.Close();
                        cn.Open();
                        Query1 = "DELETE FROM User_ProfessionalSkills  " +
                                 "WHERE Profile_id = " + pid.ToString() + " ;";
                        cmd = new SqlCommand(Query1, cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }

                    cn.Open();
                    Query1 = "SELECT * FROM User_Education " +
                             "WHERE Profile_id = " + pid.ToString() + " ;";
                    cmd = new SqlCommand(Query1, cn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        cn.Close();
                        cn.Open();
                        Query1 = "DELETE FROM User_Education  " +
                                 "WHERE Profile_id = " + pid.ToString() + " ;";
                        cmd = new SqlCommand(Query1, cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                    cn.Open();
                    Query1 = "DELETE FROM User_Profile  " +
                             "WHERE Profile_id = " + Userid.ToString() + " ;";
                    cmd = new SqlCommand(Query1, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Profile deleted successfully.");
                }
                else
                {
                    cn.Close();
                    dr.Close();
                    MessageBox.Show("Cannot delete profile as it does not exist.", "Profile does not exist",
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

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
