#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\MasterPages\Workspace.master.cs" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7AAF2B51D5796368FF4C9BB1829BDAE809A22ED8"

#line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\MasterPages\Workspace.master.cs"
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PX.Web.UI;
using PX.Web.Controls;
using PX.Common;

public partial class MasterPages_Workspace : PX.Web.UI.BaseMasterPage, IPXMasterPage
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
	/// If true - prevent redirect to features configuration.
	/// </summary>
	public bool WillShowWelcomePage
	{
		get { return this.usrCaption.WillShowWelcomePage; }
		set { this.usrCaption.WillShowWelcomePage = value; }
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
			return this.usrCaption.BranchAvailable;
		}
		set
		{
			this.usrCaption.BranchAvailable = value;
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

	public bool DataViewBarVisible
	{
		get { return this.usrCaption.DataViewBar.Visible; }
		set { this.usrCaption.DataViewBar.Visible = value; }
	}

	public void AddTitleModule(ITitleModule module)
	{
		module.Initialize(this.usrCaption);
	}

	#endregion
}


#line default
#line hidden
