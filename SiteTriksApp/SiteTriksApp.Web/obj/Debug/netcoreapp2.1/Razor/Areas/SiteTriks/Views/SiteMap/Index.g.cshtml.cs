#pragma checksum "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2631469103f4ca56cafba353047c8aac0827681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SiteTriks_Views_SiteMap_Index), @"mvc.1.0.view", @"/Areas/SiteTriks/Views/SiteMap/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SiteTriks/Views/SiteMap/Index.cshtml", typeof(AspNetCore.Areas_SiteTriks_Views_SiteMap_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2631469103f4ca56cafba353047c8aac0827681", @"/Areas/SiteTriks/Views/SiteMap/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37c59baa2c2423197145f0831249231c41dbc78d", @"/Areas/SiteTriks/Views/_ViewImports.cshtml")]
    public class Areas_SiteTriks_Views_SiteMap_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiteTriks.SiteMapModule.Models.SiteMapViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
  
    ViewBag.Title = "SiteMap";

#line default
#line hidden
            BeginContext(97, 33, true);
            WriteLiteral("\r\n<div class=\"fixed-top-2\">\r\n    ");
            EndContext();
            BeginContext(131, 42, false);
#line 8 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
Write(await Html.PartialAsync("SecondNavHeader"));

#line default
#line hidden
            EndContext();
            BeginContext(173, 440, true);
            WriteLiteral(@"
</div>

<div class=""backend-wrapper"">
    <div class=""sitemap-container"">
        <div class=""panel panel-primary"">
            <div class=""panel-heading""><b>Sitemap</b></div>
            <div class=""panel-body"">
                <div class=""panel-group"">
                    <div class=""panel panel-info"">
                        <div class=""panel-heading""><b>Options</b></div>
                        <div class=""panel-body"">
");
            EndContext();
#line 20 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                             using (Html.BeginForm("ViewXml", "SiteMap", FormMethod.Get, htmlAttributes: new { @class = "btn-group inline" }))
                            {

#line default
#line hidden
            BeginContext(788, 80, true);
            WriteLiteral("                                <button class=\"btn btn-info\">Raw view</button>\r\n");
            EndContext();
#line 23 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(899, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 24 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                             using (Html.BeginForm("Export", "SiteMap", FormMethod.Get, htmlAttributes: new { @class = "btn-group inline" }))
                            {

#line default
#line hidden
            BeginContext(1073, 81, true);
            WriteLiteral("                                <button class=\"btn btn-warning\">Export</button>\r\n");
            EndContext();
#line 27 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1185, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 28 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                             using (Html.BeginForm("UpdateSiteMap", "SiteMap", FormMethod.Get, htmlAttributes: new { @class = "btn-group inline" }))
                            {

#line default
#line hidden
            BeginContext(1366, 92, true);
            WriteLiteral("                                <button class=\"btn btn-danger\">Update sitemap.xml</button>\r\n");
            EndContext();
#line 31 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1489, 165, true);
            WriteLiteral("                            <hr>\r\n                            <div id=\"schedule-form-wrapper\">\r\n                                <h4>Schedule all sitemaps file</h4>\r\n");
            EndContext();
#line 35 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                                 using (Html.BeginForm("ScheduleAllSitemaps", "SiteMap", FormMethod.Get, htmlAttributes: new { @class = "btn-group inline" }))
                                {
                                    

#line default
#line hidden
            BeginContext(1886, 316, false);
#line 37 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                               Write(Html.DropDownList("Interval",
                                                   Html.GetEnumSelectList<SiteTriks.SiteMapModule.Common.CronType>(),
                                                   "None",
                                                   new { @class = "form-control", required = "required" }));

#line default
#line hidden
            EndContext();
            BeginContext(2204, 87, true);
            WriteLiteral("                                    <button class=\"btn btn-success\">Schedule</button>\r\n");
            EndContext();
#line 42 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2326, 553, true);
            WriteLiteral(@"                            </div>
                        </div>
                    </div>

                    <div class=""panel panel-info"">
                        <div class=""panel-heading""><b>SiteMap</b></div>
                        <div class=""panel-body"">
                            <div class=""sitemap-inner-container"">
                                <div class=""row"">
                                    <div class=""col-sm-4"">
                                        <h2>Pages</h2>
                                        <ul>
");
            EndContext();
#line 55 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                                             foreach (var item in Model.Pages)
                                            {

#line default
#line hidden
            BeginContext(3006, 54, true);
            WriteLiteral("                                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3060, "\"", 3078, 1);
#line 57 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
WriteAttributeValue("", 3067, item.Item2, 3067, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3079, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3081, 10, false);
#line 57 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                                                                     Write(item.Item1);

#line default
#line hidden
            EndContext();
            BeginContext(3091, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 58 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3149, 252, true);
            WriteLiteral("                                        </ul>\r\n                                    </div>\r\n                                    <div class=\"col-sm-4\">\r\n                                        <h2>News</h2>\r\n                                        <ul>\r\n");
            EndContext();
#line 64 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                                             foreach (var item in Model.News)
                                            {

#line default
#line hidden
            BeginContext(3527, 54, true);
            WriteLiteral("                                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3581, "\"", 3599, 1);
#line 66 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
WriteAttributeValue("", 3588, item.Item2, 3588, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3600, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3602, 10, false);
#line 66 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                                                                     Write(item.Item1);

#line default
#line hidden
            EndContext();
            BeginContext(3612, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 67 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3670, 253, true);
            WriteLiteral("                                        </ul>\r\n                                    </div>\r\n                                    <div class=\"col-sm-4\">\r\n                                        <h2>Files</h2>\r\n                                        <ul>\r\n");
            EndContext();
#line 73 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                                             foreach (var item in Model.Files)
                                            {

#line default
#line hidden
            BeginContext(4050, 54, true);
            WriteLiteral("                                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4104, "\"", 4122, 1);
#line 75 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
WriteAttributeValue("", 4111, item.Item2, 4111, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4123, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4125, 10, false);
#line 75 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                                                                     Write(item.Item1);

#line default
#line hidden
            EndContext();
            BeginContext(4135, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 76 "C:\Users\milova\.nuget\packages\sitetriks.sitemapmodule\1.0.2\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\SiteMap\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4193, 309, true);
            WriteLiteral(@"                                        </ul>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiteTriks.SiteMapModule.Models.SiteMapViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591