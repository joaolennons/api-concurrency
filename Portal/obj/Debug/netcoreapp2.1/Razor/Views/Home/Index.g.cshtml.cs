#pragma checksum "C:\Users\joaol\Desktop\provacsharpdotnet\provacsharpdotnet\Portal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b84d3a724577daac7a4caa32a7d80e87384d61e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\joaol\Desktop\provacsharpdotnet\provacsharpdotnet\Portal\Views\_ViewImports.cshtml"
using Portal;

#line default
#line hidden
#line 2 "C:\Users\joaol\Desktop\provacsharpdotnet\provacsharpdotnet\Portal\Views\_ViewImports.cshtml"
using Portal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84d3a724577daac7a4caa32a7d80e87384d61e5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea73c18953461b2da0883cbece56eb399a5ce162", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\joaol\Desktop\provacsharpdotnet\provacsharpdotnet\Portal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Portal do Tempo";

#line default
#line hidden
            BeginContext(51, 330, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""jumbotron"">
        <h3>Random Key Generator</h3>
    </div>
    <div class=""panel panel-info"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"">Key informations</h3>
        </div>
        <div class=""panel-body"">
            <div class=""well""><b>DateTime: </b>");
            EndContext();
            BeginContext(382, 23, false);
#line 14 "C:\Users\joaol\Desktop\provacsharpdotnet\provacsharpdotnet\Portal\Views\Home\Index.cshtml"
                                          Write(ViewData["DateTimeNow"]);

#line default
#line hidden
            EndContext();
            BeginContext(405, 50, true);
            WriteLiteral("</div>\r\n            <div class=\"well\"><b>Key: </b>");
            EndContext();
            BeginContext(456, 15, false);
#line 15 "C:\Users\joaol\Desktop\provacsharpdotnet\provacsharpdotnet\Portal\Views\Home\Index.cshtml"
                                     Write(ViewData["Key"]);

#line default
#line hidden
            EndContext();
            BeginContext(471, 54, true);
            WriteLiteral("</div>\r\n            <div class=\"well\"><b>Odd Sum:</b> ");
            EndContext();
            BeginContext(526, 15, false);
#line 16 "C:\Users\joaol\Desktop\provacsharpdotnet\provacsharpdotnet\Portal\Views\Home\Index.cshtml"
                                         Write(ViewData["Sum"]);

#line default
#line hidden
            EndContext();
            BeginContext(541, 275, true);
            WriteLiteral(@"</div>
        </div>
    </div>
    <div class=""panel panel-info"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"">Memory Information</h3>
        </div>
        <div class=""panel-body"">
            <div class=""well""><b>GEN0 Collections:</b> ");
            EndContext();
            BeginContext(817, 15, false);
#line 24 "C:\Users\joaol\Desktop\provacsharpdotnet\provacsharpdotnet\Portal\Views\Home\Index.cshtml"
                                                  Write(ViewData["gc0"]);

#line default
#line hidden
            EndContext();
            BeginContext(832, 63, true);
            WriteLiteral("</div>\r\n            <div class=\"well\"><b>GEN1 Collections:</b> ");
            EndContext();
            BeginContext(896, 15, false);
#line 25 "C:\Users\joaol\Desktop\provacsharpdotnet\provacsharpdotnet\Portal\Views\Home\Index.cshtml"
                                                  Write(ViewData["gc1"]);

#line default
#line hidden
            EndContext();
            BeginContext(911, 63, true);
            WriteLiteral("</div>\r\n            <div class=\"well\"><b>GEN2 Collections:</b> ");
            EndContext();
            BeginContext(975, 15, false);
#line 26 "C:\Users\joaol\Desktop\provacsharpdotnet\provacsharpdotnet\Portal\Views\Home\Index.cshtml"
                                                  Write(ViewData["gc2"]);

#line default
#line hidden
            EndContext();
            BeginContext(990, 61, true);
            WriteLiteral("</div>\r\n            <div class=\"well\"><b>Current Memory:</b> ");
            EndContext();
            BeginContext(1052, 25, false);
#line 27 "C:\Users\joaol\Desktop\provacsharpdotnet\provacsharpdotnet\Portal\Views\Home\Index.cshtml"
                                                Write(ViewData["currentMemory"]);

#line default
#line hidden
            EndContext();
            BeginContext(1077, 61, true);
            WriteLiteral("</div>\r\n            <div class=\"well\"><b>Process Memory:</b> ");
            EndContext();
            BeginContext(1139, 24, false);
#line 28 "C:\Users\joaol\Desktop\provacsharpdotnet\provacsharpdotnet\Portal\Views\Home\Index.cshtml"
                                                Write(ViewData["privateBytes"]);

#line default
#line hidden
            EndContext();
            BeginContext(1163, 42, true);
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
