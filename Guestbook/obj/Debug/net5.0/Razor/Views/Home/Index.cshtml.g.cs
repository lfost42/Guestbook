#pragma checksum "/Users/lynda/Desktop/repo/Guestbook/Guestbook/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "111731623c65bd3be04ea535f818c2b338a91cd7"
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
#line 1 "/Users/lynda/Desktop/repo/Guestbook/Guestbook/Views/_ViewImports.cshtml"
using Guestbook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lynda/Desktop/repo/Guestbook/Guestbook/Views/_ViewImports.cshtml"
using Guestbook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"111731623c65bd3be04ea535f818c2b338a91cd7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7774102fe7d67917937aa82e5d9623f52be5c23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Guests", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/lynda/Desktop/repo/Guestbook/Guestbook/Views/Home/Index.cshtml"
  
    ViewData["App"] = "GUESTBOOK";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<main>\n    <div class=\"container col-xxl-8\">\n        <div class=\"row row-cols-1 row-cols-lg-2\">\n            <div class=\"col order-last order-lg-first\">\n                <h2 class=\"display-5 fw-bold 1h-1 mb-3 appname\">");
#nullable restore
#line 11 "/Users/lynda/Desktop/repo/Guestbook/Guestbook/Views/Home/Index.cshtml"
                                                           Write(ViewData["App"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": <br>A Coding Project</h2>\n                <h4 class=\"lead\">A database application using PostgreSQL.</h4>\n\n                ");
#nullable restore
#line 14 "/Users/lynda/Desktop/repo/Guestbook/Guestbook/Views/Home/Index.cshtml"
           Write(Html.ActionLink("Codesite", "Code", "Home", null, new { @class = "button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 15 "/Users/lynda/Desktop/repo/Guestbook/Guestbook/Views/Home/Index.cshtml"
           Write(Html.ActionLink("Testsite", "Test", "Home", null, new { @class = "button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                <ul class=""fa-ul pt-2 checklist"">

                    <li><span class=""fa-li""><i class=""fas fa-check-square""></i></span>SOLID Principles</li>
                    <li><span class=""fa-li""><i class=""fas fa-check-square""></i></span>ASP.NET Core Fundamentals</li>
                    <li><span class=""fa-li""><i class=""fas fa-check-square""></i></span>MVC Design Pattern</li>
                    <li><span class=""fa-li""><i class=""fas fa-check-square""></i></span>CRUD Applications with PostgreSQL</li>
                    <li><span class=""fa-li""><i class=""fas fa-check-square""></i></span>Object Relational Mapping with Entity Framework</li>
                </ul>

                <div class=""col-12 px-4 me-md-2"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "111731623c65bd3be04ea535f818c2b338a91cd76399", async() => {
                WriteLiteral("See App");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>

                <div class=""fw-bold mt-5"">
                    <div class=""d-flex"">
                        <div class=""row"">
                            <div class=""col""><img src=""/img/htmlcssjsbs.png"" height=""85"" width=""85""></div>
                            <div class=""col""><img src=""/img/csharp.png"" height=""55"" width=""55""></div>
                            <div class=""col""><img src=""/img/netmvc.png"" height=""75"" width=""75""></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col"">
                <img src=""/img/app.png"" class=""img-fluid center-block d-block mx-auto""");
            BeginWriteAttribute("alt", " alt=\"", 2079, "\"", 2106, 2);
#nullable restore
#line 41 "/Users/lynda/Desktop/repo/Guestbook/Guestbook/Views/Home/Index.cshtml"
WriteAttributeValue("", 2085, ViewData["App"], 2085, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2101, "Logo", 2102, 5, true);
            EndWriteAttribute();
            WriteLiteral(" width=\"600\" height=\"400\">\n            </div>\n        </div>\n    </div>\n</main>\n");
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
