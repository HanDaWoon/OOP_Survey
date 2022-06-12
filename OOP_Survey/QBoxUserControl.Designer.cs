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
            this.ChoiceTitlePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateChoice = new MetroFramework.Controls.MetroButton();
            this.QNumOfChoice = new System.Windows.Forms.NumericUpDown();
            this.QType = new MetroFramework.Controls.MetroComboBox();
            this.QTitle = new MetroFramework.Controls.MetroTextBox();
            this.QIdx = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.QNumOfChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoiceTitlePanel
            // 
            this.ChoiceTitlePanel.Location = new System.Drawing.Point(5, 43);
            this.ChoiceTitlePanel.Name = "ChoiceTitlePanel";
            this.ChoiceTitlePanel.Size = new System.Drawing.Size(599, 40);
            this.ChoiceTitlePanel.TabIndex = 20;
            // 
            // CreateChoice
            // 
            this.CreateChoice.Location = new System.Drawing.Point(450, 15);
            this.CreateChoice.Name = "CreateChoice";
            this.CreateChoice.Size = new System.Drawing.Size(55, 21);
            this.CreateChoice.TabIndex = 19;
            this.CreateChoice.Text = "Create";
            this.CreateChoice.UseSelectable = true;
            // 
            // QNumOfChoice
            // 
            this.QNumOfChoice.Location = new System.Drawing.Point(321, 15);
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
            this.QNumOfChoice.TabIndex = 18;
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
            this.QType.Location = new System.Drawing.Point(194, 7);
            this.QType.Name = "QType";
            this.QType.Size = new System.Drawing.Size(121, 29);
            this.QType.TabIndex = 17;
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
            this.QTitle.Location = new System.Drawing.Point(31, 7);
            this.QTitle.MaxLength = 32767;
            this.QTitle.Name = "QTitle";
            this.QTitle.PasswordChar = '\0';
            this.QTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QTitle.SelectedText = "";
            this.QTitle.SelectionLength = 0;
            this.QTitle.SelectionStart = 0;
            this.QTitle.ShortcutsEnabled = true;
            this.QTitle.Size = new System.Drawing.Size(157, 29);
            this.QTitle.TabIndex = 16;
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
            this.QIdx.Location = new System.Drawing.Point(5, 7);
            this.QIdx.Name = "QIdx";
            this.QIdx.Size = new System.Drawing.Size(0, 0);
            this.QIdx.TabIndex = 15;
            // 
            // QBoxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ChoiceTitlePanel);
            this.Controls.Add(this.CreateChoice);
            this.Controls.Add(this.QNumOfChoice);
            this.Controls.Add(this.QType);
            this.Controls.Add(this.QTitle);
            this.Controls.Add(this.QIdx);
            this.Name = "QBoxUserControl";
            this.Size = new System.Drawing.Size(607, 86);
            ((System.ComponentModel.ISupportInitialize)(this.QNumOfChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ChoiceTitlePanel;
        private MetroFramework.Controls.MetroButton CreateChoice;
        private System.Windows.Forms.NumericUpDown QNumOfChoice;
        private MetroFramework.Controls.MetroComboBox QType;
        private MetroFramework.Controls.MetroTextBox QTitle;
        private MetroFramework.Controls.MetroLabel QIdx;
    }
}
