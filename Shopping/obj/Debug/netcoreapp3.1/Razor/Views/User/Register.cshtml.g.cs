#pragma checksum "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7ca14c4c804f564927be7324c5f7bf50d24b701"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Register), @"mvc.1.0.view", @"/Views/User/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7ca14c4c804f564927be7324c5f7bf50d24b701", @"/Views/User/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4487f0c86abf7612e0a877d6bdae29213eff1b91", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Breadcrumb Section Begin -->
<section class=""breadcrumb-section set-bg"" data-setbg=""/web/img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb__text"">
                    <h2>Register Form</h2>
                    <div class=""breadcrumb__option"">
                        <a href=""./index.html"">Home</a>
                        <span>Register</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->

");
#nullable restore
#line 25 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
 using (Html.BeginForm("Register", "User", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
Write(Html.ValidationMessage("Register", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row centered-form"">
            <div class=""col-xs-12 col-sm-8 col-md-8 col-sm-offset-2 col-md-offset-4"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">

                    </div>
                    <div class=""panel-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7ca14c4c804f564927be7324c5f7bf50d24b7015492", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 39 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                           Write(Html.LabelFor(m => m.Name, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 41 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                               Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div style=\"color:red;\">\r\n                                    ");
#nullable restore
#line 44 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 49 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                           Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 51 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                               Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div style=\"color:red;\">\r\n                                    ");
#nullable restore
#line 54 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 59 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                           Write(Html.LabelFor(m => m.CofirmPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 61 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                               Write(Html.PasswordFor(m => m.CofirmPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div style=\"color:red;\">\r\n                                    ");
#nullable restore
#line 64 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                               Write(Html.ValidationMessageFor(m => m.CofirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 69 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                           Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 71 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                               Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div style=\"color:red;\">\r\n                                    ");
#nullable restore
#line 74 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 79 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                           Write(Html.LabelFor(m => m.Adress, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 81 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                               Write(Html.TextBoxFor(m => m.Adress, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div style=\"color:red;\">\r\n                                    ");
#nullable restore
#line 84 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Adress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 89 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                           Write(Html.LabelFor(m => m.Phone, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <div class=\"col-md-10\">\r\n                                    ");
#nullable restore
#line 91 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                               Write(Html.TextBoxFor(m => m.Phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div style=\"color:red;\">\r\n                                    ");
#nullable restore
#line 94 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
                               Write(Html.ValidationMessageFor(m => m.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n                            <input type=\"submit\" value=\"Register\" class=\"btn btn-info btn-block\">\r\n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 107 "D:\DoAnchuyenganh\Shopping\Shopping\Views\User\Register.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
