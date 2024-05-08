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
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LinkedInClone
{
    public partial class Homepage : Form
    {
        private bool isCollapsed;
        private bool isExpanded;
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public Homepage()
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
            cmd = new SqlCommand(Query , cn);
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
        /*public DataTable Comment_DataLoad()
        {
            cn.Close();
            cn.Open();
            string query = "SELECT CmntTxt FROM COMMENTS " +
                           "WHERE Post_id = @postid ;";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@post_id",text_Postid1.Text);
            cmd.ExecuteNonQuery();
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }*/
        private void button_Extra1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void button_Profile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile up = new UserProfile();
            up.ShowDialog();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_DropDown1.Height -= 10;
                if (panel_DropDown1.Size == panel_DropDown1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed=false;
                }
            }
            else
            {
                panel_DropDown1.Height += 10;
                panel1.Height += 500;
                if (panel_DropDown1.Size == panel_DropDown1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                panel1_Home.Height -= 10;
                if (panel1_Home.Size == panel1_Home.MinimumSize)
                {
                    timer2.Stop();
                    isExpanded = false;
                }
            }
            else
            {
                panel1_Home.Height += 10;
                if (panel1_Home.Size == panel1_Home.MaximumSize)
                {
                    timer2.Stop();
                    isExpanded = true;
                }
            }
        }

        private void panel1_Home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Home1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_MyNetwork1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form13 fm = new Form13();
            fm.Userid = current_user_id();
            fm.ShowDialog();
            this.Hide();
        }

        private void button_Jobs1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form15 fm = new Form15();
            fm.Userid = current_user_id();
            fm.ShowDialog();
            this.Hide();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'linkedInDataSet6.Post' table. You can move, or remove it, as needed.
            this.postTableAdapter3.Fill(this.linkedInDataSet6.Post);
            // TODO: This line of code loads data into the 'linkedInDataSet4.Post' table. You can move, or remove it, as needed.
            this.postTableAdapter2.Fill(this.linkedInDataSet4.Post);

            string query = "SELECT P.Post_id , P.Post_Title , P.Post_Content , P.Timestamp , " +
                           "P.UserID , P.NoOfLikes , P.NoOfComments " +
                           "FROM Post P " +
                           "RIGHT JOIN User_Connection C ON " +
                           "P.UserID = C.ConnUserID OR P.UserID = C.UserID " +
                           "WHERE C.UserID = 1 ;";
            cn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dataTable;
            cn.Close();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string query = "SELECT P.Post_id , P.Post_Title , P.Post_Content , P.Timestamp , " +
                           "P.UserID , P.NoOfLikes , P.NoOfComments " +
                           "FROM Post P " +
                           "RIGHT JOIN User_Connection C ON " +
                           "P.UserID = C.ConnUserID OR P.UserID = C.UserID " +
                           "WHERE C.UserID = 1 ;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
            DataTable dataTable = new DataTable();
            MessageBox.Show("Data retrieved: " + dataTable.Rows.Count + " rows.");
            adapter.Fill(dataTable);
            
            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (text_Postid1.Text != "" && text_Postid1.Text != "Post Id")
            {
                cn.Open();
                string Query2 = "SELECT * FROM Post " +
                               "WHERE Post_id = @postid ; ";
                cmd = new SqlCommand(Query2 , cn);
                cmd.Parameters.AddWithValue("@postid", text_Postid1.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    text_Posttitle1.Text = dr["Post_Title"].ToString();
                    text_PostContent1.Text = dr["Post_Content"].ToString();
                    text_Likes1.Text = dr["NoOfLikes"].ToString();
                    dr.Close();
                    cn.Close();
                    cn.Open();
                    Query2 = "SELECT COUNT(Post_id)" +
                             " FROM Comments " +
                             " WHERE  Post_id = " + text_Postid1.Text + " ;";
                             cmd = new SqlCommand(Query2, cn);
                    //cmd.Parameters.AddWithValue("@postid" , text_Postid1);
                    Int32 counts = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Dispose();
                    cn.Close();
                    cn.Open();
                    text_Comments1.Text = counts.ToString();

                    cmd = new SqlCommand("Update Post " +
                                                  " SET NoOfComments = " + text_Comments1.Text +
                                                  " WHERE Post_id = " + text_Postid1.Text + " ; " , cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Post does not exist. Please enter valid id.",
                        "Invalid post", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cn.Close();
                    dr.Close();
                }
                cn.Close();
                dr.Close();

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userid = current_user_id();
            if (userid == -1)
            {
                MessageBox.Show("Warning no active users found.",
                    "Invalid Session", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (text_Postid1.Text == "")
            {
                MessageBox.Show("Post id cannot be empty. Please enter a post id.",
                    "Empty post id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cn.Open();
            String Query = "SELECT * FROM LIKES " +
                           "WHERE Post_id = " + text_Postid1.Text +
                           " AND UserID = " + userid.ToString();

            cmd = new SqlCommand(Query, cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                text_Likes1.Text= (Int32.Parse(text_Likes1.Text) - 1).ToString();
                MessageBox.Show("Unliking");
                dr.Close();
                cn.Close();
                cn.Open();
                Query = "DELETE FROM LIKES " +
                        "WHERE Post_id = " + text_Postid1.Text +
                        " AND UserID = " + userid.ToString();
                cmd = new SqlCommand(Query,cn);
                cmd.ExecuteNonQuery();
                dr.Close();
                cn.Close();

                cn.Open();
                Query = "UPDATE Post " +
                        " SET NoOfLikes = @likes " +
                        " WHERE Post_id = @postid ;";
                        cmd = new SqlCommand(Query, cn);
                cmd.Parameters.AddWithValue("@postid", text_Postid1.Text);
                cmd.Parameters.AddWithValue("@likes", text_Likes1.Text);
                cmd.ExecuteNonQuery();
                dr.Close();
                cn.Close();
            }
            else
            {
                text_Likes1.Text = (Int32.Parse(text_Likes1.Text) + 1).ToString();
                MessageBox.Show("Liking");
                dr.Close();
                cn.Close();
                cn.Open();
                Query = "INSERT INTO LIKES (Post_id, UserID) " +
                        " VALUES (@postid , @userid) ;";
                cmd = new SqlCommand(Query , cn);
                cmd.Parameters.AddWithValue("@postid" , text_Postid1.Text);
                cmd.Parameters.AddWithValue("@userid", userid.ToString());
                dr = cmd.ExecuteReader();
                dr.Close();
                cn.Close();

                cn.Open();
                Query = "UPDATE Post " +
                        " SET NoOfLikes = @likes " +
                        " WHERE Post_id = @postid ;" ;
                cmd = new SqlCommand(Query, cn);
                cmd.Parameters.AddWithValue("@postid", text_Postid1.Text);
                cmd.Parameters.AddWithValue("@likes" , text_Likes1.Text);
                cmd.ExecuteNonQuery();
                dr.Close();
                cn.Close();
            }
        }

        private void panel3_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void text_Title2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Content2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Posttitle1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_PostContent1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Comment1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Comment1_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_Postid1.Text == "")
                {
                    MessageBox.Show("Post id cannot be empty. Please enter a post id.",
                        "Empty post id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (text_Comment1.Text == "")
                {
                    MessageBox.Show("Comment cannot be empty. Please enter any sentence or word!!!",
                        "Empty Comment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userid = current_user_id();
                if (userid == -1)
                {
                    MessageBox.Show("Warning no active users found." , 
                        "Invalid Session" , MessageBoxButtons.OK , 
                        MessageBoxIcon.Warning);
                    return;
                }
                DateTime dt = DateTime.Now;
                cn.Open();
                string Query = "Insert Into Comments (Post_id , UserID , CmntTxt) " +
                               "VALUES (@post_id , @userid , @CmntText) ;" ;
                cmd = new SqlCommand(Query, cn);
                cmd.Parameters.AddWithValue("@post_id", text_Postid1.Text);
                cmd.Parameters.AddWithValue("@userid", userid.ToString());
                cmd.Parameters.AddWithValue("@CmntText",text_Comment1.Text);
                //cmd.Parameters.AddWithValue("@timestamp" , dt.ToString());
                cmd.ExecuteNonQuery();
                /*SqlDataAdapter adapter = new SqlDataAdapter(Query, cn);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dtbl;*/
                cn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void button_ShowComments1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                if (text_Postid1.Text == "")
                {
                    MessageBox.Show("Post id cannot be empty. Please enter a post id.",
                        "Empty post id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string Query = "SELECT * FROM Comments " +
                               "WHERE Post_id = " + text_Postid1.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(Query, cn);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dtbl;
                cn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void button_Addpost1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Search1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Search1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 fm = new Form14();
            fm.UseridRequestTo = Int32.Parse(txt_Search1.Text);
            fm.Currentuserid = current_user_id();
            fm.ShowDialog();
            this.Hide();
        }

        private void button_MyComments1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int userid = current_user_id();
                if (text_Postid1.Text == "")
                {
                    MessageBox.Show("Post id cannot be empty. Please enter a post id.",
                        "Empty post id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (userid == -1)
                {
                    MessageBox.Show("Warning no active users found.",
                        "Invalid Session", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                string Query = "SELECT * FROM Comments " +
                               "WHERE Post_id = " + text_Postid1.Text +
                               " AND UserID = " + userid.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, cn);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dtbl;
                cn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void text_UpdatedComment1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_CommentDelete1_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = current_user_id();
                if (text_Postid1.Text == "")
                {
                    MessageBox.Show("Post id cannot be empty. Please enter a post id.",
                        "Empty post id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (userid == -1)
                {
                    MessageBox.Show("Warning no active users found.",
                        "Invalid Session", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (text_Commentid1.Text == "")
                {
                    MessageBox.Show("Comment Id cannot be empty. Please provide a comment id.",
                        "Empty Comment Id", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                string Query = "Select * From Comments " +
                               " WHERE UserID = @userid " +
                               " AND Post_id = @postid " +
                               " AND Cmntid = @commentid ;";
                cmd = new SqlCommand(Query, cn);
                cmd.Parameters.AddWithValue("@userid", userid.ToString());
                cmd.Parameters.AddWithValue("@postid", text_Postid1.Text);
                cmd.Parameters.AddWithValue("@commentid", text_Commentid1.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    cn.Close();
                    cn.Open();
                    Query = "DELETE FROM Comments " +
                            " WHERE UserID = @userid " +
                            " AND Post_id = @postid " +
                            " AND Cmntid = @commentid ;";
                    cmd = new SqlCommand(Query, cn);
                    cmd.Parameters.AddWithValue("@userid", userid.ToString());
                    cmd.Parameters.AddWithValue("@postid", text_Postid1.Text);
                    cmd.Parameters.AddWithValue("@commentid", text_Commentid1.Text);
                    cmd.ExecuteNonQuery();
                    dr.Close();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Cannot delete other persons comments.", "Un-authorized Deletion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr.Close();
                    cn.Close();
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void button_CommentUpdate1_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = current_user_id();
                if (text_Postid1.Text == "")
                {
                    MessageBox.Show("Post id cannot be empty. Please enter a post id.",
                        "Empty post id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (userid == -1)
                {
                    MessageBox.Show("Warning no active users found.",
                        "Invalid Session", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (text_Commentid1.Text == "")
                {
                    MessageBox.Show("Comment Id cannot be empty. Please provide a comment id.",
                        "Empty Comment Id", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (text_UpdatedComment1.Text == "")
                {
                    MessageBox.Show("Updated Comment space cannot be empty. Please write a sentece or words.",
                        "Empty Comment Space", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                string Query = "UPDATE Comments " +
                               "SET CmntTxt = @commenttext " +
                               " WHERE UserID = @userid " +
                               " AND Post_id = @postid " +
                               " AND Cmntid = @commentid ;" ;
                cmd = new SqlCommand(Query, cn);
                cmd.Parameters.AddWithValue("@commenttext" , text_UpdatedComment1.Text);
                cmd.Parameters.AddWithValue("@userid", userid.ToString());
                cmd.Parameters.AddWithValue("@postid", text_Postid1.Text);
                cmd.Parameters.AddWithValue("@commentid", text_Commentid1.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
               /* cn.Open();
                Query = "SELECT * FROM Comments " +
                        "WHERE Post_id = " + text_Postid1.Text +
                        " AND UserID = " + userid.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, cn);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dtbl;
                cn.Close();*/
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void text_Likes1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void text_Comments1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_deletepost1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int userid = current_user_id();
                if (text_Postid1.Text == "")
                {
                    MessageBox.Show("Post id cannot be empty. Please enter a post id.",
                        "Empty post id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (userid == -1)
                {
                    MessageBox.Show("Warning no active users found.",
                        "Invalid Session", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                cn.Open();
                string Query1 = "SELECT * FROM Post " +
                                " WHERE Post_id = @postid AND " +
                                "UserID = @userid ;" ;
                cmd = new SqlCommand(Query1, cn);
                cmd.Parameters.AddWithValue("@userid", userid.ToString());
                cmd.Parameters.AddWithValue("@postid", text_postid2.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    dr.Close();
                    cn.Close();
                    cn.Open();
                    string Query2 = "DELETE FROM Comments " +
                                    " WHERE Post_id = @postid; ";
                                    cmd = new SqlCommand(Query2, cn);
                                    cmd.Parameters.AddWithValue("@postid", text_postid2.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    cn.Open();
                    Query2 = "DELETE FROM Likes " +
                             " WHERE Post_id = @postid; ";
                    cmd = new SqlCommand(Query2, cn);
                    cmd.Parameters.AddWithValue("@postid", text_postid2.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    cn.Open();
                    Query2 = "DELETE FROM Post " +
                             " WHERE Post_id = @postid  " +
                             " AND UserID = @userid";
                    cmd = new SqlCommand(Query2, cn);
                    cmd.Parameters.AddWithValue("@postid", text_postid2.Text);
                    cmd.Parameters.AddWithValue("@userid", userid.ToString());
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                else
                {
                    cn.Close();
                    dr.Close();
                    MessageBox.Show("Cannot delete Posts of other people.");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void text_postid2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Addpost1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (text_Title2.Text == "")
                {
                    MessageBox.Show("Post title cannot be empty. Please enter a post title.",
                        "Empty post id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (text_Content2.Text == "")
                {
                    MessageBox.Show("Content cannot be empty. Please enter any sentence or word!!!",
                        "Empty Content", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userid = current_user_id();
                if (userid == -1)
                {
                    MessageBox.Show("Warning no active users found.",
                        "Invalid Session", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                DateTime dt = DateTime.Now;
                cn.Open();
                string Query = "Insert Into Post (Post_Title , Post_Content , UserID) " +
                               "VALUES (@posttitle , @postcontent , @userid) ;";
                cmd = new SqlCommand(Query, cn);
                cmd.Parameters.AddWithValue("@posttitle", text_Title2.Text);
                cmd.Parameters.AddWithValue("@userid", userid.ToString());
                cmd.Parameters.AddWithValue("@postcontent", text_Content2.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
