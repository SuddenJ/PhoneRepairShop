#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\MasterPages\TabView.master.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E6FFA5EA58CB73EE28D337DC657CEE1B1E0977D4"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\MasterPages\TabView.master.cs"
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using PX.Web.Controls;
using PX.Web.UI;
using PX.Common;
public partial class Master_TabView : PX.Web.UI.BaseMasterPage, IPXMasterPage
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!PX.Translation.ResourceCollectingManager.IsStringCollecting)
		{
			Response.TryAddHeader("cache-control", "no-store, private");
		}
	}

	// We'll need this code in case we use ASP.NET standard localization
	protected void Page_Init(object sender, EventArgs e)
	{
		//if (PXDataSource.RedirectHelper.IsPopupPage(Page)) statusBar.Visible = false;
	}

	#region Public properties
	/// <summary>
	/// Gets or sets the screen title string.
	/// </summary>
	public string ScreenTitle
	{
		get { return this.usrCaption.ScreenTitle; }
		set { this.usrCaption.ScreenTitle = value; }
	}

	/// <summary>
	/// Gets or sets the screen ID text.
	/// </summary>
	public string ScreenID
	{
		get { return this.usrCaption.ScreenID; }
		set { this.usrCaption.ScreenID = value; }
	}

	/// <summary>
	/// Gets or sets the screen image url.
	/// </summary>
	public string ScreenImage
	{
		get { return this.usrCaption.ScreenImage; }
		set { this.usrCaption.ScreenImage = value; }
	}

	/// <summary>
	/// Gets or sets the customization availability.
	/// </summary>
	public bool CustomizationAvailable
	{
		get { return this.usrCaption.CustomizationAvailable; }
		set { this.usrCaption.CustomizationAvailable = value; }
	}

	/// <summary>
	/// Gets or sets the help menu availability.
	/// </summary>
	public bool HelpAvailable
	{
		get { return this.usrCaption.HelpAvailable; }
		set { this.usrCaption.HelpAvailable = value; }
	}

	/// <summary>
	/// Gets or sets the favorite maintenance availability
	/// </summary>
	public bool FavoriteAvailable
	{
		get { return this.usrCaption.FavoriteAvailable; }
		set { this.usrCaption.FavoriteAvailable = value; }
	}

	/// <summary>
	/// Gets or sets branch visibility in title.
	/// </summary>
	public bool BranchAvailable
	{
		get
		{
			var tlbPath = (PXToolBar)this.usrCaption.FindControl("tlbPath");
			if (tlbPath != null && tlbPath.Items != null && tlbPath.Items.Count > 0)
			{
				return tlbPath.Items[1].Visible;
			}
			return false;
		}
		set
		{
			var tlbPath = (PXToolBar)this.usrCaption.FindControl("tlbPath");
			if (tlbPath != null && tlbPath.Items != null && tlbPath.Items.Count > 0)
			{
				tlbPath.Items[1].Visible = value;
			}
		}
	}

	/// <summary>
	/// Gets or sets the web services availability.
	/// </summary>
	public bool WebServicesAvailable
	{
		get { return this.usrCaption.WebServicesAvailable; }
		set { this.usrCaption.WebServicesAvailable = value; }
	}

	/// <summary>
	/// Gets or sets the audit history availability.
	/// </summary>
	public bool AuditHistoryAvailable
	{
		get { return this.usrCaption.AuditHistoryAvailable; }
		set { this.usrCaption.AuditHistoryAvailable = value; }
	}

	public void AddTitleModule(ITitleModule module)
	{
		module.Initialize(this.usrCaption);
	}

	#endregion
}


#line default
#line hidden
