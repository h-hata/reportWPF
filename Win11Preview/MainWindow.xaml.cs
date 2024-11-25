using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using DataModel;


namespace Win11Preview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyData mydata= new ();
        public ReportPrintSettings PrintSettings = new ReportPrintSettings();

        public MainWindow()
        {
            InitializeComponent();
        }
        private FixedDocument createFixedDocument()
        {
            //FixedDocument生成
            var invoice = new Invoice();
            var page = new FixedPage() { Width = 793.7, Height = 1122.51 };//A4 px
            var pageContent = new PageContent();
            //穴埋め
            invoice.Number.Text = "請求書番号:" + mydata.invoice.ToString();
            invoice.Address.Text = mydata.address.ToString();
            invoice.Company.Text = mydata.name.ToString();
            invoice.Amount.Text = String.Format("{0:#,0} 円", mydata.amount);
            invoice.Memo.Text = mydata.memo.ToString();
            //ページ設定
            var doc = new FixedDocument();
            page.Children.Add(invoice);
            pageContent.Child = page;
            doc.Pages.Add(pageContent);
            return doc;
        }




        private void button1_Click(object sender, RoutedEventArgs e)
        {
            FixedDocument doc=createFixedDocument();
            print(doc);
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            FixedDocument doc = createFixedDocument();
            Viewer win = new Viewer(doc);
            win.Show();
        }

        public void print(FixedDocument doc)
        {
            var localPrintServer = new LocalPrintServer();
            var printQueue = localPrintServer.DefaultPrintQueue;
            var printTicket = printQueue.DefaultPrintTicket;
            printTicket.PageOrientation = PrintSettings.Landscape ? PageOrientation.Landscape : PageOrientation.Portrait;

            var dialog = new PrintDialog
            {
                PageRangeSelection = PageRangeSelection.AllPages,
                UserPageRangeEnabled = false,
                PrintQueue = printQueue,
            };
            dialog.PrintTicket = dialog.PrintQueue.MergeAndValidatePrintTicket(dialog.PrintQueue.DefaultPrintTicket, printTicket).ValidatedPrintTicket;

            bool? allowPrint = dialog.ShowDialog();
            if (allowPrint != null)
            {
                var result = (bool)allowPrint;
                if (result)
                {
                    PrintSettings.PrinterName = dialog.PrintQueue.FullName;
                    var xpsDocumentWriter = PrintQueue.CreateXpsDocumentWriter(printQueue);
                    xpsDocumentWriter.Write(doc, dialog.PrintTicket);
                }
            }
        }


    }
}