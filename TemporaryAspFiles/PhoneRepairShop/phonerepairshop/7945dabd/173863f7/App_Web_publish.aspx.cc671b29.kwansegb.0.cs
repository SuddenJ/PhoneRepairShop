//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
    
    #line 329 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Configuration;
    
    #line default
    #line hidden
    
    #line 332 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Text.RegularExpressions;
    
    #line default
    #line hidden
    
    #line 333 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web;
    
    #line default
    #line hidden
    
    #line 337 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Security;
    
    #line default
    #line hidden
    
    #line 341 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.WebControls.WebParts;
    
    #line default
    #line hidden
    
    #line 326 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 335 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.DynamicData;
    
    #line default
    #line hidden
    
    #line 327 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections.Specialized;
    
    #line default
    #line hidden
    
    #line 343 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Xml.Linq;
    
    #line default
    #line hidden
    
    #line 325 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 330 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 339 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI;
    
    #line default
    #line hidden
    
    #line 338 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Profile;
    
    #line default
    #line hidden
    
    #line 331 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 342 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.HtmlControls;
    
    #line default
    #line hidden
    
    #line 334 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Caching;
    
    #line default
    #line hidden
    
    #line 324 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System;
    
    #line default
    #line hidden
    
    #line 340 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.WebControls;
    
    #line default
    #line hidden
    
    #line 336 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.SessionState;
    
    #line default
    #line hidden
    
    #line 328 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.ComponentModel.DataAnnotations;
    
    #line default
    #line hidden
    
    
    [System.Runtime.CompilerServices.CompilerGlobalScopeAttribute()]
    public class controls_publish_aspx : global::PX.Web.Customization.Controls.Publish, System.Web.SessionState.IRequiresSessionState, System.Web.IHttpHandler {
        
        private static System.Reflection.MethodInfo @__PageInspector_SetTraceDataMethod = global::ASP.controls_publish_aspx.@__PageInspector_LoadHelper("SetTraceData");
        
        private static bool @__initialized;
        
        private static object @__fileDependencies;
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public controls_publish_aspx() {
            string[] dependencies;
            ((global::PX.Web.Customization.Controls.Publish)(this)).AppRelativeVirtualPath = "~/Controls/Publish.aspx";
            if ((global::ASP.controls_publish_aspx.@__initialized == false)) {
                dependencies = new string[1];
                dependencies[0] = "~/Controls/Publish.aspx";
                global::ASP.controls_publish_aspx.@__fileDependencies = this.GetWrappedFileDependencies(dependencies);
                global::ASP.controls_publish_aspx.@__initialized = true;
            }
            this.Server.ScriptTimeout = 30000000;
        }
        
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
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control2() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3" +
                    ".org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n\r\n<html xmlns=\"http://www.w3.org/1" +
                    "999/xhtml\" >\r\n");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        126,
                        175,
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
            if ((global::ASP.controls_publish_aspx.@__PageInspector_SetTraceDataMethod != null)) {
                global::ASP.controls_publish_aspx.@__PageInspector_SetTraceDataMethod.Invoke(null, parameters);
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control5() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("Untitled Page");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        335,
                        13,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlTitle @__BuildControl__control4() {
            global::System.Web.UI.HtmlControls.HtmlTitle @__ctrl;
            
            #line 7 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTitle();
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl1;
            
            #line 7 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__ctrl1 = this.@__BuildControl__control5();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 7 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        328,
                        28,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlHead @__BuildControl__control3() {
            global::System.Web.UI.HtmlControls.HtmlHead @__ctrl;
            
            #line 6 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlHead("head");
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlTitle @__ctrl1;
            
            #line 6 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__ctrl1 = this.@__BuildControl__control4();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 6 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        301,
                        64,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control6() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n<body>\r\n    ");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        365,
                        14,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control7() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n    <div>\r\n    \r\n    </div>\r\n    ");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        411,
                        35,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlForm @__BuildControlform1() {
            global::System.Web.UI.HtmlControls.HtmlForm @__ctrl;
            
            #line 10 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlForm();
            
            #line default
            #line hidden
            this.form1 = @__ctrl;
            
            #line 10 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__ctrl.ID = "form1";
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl1;
            
            #line 10 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__ctrl1 = this.@__BuildControl__control7();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 10 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        379,
                        74,
                        false});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.LiteralControl @__BuildControl__control8() {
            global::System.Web.UI.LiteralControl @__ctrl;
            @__ctrl = new global::System.Web.UI.LiteralControl("\r\n</body>\r\n</html>\r\n");
            this.@__PageInspector_SetTraceData(new object[] {
                        @__ctrl,
                        null,
                        453,
                        20,
                        true});
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlTree(controls_publish_aspx @__ctrl) {
            
            #line 1 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            this.InitializeCulture();
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl1;
            
            #line 1 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__ctrl1 = this.@__BuildControl__control2();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 1 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlHead @__ctrl2;
            
            #line 1 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__ctrl2 = this.@__BuildControl__control3();
            
            #line default
            #line hidden
            
            #line 1 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__parser.AddParsedSubObject(@__ctrl2);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl3;
            
            #line 1 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__ctrl3 = this.@__BuildControl__control6();
            
            #line default
            #line hidden
            
            #line 1 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__parser.AddParsedSubObject(@__ctrl3);
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlForm @__ctrl4;
            
            #line 1 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__ctrl4 = this.@__BuildControlform1();
            
            #line default
            #line hidden
            
            #line 1 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__parser.AddParsedSubObject(@__ctrl4);
            
            #line default
            #line hidden
            global::System.Web.UI.LiteralControl @__ctrl5;
            
            #line 1 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__ctrl5 = this.@__BuildControl__control8();
            
            #line default
            #line hidden
            
            #line 1 "http://server/PhoneRepairShop/Controls/Publish.aspx"
            @__parser.AddParsedSubObject(@__ctrl5);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void FrameworkInitialize() {
            this.StyleSheetTheme = "Default";
            base.FrameworkInitialize();
            this.@__BuildControlTree(this);
            this.AddWrappedFileDependencies(global::ASP.controls_publish_aspx.@__fileDependencies);
            this.Request.ValidateInput();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override int GetTypeHashCode() {
            return 783430533;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public new virtual void ProcessRequest(System.Web.HttpContext context) {
            base.ProcessRequest(context);
        }
    }
}
