#pragma checksum "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Subscription\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51edaf20b03176d0a900dd45b553a3f010302eb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaseWidget_Subscription_Display), @"mvc.1.0.view", @"/Views/BaseWidget/Subscription/Display.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BaseWidget/Subscription/Display.cshtml", typeof(AspNetCore.Views_BaseWidget_Subscription_Display))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51edaf20b03176d0a900dd45b553a3f010302eb9", @"/Views/BaseWidget/Subscription/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34297145eb0ba94e90521a7f6adfcdbdfa1eec20", @"/Views/_ViewImports.cshtml")]
    public class Views_BaseWidget_Subscription_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiteTriks.Extentions.WidgetModels.SubscriptionWidgetModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Subscription\Display.cshtml"
 if (Model.IsPreview)
{

#line default
#line hidden
            BeginContext(94, 54, true);
            WriteLiteral("    <div class=\"preview-placeholder\" data-identifier=\"");
            EndContext();
            BeginContext(149, 8, false);
#line 5 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Subscription\Display.cshtml"
                                                 Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(157, 12, true);
            WriteLiteral("\">\r\n        ");
            EndContext();
            BeginContext(170, 92, false);
#line 6 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Subscription\Display.cshtml"
   Write(await Html.PartialAsync("~/Areas/SiteTriks/Views/Shared/WidgetControl.cshtml", model: Model));

#line default
#line hidden
            EndContext();
            BeginContext(262, 16, true);
            WriteLiteral("\r\n\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 278, "\"", 301, 1);
#line 8 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Subscription\Display.cshtml"
WriteAttributeValue("", 286, Model.CssClass, 286, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(302, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(318, 91, false);
#line 9 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Subscription\Display.cshtml"
       Write(await Component.InvokeAsync("SubscriptionWidget", new { area = "", lang = Model.Language }));

#line default
#line hidden
            EndContext();
            BeginContext(409, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 12 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Subscription\Display.cshtml"
}
else
{
    if (Model.CanViewByRole && Model.CanViewByGroup)
    {

#line default
#line hidden
            BeginContext(512, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 524, "\"", 547, 1);
#line 17 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Subscription\Display.cshtml"
WriteAttributeValue("", 532, Model.CssClass, 532, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(548, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(564, 91, false);
#line 18 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Subscription\Display.cshtml"
       Write(await Component.InvokeAsync("SubscriptionWidget", new { area = "", lang = Model.Language }));

#line default
#line hidden
            EndContext();
            BeginContext(655, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 20 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Views\BaseWidget\Subscription\Display.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiteTriks.Extentions.WidgetModels.SubscriptionWidgetModel> Html { get; private set; }
    }
}
#pragma warning restore 1591