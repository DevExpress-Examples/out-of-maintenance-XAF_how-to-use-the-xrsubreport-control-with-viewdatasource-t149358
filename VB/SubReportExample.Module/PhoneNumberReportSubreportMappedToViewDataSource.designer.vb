Namespace SubReportExample.Module
    Partial Public Class PhoneNumberReportSubreportMappedToViewDataSource
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
            Dim viewProperty3 As New DevExpress.Persistent.Base.ReportsV2.ViewProperty()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.viewDataSource1 = New DevExpress.Persistent.Base.ReportsV2.ViewDataSource()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.MasterOid = New DevExpress.XtraReports.Parameters.Parameter()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            DirectCast(Me.viewDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel2})
            Me.Detail.HeightF = 39.58333F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Number")})
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(142.2916F, 6.583341F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(100F, 23F)
            Me.xrLabel2.Text = "xrLabel2"
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
            ' viewDataSource1
            ' 
            Me.viewDataSource1.Name = "viewDataSource1"
            Me.viewDataSource1.ObjectTypeName = "DevExpress.Persistent.BaseImpl.PhoneNumber"
            viewProperty1.DisplayName = "Number"
            viewProperty1.Expression = "[Number]"
            viewProperty2.DisplayName = "PartyOid"
            viewProperty2.Expression = "[Party.Oid]"
            viewProperty3.DisplayName = "PhoneType"
            viewProperty3.Expression = "[PhoneType]"
            Me.viewDataSource1.Properties.AddRange(New DevExpress.Persistent.Base.ReportsV2.ViewProperty() { viewProperty1, viewProperty2, viewProperty3})
            Me.viewDataSource1.Sorting.AddRange(New DevExpress.Xpo.SortProperty() { New DevExpress.Xpo.SortProperty("[PhoneType]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
            Me.viewDataSource1.TopReturnedRecords = 0
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.PageHeader.HeightF = 36.45833F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.Black
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(161.4583F, 27.16667F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.Text = "Phone Numbers:"
            ' 
            ' MasterOid
            ' 
            Me.MasterOid.Description = "Parameter1"
            Me.MasterOid.Name = "MasterOid"
            Me.MasterOid.Visible = False
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(31.87498F, 6.583341F)
            Me.xrLabel3.Multiline = True
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(100F, 23F)
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.Text = "[PhoneType]"
            ' 
            ' PhoneNumberReportSubreportMappedToViewDataSource
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
            Me.ComponentStorage.Add(Me.viewDataSource1)
            Me.DataSource = Me.viewDataSource1
            Me.FilterString = "[PartyOid] = ?MasterOid"
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.MasterOid})
            Me.Version = "14.1"
            DirectCast(Me.viewDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Protected viewDataSource1 As DevExpress.Persistent.Base.ReportsV2.ViewDataSource
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private MasterOid As DevExpress.XtraReports.Parameters.Parameter
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
