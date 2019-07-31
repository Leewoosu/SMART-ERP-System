using ClassLibrary;
using MyLibrary;
using MyLibrary.EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SMART_ERP_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string EmployeeName
        {
            get
            {
                return txbEmployeeName.Text;
            }
        }

        private void TxbEmployeeCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string name = CheckLoginID(txbEmployeeCode.Text);

                if (name == null)
                    MessageBox.Show("Test");

                txbEmployeeName.Text = name;
            }
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if(CheckPassWord(txbPassWord.Text)==true)
                Close();
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

                LoginSuccess();
                return true;
            }
        }

        public void LoginSuccess()
        {
            MessageBox.Show($"{txbEmployeeName.Text}님이 로그인");
        }
    }
}
