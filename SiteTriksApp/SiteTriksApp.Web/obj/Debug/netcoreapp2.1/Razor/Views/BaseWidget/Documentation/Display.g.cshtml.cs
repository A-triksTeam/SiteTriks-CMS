#pragma checksum "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Documentation\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c627fb11c9e96ad81b8463f7e64938f0f5cf668"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaseWidget_Documentation_Display), @"mvc.1.0.view", @"/Views/BaseWidget/Documentation/Display.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BaseWidget/Documentation/Display.cshtml", typeof(AspNetCore.Views_BaseWidget_Documentation_Display))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c627fb11c9e96ad81b8463f7e64938f0f5cf668", @"/Views/BaseWidget/Documentation/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34297145eb0ba94e90521a7f6adfcdbdfa1eec20", @"/Views/_ViewImports.cshtml")]
    public class Views_BaseWidget_Documentation_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiteTriks.Extentions.WidgetModels.DocumentationWidgetModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Documentation\Display.cshtml"
 if (Model.IsPreview)
{

#line default
#line hidden
            BeginContext(95, 54, true);
            WriteLiteral("    <div class=\"preview-placeholder\" data-identifier=\"");
            EndContext();
            BeginContext(150, 8, false);
#line 5 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Documentation\Display.cshtml"
                                                 Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(158, 12, true);
            WriteLiteral("\">\r\n        ");
            EndContext();
            BeginContext(171, 92, false);
#line 6 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Documentation\Display.cshtml"
   Write(await Html.PartialAsync("~/Areas/SiteTriks/Views/Shared/WidgetControl.cshtml", model: Model));

#line default
#line hidden
            EndContext();
            BeginContext(263, 16, true);
            WriteLiteral("\r\n\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 279, "\"", 302, 1);
#line 8 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Documentation\Display.cshtml"
WriteAttributeValue("", 287, Model.CssClass, 287, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(303, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(319, 92, false);
#line 9 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Documentation\Display.cshtml"
       Write(await Component.InvokeAsync("DocumentationWidget", new { area = "", lang = Model.Language }));

#line default
#line hidden
            EndContext();
            BeginContext(411, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 12 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Documentation\Display.cshtml"
}
else
{
    if (Model.CanViewByRole && Model.CanViewByGroup)
    {

#line default
#line hidden
            BeginContext(514, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 526, "\"", 549, 1);
#line 17 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Documentation\Display.cshtml"
WriteAttributeValue("", 534, Model.CssClass, 534, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(550, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(566, 92, false);
#line 18 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Documentation\Display.cshtml"
       Write(await Component.InvokeAsync("DocumentationWidget", new { area = "", lang = Model.Language }));

#line default
#line hidden
            EndContext();
            BeginContext(658, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 20 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Documentation\Display.cshtml"
    }
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiteTriks.Extentions.WidgetModels.DocumentationWidgetModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
