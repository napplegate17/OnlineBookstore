#pragma checksum "C:\Users\nickc\source\repos\OnlineBookstore\Views\Shared\BookSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9f7c9c84592a61df562c0c5df7665456cbafa96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BookSummary), @"mvc.1.0.view", @"/Views/Shared/BookSummary.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9f7c9c84592a61df562c0c5df7665456cbafa96", @"/Views/Shared/BookSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd52993051ba3b1efbc8ed13458242dee58f0dc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h4>");
#nullable restore
#line 4 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Shared\BookSummary.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <p>Author: ");
#nullable restore
#line 5 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Shared\BookSummary.cshtml"
          Write(Model.AuthorFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Shared\BookSummary.cshtml"
                                 Write(Model.AuthorMiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Shared\BookSummary.cshtml"
                                                         Write(Model.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Publisher: ");
#nullable restore
#line 6 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Shared\BookSummary.cshtml"
             Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>ISBN: ");
#nullable restore
#line 7 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Shared\BookSummary.cshtml"
        Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Classification: ");
#nullable restore
#line 8 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Shared\BookSummary.cshtml"
                  Write(Model.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Category: ");
#nullable restore
#line 9 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Shared\BookSummary.cshtml"
            Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Price: ");
#nullable restore
#line 10 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Shared\BookSummary.cshtml"
         Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Number of Pages: ");
#nullable restore
#line 11 "C:\Users\nickc\source\repos\OnlineBookstore\Views\Shared\BookSummary.cshtml"
                   Write(Model.NumberOfPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591