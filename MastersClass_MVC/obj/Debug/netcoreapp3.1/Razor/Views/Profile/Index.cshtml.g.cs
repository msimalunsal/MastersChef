#pragma checksum "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d45658fda8f82be21f370cd3fadda4f2637905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
#line 5 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Profile\Index.cshtml"
using MastersClass_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d45658fda8f82be21f370cd3fadda4f2637905", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b425e0d1ec8658ef4ad0923e4421a09b8405e687", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61d45658fda8f82be21f370cd3fadda4f26379054401", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61d45658fda8f82be21f370cd3fadda4f26379055390", async() => {
                WriteLiteral(@"
    <div class=""card mb-3"">
        <img src=""./images/italianhorizontal.jpg"" class=""card-img-top"" alt=""..."">
        <div class=""card-body"">
            <h5 class=""card-title"">Italian Food Course</h5>
            <p class=""card-text"">Your Progress</p>
            <div class=""progress"">
                <div class=""progress-bar bg-success"" role=""progressbar""");
                BeginWriteAttribute("style", " style=\"", 622, "\"", 650, 3);
                WriteAttributeValue("", 630, "width:", 630, 6, true);
#nullable restore
#line 18 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Profile\Index.cshtml"
WriteAttributeValue(" ", 636, ViewBag.sum, 637, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 649, "%", 649, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("aria-valuenow", " aria-valuenow=", 651, "", 678, 1);
#nullable restore
#line 18 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Profile\Index.cshtml"
WriteAttributeValue("", 666, ViewBag.sum, 666, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" aria-valuemin=""0"" aria-valuemax=""100""></div>
            </div>
        </div>
    </div>
    <div class=""card mb-3"">
        <img src=""./images/turkishhorizontal.jpg"" class=""card-img-top"" alt=""..."">
        <div class=""card-body"">
            <h5 class=""card-title"">Turkish Food Course</h5>
            <p class=""card-text"">Your Progress</p>
            <div class=""progress"">
                <div class=""progress-bar bg-success"" role=""progressbar""");
                BeginWriteAttribute("style", " style=\"", 1138, "\"", 1167, 3);
                WriteAttributeValue("", 1146, "width:", 1146, 6, true);
#nullable restore
#line 28 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Profile\Index.cshtml"
WriteAttributeValue(" ", 1152, ViewBag.sum2, 1153, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1166, "%", 1166, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("aria-valuenow", " aria-valuenow=", 1168, "", 1196, 1);
#nullable restore
#line 28 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Profile\Index.cshtml"
WriteAttributeValue("", 1183, ViewBag.sum2, 1183, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" aria-valuemin=""0"" aria-valuemax=""100""></div>
            </div>
        </div>
    </div>
    <div class=""card mb-3"">
        <img src=""./images/fareasthorizontal.jpg"" class=""card-img-top"" alt=""..."">
        <div class=""card-body"">
            <h5 class=""card-title"">Far East Course</h5>
            <p class=""card-text"">Your Progress</p>
            <div class=""progress"">
                <div class=""progress-bar bg-success"" role=""progressbar""");
                BeginWriteAttribute("style", " style=\"", 1652, "\"", 1681, 3);
                WriteAttributeValue("", 1660, "width:", 1660, 6, true);
#nullable restore
#line 38 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Profile\Index.cshtml"
WriteAttributeValue(" ", 1666, ViewBag.sum3, 1667, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1680, "%", 1680, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("aria-valuenow", " aria-valuenow=", 1682, "", 1710, 1);
#nullable restore
#line 38 "C:\Users\msima\source\repos\MastersClass_MVC\MastersClass_MVC\Views\Profile\Index.cshtml"
WriteAttributeValue("", 1697, ViewBag.sum3, 1697, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61d45658fda8f82be21f370cd3fadda4f26379059778", async() => {
                    WriteLiteral("Log Out");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591