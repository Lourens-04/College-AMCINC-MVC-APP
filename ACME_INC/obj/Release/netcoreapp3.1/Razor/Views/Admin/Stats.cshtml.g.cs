#pragma checksum "C:\Users\loure\Desktop\ACME_INC\ACME_INC\ACME_INC\Views\Admin\Stats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "febbbe1228eacb234d547df7cc716093615ab154"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Stats), @"mvc.1.0.view", @"/Views/Admin/Stats.cshtml")]
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
#line 1 "C:\Users\loure\Desktop\ACME_INC\ACME_INC\ACME_INC\Views\_ViewImports.cshtml"
using ACME_INC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\loure\Desktop\ACME_INC\ACME_INC\ACME_INC\Views\_ViewImports.cshtml"
using ACME_INC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"febbbe1228eacb234d547df7cc716093615ab154", @"/Views/Admin/Stats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e2b2b1ee98b6f634efabb685cfc45bfa17c7ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Stats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\loure\Desktop\ACME_INC\ACME_INC\ACME_INC\Views\Admin\Stats.cshtml"
  
    ViewData["Title"] = "Stats";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 style=""text-align:center"">Catagories Sales</h2>

<div id=""pie-container"" style=""width: 550px; height: 400px; margin: 0 auto"">
</div>

<br />
<br />
<br />

<h2 style=""text-align:center"">Product Sales</h2>

<div id=""bar-container"" style=""width: 550px; height: 400px; margin: 0 auto"">
</div>

<script language=""JavaScript"">
    google.charts.load('current', {
        callback: function () {
            var sourcearray = ");
#nullable restore
#line 23 "C:\Users\loure\Desktop\ACME_INC\ACME_INC\ACME_INC\Views\Admin\Stats.cshtml"
                         Write(Html.Raw(Json.Serialize(ViewBag.ProductSales)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Products');
            data.addColumn('number', 'Sales');

            //add each element via forEach loop
            sourcearray.forEach(function (value, index, array) {
                data.addRow([
                    value.lable,
                    value.sales
                ]);
            })

            var options = {
                backgroundColor: 'transparent',
            };

            var chart = new google.charts.Bar(document.getElementById('bar-container'));
            chart.draw(data, google.charts.Bar.convertOptions(options));
        },
        packages: ['bar']
    });

    google.charts.load('current', {
        callback: function () {
            var sourcearray = ");
#nullable restore
#line 49 "C:\Users\loure\Desktop\ACME_INC\ACME_INC\ACME_INC\Views\Admin\Stats.cshtml"
                         Write(Html.Raw(Json.Serialize(ViewBag.CategorySales)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Catagories');
            data.addColumn('number', 'Sales');

            //add each element via forEach loop
            sourcearray.forEach(function (value, index, array) {
                data.addRow([
                    value.lable,
                    value.sales
                ]);
            })

            var options = {
                backgroundColor: 'transparent',
            };

            var chart = new google.visualization.PieChart(document.getElementById('pie-container'));
            chart.draw(data, options);
        },
        packages: ['corechart']
    });
</script>

");
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