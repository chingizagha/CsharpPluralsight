#pragma checksum "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\Category\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c00f823abe7cb20feac141af875b706abf3f5e0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/List.cshtml")]
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
#line 1 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\_ViewImports.cshtml"
using BethanysPieShop.Areas.Admin.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\_ViewImports.cshtml"
using BethanysPieShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\Category\List.cshtml"
using BethanysPieShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c00f823abe7cb20feac141af875b706abf3f5e0e", @"/Areas/Admin/Views/Category/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8bd6be39df25a49ec4f9ceba01e5e7c11ba1f8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminCategoriesListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pt-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n  <h2>Categories</h2>\r\n         \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c00f823abe7cb20feac141af875b706abf3f5e0e6661", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <div class=\"input-group\">\r\n            <input type=\"search\" class=\"form-control\" name=\"categoryName\"");
                BeginWriteAttribute("value", " value=\"", 311, "\"", 319, 0);
                EndWriteAttribute();
                WriteLiteral("/>\r\n            <span class=\"input-group-btn\">\r\n                <button type=\"submit\" class=\"btn btn-outline-dark\">\r\n                    Search  \r\n                </button>\r\n            </span>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 19 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\Category\List.cshtml"
   foreach (var category in Model.Categories)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"panel panel-default\">\r\n        <div class=\"panel-heading\">\r\n            <h3>");
#nullable restore
#line 23 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\Category\List.cshtml"
           Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"panel-body\">\r\n            <span>Description: ");
#nullable restore
#line 26 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\Category\List.cshtml"
                          Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span hidden=\"hidden\">Description: ");
#nullable restore
#line 27 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\Category\List.cshtml"
                                          Write(category.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"panel-footer\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c00f823abe7cb20feac141af875b706abf3f5e0e10791", async() => {
                WriteLiteral("\r\n                <i class=\"glyphicon glyphicon-zoom-in\"></i>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\Category\List.cshtml"
                                                                                          WriteLiteral(category.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c00f823abe7cb20feac141af875b706abf3f5e0e13516", async() => {
                WriteLiteral("\r\n                <i class=\"glyphicon glyphicon-edit\"></i>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CategoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\Category\List.cshtml"
                                                                                        WriteLiteral(category.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CategoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CategoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CategoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c00f823abe7cb20feac141af875b706abf3f5e0e16267", async() => {
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-lg pt-10\"><i class=\"glyphicon glyphicon-trash\"></i></button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\Category\List.cshtml"
                                                                          WriteLiteral(category.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 10, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1650, "return", 1650, 6, true);
            AddHtmlAttributeValue(" ", 1656, "confirm(\'Are", 1657, 13, true);
            AddHtmlAttributeValue(" ", 1669, "you", 1670, 4, true);
            AddHtmlAttributeValue(" ", 1673, "sure", 1674, 5, true);
            AddHtmlAttributeValue(" ", 1678, "you", 1679, 4, true);
            AddHtmlAttributeValue(" ", 1682, "want", 1683, 5, true);
            AddHtmlAttributeValue(" ", 1687, "to", 1688, 3, true);
            AddHtmlAttributeValue(" ", 1690, "delete", 1691, 7, true);
#nullable restore
#line 40 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\Category\List.cshtml"
AddHtmlAttributeValue(" ", 1697, category.CategoryName, 1698, 22, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1720, "?\')", 1720, 3, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>      \r\n");
#nullable restore
#line 45 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\Building Web Applications with ASP.NET Core 3 and 5 MVC\Projects\BethanysPieShop\BethanysPieShop\Areas\Admin\Views\Category\List.cshtml"
  }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminCategoriesListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
