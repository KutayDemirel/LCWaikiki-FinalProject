#pragma checksum "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a2d9f898091bf26efb23074db36772365ffada5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
using MiniCommerce.UI.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a2d9f898091bf26efb23074db36772365ffada5", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e83b677bfa2215aa980f1588ee877dc571e1f70", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:250px; height:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Make", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Offers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ürün Detayları</h1>\r\n");
            WriteLiteral(@"<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>Resim</th>
            <th>
                Ürün
            </th>
            <th>
                Açıklama
            </th>
            <th>
                Marka
            </th>
            <th>
                Renk
            </th>
            <th>
                Kullanım Durumu
            </th>
            <th>
                Fiyat
            </th>
            <th>
                Ne yapmak istersin ?
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a2d9f898091bf26efb23074db36772365ffada56229", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 816, "~/images/", 816, 9, true);
#nullable restore
#line 41 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 825, Model.ImageUrl, 825, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <p >");
#nullable restore
#line 44 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 47 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 50 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
              Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 53 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
              Write(Model.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 56 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
              Write(Model.Usage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
#nullable restore
#line 59 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
              Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 62 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
                 if (@Model.IsSold == false)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-success mb-3\" data-toggle=\"modal\" data-target=\"#popUp\">Satın Al</button>\r\n");
#nullable restore
#line 67 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
                     using (Html.BeginForm("BuyProduct", "Product", Model, FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div id=""popUp"" class=""modal"" tabindex=""-1"" role=""dialog"">
                            <div class=""modal-dialog"" role=""document"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <h5 class=""modal-title"">Almak istiyor musun ?</h5>
                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                            <span aria-hidden=""true"">&times;</span>
                                        </button>
                                    </div>
                                    <div class=""modal-body"">
                                        <div class=""form-group"">
                                            <label>Ürün:</label>
                                            <p><strong>");
#nullable restore
#line 81 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
                                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></p>
                                        </div>
                                    </div>
                                    <div class=""modal-footer"">
                                        <button type=""submit"" class=""btn btn-primary"">Evet</button>
                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hayır</button>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 91 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a2d9f898091bf26efb23074db36772365ffada512694", async() => {
                WriteLiteral("Teklif Ver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
                                                                                                                      WriteLiteral(Model.Id);

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
#line 96 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
                               
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"alert-warning\">Bu ürün satışta değil</p>\r\n");
#nullable restore
#line 101 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Product\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
