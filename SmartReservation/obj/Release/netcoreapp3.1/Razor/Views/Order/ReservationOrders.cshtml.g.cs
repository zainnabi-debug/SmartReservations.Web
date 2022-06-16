#pragma checksum "C:\Users\zaino\Documents\Visual Studio 2019\Projects\SmartReservation\SmartReservation\Views\Order\ReservationOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f588f87666a4a05e6d852e90b9dc590562a19f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ReservationOrders), @"mvc.1.0.view", @"/Views/Order/ReservationOrders.cshtml")]
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
#nullable restore
#line 1 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\SmartReservation\SmartReservation\Views\_ViewImports.cshtml"
using SmartReservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\SmartReservation\SmartReservation\Views\_ViewImports.cshtml"
using SmartReservation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f588f87666a4a05e6d852e90b9dc590562a19f6", @"/Views/Order/ReservationOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f004aab76d2bdcda1a240deaf080d712866ff5de", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_ReservationOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartReservation.Model.Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\SmartReservation\SmartReservation\Views\Order\ReservationOrders.cshtml"
  
    ViewData["Title"] = "Order Items";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- ========== MAIN ========== -->
<main id=""content"" role=""main"" class=""main"">
    <!-- Content -->
    <div class=""content container-fluid"">
        <!-- Page Header -->
        <div class=""page-header"">
            <div class=""row align-items-end"">
                <div class=""col-sm mb-2 mb-sm-0"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb breadcrumb-no-gutter"">
                            <li class=""breadcrumb-item""><a class=""breadcrumb-link"" href=""javascript:;"">Orders</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Current</li>
                        </ol>
                    </nav>

                    <h1 class=""page-header-title"">Purchased Orders</h1>
                </div>
            </div>
            <!-- End Row -->
        </div>
        <!-- End Page Header -->
    </div>
    <div class=""content container-fluid my-n9"">
        <div class=""row"">
");
#nullable restore
#line 32 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\SmartReservation\SmartReservation\Views\Order\ReservationOrders.cshtml"
             foreach (var item in Model.OrderBy(model => model.CreatedOn))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"stickyBlockStartPoint\" class=\"col-lg-4 mb-3 mb-lg-0\"");
            BeginWriteAttribute("style", " style=\"", 1311, "\"", 1319, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""js-sticky-block"" data-hs-sticky-block-options=""{
                   &quot;parentSelector&quot;: &quot;#stickyBlockStartPoint&quot;,
                   &quot;breakpoint&quot;: &quot;lg&quot;,
                   &quot;startPoint&quot;: &quot;#stickyBlockStartPoint&quot;,
                   &quot;endPoint&quot;: &quot;#stickyBlockEndPoint&quot;,
                   &quot;stickyOffsetTop&quot;: 20
                 }""");
            BeginWriteAttribute("style", " style=\"", 1776, "\"", 1784, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                        <!-- End Row -->


                    <div class=""card h-100"">
                            <!-- Header -->
                        <div class=""card-header"" style=""background-color:gold"">
                                <h5 class=""card-header-title"">Quantity: <span class=""badge bg-soft-sucess text-sucess"">");
#nullable restore
#line 49 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\SmartReservation\SmartReservation\Views\Order\ReservationOrders.cshtml"
                                                                                                                  Write(item.Plates);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h5>
                            </div>
                            <!-- End Header -->
                            <!-- Body -->
                        <div class=""card-body"" style=""background-color:mintcream"">
                                <dl class=""row"">
                                    <dt class=""col-sm-3"">Item</dt>
                                    <dd class=""col-sm-9"">");
#nullable restore
#line 56 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\SmartReservation\SmartReservation\Views\Order\ReservationOrders.cshtml"
                                                    Write(item.Item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                </dl>\r\n                            </div>\r\n                            <!-- End Body -->\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 63 "C:\Users\zaino\Documents\Visual Studio 2019\Projects\SmartReservation\SmartReservation\Views\Order\ReservationOrders.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</main>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartReservation.Model.Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
