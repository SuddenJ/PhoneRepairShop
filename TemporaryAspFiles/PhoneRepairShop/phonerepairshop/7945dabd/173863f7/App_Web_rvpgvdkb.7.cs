#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM301010.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31057AF52D7FF7036A7FAC0F76432B964E1FAFD7"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM301010.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.OAuthClient;
using PX.Web.UI;

public partial class Page_SM301010 : PX.Web.UI.PXPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
        if (!this.IsCallback)
        {
            var renderer = JSManager.GetRenderer(this);
            JSManager.RegisterModule(renderer, JS.BaseKey, JS.NetType);
        }
    }

    protected void form_DataBound(object sender, EventArgs e)
    {
        var graph = (ResourceMaint)ds.DataGraph;
        if (graph.IsSiteMapAltered)
            this.ds.CallbackResultArg = "RefreshSitemap";
    }
}


#line default
#line hidden
