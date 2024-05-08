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
    public partial class Form8 : Form
    {
        public int Userid { get; set; }
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public Form8()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (Userid != -1)
            {
                if (text_FirstName.Text == "")
                {
                    MessageBox.Show("First name cannot be empty. Please enter your first name.",
                        "Empty Field", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (text_LastName.Text == "")
                {
                    MessageBox.Show("Last name cannot be empty. Please enter your last name.",
                        "Empty Field", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (text_Location.Text == "")
                {
                    MessageBox.Show("Location cannot be empty. Please enter your Location.",
                        "Empty Field", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (text_Location.Text == "")
                {
                    MessageBox.Show("Phono No cannot be empty. Please enter your Phono No.",
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
                if (dr.HasRows)
                {
                    MessageBox.Show("Warning profile already exists!!! Cannot create profile.",
                        "Invalid Profile Creation", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    cn.Close();
                    dr.Close();
                    return;
                }
                else
                {
                    cn.Close();
                    dr.Close();
                    Query = "INSERT INTO User_Profile (First_Name , Last_Name , UserID , User_Location , PhoneNo) " +
                            "VALUES (@firstname , @lastname , @userid , @location , @phoneno) ;";
                    cn.Open();
                    cmd = new SqlCommand(Query, cn);
                    cmd.Parameters.AddWithValue("@firstname", text_FirstName.Text);
                    cmd.Parameters.AddWithValue("@lastname", text_LastName.Text);
                    cmd.Parameters.AddWithValue("@userid", Userid.ToString());
                    cmd.Parameters.AddWithValue("@location", text_Location.Text);
                    cmd.Parameters.AddWithValue("@phoneno", text_PhoneNo.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Profile has been created succesfully" , "Profile Creation Successful" ,
                        MessageBoxButtons.OK , MessageBoxIcon.Information);
                }
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
            UserProfile up = new UserProfile();
            up.ShowDialog();
            this.Hide();
        }
    }
}
