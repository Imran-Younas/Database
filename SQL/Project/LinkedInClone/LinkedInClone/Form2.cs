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
    public partial class SignUp : Form
    {
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cm = new SqlCommand();
        public DBConnection conn = new DBConnection();
        public SqlDataReader dr;
        public SignUp()
        {
            InitializeComponent();
            cn = new SqlConnection(conn.MyConnection());
            this.KeyPreview = true;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Pass2.Text == "")
                {
                    MessageBox.Show("Password cannot be empty! Please provide a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txt_Email2.Text == "")
                {
                    MessageBox.Show("Email cannot be empty! Please provide an email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txt_FirstName.Text == "")
                {
                    MessageBox.Show("first name cannot be empty! Please enter your first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txt_LastName.Text == "")
                {
                    MessageBox.Show("Last name cannot be empty! Please enter your first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cn.Open();
                cm = new SqlCommand("Insert into Users(email,password,FirstName,Lastname) " +
                                  "values(@email,@password,@FirstName,@LastName)", cn);
                cm.Parameters.AddWithValue("@email", txt_Email2.Text);
                cm.Parameters.AddWithValue("@password", txt_Pass2.Text);
                cm.Parameters.AddWithValue("@FirstName", txt_FirstName.Text);
                cm.Parameters.AddWithValue("@Lastname", txt_LastName.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New Account Created Successfully!", "Saved Account",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Hide();
        }

        private void txt_Pass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_LastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
