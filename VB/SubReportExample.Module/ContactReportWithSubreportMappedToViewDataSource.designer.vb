Namespace SubReportExample.Module
    Partial Public Class ContactReportWithSubreportMappedToViewDataSource
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim viewProperty1 As New DevExpress.Persistent.Base.ReportsV2.ViewProperty()
            Dim viewProperty2 As New DevExpress.Persistent.Base.ReportsV2.ViewProperty()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.viewDataSource1 = New DevExpress.Persistent.Base.ReportsV2.ViewDataSource()
            Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
            DirectCast(Me.viewDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrSubreport1, Me.xrLabel3, Me.xrLabel1})
            Me.Detail.HeightF = 111.875F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.xrLabel3.Multiline = True
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(100F, 23F)
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.Text = "Full Name:" & ControlChars.CrLf
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FullName")})
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 12F)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(110F, 10.00001F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(452.0834F, 23F)
            Me.xrLabel1.StylePriority.UseFont = False
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel5})
            Me.ReportHeader.HeightF = 68.75F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 25F)
            Me.xrLabel5.ForeColor = System.Drawing.Color.Maroon
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(350F, 37.58334F)
            Me.xrLabel5.StylePriority.UseFont = False
            Me.xrLabel5.StylePriority.UseForeColor = False
            Me.xrLabel5.Text = "Contacts"
            ' 
            ' viewDataSource1
            ' 
            Me.viewDataSource1.Name = "viewDataSource1"
            Me.viewDataSource1.ObjectTypeName = "DevExpress.Persistent.BaseImpl.Person"
            viewProperty1.DisplayName = "FullName"
            viewProperty1.Expression = "[FirstName] + ' ' + [LastName]"
            viewProperty2.DisplayName = "Oid"
            viewProperty2.Expression = "[Oid]"
            Me.viewDataSource1.Properties.AddRange(New DevExpress.Persistent.Base.ReportsV2.ViewProperty() { viewProperty1, viewProperty2})
            Me.viewDataSource1.Sorting.AddRange(New DevExpress.Xpo.SortProperty() { New DevExpress.Xpo.SortProperty("[FullName]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
            Me.viewDataSource1.TopReturnedRecords = 0
            ' 
            ' xrSubreport1
            ' 
            Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 47.87499F)
            Me.xrSubreport1.Name = "xrSubreport1"
            Me.xrSubreport1.ReportSource = New SubReportExample.Module.PhoneNumberReportSubreportMappedToViewDataSource()
            Me.xrSubreport1.SizeF = New System.Drawing.SizeF(458.3333F, 41.08337F)
            ' 
            ' ContactReportWithSubreportMappedToViewDataSource
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
            Me.ComponentStorage.Add(Me.viewDataSource1)
            Me.DataSource = Me.viewDataSource1
            Me.DisplayName = "Contact report with subreport mapped to ViewDataSource"
            Me.Version = "14.1"
            DirectCast(Me.viewDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Protected viewDataSource1 As DevExpress.Persistent.Base.ReportsV2.ViewDataSource
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private WithEvents xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
