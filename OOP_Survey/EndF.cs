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
    public partial class EndF : MetroFramework.Forms.MetroForm
    {
        public EndF()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://13.209.213.208:55896/");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
