﻿#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Wiki\NotificationEdit.aspx.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76F873A53779D3C605615BF0E2799CA701F892F2"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Wiki\NotificationEdit.aspx.cs"
using System;
using PX.SM;
using PX.Data;
using PX.Web.UI;
using PX.Data.Wiki.Parser;
using System.Web.UI;

public partial class Page_NotificationEdit : EditPage<WikiNotificationTemplateMaintenance>
{
	protected void Page_PreInit(object sender, EventArgs e)
	{
		this.Master.FavoriteAvailable = false;
		this.Master.ScreenID = "00.000.00";
		this.Master.ScreenTitle = PXMessages.LocalizeFormatNoPrefix(PX.SM.Messages.EditNotification);
		this.Master.CustomizationAvailable = false;
	}
	protected override void Page_Init(object sender, EventArgs e)
	{
		base.Page_Init(sender, e);
		((PXLabel)this.tab1.FindControl("lblTags")).Text = PX.Data.PXMessages.LocalizeNoPrefix(PX.SM.Messages.VersionTags);
	}

	protected override PXDataSource DataSource
	{
		get { return this.ds1; }
	}

	protected override PXTab TabView
	{
		get { return this.tab1; }
	}

	protected override string ScreenTitle
	{
		get { return this.Master.ScreenTitle; }
		set { this.Master.ScreenTitle = value; }
	}
}


#line default
#line hidden