#pragma checksum "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cdd534c4eaeca8163f42061f0adb408a053283f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\DoAnchuyenganh\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnchuyenganh\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cdd534c4eaeca8163f42061f0adb408a053283f", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4487f0c86abf7612e0a877d6bdae29213eff1b91", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Breadcrumb Section Begin -->
<section class=""breadcrumb-section set-bg"" data-setbg=""/web/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb__text"">
                    <h2>Login Form</h2>
                    <div class=""breadcrumb__option"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 533, "\"", 567, 1);
#nullable restore
#line 15 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
WriteAttributeValue("", 540, Url.Action("Index","Home"), 540, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a>\r\n                        <span>Log</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Breadcrumb Section End -->\r\n<!-- Sign Up -->\r\n\r\n");
#nullable restore
#line 26 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
 using (Html.BeginForm("Login", "User", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
Write(Html.ValidationMessage("Login", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div id=\"login-row\" class=\"row justify-content-center align-items-center\">\r\n            <div id=\"login-column\" class=\"col-md-6\">\r\n                <div id=\"login-box\" class=\"col-md-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdd534c4eaeca8163f42061f0adb408a053283f6694", async() => {
                WriteLiteral("\r\n                        <h3 class=\"text-center text-info\">Login</h3>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 37 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
                       Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 39 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
                           Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 40 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <h6 style=\"color:red;\">");
#nullable restore
#line 41 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
                                                  Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 45 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
                       Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"col-md-10\">\r\n                                ");
#nullable restore
#line 47 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
                           Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 48 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <h6 style=\"color:red;\">");
#nullable restore
#line 49 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
                                                  Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h6>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""remember-me"" class=""text-info""><span>Remember me</span> <span><input id=""remember-me"" name=""remember-me"" type=""checkbox""></span></label><br>
                            <input type=""submit"" name=""submit"" class=""btn btn-info btn-md"" value=""submit"">
                        </div>
                        <div id=""register-link"" class=""text-right"">
                            <a href=""#"" class=""text-info"">Register here</a>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 64 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Login.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591