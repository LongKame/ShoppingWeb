#pragma checksum "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0586c698cfc291fb1b9bd22c64e7143448c75dfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\_ViewImports.cshtml"
using ProjectFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\_ViewImports.cshtml"
using ProjectFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0586c698cfc291fb1b9bd22c64e7143448c75dfa", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"796af203a5844574d8aea24c47d2436464a0093d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectFinal.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div id=\"content\" class=\"wrapper\" style=\"margin-top: 20px; margin-left: 400px\">\r\n");
#nullable restore
#line 10 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
     foreach (Product p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"item\">\r\n            <img class=\"lazy\"");
            BeginWriteAttribute("src", " src=\"", 326, "\"", 340, 1);
#nullable restore
#line 13 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
WriteAttributeValue("", 332, p.Image, 332, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 341, "\"", 347, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div>\r\n                <a href=\"#\"><i style=\"font-size:40px\" class=\"fa\">&#xf08a;</i></a>\r\n                <a href=\"#\"><i style=\"font-size:40px\" class=\"fa\">&#xf06e;</i></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 556, "\"", 581, 2);
            WriteAttributeValue("", 563, "/Home/Detail/", 563, 13, true);
#nullable restore
#line 17 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
WriteAttributeValue("", 576, p.Id, 576, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"text\">");
#nullable restore
#line 17 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
                                                        Write(p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n<!-- Paging -->\r\n<div style=\"margin-left: 650px;\">\r\n    <nav aria-label=\"...\">\r\n        <ul class=\"pagination\">\r\n");
#nullable restore
#line 29 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
              
                int numberPage = (int)ViewBag.numberPageSearch;
                int pageCurrent = ViewBag.pageCurrentSearch;

                if (pageCurrent > 1)
                {
                    int prePage = pageCurrent - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"active\" style=\"background-color: cornflowerblue\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1147, "\"", 1168, 2);
            WriteAttributeValue("", 1154, "?page=", 1154, 6, true);
#nullable restore
#line 36 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
WriteAttributeValue("", 1160, prePage, 1160, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a></li>\r\n");
#nullable restore
#line 37 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"

                }

                int i;
                for (i = 1; i <= numberPage; i++)
                {
                    if (i == pageCurrent)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item active\">\r\n                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1475, "\"", 1490, 2);
            WriteAttributeValue("", 1482, "?page=", 1482, 6, true);
#nullable restore
#line 46 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
WriteAttributeValue("", 1488, i, 1488, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"sr-only\">(current)</span></a>\r\n                        </li>\r\n");
#nullable restore
#line 48 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
                                                                                                                                        
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1845, "\"", 1860, 2);
            WriteAttributeValue("", 1852, "?page=", 1852, 6, true);
#nullable restore
#line 52 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
WriteAttributeValue("", 1858, i, 1858, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 53 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
                    }
                }

                if (pageCurrent >= 1 && pageCurrent < numberPage)
                {
                    int nextPage = pageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"active\" style=\"background-color: cornflowerblue\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2158, "\"", 2180, 2);
            WriteAttributeValue("", 2165, "?page=", 2165, 6, true);
#nullable restore
#line 59 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"
WriteAttributeValue("", 2171, nextPage, 2171, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a></li>\r\n");
#nullable restore
#line 60 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Search.cshtml"

                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </nav>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectFinal.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591