#pragma checksum "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\CreateCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f97901693da2bb2bc4154745120cef713efde89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CreateCategory), @"mvc.1.0.view", @"/Views/Admin/CreateCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f97901693da2bb2bc4154745120cef713efde89", @"/Views/Admin/CreateCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4487f0c86abf7612e0a877d6bdae29213eff1b91", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_CreateCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Catelogy>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-valide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\CreateCategory.cshtml"
  
    ViewData["Title"] = "CreateCategory";
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
                    <p class=""mb-1"">Validation</p>
                </div>
            </div>
            <div class=""col-sm-6 p-md-0 justify-content-sm-end mt-2 mt-sm-0 d-flex"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""javascript:void(0)"">Form</a></li>
                    <li class=""breadcrumb-item active""><a href=""javascript:void(0)"">Validation</a></li>
                </ol>
            </div>
        </div>
        <!-- row -->
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">Product</h4>
                    </div>
");
#nullable restore
#line 30 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\CreateCategory.cshtml"
                     using (Html.BeginForm("CreateCatelogy", "Admin", FormMethod.Post, new { @class = "form-horizontal form-label-left" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card-body\">\r\n                            <div class=\"form-validation\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f97901693da2bb2bc4154745120cef713efde895993", async() => {
                WriteLiteral("\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-xl-6\">\r\n                                            <div class=\"form-group row\">\r\n                                                ");
#nullable restore
#line 38 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\CreateCategory.cshtml"
                                           Write(Html.LabelFor(c => c.CategoryName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                <div class=\"col-md-10\">\r\n                                                    ");
#nullable restore
#line 40 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\CreateCategory.cshtml"
                                               Write(Html.TextBoxFor(c => c.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                            <div class=\"form-group row\">\r\n                                                ");
#nullable restore
#line 44 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\CreateCategory.cshtml"
                                           Write(Html.LabelFor(c => c.CategoryIdparent, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                <div class=\"col-md-10\">\r\n                                                    ");
#nullable restore
#line 46 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\CreateCategory.cshtml"
                                               Write(Html.TextBoxFor(c => c.CategoryIdparent, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""form-group row"">
                                                <div class=""col-lg-8 ml-auto"">
                                                    <button type=""submit"" class=""btn btn-primary"">Submit</button>
                                                </div>
                                            </div>
                                        </div>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 61 "D:\DoAnchuyenganh\Shopping\Shopping\Views\Admin\CreateCategory.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Catelogy> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591