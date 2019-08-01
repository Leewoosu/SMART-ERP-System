using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using ClassLibrary.FormHelper;

namespace SMART_ERP_System
{
    public partial class MainForm : MetroForm
    {
        LoginForm loginForm;

        public MainForm()
        {
            InitializeComponent();
        }

        public void RecieveLoginForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = loginForm.loginControl.txbEmployeeName.Text + "님 환영합니다.";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Dispose();
        }
    }
}
