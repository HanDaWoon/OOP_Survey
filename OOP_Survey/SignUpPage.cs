using MySql.Data.MySqlClient;
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
    public partial class SignUpPage : MetroFramework.Forms.MetroForm
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        public void Btn_SignUp_Click(object sender, EventArgs e)
        {
            if (!isValidID(TextBox_id.Text)) { MessageBox.Show("이미 존재하는 아이디입니다."); return; }
            if (TextBox_pw1.Text != TextBox_pw1.Text) { MessageBox.Show("비밀번호가 일치하지 않습니다. 확인 후 다시 입력해주세요."); return; }

            string value = $"'{TextBox_id.Text}', '{TextBox_pw1.Text}', '{TextBox_name.Text}'";
            LoginPage._db.Insert(DBConf.Tables[(int)eTName._user], value);
            LoginPage.LoadUserInfo();
            MessageBox.Show("회원가입을 완료했습니다. 등록한 아이디로 로그인 해주세요.");
            Close();
        }

        public static bool isValidID(string Text)
        {
            if (DBConf.user_ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in DBConf.user_ds.Tables[0].Rows)
                {
                    if (Text == row["id"].ToString())
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
