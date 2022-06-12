using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace OOP_Survey
{
    public partial class QBoxUserControl : UserControl
    {
        public QBoxUserControl(int idx)
        {
            InitializeComponent();

            QIdx.Name = "QIdx" + idx;
            QIdx.Text = idx.ToString();
            QTitle.Name = "QTitle" + idx;
            QTitle.Text = "Q" + idx;
            ChoiceTitlePanel.Name = "QCTP" + idx;

            this.CreateChoice.Click += CreateChoice_Click1;
        }

        private void CreateChoice_Click1(object sender, EventArgs e)
        {
            this.ChoiceTitlePanel.Controls.Clear();
            for(int i = 0; i < QNumOfChoice.Value; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Name = "ChoiceTitle" + QIdx + "_" + i;
                this.ChoiceTitlePanel.Controls.Add(textBox);
            }
        }
    }
}
