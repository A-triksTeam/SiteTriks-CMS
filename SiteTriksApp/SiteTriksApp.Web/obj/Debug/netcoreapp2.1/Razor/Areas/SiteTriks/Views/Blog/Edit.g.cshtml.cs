#pragma checksum "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01ebb5b9a3326e89bb84f8318efa794b495cfef5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SiteTriks_Views_Blog_Edit), @"mvc.1.0.view", @"/Areas/SiteTriks/Views/Blog/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SiteTriks/Views/Blog/Edit.cshtml", typeof(AspNetCore.Areas_SiteTriks_Views_Blog_Edit))]
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
#line 1 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\_ViewImports.cshtml"
using SiteTriksApp.Web;

#line default
#line hidden
#line 3 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\_ViewImports.cshtml"
using SiteTriksApp.Web.Models;

#line default
#line hidden
#line 4 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\_ViewImports.cshtml"
using SiteTriksApp.Web.Models.AccountViewModels;

#line default
#line hidden
#line 5 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\_ViewImports.cshtml"
using SiteTriksApp.Web.Models.ManageViewModels;

#line default
#line hidden
#line 7 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\_ViewImports.cshtml"
using SiteTriks.Infrastructure.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01ebb5b9a3326e89bb84f8318efa794b495cfef5", @"/Areas/SiteTriks/Views/Blog/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37c59baa2c2423197145f0831249231c41dbc78d", @"/Areas/SiteTriks/Views/_ViewImports.cshtml")]
    public class Areas_SiteTriks_Views_Blog_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiteTriks.BlogModule.Models.Blog.BlogPostViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/navbar-remove.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/validator.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/text-editor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sitetriks/blog.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
  
    ViewBag.Title = "Edit Blog Post";

#line default
#line hidden
            BeginContext(107, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(126, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(132, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "41a5c39088d4426c960183d4b77e727e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(188, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(193, 33, true);
            WriteLiteral("\r\n<div class=\"backend-wrapper\">\r\n");
            EndContext();
#line 12 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(273, 23, false);
#line 14 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(300, 47, true);
            WriteLiteral("        <div class=\"fixed-top-2\">\r\n            ");
            EndContext();
            BeginContext(348, 42, false);
#line 17 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
       Write(await Html.PartialAsync("SecondNavHeader"));

#line default
#line hidden
            EndContext();
            BeginContext(390, 18, true);
            WriteLiteral("\r\n\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 408, "\"", 435, 1);
#line 19 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
WriteAttributeValue("", 415, Url.Action("Index"), 415, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(436, 159, true);
            WriteLiteral(" class=\"btn-nav-2\"><span class=\"st-icon-return-to-list\"></span>Cancel</a>\r\n            <input type=\"submit\" value=\"Save\" class=\"btn-nav-2\" />\r\n        </div>\r\n");
            EndContext();
            BeginContext(597, 71, true);
            WriteLiteral("        <div class=\"page-properties\">\r\n            <hr />\r\n            ");
            EndContext();
            BeginContext(669, 33, false);
#line 25 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(702, 62, true);
            WriteLiteral("\r\n\r\n            <div class=\"form-group row\">\r\n                ");
            EndContext();
            BeginContext(765, 94, false);
#line 28 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
           Write(Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(859, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(878, 108, false);
#line 29 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
           Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "form-control", id = "title" } }));

#line default
#line hidden
            EndContext();
            BeginContext(986, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1005, 83, false);
#line 30 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 98, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group row description-row\">\r\n                ");
            EndContext();
            BeginContext(1187, 96, false);
#line 34 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
           Write(Html.LabelFor(model => model.Summary, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(1347, 94, false);
#line 36 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
               Write(Html.TextAreaFor(model => model.Summary, new { @class = "form-control", id = "summary-area" }));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1464, 85, false);
#line 37 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Summary, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 124, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group row description-row\">\r\n                ");
            EndContext();
            BeginContext(1674, 96, false);
#line 43 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
           Write(Html.LabelFor(model => model.Content, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1770, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(1834, 94, false);
#line 45 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
               Write(Html.TextAreaFor(model => model.Content, new { @class = "form-control", id = "content-area" }));

#line default
#line hidden
            EndContext();
            BeginContext(1928, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1951, 85, false);
#line 46 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.Content, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 50 "C:\Users\milova\.nuget\packages\sitetriks.blogmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Blog\Edit.cshtml"
    }

#line default
#line hidden
            BeginContext(2105, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2132, 83, true);
                WriteLiteral("\r\n    <script src=\'https://cloud.tinymce.com/stable/tinymce.min.js\'></script>\r\n    ");
                EndContext();
                BeginContext(2215, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37b296a7eab94e968983b02babd58adb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2279, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2285, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bb860cfae2c442087917258e95b8847", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2328, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2334, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81003f7e6d704c5dabb3b4bb53b66ac8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2380, 81, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        createEditBlog();\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiteTriks.BlogModule.Models.Blog.BlogPostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591