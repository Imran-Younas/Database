namespace LinkedInClone
{
    partial class Form6
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
            this.text_FirstName = new System.Windows.Forms.TextBox();
            this.text_PhoneNo = new System.Windows.Forms.TextBox();
            this.text_Location = new System.Windows.Forms.TextBox();
            this.text_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text_Degree = new System.Windows.Forms.TextBox();
            this.text_Sdate = new System.Windows.Forms.TextBox();
            this.text_Edate = new System.Windows.Forms.TextBox();
            this.text_InstituteName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.professionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userProfessionalSkillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet6 = new LinkedInClone.LinkedInDataSet6();
            this.label11 = new System.Windows.Forms.Label();
            this.user_ProfessionalSkillsTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.User_ProfessionalSkillsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfessionalSkillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // text_FirstName
            // 
            this.text_FirstName.Location = new System.Drawing.Point(80, 54);
            this.text_FirstName.Name = "text_FirstName";
            this.text_FirstName.Size = new System.Drawing.Size(202, 22);
            this.text_FirstName.TabIndex = 0;
            // 
            // text_PhoneNo
            // 
            this.text_PhoneNo.Location = new System.Drawing.Point(80, 197);
            this.text_PhoneNo.Name = "text_PhoneNo";
            this.text_PhoneNo.Size = new System.Drawing.Size(202, 22);
            this.text_PhoneNo.TabIndex = 1;
            // 
            // text_Location
            // 
            this.text_Location.Location = new System.Drawing.Point(80, 152);
            this.text_Location.Name = "text_Location";
            this.text_Location.Size = new System.Drawing.Size(202, 22);
            this.text_Location.TabIndex = 2;
            this.text_Location.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // text_LastName
            // 
            this.text_LastName.Location = new System.Drawing.Point(80, 104);
            this.text_LastName.Name = "text_LastName";
            this.text_LastName.Size = new System.Drawing.Size(202, 22);
            this.text_LastName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personal Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone No";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Degree";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Starting Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ending date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Institute Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(299, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Education Details";
            // 
            // text_Degree
            // 
            this.text_Degree.Location = new System.Drawing.Point(419, 104);
            this.text_Degree.Multiline = true;
            this.text_Degree.Name = "text_Degree";
            this.text_Degree.Size = new System.Drawing.Size(202, 22);
            this.text_Degree.TabIndex = 12;
            // 
            // text_Sdate
            // 
            this.text_Sdate.Location = new System.Drawing.Point(419, 152);
            this.text_Sdate.Multiline = true;
            this.text_Sdate.Name = "text_Sdate";
            this.text_Sdate.Size = new System.Drawing.Size(202, 22);
            this.text_Sdate.TabIndex = 11;
            // 
            // text_Edate
            // 
            this.text_Edate.Location = new System.Drawing.Point(419, 197);
            this.text_Edate.Multiline = true;
            this.text_Edate.Name = "text_Edate";
            this.text_Edate.Size = new System.Drawing.Size(202, 22);
            this.text_Edate.TabIndex = 10;
            // 
            // text_InstituteName
            // 
            this.text_InstituteName.Location = new System.Drawing.Point(419, 51);
            this.text_InstituteName.Multiline = true;
            this.text_InstituteName.Name = "text_InstituteName";
            this.text_InstituteName.Size = new System.Drawing.Size(202, 22);
            this.text_InstituteName.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.professionidDataGridViewTextBoxColumn,
            this.profileidDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.jobPositionDataGridViewTextBoxColumn,
            this.jobDescriptionDataGridViewTextBoxColumn,
            this.startingdateDataGridViewTextBoxColumn,
            this.endingdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userProfessionalSkillsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 170);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // userProfessionalSkillsBindingSource
            // 
            this.userProfessionalSkillsBindingSource.DataMember = "User_ProfessionalSkills";
            this.userProfessionalSkillsBindingSource.DataSource = this.linkedInDataSet6BindingSource;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Professional Details";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // user_ProfessionalSkillsTableAdapter
            // 
            this.user_ProfessionalSkillsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_Degree);
            this.Controls.Add(this.text_Sdate);
            this.Controls.Add(this.text_Edate);
            this.Controls.Add(this.text_InstituteName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_LastName);
            this.Controls.Add(this.text_Location);
            this.Controls.Add(this.text_PhoneNo);
            this.Controls.Add(this.text_FirstName);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfessionalSkillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_FirstName;
        private System.Windows.Forms.TextBox text_PhoneNo;
        private System.Windows.Forms.TextBox text_Location;
        private System.Windows.Forms.TextBox text_LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_Degree;
        private System.Windows.Forms.TextBox text_Sdate;
        private System.Windows.Forms.TextBox text_Edate;
        private System.Windows.Forms.TextBox text_InstituteName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource linkedInDataSet6BindingSource;
        private LinkedInDataSet6 linkedInDataSet6;
        private System.Windows.Forms.BindingSource userProfessionalSkillsBindingSource;
        private LinkedInDataSet6TableAdapters.User_ProfessionalSkillsTableAdapter user_ProfessionalSkillsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}