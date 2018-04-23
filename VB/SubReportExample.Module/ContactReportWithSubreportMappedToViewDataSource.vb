Imports System
Imports DevExpress.XtraReports.UI
Imports DevExpress.ExpressApp.Utils
Imports DevExpress.ExpressApp

Namespace SubReportExample.Module
    Partial Public Class ContactReportWithSubreportMappedToViewDataSource
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubreport1.BeforePrint
            Dim subReport As XRSubreport = DirectCast(sender, XRSubreport)
            subReport.ReportSource.Parameters("MasterOid").Value = GetCurrentColumnValue("Oid")
        End Sub
    End Class
End Namespace
