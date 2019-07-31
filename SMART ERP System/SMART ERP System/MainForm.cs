using MetroFramework.Forms;
using SMART_ERP_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_ERP_System
{    
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
        }
    }
}
