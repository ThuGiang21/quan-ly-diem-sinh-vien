#pragma checksum "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ea3cc62882dce386b0ed550c619b7df7d0b2e0cf494178adea8935cc24965204"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HocPhi_Details), @"mvc.1.0.view", @"/Views/HocPhi/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\_ViewImports.cshtml"
using Quan_Ly_Sinh_Vien;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\_ViewImports.cshtml"
using Quan_Ly_Sinh_Vien.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ea3cc62882dce386b0ed550c619b7df7d0b2e0cf494178adea8935cc24965204", @"/Views/HocPhi/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bddfaea56b9cdcba21417456842778f8dbfeb66f6b5898c2897c9994e8dcd1e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HocPhi_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Quan_Ly_Sinh_Vien.Database.HocPhi>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>HocPhi</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenSinhVien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenSinhVien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SoTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml"
       Write(Html.DisplayFor(model => model.SoTien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayThanhToan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgayThanhToan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HinhThucThanhToan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml"
       Write(Html.DisplayFor(model => model.HinhThucThanhToan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaSinhVienNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaSinhVienNavigation.HoTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea3cc62882dce386b0ed550c619b7df7d0b2e0cf494178adea8935cc249652048729", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\HocPhi\Details.cshtml"
                           WriteLiteral(Model.MaHocPhi);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea3cc62882dce386b0ed550c619b7df7d0b2e0cf494178adea8935cc2496520410983", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Quan_Ly_Sinh_Vien.Database.HocPhi> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
