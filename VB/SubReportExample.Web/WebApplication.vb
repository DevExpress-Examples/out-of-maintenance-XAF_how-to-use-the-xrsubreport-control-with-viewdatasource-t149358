Imports System
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Xpo

Namespace SubReportExample.Web
    ' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWebWebApplicationMembersTopicAll
    Partial Public Class SubReportExampleAspNetApplication
        Inherits WebApplication

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
        Private module3 As SubReportExample.Module.SubReportExampleModule
        Private objectsModule As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private reportsModuleV2 As DevExpress.ExpressApp.ReportsV2.ReportsModuleV2
        Private reportsAspNetModuleV2 As DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
        End Sub
        Private Sub SubReportExampleAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
        End Sub
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
            Me.module3 = New SubReportExample.Module.SubReportExampleModule()
            Me.objectsModule = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.reportsModuleV2 = New DevExpress.ExpressApp.ReportsV2.ReportsModuleV2()
            Me.reportsAspNetModuleV2 = New DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            ' reportsModuleV2
            '
            Me.reportsModuleV2.EnableInplaceReports = True
            Me.reportsModuleV2.ReportDataType = GetType(DevExpress.Persistent.BaseImpl.ReportDataV2)
            Me.reportsModuleV2.ShowAdditionalNavigation = False
            ' 
            ' SubReportExampleAspNetApplication
            ' 
            Me.ApplicationName = "SubReportExample"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.objectsModule)
            Me.Modules.Add(Me.reportsModuleV2)
            Me.Modules.Add(Me.reportsAspNetModuleV2)
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
    End Class
End Namespace
