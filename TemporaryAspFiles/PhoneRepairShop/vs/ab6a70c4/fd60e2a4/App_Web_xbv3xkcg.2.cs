﻿#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D043C569F7C8278B01488CD6EB8FADE9B618A981"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



public partial class Page_SM511500 : System.Web.SessionState.IRequiresSessionState {
    
    
    #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
    protected global::PX.Web.UI.PXDataSource ds;
    
    #line default
    #line hidden
    
    
    #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
    protected global::PX.Web.UI.PXGrid grid;
    
    #line default
    #line hidden
    
    protected System.Web.Profile.DefaultProfile Profile {
        get {
            return ((System.Web.Profile.DefaultProfile)(this.Context.Profile));
        }
    }
    
    protected ASP.global_asax ApplicationInstance {
        get {
            return ((ASP.global_asax)(this.Context.ApplicationInstance));
        }
    }
    
    public new ASP.masterpages_listview_master Master {
        get {
            return ((ASP.masterpages_listview_master)(base.Master));
        }
    }
}
namespace ASP {
    
    #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
    using System.Web.UI.WebControls.Expressions;
    
    #line default
    #line hidden
    
    #line 337 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Security;
    
    #line default
    #line hidden
    
    #line 325 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 331 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
    using System.Web.UI;
    
    #line default
    #line hidden
    
    #line 326 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 330 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 5 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
    using ASP;
    
    #line default
    #line hidden
    
    #line 336 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.SessionState;
    
    #line default
    #line hidden
    
    #line 329 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Configuration;
    
    #line default
    #line hidden
    
    #line 333 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web;
    
    #line default
    #line hidden
    
    #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
    using System.Web.DynamicData;
    
    #line default
    #line hidden
    
    #line 334 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Caching;
    
    #line default
    #line hidden
    
    #line 338 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Profile;
    
    #line default
    #line hidden
    
    #line 328 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.ComponentModel.DataAnnotations;
    
    #line default
    #line hidden
    
    #line 327 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections.Specialized;
    
    #line default
    #line hidden
    
    #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
    using System.Web.UI.WebControls;
    
    #line default
    #line hidden
    
    #line 324 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System;
    
    #line default
    #line hidden
    
    #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
    using System.Web.UI.WebControls.WebParts;
    
    #line default
    #line hidden
    
    #line 332 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Text.RegularExpressions;
    
    #line default
    #line hidden
    
    #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
    using System.Web.UI.DataVisualization.Charting;
    
    #line default
    #line hidden
    
    #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
    using PX.Web.UI;
    
    #line default
    #line hidden
    
    #line 343 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Xml.Linq;
    
    #line default
    #line hidden
    
    #line 342 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.HtmlControls;
    
    #line default
    #line hidden
    
    
    [System.Runtime.CompilerServices.CompilerGlobalScopeAttribute()]
    public class pages_sm_sm511500_aspx : global::Page_SM511500, System.Web.IHttpHandler {
        
        private static System.Reflection.MethodInfo @__PageInspector_SetTraceDataMethod = global::ASP.pages_sm_sm511500_aspx.@__PageInspector_LoadHelper("SetTraceData");
        
        private static bool @__initialized;
        
        private static object @__fileDependencies;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public pages_sm_sm511500_aspx() {
            string[] dependencies;
            
            #line 912304 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx.cs"
            ((global::System.Web.UI.Page)(this)).AppRelativeVirtualPath = "~/Pages/SM/SM511500.aspx";
            
            #line default
            #line hidden
            if ((global::ASP.pages_sm_sm511500_aspx.@__initialized == false)) {
                dependencies = new string[6];
                dependencies[0] = "~/Pages/SM/SM511500.aspx";
                dependencies[1] = "~/Controls/PageTitle.ascx";
                dependencies[2] = "~/Controls/PageTitle.ascx.cs";
                dependencies[3] = "~/MasterPages/ListView.master";
                dependencies[4] = "~/MasterPages/ListView.master.cs";
                dependencies[5] = "~/Pages/SM/SM511500.aspx.cs";
                global::ASP.pages_sm_sm511500_aspx.@__fileDependencies = this.GetWrappedFileDependencies(dependencies);
                global::ASP.pages_sm_sm511500_aspx.@__initialized = true;
            }
            this.Server.ScriptTimeout = 30000000;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control2() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\t");
            @__ctrl.TemplateControl = this;
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        332,
                        3,
                        true});
            return @__ctrl;
        }
        
        private static System.Reflection.MethodInfo @__PageInspector_LoadHelper(string helperName) {
            System.Type helperClass = System.Type.GetType("Microsoft.WebTools.BrowserLink.Runtime.WebForms.TraceHelpers, Microsoft.WebTools." +
                    "BrowserLink.Tracing, Version=17.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                    "1d50a3a", false, false);
            if ((helperClass != null)) {
                return helperClass.GetMethod(helperName);
            }
            return null;
        }
        
        private void @__PageInspector_SetTraceData(object[] parameters) {
            if ((global::ASP.pages_sm_sm511500_aspx.@__PageInspector_SetTraceDataMethod != null)) {
                global::ASP.pages_sm_sm511500_aspx.@__PageInspector_SetTraceDataMethod.Invoke(null, parameters);
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXDSCallbackCommand @__BuildControl__control4() {
            global::PX.Web.UI.PXDSCallbackCommand @__ctrl;
            
            #line 10 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl = new global::PX.Web.UI.PXDSCallbackCommand();
            
            #line default
            #line hidden
            
            #line 10 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Name = "viewTranslationSet";
            
            #line default
            #line hidden
            
            #line 10 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Visible = false;
            
            #line default
            #line hidden
            
            #line 10 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.CommitChanges = true;
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control3(PX.Web.UI.PXDSCallbackCollection @__ctrl) {
            global::PX.Web.UI.PXDSCallbackCommand @__ctrl1;
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl1 = this.@__BuildControl__control4();
            
            #line default
            #line hidden
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Add(@__ctrl1);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXDataSource @__BuildControlds() {
            global::PX.Web.UI.PXDataSource @__ctrl;
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl = new global::PX.Web.UI.PXDataSource();
            
            #line default
            #line hidden
            this.ds = @__ctrl;
            @__ctrl.TemplateControl = this;
            @__ctrl.ApplyStyleSheetSkin(this);
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.ID = "ds";
            
            #line default
            #line hidden
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(100D, global::System.Web.UI.WebControls.UnitType.Percentage);
            
            #line default
            #line hidden
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.PrimaryView = "TranslationSets";
            
            #line default
            #line hidden
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.TypeName = "PX.SM.TranslationSetProcessing";
            
            #line default
            #line hidden
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Visible = true;
            
            #line default
            #line hidden
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            this.@__BuildControl__control3(@__ctrl.CallbackCommands);
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        335,
                        306,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control5() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n");
            @__ctrl.TemplateControl = this;
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        641,
                        2,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlcont1(System.Web.UI.Control @__ctrl) {
            global::System.Web.UI.LiteralControl @__ctrl1;
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl1 = this.@__BuildControl__control2();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXDataSource @__ctrl2;
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl2 = this.@__BuildControlds();
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__parser.AddParsedSubObject(@__ctrl2);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl3;
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl3 = this.@__BuildControl__control5();
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__parser.AddParsedSubObject(@__ctrl3);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control6() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\t");
            @__ctrl.TemplateControl = this;
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        725,
                        3,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridColumn @__BuildControl__control10() {
            global::PX.Web.UI.PXGridColumn @__ctrl;
            
            #line 20 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridColumn();
            
            #line default
            #line hidden
            
            #line 20 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.DataField = "Selected";
            
            #line default
            #line hidden
            
            #line 20 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.TextAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
            
            #line default
            #line hidden
            
            #line 20 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Type = global::PX.Web.UI.GridColumnType.CheckBox;
            
            #line default
            #line hidden
            
            #line 20 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(40D, global::System.Web.UI.WebControls.UnitType.Pixel);
            
            #line default
            #line hidden
            
            #line 20 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.AllowCheckAll = true;
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridColumn @__BuildControl__control11() {
            global::PX.Web.UI.PXGridColumn @__ctrl;
            
            #line 21 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridColumn();
            
            #line default
            #line hidden
            
            #line 21 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.DataField = "Description";
            
            #line default
            #line hidden
            
            #line 21 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(250D, global::System.Web.UI.WebControls.UnitType.Pixel);
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridColumn @__BuildControl__control12() {
            global::PX.Web.UI.PXGridColumn @__ctrl;
            
            #line 22 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridColumn();
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.DataField = "IsCollected";
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.TextAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Type = global::PX.Web.UI.GridColumnType.CheckBox;
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(100D, global::System.Web.UI.WebControls.UnitType.Pixel);
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridColumn @__BuildControl__control13() {
            global::PX.Web.UI.PXGridColumn @__ctrl;
            
            #line 23 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridColumn();
            
            #line default
            #line hidden
            
            #line 23 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.DataField = "SystemVersion";
            
            #line default
            #line hidden
            
            #line 23 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(100D, global::System.Web.UI.WebControls.UnitType.Pixel);
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridColumn @__BuildControl__control14() {
            global::PX.Web.UI.PXGridColumn @__ctrl;
            
            #line 24 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridColumn();
            
            #line default
            #line hidden
            
            #line 24 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.DataField = "SystemTime";
            
            #line default
            #line hidden
            
            #line 24 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.DisplayFormat = "g";
            
            #line default
            #line hidden
            
            #line 24 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(150D, global::System.Web.UI.WebControls.UnitType.Pixel);
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control9(PX.Web.UI.PXGridColumnCollection @__ctrl) {
            global::PX.Web.UI.PXGridColumn @__ctrl1;
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl1 = this.@__BuildControl__control10();
            
            #line default
            #line hidden
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Add(@__ctrl1);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXGridColumn @__ctrl2;
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl2 = this.@__BuildControl__control11();
            
            #line default
            #line hidden
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Add(@__ctrl2);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXGridColumn @__ctrl3;
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl3 = this.@__BuildControl__control12();
            
            #line default
            #line hidden
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Add(@__ctrl3);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXGridColumn @__ctrl4;
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl4 = this.@__BuildControl__control13();
            
            #line default
            #line hidden
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Add(@__ctrl4);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXGridColumn @__ctrl5;
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl5 = this.@__BuildControl__control14();
            
            #line default
            #line hidden
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Add(@__ctrl5);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridLevel @__BuildControl__control8() {
            global::PX.Web.UI.PXGridLevel @__ctrl;
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridLevel();
            
            #line default
            #line hidden
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.DataMember = "TranslationSets";
            
            #line default
            #line hidden
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            this.@__BuildControl__control9(@__ctrl.Columns);
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control7(PX.Web.UI.PXGridLevelCollection @__ctrl) {
            global::PX.Web.UI.PXGridLevel @__ctrl1;
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl1 = this.@__BuildControl__control8();
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Add(@__ctrl1);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control15(PX.Web.UI.PXAutoSizeInfo @__ctrl) {
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Container = global::PX.Web.UI.DockContainer.Window;
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Enabled = true;
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.MinHeight = 200;
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control16(PX.Web.UI.PXGridLevelMode @__ctrl) {
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.AllowAddNew = new System.Nullable<bool>(false);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control20(PX.Web.UI.PXCallbackSettings @__ctrl) {
            
            #line 32 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Command = "viewTranslationSet";
            
            #line default
            #line hidden
            
            #line 32 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Target = "ds";
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXToolBarButton @__BuildControl__control19() {
            global::PX.Web.UI.PXToolBarButton @__ctrl;
            
            #line 32 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl = new global::PX.Web.UI.PXToolBarButton();
            
            #line default
            #line hidden
            
            #line 32 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            this.@__BuildControl__control20(@__ctrl.AutoCallBack);
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control18(PX.Web.UI.PXToolBarItemCollection @__ctrl) {
            global::PX.Web.UI.PXToolBarButton @__ctrl1;
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl1 = this.@__BuildControl__control19();
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Add(@__ctrl1);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control17(PX.Web.UI.PXGridActionBar @__ctrl) {
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.PagerVisible = global::PX.Web.UI.ActionVisible.False;
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            this.@__BuildControl__control18(@__ctrl.CustomItems);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGrid @__BuildControlgrid() {
            global::PX.Web.UI.PXGrid @__ctrl;
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl = new global::PX.Web.UI.PXGrid();
            
            #line default
            #line hidden
            this.grid = @__ctrl;
            @__ctrl.TemplateControl = this;
            @__ctrl.SkinID = "Inquire";
            @__ctrl.ApplyStyleSheetSkin(this);
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.ID = "grid";
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Height = new System.Web.UI.WebControls.Unit(400D, global::System.Web.UI.WebControls.UnitType.Pixel);
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(100D, global::System.Web.UI.WebControls.UnitType.Percentage);
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Caption = "Translation Sets";
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.SyncPosition = true;
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.DataSourceID = "ds";
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.BatchUpdate = true;
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.AllowPaging = true;
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            this.@__BuildControl__control7(@__ctrl.Levels);
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            this.@__BuildControl__control15(@__ctrl.AutoSize);
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            this.@__BuildControl__control16(@__ctrl.Mode);
            
            #line default
            #line hidden
            
            #line 15 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            this.@__BuildControl__control17(@__ctrl.ActionBar);
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        728,
                        1168,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control21() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n");
            @__ctrl.TemplateControl = this;
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        1896,
                        2,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlcont2(System.Web.UI.Control @__ctrl) {
            global::System.Web.UI.LiteralControl @__ctrl1;
            
            #line 14 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl1 = this.@__BuildControl__control6();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 14 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXGrid @__ctrl2;
            
            #line 14 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl2 = this.@__BuildControlgrid();
            
            #line default
            #line hidden
            
            #line 14 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__parser.AddParsedSubObject(@__ctrl2);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl3;
            
            #line 14 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl3 = this.@__BuildControl__control21();
            
            #line default
            #line hidden
            
            #line 14 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__parser.AddParsedSubObject(@__ctrl3);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlTree(pages_sm_sm511500_aspx @__ctrl) {
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.MasterPageFile = "~/MasterPages/ListView.master";
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__ctrl.Title = "Untitled Page";
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            this.InitializeCulture();
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            this.AddContentTemplate("phDS", new System.Web.UI.CompiledTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControlcont1)));
            
            #line default
            #line hidden
            
            #line 14 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            this.AddContentTemplate("phL", new System.Web.UI.CompiledTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControlcont2)));
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n"));
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n"));
            
            #line default
            #line hidden
        }
        
        
        #line 912304 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\SM\SM511500.aspx.cs"
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void FrameworkInitialize() {
            this.StyleSheetTheme = "Default";
            base.FrameworkInitialize();
            this.@__BuildControlTree(this);
            this.AddWrappedFileDependencies(global::ASP.pages_sm_sm511500_aspx.@__fileDependencies);
            this.ValidateRequestMode = System.Web.UI.ValidateRequestMode.Disabled;
        }
        
        #line default
        #line hidden
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override int GetTypeHashCode() {
            return -435004502;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override void ProcessRequest(System.Web.HttpContext context) {
            base.ProcessRequest(context);
        }
    }
}
