Imports System
Imports System.Linq
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Persistent.BaseImpl

Namespace SubReportExample.Module.DatabaseUpdate
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            Dim contactJohn As Person = ObjectSpace.FindObject(Of Person)(CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Nilsen'"))
            If contactJohn Is Nothing Then
                contactJohn = ObjectSpace.CreateObject(Of Person)()
                contactJohn.FirstName = "John"
                contactJohn.LastName = "Nilsen"
                contactJohn.Email = "john_nilsen@example.com"
                contactJohn.Birthday = New Date(1981, 10, 3)
            End If
            Dim johnPhoneNumber1 As PhoneNumber = ObjectSpace.FindObject(Of PhoneNumber)(CriteriaOperator.Parse("Number == '555-111-222'"))
            If johnPhoneNumber1 Is Nothing Then
                johnPhoneNumber1 = ObjectSpace.CreateObject(Of PhoneNumber)()
                johnPhoneNumber1.Number = "555-111-222"
                johnPhoneNumber1.PhoneType = "Fixed"
                contactJohn.PhoneNumbers.Add(johnPhoneNumber1)
            End If
            Dim johnPhoneNumber2 As PhoneNumber = ObjectSpace.FindObject(Of PhoneNumber)(CriteriaOperator.Parse("Number == '555-333-222'"))
            If johnPhoneNumber2 Is Nothing Then
                johnPhoneNumber2 = ObjectSpace.CreateObject(Of PhoneNumber)()
                johnPhoneNumber2.Number = "555-333-222"
                johnPhoneNumber2.PhoneType = "Celular"
                contactJohn.PhoneNumbers.Add(johnPhoneNumber2)
            End If

            Dim contactMary As Person = ObjectSpace.FindObject(Of Person)(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"))
            If contactMary Is Nothing Then
                contactMary = ObjectSpace.CreateObject(Of Person)()
                contactMary.FirstName = "Mary"
                contactMary.LastName = "Tellitson"
                contactMary.Email = "mary_tellitson@example.com"
                contactMary.Birthday = New Date(1980, 11, 27)
            End If
            Dim maryPhoneNumber1 As PhoneNumber = ObjectSpace.FindObject(Of PhoneNumber)(CriteriaOperator.Parse("Number == '555-999-999'"))
            If maryPhoneNumber1 Is Nothing Then
                maryPhoneNumber1 = ObjectSpace.CreateObject(Of PhoneNumber)()
                maryPhoneNumber1.Number = "555-999-999"
                maryPhoneNumber1.PhoneType = "Fixed"
                contactMary.PhoneNumbers.Add(maryPhoneNumber1)
            End If
            Dim maryPhoneNumber2 As PhoneNumber = ObjectSpace.FindObject(Of PhoneNumber)(CriteriaOperator.Parse("Number == '555-999-777'"))
            If maryPhoneNumber2 Is Nothing Then
                maryPhoneNumber2 = ObjectSpace.CreateObject(Of PhoneNumber)()
                maryPhoneNumber2.Number = "555-999-777"
                maryPhoneNumber2.PhoneType = "Celular"
                contactMary.PhoneNumbers.Add(maryPhoneNumber2)
            End If
        End Sub
    End Class
End Namespace
