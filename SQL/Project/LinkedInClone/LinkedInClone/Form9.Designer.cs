namespace LinkedInClone
{
    partial class Form9
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text_Degree = new System.Windows.Forms.TextBox();
            this.text_Sdate = new System.Windows.Forms.TextBox();
            this.text_Edate = new System.Windows.Forms.TextBox();
            this.text_InstituteName = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Degree";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Starting Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ending date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Institute Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(233, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Education Details";
            // 
            // text_Degree
            // 
            this.text_Degree.Location = new System.Drawing.Point(353, 174);
            this.text_Degree.Multiline = true;
            this.text_Degree.Name = "text_Degree";
            this.text_Degree.Size = new System.Drawing.Size(202, 22);
            this.text_Degree.TabIndex = 21;
            // 
            // text_Sdate
            // 
            this.text_Sdate.Location = new System.Drawing.Point(353, 222);
            this.text_Sdate.Multiline = true;
            this.text_Sdate.Name = "text_Sdate";
            this.text_Sdate.Size = new System.Drawing.Size(202, 22);
            this.text_Sdate.TabIndex = 20;
            // 
            // text_Edate
            // 
            this.text_Edate.Location = new System.Drawing.Point(353, 267);
            this.text_Edate.Multiline = true;
            this.text_Edate.Name = "text_Edate";
            this.text_Edate.Size = new System.Drawing.Size(202, 22);
            this.text_Edate.TabIndex = 19;
            // 
            // text_InstituteName
            // 
            this.text_InstituteName.Location = new System.Drawing.Point(353, 121);
            this.text_InstituteName.Multiline = true;
            this.text_InstituteName.Name = "text_InstituteName";
            this.text_InstituteName.Size = new System.Drawing.Size(202, 22);
            this.text_InstituteName.TabIndex = 18;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(353, 315);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 39);
            this.button_Add.TabIndex = 28;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text_Degree);
            this.Controls.Add(this.text_Sdate);
            this.Controls.Add(this.text_Edate);
            this.Controls.Add(this.text_InstituteName);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
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
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button1;
    }
}