namespace LinkedInClone
{
    partial class Form7
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_LastName = new System.Windows.Forms.TextBox();
            this.text_Location = new System.Windows.Forms.TextBox();
            this.text_PhoneNo = new System.Windows.Forms.TextBox();
            this.text_FirstName = new System.Windows.Forms.TextBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Personal Details";
            // 
            // text_LastName
            // 
            this.text_LastName.Location = new System.Drawing.Point(319, 166);
            this.text_LastName.Name = "text_LastName";
            this.text_LastName.Size = new System.Drawing.Size(202, 22);
            this.text_LastName.TabIndex = 12;
            // 
            // text_Location
            // 
            this.text_Location.Location = new System.Drawing.Point(319, 214);
            this.text_Location.Name = "text_Location";
            this.text_Location.Size = new System.Drawing.Size(202, 22);
            this.text_Location.TabIndex = 11;
            // 
            // text_PhoneNo
            // 
            this.text_PhoneNo.Location = new System.Drawing.Point(319, 259);
            this.text_PhoneNo.Name = "text_PhoneNo";
            this.text_PhoneNo.Size = new System.Drawing.Size(202, 22);
            this.text_PhoneNo.TabIndex = 10;
            // 
            // text_FirstName
            // 
            this.text_FirstName.Location = new System.Drawing.Point(319, 116);
            this.text_FirstName.Name = "text_FirstName";
            this.text_FirstName.Size = new System.Drawing.Size(202, 22);
            this.text_FirstName.TabIndex = 9;
            this.text_FirstName.TextChanged += new System.EventHandler(this.text_FirstName_TextChanged);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(319, 300);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(92, 40);
            this.button_Edit.TabIndex = 18;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(429, 300);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(92, 40);
            this.button_Delete.TabIndex = 19;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(373, 356);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(92, 40);
            this.button_back.TabIndex = 20;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_LastName);
            this.Controls.Add(this.text_Location);
            this.Controls.Add(this.text_PhoneNo);
            this.Controls.Add(this.text_FirstName);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_LastName;
        private System.Windows.Forms.TextBox text_Location;
        private System.Windows.Forms.TextBox text_PhoneNo;
        private System.Windows.Forms.TextBox text_FirstName;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_back;
    }
}