#pragma checksum "C:\Users\17dor\source\repos\MockSocialMedia\Views\Profile\SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4989efc540de7de0aa42acb870e6cb10aeaca48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_SearchResults), @"mvc.1.0.view", @"/Views/Profile/SearchResults.cshtml")]
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
#line 1 "C:\Users\17dor\source\repos\MockSocialMedia\Views\_ViewImports.cshtml"
using MockSocialMedia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\17dor\source\repos\MockSocialMedia\Views\_ViewImports.cshtml"
using MockSocialMedia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4989efc540de7de0aa42acb870e6cb10aeaca48", @"/Views/Profile/SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698674b866f9c5f12f28caf90cfba695bc42109f", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProfileViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\17dor\source\repos\MockSocialMedia\Views\Profile\SearchResults.cshtml"
 if(Model.Count != 0)
{
    foreach(ProfileViewModel p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 7 "C:\Users\17dor\source\repos\MockSocialMedia\Views\Profile\SearchResults.cshtml"
      Write(p.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "C:\Users\17dor\source\repos\MockSocialMedia\Views\Profile\SearchResults.cshtml"
    }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>No results were found for your search</h2>\r\n");
#nullable restore
#line 13 "C:\Users\17dor\source\repos\MockSocialMedia\Views\Profile\SearchResults.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProfileViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591