#pragma checksum "C:\Users\msousadapenha\source\repos\HelloWorldGitVersion\HelloWorldGitVersion\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f53ffbb7485f76a4ce2afdc64f52c33f3ea7e47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\msousadapenha\source\repos\HelloWorldGitVersion\HelloWorldGitVersion\Views\_ViewImports.cshtml"
using HelloWorldGitVersion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msousadapenha\source\repos\HelloWorldGitVersion\HelloWorldGitVersion\Views\_ViewImports.cshtml"
using HelloWorldGitVersion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f53ffbb7485f76a4ce2afdc64f52c33f3ea7e47", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"957251b727f048d78b14ae93ac00851172fe7517", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\msousadapenha\source\repos\HelloWorldGitVersion\HelloWorldGitVersion\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">\r\n        Bem Vindo!\r\n    </h1>\r\n");
#nullable restore
#line 9 "C:\Users\msousadapenha\source\repos\HelloWorldGitVersion\HelloWorldGitVersion\Views\Home\Index.cshtml"
      
        SemanticVersion semanticVersion = ViewBag.SemanticVersion;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Version: ");
#nullable restore
#line 12 "C:\Users\msousadapenha\source\repos\HelloWorldGitVersion\HelloWorldGitVersion\Views\Home\Index.cshtml"
               Write(semanticVersion.VersionNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
            WriteLiteral("    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
