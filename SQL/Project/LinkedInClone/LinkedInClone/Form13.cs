using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LinkedInClone
{
    public partial class Form13 : Form
    {
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        private bool isCollapsed;
        public int Userid { get; set; }

        public Form13()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'linkedInDataSet7.Connection_Request' table. You can move, or remove it, as needed.
            //this.connection_RequestTableAdapter.Fill(this.linkedInDataSet7.Connection_Request);
            // TODO: This line of code loads data into the 'linkedInDataSet6.User_Profile' table. You can move, or remove it, as needed.
            this.user_ProfileTableAdapter.Fill(this.linkedInDataSet6.User_Profile);
            // TODO: This line of code loads data into the 'linkedInDataSet6.JobApplication' table. You can move, or remove it, as needed.
            this.jobApplicationTableAdapter.Fill(this.linkedInDataSet6.JobApplication);
            // TODO: This line of code loads data into the 'linkedInDataSet6.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.linkedInDataSet6.Users);


            cn.Open();

            string Query =
                "SELECT U1.UserID , U1.ConnUserID , U2.FirstName , U2.LastName , U2.Email FROM User_Connection U1 " +
                "LEFT JOIN Users U2 ON U1.ConnUserID = U2.UserID " +
                "WHERE U1.UserId = " + Userid.ToString();

            SqlDataAdapter adapter = new SqlDataAdapter(Query, cn);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtbl;
            cn.Close();
            cn.Open();
            /*TextBox textBox1 = new TextBox();
            textBox1.Text = UserID.ToString();*/
            int pid = 0;
            pid = Userid;
            string sr = Userid.ToString();
                        string  Query2 = "SELECT * FROM Connection_Request " +
                                         "WHERE ConnRequestUserId = " + sr + " ;" ;
            //string Query = "SELECT * FROM Users U RIGHT JOIN Connection_Request C ON U.UserID = C.ConnRequestUserId WHERE U.UserID = " + p ;
            adapter = new SqlDataAdapter(Query2, cn);
             
                 dtbl = new DataTable();
                adapter.Fill(dtbl);

                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dtbl;
                cn.Close();

        }

        private void button_Home1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hm = new Homepage();
            hm.ShowDialog();
            this.Hide();
        }

        private void button_Search1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 fm = new Form14();
            fm.UseridRequestTo = Int32.Parse(txt_Search1.Text);
            fm.Currentuserid = Userid;
            fm.ShowDialog();
            this.Hide();
        }

        private void button_Extra1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button_Logout1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            this.Hide();
        }

        private void button_Profile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile up = new UserProfile();
            up.ShowDialog();
            this.Hide();
        }

        private void button_MyNetwork1_Click(object sender, EventArgs e)
        {

        }

        private void buutton_accept_Click(object sender, EventArgs e)
        {
            string pid2 = "";
            pid2 = Userid.ToString();
            string Query2 =
                "SELECT * FROM Connection_Request WHERE  ConnRequestUserId = " + pid2 + " ;";
            cn.Open();
            cmd = new SqlCommand(Query2,cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (textBox1.Text == dr["RequestID"].ToString())
                {
                    int connuser = Int32.Parse(dr["UserID"].ToString());
                    cn.Close();
                    dr.Close();


                    String query = "INSERT INTO User_Connection (UserID, ConnUserID) " +
                                   "VALUES (@userid , @conn)";
                    cn.Open();
                    cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@userid", connuser.ToString());
                    cmd.Parameters.AddWithValue("@conn", pid2);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    query = "INSERT INTO User_Connection (UserID, ConnUserID) " +
                            "VALUES (@userid , @conn)";
                    cn.Open();
                    cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@userid", pid2);
                    cmd.Parameters.AddWithValue("@conn", connuser.ToString());
                    cmd.ExecuteNonQuery();
                    cn.Close();


                    MessageBox.Show("userid : " + pid2 + " connuser : " + connuser);
                    cn.Open();
                    query = "DELETE FROM Connection_Request  " +
                                          "WHERE UserID = " + connuser +
                            " AND ConnRequestUserId = " + pid2 + " ; ";
                    cmd = new SqlCommand(query, cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New connection has been added.", "Connection addition" ,
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("You can not add requests that were not sent to you. Please add a connection id that was sent to you.",
                        "Invalid Connection Accept request",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cn.Close();
                    dr.Close();
                }
                cn.Close();
            }
            else
            {
                cn.Close();
                dr.Close();
                MessageBox.Show("You do not have any connection requests. Cannot add connections that did not send requests.", "Invalid Connection Accept request",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cn.Close();
            dr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_reject_Click(object sender, EventArgs e)
        {
            string pid3 = "";
            pid3 = Userid.ToString();
            string Query2 = "SELECT * FROM Connection_Request WHERE  ConnRequestUserId = " + pid3 + " ;";
            cn.Open();
            cmd = new SqlCommand(Query2,cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (textBox1.Text == dr["RequestID"].ToString())
                {
                    cn.Close();
                    dr.Close();
                    

                    cn.Open();
                    string query = "DELETE FROM Connection_Request  " +
                                   "WHERE RequestID = " + textBox1.Text;
                    cmd = new SqlCommand(query,cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Connection has been rejected successfully", "Connection request rejection",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cn.Close();
                    dr.Close();
                    MessageBox.Show("You can not reject requests that were not sent to you. Please add a connection id that was sent to you.",
                        "Invalid Connection Accept request",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Close();
            }
            else
            {
                MessageBox.Show("You do not have any connection requests. Cannot reject connections that did not send requests.", "Invalid Connection reject request",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_DropDown1.Height -= 10;
                panel1_UserProfile.Height -= 13;

                if (panel_DropDown1.Size == panel_DropDown1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel_DropDown1.Height += 10;
                panel1_UserProfile.Height += 13;
                if (panel_DropDown1.Size == panel_DropDown1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }
    }
}
