#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\WZ\WZ201000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B0CAECB46BF389F9DFD159EAAF5ACE0FBAAFBEF3"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\WZ\WZ201000.aspx.cs"
using System;
using PX.Web.UI;
using PX.Objects.WZ;

public partial class Page_WZ201000 : PXPage
{
    protected void Page_Init(object sender, EventArgs e)
    {

	}
	protected void grid_OnDataBound(object sender, EventArgs e)
	{
		WZScenarioEntry graph = this.ds.DataGraph as WZScenarioEntry;
		if (graph.IsSiteMapAltered)
			this.ds.CallbackResultArg = "RefreshSitemap";
	}
}

#line default
#line hidden
