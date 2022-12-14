#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\EP\EP102000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7EE7B03066E9D1CB40E1899C053756B8F9F1076A"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\EP\EP102000.aspx.cs"
using PX.Common;
using PX.Data;
using PX.Objects.CS;
using PX.Objects.PR;
using PX.Web.UI;
using System;

public partial class Page_EP102000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!PXAccess.FeatureInstalled<FeaturesSet.payrollModule>())
			return;

		PREarningTypeMaint graph = PXGraph.CreateInstance<PREarningTypeMaint>();
		string url = PXDataSource.getMainForm(graph.GetType());
		if (url == null)
			return;

		graph.Unload();
		PXContext.Session.RedirectGraphType[PXUrl.ToAbsoluteUrl(url)] = graph.GetType();
		Response.Redirect(this.ResolveUrl(url));
	}
}


#line default
#line hidden
