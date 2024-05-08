namespace LinkedInClone
{
    partial class Form18
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
            this.text_Requirements = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.text_Description = new System.Windows.Forms.TextBox();
            this.text_deadline = new System.Windows.Forms.TextBox();
            this.text_Position = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_Requirements
            // 
            this.text_Requirements.Location = new System.Drawing.Point(192, 262);
            this.text_Requirements.Multiline = true;
            this.text_Requirements.Name = "text_Requirements";
            this.text_Requirements.Size = new System.Drawing.Size(749, 82);
            this.text_Requirements.TabIndex = 47;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.button2.Location = new System.Drawing.Point(766, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 46;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.button1.Location = new System.Drawing.Point(866, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 45;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_Description
            // 
            this.text_Description.Location = new System.Drawing.Point(192, 155);
            this.text_Description.Multiline = true;
            this.text_Description.Name = "text_Description";
            this.text_Description.Size = new System.Drawing.Size(749, 82);
            this.text_Description.TabIndex = 43;
            // 
            // text_deadline
            // 
            this.text_deadline.Location = new System.Drawing.Point(192, 100);
            this.text_deadline.Name = "text_deadline";
            this.text_deadline.Size = new System.Drawing.Size(423, 22);
            this.text_deadline.TabIndex = 41;
            // 
            // text_Position
            // 
            this.text_Position.Location = new System.Drawing.Point(192, 41);
            this.text_Position.Name = "text_Position";
            this.text_Position.Size = new System.Drawing.Size(423, 22);
            this.text_Position.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "Job Requirements";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(17, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Job Description";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Job Deadline";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Job Position";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 502);
            this.Controls.Add(this.text_Requirements);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_Description);
            this.Controls.Add(this.text_deadline);
            this.Controls.Add(this.text_Position);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form18";
            this.Text = "Form18";
            this.Load += new System.EventHandler(this.Form18_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Requirements;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_Description;
        private System.Windows.Forms.TextBox text_deadline;
        private System.Windows.Forms.TextBox text_Position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}