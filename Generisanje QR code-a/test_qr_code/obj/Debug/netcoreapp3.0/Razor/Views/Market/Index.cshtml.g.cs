#pragma checksum "D:\Fakultet\Diplomski rad\Generisanje QR code-a\test_qr_code\Views\Market\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19814a411c9c9c9241479105e5ec7615e39c32a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Market_Index), @"mvc.1.0.view", @"/Views/Market/Index.cshtml")]
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
#line 1 "D:\Fakultet\Diplomski rad\Generisanje QR code-a\test_qr_code\Views\_ViewImports.cshtml"
using test_qr_code;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Fakultet\Diplomski rad\Generisanje QR code-a\test_qr_code\Views\_ViewImports.cshtml"
using test_qr_code.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19814a411c9c9c9241479105e5ec7615e39c32a0", @"/Views/Market/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77171347463f9e7343a01d0b96c70d3a804e9b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Market_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Fakultet\Diplomski rad\Generisanje QR code-a\test_qr_code\Views\Market\Index.cshtml"
  
    Market tmp = (Market)ViewData["test"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
#nullable restore
#line 8 "D:\Fakultet\Diplomski rad\Generisanje QR code-a\test_qr_code\Views\Market\Index.cshtml"
Write(tmp.MarketID);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n");
#nullable restore
#line 9 "D:\Fakultet\Diplomski rad\Generisanje QR code-a\test_qr_code\Views\Market\Index.cshtml"
Write(tmp.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\nUspješno obavljeno");
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