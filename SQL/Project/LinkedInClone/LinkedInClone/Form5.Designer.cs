namespace LinkedInClone
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet6 = new LinkedInClone.LinkedInDataSet6();
            this.button_back = new System.Windows.Forms.Button();
            this.jobAddsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobAddsTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.JobAddsTableAdapter();
            this.commentsTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.CommentsTableAdapter();
            this.jobApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobApplicationTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.JobApplicationTableAdapter();
            this.userProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_ProfileTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.User_ProfileTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.UsersTableAdapter();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posttitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcontent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nooflikes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobAddsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.PostId,
            this.posttitle,
            this.postcontent,
            this.nooflikes,
            this.NoOfComments,
            this.comment});
            this.dataGridView1.DataSource = this.commentsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1107, 450);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.linkedInDataSet6BindingSource;
            // 
            // linkedInDataSet6BindingSource
            // 
            this.linkedInDataSet6BindingSource.DataSource = this.linkedInDataSet6;
            this.linkedInDataSet6BindingSource.Position = 0;
            // 
            // linkedInDataSet6
            // 
            this.linkedInDataSet6.DataSetName = "LinkedInDataSet6";
            this.linkedInDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(517, 504);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 48);
            this.button_back.TabIndex = 9;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // jobAddsBindingSource
            // 
            this.jobAddsBindingSource.DataMember = "JobAdds";
            this.jobAddsBindingSource.DataSource = this.linkedInDataSet6BindingSource;
            // 
            // jobAddsTableAdapter
            // 
            this.jobAddsTableAdapter.ClearBeforeFill = true;
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
            // 
            // jobApplicationBindingSource
            // 
            this.jobApplicationBindingSource.DataMember = "JobApplication";
            this.jobApplicationBindingSource.DataSource = this.linkedInDataSet6BindingSource;
            // 
            // jobApplicationTableAdapter
            // 
            this.jobApplicationTableAdapter.ClearBeforeFill = true;
            // 
            // userProfileBindingSource
            // 
            this.userProfileBindingSource.DataMember = "User_Profile";
            this.userProfileBindingSource.DataSource = this.linkedInDataSet6BindingSource;
            // 
            // user_ProfileTableAdapter
            // 
            this.user_ProfileTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.linkedInDataSet6BindingSource;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "UserID";
            this.userid.HeaderText = "user id";
            this.userid.MinimumWidth = 6;
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Width = 125;
            // 
            // PostId
            // 
            this.PostId.DataPropertyName = "Post_id";
            this.PostId.HeaderText = "post id";
            this.PostId.MinimumWidth = 6;
            this.PostId.Name = "PostId";
            this.PostId.ReadOnly = true;
            this.PostId.Width = 125;
            // 
            // posttitle
            // 
            this.posttitle.DataPropertyName = "Post_Title";
            this.posttitle.HeaderText = "post title";
            this.posttitle.MinimumWidth = 6;
            this.posttitle.Name = "posttitle";
            this.posttitle.ReadOnly = true;
            this.posttitle.Width = 125;
            // 
            // postcontent
            // 
            this.postcontent.DataPropertyName = "Post_Content";
            this.postcontent.HeaderText = "post content";
            this.postcontent.MinimumWidth = 6;
            this.postcontent.Name = "postcontent";
            this.postcontent.ReadOnly = true;
            this.postcontent.Width = 125;
            // 
            // nooflikes
            // 
            this.nooflikes.DataPropertyName = "NoOfLikes";
            this.nooflikes.HeaderText = "No of likes";
            this.nooflikes.MinimumWidth = 6;
            this.nooflikes.Name = "nooflikes";
            this.nooflikes.ReadOnly = true;
            this.nooflikes.Width = 125;
            // 
            // NoOfComments
            // 
            this.NoOfComments.DataPropertyName = "NoOfComments";
            this.NoOfComments.HeaderText = "Total comments";
            this.NoOfComments.MinimumWidth = 6;
            this.NoOfComments.Name = "NoOfComments";
            this.NoOfComments.ReadOnly = true;
            this.NoOfComments.Width = 125;
            // 
            // comment
            // 
            this.comment.DataPropertyName = "CmntTxt";
            this.comment.HeaderText = "comment";
            this.comment.MinimumWidth = 6;
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            this.comment.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 596);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Back";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobAddsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobApplicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.BindingSource linkedInDataSet6BindingSource;
        private LinkedInDataSet6 linkedInDataSet6;
        private System.Windows.Forms.BindingSource jobAddsBindingSource;
        private LinkedInDataSet6TableAdapters.JobAddsTableAdapter jobAddsTableAdapter;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private LinkedInDataSet6TableAdapters.CommentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.BindingSource jobApplicationBindingSource;
        private LinkedInDataSet6TableAdapters.JobApplicationTableAdapter jobApplicationTableAdapter;
        private System.Windows.Forms.BindingSource userProfileBindingSource;
        private LinkedInDataSet6TableAdapters.User_ProfileTableAdapter user_ProfileTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LinkedInDataSet6TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn posttitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcontent;
        private System.Windows.Forms.DataGridViewTextBoxColumn nooflikes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
    }
}