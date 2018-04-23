using System;
using DevExpress.XtraReports.UI;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp;

namespace SubReportExample.Module {
    public partial class ContactReportWithSubreportMappedToViewDataSource : DevExpress.XtraReports.UI.XtraReport {
        public ContactReportWithSubreportMappedToViewDataSource() {
            InitializeComponent();
        }
        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRSubreport subReport = (XRSubreport)sender;
            subReport.ReportSource.Parameters["MasterOid"].Value = GetCurrentColumnValue("Oid");
        }
    }
}
