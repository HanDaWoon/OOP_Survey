namespace OOP_Survey
{
    partial class SurveyPage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_title = new MetroFramework.Controls.MetroLabel();
            this.TextBox_title = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(728, 566);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // Label_title
            // 
            this.Label_title.AutoSize = true;
            this.Label_title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_title.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_title.Location = new System.Drawing.Point(23, 90);
            this.Label_title.Name = "Label_title";
            this.Label_title.Size = new System.Drawing.Size(44, 25);
            this.Label_title.TabIndex = 0;
            this.Label_title.Text = "Title";
            // 
            // TextBox_title
            // 
            // 
            // 
            // 
            this.TextBox_title.CustomButton.Image = null;
            this.TextBox_title.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.TextBox_title.CustomButton.Name = "";
            this.TextBox_title.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_title.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_title.CustomButton.TabIndex = 1;
            this.TextBox_title.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_title.CustomButton.UseSelectable = true;
            this.TextBox_title.CustomButton.Visible = false;
            this.TextBox_title.Lines = new string[0];
            this.TextBox_title.Location = new System.Drawing.Point(74, 91);
            this.TextBox_title.MaxLength = 32767;
            this.TextBox_title.Name = "TextBox_title";
            this.TextBox_title.PasswordChar = '\0';
            this.TextBox_title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_title.SelectedText = "";
            this.TextBox_title.SelectionLength = 0;
            this.TextBox_title.SelectionStart = 0;
            this.TextBox_title.ShortcutsEnabled = true;
            this.TextBox_title.Size = new System.Drawing.Size(220, 23);
            this.TextBox_title.TabIndex = 1;
            this.TextBox_title.UseSelectable = true;
            this.TextBox_title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(599, 91);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(25, 25);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "+";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(420, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(173, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Number of question";
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.Location = new System.Drawing.Point(389, 91);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(25, 25);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "-";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(20, 694);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(734, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SurveyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(774, 737);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.TextBox_title);
            this.Controls.Add(this.Label_title);
            this.Name = "SurveyPage";
            this.Text = "Survey";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SurveyPage_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel Label_title;
        private MetroFramework.Controls.MetroTextBox TextBox_title;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Button button1;
    }
}