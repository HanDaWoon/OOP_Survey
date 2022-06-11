using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Survey
{
    public partial class SurveyPage : MetroFramework.Forms.MetroForm
    {
        int Qnum=0;
        public SurveyPage()
        {
            InitializeComponent();
        }

        private void SurveyPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Qnum++;
            QBoxUserControl qBox = new QBoxUserControl(Qnum);
            flowLayoutPanel1.Controls.Add(qBox);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.RemoveAt(Qnum-1);
            Qnum--;
        }
    }
}
