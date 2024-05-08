namespace LinkedInClone
{
    partial class Form15
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jOBIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobRequirements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobAddsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.linkedInDataSet7 = new LinkedInClone.LinkedInDataSet7();
            this.linkedInDataSet6 = new LinkedInClone.LinkedInDataSet6();
            this.jobApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobApplicationTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.JobApplicationTableAdapter();
            this.jobAddsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobAddsTableAdapter = new LinkedInClone.LinkedInDataSet6TableAdapters.JobAddsTableAdapter();
            this.jobAddsTableAdapter1 = new LinkedInClone.LinkedInDataSet7TableAdapters.JobAddsTableAdapter();
            this.button_postjob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobAddsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobAddsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(543, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(636, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(287, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Job Advertisements";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jOBIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.profileidDataGridViewTextBoxColumn,
            this.JobPosition,
            this.JobDescription,
            this.JobRequirements,
            this.Deadline});
            this.dataGridView1.DataSource = this.jobAddsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(99, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(602, 263);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // jOBIDDataGridViewTextBoxColumn
            // 
            this.jOBIDDataGridViewTextBoxColumn.DataPropertyName = "JOBID";
            this.jOBIDDataGridViewTextBoxColumn.HeaderText = "JOBID";
            this.jOBIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jOBIDDataGridViewTextBoxColumn.Name = "jOBIDDataGridViewTextBoxColumn";
            this.jOBIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // profileidDataGridViewTextBoxColumn
            // 
            this.profileidDataGridViewTextBoxColumn.DataPropertyName = "Profile_id";
            this.profileidDataGridViewTextBoxColumn.HeaderText = "Profile_id";
            this.profileidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.profileidDataGridViewTextBoxColumn.Name = "profileidDataGridViewTextBoxColumn";
            this.profileidDataGridViewTextBoxColumn.Width = 125;
            // 
            // JobPosition
            // 
            this.JobPosition.DataPropertyName = "JobPosition";
            this.JobPosition.HeaderText = "JobPosition";
            this.JobPosition.MinimumWidth = 6;
            this.JobPosition.Name = "JobPosition";
            this.JobPosition.Width = 125;
            // 
            // JobDescription
            // 
            this.JobDescription.DataPropertyName = "JobDescription";
            this.JobDescription.HeaderText = "JobDescription";
            this.JobDescription.MinimumWidth = 6;
            this.JobDescription.Name = "JobDescription";
            this.JobDescription.Width = 125;
            // 
            // JobRequirements
            // 
            this.JobRequirements.DataPropertyName = "JobRequirements";
            this.JobRequirements.HeaderText = "JobRequirements";
            this.JobRequirements.MinimumWidth = 6;
            this.JobRequirements.Name = "JobRequirements";
            this.JobRequirements.Width = 125;
            // 
            // Deadline
            // 
            this.Deadline.DataPropertyName = "Deadline";
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.MinimumWidth = 6;
            this.Deadline.Name = "Deadline";
            this.Deadline.Width = 125;
            // 
            // jobAddsBindingSource1
            // 
            this.jobAddsBindingSource1.DataMember = "JobAdds";
            this.jobAddsBindingSource1.DataSource = this.linkedInDataSet7;
            // 
            // linkedInDataSet7
            // 
            this.linkedInDataSet7.DataSetName = "LinkedInDataSet7";
            this.linkedInDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkedInDataSet6
            // 
            this.linkedInDataSet6.DataSetName = "LinkedInDataSet6";
            this.linkedInDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobApplicationBindingSource
            // 
            this.jobApplicationBindingSource.DataMember = "JobApplication";
            this.jobApplicationBindingSource.DataSource = this.linkedInDataSet6;
            // 
            // jobApplicationTableAdapter
            // 
            this.jobApplicationTableAdapter.ClearBeforeFill = true;
            // 
            // jobAddsBindingSource
            // 
            this.jobAddsBindingSource.DataMember = "JobAdds";
            this.jobAddsBindingSource.DataSource = this.linkedInDataSet6;
            // 
            // jobAddsTableAdapter
            // 
            this.jobAddsTableAdapter.ClearBeforeFill = true;
            // 
            // jobAddsTableAdapter1
            // 
            this.jobAddsTableAdapter1.ClearBeforeFill = true;
            // 
            // button_postjob
            // 
            this.button_postjob.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_postjob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_postjob.Location = new System.Drawing.Point(392, 395);
            this.button_postjob.Name = "button_postjob";
            this.button_postjob.Size = new System.Drawing.Size(88, 28);
            this.button_postjob.TabIndex = 12;
            this.button_postjob.Text = "Job Post";
            this.button_postjob.UseVisualStyleBackColor = false;
            this.button_postjob.Click += new System.EventHandler(this.button_postjob_Click);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_postjob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form15";
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobAddsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobApplicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobAddsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LinkedInDataSet6 linkedInDataSet6;
        private System.Windows.Forms.BindingSource jobApplicationBindingSource;
        private LinkedInDataSet6TableAdapters.JobApplicationTableAdapter jobApplicationTableAdapter;
        private System.Windows.Forms.BindingSource jobAddsBindingSource;
        private LinkedInDataSet6TableAdapters.JobAddsTableAdapter jobAddsTableAdapter;
        private LinkedInDataSet7 linkedInDataSet7;
        private System.Windows.Forms.BindingSource jobAddsBindingSource1;
        private LinkedInDataSet7TableAdapters.JobAddsTableAdapter jobAddsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobRequirements;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.Button button_postjob;
    }
}