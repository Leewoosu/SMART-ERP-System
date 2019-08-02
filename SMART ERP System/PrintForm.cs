using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_ERP_System
{
    public partial class PrintForm : MetroForm
    {
        private PrintDocument printDoc = new PrintDocument();
        private PageSettings pgSettings = new PageSettings();
        private PrinterSettings prtSettings = new PrinterSettings();

        public PrintForm()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printDoc.PrinterSettings = prtSettings;
            printDoc.DefaultPageSettings = pgSettings;
            PrintDialog dlg = new PrintDialog();
            dlg.Document = printDoc;

            if (dlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        private void BtnPrintSetting_Click(object sender, EventArgs e)
        {
            PageSetupDialog psd = new PageSetupDialog();
            psd.AllowPrinter = true;
            psd.AllowOrientation = true;
            psd.AllowMargins = true;
            psd.PageSettings = pgSettings;
            psd.PrinterSettings = prtSettings;

            psd.ShowDialog();
        }

        private void BtnPreView_Click(object sender, EventArgs e)
        {
            printDoc.PrinterSettings = prtSettings;
            printDoc.DefaultPageSettings = pgSettings;
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            dlg.Document = printDoc;
            dlg.ShowDialog();
        }

        // 프린트 핸들러
        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            String textToPrint = ".Net Printing is Easy";
            Font printFont = new Font("Courier New", 40);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            float width = e.PageSettings.PaperSize.Width;
            float height = e.PageSettings.PaperSize.Height;

            //// 이미지는 각자 경로로 변경
            Image img = Image.FromFile(@"C:\Users\301-02\source\repos\SMART ERP System\SMART ERP System\Resources\print-preview.png");
            e.Graphics.DrawImage(img, 0, 0, (int)width, (int)height);
            e.Graphics.DrawString(textToPrint, printFont, Brushes.Red, 50, 100);
        }
    }
}
