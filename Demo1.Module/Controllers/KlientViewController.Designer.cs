namespace JKXAF.Module.Controllers
{
    partial class KlientViewController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dodajSpotkanieAction = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.generateRecordsAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // dodajSpotkanieAction
            // 
            this.dodajSpotkanieAction.AcceptButtonCaption = null;
            this.dodajSpotkanieAction.CancelButtonCaption = null;
            this.dodajSpotkanieAction.Caption = "Dodaj spotknaie";
            this.dodajSpotkanieAction.ConfirmationMessage = null;
            this.dodajSpotkanieAction.Id = "5a4e0c34-4884-4dce-ba6e-e976cc5dec47";
            this.dodajSpotkanieAction.ImageName = "BO_Scheduler";
            this.dodajSpotkanieAction.TargetObjectType = typeof(JKXAF.Module.BusinessObjects.Customer);
            this.dodajSpotkanieAction.ToolTip = null;
            this.dodajSpotkanieAction.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.dodajSpotkanieAction_CustomizePopupWindowParams);
            // 
            // generateRecordsAction
            // 
            this.generateRecordsAction.Caption = "Utworz rekordy testowe";
            this.generateRecordsAction.ConfirmationMessage = null;
            this.generateRecordsAction.Id = "31b67558-7211-4d44-b610-2daddae77a27";
            this.generateRecordsAction.ToolTip = null;
            this.generateRecordsAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.generateRecordsAction_Execute);
            // 
            // KlientViewController
            // 
            this.Actions.Add(this.dodajSpotkanieAction);
            this.Actions.Add(this.generateRecordsAction);
            this.TargetObjectType = typeof(JKXAF.Module.BusinessObjects.Customer);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction dodajSpotkanieAction;
        private DevExpress.ExpressApp.Actions.SimpleAction generateRecordsAction;
    }
}
