namespace LinkedInClone
{
    partial class Form12
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
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_JobDescription = new System.Windows.Forms.TextBox();
            this.text_Edate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text_JobPostion = new System.Windows.Forms.TextBox();
            this.text_Sdate = new System.Windows.Forms.TextBox();
            this.text_CompanyName = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_ProfessionID = new System.Windows.Forms.TextBox();
            this.linkedInDataSet6 = new LinkedInClone.LinkedInDataSet6();
            this.userProfessionalSkillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_ProfessionalSkillsTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.User_ProfessionalSkillsTableAdapter();
            this.professionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfessionalSkillsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Current Professional Details";
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 137);
            this.dataGridView1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Starting Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ending date";
            // 
            // text_JobDescription
            // 
            this.text_JobDescription.Location = new System.Drawing.Point(130, 161);
            this.text_JobDescription.Multiline = true;
            this.text_JobDescription.Name = "text_JobDescription";
            this.text_JobDescription.Size = new System.Drawing.Size(202, 22);
            this.text_JobDescription.TabIndex = 42;
            // 
            // text_Edate
            // 
            this.text_Edate.Location = new System.Drawing.Point(132, 248);
            this.text_Edate.Multiline = true;
            this.text_Edate.Name = "text_Edate";
            this.text_Edate.Size = new System.Drawing.Size(202, 22);
            this.text_Edate.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Job Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Job Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Company Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Professional Details";
            // 
            // text_JobPostion
            // 
            this.text_JobPostion.Location = new System.Drawing.Point(130, 115);
            this.text_JobPostion.Multiline = true;
            this.text_JobPostion.Name = "text_JobPostion";
            this.text_JobPostion.Size = new System.Drawing.Size(202, 22);
            this.text_JobPostion.TabIndex = 36;
            // 
            // text_Sdate
            // 
            this.text_Sdate.Location = new System.Drawing.Point(132, 203);
            this.text_Sdate.Multiline = true;
            this.text_Sdate.Name = "text_Sdate";
            this.text_Sdate.Size = new System.Drawing.Size(202, 22);
            this.text_Sdate.TabIndex = 35;
            // 
            // text_CompanyName
            // 
            this.text_CompanyName.Location = new System.Drawing.Point(132, 72);
            this.text_CompanyName.Multiline = true;
            this.text_CompanyName.Name = "text_CompanyName";
            this.text_CompanyName.Size = new System.Drawing.Size(202, 22);
            this.text_CompanyName.TabIndex = 34;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(364, 137);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(92, 40);
            this.button_back.TabIndex = 47;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(364, 230);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(92, 40);
            this.button_Delete.TabIndex = 46;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(364, 37);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(92, 40);
            this.button_Edit.TabIndex = 45;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "ProfessionID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_ProfessionID
            // 
            this.text_ProfessionID.Location = new System.Drawing.Point(132, 37);
            this.text_ProfessionID.Multiline = true;
            this.text_ProfessionID.Name = "text_ProfessionID";
            this.text_ProfessionID.Size = new System.Drawing.Size(202, 22);
            this.text_ProfessionID.TabIndex = 48;
            // 
            // linkedInDataSet6
            // 
            this.linkedInDataSet6.DataSetName = "LinkedInDataSet6";
            this.linkedInDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userProfessionalSkillsBindingSource
            // 
            this.userProfessionalSkillsBindingSource.DataMember = "User_ProfessionalSkills";
            this.userProfessionalSkillsBindingSource.DataSource = this.linkedInDataSet6;
            // 
            // user_ProfessionalSkillsTableAdapter
            // 
            this.user_ProfessionalSkillsTableAdapter.ClearBeforeFill = true;
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
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_ProfessionID);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_JobDescription);
            this.Controls.Add(this.text_Edate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_JobPostion);
            this.Controls.Add(this.text_Sdate);
            this.Controls.Add(this.text_CompanyName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfessionalSkillsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_JobDescription;
        private System.Windows.Forms.TextBox text_Edate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_JobPostion;
        private System.Windows.Forms.TextBox text_Sdate;
        private System.Windows.Forms.TextBox text_CompanyName;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_ProfessionID;
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
    }
}