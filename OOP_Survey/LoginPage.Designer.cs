namespace OOP_Survey
{
    partial class LoginPage
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
            this.Btn_login = new MetroFramework.Controls.MetroButton();
            this.Label_id = new MetroFramework.Controls.MetroLabel();
            this.Label_password = new MetroFramework.Controls.MetroLabel();
            this.TextBox_id = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_pw = new MetroFramework.Controls.MetroTextBox();
            this.Btn_signup = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Btn_login
            // 
            this.Btn_login.Location = new System.Drawing.Point(273, 107);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(73, 48);
            this.Btn_login.TabIndex = 0;
            this.Btn_login.Text = "LOGIN";
            this.Btn_login.UseSelectable = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Label_id
            // 
            this.Label_id.AutoSize = true;
            this.Label_id.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_id.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_id.Location = new System.Drawing.Point(23, 105);
            this.Label_id.Name = "Label_id";
            this.Label_id.Size = new System.Drawing.Size(30, 25);
            this.Label_id.TabIndex = 1;
            this.Label_id.Text = "ID";
            // 
            // Label_password
            // 
            this.Label_password.AutoSize = true;
            this.Label_password.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_password.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_password.Location = new System.Drawing.Point(23, 130);
            this.Label_password.Name = "Label_password";
            this.Label_password.Size = new System.Drawing.Size(39, 25);
            this.Label_password.TabIndex = 2;
            this.Label_password.Text = "PW";
            // 
            // TextBox_id
            // 
            // 
            // 
            // 
            this.TextBox_id.CustomButton.Image = null;
            this.TextBox_id.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.TextBox_id.CustomButton.Name = "";
            this.TextBox_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_id.CustomButton.TabIndex = 1;
            this.TextBox_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_id.CustomButton.UseSelectable = true;
            this.TextBox_id.CustomButton.Visible = false;
            this.TextBox_id.Lines = new string[0];
            this.TextBox_id.Location = new System.Drawing.Point(81, 107);
            this.TextBox_id.MaxLength = 32767;
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.SelectionLength = 0;
            this.TextBox_id.SelectionStart = 0;
            this.TextBox_id.ShortcutsEnabled = true;
            this.TextBox_id.Size = new System.Drawing.Size(156, 23);
            this.TextBox_id.TabIndex = 3;
            this.TextBox_id.UseSelectable = true;
            this.TextBox_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBox_pw
            // 
            // 
            // 
            // 
            this.TextBox_pw.CustomButton.Image = null;
            this.TextBox_pw.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.TextBox_pw.CustomButton.Name = "";
            this.TextBox_pw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_pw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_pw.CustomButton.TabIndex = 1;
            this.TextBox_pw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_pw.CustomButton.UseSelectable = true;
            this.TextBox_pw.CustomButton.Visible = false;
            this.TextBox_pw.Lines = new string[0];
            this.TextBox_pw.Location = new System.Drawing.Point(81, 132);
            this.TextBox_pw.MaxLength = 32767;
            this.TextBox_pw.Name = "TextBox_pw";
            this.TextBox_pw.PasswordChar = '*';
            this.TextBox_pw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_pw.SelectedText = "";
            this.TextBox_pw.SelectionLength = 0;
            this.TextBox_pw.SelectionStart = 0;
            this.TextBox_pw.ShortcutsEnabled = true;
            this.TextBox_pw.Size = new System.Drawing.Size(156, 23);
            this.TextBox_pw.TabIndex = 4;
            this.TextBox_pw.UseSelectable = true;
            this.TextBox_pw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_pw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_signup
            // 
            this.Btn_signup.Location = new System.Drawing.Point(273, 161);
            this.Btn_signup.Name = "Btn_signup";
            this.Btn_signup.Size = new System.Drawing.Size(73, 29);
            this.Btn_signup.TabIndex = 5;
            this.Btn_signup.Text = "Sign Up";
            this.Btn_signup.UseSelectable = true;
            this.Btn_signup.Click += new System.EventHandler(this.Btn_signup_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 212);
            this.Controls.Add(this.Btn_signup);
            this.Controls.Add(this.TextBox_pw);
            this.Controls.Add(this.TextBox_id);
            this.Controls.Add(this.Label_password);
            this.Controls.Add(this.Label_id);
            this.Controls.Add(this.Btn_login);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FirstPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Btn_login;
        private MetroFramework.Controls.MetroLabel Label_id;
        private MetroFramework.Controls.MetroLabel Label_password;
        private MetroFramework.Controls.MetroTextBox TextBox_id;
        private MetroFramework.Controls.MetroTextBox TextBox_pw;
        private MetroFramework.Controls.MetroButton Btn_signup;
    }
}

