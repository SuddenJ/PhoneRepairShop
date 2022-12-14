#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\EP\EP404000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E4706BDF0341E329B821D3FB31C483D2DA7CB890"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\EP\EP404000.aspx.cs"
using System;
using System.Drawing;
using System.Web.UI.WebControls;
using PX.Data;
using PX.Common.Collection;
using PX.Data.EP;
using PX.DataSync;
using PX.Objects.CR;
using PX.Objects.EP;
using PX.TM;

public partial class Pages_EP404000 : PX.Web.UI.PXPage
{	
	protected void Page_Init(object sender, EventArgs e)
	{		
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		EventTaskCategoryMaint categoryMaint = PXGraph.CreateInstance<EventTaskCategoryMaint>();

		RegisterStyle("CssOverdue", null, "Red", false);
		RegisterStyle("CssOverdueBold", null, "Red", true);
		RegisterStyle("BaseBold", null, null, true);

		coloredCategories = new Set<int>(true);
		foreach (EPEventCategory rec in categoryMaint.ColoredCategories.Select())
		{
			PXIntState color = categoryMaint.ColoredCategories.Cache.GetStateExt(rec, "Color") as PXIntState;
			if (color != null)
			{
				coloredCategories.Add(rec.CategoryID ?? 0);
			    int colorIndex = color.AllowedValues != null ? Array.IndexOf(color.AllowedValues, (int)color.Value) : -1;                                				
				string backColor = (colorIndex > 0)  
                    ? color.AllowedLabels[colorIndex]
                    : color.Value.ToString();

				RegisterStyle("Css" + rec.CategoryID, backColor, null, false);
				RegisterStyle("CssBold" + rec.CategoryID, backColor, null, true);
				RegisterStyle("CssOver" + rec.CategoryID, backColor, "Red", false);
				RegisterStyle("CssBoldOver" + rec.CategoryID, backColor, "Red", true);
			}
		}
	}

	private void RegisterStyle(string name, string backColor, string foreColor, bool bold)
	{
		Style style = new Style();
		if (!string.IsNullOrEmpty(backColor)) style.BackColor = Color.FromName(backColor);
		if (!string.IsNullOrEmpty(foreColor)) style.ForeColor = Color.FromName(foreColor);
		if (bold) style.Font.Bold = true;
		this.Page.Header.StyleSheet.CreateStyleRule(style, this, "." + name);
	}

	private Set<int> coloredCategories;
		
	protected void grid_RowDataBound(object sender, PX.Web.UI.PXGridRowEventArgs e)
	{
		PXResult record = e.Row.DataItem as PXResult;
		if (record == null) return;

		EPView viewInfo = (EPView)record[typeof(EPView)];
		bool isBold = viewInfo != null && (viewInfo.Status == null || viewInfo.Status == EPViewStatusAttribute.NOTVIEWED);

		CRActivity item = (CRActivity)record[typeof(CRActivity)];

		if (isBold) e.Row.Style.CssClass = "BaseBold";
		if(item.CategoryID != null && coloredCategories.Contains(item.CategoryID??0))
		{
			if (item.IsOverdue == true)
				e.Row.Style.CssClass = (isBold ? "CssBoldOver" : "CssOver") + item.CategoryID;				
			else
				e.Row.Style.CssClass = (isBold ? "CssBold" : "Css") + item.CategoryID;
		}
		else
		{
			if (item.IsOverdue == true)
				e.Row.Style.CssClass = (isBold ? "CssOverdueBold" : "CssOverdue");
		}
	}
}

#line default
#line hidden
