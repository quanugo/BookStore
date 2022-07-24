#pragma checksum "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4af2a23957b1756f7d670f6a0cfa3d079cf79d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
#line 1 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4af2a23957b1756f7d670f6a0cfa3d079cf79d2", @"/Views/Home/Cart.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartItem>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4af2a23957b1756f7d670f6a0cfa3d079cf79d23099", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Cart</title>
    <style>
        body{
            margin-left:20%;
            margin-top:10%;
            background-image:url(""/Content/User/images/background_cart.jpg"");
            background-repeat: no-repeat;
            background-size: cover;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4af2a23957b1756f7d670f6a0cfa3d079cf79d24425", async() => {
                WriteLiteral("\r\n    <a href=\"/home\">Continue Shopping</a>\r\n    <h2>Cart</h2>\r\n\r\n");
#nullable restore
#line 27 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
     if (Model.Count > 0)
    {
        double total = 0;
        int stt = 1;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <form action=""/submit"" method=""get"">
            <table>
                <tr>
                    <th>Image</th>
                    <th>Book Name</th>
                    <th>Unit Price</th>
                    <th>Quantity</th>
                    <th>Total</th>
                    <th></th>
                </tr>
");
#nullable restore
#line 41 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
                 foreach (var cartitem in Model)
                {
                    var thanhtien = cartitem.Quantity * cartitem.Book.Price;
                    total += thanhtien;


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td><img");
                BeginWriteAttribute("src", " src=\"", 1216, "\"", 1260, 2);
                WriteAttributeValue("", 1222, "/Content/User/", 1222, 14, true);
#nullable restore
#line 47 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1236, cartitem.Book.ImagePath, 1236, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"image\" /></td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
                       Write(cartitem.Book.BookName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
                        Write(cartitem.Book.Price.ToString("n0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td><input type=\"text\" name=\"quantity\"");
                BeginWriteAttribute("value", " value=\"", 1475, "\"", 1516, 1);
#nullable restore
#line 50 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1483, cartitem.Quantity.ToString("n0"), 1483, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
                        Write(thanhtien.ToString("n0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1649, "\"", 1691, 3);
                WriteAttributeValue("", 1656, "/updatecart/", 1656, 12, true);
#nullable restore
#line 53 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1668, cartitem.Book.BookId, 1668, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1689, "/2", 1689, 2, true);
                EndWriteAttribute();
                WriteLiteral(">Update</a>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1735, "\"", 1775, 2);
                WriteAttributeValue("", 1742, "/removecart/", 1742, 12, true);
#nullable restore
#line 54 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1754, cartitem.Book.BookId, 1754, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td colspan=\"4\">Total</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
                    Write(total.ToString("n0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td></td>\r\n                </tr>\r\n            </table>\r\n\r\n            <input type=\"submit\" value=\"Submit Order\" />\r\n        </form>\r\n");
#nullable restore
#line 67 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>Giỏ hàng trống</p>\r\n");
#nullable restore
#line 71 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Cart.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591