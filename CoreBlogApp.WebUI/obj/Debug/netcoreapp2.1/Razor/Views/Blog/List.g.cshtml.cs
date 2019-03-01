#pragma checksum "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17145adb9568fdb1e327b27bea5b04581cf29791"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_List), @"mvc.1.0.view", @"/Views/Blog/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/List.cshtml", typeof(AspNetCore.Views_Blog_List))]
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
#line 1 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\_ViewImports.cshtml"
using CoreBlogApp.WebUI.Models;

#line default
#line hidden
#line 2 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\_ViewImports.cshtml"
using CoreBlogApp.Entity.DbEntities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17145adb9568fdb1e327b27bea5b04581cf29791", @"/Views/Blog/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0619506ec85f3a602316943541aaa191894cca61", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(119, 118, true);
            WriteLiteral("\r\n<div class=\"container mt-3\">\r\n    <h2>Blog List</h2>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n");
            EndContext();
#line 12 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
             if (Model.Count() > 0)
            {

#line default
#line hidden
            BeginContext(289, 166, true);
            WriteLiteral("                <p>\r\n                    <a href=\"/Blog/Create\" class=\"btn btn-primary\"><span class=\"glyphicon glyphicon-plus\"></span> New</a>\r\n                </p>\r\n");
            EndContext();
            BeginContext(457, 572, true);
            WriteLiteral(@"                <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Image</th>
                            <th>Title</th>
                            <th>Date</th>
                            <th>Is Approved</th>
                            <th>Is Home</th>
                            <th>Is Slider</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 32 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1110, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1173, 11, false);
#line 35 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(item.BlogId);

#line default
#line hidden
            EndContext();
            BeginContext(1184, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1257, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "60822e3e5b8e44368dfb432e3cae9999", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1267, "~/img/", 1267, 6, true);
#line 37 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
AddHtmlAttributeValue("", 1273, item.Image, 1273, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(1313, 69, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
            EndContext();
            BeginContext(1383, 10, false);
#line 39 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1393, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1433, 9, false);
#line 40 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1442, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 42 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                                 if (@item.IsApproved)
                                {

#line default
#line hidden
            BeginContext(1574, 85, true);
            WriteLiteral("                                    <i class=\"fa fa-check\" aria-hidden=\"true\"> </i>\r\n");
            EndContext();
#line 45 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1767, 85, true);
            WriteLiteral("                                    <i class=\"fa fa-times\" aria-hidden=\"true\"> </i>\r\n");
            EndContext();
#line 49 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(1887, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 53 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                                 if (@item.IsHome)
                                {

#line default
#line hidden
            BeginContext(2045, 85, true);
            WriteLiteral("                                    <i class=\"fa fa-check\" aria-hidden=\"true\"> </i>\r\n");
            EndContext();
#line 56 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2238, 85, true);
            WriteLiteral("                                    <i class=\"fa fa-times\" aria-hidden=\"true\"> </i>\r\n");
            EndContext();
#line 60 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(2358, 71, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            EndContext();
#line 64 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                                 if (@item.IsSlider)
                                {

#line default
#line hidden
            BeginContext(2518, 85, true);
            WriteLiteral("                                    <i class=\"fa fa-check\" aria-hidden=\"true\"> </i>\r\n");
            EndContext();
#line 67 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2711, 85, true);
            WriteLiteral("                                    <i class=\"fa fa-times\" aria-hidden=\"true\"> </i>\r\n");
            EndContext();
#line 71 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                                }

#line default
#line hidden
            BeginContext(2831, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2935, 115, false);
#line 75 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                           Write(Html.ActionLink("Edit", "AddorUpdate", "Blog", new { id = item.BlogId }, new { @class = "btn btn-primary btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(3050, 36, true);
            WriteLiteral("\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3086, "\"", 3118, 2);
            WriteAttributeValue("", 3093, "/Blog/Delete/", 3093, 13, true);
#line 76 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
WriteAttributeValue("", 3106, item.BlogId, 3106, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3119, 358, true);
            WriteLiteral(@"
                                   onclick=""return confirm('Are you sure want to delete this category?')""
                                   class=""btn btn-danger btn-sm"" title=""Delete"">
                                    Delete
                                    <span class=""glyphicon glyphicon-trash""></span>
                                </a>
");
            EndContext();
            BeginContext(3624, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 85 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
                        }

#line default
#line hidden
            BeginContext(3717, 56, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
            EndContext();
#line 88 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3821, 110, true);
            WriteLiteral("                <div class=\"alert alert-danger\">\r\n                    Blog not found\r\n                </div>\r\n");
            EndContext();
#line 94 "C:\Users\Sinan Tok\source\repos\CoreBlogApp\CoreBlogApp.WebUI\Views\Blog\List.cshtml"
            }

#line default
#line hidden
            BeginContext(3946, 46, true);
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
