#pragma checksum "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Dynamic\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03e5a8b0b4bd627ebf2daa5477a9117cf4110439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaseWidget_Dynamic_Display), @"mvc.1.0.view", @"/Views/BaseWidget/Dynamic/Display.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BaseWidget/Dynamic/Display.cshtml", typeof(AspNetCore.Views_BaseWidget_Dynamic_Display))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e5a8b0b4bd627ebf2daa5477a9117cf4110439", @"/Views/BaseWidget/Dynamic/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34297145eb0ba94e90521a7f6adfcdbdfa1eec20", @"/Views/_ViewImports.cshtml")]
    public class Views_BaseWidget_Dynamic_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiteTriks.Extentions.WidgetModels.DynamicWidgetModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Dynamic\Display.cshtml"
 if (Model.IsPreview)
{

#line default
#line hidden
            BeginContext(89, 54, true);
            WriteLiteral("    <div class=\"preview-placeholder\" data-identifier=\"");
            EndContext();
            BeginContext(144, 8, false);
#line 5 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Dynamic\Display.cshtml"
                                                 Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(152, 12, true);
            WriteLiteral("\">\r\n        ");
            EndContext();
            BeginContext(165, 92, false);
#line 6 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Dynamic\Display.cshtml"
   Write(await Html.PartialAsync("~/Areas/SiteTriks/Views/Shared/WidgetControl.cshtml", model: Model));

#line default
#line hidden
            EndContext();
            BeginContext(257, 16, true);
            WriteLiteral("\r\n\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 273, "\"", 296, 1);
#line 8 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Dynamic\Display.cshtml"
WriteAttributeValue("", 281, Model.CssClass, 281, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(297, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(313, 88, false);
#line 9 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Dynamic\Display.cshtml"
       Write(await Component.InvokeAsync("DynamicWidget", new { area = "", element = Model.Element }));

#line default
#line hidden
            EndContext();
            BeginContext(401, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 12 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Dynamic\Display.cshtml"
}
else
{
    if (Model.CanViewByRole && Model.CanViewByGroup)
    {

#line default
#line hidden
            BeginContext(504, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 516, "\"", 539, 1);
#line 17 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Dynamic\Display.cshtml"
WriteAttributeValue("", 524, Model.CssClass, 524, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(540, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(556, 88, false);
#line 18 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Dynamic\Display.cshtml"
       Write(await Component.InvokeAsync("DynamicWidget", new { area = "", element = Model.Element }));

#line default
#line hidden
            EndContext();
            BeginContext(644, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 20 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Dynamic\Display.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiteTriks.Extentions.WidgetModels.DynamicWidgetModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
