#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\IN\IN409010.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "800A0FA584AAEF811DE07928EF7821F97F64729C"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\IN\IN409010.aspx.cs"
using System;
using System.Drawing;
using System.Web.UI.WebControls;
using PX.Common;
using PX.Data;
using PX.Objects.IN;
using PX.Web.UI;

public partial class Page_IN409010 : PX.Web.UI.PXPage
{
	private static class PickCss
	{
		public const string Splitting = "CssSplitting";
	}

	protected void Page_Init(object sender, EventArgs e) { }

	protected void Page_Load(object sender, EventArgs e)
	{
		RegisterStyle(PickCss.Splitting, null, null, true);
	}

	private void RegisterStyle(string name, Color? backColor, Color? foreColor, bool bold)
	{
		Style style = new Style();
		if (backColor.HasValue) style.BackColor = backColor.Value;
		if (foreColor.HasValue) style.ForeColor = foreColor.Value;
		if (bold) style.Font.Bold = true;
		this.Page.Header.StyleSheet.CreateStyleRule(style, this, "." + name);
	}

	protected void grid_OnRowDataBound(object sender, PX.Web.UI.PXGridRowEventArgs e)
	{
		var graph = (StoragePlaceEnq)((PXGrid)sender).DataGraph;
		StoragePlaceStatus tran;

		PXResult record = e.Row.DataItem as PXResult;
		if (record != null)
		{
			tran = (StoragePlaceStatus)record[typeof(StoragePlaceStatus)];
		}
		else
		{
			tran = e.Row.DataItem as StoragePlaceStatus;
		}

		if (tran == null)
			return;

		//if (graph.Filter.Current.With(_ => _.ExpandByLotSerialNbr) == true && tran.IsOverall == true)
		//{
		//	e.Row.Style.CssClass = PickCss.Splitting;
		//}
		//else
		//{
		//	e.Row.Style.Reset();
		//}
	}
}

#line default
#line hidden
