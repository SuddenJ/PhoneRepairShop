﻿#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00A430DAE0C858DC45FBBB830D4DBD64A71BD3E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



public partial class Pages_DR_DR201510 : System.Web.SessionState.IRequiresSessionState {
    
    
    #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
    protected global::PX.Web.UI.PXDataSource ds;
    
    #line default
    #line hidden
    
    
    #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
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
}
namespace ASP {
    
    #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
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
    
    #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
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
    
    #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
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
    
    #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
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
    
    #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
    using System.Web.UI.WebControls;
    
    #line default
    #line hidden
    
    #line 324 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
    using System.Web.UI.WebControls.WebParts;
    
    #line default
    #line hidden
    
    #line 332 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Text.RegularExpressions;
    
    #line default
    #line hidden
    
    #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
    using System.Web.UI.DataVisualization.Charting;
    
    #line default
    #line hidden
    
    #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
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
    public class pages_dr_dr201510_aspx : global::Pages_DR_DR201510, System.Web.IHttpHandler {
        
        private static System.Reflection.MethodInfo @__PageInspector_SetTraceDataMethod = global::ASP.pages_dr_dr201510_aspx.@__PageInspector_LoadHelper("SetTraceData");
        
        private static bool @__initialized;
        
        private static object @__fileDependencies;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public pages_dr_dr201510_aspx() {
            string[] dependencies;
            
            #line 912304 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx.cs"
            ((global::System.Web.UI.Page)(this)).AppRelativeVirtualPath = "~/Pages/DR/DR201510.aspx";
            
            #line default
            #line hidden
            if ((global::ASP.pages_dr_dr201510_aspx.@__initialized == false)) {
                dependencies = new string[6];
                dependencies[0] = "~/Pages/DR/DR201510.aspx";
                dependencies[1] = "~/Controls/PageTitle.ascx";
                dependencies[2] = "~/Controls/PageTitle.ascx.cs";
                dependencies[3] = "~/MasterPages/ListView.master";
                dependencies[4] = "~/MasterPages/ListView.master.cs";
                dependencies[5] = "~/Pages/DR/DR201510.aspx.cs";
                global::ASP.pages_dr_dr201510_aspx.@__fileDependencies = this.GetWrappedFileDependencies(dependencies);
                global::ASP.pages_dr_dr201510_aspx.@__initialized = true;
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
                        274,
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
            if ((global::ASP.pages_dr_dr201510_aspx.@__PageInspector_SetTraceDataMethod != null)) {
                global::ASP.pages_dr_dr201510_aspx.@__PageInspector_SetTraceDataMethod.Invoke(null, parameters);
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXDSCallbackCommand @__BuildControl__control4() {
            global::PX.Web.UI.PXDSCallbackCommand @__ctrl;
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl = new global::PX.Web.UI.PXDSCallbackCommand();
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Name = "ViewSchedule";
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.DependOnGrid = "grid";
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Visible = false;
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXDSCallbackCommand @__BuildControl__control5() {
            global::PX.Web.UI.PXDSCallbackCommand @__ctrl;
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl = new global::PX.Web.UI.PXDSCallbackCommand();
            
            #line default
            #line hidden
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Name = "ViewDoc";
            
            #line default
            #line hidden
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.DependOnGrid = "grid";
            
            #line default
            #line hidden
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Visible = false;
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control3(PX.Web.UI.PXDSCallbackCollection @__ctrl) {
            global::PX.Web.UI.PXDSCallbackCommand @__ctrl1;
            
            #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl1 = this.@__BuildControl__control4();
            
            #line default
            #line hidden
            
            #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Add(@__ctrl1);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXDSCallbackCommand @__ctrl2;
            
            #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl2 = this.@__BuildControl__control5();
            
            #line default
            #line hidden
            
            #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Add(@__ctrl2);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXDataSource @__BuildControlds() {
            global::PX.Web.UI.PXDataSource @__ctrl;
            
            #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl = new global::PX.Web.UI.PXDataSource();
            
            #line default
            #line hidden
            this.ds = @__ctrl;
            @__ctrl.TemplateControl = this;
            @__ctrl.ApplyStyleSheetSkin(this);
            
            #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.ID = "ds";
            
            #line default
            #line hidden
            
            #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Visible = true;
            
            #line default
            #line hidden
            
            #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(100D, global::System.Web.UI.WebControls.UnitType.Percentage);
            
            #line default
            #line hidden
            
            #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.TypeName = "PX.Objects.DR.DRSchedulePrimary";
            
            #line default
            #line hidden
            
            #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.PrimaryView = "Items";
            
            #line default
            #line hidden
            
            #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            this.@__BuildControl__control3(@__ctrl.CallbackCommands);
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        277,
                        366,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control6() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n");
            @__ctrl.TemplateControl = this;
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        643,
                        2,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlcont1(System.Web.UI.Control @__ctrl) {
            global::System.Web.UI.LiteralControl @__ctrl1;
            
            #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl1 = this.@__BuildControl__control2();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXDataSource @__ctrl2;
            
            #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl2 = this.@__BuildControlds();
            
            #line default
            #line hidden
            
            #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__parser.AddParsedSubObject(@__ctrl2);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl3;
            
            #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl3 = this.@__BuildControl__control6();
            
            #line default
            #line hidden
            
            #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__parser.AddParsedSubObject(@__ctrl3);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control7() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\t");
            @__ctrl.TemplateControl = this;
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        729,
                        3,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridColumn @__BuildControl__control11() {
            global::PX.Web.UI.PXGridColumn @__ctrl;
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridColumn();
            
            #line default
            #line hidden
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.DataField = "ScheduleNbr";
            
            #line default
            #line hidden
            
            #line 18 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.LinkCommand = "ViewSchedule";
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridColumn @__BuildControl__control12() {
            global::PX.Web.UI.PXGridColumn @__ctrl;
            
            #line 19 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridColumn();
            
            #line default
            #line hidden
            
            #line 19 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.DataField = "Status";
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridColumn @__BuildControl__control13() {
            global::PX.Web.UI.PXGridColumn @__ctrl;
            
            #line 20 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridColumn();
            
            #line default
            #line hidden
            
            #line 20 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.DataField = "BAccountType";
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridColumn @__BuildControl__control14() {
            global::PX.Web.UI.PXGridColumn @__ctrl;
            
            #line 21 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridColumn();
            
            #line default
            #line hidden
            
            #line 21 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.DataField = "BAccountID";
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridColumn @__BuildControl__control15() {
            global::PX.Web.UI.PXGridColumn @__ctrl;
            
            #line 22 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridColumn();
            
            #line default
            #line hidden
            
            #line 22 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.DataField = "DocumentTypeEx";
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridColumn @__BuildControl__control16() {
            global::PX.Web.UI.PXGridColumn @__ctrl;
            
            #line 23 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridColumn();
            
            #line default
            #line hidden
            
            #line 23 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.DataField = "RefNbr";
            
            #line default
            #line hidden
            
            #line 23 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.LinkCommand = "ViewDoc";
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control10(PX.Web.UI.PXGridColumnCollection @__ctrl) {
            global::PX.Web.UI.PXGridColumn @__ctrl1;
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl1 = this.@__BuildControl__control11();
            
            #line default
            #line hidden
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Add(@__ctrl1);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXGridColumn @__ctrl2;
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl2 = this.@__BuildControl__control12();
            
            #line default
            #line hidden
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Add(@__ctrl2);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXGridColumn @__ctrl3;
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl3 = this.@__BuildControl__control13();
            
            #line default
            #line hidden
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Add(@__ctrl3);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXGridColumn @__ctrl4;
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl4 = this.@__BuildControl__control14();
            
            #line default
            #line hidden
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Add(@__ctrl4);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXGridColumn @__ctrl5;
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl5 = this.@__BuildControl__control15();
            
            #line default
            #line hidden
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Add(@__ctrl5);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXGridColumn @__ctrl6;
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl6 = this.@__BuildControl__control16();
            
            #line default
            #line hidden
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Add(@__ctrl6);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGridLevel @__BuildControl__control9() {
            global::PX.Web.UI.PXGridLevel @__ctrl;
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl = new global::PX.Web.UI.PXGridLevel();
            
            #line default
            #line hidden
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.DataMember = "Items";
            
            #line default
            #line hidden
            
            #line 16 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            this.@__BuildControl__control10(@__ctrl.Columns);
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control8(PX.Web.UI.PXGridLevelCollection @__ctrl) {
            global::PX.Web.UI.PXGridLevel @__ctrl1;
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl1 = this.@__BuildControl__control9();
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Add(@__ctrl1);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control17(PX.Web.UI.PXAutoSizeInfo @__ctrl) {
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Container = global::PX.Web.UI.DockContainer.Window;
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Enabled = true;
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.MinHeight = 150;
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControl__control18(PX.Web.UI.PXGridLevelMode @__ctrl) {
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.AllowAddNew = new System.Nullable<bool>(false);
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.AllowUpdate = new System.Nullable<bool>(false);
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.AllowDelete = new System.Nullable<bool>(false);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::PX.Web.UI.PXGrid @__BuildControlgrid() {
            global::PX.Web.UI.PXGrid @__ctrl;
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl = new global::PX.Web.UI.PXGrid();
            
            #line default
            #line hidden
            this.grid = @__ctrl;
            @__ctrl.TemplateControl = this;
            @__ctrl.SkinID = "PrimaryInquire";
            @__ctrl.ApplyStyleSheetSkin(this);
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.ID = "grid";
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.DataSourceID = "ds";
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("Style", "z-index: 100");
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(100D, global::System.Web.UI.WebControls.UnitType.Percentage);
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Height = new System.Web.UI.WebControls.Unit(150D, global::System.Web.UI.WebControls.UnitType.Pixel);
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.AdjustPageSize = global::PX.Web.UI.GridPageSizeMode.Auto;
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.AllowPaging = true;
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Caption = "Time Cards";
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.FastFilterFields = new string[] {
                    "BAccountID",
                    "RefNbr"};
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.SyncPosition = true;
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            this.@__BuildControl__control8(@__ctrl.Levels);
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            this.@__BuildControl__control17(@__ctrl.AutoSize);
            
            #line default
            #line hidden
            
            #line 13 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            this.@__BuildControl__control18(@__ctrl.Mode);
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        732,
                        862,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control19() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n");
            @__ctrl.TemplateControl = this;
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        1594,
                        2,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlcont3(System.Web.UI.Control @__ctrl) {
            global::System.Web.UI.LiteralControl @__ctrl1;
            
            #line 12 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl1 = this.@__BuildControl__control7();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 12 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            global::PX.Web.UI.PXGrid @__ctrl2;
            
            #line 12 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl2 = this.@__BuildControlgrid();
            
            #line default
            #line hidden
            
            #line 12 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__parser.AddParsedSubObject(@__ctrl2);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl3;
            
            #line 12 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl3 = this.@__BuildControl__control19();
            
            #line default
            #line hidden
            
            #line 12 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__parser.AddParsedSubObject(@__ctrl3);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlTree(pages_dr_dr201510_aspx @__ctrl) {
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.MasterPageFile = "~/MasterPages/ListView.master";
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__ctrl.Title = "Deferred Schedules";
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            this.InitializeCulture();
            
            #line default
            #line hidden
            
            #line 3 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            this.AddContentTemplate("phDS", new System.Web.UI.CompiledTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControlcont1)));
            
            #line default
            #line hidden
            
            #line 12 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            this.AddContentTemplate("phL", new System.Web.UI.CompiledTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControlcont3)));
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\r\n"));
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n"));
            
            #line default
            #line hidden
        }
        
        
        #line 912304 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Pages\DR\DR201510.aspx.cs"
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void FrameworkInitialize() {
            this.StyleSheetTheme = "Default";
            base.FrameworkInitialize();
            this.@__BuildControlTree(this);
            this.AddWrappedFileDependencies(global::ASP.pages_dr_dr201510_aspx.@__fileDependencies);
            this.ValidateRequestMode = System.Web.UI.ValidateRequestMode.Disabled;
        }
        
        #line default
        #line hidden
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override int GetTypeHashCode() {
            return -778816045;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override void ProcessRequest(System.Web.HttpContext context) {
            base.ProcessRequest(context);
        }
    }
}
