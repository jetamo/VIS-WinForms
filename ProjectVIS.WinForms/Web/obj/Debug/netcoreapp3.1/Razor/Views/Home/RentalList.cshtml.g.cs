#pragma checksum "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fffaa1fc3296f46a56d5273ed1c1b86a3493ef61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RentalList), @"mvc.1.0.view", @"/Views/Home/RentalList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
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
#line 1 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
using DomainLayer.ActiveRecord;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fffaa1fc3296f46a56d5273ed1c1b86a3493ef61", @"/Views/Home/RentalList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RentalList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
  
    ViewData["Title"] = "Knihovna";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
 foreach (KeyValuePair<RentalActiveRecord, List<BookActiveRecord>> rental in ViewBag.Rentals)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <table border=\"1\">\r\n            <tr>\r\n                <td><b>Datum vypujcky</b></td>\r\n            </tr>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
               Write(rental.Key.RentalDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b>Nazev</b></td>\r\n                <td><b>Jmeno autora</b></td>\r\n                <td><b>Zanr</b></td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
             foreach (BookActiveRecord book in rental.Value)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
                   Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
                   Write(book.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
                                     Write(book.Author.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
                   Write(book.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n    <br>\r\n    <br>\r\n");
#nullable restore
#line 37 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 933, "\"", 968, 1);
#nullable restore
#line 38 "C:\dev\volavka\ProjectVIS.WinForms\Web\Views\Home\RentalList.cshtml"
WriteAttributeValue("", 940, Url.Action("Index", "Home"), 940, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Prodlouzit vypujcku</a>\r\n\r\n");
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
