#pragma checksum "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca98615dc532dcec59f0ea574be16a45bb23e513"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home__OrderAverageReport), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/_OrderAverageReport.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 7 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca98615dc532dcec59f0ea574be16a45bb23e513", @"/Areas/Admin/Views/Home/_OrderAverageReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9afeeb77ddd3a4a2e0698ab1d31f0fa32cb5e81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home__OrderAverageReport : Nop.Web.Framework.Mvc.Razor.NopRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
  
    const string panelId = "order-average-report-box";
    const string hidePanelAttributeName = "Reports.HideOrderAverageReportPanel";
    var hidePanel = genericAttributeService.GetAttribute<bool>(workContext.CurrentCustomer, hidePanelAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 381, "\"", 444, 3);
            WriteAttributeValue("", 389, "box", 389, 3, true);
            WriteAttributeValue(" ", 392, "box-info", 393, 9, true);
            WriteAttributeValue(" ", 401, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 9 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
                          if(hidePanel){

#line default
#line hidden
#nullable disable
                WriteLiteral("collapsed-box");
#nullable restore
#line 9 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
                                                                  }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 402, 42, false);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 445, "\"", 458, 1);
#nullable restore
#line 9 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
WriteAttributeValue("", 450, panelId, 450, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"box-header with-border\">\r\n        <h3 class=\"box-title\">\r\n            <i class=\"fa fa-money\"></i>\r\n            ");
#nullable restore
#line 13 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
       Write(T("Admin.SalesReport.Average"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n        <div class=\"box-tools pull-right\">\r\n            <button class=\"btn btn-box-tool\" data-widget=\"collapse\">\r\n");
#nullable restore
#line 17 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
                 if (hidePanel)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fa fa-plus\"></i>");
#nullable restore
#line 19 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
                                                           
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fa fa-minus\"></i>");
#nullable restore
#line 23 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
                                                            
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </button>\r\n        </div>\r\n    </div>\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#");
#nullable restore
#line 30 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
           Write(panelId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').on(\'click\', \'button[data-widget=\"collapse\"]\', function () {\r\n                var collapsed = !$(\'#");
#nullable restore
#line 31 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
                                Write(panelId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').hasClass(\'collapsed-box\');\r\n                saveUserPreferences(\'");
#nullable restore
#line 32 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
                                 Write(Url.Action("SavePreference", "Preferences"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 32 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
                                                                                  Write(hidePanelAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', collapsed);\r\n            });\r\n        });\r\n    </script>\r\n    <div class=\"box-body\" style=\"padding-bottom: 22px;\">\r\n        ");
#nullable restore
#line 37 "E:\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\Home\_OrderAverageReport.cshtml"
   Write(await Html.PartialAsync("Table", new DataTablesModel
        {
            Name = "average-order-report-grid",
            UrlRead = new DataUrl("OrderAverageReportList", "Order", null),
            Length = int.MaxValue,
            Paging = false,
            Info = false,
            ColumnCollection = new List<ColumnProperty>
            {
                new ColumnProperty(nameof(OrderAverageReportModel.OrderStatus))
                {
                    Title = T("Admin.SalesReport.Average.OrderStatus").Text
                },
                new ColumnProperty(nameof(OrderAverageReportModel.SumTodayOrders))
                {
                    Title = T("Admin.SalesReport.Average.SumTodayOrders").Text
                },
                new ColumnProperty(nameof(OrderAverageReportModel.SumThisWeekOrders))
                {
                    Title = T("Admin.SalesReport.Average.SumThisWeekOrders").Text
                },
                new ColumnProperty(nameof(OrderAverageReportModel.SumThisMonthOrders))
                {
                    Title = T("Admin.SalesReport.Average.SumThisMonthOrders").Text
                },
                new ColumnProperty(nameof(OrderAverageReportModel.SumThisYearOrders))
                {
                    Title = T("Admin.SalesReport.Average.SumThisYearOrders").Text
                },
                new ColumnProperty(nameof(OrderAverageReportModel.SumAllTimeOrders))
                {
                    Title = T("Admin.SalesReport.Average.SumAllTimeOrders").Text
                }
            }
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Common.IGenericAttributeService genericAttributeService { get; private set; }
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
