using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Win11Preview
{
    internal class ViewViewModel
    {
        public FixedDocument ReportViewer { get; }
        public ViewViewModel(FixedDocument doc)
        {
            ReportViewer = doc;
        }
    }
}
