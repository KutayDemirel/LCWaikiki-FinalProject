#pragma checksum "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "115e3949b5b5139ed724fbd1b4556f7a1c6cb385"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 2 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\_ViewImports.cshtml"
using MiniCommerce.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\_ViewImports.cshtml"
using MiniCommerce.UI.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Category\Index.cshtml"
using MiniCommerce.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115e3949b5b5139ed724fbd1b4556f7a1c6cb385", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9da8e235803d93e4611679353ce68e59e08330a", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Kategori Adı</th>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
