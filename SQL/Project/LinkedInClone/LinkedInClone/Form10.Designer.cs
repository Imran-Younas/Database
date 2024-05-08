namespace LinkedInClone
{
    partial class Form10
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text_Degree = new System.Windows.Forms.TextBox();
            this.text_Sdate = new System.Windows.Forms.TextBox();
            this.text_Edate = new System.Windows.Forms.TextBox();
            this.text_InstituteName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.educationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instituteNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEducationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet6 = new LinkedInClone.LinkedInDataSet6();
            this.user_EducationTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.User_EducationTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.text_EducationID = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEducationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Degree";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Starting Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ending date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Institute Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Education Details";
            // 
            // text_Degree
            // 
            this.text_Degree.Location = new System.Drawing.Point(132, 138);
            this.text_Degree.Multiline = true;
            this.text_Degree.Name = "text_Degree";
            this.text_Degree.Size = new System.Drawing.Size(202, 22);
            this.text_Degree.TabIndex = 21;
            // 
            // text_Sdate
            // 
            this.text_Sdate.Location = new System.Drawing.Point(132, 182);
            this.text_Sdate.Multiline = true;
            this.text_Sdate.Name = "text_Sdate";
            this.text_Sdate.Size = new System.Drawing.Size(202, 22);
            this.text_Sdate.TabIndex = 20;
            // 
            // text_Edate
            // 
            this.text_Edate.Location = new System.Drawing.Point(132, 227);
            this.text_Edate.Multiline = true;
            this.text_Edate.Name = "text_Edate";
            this.text_Edate.Size = new System.Drawing.Size(202, 22);
            this.text_Edate.TabIndex = 19;
            // 
            // text_InstituteName
            // 
            this.text_InstituteName.Location = new System.Drawing.Point(132, 93);
            this.text_InstituteName.Multiline = true;
            this.text_InstituteName.Name = "text_InstituteName";
            this.text_InstituteName.Size = new System.Drawing.Size(202, 22);
            this.text_InstituteName.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Current Educational Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.educationidDataGridViewTextBoxColumn,
            this.profileidDataGridViewTextBoxColumn,
            this.instituteNameDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.startingdateDataGridViewTextBoxColumn,
            this.endingdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userEducationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 142);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // educationidDataGridViewTextBoxColumn
            // 
            this.educationidDataGridViewTextBoxColumn.DataPropertyName = "Education_id";
            this.educationidDataGridViewTextBoxColumn.HeaderText = "Education_id";
            this.educationidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.educationidDataGridViewTextBoxColumn.Name = "educationidDataGridViewTextBoxColumn";
            this.educationidDataGridViewTextBoxColumn.Width = 125;
            // 
            // profileidDataGridViewTextBoxColumn
            // 
            this.profileidDataGridViewTextBoxColumn.DataPropertyName = "Profile_id";
            this.profileidDataGridViewTextBoxColumn.HeaderText = "Profile_id";
            this.profileidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.profileidDataGridViewTextBoxColumn.Name = "profileidDataGridViewTextBoxColumn";
            this.profileidDataGridViewTextBoxColumn.Width = 125;
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
            // user_EducationTableAdapter
            // 
            this.user_EducationTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Education ID";
            // 
            // text_EducationID
            // 
            this.text_EducationID.Location = new System.Drawing.Point(132, 53);
            this.text_EducationID.Multiline = true;
            this.text_EducationID.Name = "text_EducationID";
            this.text_EducationID.Size = new System.Drawing.Size(202, 22);
            this.text_EducationID.TabIndex = 29;
            this.text_EducationID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(365, 218);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(92, 40);
            this.button_Delete.TabIndex = 32;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(365, 56);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(92, 40);
            this.button_Edit.TabIndex = 31;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(365, 138);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(92, 40);
            this.button_back.TabIndex = 33;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_EducationID);
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
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEducationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_Degree;
        private System.Windows.Forms.TextBox text_Sdate;
        private System.Windows.Forms.TextBox text_Edate;
        private System.Windows.Forms.TextBox text_InstituteName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource linkedInDataSet6BindingSource;
        private LinkedInDataSet6 linkedInDataSet6;
        private System.Windows.Forms.BindingSource userEducationBindingSource;
        private LinkedInDataSet6TableAdapters.User_EducationTableAdapter user_EducationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instituteNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_EducationID;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_back;
    }
}