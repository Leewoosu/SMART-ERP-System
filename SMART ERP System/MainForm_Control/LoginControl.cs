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
            int chk = Check(txbEmployeeCode.Text, txbPassWord.Text);

            if (chk == 1)
            {
                _loginForm.Hide();
            }
            else
            {
                MessageBox.Show("PassWord를 확인하세요");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int Check(string ID)
        {
            int result;
            string txb;
            using (ERPEntities entity = new ERPEntities())
            {
                result = entity.사원등록.Where(x => x.사원코드 == txbEmployeeCode.Text).ToList().Count;
                txb = entity.사원등록.Where(x => x.사원코드 == txbEmployeeCode.Text).Select(x => x.사원명).ToList().FirstOrDefault();
                if (result == 1)
                    txbEmployeeName.Text = txb;
            }

            return result;
        }

        private int Check(string ID, string PW)
        {
            int result;

            using (ERPEntities entity = new ERPEntities())
            {
                result = entity.사원등록.Where(x => x.사원코드 == txbEmployeeCode.Text && x.암호 == txbPassWord.Text).ToList().Count;

            }

            return result;
        }

        private void TxbEmployeeCode_KeyUp(object sender, KeyEventArgs e)
        {
            int Chk;
            if (e.KeyCode == Keys.Enter)
            {
                Chk = Check(txbEmployeeCode.Text);

                if (Chk == 1)
                {
                    txbPassWord.Focus();
                }
                else
                {
                    txbEmployeeName.Text = "ID를 확인하세요";
                }
            }
        }

        private void TxbPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnOk_Click(null, null);
        }
    }
}