#pragma checksum "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0f1bc627e153419b0a36cd2039a0ade9992f19f12c4809c024cf9dab96c87ed6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LopHoc_Details), @"mvc.1.0.view", @"/Views/LopHoc/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0f1bc627e153419b0a36cd2039a0ade9992f19f12c4809c024cf9dab96c87ed6", @"/Views/LopHoc/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bddfaea56b9cdcba21417456842778f8dbfeb66f6b5898c2897c9994e8dcd1e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LopHoc_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Quan_Ly_Sinh_Vien.Database.LopHoc>
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
#line 3 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Details</h1>


<div class=""container-fluid"">
    <!--page heading-->
    <h1 class=""h3 mb-2 text-gray-800"">Môn Học</h1>
    <!--Datatables Example-->
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Danh Mục Môn Học</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <div>
                    <h4>LopHoc</h4>
                    <hr />
                    <dl class=""row"">
                        <dt class=""col-sm-2"">
                            ");
#nullable restore
#line 25 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.TenLop));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 28 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayFor(model => model.TenLop));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 31 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.SiSo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayFor(model => model.SiSo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 37 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.TenGiangVien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 40 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayFor(model => model.TenGiangVien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 43 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.PhongHoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 46 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayFor(model => model.PhongHoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 49 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.NamHoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 52 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayFor(model => model.NamHoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 55 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.KhoaHoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 58 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayFor(model => model.KhoaHoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 61 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.GioiTinhGiangVien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 64 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                       Write(Html.DisplayFor(model => model.GioiTinhGiangVien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </div>\r\n                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f1bc627e153419b0a36cd2039a0ade9992f19f12c4809c024cf9dab96c87ed611630", async() => {
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
#line 69 "C:\Users\hp\Documents\Zalo Received Files\Quan-Ly-Sinh-Vien-\Quan-Ly-Sinh-Vien-\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Quan_Ly_Sinh_Vien\Views\LopHoc\Details.cshtml"
                                           WriteLiteral(Model.MaLop);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f1bc627e153419b0a36cd2039a0ade9992f19f12c4809c024cf9dab96c87ed613914", async() => {
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Quan_Ly_Sinh_Vien.Database.LopHoc> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
