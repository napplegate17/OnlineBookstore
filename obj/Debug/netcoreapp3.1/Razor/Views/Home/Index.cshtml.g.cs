#pragma checksum "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b61470f3c6aed32511322c2f788076daacaa1d9c"
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
#line 1 "C:\Users\nickc\source\repos\OnlineBookstore\Views\_ViewImports.cshtml"
using OnlineBookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nickc\source\repos\OnlineBookstore\Views\_ViewImports.cshtml"
using OnlineBookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nickc\source\repos\OnlineBookstore\Views\_ViewImports.cshtml"
using OnlineBookstore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61470f3c6aed32511322c2f788076daacaa1d9c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd52993051ba3b1efbc8ed13458242dee58f0dc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::OnlineBookstore.Infrastructure.PageLinkTagHelper __OnlineBookstore_Infrastructure_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Nicholas Applegate, 1-3-->\r\n\r\n");
            WriteLiteral("\r\n<header>\r\n    <h1>Online Bookstore</h1>\r\n</header>\r\n\r\n<!--Display information for each book in the database-->\r\n\r\n");
#nullable restore
#line 14 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
 foreach (var x in Model.Books)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h4>");
#nullable restore
#line 17 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
   Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <p>Author: ");
#nullable restore
#line 18 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
          Write(x.AuthorFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
                             Write(x.AuthorMiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
                                                 Write(x.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Publisher: ");
#nullable restore
#line 19 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
             Write(x.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>ISBN: ");
#nullable restore
#line 20 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
        Write(x.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Classification: ");
#nullable restore
#line 21 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
                  Write(x.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Category: ");
#nullable restore
#line 22 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
            Write(x.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Price: ");
#nullable restore
#line 23 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
         Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Number of Pages: ");
#nullable restore
#line 24 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
                   Write(x.NumberOfPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
#nullable restore
#line 26 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b61470f3c6aed32511322c2f788076daacaa1d9c6737", async() => {
            }
            );
            __OnlineBookstore_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::OnlineBookstore.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__OnlineBookstore_Infrastructure_PageLinkTagHelper);
#nullable restore
#line 28 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Home\Index.cshtml"
__OnlineBookstore_Infrastructure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __OnlineBookstore_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __OnlineBookstore_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
