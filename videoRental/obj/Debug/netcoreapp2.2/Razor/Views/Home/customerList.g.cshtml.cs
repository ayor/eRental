#pragma checksum "C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\Views\Home\customerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20e337e94c02024a5943584aa3222dfe324f2e0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_customerList), @"mvc.1.0.view", @"/Views/Home/customerList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/customerList.cshtml", typeof(AspNetCore.Views_Home_customerList))]
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
#line 1 "C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\Views\_ViewImports.cshtml"
using videoRental;

#line default
#line hidden
#line 2 "C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\Views\_ViewImports.cshtml"
using videoRental.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e337e94c02024a5943584aa3222dfe324f2e0f", @"/Views/Home/customerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e23dc2c17722b0bfb5d590a236ac94ef5f43e10c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_customerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CustomerModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\Views\Home\customerList.cshtml"
  
    ViewData["Title"] = "List of Customers";

#line default
#line hidden
            BeginContext(176, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(213, 499, true);
            WriteLiteral(@"
<style>
    table {
        width: 100%;
    }

    th {
        height: 50px;
        text-align: center;
    }

    td {
        vertical-align: middle;
    }

    thead :hover, tbody :hover {
        background-color: #f2f2f2;
    }

    td, th {
        padding: 15px;
        border-bottom: 1px solid #ddd;
    }
    /*tr :nth-child(even){
        background-color:#f2f2f2;
    }*/
    thead {
        background-color: rgba(20, 20, 200, 0.5);
    }
</style>
<h3>");
            EndContext();
            BeginContext(712, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20e337e94c02024a5943584aa3222dfe324f2e0f5697", async() => {
                BeginContext(767, 15, true);
                WriteLiteral("Create Customer");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(786, 258, true);
            WriteLiteral(@"</h3>
<div class=""text-center"">
    <table>
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Address</th>
                <th>X</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 51 "C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\Views\Home\customerList.cshtml"
             foreach (CustomerModel customer in Model)
            {


#line default
#line hidden
            BeginContext(1117, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1164, 11, false);
#line 55 "C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\Views\Home\customerList.cshtml"
                   Write(customer.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1233, 21, false);
#line 57 "C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\Views\Home\customerList.cshtml"
                   Write(customer.customerName);

#line default
#line hidden
            EndContext();
            BeginContext(1254, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1334, 16, false);
#line 60 "C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\Views\Home\customerList.cshtml"
                   Write(customer.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1350, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1429, 185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20e337e94c02024a5943584aa3222dfe324f2e0f9064", async() => {
                BeginContext(1505, 102, true);
                WriteLiteral("\r\n                            <button class=\"btn btn-danger\">Delete</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\Views\Home\customerList.cshtml"
                                                                          WriteLiteral(customer.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1614, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 68 "C:\Users\DOSUMU AYOMIDE\source\repos\videoRental\videoRental\Views\Home\customerList.cshtml"
            }

#line default
#line hidden
            BeginContext(1681, 46, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CustomerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
