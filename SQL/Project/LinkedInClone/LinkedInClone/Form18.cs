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
    public partial class Form18 : Form
    {
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cm = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public int Userid { get; set; }

        public Form18()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("select * from User_Profile where UserID = " + Userid.ToString(), cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                string pf = dr["Profile_id"].ToString();

                string query3 =
                    "INSERT INTO JobAdds (UserID, Profile_id, JobPosition, JobDescription, JobRequirements, Deadline) " +
                    "VALUES (@userID , @profile_id , @jobpos , @jobdesc , @jobreq,@deadline)";


                cn.Close();
                dr.Close();
                cn.Open();
                SqlCommand command = new SqlCommand(query3, cn);
                command.Parameters.AddWithValue("@UserID", Userid.ToString());
                command.Parameters.AddWithValue("@profile_id", pf);
                command.Parameters.AddWithValue("@jobpos", text_Position.Text);
                command.Parameters.AddWithValue("@jobdesc", text_Description.Text);
                command.Parameters.AddWithValue("@jobreq", text_Requirements.Text);
                command.Parameters.AddWithValue("@deadline", DateTime.ParseExact(text_deadline.Text, "dd-MM-yyyy", null));

                command.ExecuteNonQuery();
                MessageBox.Show("Job Add Created Successfully!", "Succed", MessageBoxButtons.OK);
                using (SqlCommand cmd = new SqlCommand(query3, cn))

                cn.Close();
   
                
            }
            else
            {

                MessageBox.Show("Wrong Information", "Failed", MessageBoxButtons.OK);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 fm = new Form15();
            fm.ShowDialog();
            this.Hide();
        }
    }
}
