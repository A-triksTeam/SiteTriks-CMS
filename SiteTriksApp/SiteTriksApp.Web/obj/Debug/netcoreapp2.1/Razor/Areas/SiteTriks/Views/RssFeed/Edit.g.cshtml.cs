#pragma checksum "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d39aa5d7a70ea8c4988001f11d88a9cd59b5c53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SiteTriks_Views_RssFeed_Edit), @"mvc.1.0.view", @"/Areas/SiteTriks/Views/RssFeed/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SiteTriks/Views/RssFeed/Edit.cshtml", typeof(AspNetCore.Areas_SiteTriks_Views_RssFeed_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d39aa5d7a70ea8c4988001f11d88a9cd59b5c53", @"/Areas/SiteTriks/Views/RssFeed/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37c59baa2c2423197145f0831249231c41dbc78d", @"/Areas/SiteTriks/Views/_ViewImports.cshtml")]
    public class Areas_SiteTriks_Views_RssFeed_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiteTriks.RssFeedModule.Models.EditRssFeedViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/navbar-remove.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/leaving-warning.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sitetriks/rss-feeds.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
  
    ViewBag.Title = "Edit RssFeed Configuration";

#line default
#line hidden
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(139, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(145, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e0820c1d29c4f09b02fc6a4ea86b667", async() => {
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
                BeginContext(201, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(206, 33, true);
            WriteLiteral("\r\n<div class=\"backend-wrapper\">\r\n");
            EndContext();
#line 12 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
            BeginContext(277, 47, true);
            WriteLiteral("        <div class=\"fixed-top-2\">\r\n            ");
            EndContext();
            BeginContext(325, 42, false);
#line 15 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
       Write(await Html.PartialAsync("SecondNavHeader"));

#line default
#line hidden
            EndContext();
            BeginContext(367, 18, true);
            WriteLiteral("\r\n\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 385, "\"", 412, 1);
#line 17 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
WriteAttributeValue("", 392, Url.Action("Index"), 392, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(413, 159, true);
            WriteLiteral(" class=\"btn-nav-2\"><span class=\"st-icon-return-to-list\"></span>Cancel</a>\r\n            <input type=\"submit\" value=\"Edit\" class=\"btn-nav-2\" />\r\n        </div>\r\n");
            EndContext();
            BeginContext(574, 110, true);
            WriteLiteral("        <div class=\"page-properties\">\r\n            <div class=\"form-group row\">\r\n                <h4>Builder: ");
            EndContext();
            BeginContext(685, 17, false);
#line 23 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                        Write(Model.BuilderName);

#line default
#line hidden
            EndContext();
            BeginContext(702, 128, true);
            WriteLiteral("</h4>\r\n            </div>\r\n            <div id=\"fieldItems\">\r\n                <div class=\"form-group row\">\r\n                    ");
            EndContext();
            BeginContext(831, 85, false);
#line 27 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
               Write(Html.LabelFor(m => m.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(916, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(939, 111, false);
#line 28 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
               Write(Html.EditorFor(m => m.Name, Model.Name, new { htmlAttributes = new { @class = "form-control", Id = "title" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 92, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group row\">\r\n                    ");
            EndContext();
            BeginContext(1143, 92, false);
#line 31 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
               Write(Html.LabelFor(model => Model.Url, htmlAttributes: new { @class = "control-label col-xs-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1235, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1258, 117, false);
#line 32 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
               Write(Html.EditorFor(model => Model.Url, new { htmlAttributes = new { @class = "form-control inline-block", Id = "url" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 50, true);
            WriteLiteral("\r\n                </div>\r\n                <hr />\r\n");
            EndContext();
#line 35 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                 for (int i = 0; i < Model.RssFeedItems.Count; i++)
                {

#line default
#line hidden
            BeginContext(1513, 128, true);
            WriteLiteral("                    <div class=\"form-group row description-row\">\r\n                        <label class=\"control-label col-md-2\">");
            EndContext();
            BeginContext(1642, 31, false);
#line 38 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                                                         Write(Model.RssFeedItems[i].FieldName);

#line default
#line hidden
            EndContext();
            BeginContext(1673, 34, true);
            WriteLiteral("</label>\r\n                        ");
            EndContext();
            BeginContext(1708, 56, false);
#line 39 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                   Write(Html.HiddenFor(model => model.RssFeedItems[i].FieldName));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1791, 145, false);
#line 40 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                   Write(Html.EditorFor(x => Model.RssFeedItems[i].FieldValue, Model.RssFeedItems[i].FieldValue, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1936, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 42 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"

                }

#line default
#line hidden
            BeginContext(1987, 106, true);
            WriteLiteral("                <hr />\r\n                <div class=\"form-group row\">\r\n                    <h4>MappedFrom: ");
            EndContext();
            BeginContext(2094, 13, false);
#line 46 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                               Write(Model.MapFrom);

#line default
#line hidden
            EndContext();
            BeginContext(2107, 131, true);
            WriteLiteral("</h4>\r\n                    <div class=\"col-md-8\">\r\n                        <h4>Item Mappings</h4>\r\n                        <hr />\r\n");
            EndContext();
#line 50 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                         for (int i = 0; i < Model.ItemMappings.Count; i++)
                        {

#line default
#line hidden
            BeginContext(2342, 128, true);
            WriteLiteral("                            <div class=\"form-group row\">\r\n                                <label class=\"control-label col-md-2\">");
            EndContext();
            BeginContext(2471, 29, false);
#line 53 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                                                                 Write(Model.ItemMappings[i].FieldTo);

#line default
#line hidden
            EndContext();
            BeginContext(2500, 42, true);
            WriteLiteral("</label>\r\n                                ");
            EndContext();
            BeginContext(2543, 54, false);
#line 54 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                           Write(Html.HiddenFor(model => model.ItemMappings[i].FieldTo));

#line default
#line hidden
            EndContext();
            BeginContext(2597, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2632, 173, false);
#line 55 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                           Write(Html.DropDownListFor(model => model.ItemMappings[i].FieldFrom, Model.ItemMappings[i].AvailablePropertiesSelectItems,
                       new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2805, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 58 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                        }

#line default
#line hidden
            BeginContext(2870, 157, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"col-md-2\">\r\n                        <h5>Available properties</h5>\r\n                        <ul>\r\n");
            EndContext();
#line 63 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                             foreach (var prop in Model.BuilderProperties)
                            {

#line default
#line hidden
            BeginContext(3134, 36, true);
            WriteLiteral("                                <li>");
            EndContext();
            BeginContext(3171, 4, false);
#line 65 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                               Write(prop);

#line default
#line hidden
            EndContext();
            BeginContext(3175, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 66 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                            }

#line default
#line hidden
            BeginContext(3213, 143, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 73 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
    }

#line default
#line hidden
            BeginContext(3363, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3389, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3395, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "073e696ad8b44ae89f0b1eeb61573072", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3442, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3448, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b1d9122baf04cd2b1a9492ec6bb1030", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3499, 37, true);
                WriteLiteral("\r\n    <script>\r\n        editRssFeed(\'");
                EndContext();
                BeginContext(3537, 34, false);
#line 79 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                Write(Url.Action("ValidateUrl", "Pages"));

#line default
#line hidden
                EndContext();
                BeginContext(3571, 4, true);
                WriteLiteral("\', \'");
                EndContext();
                BeginContext(3576, 27, false);
#line 79 "C:\Users\milova\.nuget\packages\sitetriks.rssfeedmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\RssFeed\Edit.cshtml"
                                                       Write(Url.Action("BuilderFields"));

#line default
#line hidden
                EndContext();
                BeginContext(3603, 19, true);
                WriteLiteral("\')\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiteTriks.RssFeedModule.Models.EditRssFeedViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
