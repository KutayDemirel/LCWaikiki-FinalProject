#pragma checksum "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Shared\_ClientSideMessagePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f53d2a114def299504f4675c9bb0050587d24e4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ClientSideMessagePartial), @"mvc.1.0.view", @"/Views/Shared/_ClientSideMessagePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f53d2a114def299504f4675c9bb0050587d24e4c", @"/Views/Shared/_ClientSideMessagePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9da8e235803d93e4611679353ce68e59e08330a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ClientSideMessagePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Shared\_ClientSideMessagePartial.cshtml"
  
    if (TempData["Message"] != null)
    {
        var messageObj = Newtonsoft.Json.JsonConvert.DeserializeObject<JResult>(TempData["Message"].ToString());

        if (messageObj.Status == Status.Ok)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script>$.ShowSuccess(\'");
#nullable restore
#line 8 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Shared\_ClientSideMessagePartial.cshtml"
                              Write(Html.Raw(messageObj.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\'");
#nullable restore
#line 8 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Shared\_ClientSideMessagePartial.cshtml"
                                                            Write(Html.Raw(messageObj.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\')</script>\r\n");
#nullable restore
#line 9 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Shared\_ClientSideMessagePartial.cshtml"

        }
        else if (messageObj.Status == Status.Error)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script>$.ShowError(\'");
#nullable restore
#line 13 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Shared\_ClientSideMessagePartial.cshtml"
                            Write(Html.Raw(messageObj.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\'");
#nullable restore
#line 13 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Shared\_ClientSideMessagePartial.cshtml"
                                                          Write(Html.Raw(messageObj.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\')</script>\r\n");
#nullable restore
#line 14 "C:\Users\ktyde\Desktop\LCW Projeler\MiniCommerce\MiniCommerce\UI\MiniCommerce.UI\Views\Shared\_ClientSideMessagePartial.cshtml"
        }

    }


#line default
#line hidden
#nullable disable
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