#pragma checksum "C:\Users\milova\.nuget\packages\sitetriks.documentationmodule\1.0.2.1\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Documentation\GetContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb2c55d3adea0c76ba5c295c9382ab0f0533de67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SiteTriks_Views_Documentation_GetContent), @"mvc.1.0.view", @"/Areas/SiteTriks/Views/Documentation/GetContent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SiteTriks/Views/Documentation/GetContent.cshtml", typeof(AspNetCore.Areas_SiteTriks_Views_Documentation_GetContent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2c55d3adea0c76ba5c295c9382ab0f0533de67", @"/Areas/SiteTriks/Views/Documentation/GetContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37c59baa2c2423197145f0831249231c41dbc78d", @"/Areas/SiteTriks/Views/_ViewImports.cshtml")]
    public class Areas_SiteTriks_Views_Documentation_GetContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiteTriks.DocumentationModule.Models.TopicDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(74, 10, false);
#line 3 "C:\Users\milova\.nuget\packages\sitetriks.documentationmodule\1.0.2.1\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Documentation\GetContent.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(84, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
            BeginContext(120, 5, true);
            WriteLiteral("<div>");
            EndContext();
            BeginContext(126, 17, false);
#line 5 "C:\Users\milova\.nuget\packages\sitetriks.documentationmodule\1.0.2.1\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Documentation\GetContent.cshtml"
Write(Model.ContentName);

#line default
#line hidden
            EndContext();
            BeginContext(143, 13, true);
            WriteLiteral("</div>\r\n<div>");
            EndContext();
            BeginContext(157, 28, false);
#line 6 "C:\Users\milova\.nuget\packages\sitetriks.documentationmodule\1.0.2.1\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Documentation\GetContent.cshtml"
Write(Html.Raw(Model.TopicContent));

#line default
#line hidden
            EndContext();
            BeginContext(185, 13, true);
            WriteLiteral("</div>\r\n<div>");
            EndContext();
            BeginContext(199, 13, false);
#line 7 "C:\Users\milova\.nuget\packages\sitetriks.documentationmodule\1.0.2.1\contentFiles\any\netcoreapp2.1\Areas\SiteTriks\Views\Documentation\GetContent.cshtml"
Write(Model.Version);

#line default
#line hidden
            EndContext();
            BeginContext(212, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiteTriks.DocumentationModule.Models.TopicDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
