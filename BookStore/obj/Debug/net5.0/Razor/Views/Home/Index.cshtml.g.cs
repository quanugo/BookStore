#pragma checksum "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87649b2b16ad5fa42a726cf9104ae84cf6991a31"
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
#line 1 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87649b2b16ad5fa42a726cf9104ae84cf6991a31", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Book>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("CategorySection", async() => {
                WriteLiteral("\r\n    <h1>Category</h1>\r\n    <ul>\r\n");
#nullable restore
#line 14 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
         foreach (KeyValuePair<int, string> kvp in ViewBag.Category)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li><a");
                BeginWriteAttribute("href", " href=\"", 352, "\"", 384, 2);
                WriteAttributeValue("", 359, "/home?categoryid=", 359, 17, true);
#nullable restore
#line 16 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 376, kvp.Key, 376, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
                                               Write(kvp.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 17 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n");
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87649b2b16ad5fa42a726cf9104ae84cf6991a314975", async() => {
                WriteLiteral(@"

    <style>
        .buy_now_button a {
            background: url(/Content/User/images/templatemo_btn_02.jpg) no-repeat;
        }

        .detail_button a {
            background: url(/Content/User/images/templatemo_btn_01.jpg) no-repeat;
        }

        .pagination-container {
            margin-top: 30px;
            margin-left: 30%;
            width: 50%;
            padding: 10px;
            background-color: #171716;
        }

        .pagination {
            list-style: none;
            display: flex;
        }

        li {
            margin-top: auto;
            margin-bottom: auto;
            margin-right: 5px;
            margin-left: 5px;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87649b2b16ad5fa42a726cf9104ae84cf6991a316669", async() => {
                WriteLiteral("\r\n    <div>\r\n");
#nullable restore
#line 54 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
         foreach (Book b in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"templatemo_product_box\">\r\n                <h1>");
#nullable restore
#line 57 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
               Write(b.BookName);

#line default
#line hidden
#nullable disable
                WriteLiteral("<span>(by ");
#nullable restore
#line 57 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
                                    Write(b.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</span></h1>\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 1379, "\"", 1411, 2);
                WriteAttributeValue("", 1385, "/Content/User/", 1385, 14, true);
#nullable restore
#line 58 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 1399, b.ImagePath, 1399, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"image\" />\r\n                <div class=\"product_info\">\r\n                    <h3>");
#nullable restore
#line 60 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
                   Write(b.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</h3>\r\n                    <div class=\"buy_now_button\"><a");
                BeginWriteAttribute("href", " href=\"", 1566, "\"", 1591, 2);
                WriteAttributeValue("", 1573, "/addcart/", 1573, 9, true);
#nullable restore
#line 61 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 1582, b.BookId, 1582, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Buy Now</a></div>\r\n                    <div class=\"detail_button\"><a href=\"#\">Detail</a></div>\r\n                </div>\r\n                <div class=\"cleaner\">&nbsp;</div>\r\n            </div>\r\n");
#nullable restore
#line 66 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div id=\"templatemo_footer\">\r\n        ");
#nullable restore
#line 71 "C:\Users\Admin\OneDrive\Documents\PRN211\BookStore\BookStore\Views\Home\Index.cshtml"
   Write(Html.PagedListPager(Model, page => Url.Action("Index", new { @ViewBag.categoryId, page })));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
