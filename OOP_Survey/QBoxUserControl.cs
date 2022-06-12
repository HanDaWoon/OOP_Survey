using MetroFramework.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_Survey
{
    public partial class QBoxUserControl : UserControl
    {
        public QBoxUserControl(int idx)
        {
            InitializeComponent();

            QIdx.Name = idx.ToString();
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
                textBox.Name = QIdx.Name + "_" + i;
                this.ChoiceTitlePanel.Controls.Add(textBox);
            }
        }
        public Dictionary<string, string> GetTT()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add(QTitle.Text, QType.Text);
            return result;
        }

        public Dictionary<string,string> GetData()
        {
            Dictionary<string,string> data = new Dictionary<string,string>();
            
            for (int i = 0; i < ChoiceTitlePanel.Controls.Count; i++)
            {
                data.Add(ChoiceTitlePanel.Controls[i].Name, ChoiceTitlePanel.Controls[i].Text);
            }
            return data;
        }

    }
}
