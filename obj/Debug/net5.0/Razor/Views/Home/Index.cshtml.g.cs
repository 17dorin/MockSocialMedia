#pragma checksum "C:\Users\17dor\source\repos\MockSocialMedia\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dc3f51cf5d4630e520c132f5631ba5c90bb341f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dc3f51cf5d4630e520c132f5631ba5c90bb341f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698674b866f9c5f12f28caf90cfba695bc42109f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\17dor\source\repos\MockSocialMedia\Views\Home\Index.cshtml"
 if(Model.Count != 0)
{
    foreach(Post p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 7 "C:\Users\17dor\source\repos\MockSocialMedia\Views\Home\Index.cshtml"
      Write(p.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 8 "C:\Users\17dor\source\repos\MockSocialMedia\Views\Home\Index.cshtml"
      Write(p.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 9 "C:\Users\17dor\source\repos\MockSocialMedia\Views\Home\Index.cshtml"
      Write(p.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 10 "C:\Users\17dor\source\repos\MockSocialMedia\Views\Home\Index.cshtml"
    }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No posts to show. Create some posts or follow other users to see posts on your home page</p>\r\n");
#nullable restore
#line 15 "C:\Users\17dor\source\repos\MockSocialMedia\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
