#pragma checksum "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8b1c867d2b6a4ceb1be27b6bf7bf54696e3305b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Contact.Pages_Contact_About), @"mvc.1.0.razor-page", @"/Pages/Contact/About.cshtml")]
namespace OdeToFood.Pages.Contact
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
#line 1 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b1c867d2b6a4ceb1be27b6bf7bf54696e3305b", @"/Pages/Contact/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4131f99e56e7ed69e62210f35a81d8b4678309ec", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Contact_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Hi</h1>\r\n\r\n\r\n<ul>\r\n");
#nullable restore
#line 10 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
     foreach(var restaurant in @Model.Restaurants)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 12 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
       Write(restaurant.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 13 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
       Write(restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 14 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
       Write(restaurant.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 15 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
       Write(restaurant.Cuisine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n\r\n<table class = \"table\">\r\n");
#nullable restore
#line 21 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
     foreach(var restaurant in @Model.Restaurants)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
           Write(restaurant.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
           Write(restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
           Write(restaurant.Cuisine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
           Write(restaurant.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n<div>");
#nullable restore
#line 33 "C:\Users\cingi\Desktop\Pluralsight\ASP.NET Core\ASP.NET Core Fundamentals\Projects\OdeToFood\OdeToFood\Pages\Contact\About.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Contact.AboutModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Contact.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Contact.AboutModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Contact.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
