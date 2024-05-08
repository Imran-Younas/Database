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
    public partial class Form15 : Form
    {

        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        private DBConnection dbcon = new DBConnection();
        public SqlDataReader dr;
        public int Userid { get; set; }

        public Form15()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }



        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'linkedInDataSet7.JobAdds' table. You can move, or remove it, as needed.
            this.jobAddsTableAdapter1.Fill(this.linkedInDataSet7.JobAdds);
            // TODO: This line of code loads data into the 'linkedInDataSet6.JobAdds' table. You can move, or remove it, as needed.
            this.jobAddsTableAdapter.Fill(this.linkedInDataSet6.JobAdds);
            // TODO: This line of code loads data into the 'linkedInDataSet6.JobApplication' table. You can move, or remove it, as needed.
            this.jobApplicationTableAdapter.Fill(this.linkedInDataSet6.JobApplication);
            //var typeReportSource = new Report1.TypeReportSource();

            cn.Open();


            string query = "SELECT * FROM JobAdds";
            SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
            DataTable jobAddsTable = new DataTable();

            // Clear any existing columns
            //dataGridView1.Columns.Clear();

            adapter.Fill(jobAddsTable);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = jobAddsTable;
  
            // Add columns to the DataGridView
            /* foreach (DataColumn column in jobAddsTable.Columns)
             {
                 dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
             }

             // Add unbound column
             DataGridViewTextBoxColumn calculatedColumn = new DataGridViewTextBoxColumn();
             calculatedColumn.HeaderText = "Calculated Column";
             dataGridView1.Columns.Add(calculatedColumn);

             // Bind the DataTable to the DataGridView
             dataGridView1.DataSource = jobAddsTable;

             // Calculate and populate unbound column values
             foreach (DataGridViewRow row in dataGridView1.Rows)
             {
                 int jobID = Convert.ToInt32(row.Cells["JOBID"].Value);
                 string calculatedValue = $"Calculated for JobID: {jobID}";
                 row.Cells["Calculated Column"].Value = calculatedValue;
             }*/


            cn.Close();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 fm = new Form16();
            fm.ShowDialog();
            this.Hide();
            //Applications10 su = new Applications10();
            //su.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage su = new Homepage();
            su.ShowDialog();
            this.Hide();
        }

        private void Form15_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'linkedInDataSet6.JobApplication' table. You can move, or remove it, as needed.
            //  this.jobApplicationTableAdapter1.Fill(this.linkedInDataSet6.JobApplication);
            // TODO: This line of code loads data into the 'linkedInDataSet7.JobApplication' table. You can move, or remove it, as needed.
            //this.jobApplicationTableAdapter.Fill(this.linkedInDataSet7.JobApplication);

        }

        private void button_postjob_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form18 fm = new Form18();
            fm.Userid = Userid;
            fm.ShowDialog();
            this.Hide();
        }
    }

}






