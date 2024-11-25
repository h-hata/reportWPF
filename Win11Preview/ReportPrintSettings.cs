using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Printing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Win11Preview
{

    public class ReportPrintSettings : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged=null;

        private string printerName = "" ;
        public string PrinterName
        {
            get => printerName;
            set
            {
                printerName = value;
                NotifyPropertyChanged();
            }
        }

        private int leftMargin;
        public int LeftMargin
        {
            get => leftMargin;
            set
            {
                leftMargin = value;
                NotifyPropertyChanged();
            }
        }

        private int rightMargin;
        public int RightMargin
        {
            get => rightMargin;
            set
            {
                rightMargin = value;
                NotifyPropertyChanged();
            }
        }

        private int topMargin;
        public int TopMargin
        {
            get => topMargin;
            set
            {
                topMargin = value;
                NotifyPropertyChanged();
            }
        }

        private int bottomMargin;
        public int BottomMargin
        {
            get => bottomMargin;
            set
            {
                bottomMargin = value;
                NotifyPropertyChanged();
            }
        }

        private PageMediaSize? paperSize=null;
        public PageMediaSize? PaperSize
        {
            get => paperSize;
            set
            {
                paperSize = value;
                NotifyPropertyChanged();
            }
        }

        private string paperSourceName="";
        public string PaperSourceName
        {
            get => paperSourceName;
            set
            {
                paperSourceName = value;
                NotifyPropertyChanged();
            }
        }

        private int paperSourceKind;
        public int PaperSourceKind
        {
            get => paperSourceKind;
            set
            {
                paperSourceKind = value;
                NotifyPropertyChanged();
            }
        }

        private bool landscape;
        public bool Landscape
        {
            get => landscape;
            set
            {
                landscape = value;
                NotifyPropertyChanged();
            }
        }

        private int? dpi;
        public int? Dpi
        {
            get => dpi;
            set
            {
                dpi = value;
                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
