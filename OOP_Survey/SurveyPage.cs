using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace OOP_Survey
{
    public partial class SurveyPage : MetroFramework.Forms.MetroForm
    {
        int Qnum = 0;
        private string id;
        public static MySql _db = new MySql();


        public SurveyPage(string id)
        {
            InitializeComponent();
            this.id = id;
            LoadUserInfo();
        }

        private void SurveyPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public static void LoadUserInfo()
        {
            //데이터베이스에서 설문 불러오기
            DBConf.survey_ds = _db.SelectAll(DBConf.Tables[1]);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Qnum++;
            QBoxUserControl qBox = new QBoxUserControl(Qnum);
            qBox.Name = "QBox" + Qnum;
            flowLayoutPanel1.Controls.Add(qBox);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.RemoveAt(Qnum - 1);
            Qnum--;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string value = $"'{id}', '{CreateJSON()}'";
            LoginPage._db.InsertData(DBConf.Tables[1], value);

            foreach (DataRow row in DBConf.survey_ds.Tables[0].Rows)
            {
                if (id == row["userid"].ToString())
                {
                    LoginPage._db.DelData(DBConf.Tables[1], id);
                }
            }
            LoginPage._db.InsertData(DBConf.Tables[1], value);
            MessageBox.Show("Complete");
        }

        private string CreateJSON()
        {
            StringBuilder temp = new StringBuilder(50 * flowLayoutPanel1.Controls.Count);
            temp.Append("{ ");
            temp.Append("\"title\": ");
            temp.Append("\"" + TextBox_title.Text.Replace("\"", "\\\"").Replace("\n", "\\n") + "\"");
            temp.Append(",");
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                temp.Append("\"" + i + "\"" + ": {");
                var t = (QBoxUserControl)(flowLayoutPanel1.Controls[i]);
                Dictionary<string, string> tt = t.GetTT();
                var key = tt.Keys.GetEnumerator();
                var value = tt.Values.GetEnumerator();
                key.MoveNext();
                value.MoveNext();
                temp.Append("\"title\": ");
                temp.Append("\"" + key.Current + "\"");
                temp.Append(",");
                temp.Append("\"type\": ");
                temp.Append("\"" + value.Current + "\"");
                temp.Append(",");
                Dictionary<string, string> ttt = t.GetData();
                temp.Append("\"context\": ");
                temp.Append(JsonConvert.SerializeObject(ttt, Formatting.None));
                temp.Append("},");
            }
            temp.Remove(temp.Length - 1, 1);
            temp.Append("}");
            return temp.ToString();
        }
    }
}
