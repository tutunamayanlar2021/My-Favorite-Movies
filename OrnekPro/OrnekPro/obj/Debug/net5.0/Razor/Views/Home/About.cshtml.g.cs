#pragma checksum "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c0147145cb45c746635a8f597164072af7388a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\_ViewImports.cshtml"
using OrnekPro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\_ViewImports.cshtml"
using OrnekPro.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\_ViewImports.cshtml"
using OrnekPro.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c0147145cb45c746635a8f597164072af7388a", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccd26d39bc1a2a8c0ce23398f52764c0579a75f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tur>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>HOME/ABOUT</p>\r\n\r\n");
            DefineSection("list", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
#nullable restore
#line 8 "C:\Users\AYJiPO\source\repos\OrnekPro\OrnekPro\Views\Home\About.cshtml"
Write(await Component.InvokeAsync("Turler"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tur>> Html { get; private set; }
    }
}
#pragma warning restore 1591