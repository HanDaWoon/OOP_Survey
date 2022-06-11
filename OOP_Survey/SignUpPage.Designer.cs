namespace OOP_Survey
{
    partial class SignUpPage
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
            this.Label_name = new MetroFramework.Controls.MetroLabel();
            this.Btn_SignUp = new MetroFramework.Controls.MetroButton();
            this.TextBox_pw1 = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_id = new MetroFramework.Controls.MetroTextBox();
            this.Label_password = new MetroFramework.Controls.MetroLabel();
            this.Label_id = new MetroFramework.Controls.MetroLabel();
            this.TextBox_name = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_pw2 = new MetroFramework.Controls.MetroTextBox();
            this.Label_pwCheck = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // Label_name
            // 
            this.Label_name.AutoSize = true;
            this.Label_name.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_name.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_name.Location = new System.Drawing.Point(23, 160);
            this.Label_name.Name = "Label_name";
            this.Label_name.Size = new System.Drawing.Size(96, 25);
            this.Label_name.TabIndex = 0;
            this.Label_name.Text = "Your name";
            // 
            // Btn_SignUp
            // 
            this.Btn_SignUp.Location = new System.Drawing.Point(206, 215);
            this.Btn_SignUp.Name = "Btn_SignUp";
            this.Btn_SignUp.Size = new System.Drawing.Size(75, 23);
            this.Btn_SignUp.TabIndex = 5;
            this.Btn_SignUp.Text = "SignUp";
            this.Btn_SignUp.UseSelectable = true;
            this.Btn_SignUp.Click += new System.EventHandler(this.Btn_SignUp_Click);
            // 
            // TextBox_pw1
            // 
            // 
            // 
            // 
            this.TextBox_pw1.CustomButton.Image = null;
            this.TextBox_pw1.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.TextBox_pw1.CustomButton.Name = "";
            this.TextBox_pw1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_pw1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_pw1.CustomButton.TabIndex = 1;
            this.TextBox_pw1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_pw1.CustomButton.UseSelectable = true;
            this.TextBox_pw1.CustomButton.Visible = false;
            this.TextBox_pw1.Lines = new string[0];
            this.TextBox_pw1.Location = new System.Drawing.Point(125, 102);
            this.TextBox_pw1.MaxLength = 32767;
            this.TextBox_pw1.Name = "TextBox_pw1";
            this.TextBox_pw1.PasswordChar = '*';
            this.TextBox_pw1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_pw1.SelectedText = "";
            this.TextBox_pw1.SelectionLength = 0;
            this.TextBox_pw1.SelectionStart = 0;
            this.TextBox_pw1.ShortcutsEnabled = true;
            this.TextBox_pw1.Size = new System.Drawing.Size(156, 23);
            this.TextBox_pw1.TabIndex = 2;
            this.TextBox_pw1.UseSelectable = true;
            this.TextBox_pw1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_pw1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.TextBox_id.Location = new System.Drawing.Point(125, 73);
            this.TextBox_id.MaxLength = 32767;
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.SelectionLength = 0;
            this.TextBox_id.SelectionStart = 0;
            this.TextBox_id.ShortcutsEnabled = true;
            this.TextBox_id.Size = new System.Drawing.Size(156, 23);
            this.TextBox_id.TabIndex = 1;
            this.TextBox_id.UseSelectable = true;
            this.TextBox_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label_password
            // 
            this.Label_password.AutoSize = true;
            this.Label_password.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_password.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_password.Location = new System.Drawing.Point(23, 102);
            this.Label_password.Name = "Label_password";
            this.Label_password.Size = new System.Drawing.Size(39, 25);
            this.Label_password.TabIndex = 0;
            this.Label_password.Text = "PW";
            // 
            // Label_id
            // 
            this.Label_id.AutoSize = true;
            this.Label_id.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_id.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_id.Location = new System.Drawing.Point(23, 73);
            this.Label_id.Name = "Label_id";
            this.Label_id.Size = new System.Drawing.Size(30, 25);
            this.Label_id.TabIndex = 0;
            this.Label_id.Text = "ID";
            // 
            // TextBox_name
            // 
            // 
            // 
            // 
            this.TextBox_name.CustomButton.Image = null;
            this.TextBox_name.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.TextBox_name.CustomButton.Name = "";
            this.TextBox_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_name.CustomButton.TabIndex = 1;
            this.TextBox_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_name.CustomButton.UseSelectable = true;
            this.TextBox_name.CustomButton.Visible = false;
            this.TextBox_name.Lines = new string[0];
            this.TextBox_name.Location = new System.Drawing.Point(125, 160);
            this.TextBox_name.MaxLength = 32767;
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.SelectionLength = 0;
            this.TextBox_name.SelectionStart = 0;
            this.TextBox_name.ShortcutsEnabled = true;
            this.TextBox_name.Size = new System.Drawing.Size(156, 23);
            this.TextBox_name.TabIndex = 4;
            this.TextBox_name.UseSelectable = true;
            this.TextBox_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBox_pw2
            // 
            // 
            // 
            // 
            this.TextBox_pw2.CustomButton.Image = null;
            this.TextBox_pw2.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.TextBox_pw2.CustomButton.Name = "";
            this.TextBox_pw2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_pw2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_pw2.CustomButton.TabIndex = 1;
            this.TextBox_pw2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_pw2.CustomButton.UseSelectable = true;
            this.TextBox_pw2.CustomButton.Visible = false;
            this.TextBox_pw2.Lines = new string[0];
            this.TextBox_pw2.Location = new System.Drawing.Point(125, 131);
            this.TextBox_pw2.MaxLength = 32767;
            this.TextBox_pw2.Name = "TextBox_pw2";
            this.TextBox_pw2.PasswordChar = '*';
            this.TextBox_pw2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_pw2.SelectedText = "";
            this.TextBox_pw2.SelectionLength = 0;
            this.TextBox_pw2.SelectionStart = 0;
            this.TextBox_pw2.ShortcutsEnabled = true;
            this.TextBox_pw2.Size = new System.Drawing.Size(156, 23);
            this.TextBox_pw2.TabIndex = 3;
            this.TextBox_pw2.UseSelectable = true;
            this.TextBox_pw2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_pw2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label_pwCheck
            // 
            this.Label_pwCheck.AutoSize = true;
            this.Label_pwCheck.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_pwCheck.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_pwCheck.Location = new System.Drawing.Point(23, 131);
            this.Label_pwCheck.Name = "Label_pwCheck";
            this.Label_pwCheck.Size = new System.Drawing.Size(91, 25);
            this.Label_pwCheck.TabIndex = 0;
            this.Label_pwCheck.Text = "PW Check";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.TextBox_pw2);
            this.Controls.Add(this.Label_pwCheck);
            this.Controls.Add(this.TextBox_name);
            this.Controls.Add(this.TextBox_pw1);
            this.Controls.Add(this.TextBox_id);
            this.Controls.Add(this.Label_password);
            this.Controls.Add(this.Label_id);
            this.Controls.Add(this.Btn_SignUp);
            this.Controls.Add(this.Label_name);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Label_id;
        private MetroFramework.Controls.MetroLabel Label_password;
        private MetroFramework.Controls.MetroLabel Label_pwCheck;
        private MetroFramework.Controls.MetroLabel Label_name;
        private MetroFramework.Controls.MetroTextBox TextBox_id;
        private MetroFramework.Controls.MetroTextBox TextBox_pw1;
        private MetroFramework.Controls.MetroTextBox TextBox_pw2;
        private MetroFramework.Controls.MetroTextBox TextBox_name;
        private MetroFramework.Controls.MetroButton Btn_SignUp;
    }
}