#pragma checksum "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3910c6f87095976833872f14f6946ce28ec556db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_ReceivedOffers), @"mvc.1.0.view", @"/Views/Accounts/ReceivedOffers.cshtml")]
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
#line 3 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\_ViewImports.cshtml"
using MiniCommerce.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\_ViewImports.cshtml"
using MiniCommerce.UI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3910c6f87095976833872f14f6946ce28ec556db", @"/Views/Accounts/ReceivedOffers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e83b677bfa2215aa980f1588ee877dc571e1f70", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_ReceivedOffers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApproveOfferViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Accounts/SubmittedOffers"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Accounts/ReceivedOffers"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            DefineSection("Header", async() => {
            }
            );
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n\r\n<div class=\"list-group\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3910c6f87095976833872f14f6946ce28ec556db4595", async() => {
                    WriteLiteral("Your Offers");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3910c6f87095976833872f14f6946ce28ec556db5826", async() => {
                    WriteLiteral("Received Offers");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</div>\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"<table class=""table table-bordered table-hover"" "">
    <thead>
        <tr>
            <th>
                Product
            </th>
            <th>
                Price
            </th>
            <th>
                Status
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"
         foreach (var item in Model.GetOffers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n");
#nullable restore
#line 40 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"
                 if(item.IsApproved == false){


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"btn-toolbar\" role=\"toolbar\">\r\n                    <div class=\"btn-group mr-2\" role=\"group\">\r\n");
#nullable restore
#line 44 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"
                         using (Html.BeginForm("Approve", "Offers", Model, FormMethod.Post)){
                           

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\" name=\"Offer.Id\"");
            BeginWriteAttribute("value", " value=\"", 1479, "\"", 1495, 1);
#nullable restore
#line 47 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"
WriteAttributeValue("", 1487, item.Id, 1487, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                        <input type=\"submit\" value=\"Approve\" asp-controller=\"Offers\" asp-action=\"Approve\"  class=\"btn btn-sm btn-outline-success \">\r\n");
#nullable restore
#line 49 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"btn-group mr-2\" role=\"group\">\r\n\r\n");
#nullable restore
#line 54 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"
                         using (Html.BeginForm("Delete", "Offers",item, FormMethod.Post))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"submit\" value=\"Refuse\" asp-controller=\"Offers\" asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1992, "\"", 2015, 1);
#nullable restore
#line 56 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"
WriteAttributeValue("", 2007, item.Id, 2007, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-danger\">\r\n");
#nullable restore
#line 57 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 60 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"

                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Product has been approved</p>\r\n");
#nullable restore
#line 63 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Accounts\ReceivedOffers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApproveOfferViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
