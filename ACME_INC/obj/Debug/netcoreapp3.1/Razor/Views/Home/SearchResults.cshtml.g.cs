#pragma checksum "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b00f76e3fac91a5fd3d6794c1f7b3f8aeb77fe31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchResults), @"mvc.1.0.view", @"/Views/Home/SearchResults.cshtml")]
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
#line 1 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\_ViewImports.cshtml"
using ACME_INC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\_ViewImports.cshtml"
using ACME_INC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b00f76e3fac91a5fd3d6794c1f7b3f8aeb77fe31", @"/Views/Home/SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e2b2b1ee98b6f634efabb685cfc45bfa17c7ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LogInAndSignUp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .card {
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        max-width: 1000px;
        margin: 20px;
        text-align: center;
        float: left;
        max-height: 1000px;
        border-radius: 10px 10px 10px 10px;
    }
</style>

");
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml"
  
    var uToken = HttpContextAccessor.HttpContext.Request.Cookies["UserToken"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml"
  
    string s = "";
    foreach (var item in ViewBag.SearchText)
    {
        s = s + item;
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Search Results for ");
#nullable restore
#line 26 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml"
                      Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml"
 foreach (var item in ViewBag.SearchProducts)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <p></p>\r\n\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 692, "\"", 719, 1);
#nullable restore
#line 34 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml"
WriteAttributeValue("", 698, item.ProductImageURL, 698, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"180\" width=\"340\" />\r\n\r\n        <h1>");
#nullable restore
#line 36 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml"
       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n        <p> R ");
#nullable restore
#line 38 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml"
         Write(Math.Round(Convert.ToDouble(item.ProductPrice), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 40 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml"
         if (uToken != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b00f76e3fac91a5fd3d6794c1f7b3f8aeb77fe317440", async() => {
                WriteLiteral("View Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml"
                                          WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b00f76e3fac91a5fd3d6794c1f7b3f8aeb77fe319985", async() => {
                WriteLiteral("Log in to purchase items");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p></p>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\loure\Desktop\17229570_PROG7311_POE\17229570_PROG7311_POE\17229570_PROG7311_Task2\ACME_INC\ACME_INC\ACME_INC\Views\Home\SearchResults.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"clear: left\">\r\n\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
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
