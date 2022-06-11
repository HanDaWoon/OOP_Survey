namespace OOP_Survey
{
    partial class QBoxUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QBox = new System.Windows.Forms.GroupBox();
            this.CreateChoice = new MetroFramework.Controls.MetroButton();
            this.QNumOfChoice = new System.Windows.Forms.NumericUpDown();
            this.QType = new MetroFramework.Controls.MetroComboBox();
            this.QTitle = new MetroFramework.Controls.MetroTextBox();
            this.QIdx = new MetroFramework.Controls.MetroLabel();
            this.ChoiceTitlePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.QBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QNumOfChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // QBox
            // 
            this.QBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QBox.Controls.Add(this.ChoiceTitlePanel);
            this.QBox.Controls.Add(this.CreateChoice);
            this.QBox.Controls.Add(this.QNumOfChoice);
            this.QBox.Controls.Add(this.QType);
            this.QBox.Controls.Add(this.QTitle);
            this.QBox.Controls.Add(this.QIdx);
            this.QBox.Location = new System.Drawing.Point(0, 0);
            this.QBox.Name = "QBox";
            this.QBox.Size = new System.Drawing.Size(612, 101);
            this.QBox.TabIndex = 11;
            this.QBox.TabStop = false;
            this.QBox.Text = "QIdx";
            // 
            // CreateChoice
            // 
            this.CreateChoice.Location = new System.Drawing.Point(452, 20);
            this.CreateChoice.Name = "CreateChoice";
            this.CreateChoice.Size = new System.Drawing.Size(55, 21);
            this.CreateChoice.TabIndex = 13;
            this.CreateChoice.Text = "Create";
            this.CreateChoice.UseSelectable = true;
            // 
            // QNumOfChoice
            // 
            this.QNumOfChoice.Location = new System.Drawing.Point(323, 20);
            this.QNumOfChoice.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.QNumOfChoice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QNumOfChoice.Name = "QNumOfChoice";
            this.QNumOfChoice.Size = new System.Drawing.Size(120, 21);
            this.QNumOfChoice.TabIndex = 12;
            this.QNumOfChoice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // QType
            // 
            this.QType.FormattingEnabled = true;
            this.QType.ItemHeight = 23;
            this.QType.Items.AddRange(new object[] {
            "CheckBox",
            "RadioButton"});
            this.QType.Location = new System.Drawing.Point(196, 12);
            this.QType.Name = "QType";
            this.QType.Size = new System.Drawing.Size(121, 29);
            this.QType.TabIndex = 11;
            this.QType.UseSelectable = true;
            // 
            // QTitle
            // 
            // 
            // 
            // 
            this.QTitle.CustomButton.Image = null;
            this.QTitle.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.QTitle.CustomButton.Name = "";
            this.QTitle.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.QTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QTitle.CustomButton.TabIndex = 1;
            this.QTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QTitle.CustomButton.UseSelectable = true;
            this.QTitle.CustomButton.Visible = false;
            this.QTitle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.QTitle.Lines = new string[] {
        "Q1.title"};
            this.QTitle.Location = new System.Drawing.Point(33, 12);
            this.QTitle.MaxLength = 32767;
            this.QTitle.Name = "QTitle";
            this.QTitle.PasswordChar = '\0';
            this.QTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QTitle.SelectedText = "";
            this.QTitle.SelectionLength = 0;
            this.QTitle.SelectionStart = 0;
            this.QTitle.ShortcutsEnabled = true;
            this.QTitle.Size = new System.Drawing.Size(157, 29);
            this.QTitle.TabIndex = 10;
            this.QTitle.Text = "Q1.title";
            this.QTitle.UseSelectable = true;
            this.QTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QIdx
            // 
            this.QIdx.AutoSize = true;
            this.QIdx.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.QIdx.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.QIdx.Location = new System.Drawing.Point(7, 12);
            this.QIdx.Name = "QIdx";
            this.QIdx.Size = new System.Drawing.Size(0, 0);
            this.QIdx.TabIndex = 9;
            // 
            // ChoiceTitlePanel
            // 
            this.ChoiceTitlePanel.Location = new System.Drawing.Point(7, 48);
            this.ChoiceTitlePanel.Name = "ChoiceTitlePanel";
            this.ChoiceTitlePanel.Size = new System.Drawing.Size(599, 40);
            this.ChoiceTitlePanel.TabIndex = 14;
            // 
            // QBoxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.QBox);
            this.Name = "QBoxUserControl";
            this.Size = new System.Drawing.Size(615, 104);
            this.QBox.ResumeLayout(false);
            this.QBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QNumOfChoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox QBox;
        private System.Windows.Forms.NumericUpDown QNumOfChoice;
        private MetroFramework.Controls.MetroComboBox QType;
        private MetroFramework.Controls.MetroTextBox QTitle;
        private MetroFramework.Controls.MetroLabel QIdx;
        private MetroFramework.Controls.MetroButton CreateChoice;
        private System.Windows.Forms.FlowLayoutPanel ChoiceTitlePanel;
    }
}
