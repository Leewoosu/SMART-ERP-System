using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SMART_ERP_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode305 = new System.Windows.Forms.TreeNode("전표 등록");
            System.Windows.Forms.TreeNode treeNode306 = new System.Windows.Forms.TreeNode("분개장");
            System.Windows.Forms.TreeNode treeNode307 = new System.Windows.Forms.TreeNode("매입매출장");
            System.Windows.Forms.TreeNode treeNode308 = new System.Windows.Forms.TreeNode("기간비용현황");
            System.Windows.Forms.TreeNode treeNode309 = new System.Windows.Forms.TreeNode("[전표/장부관리]", new System.Windows.Forms.TreeNode[] {
            treeNode305,
            treeNode306,
            treeNode307,
            treeNode308});
            System.Windows.Forms.TreeNode treeNode310 = new System.Windows.Forms.TreeNode("결산자료입력");
            System.Windows.Forms.TreeNode treeNode311 = new System.Windows.Forms.TreeNode("합계잔액시산표");
            System.Windows.Forms.TreeNode treeNode312 = new System.Windows.Forms.TreeNode("재무상태표");
            System.Windows.Forms.TreeNode treeNode313 = new System.Windows.Forms.TreeNode("손익계산서");
            System.Windows.Forms.TreeNode treeNode314 = new System.Windows.Forms.TreeNode("원가보고서");
            System.Windows.Forms.TreeNode treeNode315 = new System.Windows.Forms.TreeNode("[결산/재무제표관리]", new System.Windows.Forms.TreeNode[] {
            treeNode310,
            treeNode311,
            treeNode312,
            treeNode313,
            treeNode314});
            System.Windows.Forms.TreeNode treeNode316 = new System.Windows.Forms.TreeNode("자금계획달력");
            System.Windows.Forms.TreeNode treeNode317 = new System.Windows.Forms.TreeNode("자금현황 & 입출금내역");
            System.Windows.Forms.TreeNode treeNode318 = new System.Windows.Forms.TreeNode("[자금관리]", new System.Windows.Forms.TreeNode[] {
            treeNode316,
            treeNode317});
            System.Windows.Forms.TreeNode treeNode319 = new System.Windows.Forms.TreeNode("예산신청/편성/조정입력");
            System.Windows.Forms.TreeNode treeNode320 = new System.Windows.Forms.TreeNode("예산실적현황");
            System.Windows.Forms.TreeNode treeNode321 = new System.Windows.Forms.TreeNode("[예산관리]", new System.Windows.Forms.TreeNode[] {
            treeNode319,
            treeNode320});
            System.Windows.Forms.TreeNode treeNode322 = new System.Windows.Forms.TreeNode("고정자산등록");
            System.Windows.Forms.TreeNode treeNode323 = new System.Windows.Forms.TreeNode("고정자산관리대장");
            System.Windows.Forms.TreeNode treeNode324 = new System.Windows.Forms.TreeNode("[고정자산관리]", new System.Windows.Forms.TreeNode[] {
            treeNode322,
            treeNode323});
            System.Windows.Forms.TreeNode treeNode325 = new System.Windows.Forms.TreeNode("[업무용승용차 차량등록]");
            System.Windows.Forms.TreeNode treeNode326 = new System.Windows.Forms.TreeNode("부가세신고서");
            System.Windows.Forms.TreeNode treeNode327 = new System.Windows.Forms.TreeNode("[부가가치세관리]", new System.Windows.Forms.TreeNode[] {
            treeNode326});
            System.Windows.Forms.TreeNode treeNode328 = new System.Windows.Forms.TreeNode("계정과목등록");
            System.Windows.Forms.TreeNode treeNode329 = new System.Windows.Forms.TreeNode("[기초정보관리]", new System.Windows.Forms.TreeNode[] {
            treeNode328});
            System.Windows.Forms.TreeNode treeNode330 = new System.Windows.Forms.TreeNode("회계관리", new System.Windows.Forms.TreeNode[] {
            treeNode309,
            treeNode315,
            treeNode318,
            treeNode321,
            treeNode324,
            treeNode325,
            treeNode327,
            treeNode329});
            System.Windows.Forms.TreeNode treeNode331 = new System.Windows.Forms.TreeNode("소득/세액공제 환경설정");
            System.Windows.Forms.TreeNode treeNode332 = new System.Windows.Forms.TreeNode("급/상여 지급일자 등록");
            System.Windows.Forms.TreeNode treeNode333 = new System.Windows.Forms.TreeNode("인사/급여환경설정");
            System.Windows.Forms.TreeNode treeNode334 = new System.Windows.Forms.TreeNode("[기초정보관리] ", new System.Windows.Forms.TreeNode[] {
            treeNode331,
            treeNode332,
            treeNode333});
            System.Windows.Forms.TreeNode treeNode335 = new System.Windows.Forms.TreeNode("인사정보등록");
            System.Windows.Forms.TreeNode treeNode336 = new System.Windows.Forms.TreeNode("사원 입/퇴사현황");
            System.Windows.Forms.TreeNode treeNode337 = new System.Windows.Forms.TreeNode("[인사관리]", new System.Windows.Forms.TreeNode[] {
            treeNode335,
            treeNode336});
            System.Windows.Forms.TreeNode treeNode338 = new System.Windows.Forms.TreeNode("급여입력");
            System.Windows.Forms.TreeNode treeNode339 = new System.Windows.Forms.TreeNode("급여대장");
            System.Windows.Forms.TreeNode treeNode340 = new System.Windows.Forms.TreeNode("사원별 급/상여 변동현황");
            System.Windows.Forms.TreeNode treeNode341 = new System.Windows.Forms.TreeNode("[급여관리]", new System.Windows.Forms.TreeNode[] {
            treeNode338,
            treeNode339,
            treeNode340});
            System.Windows.Forms.TreeNode treeNode342 = new System.Windows.Forms.TreeNode("퇴직기준설정");
            System.Windows.Forms.TreeNode treeNode343 = new System.Windows.Forms.TreeNode("퇴직금산정");
            System.Windows.Forms.TreeNode treeNode344 = new System.Windows.Forms.TreeNode("퇴직금추계액");
            System.Windows.Forms.TreeNode treeNode345 = new System.Windows.Forms.TreeNode("퇴직금산정현황");
            System.Windows.Forms.TreeNode treeNode346 = new System.Windows.Forms.TreeNode("[퇴직정산관리]", new System.Windows.Forms.TreeNode[] {
            treeNode342,
            treeNode343,
            treeNode344,
            treeNode345});
            System.Windows.Forms.TreeNode treeNode347 = new System.Windows.Forms.TreeNode("지방소득세 특별징수명세/납부서");
            System.Windows.Forms.TreeNode treeNode348 = new System.Windows.Forms.TreeNode("원천징수 이행상황신고서");
            System.Windows.Forms.TreeNode treeNode349 = new System.Windows.Forms.TreeNode("[세무관리]", new System.Windows.Forms.TreeNode[] {
            treeNode347,
            treeNode348});
            System.Windows.Forms.TreeNode treeNode350 = new System.Windows.Forms.TreeNode("인사관리", new System.Windows.Forms.TreeNode[] {
            treeNode334,
            treeNode337,
            treeNode341,
            treeNode346,
            treeNode349});
            System.Windows.Forms.TreeNode treeNode351 = new System.Windows.Forms.TreeNode("기준정보");
            System.Windows.Forms.TreeNode treeNode352 = new System.Windows.Forms.TreeNode("기준정보관리");
            System.Windows.Forms.TreeNode treeNode353 = new System.Windows.Forms.TreeNode("[기초정보관리]", new System.Windows.Forms.TreeNode[] {
            treeNode351,
            treeNode352});
            System.Windows.Forms.TreeNode treeNode354 = new System.Windows.Forms.TreeNode("BOM 및 Part Number에 의한 구매소요량 계산 및 조정");
            System.Windows.Forms.TreeNode treeNode355 = new System.Windows.Forms.TreeNode("공정정보");
            System.Windows.Forms.TreeNode treeNode356 = new System.Windows.Forms.TreeNode("설비정보");
            System.Windows.Forms.TreeNode treeNode357 = new System.Windows.Forms.TreeNode("생산현황 조회");
            System.Windows.Forms.TreeNode treeNode358 = new System.Windows.Forms.TreeNode("생산실적 입력");
            System.Windows.Forms.TreeNode treeNode359 = new System.Windows.Forms.TreeNode("일일 / 주간 생산 일보");
            System.Windows.Forms.TreeNode treeNode360 = new System.Windows.Forms.TreeNode("재공관리");
            System.Windows.Forms.TreeNode treeNode361 = new System.Windows.Forms.TreeNode("외주관리");
            System.Windows.Forms.TreeNode treeNode362 = new System.Windows.Forms.TreeNode("외주 입고");
            System.Windows.Forms.TreeNode treeNode363 = new System.Windows.Forms.TreeNode("외주 자재출고");
            System.Windows.Forms.TreeNode treeNode364 = new System.Windows.Forms.TreeNode("외주발주현황");
            System.Windows.Forms.TreeNode treeNode365 = new System.Windows.Forms.TreeNode("외주재고관리");
            System.Windows.Forms.TreeNode treeNode366 = new System.Windows.Forms.TreeNode("생산관리", new System.Windows.Forms.TreeNode[] {
            treeNode353,
            treeNode354,
            treeNode355,
            treeNode356,
            treeNode357,
            treeNode358,
            treeNode359,
            treeNode360,
            treeNode361,
            treeNode362,
            treeNode363,
            treeNode364,
            treeNode365});
            System.Windows.Forms.TreeNode treeNode367 = new System.Windows.Forms.TreeNode("수주등록");
            System.Windows.Forms.TreeNode treeNode368 = new System.Windows.Forms.TreeNode("구매관리");
            System.Windows.Forms.TreeNode treeNode369 = new System.Windows.Forms.TreeNode("구매현황");
            System.Windows.Forms.TreeNode treeNode370 = new System.Windows.Forms.TreeNode("재고관리");
            System.Windows.Forms.TreeNode treeNode371 = new System.Windows.Forms.TreeNode("재고조정");
            System.Windows.Forms.TreeNode treeNode372 = new System.Windows.Forms.TreeNode("기초정보관리");
            System.Windows.Forms.TreeNode treeNode373 = new System.Windows.Forms.TreeNode("출고처리");
            System.Windows.Forms.TreeNode treeNode374 = new System.Windows.Forms.TreeNode("매출액");
            System.Windows.Forms.TreeNode treeNode375 = new System.Windows.Forms.TreeNode("예상 매출액");
            System.Windows.Forms.TreeNode treeNode376 = new System.Windows.Forms.TreeNode("물류관리", new System.Windows.Forms.TreeNode[] {
            treeNode367,
            treeNode368,
            treeNode369,
            treeNode370,
            treeNode371,
            treeNode372,
            treeNode373,
            treeNode374,
            treeNode375});
            System.Windows.Forms.TreeNode treeNode377 = new System.Windows.Forms.TreeNode("시스템 환경설정 및 사용 권한 설정");
            System.Windows.Forms.TreeNode treeNode378 = new System.Windows.Forms.TreeNode("회사정보 등록");
            System.Windows.Forms.TreeNode treeNode379 = new System.Windows.Forms.TreeNode("거래처, 프로젝트, 품목, 물류 등록");
            System.Windows.Forms.TreeNode treeNode380 = new System.Windows.Forms.TreeNode("시스템관리", new System.Windows.Forms.TreeNode[] {
            treeNode377,
            treeNode378,
            treeNode379});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 720);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(673, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 45);
            this.button4.TabIndex = 8;
            this.button4.Text = "정보";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(389, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = "닫기";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "인쇄";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "조회";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HYGothic-Extra", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ERP 솔루션";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1240, 651);
            this.splitContainer2.SplitterDistance = 188;
            this.splitContainer2.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.treeView1);
            this.splitContainer3.Size = new System.Drawing.Size(188, 651);
            this.splitContainer3.SplitterDistance = 39;
            this.splitContainer3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "메뉴검색";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(65, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 21);
            this.textBox1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode305.Name = "Node16";
            treeNode305.Text = "전표 등록";
            treeNode306.Name = "Node17";
            treeNode306.Text = "분개장";
            treeNode307.Name = "Node18";
            treeNode307.Text = "매입매출장";
            treeNode308.Name = "Node19";
            treeNode308.Text = "기간비용현황";
            treeNode309.Name = "Node5";
            treeNode309.Text = "[전표/장부관리]";
            treeNode310.Name = "Node20";
            treeNode310.Text = "결산자료입력";
            treeNode311.Name = "Node21";
            treeNode311.Text = "합계잔액시산표";
            treeNode312.Name = "Node22";
            treeNode312.Text = "재무상태표";
            treeNode313.Name = "Node23";
            treeNode313.Text = "손익계산서";
            treeNode314.Name = "Node24";
            treeNode314.Text = "원가보고서";
            treeNode315.Name = "Node6";
            treeNode315.Text = "[결산/재무제표관리]";
            treeNode316.Name = "Node25";
            treeNode316.Text = "자금계획달력";
            treeNode317.Name = "Node26";
            treeNode317.Text = "자금현황 & 입출금내역";
            treeNode318.Name = "Node7";
            treeNode318.Text = "[자금관리]";
            treeNode319.Name = "Node27";
            treeNode319.Text = "예산신청/편성/조정입력";
            treeNode320.Name = "Node28";
            treeNode320.Text = "예산실적현황";
            treeNode321.Name = "Node8";
            treeNode321.Text = "[예산관리]";
            treeNode322.Name = "Node29";
            treeNode322.Text = "고정자산등록";
            treeNode323.Name = "Node30";
            treeNode323.Text = "고정자산관리대장";
            treeNode324.Name = "Node9";
            treeNode324.Text = "[고정자산관리]";
            treeNode325.Name = "Node11";
            treeNode325.Text = "[업무용승용차 차량등록]";
            treeNode326.Name = "Node15";
            treeNode326.Text = "부가세신고서";
            treeNode327.Name = "Node12";
            treeNode327.Text = "[부가가치세관리]";
            treeNode328.Name = "Node14";
            treeNode328.Text = "계정과목등록";
            treeNode329.Name = "Node13";
            treeNode329.Text = "[기초정보관리]";
            treeNode330.Name = "Node0";
            treeNode330.Text = "회계관리";
            treeNode331.Name = "Node39";
            treeNode331.Text = "소득/세액공제 환경설정";
            treeNode332.Name = "Node40";
            treeNode332.Text = "급/상여 지급일자 등록";
            treeNode333.Name = "Node41";
            treeNode333.Text = "인사/급여환경설정";
            treeNode334.Name = "Node34";
            treeNode334.Text = "[기초정보관리] ";
            treeNode335.Name = "Node42";
            treeNode335.Text = "인사정보등록";
            treeNode336.Name = "Node43";
            treeNode336.Text = "사원 입/퇴사현황";
            treeNode337.Name = "Node35";
            treeNode337.Text = "[인사관리]";
            treeNode338.Name = "Node45";
            treeNode338.Text = "급여입력";
            treeNode339.Name = "Node46";
            treeNode339.Text = "급여대장";
            treeNode340.Name = "Node47";
            treeNode340.Text = "사원별 급/상여 변동현황";
            treeNode341.Name = "Node36";
            treeNode341.Text = "[급여관리]";
            treeNode342.Name = "Node48";
            treeNode342.Text = "퇴직기준설정";
            treeNode343.Name = "Node49";
            treeNode343.Text = "퇴직금산정";
            treeNode344.Name = "Node50";
            treeNode344.Text = "퇴직금추계액";
            treeNode345.Name = "Node51";
            treeNode345.Text = "퇴직금산정현황";
            treeNode346.Name = "Node37";
            treeNode346.Text = "[퇴직정산관리]";
            treeNode347.Name = "Node52";
            treeNode347.Text = "지방소득세 특별징수명세/납부서";
            treeNode348.Name = "Node53";
            treeNode348.Text = "원천징수 이행상황신고서";
            treeNode349.Name = "Node38";
            treeNode349.Text = "[세무관리]";
            treeNode350.Name = "Node1";
            treeNode350.Text = "인사관리";
            treeNode351.Name = "Node57";
            treeNode351.Text = "기준정보";
            treeNode352.Name = "Node0";
            treeNode352.Text = "기준정보관리";
            treeNode353.Name = "Node54";
            treeNode353.Text = "[기초정보관리]";
            treeNode354.Name = "Node56";
            treeNode354.Text = "BOM 및 Part Number에 의한 구매소요량 계산 및 조정";
            treeNode355.Name = "Node1";
            treeNode355.Text = "공정정보";
            treeNode356.Name = "Node2";
            treeNode356.Text = "설비정보";
            treeNode357.Name = "Node3";
            treeNode357.Text = "생산현황 조회";
            treeNode358.Name = "Node4";
            treeNode358.Text = "생산실적 입력";
            treeNode359.Name = "Node5";
            treeNode359.Text = "일일 / 주간 생산 일보";
            treeNode360.Name = "";
            treeNode360.Text = "재공관리";
            treeNode361.Name = "";
            treeNode361.Text = "외주관리";
            treeNode362.Name = "";
            treeNode362.Text = "외주 입고";
            treeNode363.Name = "";
            treeNode363.Text = "외주 자재출고";
            treeNode364.Name = "";
            treeNode364.Text = "외주발주현황";
            treeNode365.Name = "";
            treeNode365.Text = "외주재고관리";
            treeNode366.Name = "Node2";
            treeNode366.Text = "생산관리";
            treeNode367.Name = "Node0";
            treeNode367.Text = "수주등록";
            treeNode368.Name = "";
            treeNode368.Text = "구매관리";
            treeNode369.Name = "";
            treeNode369.Text = "구매현황";
            treeNode370.Name = "";
            treeNode370.Text = "재고관리";
            treeNode371.Name = "";
            treeNode371.Text = "재고조정";
            treeNode372.Name = "";
            treeNode372.Text = "기초정보관리";
            treeNode373.Name = "";
            treeNode373.Text = "출고처리";
            treeNode374.Name = "";
            treeNode374.Text = "매출액";
            treeNode375.Name = "";
            treeNode375.Text = "예상 매출액";
            treeNode376.Name = "Node3";
            treeNode376.Text = "물류관리";
            treeNode377.Name = "Node31";
            treeNode377.Text = "시스템 환경설정 및 사용 권한 설정";
            treeNode378.Name = "Node32";
            treeNode378.Text = "회사정보 등록";
            treeNode379.Name = "Node33";
            treeNode379.Text = "거래처, 프로젝트, 품목, 물류 등록";
            treeNode380.Name = "Node4";
            treeNode380.Text = "시스템관리";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode330,
            treeNode350,
            treeNode366,
            treeNode376,
            treeNode380});
            this.treeView1.Size = new System.Drawing.Size(184, 604);
            this.treeView1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}

