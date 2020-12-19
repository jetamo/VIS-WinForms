#pragma checksum "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c4410c3e42ee7d74df0f171e46f0d55aa6daef7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BookList), @"mvc.1.0.view", @"/Views/Home/BookList.cshtml")]
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
#line 1 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml"
using DomainLayer.ActiveRecord;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c4410c3e42ee7d74df0f171e46f0d55aa6daef7", @"/Views/Home/BookList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BookList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml"
  
    ViewData["Title"] = "Knihovna";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table border=\"1\">\r\n    <tr>\r\n        <td><b>Nazev</b></td>\r\n        <td><b>Jmeno autora</b></td>\r\n        <td><b>Zanr</b></td>\r\n        <td><b>Skladem</b></td>\r\n        <td><b>Rezervovat</b></td>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml"
     foreach (BookActiveRecord book in ViewBag.Books)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml"
           Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml"
           Write(book.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml"
                             Write(book.Author.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml"
           Write(book.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml"
           Write(book.Available);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml"
             if (book.Available <= 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>NErezervovat</td>\r\n");
#nullable restore
#line 25 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>rezervovat</td>\r\n");
#nullable restore
#line 29 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 31 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\BookList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
