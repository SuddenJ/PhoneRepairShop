﻿#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM205040.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62DDA4EC1391D5642468BE3C6C0CC4192CDB3628"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM205040.aspx.cs"
using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Data.Wiki.Parser;
using PX.Web.Controls;

public partial class Page_SM205040 : PX.Web.UI.PXPage
{
	protected void Page_Init(object sender, EventArgs e)
	{
		this.Master.PopupHeight = 560;
		this.Master.PopupWidth = 870;
	}

	protected void wikiEdit_BeforePreview(object src, PX.Web.UI.PXRichTextEdit.BeforePreviewArgs args)
	{
		var screenId = (DefaultDataSource.DataGraph as PX.SM.AUNotificationMaint).SiteMap.Current.ScreenID;
		var info = PX.Api.ScreenUtils.GetScreenInfo(screenId);
		if (info != null)
		{
			args.GraphName = info.GraphName;
			args.ViewName = info.PrimaryView;
		}
	}
}


#line default
#line hidden
