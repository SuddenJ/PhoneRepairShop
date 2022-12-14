#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM208600.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AFE05B2D7340BD77CD58C6EC5B57A67B0DDEB8EB"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM208600.aspx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Dashboards;
using PX.Data.Maintenance.GI;
using PX.Web.UI;

public partial class Page_SM208600 : PXPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

	protected void frmHeader_DataBound(object sender, EventArgs e)
	{
		DashboardMaint graph = (DashboardMaint) this.ds.DataGraph;
		if (graph.IsSiteMapAltered)
			this.ds.CallbackResultArg = "RefreshSitemap";
	}

	protected void grd_EditorsCreated_RelativeDates(object sender, EventArgs e)
	{
		PXGrid grid = sender as PXGrid;
		if (grid != null)
		{
			PXDateTimeEdit de = grid.PrimaryLevel.GetStandardEditor(GridStandardEditor.Date) as PXDateTimeEdit;
			if (de != null)
			{
				de.ShowRelativeDates = true;
			}
		}
	}
}

#line default
#line hidden
