﻿#pragma checksum "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65459A2037EFB1685A9E4BDF9429B22DD974E132"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



public partial class Frames_LoginRemind : System.Web.SessionState.IRequiresSessionState {
    
    
    #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
    protected global::System.Web.UI.WebControls.TextBox edEmail;
    
    #line default
    #line hidden
    
    
    #line 8 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
    protected global::System.Web.UI.WebControls.DropDownList cmbCompany;
    
    #line default
    #line hidden
    
    
    #line 9 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
    protected global::System.Web.UI.WebControls.Button btnSubmit;
    
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
    
    public new ASP.masterpages_login_master Master {
        get {
            return ((ASP.masterpages_login_master)(base.Master));
        }
    }
}
namespace ASP {
    
    #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
    using System.Web.UI.WebControls.Expressions;
    
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
    
    #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
    using System.Web.UI.DataVisualization.Charting;
    
    #line default
    #line hidden
    
    #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
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
    
    #line 4 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
    using ASP;
    
    #line default
    #line hidden
    
    #line 336 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.SessionState;
    
    #line default
    #line hidden
    
    #line 327 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections.Specialized;
    
    #line default
    #line hidden
    
    #line 333 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web;
    
    #line default
    #line hidden
    
    #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
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
    
    #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
    using System.Web.UI.WebControls;
    
    #line default
    #line hidden
    
    #line 337 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Security;
    
    #line default
    #line hidden
    
    #line 324 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System;
    
    #line default
    #line hidden
    
    #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
    using System.Web.UI.WebControls.WebParts;
    
    #line default
    #line hidden
    
    #line 332 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Text.RegularExpressions;
    
    #line default
    #line hidden
    
    #line 329 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Configuration;
    
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
    public class frames_loginremind_aspx : global::Frames_LoginRemind, System.Web.IHttpHandler {
        
        private static System.Reflection.MethodInfo @__PageInspector_SetTraceDataMethod = global::ASP.frames_loginremind_aspx.@__PageInspector_LoadHelper("SetTraceData");
        
        private static bool @__initialized;
        
        private static object @__fileDependencies;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public frames_loginremind_aspx() {
            string[] dependencies;
            
            #line 912304 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx.cs"
            ((global::System.Web.UI.Page)(this)).AppRelativeVirtualPath = "~/Frames/LoginRemind.aspx";
            
            #line default
            #line hidden
            if ((global::ASP.frames_loginremind_aspx.@__initialized == false)) {
                dependencies = new string[4];
                dependencies[0] = "~/Frames/LoginRemind.aspx";
                dependencies[1] = "~/MasterPages/Login.master";
                dependencies[2] = "~/MasterPages/Login.master.cs";
                dependencies[3] = "~/Frames/LoginRemind.aspx.cs";
                global::ASP.frames_loginremind_aspx.@__fileDependencies = this.GetWrappedFileDependencies(dependencies);
                global::ASP.frames_loginremind_aspx.@__initialized = true;
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
                        379,
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
            if ((global::ASP.frames_loginremind_aspx.@__PageInspector_SetTraceDataMethod != null)) {
                global::ASP.frames_loginremind_aspx.@__PageInspector_SetTraceDataMethod.Invoke(null, parameters);
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.WebControls.TextBox @__BuildControledEmail() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            
            #line default
            #line hidden
            this.edEmail = @__ctrl;
            @__ctrl.TemplateControl = this;
            @__ctrl.ApplyStyleSheetSkin(this);
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl.ID = "edEmail";
            
            #line default
            #line hidden
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl.CssClass = "login_user border-box";
            
            #line default
            #line hidden
            
            #line 7 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("placeholder", "Enter your email address");
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        382,
                        115,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control3() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\t");
            @__ctrl.TemplateControl = this;
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        497,
                        3,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.WebControls.DropDownList @__BuildControlcmbCompany() {
            global::System.Web.UI.WebControls.DropDownList @__ctrl;
            
            #line 8 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl = new global::System.Web.UI.WebControls.DropDownList();
            
            #line default
            #line hidden
            this.cmbCompany = @__ctrl;
            @__ctrl.TemplateControl = this;
            @__ctrl.ApplyStyleSheetSkin(this);
            
            #line 8 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl.ID = "cmbCompany";
            
            #line default
            #line hidden
            
            #line 8 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl.CssClass = "login_company border-box";
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        500,
                        87,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control4() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\t");
            @__ctrl.TemplateControl = this;
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        587,
                        3,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.WebControls.Button @__BuildControlbtnSubmit() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            
            #line 9 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            
            #line default
            #line hidden
            this.btnSubmit = @__ctrl;
            @__ctrl.TemplateControl = this;
            @__ctrl.ApplyStyleSheetSkin(this);
            
            #line 9 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl.ID = "btnSubmit";
            
            #line default
            #line hidden
            
            #line 9 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl.Text = "Submit";
            
            #line default
            #line hidden
            
            #line 9 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl.CssClass = "login_button";
            
            #line default
            #line hidden
            
            #line 9 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl.Click += new System.EventHandler(this.btnSubmit_Click);
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        590,
                        108,
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
                        698,
                        2,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlContent3(System.Web.UI.Control @__ctrl) {
            global::System.Web.UI.LiteralControl @__ctrl1;
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl1 = this.@__BuildControl__control2();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            global::System.Web.UI.WebControls.TextBox @__ctrl2;
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl2 = this.@__BuildControledEmail();
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__parser.AddParsedSubObject(@__ctrl2);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl3;
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl3 = this.@__BuildControl__control3();
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__parser.AddParsedSubObject(@__ctrl3);
            
            #line default
            #line hidden
            global::System.Web.UI.WebControls.DropDownList @__ctrl4;
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl4 = this.@__BuildControlcmbCompany();
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__parser.AddParsedSubObject(@__ctrl4);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl5;
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl5 = this.@__BuildControl__control4();
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__parser.AddParsedSubObject(@__ctrl5);
            
            #line default
            #line hidden
            global::System.Web.UI.WebControls.Button @__ctrl6;
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl6 = this.@__BuildControlbtnSubmit();
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__parser.AddParsedSubObject(@__ctrl6);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl7;
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl7 = this.@__BuildControl__control5();
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__parser.AddParsedSubObject(@__ctrl7);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control6() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\t<script type=\'text/javascript\'>\r\n\t\twindow.onload = function ()\r\n\t\t{\r\n\t\t\tvar ed" +
                    "itor = document.form1[\'edEmail\'];\r\n\t\t\tif (editor && !editor.readOnly) editor.foc" +
                    "us();\r\n\t\t}\r\n\t</script>\r\n");
            @__ctrl.TemplateControl = this;
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        791,
                        185,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlContent6(System.Web.UI.Control @__ctrl) {
            global::System.Web.UI.LiteralControl @__ctrl1;
            
            #line 12 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl1 = this.@__BuildControl__control6();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 12 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlTree(frames_loginremind_aspx @__ctrl) {
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl.Title = "";
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl.MasterPageFile = "~/MasterPages/Login.master";
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl.ClientIDMode = global::System.Web.UI.ClientIDMode.Static;
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__ctrl.EnableEventValidation = false;
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            this.InitializeCulture();
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            this.AddContentTemplate("phUser", new System.Web.UI.CompiledTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControlContent3)));
            
            #line default
            #line hidden
            
            #line 12 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            this.AddContentTemplate("phStart", new System.Web.UI.CompiledTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControlContent6)));
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\r\n"));
            
            #line default
            #line hidden
            
            #line 1 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n"));
            
            #line default
            #line hidden
        }
        
        
        #line 912304 "C:\Users\Josh\Documents\AcumaticaLearning\PhoneRepairShop\Frames\LoginRemind.aspx.cs"
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void FrameworkInitialize() {
            this.StyleSheetTheme = "Default";
            base.FrameworkInitialize();
            this.@__BuildControlTree(this);
            this.AddWrappedFileDependencies(global::ASP.frames_loginremind_aspx.@__fileDependencies);
            this.ValidateRequestMode = System.Web.UI.ValidateRequestMode.Disabled;
        }
        
        #line default
        #line hidden
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override int GetTypeHashCode() {
            return 1720509037;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override void ProcessRequest(System.Web.HttpContext context) {
            base.ProcessRequest(context);
        }
    }
}