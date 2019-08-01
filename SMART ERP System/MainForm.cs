using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using ClassLibrary.FormHelper;
using System.Collections.Generic;
using ClassLibrary;
using System.Linq;

namespace SMART_ERP_System
{
    public partial class MainForm : MetroForm
    {
        LoginForm loginForm;
        List<메뉴등록> menuRegist;

        public MainForm()
        {
            InitializeComponent();
            SetTreeView();
        }

        public void RecieveLoginForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = loginForm.loginControl.txbEmployeeName.Text +
                "님 환영합니다.";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Dispose();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm();
            printForm.SetFormLocation();
            printForm.ShowDialog();
        }

        public void SetTreeView()
        {
            using (ERPEntities entity = new ERPEntities())
            {
                menuRegist = entity.메뉴등록.ToList();

                foreach (var item in menuRegist)
                {
                    if (item.PrentKey == null)
                        treeView.Nodes.Add(item.CodeNum, item.Title);
                }

                foreach (var item in menuRegist)
                {
                    int check = treeView.Nodes.Find(item.PrentKey, true).Length;
                    if (check > 0)
                    {
                        int inputNum = treeView.Nodes.Find(item.PrentKey, true).Length - 1;
                        treeView.Nodes.Find(item.PrentKey, true)[inputNum].Nodes.Add(item.CodeNum, item.Title);
                    }
                }
            }
        }

        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeView treeView = (TreeView)sender;
            TabPage tabPage = new TabPage(treeView.SelectedNode.Text);
            metroTabControl.TabPages.Add(tabPage);
        }

        private void BtnMenuSearch_Click(object sender, EventArgs e)
        {
            SearchNode(treeView.Nodes, txbMenuSearch.Text).Expand();
        }

        public TreeNode SearchNode(TreeNodeCollection collection, string strKey)
        {
            foreach (TreeNode node in collection)
            {
                if (node.Text.Contains(strKey))
                    return node;

                TreeNode findNode = SearchNode(node.Nodes, strKey);
                if (findNode != null)
                    return findNode;
            }

            return null;
        }
    }
}
