#pragma checksum "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\ECommerse\Views\StoreManager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eecc69a04e86509f80f6f60680d26f551774146"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ECommerse_Views_StoreManager_Index), @"mvc.1.0.view", @"/Areas/ECommerse/Views/StoreManager/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ECommerse/Views/StoreManager/Index.cshtml", typeof(AspNetCore.Areas_ECommerse_Views_StoreManager_Index))]
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
#line 1 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\ECommerse\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\ECommerse\Views\_ViewImports.cshtml"
using SiteTriksApp.Web;

#line default
#line hidden
#line 3 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\ECommerse\Views\_ViewImports.cshtml"
using SiteTriksApp.Web.Models;

#line default
#line hidden
#line 4 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\ECommerse\Views\_ViewImports.cshtml"
using SiteTriksApp.Web.Models.AccountViewModels;

#line default
#line hidden
#line 5 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\ECommerse\Views\_ViewImports.cshtml"
using SiteTriksApp.Web.Models.ManageViewModels;

#line default
#line hidden
#line 7 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\ECommerse\Views\_ViewImports.cshtml"
using SiteTriks.Infrastructure.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eecc69a04e86509f80f6f60680d26f551774146", @"/Areas/ECommerse/Views/StoreManager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37c59baa2c2423197145f0831249231c41dbc78d", @"/Areas/ECommerse/Views/_ViewImports.cshtml")]
    public class Areas_ECommerse_Views_StoreManager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\ECommerse\Views\StoreManager\Index.cshtml"
  
    ViewBag.Title = "Stores";

#line default
#line hidden
            BeginContext(38, 33, true);
            WriteLiteral("\r\n<div class=\"fixed-top-2\">\r\n    ");
            EndContext();
            BeginContext(72, 80, false);
#line 6 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\ECommerse\Views\StoreManager\Index.cshtml"
Write(await Html.PartialAsync("~/Areas/SiteTriks/Views/Shared/SecondNavHeader.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(152, 8, true);
            WriteLiteral("\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 160, "\"", 188, 1);
#line 7 "E:\Kaloyan\Projects\AlphaPreview0001\Deploy\Sitetriks-CMS\SiteTriksApp\SiteTriksApp.Web\Areas\ECommerse\Views\StoreManager\Index.cshtml"
WriteAttributeValue("", 167, Url.Action("Create"), 167, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(189, 194, true);
            WriteLiteral(" class=\"btn-nav-2\"><span class=\"glyphicon glyphicon-plus\"></span>Create Store</a>\r\n</div>\r\n\r\n<div class=\"backend-wrapper\">\r\n    <h1>Store Manager</h1>\r\n    <div class=\"grid\"></div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(400, 1675, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        var grid = Grid();
        var data = { link: '/ecommerse/storemanager/grid', serverSide: false };
        var columns = [{
            name: 'id',
            title: '',
            type: 'checkbox',
            size: 1
        },
        {
            name: 'title',
            title: 'Title',
            type: 'string',
            filter: true,
            sort: true,
            extraFields: ['id'],
            size: 2,
            headerTemplate: '<b>#item#</b>', // #item# is the placeholder for the content
            contentTemplate: '<a href=""/ecommerse/storemanager/details?id=#item0#"">#item#</a>'
        },
        {
            name: 'url',
            title: 'Url',
            type: 'string',
            filter: true,
            sort: true,
            size: 2,
            contentTemplate: '<span class=""text-danger"">#item#</span>',
            headerTemplate: '<b>#item#</b>'
        },
        {
            name: 'id',");
                WriteLiteral(@"
            title: '',
            type: 'string',
            filter: true,
            sort: true,
            size: 2,
            headerTemplate: '<b>#item#</b>', // #item# is the placeholder for the content
            contentTemplate: '<a class=""btn btn-sm btn-backend"" href=""/ecommerse/storemanager/displaystore?id=#item#"">Display</a>'
        }];

        let buttons = [{
            title: 'Delete',
            postUrl: '/ecommerse/storemanager/delete',
            type: 'danger'
        }];

        var config = grid.build(columns, buttons, grid.defaultPager, data);
        grid.init('.grid', config);
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
