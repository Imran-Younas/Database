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
    public partial class Form5 : Form
    {
        private DataTable dataTable;
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public DataGridView Grid { get; set; }

        public Form5()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'linkedInDataSet6.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.linkedInDataSet6.Users);
            // TODO: This line of code loads data into the 'linkedInDataSet6.User_Profile' table. You can move, or remove it, as needed.
            this.user_ProfileTableAdapter.Fill(this.linkedInDataSet6.User_Profile);
            // TODO: This line of code loads data into the 'linkedInDataSet6.JobApplication' table. You can move, or remove it, as needed.
            this.jobApplicationTableAdapter.Fill(this.linkedInDataSet6.JobApplication);
            // TODO: This line of code loads data into the 'linkedInDataSet6.Comments' table. You can move, or remove it, as needed.
            this.commentsTableAdapter.Fill(this.linkedInDataSet6.Comments);
            // TODO: This line of code loads data into the 'linkedInDataSet6.JobAdds' table. You can move, or remove it, as needed.
            this.jobAddsTableAdapter.Fill(this.linkedInDataSet6.JobAdds);
            try
            {
                cn.Open();

                string Query = "SELECT P.Post_id , P.Post_Title , P.Post_Content , P.Timestamp , " +
                               "P.UserID , P.NoOfLikes , P.NoOfComments , C.Cmntid , C.UserID , C.CmntTxt " +
                               "FROM Post P " +
                               "LEFT JOIN Comments C ON " +
                               "P.Post_id = C.Post_id " +
                               "RIGHT JOIN Users U ON " +
                               "U.UserID = P.UserID " +
                               "AND U.status = 1 ;";
                    
                SqlDataAdapter adapter = new SqlDataAdapter(Query, cn);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;
                cn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile Up = new UserProfile();
            Up.ShowDialog();
            this.Hide();
        }
    }
}
