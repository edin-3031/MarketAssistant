#pragma checksum "C:\Users\Edin\Desktop\Diplomski rad\test_qr_code\test_qr_code\Views\QR\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ca43ecd48ac2930bae64a0e2bb740ac238f9ff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QR_Index), @"mvc.1.0.view", @"/Views/QR/Index.cshtml")]
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
#line 1 "C:\Users\Edin\Desktop\Diplomski rad\test_qr_code\test_qr_code\Views\_ViewImports.cshtml"
using test_qr_code;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Edin\Desktop\Diplomski rad\test_qr_code\test_qr_code\Views\_ViewImports.cshtml"
using test_qr_code.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca43ecd48ac2930bae64a0e2bb740ac238f9ff1", @"/Views/QR/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77171347463f9e7343a01d0b96c70d3a804e9b74", @"/Views/_ViewImports.cshtml")]
    public class Views_QR_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Edin\Desktop\Diplomski rad\test_qr_code\test_qr_code\Views\QR\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<h1>QR Code</h1>\r\n<img");
            BeginWriteAttribute("src", " src=\'", 83, "\'", 109, 1);
#nullable restore
#line 8 "C:\Users\Edin\Desktop\Diplomski rad\test_qr_code\test_qr_code\Views\QR\Index.cshtml"
WriteAttributeValue("", 89, Url.Action("image"), 89, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 110, "\"", 116, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 9 "C:\Users\Edin\Desktop\Diplomski rad\test_qr_code\test_qr_code\Views\QR\Index.cshtml"
Write(Url.PageLink());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        alert(\'ViewBag.image\');\r\n    });\r\n</script>");
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
