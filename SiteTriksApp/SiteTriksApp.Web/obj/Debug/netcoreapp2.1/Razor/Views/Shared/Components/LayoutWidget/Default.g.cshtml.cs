#pragma checksum "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\LayoutWidget\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03563bd50a167e96f271f8c7ef150e7e09935495"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LayoutWidget_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LayoutWidget/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/LayoutWidget/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_LayoutWidget_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03563bd50a167e96f271f8c7ef150e7e09935495", @"/Views/Shared/Components/LayoutWidget/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34297145eb0ba94e90521a7f6adfcdbdfa1eec20", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LayoutWidget_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiteTriks.Services.Models.LayoutModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 21, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n");
            EndContext();
            BeginContext(281, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\LayoutWidget\Default.cshtml"
     if(Model.LayoutRows == null)
	{
		return;

	}

#line default
#line hidden
            BeginContext(336, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\LayoutWidget\Default.cshtml"
     foreach (var item in Model.LayoutRows)
    {
        

#line default
#line hidden
            BeginContext(399, 73, false);
#line 14 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\LayoutWidget\Default.cshtml"
   Write(Html.Raw(string.Format("<{0} class='row {1}'>", item.Tag, item.CssClass)));

#line default
#line hidden
            EndContext();
#line 15 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\LayoutWidget\Default.cshtml"
         foreach (var column in item.Columns)
        {
            string placeholder = column.Properties.Placeholder;
            string cssClasses = string.Empty;
            foreach (var col in column.Resolutions)
            {
                cssClasses += $"col-{col.Key}-{col.Value.Size} col-{col.Key}-offset-{col.Value.Offset} ";

                if ((bool)ViewBag.IsPreview)
                {
                    cssClasses += $"st-col-{col.Key}-{col.Value.Size} st-col-{col.Key}-offset-{col.Value.Offset} ";
                }
            }

            if (!string.IsNullOrWhiteSpace(column.Properties.CssClass))
            {
                cssClasses += " " + column.Properties.CssClass + " ";
            }


#line default
#line hidden
            BeginContext(1215, 35, true);
            WriteLiteral("            <div data-placeholder=\"");
            EndContext();
            BeginContext(1251, 11, false);
#line 34 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\LayoutWidget\Default.cshtml"
                              Write(placeholder);

#line default
#line hidden
            EndContext();
            BeginContext(1262, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1263, "\"", 1374, 2);
#line 34 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\LayoutWidget\Default.cshtml"
WriteAttributeValue("", 1271, (bool)ViewBag.IsPreview ? "drop drop-layout connected-widget-container placeholder" : "", 1271, 91, false);

#line default
#line hidden
#line 34 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\LayoutWidget\Default.cshtml"
WriteAttributeValue(" ", 1362, cssClasses, 1363, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1375, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(1395, 221, false);
#line 35 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\LayoutWidget\Default.cshtml"
           Write(await Component.InvokeAsync("RenderPlaceholder", new { pageUrl = Model.PageUrl, version = Model.Version, preview = (bool)ViewBag.IsPreview ? "preview" : "", culture = (string)ViewBag.Language, placeholder = placeholder }));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 37 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\LayoutWidget\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(1658, 43, false);
#line 38 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\LayoutWidget\Default.cshtml"
   Write(Html.Raw(string.Format("</{0}>", item.Tag)));

#line default
#line hidden
            EndContext();
#line 38 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\Shared\Components\LayoutWidget\Default.cshtml"
                                                    
    }

#line default
#line hidden
            BeginContext(1710, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiteTriks.Services.Models.LayoutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591