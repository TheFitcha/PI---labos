namespace Prijava_i_prikaz_korisničkog_profila
{
    partial class UserProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.adminRadio = new System.Windows.Forms.RadioButton();
            this.guestRadio = new System.Windows.Forms.RadioButton();
            this.employeeRadio = new System.Windows.Forms.RadioButton();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.userGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname:";
            // 
            // firstnameBox
            // 
            this.firstnameBox.Enabled = false;
            this.firstnameBox.Location = new System.Drawing.Point(97, 35);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(199, 22);
            this.firstnameBox.TabIndex = 2;
            // 
            // lastnameBox
            // 
            this.lastnameBox.Enabled = false;
            this.lastnameBox.Location = new System.Drawing.Point(97, 63);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(199, 22);
            this.lastnameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // usernameBox
            // 
            this.usernameBox.Enabled = false;
            this.usernameBox.Location = new System.Drawing.Point(97, 114);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(199, 22);
            this.usernameBox.TabIndex = 6;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(97, 142);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(199, 22);
            this.passwordBox.TabIndex = 7;
            // 
            // userGroupBox
            // 
            this.userGroupBox.Controls.Add(this.employeeRadio);
            this.userGroupBox.Controls.Add(this.guestRadio);
            this.userGroupBox.Controls.Add(this.adminRadio);
            this.userGroupBox.Enabled = false;
            this.userGroupBox.Location = new System.Drawing.Point(97, 171);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(200, 100);
            this.userGroupBox.TabIndex = 8;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "User type:";
            // 
            // adminRadio
            // 
            this.adminRadio.AutoSize = true;
            this.adminRadio.Location = new System.Drawing.Point(26, 22);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(103, 20);
            this.adminRadio.TabIndex = 0;
            this.adminRadio.TabStop = true;
            this.adminRadio.Text = "Administrator";
            this.adminRadio.UseVisualStyleBackColor = true;
            // 
            // guestRadio
            // 
            this.guestRadio.AutoSize = true;
            this.guestRadio.Location = new System.Drawing.Point(26, 48);
            this.guestRadio.Name = "guestRadio";
            this.guestRadio.Size = new System.Drawing.Size(60, 20);
            this.guestRadio.TabIndex = 1;
            this.guestRadio.TabStop = true;
            this.guestRadio.Text = "Guest";
            this.guestRadio.UseVisualStyleBackColor = true;
            // 
            // employeeRadio
            // 
            this.employeeRadio.AutoSize = true;
            this.employeeRadio.Location = new System.Drawing.Point(26, 74);
            this.employeeRadio.Name = "employeeRadio";
            this.employeeRadio.Size = new System.Drawing.Size(87, 20);
            this.employeeRadio.TabIndex = 2;
            this.employeeRadio.TabStop = true;
            this.employeeRadio.Text = "Employee";
            this.employeeRadio.UseVisualStyleBackColor = true;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(220, 277);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(76, 34);
            this.logOutBtn.TabIndex = 9;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 317);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.userGroupBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.firstnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.RadioButton employeeRadio;
        private System.Windows.Forms.RadioButton guestRadio;
        private System.Windows.Forms.RadioButton adminRadio;
        private System.Windows.Forms.Button logOutBtn;
    }
}