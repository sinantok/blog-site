#pragma checksum "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\Shared\_BlogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13754c91735a9d5521052911df2be9d904c6a020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BlogList), @"mvc.1.0.view", @"/Views/Shared/_BlogList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_BlogList.cshtml", typeof(AspNetCore.Views_Shared__BlogList))]
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
#line 1 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\_ViewImports.cshtml"
using CoreBlogApp.WebUI.Models;

#line default
#line hidden
#line 2 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\_ViewImports.cshtml"
using CoreBlogApp.Entity.DbEntities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13754c91735a9d5521052911df2be9d904c6a020", @"/Views/Shared/_BlogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0619506ec85f3a602316943541aaa191894cca61", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BlogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\Shared\_BlogList.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
            BeginContext(55, 60, true);
            WriteLiteral("    <div class=\"alet alert-warning\">Kayıt bulunamadı</div>\r\n");
            EndContext();
#line 5 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\Shared\_BlogList.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(127, 31, true);
            WriteLiteral("    <p class=\"lead\">Blogs</p>\r\n");
            EndContext();
#line 9 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\Shared\_BlogList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(199, 88, true);
            WriteLiteral("        <div class=\"card my-2\">\r\n            <div class=\"card-header\">\r\n                ");
            EndContext();
            BeginContext(288, 10, false);
#line 13 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\Shared\_BlogList.cshtml"
           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(298, 34, true);
            WriteLiteral("\r\n            </div>\r\n            ");
            EndContext();
            BeginContext(332, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7bf82355b4c94164956e156ae9ca4a6f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 363, "~/img/", 363, 6, true);
#line 15 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\Shared\_BlogList.cshtml"
AddHtmlAttributeValue("", 369, item.Image, 369, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(416, 79, true);
            WriteLiteral("\r\n            <div class=\"card-block\">\r\n                <h4 class=\"card-title\">");
            EndContext();
            BeginContext(496, 10, false);
#line 17 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\Shared\_BlogList.cshtml"
                                  Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(506, 44, true);
            WriteLiteral("</h4>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(551, 16, false);
#line 18 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\Shared\_BlogList.cshtml"
                                Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(567, 22, true);
            WriteLiteral("</p>\r\n                ");
            EndContext();
            BeginContext(590, 112, false);
#line 19 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\Shared\_BlogList.cshtml"
           Write(Html.ActionLink("Blog Details", "Details", "Blog", new { id = item.BlogId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(702, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 22 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\Shared\_BlogList.cshtml"
    }

#line default
#line hidden
#line 22 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Views\Shared\_BlogList.cshtml"
     
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
