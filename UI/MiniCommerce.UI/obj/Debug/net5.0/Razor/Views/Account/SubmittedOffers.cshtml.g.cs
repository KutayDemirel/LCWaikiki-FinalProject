#pragma checksum "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bbebe549ed588ce4b9fb8455324c44a92070258"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SubmittedOffers), @"mvc.1.0.view", @"/Views/Account/SubmittedOffers.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#nullable restore
#line 1 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bbebe549ed588ce4b9fb8455324c44a92070258", @"/Views/Account/SubmittedOffers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e83b677bfa2215aa980f1588ee877dc571e1f70", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SubmittedOffers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApproveOfferViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/SubmittedOffers"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/ReceivedOffers"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OfferBuyProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Geri ??ek"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Offer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete btn btn-outline-danger "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Header", async() => {
                WriteLiteral("\r\n");
            }
            );
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n\r\n<div class=\"list-group\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bbebe549ed588ce4b9fb8455324c44a920702587734", async() => {
                    WriteLiteral("Yapt??????n Teklifler");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bbebe549ed588ce4b9fb8455324c44a920702588972", async() => {
                    WriteLiteral("Al??nan Teklifler");
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
            WriteLiteral(@"<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>
                ??r??n
            </th>
            <th>
                Fiyat
            </th>
            <th>
                Ne Yapmak ??stersin ?
            </th>
        </tr>
    </thead>
    <tbody>


");
#nullable restore
#line 32 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
         foreach (var item in Model.GetOffers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 35 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
                 if (Model.Products.FirstOrDefault(x => x.Id == item.ProductId).IsSold == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
                   Write(Html.DisplayFor(modelItem => Model.Products.FirstOrDefault(x => x.Id == item.ProductId).Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"btn-toolbar\" role=\"toolbar\">\r\n                            <div class=\"btn-group mr-2\" role=\"group\">\r\n");
#nullable restore
#line 46 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
                                 if (item.IsApproved is true)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bbebe549ed588ce4b9fb8455324c44a9207025812647", async() => {
                WriteLiteral("Sat??n Al");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
                                                                                                                       WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
                                                                                                                                                         WriteLiteral(item.Price);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["price"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-price", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["price"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
                                           
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"btn-group\" role=\"group\">\r\n");
#nullable restore
#line 57 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
                                 using (Html.BeginForm("Delete", "Offer", FormMethod.Post))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4bbebe549ed588ce4b9fb8455324c44a9207025816888", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
                                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n\r\n                    </td>\r\n");
#nullable restore
#line 66 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 68 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Account\SubmittedOffers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            WriteLiteral("\r\n");
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
