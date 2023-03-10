#pragma checksum "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8d98056d3acec14605619ee9d4e6352e80b3214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserInfo), @"mvc.1.0.view", @"/Views/Admin/UserInfo.cshtml")]
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
#line 1 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\UserInfo.cshtml"
using Shopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8d98056d3acec14605619ee9d4e6352e80b3214", @"/Views/Admin/UserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4487f0c86abf7612e0a877d6bdae29213eff1b91", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_UserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\UserInfo.cshtml"
  
    ViewData["Title"] = "UserInfo";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-body"">
    <div class=""container-fluid"">
        <div class=""row page-titles mx-0"">
            <div class=""col-sm-6 p-md-0"">
                <div class=""welcome-text"">
                    <h4>Hi, welcome back!</h4>
                    <p class=""mb-0"">Your business dashboard template</p>
                </div>
            </div>
            <div class=""col-sm-6 p-md-0 justify-content-sm-end mt-2 mt-sm-0 d-flex"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""javascript:void(0)"">Table</a></li>
                    <li class=""breadcrumb-item active""><a href=""javascript:void(0)"">Bootstrap</a></li>
                </ol>
            </div>
        </div>
        <!-- row -->

        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">Product List</h4>
                    </div>
              ");
            WriteLiteral("      <div class=\"card-body\">\r\n                        <div class=\"table-responsive\">\r\n                            <table class=\"table table-responsive-sm\">\r\n");
#nullable restore
#line 34 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\UserInfo.cshtml"
                                 foreach (var u in ViewBag.userlist as List<User>)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <thead>\r\n                                        <tr>\r\n                                            <th>");
#nullable restore
#line 38 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\UserInfo.cshtml"
                                           Write(u.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 39 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\UserInfo.cshtml"
                                           Write(u.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 40 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\UserInfo.cshtml"
                                           Write(u.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 41 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\UserInfo.cshtml"
                                           Write(u.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 42 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\UserInfo.cshtml"
                                           Write(u.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 43 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\UserInfo.cshtml"
                                           Write(u.PhoneNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>\r\n\r\n                                                ");
#nullable restore
#line 46 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\UserInfo.cshtml"
                                           Write(Html.ActionLink("Profile",
                                                               "ViewProfile",
                                                               new { Id = @u.UserId },
                                                               new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n                                            </th>\r\n                                        </tr>\r\n                                    </thead>\r\n");
#nullable restore
#line 54 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\UserInfo.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
