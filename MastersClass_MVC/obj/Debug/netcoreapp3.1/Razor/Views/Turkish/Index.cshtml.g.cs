#pragma checksum "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Turkish\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bc4b324cb488507f39098b4ee455fab7f37011f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Turkish_Index), @"mvc.1.0.view", @"/Views/Turkish/Index.cshtml")]
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
#line 1 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\_ViewImports.cshtml"
using MastersClass_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Turkish\Index.cshtml"
using MastersClass_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bc4b324cb488507f39098b4ee455fab7f37011f", @"/Views/Turkish/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b425e0d1ec8658ef4ad0923e4421a09b8405e687", @"/Views/_ViewImports.cshtml")]
    public class Views_Turkish_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Courses>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bc4b324cb488507f39098b4ee455fab7f37011f3316", async() => {
                WriteLiteral("\r\n    <title></title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bc4b324cb488507f39098b4ee455fab7f37011f4305", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Turkish\Index.cshtml"
     foreach (var x in Model)
    {
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card mb-3\" style=\"max-width: 1000px;\">\r\n            <div class=\"row g-0\">\r\n                <div class=\"col-md-4\">\r\n                    <img");
                BeginWriteAttribute("src", " src=", 492, "", 510, 1);
#nullable restore
#line 20 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Turkish\Index.cshtml"
WriteAttributeValue("", 497, x.imageslink, 497, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid rounded-start\" alt=\"...\">\r\n             \r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 25 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Turkish\Index.cshtml"
                                          Write(x.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 26 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Turkish\Index.cshtml"
                                        Write(x.description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p class=\"card-text\"><small class=\"text-muted\">Video Length: ");
#nullable restore
#line 27 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Turkish\Index.cshtml"
                                                                                Write(x.time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small></p>\r\n                         \r\n                        <a class=\"btn btn-outline-primary\"");
                BeginWriteAttribute("href", " href=\"", 996, "\"", 1045, 2);
                WriteAttributeValue("", 1003, "/Turkish/", 1003, 9, true);
#nullable restore
#line 29 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Turkish\Index.cshtml"
WriteAttributeValue("", 1012, String.Concat("Level", @x.level), 1012, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Watch Now!</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 34 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Turkish\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Courses>> Html { get; private set; }
    }
}
#pragma warning restore 1591
