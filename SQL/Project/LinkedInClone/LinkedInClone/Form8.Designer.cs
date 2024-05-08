namespace LinkedInClone
{
    partial class Form8
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Personal Details";
            // 
            // text_LastName
            // 
            this.text_LastName.Location = new System.Drawing.Point(332, 205);
            this.text_LastName.Name = "text_LastName";
            this.text_LastName.Size = new System.Drawing.Size(202, 22);
            this.text_LastName.TabIndex = 12;
            // 
            // text_Location
            // 
            this.text_Location.Location = new System.Drawing.Point(332, 253);
            this.text_Location.Name = "text_Location";
            this.text_Location.Size = new System.Drawing.Size(202, 22);
            this.text_Location.TabIndex = 11;
            // 
            // text_PhoneNo
            // 
            this.text_PhoneNo.Location = new System.Drawing.Point(332, 298);
            this.text_PhoneNo.Name = "text_PhoneNo";
            this.text_PhoneNo.Size = new System.Drawing.Size(202, 22);
            this.text_PhoneNo.TabIndex = 10;
            // 
            // text_FirstName
            // 
            this.text_FirstName.Location = new System.Drawing.Point(332, 155);
            this.text_FirstName.Name = "text_FirstName";
            this.text_FirstName.Size = new System.Drawing.Size(202, 22);
            this.text_FirstName.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(332, 337);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 39);
            this.button_create.TabIndex = 22;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_LastName);
            this.Controls.Add(this.text_Location);
            this.Controls.Add(this.text_PhoneNo);
            this.Controls.Add(this.text_FirstName);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_create;
    }
}