#pragma checksum "C:\Users\rober\OneDrive\Code\Flochar\Pages\AskQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80976d6b95ddc27c5349ceae78c6f48907ebbd5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FloChar.Pages.Pages_AskQuestion), @"mvc.1.0.razor-page", @"/Pages/AskQuestion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AskQuestion.cshtml", typeof(FloChar.Pages.Pages_AskQuestion), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80976d6b95ddc27c5349ceae78c6f48907ebbd5c", @"/Pages/AskQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7c422dc10fbcbfae78265390b8e43e9510cdce", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AskQuestion : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\rober\OneDrive\Code\Flochar\Pages\AskQuestion.cshtml"
  
    ViewData["Title"] = "AskQuestion";

#line default
#line hidden
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(89, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a102e4ae767f4ca5a2dec4f4fa99616c", async() => {
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
            BeginContext(136, 1343, true);
            WriteLiteral(@"

<h2>Ask a Generic Question</h2>
<label>Topic Question</label>
<input id=""rootQuestionInput"" type=""text"" name=""question"" class=""form-control mb-3 "" placeholder=""Type your Question Here"" maxlength=""255"" />
<br />
<label>List your Sub-Questions here</label>
<div id=""subQuestions"" class=""row"">
    <div class=""ml-3"">
        <div class=""col-md-11""><input class=""subQuestionInput form-control"" type=""text"" name=""question"" placeholder=""Type your Question Here"" maxlength=""255"" /></div>
        <button class=""btn btn-danger"">&#10005;</button>
    </div>
    <br />
    <div class=""ml-3"">
        <div class=""col-md-11""><input class=""subQuestionInput form-control"" type=""text"" name=""question"" placeholder=""Type your Question Here"" maxlength=""255"" /></div>
        <button class=""btn btn-danger"">&#10005;</button>
    </div>
    <br />
    <div class=""ml-3"">
        <div class=""col-md-11""><input class=""subQuestionInput form-control"" type=""text"" name=""question"" placeholder=""Type your Question Here"" maxlength");
            WriteLiteral(@"=""255"" /></div>
        <button class=""btn btn-danger"">&#10005;</button>
    </div>
    <br />
</div>
<br />
<button class=""btn btn-success"" type=""button"" onclick=""addSubQuestion()"">Add Another Sub-Question</button>
<button class=""btn btn-primary"" type=""submit"" onclick=""postQuestion()"">Submit</button>
<br />
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FloChar.AskQuestionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FloChar.AskQuestionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FloChar.AskQuestionModel>)PageContext?.ViewData;
        public FloChar.AskQuestionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
