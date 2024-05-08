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
    public partial class UserProfile : Form
    {
        private bool isCollapsed;
        private bool isExpanded;
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;

        public UserProfile()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        public int current_user_id()
        {
            bool found = false;
            int userid = -1;
            cn.Open();
            string Query = "Select * From Users " +
                           "Where Status = 1 ;";
            cmd = new SqlCommand(Query, cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                found = true;
                userid = Int32.Parse(dr["UserID"].ToString());
                cn.Close();
                dr.Close();
            }
            else
            {
                return userid;
            }
            return userid;
        }

        private void button_Extra1_Click(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void panel1_Home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void button_Logout1_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("Update Users " +
                                 "SET Status = 0 " +
                                 "WHERE Status = 1 ;", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Hide();
        }

        private void button_Home1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hm = new Homepage();
            hm.ShowDialog();
            this.Hide();
        }


        private void button_myposts1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5  fm = new Form5();
            fm.ShowDialog();
            this.Hide();
        }

        private void button_viewprofile_Click(object sender, EventArgs e)
        {
            int userid = -1;
            userid = current_user_id();

            if (userid != -1)
            {
                this.Hide();
                Form6 fm = new Form6();
                fm.Userid = current_user_id();
                fm.ShowDialog();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 fm = new Form7();
            fm.Userid = current_user_id();
            fm.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 fm = new Form8();
            fm.Userid = current_user_id();
            fm.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 fm = new Form9();
            fm.Userid = current_user_id();
            fm.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 fm = new Form10();
            fm.Userid = current_user_id();
            fm.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 fm = new Form11();
            fm.Userid = current_user_id();
            fm.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 fm = new Form12();
            fm.Userid = current_user_id();
            fm.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 fm = new Form13();
            fm.Userid = current_user_id();
            fm.ShowDialog();
            this.Hide();
        }

        private void button_Search1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 fm = new Form14();
            fm.UseridRequestTo = Int32.Parse(txt_Search1.Text);
            fm.Currentuserid=current_user_id();
            fm.ShowDialog();
            this.Hide();
        }

        private void button_Jobs1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 fm = new Form15();
            fm.Userid = current_user_id();
            fm.ShowDialog();
            this.Hide();
        }
    }
}

/*if (Userid == -1)
{
    MessageBox.Show("Warning no active users found.",
        "Invalid Session", MessageBoxButtons.OK,
        MessageBoxIcon.Warning);
    return;
}*/
