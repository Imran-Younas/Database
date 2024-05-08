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
    public partial class Form14 : Form
    {
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public int UseridRequestTo { get; set; }
        public int Currentuserid { get; set; }

        public Form14()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'linkedInDataSet5.User_Education' table. You can move, or remove it, as needed.
            this.user_EducationTableAdapter1.Fill(this.linkedInDataSet5.User_Education);
            // TODO: This line of code loads data into the 'linkedInDataSet5.User_ProfessionalSkills' table. You can move, or remove it, as needed.
            this.user_ProfessionalSkillsTableAdapter1.Fill(this.linkedInDataSet5.User_ProfessionalSkills);

            string Query = " SELECT * FROM User_Profile " +
                    "WHERE UserID = " + UseridRequestTo.ToString(); 
            cn.Open();
            cmd = new SqlCommand(Query, cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                cn.Close();
                dr.Close();
                ; cn.Open();
                cmd = new SqlCommand(Query, cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (Int32.Parse(dr["UserID"].ToString()) == UseridRequestTo)
                {
                    text_FirstName.Text = dr["First_Name"].ToString();
                    text_LastName.Text = dr["Last_Name"].ToString();
                    text_Location.Text = dr["User_Location"].ToString();
                    text_PhoneNo.Text = dr["PhoneNo"].ToString();
                    cn.Close();
                    dr.Close();

                    Query = "SELECT * FROM User_ProfessionalSkills U " +
                                   "LEFT JOIN User_Profile UP " +
                                   "ON U.Profile_id = UP.Profile_id " +
                                   "WHERE UP.UserID = " + UseridRequestTo.ToString();

                    cn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(Query, cn);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);

                    dataGridView3.AutoGenerateColumns = false;
                    dataGridView3.DataSource = dtbl;
                    cn.Close();

                    cn.Open();
                    Query = "SELECT * FROM User_Education U " +
                            "LEFT JOIN User_Profile UP " +
                            "ON U.Profile_id = UP.Profile_id " +
                            "WHERE UP.UserID = " + UseridRequestTo.ToString();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(Query, cn);
                    dtbl = new DataTable();
                    adapter2.Fill(dtbl);

                    dataGridView2.AutoGenerateColumns = false;
                    dataGridView2.DataSource = dtbl;
                    cn.Close();

                }
                else
                {
                    MessageBox.Show("Warning no users found. Please enter a valid user id",
                        "Invalid user id", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    cn.Close();
                    dr.Close();
                }
                
            }
            else
            {
                cn.Close();
                dr.Close();
                this.Close();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_ConnectionRequest_Click(object sender, EventArgs e)
        {
            string Query = " SELECT * FROM User_Connection " +
                           " WHERE UserID = " + Currentuserid.ToString() + 
                           " AND ConnUserID = " + UseridRequestTo.ToString();
            cn.Open();
            cmd = new SqlCommand(Query, cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                cn.Close();
                dr.Close();
                MessageBox.Show("This user is already in your connections. " +
                                "Cannot add this user to your connections if already in connections",
                    "Invalid Connection Addition", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cn.Close();
                dr.Close();
                if (UseridRequestTo == Currentuserid)
                {
                    MessageBox.Show("Cannot add yourself to connections. ",
                        "Invalid Connection Addition", MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    cn.Open();
                    Query = " SELECT * FROM Connection_Request " +
                            " WHERE UserID = " + Currentuserid.ToString() + 
                            " AND ConnRequestUserId = " + UseridRequestTo.ToString() + " ;";
                    cmd = new SqlCommand(Query, cn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        cn.Close();
                        
                      //  if (dr["UserID"].ToString() == userid )
                       // {
                            MessageBox.Show("This request already exists and is pending " +
                                            "Cannot send request for this connection again until request is processed",
                                "Invalid Connection Request", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                       // }
                    }
                    else
                    {
                        cn.Close();
                        dr.Close();
                        cn.Open();
                        Query = "INSERT INTO Connection_Request (UserID , ConnRequestUserId) " +
                                "VALUES (@userid , @connrequserid) ;";
                        cmd = new SqlCommand(Query, cn);
                        cmd.Parameters.AddWithValue("@userid", Currentuserid.ToString());
                        cmd.Parameters.AddWithValue("@connrequserid", UseridRequestTo.ToString());
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Connection request Sent to other user. ",
                            "Connection Request Sent", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    
                }
            }
        }

        private void button_Home1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hm = new Homepage();
            hm.ShowDialog();
            this.Hide();
        }

        private void button_Profile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile UP = new UserProfile();
            UP.ShowDialog();
            this.Hide();
        }
    }
}
