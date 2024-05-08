namespace LinkedInClone
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_login = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_signup = new System.Windows.Forms.Button();
            this.txt_Pass2 = new System.Windows.Forms.TextBox();
            this.txt_Email2 = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_signup);
            this.panel1.Controls.Add(this.txt_Pass2);
            this.panel1.Controls.Add(this.txt_Email2);
            this.panel1.Controls.Add(this.txt_LastName);
            this.panel1.Controls.Add(this.txt_FirstName);
            this.panel1.Location = new System.Drawing.Point(619, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 601);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(287, 447);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(40, 16);
            this.label_login.TabIndex = 6;
            this.label_login.TabStop = true;
            this.label_login.Text = "Login";
            this.label_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_login_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(156, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Already a member?";
            // 
            // button_signup
            // 
            this.button_signup.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_signup.Location = new System.Drawing.Point(54, 402);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(353, 32);
            this.button_signup.TabIndex = 4;
            this.button_signup.Text = "Sign Up";
            this.button_signup.UseVisualStyleBackColor = false;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // txt_Pass2
            // 
            this.txt_Pass2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Pass2.Location = new System.Drawing.Point(54, 346);
            this.txt_Pass2.Multiline = true;
            this.txt_Pass2.Name = "txt_Pass2";
            this.txt_Pass2.Size = new System.Drawing.Size(353, 32);
            this.txt_Pass2.TabIndex = 3;
            this.txt_Pass2.Text = "Password";
            this.txt_Pass2.TextChanged += new System.EventHandler(this.txt_Pass2_TextChanged);
            // 
            // txt_Email2
            // 
            this.txt_Email2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Email2.Location = new System.Drawing.Point(54, 292);
            this.txt_Email2.Multiline = true;
            this.txt_Email2.Name = "txt_Email2";
            this.txt_Email2.Size = new System.Drawing.Size(353, 32);
            this.txt_Email2.TabIndex = 2;
            this.txt_Email2.Text = "Email";
            this.txt_Email2.TextChanged += new System.EventHandler(this.txt_Email2_TextChanged);
            // 
            // txt_LastName
            // 
            this.txt_LastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LastName.Location = new System.Drawing.Point(248, 235);
            this.txt_LastName.Multiline = true;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(159, 34);
            this.txt_LastName.TabIndex = 1;
            this.txt_LastName.Text = "Last Name";
            this.txt_LastName.TextChanged += new System.EventHandler(this.txt_LastName_TextChanged);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_FirstName.Location = new System.Drawing.Point(54, 235);
            this.txt_FirstName.Multiline = true;
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(163, 34);
            this.txt_FirstName.TabIndex = 0;
            this.txt_FirstName.Text = "First Name";
            this.txt_FirstName.TextChanged += new System.EventHandler(this.txt_FirstName_TextChanged);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 599);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "SignUp";
            this.Text = "SignUp Page";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Email2;
        private System.Windows.Forms.TextBox txt_Pass2;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel label_login;
    }
}