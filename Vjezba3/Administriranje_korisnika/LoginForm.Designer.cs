namespace Administriranje_korisnika
{
    partial class LoginForm
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
            this.label_please_enter = new System.Windows.Forms.Label();
            this.label_usrname = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_please_enter
            // 
            this.label_please_enter.AutoSize = true;
            this.label_please_enter.Location = new System.Drawing.Point(13, 13);
            this.label_please_enter.Name = "label_please_enter";
            this.label_please_enter.Size = new System.Drawing.Size(186, 13);
            this.label_please_enter.TabIndex = 0;
            this.label_please_enter.Text = "Please enter user credentials to log in:";
            // 
            // label_usrname
            // 
            this.label_usrname.AutoSize = true;
            this.label_usrname.Location = new System.Drawing.Point(7, 48);
            this.label_usrname.Name = "label_usrname";
            this.label_usrname.Size = new System.Drawing.Size(58, 13);
            this.label_usrname.TabIndex = 1;
            this.label_usrname.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(7, 97);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(10, 64);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(199, 20);
            this.usernameBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(10, 113);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(199, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(136, 139);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(75, 23);
            this.logInBtn.TabIndex = 5;
            this.logInBtn.Text = "Log In";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 180);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.label_usrname);
            this.Controls.Add(this.label_please_enter);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_please_enter;
        private System.Windows.Forms.Label label_usrname;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button logInBtn;
    }
}

