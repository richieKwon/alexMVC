#pragma checksum "/Users/richie/RiderProjects/alexMVC/bluepopes/Views/Home/Test4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e6f6857ee3fd0fea0d5b6aeb34d9b3b6f41b6c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test4), @"mvc.1.0.view", @"/Views/Home/Test4.cshtml")]
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
#line 1 "/Users/richie/RiderProjects/alexMVC/bluepopes/Views/_ViewImports.cshtml"
using bluepopes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/richie/RiderProjects/alexMVC/bluepopes/Views/_ViewImports.cshtml"
using bluepopes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e6f6857ee3fd0fea0d5b6aeb34d9b3b6f41b6c9", @"/Views/Home/Test4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59d1fca192fe8ecaeea32f42357ba04a542ecdb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Test4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/richie/RiderProjects/alexMVC/bluepopes/Views/Home/Test4.cshtml"
  
    var x = ViewData["x"] as string;
    var y = ViewBag.y;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    This is a test page.\n</div>\n\n<div>\n    <table class=\"table table-bordered\">\n        <thead>\n        <tr>\n            <th>X</th>\n            <th>Y</th>\n        </tr>\n        </thead>\n        <tbody>\n        <tr>\n            <td>");
#nullable restore
#line 19 "/Users/richie/RiderProjects/alexMVC/bluepopes/Views/Home/Test4.cshtml"
           Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 22 "/Users/richie/RiderProjects/alexMVC/bluepopes/Views/Home/Test4.cshtml"
           Write(y);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        </tbody>\n    </table>\n</div>");
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
