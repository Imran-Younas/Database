namespace LinkedInClone
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Signin = new System.Windows.Forms.Panel();
            this.link_SignUp = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Email1 = new System.Windows.Forms.TextBox();
            this.txt_pass1 = new System.Windows.Forms.TextBox();
            this.button_signin = new System.Windows.Forms.Button();
            this.Signin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Signin
            // 
            this.Signin.BackColor = System.Drawing.Color.Transparent;
            this.Signin.Controls.Add(this.link_SignUp);
            this.Signin.Controls.Add(this.label1);
            this.Signin.Controls.Add(this.txt_Email1);
            this.Signin.Controls.Add(this.txt_pass1);
            this.Signin.Controls.Add(this.button_signin);
            this.Signin.Location = new System.Drawing.Point(166, 43);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(420, 302);
            this.Signin.TabIndex = 0;
            this.Signin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // link_SignUp
            // 
            this.link_SignUp.AutoSize = true;
            this.link_SignUp.BackColor = System.Drawing.Color.Gray;
            this.link_SignUp.Location = new System.Drawing.Point(235, 257);
            this.link_SignUp.Name = "link_SignUp";
            this.link_SignUp.Size = new System.Drawing.Size(62, 16);
            this.link_SignUp.TabIndex = 5;
            this.link_SignUp.TabStop = true;
            this.link_SignUp.Text = "Join Now";
            this.link_SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_SignUp_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(140, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Not a member?";
            // 
            // txt_Email1
            // 
            this.txt_Email1.AllowDrop = true;
            this.txt_Email1.Location = new System.Drawing.Point(39, 106);
            this.txt_Email1.Multiline = true;
            this.txt_Email1.Name = "txt_Email1";
            this.txt_Email1.Size = new System.Drawing.Size(346, 32);
            this.txt_Email1.TabIndex = 2;
            this.txt_Email1.Text = "Email Address";
            this.txt_Email1.UseWaitCursor = true;
            this.txt_Email1.TextChanged += new System.EventHandler(this.txt_Email1_TextChanged);
            // 
            // txt_pass1
            // 
            this.txt_pass1.Location = new System.Drawing.Point(39, 155);
            this.txt_pass1.Multiline = true;
            this.txt_pass1.Name = "txt_pass1";
            this.txt_pass1.Size = new System.Drawing.Size(346, 32);
            this.txt_pass1.TabIndex = 1;
            this.txt_pass1.Text = "Password";
            // 
            // button_signin
            // 
            this.button_signin.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_signin.Location = new System.Drawing.Point(39, 206);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(346, 36);
            this.button_signin.TabIndex = 0;
            this.button_signin.Text = "Sign in";
            this.button_signin.UseVisualStyleBackColor = false;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 454);
            this.Controls.Add(this.Signin);
            this.Name = "Login";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Signin.ResumeLayout(false);
            this.Signin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Signin;
        private System.Windows.Forms.Button button_signin;
        private System.Windows.Forms.TextBox txt_pass1;
        private System.Windows.Forms.TextBox txt_Email1;
        private System.Windows.Forms.LinkLabel link_SignUp;
        private System.Windows.Forms.Label label1;
    }
}

