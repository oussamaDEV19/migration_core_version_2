#pragma checksum "C:\Users\HP\source\repos\migration-core\CoreMigration\Views\Home\gallerieListImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d66307866d349eb25d5bead89fc65791afb5be55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_gallerieListImages), @"mvc.1.0.view", @"/Views/Home/gallerieListImages.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\migration-core\CoreMigration\Views\_ViewImports.cshtml"
using CoreMigration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP\source\repos\migration-core\CoreMigration\Views\Home\gallerieListImages.cshtml"
using CoreMigration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d66307866d349eb25d5bead89fc65791afb5be55", @"/Views/Home/gallerieListImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa74b44e39f1bf90250732af1aa45cb959b99a19", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_gallerieListImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\source\repos\migration-core\CoreMigration\Views\Home\gallerieListImages.cshtml"
  
    ViewBag.Title = "gallerieListImages";
    Layout = "~/Views/Shared/_Layout.cshtml";
    IEnumerable<gallerie> Gal = ViewData["listgallerie"] as IEnumerable<gallerie>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div>
        <div class=""card card-danger"">
            <div class=""card-header"">
                <h3 class=""card-title"">Events</h3>

            </div>
            <div class=""card-body p-0"">
                <table class=""table table-striped projects"">
                    <thead>
                        <tr>
                            <th style=""width: 1%"">
                                ID
                            </th>
                            <th style=""width: 10%"">
                                Type
                            </th>

                            <th style=""width: 10%"">
                                Date
                            </th>
                            <th style=""width: 30%"">
                                image
                            </th>
                            <th style=""width: 8%"" class=""text-center"">

                            </th>

                        </tr>
                    </the");
            WriteLiteral("ad>\r\n                    <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\HP\source\repos\migration-core\CoreMigration\Views\Home\gallerieListImages.cshtml"
                         foreach (var e in Gal)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 43 "C:\Users\HP\source\repos\migration-core\CoreMigration\Views\Home\gallerieListImages.cshtml"
                               Write(e.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 46 "C:\Users\HP\source\repos\migration-core\CoreMigration\Views\Home\gallerieListImages.cshtml"
                               Write(e.type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 49 "C:\Users\HP\source\repos\migration-core\CoreMigration\Views\Home\gallerieListImages.cshtml"
                               Write(e.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d66307866d349eb25d5bead89fc65791afb5be556483", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1826, "~/images/", 1826, 9, true);
#nullable restore
#line 52 "C:\Users\HP\source\repos\migration-core\CoreMigration\Views\Home\gallerieListImages.cshtml"
AddHtmlAttributeValue("", 1835, e.path, 1835, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td class=\"project-actions text-right\">\r\n                                    <a class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'are you sure ?\')\"");
            BeginWriteAttribute("href", " href=\"", 2091, "\"", 2124, 2);
            WriteAttributeValue("", 2098, "/Home/delet_gallerie/", 2098, 21, true);
#nullable restore
#line 56 "C:\Users\HP\source\repos\migration-core\CoreMigration\Views\Home\gallerieListImages.cshtml"
WriteAttributeValue("", 2119, e.id, 2119, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fas fa-trash"">
                                        </i>
                                        Delete
                                    </a>
                                </td>
                            </tr>
");
#nullable restore
#line 63 "C:\Users\HP\source\repos\migration-core\CoreMigration\Views\Home\gallerieListImages.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            <!-- /.card-body -->\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n");
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