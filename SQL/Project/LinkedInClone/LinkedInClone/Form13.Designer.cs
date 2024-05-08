namespace LinkedInClone
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet6 = new LinkedInClone.LinkedInDataSet6();
            this.userConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.user_ConnectionTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.User_ConnectionTableAdapter();
            this.usersTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.UsersTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKJobApplicUserI3FB147EFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobApplicationTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.JobApplicationTableAdapter();
            this.userProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_ProfileTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.User_ProfileTableAdapter();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1_UserProfile = new System.Windows.Forms.Panel();
            this.panel_DropDown1 = new System.Windows.Forms.Panel();
            this.button_Profile1 = new System.Windows.Forms.Button();
            this.button_Logout1 = new System.Windows.Forms.Button();
            this.button_Extra1 = new System.Windows.Forms.Button();
            this.button_Search1 = new System.Windows.Forms.Button();
            this.button_MyNetwork1 = new System.Windows.Forms.Button();
            this.button_Jobs1 = new System.Windows.Forms.Button();
            this.button_Home1 = new System.Windows.Forms.Button();
            this.txt_Search1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connRequestUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionRequestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet7 = new LinkedInClone.LinkedInDataSet7();
            this.connectionRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connection_RequestTableAdapter = new LinkedInClone.LinkedInDataSet7TableAdapters.Connection_RequestTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buutton_accept = new System.Windows.Forms.Button();
            this.button_reject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userConnectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKJobApplicUserI3FB147EFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            this.panel1_UserProfile.SuspendLayout();
            this.panel_DropDown1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionRequestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.ConnUserID,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 176);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 125;
            // 
            // ConnUserID
            // 
            this.ConnUserID.DataPropertyName = "ConnUserID";
            this.ConnUserID.HeaderText = "ConnUserID";
            this.ConnUserID.MinimumWidth = 6;
            this.ConnUserID.Name = "ConnUserID";
            this.ConnUserID.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.linkedInDataSet6;
            // 
            // linkedInDataSet6
            // 
            this.linkedInDataSet6.DataSetName = "LinkedInDataSet6";
            this.linkedInDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userConnectionBindingSource
            // 
            this.userConnectionBindingSource.DataMember = "User_Connection";
            this.userConnectionBindingSource.DataSource = this.linkedInDataSet6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-5, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "My Connections";
            // 
            // user_ConnectionTableAdapter
            // 
            this.user_ConnectionTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.linkedInDataSet6;
            // 
            // fKJobApplicUserI3FB147EFBindingSource
            // 
            this.fKJobApplicUserI3FB147EFBindingSource.DataMember = "FK__JobApplic__UserI__3FB147EF";
            this.fKJobApplicUserI3FB147EFBindingSource.DataSource = this.usersBindingSource1;
            // 
            // jobApplicationTableAdapter
            // 
            this.jobApplicationTableAdapter.ClearBeforeFill = true;
            // 
            // userProfileBindingSource
            // 
            this.userProfileBindingSource.DataMember = "User_Profile";
            this.userProfileBindingSource.DataSource = this.linkedInDataSet6;
            // 
            // user_ProfileTableAdapter
            // 
            this.user_ProfileTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.linkedInDataSet6;
            // 
            // panel1_UserProfile
            // 
            this.panel1_UserProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1_UserProfile.Controls.Add(this.panel_DropDown1);
            this.panel1_UserProfile.Controls.Add(this.button_Search1);
            this.panel1_UserProfile.Controls.Add(this.button_MyNetwork1);
            this.panel1_UserProfile.Controls.Add(this.button_Jobs1);
            this.panel1_UserProfile.Controls.Add(this.button_Home1);
            this.panel1_UserProfile.Controls.Add(this.txt_Search1);
            this.panel1_UserProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_UserProfile.Location = new System.Drawing.Point(0, 0);
            this.panel1_UserProfile.MaximumSize = new System.Drawing.Size(1148, 158);
            this.panel1_UserProfile.MinimumSize = new System.Drawing.Size(1148, 58);
            this.panel1_UserProfile.Name = "panel1_UserProfile";
            this.panel1_UserProfile.Size = new System.Drawing.Size(1148, 58);
            this.panel1_UserProfile.TabIndex = 23;
            // 
            // panel_DropDown1
            // 
            this.panel_DropDown1.Controls.Add(this.button_Profile1);
            this.panel_DropDown1.Controls.Add(this.button_Logout1);
            this.panel_DropDown1.Controls.Add(this.button_Extra1);
            this.panel_DropDown1.Location = new System.Drawing.Point(1071, 0);
            this.panel_DropDown1.MaximumSize = new System.Drawing.Size(54, 140);
            this.panel_DropDown1.MinimumSize = new System.Drawing.Size(54, 51);
            this.panel_DropDown1.Name = "panel_DropDown1";
            this.panel_DropDown1.Size = new System.Drawing.Size(54, 58);
            this.panel_DropDown1.TabIndex = 6;
            // 
            // button_Profile1
            // 
            this.button_Profile1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Profile1.BackgroundImage")));
            this.button_Profile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Profile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Profile1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Profile1.Location = new System.Drawing.Point(0, 105);
            this.button_Profile1.Name = "button_Profile1";
            this.button_Profile1.Size = new System.Drawing.Size(54, 49);
            this.button_Profile1.TabIndex = 7;
            this.button_Profile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Profile1.UseVisualStyleBackColor = true;
            this.button_Profile1.Click += new System.EventHandler(this.button_Profile1_Click);
            // 
            // button_Logout1
            // 
            this.button_Logout1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Logout1.BackgroundImage")));
            this.button_Logout1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Logout1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Logout1.Location = new System.Drawing.Point(0, 58);
            this.button_Logout1.Name = "button_Logout1";
            this.button_Logout1.Size = new System.Drawing.Size(54, 47);
            this.button_Logout1.TabIndex = 6;
            this.button_Logout1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Logout1.UseVisualStyleBackColor = true;
            this.button_Logout1.Click += new System.EventHandler(this.button_Logout1_Click);
            // 
            // button_Extra1
            // 
            this.button_Extra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Extra1.BackgroundImage")));
            this.button_Extra1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Extra1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Extra1.Location = new System.Drawing.Point(0, 0);
            this.button_Extra1.Name = "button_Extra1";
            this.button_Extra1.Size = new System.Drawing.Size(54, 58);
            this.button_Extra1.TabIndex = 5;
            this.button_Extra1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Extra1.UseVisualStyleBackColor = true;
            this.button_Extra1.Click += new System.EventHandler(this.button_Extra1_Click);
            // 
            // button_Search1
            // 
            this.button_Search1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Search1.BackgroundImage")));
            this.button_Search1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Search1.FlatAppearance.BorderSize = 0;
            this.button_Search1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Search1.Location = new System.Drawing.Point(264, 15);
            this.button_Search1.Name = "button_Search1";
            this.button_Search1.Size = new System.Drawing.Size(34, 28);
            this.button_Search1.TabIndex = 7;
            this.button_Search1.UseVisualStyleBackColor = true;
            this.button_Search1.Click += new System.EventHandler(this.button_Search1_Click);
            // 
            // button_MyNetwork1
            // 
            this.button_MyNetwork1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_MyNetwork1.BackgroundImage")));
            this.button_MyNetwork1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_MyNetwork1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_MyNetwork1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_MyNetwork1.Location = new System.Drawing.Point(647, 0);
            this.button_MyNetwork1.Name = "button_MyNetwork1";
            this.button_MyNetwork1.Size = new System.Drawing.Size(64, 58);
            this.button_MyNetwork1.TabIndex = 9;
            this.button_MyNetwork1.Text = "My Network";
            this.button_MyNetwork1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_MyNetwork1.UseVisualStyleBackColor = true;
            this.button_MyNetwork1.Click += new System.EventHandler(this.button_MyNetwork1_Click);
            // 
            // button_Jobs1
            // 
            this.button_Jobs1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Jobs1.BackgroundImage")));
            this.button_Jobs1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Jobs1.Location = new System.Drawing.Point(865, 0);
            this.button_Jobs1.Name = "button_Jobs1";
            this.button_Jobs1.Size = new System.Drawing.Size(61, 58);
            this.button_Jobs1.TabIndex = 8;
            this.button_Jobs1.Text = "Jobs";
            this.button_Jobs1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Jobs1.UseVisualStyleBackColor = true;
            // 
            // button_Home1
            // 
            this.button_Home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Home1.BackgroundImage")));
            this.button_Home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Home1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Home1.Location = new System.Drawing.Point(418, 0);
            this.button_Home1.Name = "button_Home1";
            this.button_Home1.Size = new System.Drawing.Size(57, 58);
            this.button_Home1.TabIndex = 6;
            this.button_Home1.Text = "Home";
            this.button_Home1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Home1.UseVisualStyleBackColor = true;
            this.button_Home1.Click += new System.EventHandler(this.button_Home1_Click);
            // 
            // txt_Search1
            // 
            this.txt_Search1.Location = new System.Drawing.Point(23, 15);
            this.txt_Search1.Multiline = true;
            this.txt_Search1.Name = "txt_Search1";
            this.txt_Search1.Size = new System.Drawing.Size(246, 28);
            this.txt_Search1.TabIndex = 5;
            this.txt_Search1.Text = "Search";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.connRequestUserIdDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.connectionRequestBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(17, 89);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(555, 150);
            this.dataGridView2.TabIndex = 24;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // connRequestUserIdDataGridViewTextBoxColumn
            // 
            this.connRequestUserIdDataGridViewTextBoxColumn.DataPropertyName = "ConnRequestUserId";
            this.connRequestUserIdDataGridViewTextBoxColumn.HeaderText = "ConnRequestUserId";
            this.connRequestUserIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.connRequestUserIdDataGridViewTextBoxColumn.Name = "connRequestUserIdDataGridViewTextBoxColumn";
            this.connRequestUserIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.Width = 125;
            // 
            // connectionRequestBindingSource1
            // 
            this.connectionRequestBindingSource1.DataMember = "Connection_Request";
            this.connectionRequestBindingSource1.DataSource = this.linkedInDataSet7;
            // 
            // linkedInDataSet7
            // 
            this.linkedInDataSet7.DataSetName = "LinkedInDataSet7";
            this.linkedInDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // connectionRequestBindingSource
            // 
            this.connectionRequestBindingSource.DataMember = "Connection_Request";
            this.connectionRequestBindingSource.DataSource = this.linkedInDataSet7;
            // 
            // connection_RequestTableAdapter
            // 
            this.connection_RequestTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Connection Requests";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 46);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buutton_accept
            // 
            this.buutton_accept.Location = new System.Drawing.Point(687, 161);
            this.buutton_accept.Name = "buutton_accept";
            this.buutton_accept.Size = new System.Drawing.Size(75, 33);
            this.buutton_accept.TabIndex = 27;
            this.buutton_accept.Text = "Accept";
            this.buutton_accept.UseVisualStyleBackColor = true;
            this.buutton_accept.Click += new System.EventHandler(this.buutton_accept_Click);
            // 
            // button_reject
            // 
            this.button_reject.Location = new System.Drawing.Point(804, 161);
            this.button_reject.Name = "button_reject";
            this.button_reject.Size = new System.Drawing.Size(75, 33);
            this.button_reject.TabIndex = 28;
            this.button_reject.Text = "Reject";
            this.button_reject.UseVisualStyleBackColor = true;
            this.button_reject.Click += new System.EventHandler(this.button_reject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Request Id";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_reject);
            this.Controls.Add(this.buutton_accept);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1_UserProfile);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form13";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userConnectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKJobApplicUserI3FB147EFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            this.panel1_UserProfile.ResumeLayout(false);
            this.panel1_UserProfile.PerformLayout();
            this.panel_DropDown1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionRequestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionRequestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private LinkedInDataSet6 linkedInDataSet6;
        private System.Windows.Forms.BindingSource userConnectionBindingSource;
        private LinkedInDataSet6TableAdapters.User_ConnectionTableAdapter user_ConnectionTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LinkedInDataSet6TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource fKJobApplicUserI3FB147EFBindingSource;
        private LinkedInDataSet6TableAdapters.JobApplicationTableAdapter jobApplicationTableAdapter;
        private System.Windows.Forms.BindingSource userProfileBindingSource;
        private LinkedInDataSet6TableAdapters.User_ProfileTableAdapter user_ProfileTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1_UserProfile;
        private System.Windows.Forms.Panel panel_DropDown1;
        private System.Windows.Forms.Button button_Profile1;
        private System.Windows.Forms.Button button_Logout1;
        private System.Windows.Forms.Button button_Extra1;
        private System.Windows.Forms.Button button_Search1;
        private System.Windows.Forms.Button button_MyNetwork1;
        private System.Windows.Forms.Button button_Jobs1;
        private System.Windows.Forms.Button button_Home1;
        private System.Windows.Forms.TextBox txt_Search1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private LinkedInDataSet7 linkedInDataSet7;
        private System.Windows.Forms.BindingSource connectionRequestBindingSource;
        private LinkedInDataSet7TableAdapters.Connection_RequestTableAdapter connection_RequestTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buutton_accept;
        private System.Windows.Forms.Button button_reject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connRequestUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource connectionRequestBindingSource1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}