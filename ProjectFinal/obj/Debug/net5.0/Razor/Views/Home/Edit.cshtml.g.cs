#pragma checksum "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44de39c84caa3027677a3b84ae5044b26ee91bf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
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
#line 12 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml"
using ProjectFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44de39c84caa3027677a3b84ae5044b26ee91bf7", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"796af203a5844574d8aea24c47d2436464a0093d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/DoEdit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 9 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"add\" style=\"margin-left:30%\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44de39c84caa3027677a3b84ae5044b26ee91bf73933", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label>Product Name: </label>\r\n            <input style=\"width:50%\" name=\"newProduct.Id\"");
                BeginWriteAttribute("value", " value=\"", 555, "\"", 572, 1);
#nullable restore
#line 19 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml"
WriteAttributeValue("", 563, Model.Id, 563, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" readonly class=\"form-control\" placeholder=\"Enter name\">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Product Name: </label>\r\n            <input style=\"width:50%\" name=\"newProduct.ProductName\"");
                BeginWriteAttribute("value", " value=\"", 802, "\"", 828, 1);
#nullable restore
#line 23 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml"
WriteAttributeValue("", 810, Model.ProductName, 810, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class=\"form-control\" placeholder=\"Enter name\">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Image: </label>\r\n            <input style=\"width:50%\" name=\"newProduct.Image\"");
                BeginWriteAttribute("value", " value=\"", 1036, "\"", 1056, 1);
#nullable restore
#line 27 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1044, Model.Image, 1044, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class=\"form-control\" placeholder=\"Enter image\">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Quantity: </label>\r\n            <input style=\"width:50%\" name=\"newProduct.Quantity\"");
                BeginWriteAttribute("value", " value=\"", 1271, "\"", 1294, 1);
#nullable restore
#line 31 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1279, Model.Quantity, 1279, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" class=\"form-control\" placeholder=\"Enter quantity\">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Price: </label>\r\n            <input style=\"width:50%\" name=\"newProduct.Price\"");
                BeginWriteAttribute("value", " value=\"", 1508, "\"", 1528, 1);
#nullable restore
#line 35 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1516, Model.Price, 1516, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" class=\"form-control\" placeholder=\"Enter price\">\r\n        </div>\r\n        <label>Category: </label>\r\n        <select name=\"newProduct.IdCategory\">\r\n");
#nullable restore
#line 39 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml"
             foreach (Category i in ViewBag.Cate)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44de39c84caa3027677a3b84ae5044b26ee91bf77580", async() => {
                    WriteLiteral("\r\n");
                    WriteLiteral("                    ");
#nullable restore
#line 43 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml"
               Write(i.CategoryName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml"
                   WriteLiteral(i.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n        <div class=\"form-group\">\r\n            <label>Description: </label>\r\n            <input style=\"width:50%\" name=\"newProduct.Description\"");
                BeginWriteAttribute("value", " value=\"", 2103, "\"", 2129, 1);
#nullable restore
#line 49 "C:\Users\Computer\Desktop\ShoppingWeb\ProjectFinal\Views\Home\Edit.cshtml"
WriteAttributeValue("", 2111, Model.Description, 2111, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class=\"form-control\" placeholder=\"Enter description\">\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
