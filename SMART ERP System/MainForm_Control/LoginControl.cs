using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using ClassLibrary.FormHelper;

namespace SMART_ERP_System
{
    public partial class LoginControl : UserControl
    {
        private LoginForm _loginForm;

        public void RecieveLoginForm(LoginForm loginForm)
        {
            _loginForm = loginForm;
        }

        public LoginControl()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string name = CheckLoginID(txbEmployeeCode.Text);

            if (name == null)
            {
                MessageBox.Show("사원코드가 일치하지 않음");
            }
            else
            {
                txbEmployeeName.Text = name;
                txbPassWord.Focus();
            }

            if (txbEmployeeCode.Text.IsNullOrEmpty() == true)
            {
                MessageBox.Show("사원코드를 입력하세요");
                return;
            }

            if (txbPassWord.Text.IsNullOrEmpty() == true)
            {
                MessageBox.Show("암호를 입력하세요");
                return;
            }

            if (CheckPassWord(txbPassWord.Text) == true)
            {
                LoginSuccess();
                _loginForm.Visible = false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("종료합니다.");
            Application.Exit();
        }

        private string CheckLoginID(string text)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                string name = entities.사원등록
                    .Where(x => x.사원코드 == text)
                    .Select(x => x.사원명).ToList().FirstOrDefault();

                return name;
            }
        }
        private bool CheckPassWord(string text)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                string pwd = entities.사원등록
                    .Where(x => x.암호 == text)
                    .Select(x => x.암호)
                    .ToList().FirstOrDefault();

                if (pwd == null)
                {
                    MessageBox.Show("틀린 암호");
                    return false;
                }

                return true;
            }
        }
        public void LoginSuccess()
        {
            MessageBox.Show($"{txbEmployeeName.Text}님이 로그인");
        }

        private void TxbEmployeeCode_Enter(object sender, EventArgs e)
        {

        }
    }
}
