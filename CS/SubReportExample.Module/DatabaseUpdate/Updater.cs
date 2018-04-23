using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;

namespace SubReportExample.Module.DatabaseUpdate {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Person contactJohn = ObjectSpace.FindObject<Person>(CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Nilsen'"));
            if (contactJohn == null) {
                contactJohn = ObjectSpace.CreateObject<Person>();
                contactJohn.FirstName = "John";
                contactJohn.LastName = "Nilsen";
                contactJohn.Email = "john_nilsen@example.com";
                contactJohn.Birthday = new DateTime(1981, 10, 3);
            }
            PhoneNumber johnPhoneNumber1 = ObjectSpace.FindObject<PhoneNumber>(CriteriaOperator.Parse("Number == '555-111-222'"));
            if (johnPhoneNumber1 == null) {
                johnPhoneNumber1 = ObjectSpace.CreateObject<PhoneNumber>();
                johnPhoneNumber1.Number = "555-111-222";
                johnPhoneNumber1.PhoneType = "Fixed";
                contactJohn.PhoneNumbers.Add(johnPhoneNumber1);
            }
            PhoneNumber johnPhoneNumber2 = ObjectSpace.FindObject<PhoneNumber>(CriteriaOperator.Parse("Number == '555-333-222'"));
            if (johnPhoneNumber2 == null) {
                johnPhoneNumber2 = ObjectSpace.CreateObject<PhoneNumber>();
                johnPhoneNumber2.Number = "555-333-222";
                johnPhoneNumber2.PhoneType = "Celular";
                contactJohn.PhoneNumbers.Add(johnPhoneNumber2);
            }

            Person contactMary = ObjectSpace.FindObject<Person>(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"));
            if (contactMary == null) {
                contactMary = ObjectSpace.CreateObject<Person>();
                contactMary.FirstName = "Mary";
                contactMary.LastName = "Tellitson";
                contactMary.Email = "mary_tellitson@example.com";
                contactMary.Birthday = new DateTime(1980, 11, 27);
            }
            PhoneNumber maryPhoneNumber1 = ObjectSpace.FindObject<PhoneNumber>(CriteriaOperator.Parse("Number == '555-999-999'"));
            if (maryPhoneNumber1 == null) {
                maryPhoneNumber1 = ObjectSpace.CreateObject<PhoneNumber>();
                maryPhoneNumber1.Number = "555-999-999";
                maryPhoneNumber1.PhoneType = "Fixed";
                contactMary.PhoneNumbers.Add(maryPhoneNumber1);
            }
            PhoneNumber maryPhoneNumber2 = ObjectSpace.FindObject<PhoneNumber>(CriteriaOperator.Parse("Number == '555-999-777'"));
            if (maryPhoneNumber2 == null) {
                maryPhoneNumber2 = ObjectSpace.CreateObject<PhoneNumber>();
                maryPhoneNumber2.Number = "555-999-777";
                maryPhoneNumber2.PhoneType = "Celular";
                contactMary.PhoneNumbers.Add(maryPhoneNumber2);
            }
        }
    }
}
