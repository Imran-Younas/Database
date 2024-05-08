using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LinkedInClone
{
    public partial class Login : Form
    {
        public string pass, email = "";
        public string firstname, lastname;

        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        /*private SignUp mainForm = null;
        public Login(Form callingForm)
        {
            mainForm = callingForm as SignUp;
            InitializeComponent();
        }*/
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            try
            {
                bool found;
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM Users " +
                    "WHERE email = @email " +
                    "AND password = @password;", cn);
                cmd.Parameters.AddWithValue("@email", txt_Email1.Text);
                cmd.Parameters.AddWithValue("@password", txt_pass1.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    email = dr["email"].ToString();
                    firstname = dr["FirstName"].ToString();
                    lastname = dr["LastName"].ToString();
                    pass = dr["password"].ToString();
                }
                else
                {
                    found = false;
                    dr.Close();
                    cn.Close();
                }
                if (found == true)
                {
                   // Login log = new Login();
                    MessageBox.Show("Welcome " + firstname + lastname, "Login Successful" 
                        , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    cn.Close();
                    dr.Close();
                    cn.Open();
                    cmd = new SqlCommand("Update Users " +
                                         "SET Status = 1 " +
                                         "WHERE email=@email", cn);
                    cmd.Parameters.AddWithValue("@email", txt_Email1.Text);
                    cmd.ExecuteNonQuery();
                    txt_pass1.Clear();
                    //log.ShowDialog();
                    this.Hide();
                    Homepage hm = new Homepage();
                    hm.ShowDialog();
                    this.Hide();
                    //dr.Close();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void link_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.ShowDialog();
            this.Hide();
        }
    }
}
