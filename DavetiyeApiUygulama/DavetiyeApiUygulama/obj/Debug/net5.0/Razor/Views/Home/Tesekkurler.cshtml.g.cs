#pragma checksum "C:\Users\SC-303 1\source\repos\DavetiyeApiUygulama\DavetiyeApiUygulama\Views\Home\Tesekkurler.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96c7a33492ccec53293d6124ef0f7bb3c039b404"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tesekkurler), @"mvc.1.0.view", @"/Views/Home/Tesekkurler.cshtml")]
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
#line 1 "C:\Users\SC-303 1\source\repos\DavetiyeApiUygulama\DavetiyeApiUygulama\Views\_ViewImports.cshtml"
using DavetiyeApiUygulama;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SC-303 1\source\repos\DavetiyeApiUygulama\DavetiyeApiUygulama\Views\_ViewImports.cshtml"
using DavetiyeApiUygulama.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96c7a33492ccec53293d6124ef0f7bb3c039b404", @"/Views/Home/Tesekkurler.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1177e0788043d69be809c10accf57afb9962f5d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tesekkurler : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DavetiyeApiUygulama.Models.Davetiye>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SC-303 1\source\repos\DavetiyeApiUygulama\DavetiyeApiUygulama\Views\Home\Tesekkurler.cshtml"
   
    ViewData["Title"] = "Tesekkurler";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Teşekkürler,");
#nullable restore
#line 5 "C:\Users\SC-303 1\source\repos\DavetiyeApiUygulama\DavetiyeApiUygulama\Views\Home\Tesekkurler.cshtml"
           Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div>\r\n");
#nullable restore
#line 7 "C:\Users\SC-303 1\source\repos\DavetiyeApiUygulama\DavetiyeApiUygulama\Views\Home\Tesekkurler.cshtml"
     if (Model.KatilimaDurumu == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("Gelmene çok sevindim :)\r\n");
#nullable restore
#line 10 "C:\Users\SC-303 1\source\repos\DavetiyeApiUygulama\DavetiyeApiUygulama\Views\Home\Tesekkurler.cshtml"
   Write(Html.ActionLink("Katılılanlar", "GetAllDavetiye", "Home"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SC-303 1\source\repos\DavetiyeApiUygulama\DavetiyeApiUygulama\Views\Home\Tesekkurler.cshtml"
                                                                  
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("Gelmeyecek olana üzüldüm...\r\n");
#nullable restore
#line 15 "C:\Users\SC-303 1\source\repos\DavetiyeApiUygulama\DavetiyeApiUygulama\Views\Home\Tesekkurler.cshtml"
   Write(Html.ActionLink("Davetliler", "Liste", "Home"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\SC-303 1\source\repos\DavetiyeApiUygulama\DavetiyeApiUygulama\Views\Home\Tesekkurler.cshtml"
                                                       
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DavetiyeApiUygulama.Models.Davetiye> Html { get; private set; }
    }
}
#pragma warning restore 1591
