using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bogus;
using JKXAF.Module.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace JKXAF.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class KlientViewController : ViewController
    {
        public KlientViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void dodajSpotkanieAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            var klient = (Customer)View.CurrentObject;
            IObjectSpace os = View.ObjectSpace.CreateNestedObjectSpace();
            Meeting spotkanie = os.CreateObject<Meeting>();
            spotkanie.Klient = os.GetObject(klient);
            e.View = Application.CreateDetailView(os, spotkanie);
        }

        private void generateRecordsAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            IObjectSpace os = Application.CreateObjectSpace();



            var recFaker = new Faker<Customer>()
                .CustomInstantiator(f => os.CreateObject<Customer>())
                .RuleFor(o => o.Telefon, f => f.Person.Phone)
                .RuleFor(o => o.Skrot, f => f.Company.CatchPhrase())
                .RuleFor(o => o.Nazwa, f => f.Company.CompanyName())
                .RuleFor(o => o.Email, (f, u) => f.Internet.Email())
                .RuleFor(o => o.Miejscowosc, f => f.Address.City())
                .RuleFor(o => o.KodPocztowy, f => f.Address.ZipCode())
            .RuleFor(o => o.Ulica, f => f.Address.StreetName());


            var users = recFaker.Generate(1000);
            os.CommitChanges();

            View.ObjectSpace.Refresh();

        }
    }
}
