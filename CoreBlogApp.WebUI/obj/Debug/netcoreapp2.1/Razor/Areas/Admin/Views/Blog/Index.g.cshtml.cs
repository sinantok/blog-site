#pragma checksum "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c077309ff6a1f5dede63d128274ef81d6040bb6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Blog/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Blog_Index))]
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
#line 1 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using CoreBlogApp.Entity.DbEntities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c077309ff6a1f5dede63d128274ef81d6040bb6e", @"/Areas/Admin/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3512f05e6ff6a6ef67567d74ee576b3d2066d359", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(131, 118, true);
            WriteLiteral("\r\n<div class=\"container mt-3\">\r\n    <h2>Blog List</h2>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n");
            EndContext();
#line 12 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
             if (Model.Count() > 0)
            {
                var say = 0;

#line default
#line hidden
            BeginContext(331, 172, true);
            WriteLiteral("                <p>\r\n                    <a href=\"/Admin/Blog/Create\" class=\"btn btn-primary\"><span class=\"glyphicon glyphicon-plus\"></span> New</a>\r\n                </p>\r\n");
            EndContext();
            BeginContext(505, 570, true);
            WriteLiteral(@"                <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <th></th>
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
#line 33 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                         foreach (var item in Model)
                        {
                            say++;

#line default
#line hidden
            BeginContext(1192, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1263, 3, false);
#line 37 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                               Write(say);

#line default
#line hidden
            EndContext();
            BeginContext(1266, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1347, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "360e655076134a829da8523f8114e27a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1357, "~/img/", 1357, 6, true);
#line 39 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1363, item.Image, 1363, 11, false);

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
            BeginContext(1404, 77, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
            EndContext();
            BeginContext(1482, 10, false);
#line 41 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1492, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1536, 9, false);
#line 42 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1545, 45, true);
            WriteLiteral("</td>\r\n                                <td>\r\n");
            EndContext();
#line 44 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                                     if (@item.IsApproved)
                                    {

#line default
#line hidden
            BeginContext(1689, 89, true);
            WriteLiteral("                                        <i class=\"fa fa-check\" aria-hidden=\"true\"> </i>\r\n");
            EndContext();
#line 47 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(1898, 89, true);
            WriteLiteral("                                        <i class=\"fa fa-times\" aria-hidden=\"true\"> </i>\r\n");
            EndContext();
#line 51 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2026, 79, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
            EndContext();
#line 55 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                                     if (@item.IsHome)
                                    {

#line default
#line hidden
            BeginContext(2200, 89, true);
            WriteLiteral("                                        <i class=\"fa fa-check\" aria-hidden=\"true\"> </i>\r\n");
            EndContext();
#line 58 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2409, 89, true);
            WriteLiteral("                                        <i class=\"fa fa-times\" aria-hidden=\"true\"> </i>\r\n");
            EndContext();
#line 62 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2537, 79, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
            EndContext();
#line 66 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                                     if (@item.IsSlider)
                                    {

#line default
#line hidden
            BeginContext(2713, 89, true);
            WriteLiteral("                                        <i class=\"fa fa-check\" aria-hidden=\"true\"> </i>\r\n");
            EndContext();
#line 69 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2922, 89, true);
            WriteLiteral("                                        <i class=\"fa fa-times\" aria-hidden=\"true\"> </i>\r\n");
            EndContext();
#line 73 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3050, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3166, 124, false);
#line 77 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                               Write(Html.ActionLink("Edit", "Edit", "Blog", new { area = "Admin", id = item.BlogId }, new { @class = "btn btn-primary btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(3290, 40, true);
            WriteLiteral("\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3330, "\"", 3368, 2);
            WriteAttributeValue("", 3337, "/Admin/Blog/Delete/", 3337, 19, true);
#line 78 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3356, item.BlogId, 3356, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3369, 448, true);
            WriteLiteral(@"
                                       onclick=""return confirm('Are you sure want to delete this blog?')""
                                       class=""btn btn-danger btn-sm"" title=""Delete"">
                                        Delete
                                        <span class=""glyphicon glyphicon-trash""></span>
                                    </a>
                                </td>
                            </tr>
");
            EndContext();
#line 86 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3844, 56, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
            EndContext();
#line 89 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3948, 110, true);
            WriteLiteral("                <div class=\"alert alert-danger\">\r\n                    Blog not found\r\n                </div>\r\n");
            EndContext();
#line 95 "C:\Users\Sinan Tok\Desktop\CoreBlogApp\CoreBlogApp.WebUI\Areas\Admin\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4073, 44, true);
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
