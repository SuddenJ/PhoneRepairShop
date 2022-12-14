#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\GL\GL405000.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36F479173ECF81CAE7E346871373C34A2D0958BF"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\GL\GL405000.aspx.cs"
using System;
using System.Drawing;
using System.Web.UI.WebControls;
using PX.Data;
using PX.Objects.GL.Reclassification.UI;

public partial class Page_GL405000 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
        RegisterStyle("CssCurrentLine", null, null, true);
    }

    private void RegisterStyle(string name, Color? backColor, Color? foreColor, bool bold)
    {
        Style style = new Style();
        if (backColor != null) style.BackColor = backColor.Value;
        if (foreColor != null) style.ForeColor = foreColor.Value;
        style.Font.Bold = bold;
        Page.Header.StyleSheet.CreateStyleRule(style, this, "." + name);
    }

    protected void grid_OnRowDataBound(object sender, PX.Web.UI.PXGridRowEventArgs e)
    {
        GLTranReclHist tran;

        PXResult record = e.Row.DataItem as PXResult;
        if (record != null)
        {
            tran = (GLTranReclHist)record[typeof(GLTranReclHist)];
        }
        else
        {
            tran = e.Row.DataItem as GLTranReclHist;
        }

        if (tran == null)
            return;

        if (tran.IsCurrent == true)
        {
            e.Row.Style.CssClass = "CssCurrentLine";
        }
    }
}


#line default
#line hidden
