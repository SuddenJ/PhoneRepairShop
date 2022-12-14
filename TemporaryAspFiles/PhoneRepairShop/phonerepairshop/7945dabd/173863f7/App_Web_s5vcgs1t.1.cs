#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\IN\IN409020.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "356DD85D4CFAE9B67C363A36B6E46706D6EAE7B1"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\IN\IN409020.aspx.cs"
using System;
using System.Drawing;
using System.Web.UI.WebControls;
using PX.Common;
using PX.Data;
using PX.Objects.IN;
using PX.Web.UI;

public partial class Page_IN409020 : PX.Web.UI.PXPage
{
	private static class PickCss
	{
		public const string Complete = "CssComplete";
		public const string Partial = "CssPartial";
		public const string Overpick = "CssOverpick";
		public const string Splitting = "CssSplitting";
	}

	protected void Page_Init(object sender, EventArgs e) { }

	protected void Page_Load(object sender, EventArgs e)
	{
		RegisterStyle(PickCss.Complete, null, Color.Green, true);
		RegisterStyle(PickCss.Partial, null, Color.Black, true);
		RegisterStyle(PickCss.Overpick, null, Color.OrangeRed, true);
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

	protected void LogGrid_RowDataBound(object sender, PX.Web.UI.PXGridRowEventArgs e)
	{
		var log = (PX.Objects.IN.WMSScanLog)PXResult.UnwrapMain(e.Row.DataItem);
		if (log == null) return;

		if (log.MessageType == PX.Objects.IN.WMSMessageTypes.Error)
		{
			e.Row.Style.CssClass = PickCss.Overpick;
		}
		else if (log.MessageType == PX.Objects.IN.WMSMessageTypes.Warning)
		{
			e.Row.Style.CssClass = PickCss.Partial;
		}
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
