#pragma checksum "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/crudelicious/crudelicious/Views/Home/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a9110fe0a652ab93b9a011a070ab767bd6ff843"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(crudelicious.Home.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Show.cshtml", typeof(crudelicious.Home.Views_Home_Show))]
namespace crudelicious.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/crudelicious/crudelicious/Views/Home/Show.cshtml"
using crudelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a9110fe0a652ab93b9a011a070ab767bd6ff843", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e11676a8876551cfc8af53fe3a355e2e2f598cbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(40, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a9110fe0a652ab93b9a011a070ab767bd6ff8433889", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(86, 213, true);
            WriteLiteral("\n<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\n");
            EndContext();
            BeginContext(299, 685, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a9110fe0a652ab93b9a011a070ab767bd6ff8435343", async() => {
                BeginContext(305, 268, true);
                WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-light bg-dark"">
    <h1 class=""white mr-auto text"">Welcome to CRUDelicious</h1>
    <a href=""/"" class=""btn btn-info"">Home</a>
</nav>
<div class=""container"">
    <div class=""container border"">
        <h1 class=""text-center"">");
                EndContext();
                BeginContext(574, 10, false);
#line 13 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/crudelicious/crudelicious/Views/Home/Show.cshtml"
                           Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(584, 38, true);
                WriteLiteral("</h1>\n        <h6 class=\"text-center\">");
                EndContext();
                BeginContext(623, 10, false);
#line 14 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/crudelicious/crudelicious/Views/Home/Show.cshtml"
                           Write(Model.Chef);

#line default
#line hidden
                EndContext();
                BeginContext(633, 36, true);
                WriteLiteral("</h6>\n    </div>\n    <p class=\"row\">");
                EndContext();
                BeginContext(670, 17, false);
#line 16 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/crudelicious/crudelicious/Views/Home/Show.cshtml"
              Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(687, 42, true);
                WriteLiteral("</p>\n    <h6 class=\"row\"><b>Calories:</b> ");
                EndContext();
                BeginContext(730, 14, false);
#line 17 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/crudelicious/crudelicious/Views/Home/Show.cshtml"
                                Write(Model.Calories);

#line default
#line hidden
                EndContext();
                BeginContext(744, 44, true);
                WriteLiteral("</h6>\n    <h6 class=\"row\"><b>Tastiness:</b> ");
                EndContext();
                BeginContext(789, 15, false);
#line 18 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/crudelicious/crudelicious/Views/Home/Show.cshtml"
                                 Write(Model.Tastiness);

#line default
#line hidden
                EndContext();
                BeginContext(804, 37, true);
                WriteLiteral("</h6>\n</div>\n<div class=\"row\">\n    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 841, "\"", 868, 2);
                WriteAttributeValue("", 848, "delete/", 848, 7, true);
#line 21 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/crudelicious/crudelicious/Views/Home/Show.cshtml"
WriteAttributeValue("", 855, Model.DishId, 855, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(869, 41, true);
                WriteLiteral(" class=\"btn btn-danger\">Delete</a>\n    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 910, "\"", 935, 2);
                WriteAttributeValue("", 917, "edit/", 917, 5, true);
#line 22 "/Users/IrockMyWarlock/Desktop/codingdojo/c#/ORMs/crudelicious/crudelicious/Views/Home/Show.cshtml"
WriteAttributeValue("", 922, Model.DishId, 922, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(936, 41, true);
                WriteLiteral(" class=\"btn btn-warning\">Edit</a>\n</div>\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
