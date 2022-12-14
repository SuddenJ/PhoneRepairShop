#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\PM\PM301000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "485EE851A858E6119FD0A95DF8508B882B6D17E8"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\PM\PM301000.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Drawing;
using PX.Data;
using PX.Objects.EP;
using PX.Objects.PM;

public partial class Page_PM301000 : PX.Web.UI.PXPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
		Style style = new Style();
		style.Font.Bold = true;
		this.Page.Header.StyleSheet.CreateStyleRule(style, this, "." + "BoldText");

		this.Master.PopupWidth = 1000;
		this.Master.PopupHeight = 700;
    }

	protected void ProjectBalanceGrid_RowDataBound(object sender, PX.Web.UI.PXGridRowEventArgs e)
	{
		ProjectEntry.PMProjectBalanceRecord item = e.Row.DataItem as ProjectEntry.PMProjectBalanceRecord;
		if (item != null && item.RecordID < 0)
		{
			e.Row.Style.CssClass = "BoldText";
		}
	}

	protected void BudgetGrid_RowDataBound(object sender, PX.Web.UI.PXGridRowEventArgs e)
	{
		PMBudget item = e.Row.DataItem as PMBudget;
		if (item != null && item.SortOrder == 1)
		{
			e.Row.Style.CssClass = "BoldText";
		}
	}
}


#line default
#line hidden
