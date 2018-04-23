Imports System
Imports System.Text
Imports System.Linq
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports System.Collections.Generic
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.Model.Core
Imports DevExpress.ExpressApp.Model.DomainLogics
Imports DevExpress.ExpressApp.Model.NodeGenerators
Imports DevExpress.ExpressApp.ReportsV2
Imports DevExpress.Persistent.BaseImpl

Namespace SubReportExample.Module
    Public NotInheritable Partial Class SubReportExampleModule
        Inherits ModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Dim updater As ModuleUpdater = New DatabaseUpdate.Updater(objectSpace, versionFromDB)
            Dim predefinedReportsUpdater As New PredefinedReportsUpdater(Application, objectSpace, versionFromDB)
            predefinedReportsUpdater.AddPredefinedReport(Of ContactReportWithSubreportMappedToViewDataSource)("Contacts and phone numbers", GetType(Person), True)
            Return New ModuleUpdater() { updater, predefinedReportsUpdater }
        End Function
    End Class
End Namespace
