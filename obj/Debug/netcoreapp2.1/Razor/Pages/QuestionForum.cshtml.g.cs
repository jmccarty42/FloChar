#pragma checksum "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f58c99a2e71eb2251c39492adb8a338e47457ca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FloChar.Pages.Pages_QuestionForum), @"mvc.1.0.razor-page", @"/Pages/QuestionForum.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/QuestionForum.cshtml", typeof(FloChar.Pages.Pages_QuestionForum), null)]
namespace FloChar.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\rober\OneDrive\Code\Flochar\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\rober\OneDrive\Code\Flochar\Pages\_ViewImports.cshtml"
using FloChar;

#line default
#line hidden
#line 3 "C:\Users\rober\OneDrive\Code\Flochar\Pages\_ViewImports.cshtml"
using FloChar.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58c99a2e71eb2251c39492adb8a338e47457ca2", @"/Pages/QuestionForum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7c422dc10fbcbfae78265390b8e43e9510cdce", @"/Pages/_ViewImports.cshtml")]
    public class Pages_QuestionForum : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/questionHandler.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
  
    ViewData["Title"] = "QuestionForum";

#line default
#line hidden
            BeginContext(91, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(93, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63ca61936b2b458a9ed20065cdad88a8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(140, 30, true);
            WriteLiteral("\r\n\r\n<h2>QuestionForum</h2>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
 foreach (var rootQuestion in Model.RootQuestions)
{

#line default
#line hidden
            BeginContext(225, 143, true);
            WriteLiteral("    <div>\r\n        <p>\r\n            <a href=\"/treedisplay\" class=\"btn btn-primary\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse-");
            EndContext();
            BeginContext(369, 15, false);
#line 15 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
                                                                                                                  Write(rootQuestion.Id);

#line default
#line hidden
            EndContext();
            BeginContext(384, 23, true);
            WriteLiteral("\" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 407, "\"", 449, 3);
            WriteAttributeValue("", 423, "collapse-", 423, 9, true);
#line 15 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
WriteAttributeValue("", 432, rootQuestion.Id, 432, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 448, ";", 448, 1, true);
            EndWriteAttribute();
            BeginContext(450, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(470, 17, false);
#line 16 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
           Write(rootQuestion.Name);

#line default
#line hidden
            EndContext();
            BeginContext(487, 63, true);
            WriteLiteral("\r\n            </a>\r\n        </p>\r\n        <div class=\"collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 550, "\"", 580, 2);
            WriteAttributeValue("", 555, "collapse-", 555, 9, true);
#line 19 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
WriteAttributeValue("", 564, rootQuestion.Id, 564, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(581, 121, true);
            WriteLiteral(">\r\n            <div class=\"card card-body\">\r\n                Loading...\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 25 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FloChar.QuestionForumModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FloChar.QuestionForumModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FloChar.QuestionForumModel>)PageContext?.ViewData;
        public FloChar.QuestionForumModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
