#pragma checksum "C:\Users\loure\Desktop\ACME_INC\ACME_INC\ACME_INC\Views\LogInAndSignUp\LogIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31185a5d0ce93a265bddbccaba0ab12f067d4e01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LogInAndSignUp_LogIn), @"mvc.1.0.view", @"/Views/LogInAndSignUp/LogIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31185a5d0ce93a265bddbccaba0ab12f067d4e01", @"/Views/LogInAndSignUp/LogIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e2b2b1ee98b6f634efabb685cfc45bfa17c7ce", @"/Views/_ViewImports.cshtml")]
    public class Views_LogInAndSignUp_LogIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/LogInAndSignUp/LogIn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\loure\Desktop\ACME_INC\ACME_INC\ACME_INC\Views\LogInAndSignUp\LogIn.cshtml"
  
    ViewBag.Title = "LogIn";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>LogIn</h2>\r\n\r\n<span style=\"color:red\"> ");
#nullable restore
#line 8 "C:\Users\loure\Desktop\ACME_INC\ACME_INC\ACME_INC\Views\LogInAndSignUp\LogIn.cshtml"
                    Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31185a5d0ce93a265bddbccaba0ab12f067d4e014433", async() => {
                WriteLiteral("\r\n    <table style=\"width:50%\">\r\n        <tr style=\"height:40px\">\r\n            <td>Username</td>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\loure\Desktop\ACME_INC\ACME_INC\ACME_INC\Views\LogInAndSignUp\LogIn.cshtml"
           Write(Html.TextBox("tbxUserEmail", null, new { @class = "form-control", @Style = "background-color:whitesmoke" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>&nbsp</td>\r\n        </tr>\r\n        <tr style=\"height:40px\">\r\n            <td>Password</td>\r\n            <td> ");
#nullable restore
#line 18 "C:\Users\loure\Desktop\ACME_INC\ACME_INC\ACME_INC\Views\LogInAndSignUp\LogIn.cshtml"
            Write(Html.Password("tbxUserPassword", null, new { @class = "form-control", @Style = "background-color:whitesmoke" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </td>
            <td>&nbsp</td>
        </tr>
        <tr style=""height:40px"">
            <td>&nbsp</td>
            <td> <input id=""btnSubmit"" type=""submit"" value=""Log In"" class=""btn btn-default"" style=""background-color:whitesmoke"" /> </td>
            <td>&nbsp</td>
        </tr>
    </table>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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