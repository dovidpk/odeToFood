#pragma checksum "/Users/dovid/Projects/proj_studyno_http/proj_studyno_http/Pages/Res/detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc7faa5dfb50159a37b64cb91b60df95bdcff9c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(proj_studyno_http.Pages.Res.Pages_Res_detail), @"mvc.1.0.razor-page", @"/Pages/Res/detail.cshtml")]
namespace proj_studyno_http.Pages.Res
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
#line 1 "/Users/dovid/Projects/proj_studyno_http/proj_studyno_http/Pages/_ViewImports.cshtml"
using proj_studyno_http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{restaurantId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc7faa5dfb50159a37b64cb91b60df95bdcff9c8", @"/Pages/Res/detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"191a911098fb9d6f801af58d5d291a3bffc6063e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Res_detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>");
#nullable restore
#line 6 "/Users/dovid/Projects/proj_studyno_http/proj_studyno_http/Pages/Res/detail.cshtml"
Write(Model.Restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n\n<div>\n    ID: ");
#nullable restore
#line 10 "/Users/dovid/Projects/proj_studyno_http/proj_studyno_http/Pages/Res/detail.cshtml"
   Write(Model.Restaurant.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    Address: ");
#nullable restore
#line 13 "/Users/dovid/Projects/proj_studyno_http/proj_studyno_http/Pages/Res/detail.cshtml"
        Write(Model.Restaurant.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    Color: ");
#nullable restore
#line 16 "/Users/dovid/Projects/proj_studyno_http/proj_studyno_http/Pages/Res/detail.cshtml"
      Write(Model.Restaurant.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n");
#nullable restore
#line 19 "/Users/dovid/Projects/proj_studyno_http/proj_studyno_http/Pages/Res/detail.cshtml"
 if (Model.message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        ");
#nullable restore
#line 22 "/Users/dovid/Projects/proj_studyno_http/proj_studyno_http/Pages/Res/detail.cshtml"
   Write(Model.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 24 "/Users/dovid/Projects/proj_studyno_http/proj_studyno_http/Pages/Res/detail.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<proj_studyno_http.Pages.Res.detailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<proj_studyno_http.Pages.Res.detailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<proj_studyno_http.Pages.Res.detailModel>)PageContext?.ViewData;
        public proj_studyno_http.Pages.Res.detailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
