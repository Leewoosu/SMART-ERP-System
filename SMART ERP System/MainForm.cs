using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using ClassLibrary.FormHelper;
using System.Collections.Generic;
using ClassLibrary;
using System.Linq;
using SMART_ERP_System.MenuUserControl;

namespace SMART_ERP_System
{
    public partial class MainForm : MetroForm
    {
        LoginForm loginForm;
        List<메뉴등록> menuItems;
        List<UserControl> controls;

        public MainForm()
        {
            InitializeComponent();
            SetTreeView();
        }

        #region Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            AddControls();
            Text = loginForm.loginControl.txbEmployeeName.Text +
                "님 환영합니다.";
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Dispose();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (metroTabControl.TabCount != 0)
                metroTabControl.TabPages.Remove(metroTabControl.SelectedTab);
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm();
            printForm.SetFormLocation();
            printForm.ShowDialog();
        }
        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string SerchName;

            if ((sender as TreeNode) != null)
            {
                TreeNode treeNode = (TreeNode)sender;
                SerchName = treeNode.Text;
            }
            else
            {
                SerchName = treeView.SelectedNode.Text;
            }

            int i = metroTabControl.TabPages.Count;
            if (i == 0)
            {
                foreach (var control in controls)
                {
                    if (SerchName == control.Name)
                    {
                        TabPage tabPage = new TabPage(Text = $"{control.Name}");
                        metroTabControl.TabPages.Add(tabPage);
                        control.Parent = tabPage;
                        control.Show();
                        control.Dock = DockStyle.Fill;
                        metroTabControl.SelectedTab = tabPage;
                        return;
                    }
                }
            }
            else
            {
                int CurrentPageNumber = metroTabControl.SelectedIndex;

                for (int j = 0; j < i; j++)
                {
                    metroTabControl.Visible = false;
                    metroTabControl.SelectedIndex = j;
                    if (metroTabControl.SelectedTab.Text == SerchName)
                    {
                        metroTabControl.Visible = true;
                        return;
                    }
                }

                metroTabControl.Visible = true;

                foreach (var control in controls)
                {
                    if (SerchName == control.Name)
                    {
                        TabPage tabPage = new TabPage(Text = $"{control.Name}");
                        metroTabControl.TabPages.Add(tabPage);

                        control.Parent = tabPage;
                        control.Show();
                        control.Dock = DockStyle.Fill;
                        metroTabControl.SelectedTab = tabPage;
                        return;
                    }
                }
                metroTabControl.SelectedIndex = CurrentPageNumber;
            }
        }
        private void BtnMenuSearch_Click(object sender, EventArgs e)
        {


        }
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Info");
        }
        private void TxbMenuSearch_KeyUp(object sender, KeyEventArgs e)
        {
            List<string> searchingMenu = new List<string>();
            listBox.Visible = false;
            listBox.Items.Clear();

            if (txbMenuSearch.Text.Length >= 2)
            {
                foreach (var item in menuItems)
                {
                    if (item.Title.Contains(txbMenuSearch.Text) == true)
                    {
                        listBox.Items.Add(item.Title);
                    }
                }

                foreach (var item in searchingMenu)
                {
                    listBox.Items.Add(item);
                }
                listBox.Visible = true;
            }
        }
        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            listBox.Visible = false;
            string keyValue = listBox.SelectedItem.ToString();
            TreeNode node = SearchNode(keyValue, treeView.Nodes[0]);
            TreeView_NodeMouseDoubleClick(node, null);
        }
        #endregion

        public void RecieveLoginForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
        }

        public void AddControls()
        {
            controls = new List<UserControl>();
            controls.Add(전표등록 = new 전표등록());
            controls.Add(전표출력 = new 전표출력());
            controls.Add(분개장 = new 분개장());
            controls.Add(결산자료입력 = new 결산자료입력());
            controls.Add(합계잔액시산표 = new 합계잔액시산표());
            controls.Add(재무상태표 = new 재무상태표());
            controls.Add(손익계산서 = new 손익계산서());
            controls.Add(원가보고서 = new 원가보고서());
            controls.Add(고정자산등록 = new 고정자산등록());
            controls.Add(고정자산관리대장 = new 고정자산관리대장());
            controls.Add(업무용승용차차량등록 = new 업무용승용차차량등록());
            controls.Add(계정과목등록 = new 계정과목등록());
            controls.Add(소득세액공제환경설정 = new 소득세액공제환경설정());
            controls.Add(인사급여환경설정 = new 인사급여환경설정());
            controls.Add(인사정보등록 = new 인사정보등록());
            controls.Add(급여입력 = new 급여입력());
            controls.Add(급여대장 = new 급여대장());
            controls.Add(퇴직기준설정 = new 퇴직기준설정());
            controls.Add(퇴직금산정 = new 퇴직금산정());
            controls.Add(퇴직금산정현황 = new 퇴직금산정현황());
            controls.Add(BOM등록및정전개 = new BOM등록및정전개());
            controls.Add(불량유형등록 = new 불량유형등록());
            controls.Add(생산현황조회 = new 생산현황조회());
            controls.Add(생산실적입력 = new 생산실적입력());
            controls.Add(일일주간생산일보 = new 일일주간생산일보());
            controls.Add(재공관리 = new 재공관리());
            controls.Add(외주입고 = new 외주입고());
            controls.Add(외주자재출고 = new 외주자재출고());
            controls.Add(외주발주현황 = new 외주발주현황());
            controls.Add(청구등록 = new 청구등록());
            controls.Add(입고검사등록 = new 입고검사등록());
            controls.Add(발주등록 = new 발주등록());
            controls.Add(입고처리 = new 입고처리());
            controls.Add(소요량전개 = new 소요량전개());
            controls.Add(발주현황 = new 발주현황());
            controls.Add(입고현황 = new 입고현황());
            controls.Add(청구현황 = new 청구현황());
            controls.Add(품목단가등록 = new 품목단가등록());
            controls.Add(자재등록 = new 자재등록());
            controls.Add(출고처리 = new 출고처리());
        }

        public void SetTreeView()
        {
            using (ERPEntities entity = new ERPEntities())
            {
                menuItems = entity.메뉴등록.ToList();

                foreach (var item in menuItems)
                {
                    if (item.PrentKey == null)
                        treeView.Nodes.Add(item.CodeNum, item.Title);
                }

                foreach (var item in menuItems)
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

        private TreeNode SearchNode(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    node = StartNode;
                    break;
                }

                if (StartNode.Nodes.Count != 0)
                {
                    node = SearchNode(SearchText, StartNode.Nodes[0]);

                    if (node != null)
                    {
                        break;
                    }
                }
                StartNode = StartNode.NextNode;
            }
            return node;
        }
    }
}