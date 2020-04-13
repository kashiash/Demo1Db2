using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKXAF.Module.Win.Controllers
{
 public   class GridSettingsController : ViewController<ListView>
    {
        public GridSettingsController()
        {
            //TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            //TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            ViewControlsCreated += new System.EventHandler(this.WinAlternatingRowsController_ViewControlsCreated);

        }

        private void WinAlternatingRowsController_ViewControlsCreated(object sender, EventArgs e)
        {
            if (View.Editor is GridListEditor listEditor)
            {
                GridView gridView = listEditor.GridView;
                gridView.OptionsView.EnableAppearanceOddRow = true;
                gridView.OptionsView.ColumnAutoWidth = false;
                gridView.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}
