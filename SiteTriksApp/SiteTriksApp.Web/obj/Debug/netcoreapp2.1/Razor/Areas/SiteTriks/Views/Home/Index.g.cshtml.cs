#pragma checksum "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec47c2dbe2172f6ef5fb1ea2095baab1430c2dd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SiteTriks_Views_Home_Index), @"mvc.1.0.view", @"/Areas/SiteTriks/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SiteTriks/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_SiteTriks_Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec47c2dbe2172f6ef5fb1ea2095baab1430c2dd3", @"/Areas/SiteTriks/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37c59baa2c2423197145f0831249231c41dbc78d", @"/Areas/SiteTriks/Views/_ViewImports.cshtml")]
    public class Areas_SiteTriks_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SiteTriks.Models.DashboardConfiguration.DashboardConfigurationModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/dragable.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(154, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Dashboard";

#line default
#line hidden
            BeginContext(197, 33, true);
            WriteLiteral("\r\n<div class=\"fixed-top-2\">\r\n    ");
            EndContext();
            BeginContext(231, 42, false);
#line 10 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("SecondNavHeader"));

#line default
#line hidden
            EndContext();
            BeginContext(273, 155, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"dashboard-wrapper\">\r\n    <div class=\"row\">\r\n        <div class=\"side-navigation col-md-3 col-lg-2 col-sm-3 col-xs-3\">\r\n            ");
            EndContext();
            BeginContext(429, 41, false);
#line 16 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("SideNavigation"));

#line default
#line hidden
            EndContext();
            BeginContext(470, 150, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"dashboard-content col-lg-10 col-md-9 col-sm-9 col-xs-9\">\r\n            <div class=\"row\" id=\"dashbpard-widgets\">\r\n");
            EndContext();
#line 20 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\Home\Index.cshtml"
                 foreach (var dashboardConfig in Model)
                {

#line default
#line hidden
            BeginContext(696, 85, true);
            WriteLiteral("                    <div class=\"dashboard-conten-column dashboard-widget\" data-type=\"");
            EndContext();
            BeginContext(782, 27, false);
#line 22 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\Home\Index.cshtml"
                                                                                Write(dashboardConfig.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(809, 28, true);
            WriteLiteral("\">\r\n                        ");
            EndContext();
            BeginContext(838, 54, false);
#line 23 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\Home\Index.cshtml"
                   Write(await Component.InvokeAsync(dashboardConfig.ClassName));

#line default
#line hidden
            EndContext();
            BeginContext(892, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 25 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\SiteTriks\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(941, 402, true);
            WriteLiteral(@"
                <div class=""google-analytics col-lg-12 col-md-12 col-sm-9 col-xs-9"">
                    <div class=""row"">
                        <div class=""dashboard-table"">
                            <div class=""panel panel-primary"" style=""border: none;"">
                                <div class=""controle-header panel-heading panel-heading-landing"">
                                    ");
            EndContext();
            BeginContext(1343, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f3e82dc137e452287c0ba1da06ee0f1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1376, 1054, true);
            WriteLiteral(@"
                                    <h1 class=""panel-title panel-title-landing"">
                                        Google Analytics
                                    </h1>
                                </div>

                                <div class=""panel-body panel-body-landing"">
                                    <div class=""col-lg-6 col-md-6 col-xs-6"">
                                        Page
                                    </div>
                                    <div class=""col-lg-6 col-md-6 col-xs-6"">
                                        Active Users
                                    </div>
                                    <table class=""table""></table>
                                </div>
                                <div class=""panel-footer panel-footer-landing"">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        ");
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2447, 635, true);
                WriteLiteral(@" 
    <script>
        $(document).ready(function (ev) {
            $('#dashbpard-widgets').sortable({
                stop: function (event, ui) {
                    var sortedIDs = $('#dashbpard-widgets').sortable('toArray', { attribute: 'data-type' });

                    Loader.show('#fff');
                    Data.postJson({ url: '/sitetriks/dashboardconfiguration/save', data: { names: sortedIDs } }).then(function (res) {
                        Loader.hide();
                    }, Data.defaultError);
                }
            });
        });

        $('.side-nav-collapse').hide();
    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SiteTriks.Configuration.LicenseManager LicenseManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SiteTriks.Models.DashboardConfiguration.DashboardConfigurationModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
