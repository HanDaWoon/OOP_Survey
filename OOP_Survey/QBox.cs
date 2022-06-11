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
    public partial class QBox : UserControl
    {
        public QBox()
        {
            InitializeComponent();
        }

        private void QType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QType.SelectedText == "CheckBox")
            {
                MessageBox.Show("Checkbox");
            }
        }
    }
}
