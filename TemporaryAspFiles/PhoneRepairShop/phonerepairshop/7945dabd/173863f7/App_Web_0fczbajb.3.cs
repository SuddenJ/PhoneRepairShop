#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\CR\CO409070.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9DB1E7C0B46ED43018B150BCA035079FDDB7AC87"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\CR\CO409070.aspx.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Objects.EP;
using PX.Data;

public partial class Pages_CO409070 : PX.Web.UI.PXPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Style style = new Style();
        style.Font.Bold = true;
        this.Page.Header.StyleSheet.CreateStyleRule(style, this, ".SubjBold");
    }
    protected void grid_RowDataBound(object sender, PX.Web.UI.PXGridRowEventArgs e)
    {
        PXResult record = e.Row.DataItem as PXResult;
        if (record == null) return;

        EPView viewInfo = (EPView)record[typeof(EPView)];
        bool isBold = viewInfo != null && (viewInfo.Status == null || viewInfo.Status == EPViewStatusAttribute.NOTVIEWED);
        if (isBold) e.Row.Style.CssClass = "SubjBold";
    }
}

#line default
#line hidden
