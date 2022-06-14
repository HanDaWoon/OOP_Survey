using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OOP_Survey
{
    public partial class LoginPage : MetroFramework.Forms.MetroForm
    {
        
        public static MySql _db = new MySql();

        public LoginPage()
        {
            InitializeComponent();
            
            //사용자 정보 가져오기
            LoadUserInfo();
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {
            _db.Connection();
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        {
            SignUpPage signUp = new SignUpPage();
            signUp.ShowDialog();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            LoadUserInfo();
            CheckID_PW(TextBox_id.Text, TextBox_pw.Text);
        }
        public static void LoadUserInfo()
        {
            //데이터베이스에서 사용자 정보 가져오기
            DBConf.user_ds = _db.SelectAll(DBConf.Tables[(int)eTName._user]);
        }

        private void CheckID_PW(string id, string pw)
        {
            //사용자 정보와 비교해서 ID / Password 일치하는 지 확인
            if (DBConf.user_ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in DBConf.user_ds.Tables[0].Rows)
                {
                    if (id == row["id"].ToString())
                    {
                        if (pw == row["pw"].ToString())
                        {
                            this.Hide();
                            SurveyPage surveyPage = new SurveyPage(id);
                            surveyPage.Show();
                            return;
                        }
                        else MessageBox.Show("비밀번호가 일치하지 않습니다. 확인 후 다시 입력해주세요.");
                    }

                }
                MessageBox.Show("사용자 정보가 없습니다.");
            }
            else
            {
                MessageBox.Show("데이터가 없습니다.");
            }
        }
    }
}
