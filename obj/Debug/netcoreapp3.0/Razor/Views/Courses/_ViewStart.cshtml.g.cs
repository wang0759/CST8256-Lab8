#pragma checksum "C:\Users\Victor\Documents\Projects\Lab8\Views\Courses\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b522412c5be17af5004216fdd6f7054de158827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses__ViewStart), @"mvc.1.0.view", @"/Views/Courses/_ViewStart.cshtml")]
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
#line 1 "C:\Users\Victor\Documents\Projects\Lab8\Views\_ViewImports.cshtml"
using Lab5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Victor\Documents\Projects\Lab8\Views\_ViewImports.cshtml"
using Lab5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b522412c5be17af5004216fdd6f7054de158827", @"/Views/Courses/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de5c7a10af704975369c03e51a68b1f930a79786", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Victor\Documents\Projects\Lab8\Views\Courses\_ViewStart.cshtml"
  
    Layout = "_ACLayout";

    List<TopMenuItem> topMenuItems = new List<TopMenuItem>();
    topMenuItems.Add(new TopMenuItem { AspAction = "Index", AspController = "Employees", DisplayText = "Employees" });
    topMenuItems.Add(new TopMenuItem { AspAction = "Index", AspController = "Students", DisplayText = "Students" });
    topMenuItems.Add(new TopMenuItem { AspAction = "Index", AspController = "Courses", DisplayText = "Courses" });
    topMenuItems.Add(new TopMenuItem { AspAction = "Index", AspController = "AcademicRecords", DisplayText = "Academic Records" });

    ViewData["topMenu"] = topMenuItems;

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
