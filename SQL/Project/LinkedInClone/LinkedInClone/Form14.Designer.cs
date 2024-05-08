namespace LinkedInClone
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.educationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instituteNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEducationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet5 = new LinkedInClone.LinkedInDataSet5();
            this.userEducationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet6 = new LinkedInClone.LinkedInDataSet6();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.professionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userProfessionalSkillsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userProfessionalSkillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_LastName = new System.Windows.Forms.TextBox();
            this.text_Location = new System.Windows.Forms.TextBox();
            this.text_PhoneNo = new System.Windows.Forms.TextBox();
            this.text_FirstName = new System.Windows.Forms.TextBox();
            this.user_ProfessionalSkillsTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.User_ProfessionalSkillsTableAdapter();
            this.user_EducationTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.User_EducationTableAdapter();
            this.linkedInDataSet3 = new LinkedInClone.LinkedInDataSet3();
            this.linkedInDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet1 = new LinkedInClone.LinkedInDataSet1();
            this.linkedInDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_ProfessionalSkillsTableAdapter1 = new LinkedInClone.LinkedInDataSet5TableAdapters.User_ProfessionalSkillsTableAdapter();
            this.user_EducationTableAdapter1 = new LinkedInClone.LinkedInDataSet5TableAdapters.User_EducationTableAdapter();
            this.button_ConnectionRequest = new System.Windows.Forms.Button();
            this.button_Home1 = new System.Windows.Forms.Button();
            this.button_Profile1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEducationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEducationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfessionalSkillsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfessionalSkillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(399, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Educational Details";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.educationidDataGridViewTextBoxColumn,
            this.profileidDataGridViewTextBoxColumn1,
            this.instituteNameDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.startingdateDataGridViewTextBoxColumn1,
            this.endingdateDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.userEducationBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(404, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(396, 153);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // educationidDataGridViewTextBoxColumn
            // 
            this.educationidDataGridViewTextBoxColumn.DataPropertyName = "Education_id";
            this.educationidDataGridViewTextBoxColumn.HeaderText = "Education_id";
            this.educationidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.educationidDataGridViewTextBoxColumn.Name = "educationidDataGridViewTextBoxColumn";
            this.educationidDataGridViewTextBoxColumn.Width = 125;
            // 
            // profileidDataGridViewTextBoxColumn1
            // 
            this.profileidDataGridViewTextBoxColumn1.DataPropertyName = "Profile_id";
            this.profileidDataGridViewTextBoxColumn1.HeaderText = "Profile_id";
            this.profileidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.profileidDataGridViewTextBoxColumn1.Name = "profileidDataGridViewTextBoxColumn1";
            this.profileidDataGridViewTextBoxColumn1.Width = 125;
            // 
            // instituteNameDataGridViewTextBoxColumn
            // 
            this.instituteNameDataGridViewTextBoxColumn.DataPropertyName = "Institute_Name";
            this.instituteNameDataGridViewTextBoxColumn.HeaderText = "Institute_Name";
            this.instituteNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instituteNameDataGridViewTextBoxColumn.Name = "instituteNameDataGridViewTextBoxColumn";
            this.instituteNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Degree";
            this.degreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.Width = 125;
            // 
            // startingdateDataGridViewTextBoxColumn1
            // 
            this.startingdateDataGridViewTextBoxColumn1.DataPropertyName = "Starting_date";
            this.startingdateDataGridViewTextBoxColumn1.HeaderText = "Starting_date";
            this.startingdateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.startingdateDataGridViewTextBoxColumn1.Name = "startingdateDataGridViewTextBoxColumn1";
            this.startingdateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // endingdateDataGridViewTextBoxColumn1
            // 
            this.endingdateDataGridViewTextBoxColumn1.DataPropertyName = "Ending_date";
            this.endingdateDataGridViewTextBoxColumn1.HeaderText = "Ending_date";
            this.endingdateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.endingdateDataGridViewTextBoxColumn1.Name = "endingdateDataGridViewTextBoxColumn1";
            this.endingdateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // userEducationBindingSource1
            // 
            this.userEducationBindingSource1.DataMember = "User_Education";
            this.userEducationBindingSource1.DataSource = this.linkedInDataSet5;
            // 
            // linkedInDataSet5
            // 
            this.linkedInDataSet5.DataSetName = "LinkedInDataSet5";
            this.linkedInDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userEducationBindingSource
            // 
            this.userEducationBindingSource.DataMember = "User_Education";
            this.userEducationBindingSource.DataSource = this.linkedInDataSet6BindingSource;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Professional Details";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.professionidDataGridViewTextBoxColumn,
            this.profileidDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.jobPositionDataGridViewTextBoxColumn,
            this.jobDescriptionDataGridViewTextBoxColumn,
            this.startingdateDataGridViewTextBoxColumn,
            this.endingdateDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.userProfessionalSkillsBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(5, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(393, 153);
            this.dataGridView3.TabIndex = 24;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // professionidDataGridViewTextBoxColumn
            // 
            this.professionidDataGridViewTextBoxColumn.DataPropertyName = "Profession_id";
            this.professionidDataGridViewTextBoxColumn.HeaderText = "Profession_id";
            this.professionidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.professionidDataGridViewTextBoxColumn.Name = "professionidDataGridViewTextBoxColumn";
            this.professionidDataGridViewTextBoxColumn.Width = 125;
            // 
            // profileidDataGridViewTextBoxColumn
            // 
            this.profileidDataGridViewTextBoxColumn.DataPropertyName = "Profile_id";
            this.profileidDataGridViewTextBoxColumn.HeaderText = "Profile_id";
            this.profileidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.profileidDataGridViewTextBoxColumn.Name = "profileidDataGridViewTextBoxColumn";
            this.profileidDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "Company_Name";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company_Name";
            this.companyNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobPositionDataGridViewTextBoxColumn
            // 
            this.jobPositionDataGridViewTextBoxColumn.DataPropertyName = "JobPosition";
            this.jobPositionDataGridViewTextBoxColumn.HeaderText = "JobPosition";
            this.jobPositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobPositionDataGridViewTextBoxColumn.Name = "jobPositionDataGridViewTextBoxColumn";
            this.jobPositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobDescriptionDataGridViewTextBoxColumn
            // 
            this.jobDescriptionDataGridViewTextBoxColumn.DataPropertyName = "JobDescription";
            this.jobDescriptionDataGridViewTextBoxColumn.HeaderText = "JobDescription";
            this.jobDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobDescriptionDataGridViewTextBoxColumn.Name = "jobDescriptionDataGridViewTextBoxColumn";
            this.jobDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // startingdateDataGridViewTextBoxColumn
            // 
            this.startingdateDataGridViewTextBoxColumn.DataPropertyName = "Starting_date";
            this.startingdateDataGridViewTextBoxColumn.HeaderText = "Starting_date";
            this.startingdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startingdateDataGridViewTextBoxColumn.Name = "startingdateDataGridViewTextBoxColumn";
            this.startingdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endingdateDataGridViewTextBoxColumn
            // 
            this.endingdateDataGridViewTextBoxColumn.DataPropertyName = "Ending_date";
            this.endingdateDataGridViewTextBoxColumn.HeaderText = "Ending_date";
            this.endingdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endingdateDataGridViewTextBoxColumn.Name = "endingdateDataGridViewTextBoxColumn";
            this.endingdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // userProfessionalSkillsBindingSource1
            // 
            this.userProfessionalSkillsBindingSource1.DataMember = "User_ProfessionalSkills";
            this.userProfessionalSkillsBindingSource1.DataSource = this.linkedInDataSet5;
            // 
            // userProfessionalSkillsBindingSource
            // 
            this.userProfessionalSkillsBindingSource.DataMember = "User_ProfessionalSkills";
            this.userProfessionalSkillsBindingSource.DataSource = this.linkedInDataSet6BindingSource;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Phone No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Personal Details";
            // 
            // text_LastName
            // 
            this.text_LastName.Location = new System.Drawing.Point(79, 308);
            this.text_LastName.Name = "text_LastName";
            this.text_LastName.Size = new System.Drawing.Size(202, 22);
            this.text_LastName.TabIndex = 29;
            // 
            // text_Location
            // 
            this.text_Location.Location = new System.Drawing.Point(79, 356);
            this.text_Location.Name = "text_Location";
            this.text_Location.Size = new System.Drawing.Size(202, 22);
            this.text_Location.TabIndex = 28;
            // 
            // text_PhoneNo
            // 
            this.text_PhoneNo.Location = new System.Drawing.Point(79, 401);
            this.text_PhoneNo.Name = "text_PhoneNo";
            this.text_PhoneNo.Size = new System.Drawing.Size(202, 22);
            this.text_PhoneNo.TabIndex = 27;
            // 
            // text_FirstName
            // 
            this.text_FirstName.Location = new System.Drawing.Point(79, 258);
            this.text_FirstName.Name = "text_FirstName";
            this.text_FirstName.Size = new System.Drawing.Size(202, 22);
            this.text_FirstName.TabIndex = 26;
            // 
            // user_ProfessionalSkillsTableAdapter
            // 
            this.user_ProfessionalSkillsTableAdapter.ClearBeforeFill = true;
            // 
            // user_EducationTableAdapter
            // 
            this.user_EducationTableAdapter.ClearBeforeFill = true;
            // 
            // linkedInDataSet3
            // 
            this.linkedInDataSet3.DataSetName = "LinkedInDataSet3";
            this.linkedInDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkedInDataSet3BindingSource
            // 
            this.linkedInDataSet3BindingSource.DataSource = this.linkedInDataSet3;
            this.linkedInDataSet3BindingSource.Position = 0;
            // 
            // linkedInDataSet1
            // 
            this.linkedInDataSet1.DataSetName = "LinkedInDataSet1";
            this.linkedInDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkedInDataSet1BindingSource
            // 
            this.linkedInDataSet1BindingSource.DataSource = this.linkedInDataSet1;
            this.linkedInDataSet1BindingSource.Position = 0;
            // 
            // user_ProfessionalSkillsTableAdapter1
            // 
            this.user_ProfessionalSkillsTableAdapter1.ClearBeforeFill = true;
            // 
            // user_EducationTableAdapter1
            // 
            this.user_EducationTableAdapter1.ClearBeforeFill = true;
            // 
            // button_ConnectionRequest
            // 
            this.button_ConnectionRequest.Location = new System.Drawing.Point(499, 305);
            this.button_ConnectionRequest.Name = "button_ConnectionRequest";
            this.button_ConnectionRequest.Size = new System.Drawing.Size(97, 67);
            this.button_ConnectionRequest.TabIndex = 35;
            this.button_ConnectionRequest.Text = "Send Connection Request";
            this.button_ConnectionRequest.UseVisualStyleBackColor = true;
            this.button_ConnectionRequest.Click += new System.EventHandler(this.button_ConnectionRequest_Click);
            // 
            // button_Home1
            // 
            this.button_Home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Home1.BackgroundImage")));
            this.button_Home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Home1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Home1.Location = new System.Drawing.Point(611, 305);
            this.button_Home1.Name = "button_Home1";
            this.button_Home1.Size = new System.Drawing.Size(63, 67);
            this.button_Home1.TabIndex = 36;
            this.button_Home1.Text = "Home";
            this.button_Home1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Home1.UseVisualStyleBackColor = true;
            this.button_Home1.Click += new System.EventHandler(this.button_Home1_Click);
            // 
            // button_Profile1
            // 
            this.button_Profile1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Profile1.BackgroundImage")));
            this.button_Profile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Profile1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Profile1.Location = new System.Drawing.Point(421, 305);
            this.button_Profile1.Name = "button_Profile1";
            this.button_Profile1.Size = new System.Drawing.Size(63, 67);
            this.button_Profile1.TabIndex = 37;
            this.button_Profile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Profile1.UseVisualStyleBackColor = true;
            this.button_Profile1.Click += new System.EventHandler(this.button_Profile1_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Profile1);
            this.Controls.Add(this.button_Home1);
            this.Controls.Add(this.button_ConnectionRequest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_LastName);
            this.Controls.Add(this.text_Location);
            this.Controls.Add(this.text_PhoneNo);
            this.Controls.Add(this.text_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label11);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEducationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEducationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfessionalSkillsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfessionalSkillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_LastName;
        private System.Windows.Forms.TextBox text_Location;
        private System.Windows.Forms.TextBox text_PhoneNo;
        private System.Windows.Forms.TextBox text_FirstName;
        private System.Windows.Forms.BindingSource linkedInDataSet6BindingSource;
        private LinkedInDataSet6 linkedInDataSet6;
        private System.Windows.Forms.BindingSource userProfessionalSkillsBindingSource;
        private LinkedInDataSet6TableAdapters.User_ProfessionalSkillsTableAdapter user_ProfessionalSkillsTableAdapter;
        private System.Windows.Forms.BindingSource userEducationBindingSource;
        private LinkedInDataSet6TableAdapters.User_EducationTableAdapter user_EducationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn instituteNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource linkedInDataSet1BindingSource;
        private LinkedInDataSet1 linkedInDataSet1;
        private LinkedInDataSet3 linkedInDataSet3;
        private System.Windows.Forms.BindingSource linkedInDataSet3BindingSource;
        private LinkedInDataSet5 linkedInDataSet5;
        private System.Windows.Forms.BindingSource userProfessionalSkillsBindingSource1;
        private LinkedInDataSet5TableAdapters.User_ProfessionalSkillsTableAdapter user_ProfessionalSkillsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userEducationBindingSource1;
        private LinkedInDataSet5TableAdapters.User_EducationTableAdapter user_EducationTableAdapter1;
        private System.Windows.Forms.Button button_ConnectionRequest;
        private System.Windows.Forms.Button button_Home1;
        private System.Windows.Forms.Button button_Profile1;
    }
}