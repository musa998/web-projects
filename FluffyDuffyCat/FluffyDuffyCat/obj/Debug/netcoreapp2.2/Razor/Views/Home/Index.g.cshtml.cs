#pragma checksum "D:\My projects\.Net Core\FluffyDuffyCat\FluffyDuffyCat\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8a6e827530bd15856e9a575a5448e690975c4ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\My projects\.Net Core\FluffyDuffyCat\FluffyDuffyCat\Views\_ViewImports.cshtml"
using FluffyDuffyCat;

#line default
#line hidden
#line 2 "D:\My projects\.Net Core\FluffyDuffyCat\FluffyDuffyCat\Views\_ViewImports.cshtml"
using FluffyDuffyCat.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8a6e827530bd15856e9a575a5448e690975c4ef", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1cf8059ce59af784e5c7066111ddaf04f4fd9c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CatViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\My projects\.Net Core\FluffyDuffyCat\FluffyDuffyCat\Views\Home\Index.cshtml"
  
    Layout = "_Layout";
    var title = "READ Cats";
    ViewData["Title"] = title;

#line default
#line hidden
            BeginContext(130, 9, true);
            WriteLiteral("<tbody>\r\n");
            EndContext();
#line 9 "D:\My projects\.Net Core\FluffyDuffyCat\FluffyDuffyCat\Views\Home\Index.cshtml"
     if (Model == null)
    {

#line default
#line hidden
            BeginContext(171, 97, true);
            WriteLiteral("        <tr>\r\n            <td colspan=\"7\" class=\"text-center\">No Model Data</td>\r\n        </tr>\r\n");
            EndContext();
#line 14 "D:\My projects\.Net Core\FluffyDuffyCat\FluffyDuffyCat\Views\Home\Index.cshtml"
    }
    else
    {
        

#line default
#line hidden
#line 17 "D:\My projects\.Net Core\FluffyDuffyCat\FluffyDuffyCat\Views\Home\Index.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
            BeginContext(338, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 352, "\"", 409, 1);
#line 19 "D:\My projects\.Net Core\FluffyDuffyCat\FluffyDuffyCat\Views\Home\Index.cshtml"
WriteAttributeValue("", 359, Url.Action("Details", "Cat", new { id = p.CatId}), 359, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(410, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(412, 36, false);
#line 19 "D:\My projects\.Net Core\FluffyDuffyCat\FluffyDuffyCat\Views\Home\Index.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => p.Name));

#line default
#line hidden
            EndContext();
            BeginContext(448, 27, true);
            WriteLiteral("</a>\r\n            <p></p>\r\n");
            EndContext();
#line 21 "D:\My projects\.Net Core\FluffyDuffyCat\FluffyDuffyCat\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#line 21 "D:\My projects\.Net Core\FluffyDuffyCat\FluffyDuffyCat\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(493, 35, true);
            WriteLiteral("</tbody>\r\n<a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 528, "\"", 563, 1);
#line 24 "D:\My projects\.Net Core\FluffyDuffyCat\FluffyDuffyCat\Views\Home\Index.cshtml"
WriteAttributeValue("", 535, Url.Action("Create", "Cat"), 535, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(564, 14, true);
            WriteLiteral(">Add Cat</a>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CatViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591