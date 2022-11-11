namespace UI
{
    partial class LoginViewForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.labelIndicator = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.paneForgotPassword = new System.Windows.Forms.Panel();
            this.buttonForgetPasswordCheckEmailandId = new System.Windows.Forms.Button();
            this.buttonSetNewPassword = new System.Windows.Forms.Button();
            this.labelForgotPasswordNewPassword = new System.Windows.Forms.Label();
            this.textBoxForgetPassowrdNewPassword = new System.Windows.Forms.TextBox();
            this.labelForgotPasswordId = new System.Windows.Forms.Label();
            this.labelForgetPasswordUsername = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.paneForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(122, 305);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 34);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.Location = new System.Drawing.Point(345, 305);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(116, 34);
            this.btnForgotPassword.TabIndex = 1;
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.UseVisualStyleBackColor = true;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // labelIndicator
            // 
            this.labelIndicator.AutoSize = true;
            this.labelIndicator.Location = new System.Drawing.Point(91, 250);
            this.labelIndicator.Name = "labelIndicator";
            this.labelIndicator.Size = new System.Drawing.Size(19, 15);
            this.labelIndicator.TabIndex = 2;
            this.labelIndicator.Text = "....";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(91, 97);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(185, 23);
            this.textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AllowDrop = true;
            this.textBoxPassword.Location = new System.Drawing.Point(91, 149);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(185, 23);
            this.textBoxPassword.TabIndex = 4;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(122, 280);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(104, 19);
            this.checkBoxRememberMe.TabIndex = 5;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(91, 131);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(91, 79);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(60, 15);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username";
            // 
            // paneForgotPassword
            // 
            this.paneForgotPassword.Controls.Add(this.buttonForgetPasswordCheckEmailandId);
            this.paneForgotPassword.Controls.Add(this.buttonSetNewPassword);
            this.paneForgotPassword.Controls.Add(this.labelForgotPasswordNewPassword);
            this.paneForgotPassword.Controls.Add(this.textBoxForgetPassowrdNewPassword);
            this.paneForgotPassword.Controls.Add(this.labelForgotPasswordId);
            this.paneForgotPassword.Controls.Add(this.labelForgetPasswordUsername);
            this.paneForgotPassword.Controls.Add(this.textBoxEmail);
            this.paneForgotPassword.Controls.Add(this.textBoxUserId);
            this.paneForgotPassword.Location = new System.Drawing.Point(91, 25);
            this.paneForgotPassword.Name = "paneForgotPassword";
            this.paneForgotPassword.Size = new System.Drawing.Size(370, 203);
            this.paneForgotPassword.TabIndex = 8;
            // 
            // buttonForgetPasswordCheckEmailandId
            // 
            this.buttonForgetPasswordCheckEmailandId.Location = new System.Drawing.Point(222, 44);
            this.buttonForgetPasswordCheckEmailandId.Name = "buttonForgetPasswordCheckEmailandId";
            this.buttonForgetPasswordCheckEmailandId.Size = new System.Drawing.Size(136, 34);
            this.buttonForgetPasswordCheckEmailandId.TabIndex = 13;
            this.buttonForgetPasswordCheckEmailandId.Text = "Check Email and Id";
            this.buttonForgetPasswordCheckEmailandId.UseVisualStyleBackColor = true;
            this.buttonForgetPasswordCheckEmailandId.Click += new System.EventHandler(this.buttonForgetPasswordCheckEmailandId_Click);
            // 
            // buttonSetNewPassword
            // 
            this.buttonSetNewPassword.Location = new System.Drawing.Point(222, 149);
            this.buttonSetNewPassword.Name = "buttonSetNewPassword";
            this.buttonSetNewPassword.Size = new System.Drawing.Size(136, 34);
            this.buttonSetNewPassword.TabIndex = 9;
            this.buttonSetNewPassword.Text = "Set new password";
            this.buttonSetNewPassword.UseVisualStyleBackColor = true;
            this.buttonSetNewPassword.Click += new System.EventHandler(this.buttonSetNewPassword_Click);
            // 
            // labelForgotPasswordNewPassword
            // 
            this.labelForgotPasswordNewPassword.AutoSize = true;
            this.labelForgotPasswordNewPassword.Location = new System.Drawing.Point(16, 131);
            this.labelForgotPasswordNewPassword.Name = "labelForgotPasswordNewPassword";
            this.labelForgotPasswordNewPassword.Size = new System.Drawing.Size(84, 15);
            this.labelForgotPasswordNewPassword.TabIndex = 12;
            this.labelForgotPasswordNewPassword.Text = "New Password";
            // 
            // textBoxForgetPassowrdNewPassword
            // 
            this.textBoxForgetPassowrdNewPassword.Location = new System.Drawing.Point(16, 149);
            this.textBoxForgetPassowrdNewPassword.Name = "textBoxForgetPassowrdNewPassword";
            this.textBoxForgetPassowrdNewPassword.Size = new System.Drawing.Size(163, 23);
            this.textBoxForgetPassowrdNewPassword.TabIndex = 11;
            // 
            // labelForgotPasswordId
            // 
            this.labelForgotPasswordId.AutoSize = true;
            this.labelForgotPasswordId.Location = new System.Drawing.Point(16, 80);
            this.labelForgotPasswordId.Name = "labelForgotPasswordId";
            this.labelForgotPasswordId.Size = new System.Drawing.Size(43, 15);
            this.labelForgotPasswordId.TabIndex = 10;
            this.labelForgotPasswordId.Text = "User Id";
            // 
            // labelForgetPasswordUsername
            // 
            this.labelForgetPasswordUsername.AutoSize = true;
            this.labelForgetPasswordUsername.Location = new System.Drawing.Point(16, 28);
            this.labelForgetPasswordUsername.Name = "labelForgetPasswordUsername";
            this.labelForgetPasswordUsername.Size = new System.Drawing.Size(60, 15);
            this.labelForgetPasswordUsername.TabIndex = 9;
            this.labelForgetPasswordUsername.Text = "Username";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(16, 46);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(163, 23);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(16, 98);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(100, 23);
            this.textBoxUserId.TabIndex = 0;
            // 
            // LoginViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 385);
            this.Controls.Add(this.paneForgotPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelIndicator);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginViewForm";
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginViewForm_Load);
            this.paneForgotPassword.ResumeLayout(false);
            this.paneForgotPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Label labelIndicator;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel paneForgotPassword;
        private System.Windows.Forms.Label labelForgotPasswordId;
        private System.Windows.Forms.Label labelForgetPasswordUsername;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label labelForgotPasswordNewPassword;
        private System.Windows.Forms.TextBox textBoxForgetPassowrdNewPassword;
        private System.Windows.Forms.Button buttonSetNewPassword;
        private System.Windows.Forms.Button buttonForgetPasswordCheckEmailandId;
    }
}