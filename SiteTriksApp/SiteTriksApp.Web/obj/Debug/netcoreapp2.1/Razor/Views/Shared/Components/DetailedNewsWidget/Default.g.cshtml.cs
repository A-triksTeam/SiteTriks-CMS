#pragma checksum "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "102984d8e42b058b3939f4c3b7541769d060329d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DetailedNewsWidget_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DetailedNewsWidget/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/DetailedNewsWidget/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_DetailedNewsWidget_Default))]
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
#line 1 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\_ViewImports.cshtml"
using SiteTriksApp.Web;

#line default
#line hidden
#line 3 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\_ViewImports.cshtml"
using SiteTriksApp.Web.Models;

#line default
#line hidden
#line 4 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\_ViewImports.cshtml"
using SiteTriksApp.Web.Models.AccountViewModels;

#line default
#line hidden
#line 5 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\_ViewImports.cshtml"
using SiteTriksApp.Web.Models.ManageViewModels;

#line default
#line hidden
#line 6 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\_ViewImports.cshtml"
using SiteTriks.Models.CoreWidgets;

#line default
#line hidden
#line 9 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\_ViewImports.cshtml"
using SiteTriks.Infrastructure.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"102984d8e42b058b3939f4c3b7541769d060329d", @"/Views/Shared/Components/DetailedNewsWidget/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34297145eb0ba94e90521a7f6adfcdbdfa1eec20", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DetailedNewsWidget_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiteTriks.Models.News.NewsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 26, true);
            WriteLiteral("\r\n<input name=\"SEOKeyword\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 66, "\"", 91, 1);
#line 3 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
WriteAttributeValue("", 74, Model.SEOKeyword, 74, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(92, 240, true);
            WriteLiteral(" type=\"hidden\" />\r\n\r\n<div>\r\n    <div class=\"news-container\">\r\n        <div class=\"news-container-1\">\r\n            <div>\r\n                <div class=\"relative nc-d1\">\r\n                    <div class=\"ta-center\">\r\n                        <h3>");
            EndContext();
            BeginContext(333, 33, false);
#line 11 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
                       Write(Html.DisplayFor(m => Model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(366, 110, true);
            WriteLiteral("</h3>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"news-mi-container\">\r\n");
            EndContext();
#line 16 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
                     if (!string.IsNullOrEmpty(Model.MainImageUrlID))
                    {

#line default
#line hidden
            BeginContext(570, 52, true);
            WriteLiteral("                        <img class=\"news-main-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 622, "\"", 659, 2);
            WriteAttributeValue("", 628, "/files/id/", 628, 10, true);
#line 18 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
WriteAttributeValue("", 638, Model.MainImageUrlID, 638, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(660, 36, true);
            WriteLiteral(" alt=\"Failed to load main image!\">\r\n");
            EndContext();
#line 19 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(719, 161, true);
            WriteLiteral("                </div>\r\n\r\n                <div class=\"ta-right\">\r\n                    <span class=\"news-date-created\" id=\"detailed-news-date-created\" data-year=\"");
            EndContext();
            BeginContext(881, 28, false);
#line 23 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
                                                                                          Write(Model.DateCreated.Value.Year);

#line default
#line hidden
            EndContext();
            BeginContext(909, 14, true);
            WriteLiteral("\" data-month=\"");
            EndContext();
            BeginContext(924, 29, false);
#line 23 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
                                                                                                                                     Write(Model.DateCreated.Value.Month);

#line default
#line hidden
            EndContext();
            BeginContext(953, 22, true);
            WriteLiteral("\">Date Created: <span>");
            EndContext();
            BeginContext(976, 46, false);
#line 23 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
                                                                                                                                                                                         Write(Model.DateCreated.Value.ToString("dd.MM.yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 150, true);
            WriteLiteral("</span></span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div>\r\n            <div class=\"news-content\">\r\n                <p>");
            EndContext();
            BeginContext(1173, 23, false);
#line 29 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
              Write(Html.Raw(Model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 82, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"news-container-2\">\r\n");
            EndContext();
#line 33 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
             if (!string.IsNullOrEmpty(Model.ImagesUrlsIDs))
            {

#line default
#line hidden
            BeginContext(1355, 91, true);
            WriteLiteral("                <div class=\"gallery\">\r\n                    <div class=\"gallerycontainer\">\r\n");
            EndContext();
#line 37 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
                         foreach (var item in Model.ImagesUrlsIDs.Split(';'))
                        {

#line default
#line hidden
            BeginContext(1552, 127, true);
            WriteLiteral("                            <div class=\"gallery-item inline-block\">\r\n                                <img class=\"display-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1679, "\"", 1700, 2);
            WriteAttributeValue("", 1685, "/files/id/", 1685, 10, true);
#line 40 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
WriteAttributeValue("", 1695, item, 1695, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1701, 67, true);
            WriteLiteral(" alt=\"Failed to load image!\">\r\n                            </div>\r\n");
            EndContext();
#line 42 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(1795, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 46 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\DetailedNewsWidget\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(1864, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiteTriks.Models.News.NewsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
