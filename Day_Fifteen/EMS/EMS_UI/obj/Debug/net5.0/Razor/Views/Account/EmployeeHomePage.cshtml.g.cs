#pragma checksum "D:\proj\EMS\EMS_UI\Views\Account\EmployeeHomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bfe60760d8fe612ffd1e0260ca3612e91ecf694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_EmployeeHomePage), @"mvc.1.0.view", @"/Views/Account/EmployeeHomePage.cshtml")]
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
#line 1 "D:\proj\EMS\EMS_UI\Views\_ViewImports.cshtml"
using EMS_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\proj\EMS\EMS_UI\Views\_ViewImports.cshtml"
using EMS_UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\proj\EMS\EMS_UI\Views\Account\EmployeeHomePage.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bfe60760d8fe612ffd1e0260ca3612e91ecf694", @"/Views/Account/EmployeeHomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c600ea6dd6116499ae5c917349c222be5839b60b", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_EmployeeHomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\proj\EMS\EMS_UI\Views\Account\EmployeeHomePage.cshtml"
  
    ViewData["Title"] = "EmployeeHomePage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>EmployeeHomePage</h1>\r\n<h2>Hello ");
#nullable restore
#line 9 "D:\proj\EMS\EMS_UI\Views\Account\EmployeeHomePage.cshtml"
     Write(HttpContextAccessor.HttpContext.Session.GetString("username"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
