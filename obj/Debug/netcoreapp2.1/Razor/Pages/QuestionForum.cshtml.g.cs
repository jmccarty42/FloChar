#pragma checksum "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88506009809f8d7ff175f919577d72fc3ecc4f4f"
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
#line 2 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
using FloChar.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88506009809f8d7ff175f919577d72fc3ecc4f4f", @"/Pages/QuestionForum.cshtml")]
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
  
    ViewData["Title"] = "QuestionForum";

#line default
#line hidden
            BeginContext(119, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(121, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c6361b1aed4e6faa4ecff6cef0f894", async() => {
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
            BeginContext(168, 86, true);
            WriteLiteral("\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/d3/3.5.17/d3.min.js\"></script>\r\n");
            EndContext();
#line 10 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
 for (int i = 0; i < 10; i++)
{

#line default
#line hidden
            BeginContext(288, 24, true);
            WriteLiteral("    <script>console.log(");
            EndContext();
            BeginContext(313, 1, false);
#line 12 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(314, 12, true);
            WriteLiteral(")</script>\r\n");
            EndContext();
#line 13 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
}

#line default
#line hidden
            BeginContext(329, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(333, 533, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7daf031d3954426953aa15470cfe682", async() => {
                BeginContext(339, 520, true);
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <meta charset=""utf-8"">

    <title>Collapsible Tree Example</title>

    <style>

        .node circle {
            fill: #fff;
            stroke: rgb(0, 0, 0);
            stroke-width: 3px;
        }

        .node text {
            font: 18px sans-serif;
        }

        .link {
            fill: none;
            stroke: #ccc;
            stroke-width: 2px;
        }
    </style>



");
                EndContext();
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
            EndContext();
            BeginContext(866, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
 foreach (var rootQuestion in Model.RootQuestions)
{

}

#line default
#line hidden
            BeginContext(928, 4422, true);
            WriteLiteral(@"<script>
    // ************** Generate the tree diagram	 *****************
    //console.log(""here"");
    function drawTree(id) {
        var maxdim = 0;
        function update_maxdim(x) { maxdim = x;}

        // load the external data
        //var tree_json = new Promise(
        //    function (resolve, reject) {
        //    // Only `delay` is able to resolve or reject the promise
        //        setTimeout(function () {
        //            resolve(getJsonForTree(id)); // After 3 seconds, resolve the promise with value 42
        //        }, 3000);
        //});
        
        //var tree_json = getJsonForTree(id);
       
       d3.json(""/api/Question/tree/"" + id, maxdim = function (error, treeData, maxdim) {
           root = treeData[0];
           update(root);
        });
        
        var margin = { top: 50, right: 50, bottom: 50, left: 50 },
            width = 960 - margin.right - margin.left,
            height = 960 - margin.top - margin.bottom;
           ");
            WriteLiteral(@" 
        var i = 0;

        var tree = d3.layout.tree()
            .size([width, height]);

        var diagonal = d3.svg.diagonal()
            .projection(function (d) { return [d.x, d.y]; });
        console.log(""#svgholder"" + id);
        var svg = d3.select(""#svgholder-"" + id).append(""svg"")
            .attr(""width"", width + margin.right + margin.left)
            .attr(""height"", height + margin.top + margin.bottom)
            .attr(""class"", ""tree"" + id)
            .append(""g"")
            .attr(""transform"", ""translate("" + margin.left + "","" + margin.top + "")"");

        function update(source) {

            // Compute the new tree layout.
            var nodes = tree.nodes(root).reverse(),
                links = tree.links(nodes);

            // Normalize for fixed-depth.
            var yscale = 100;
            var maxy = 0;
            var maxx = 0;
            nodes.forEach(function (d) { d.y = d.depth * yscale; maxy = d.y > maxy ? d.y : maxy });
            nodes.f");
            WriteLiteral(@"orEach(function (d) { maxx = d.x > maxx ? d.x : maxx })
            //window.alert(maxx)
            //window.alert(maxy)
            if (maxx > 960 - margin.left - margin.right) {
                var scale = 960 / maxx;
                yscale = yscale * scale;
            }
            maxy = 0;
            maxx = 0;
            nodes.forEach(function (d) { d.y = d.depth * yscale; maxy = d.y > maxy ? d.y : maxy });
            nodes.forEach(function (d) { maxx = d.x > maxx ? d.x : maxx })
            // Declare the nodes…
            var node = svg.selectAll(""g.node"")
                .data(nodes, function (d) {/* console.log(d.name + ""\t\t\t\t"" + d.is_link);*/ return d.id || (d.id = ++i); });

            // Enter the nodes.
            var nodeEnter = node.enter().append(""g"")
                .attr(""class"", ""node"")
                .attr(""transform"", function (d) {
                    console.log(""test"");
                    return ""translate("" + d.x + "","" + d.y + "")"";
                });");
            WriteLiteral(@"

            nodeEnter.append(""circle"")
                .attr(""r"", 5)
                .style(""fill"", ""#eaeaff"");

            nodeEnter.append(""text"")
                .attr(""y"", function (d) {
                    return d.children || d._children ? -25 : 25;
                })
                .attr(""dy"", "".35em"")
                .attr(""text-anchor"", ""middle"")
                .text(function (d) { return d.name; })
                .style(""fill-opacity"", 1);

            // Declare the links…
            var link = svg.selectAll(""path.link"")
                .data(links, function (d) { return d.target.id; });

            // Enter the links.
            link.enter().insert(""path"", ""g"")
                .attr(""class"", ""link"")
                .attr(""d"", diagonal);

            return maxy;

        }
        
    }
    
</script>
<script>
    function hideDiv(id) {
        var div = document.getElementById('question-' + id);
        if (div.style.display !== 'none') {
            d");
            WriteLiteral(@"iv.style.display = 'none';
        }
        else {
            div.style.display = 'block';
        }
    }
</script>
<script>
    function getNumAnswered(id, num) {
        document.getElementById(""answer-count-"" + id).innerText = num + "" Answers"";
    }

    
</script>
<h2>Previously Created Questions</h2>
");
            EndContext();
#line 172 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
 foreach (var rootQuestion in Model.RootQuestions)
{

#line default
#line hidden
            BeginContext(5405, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5413, "\"", 5443, 2);
            WriteAttributeValue("", 5418, "question-", 5418, 9, true);
#line 174 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
WriteAttributeValue("", 5427, rootQuestion.Id, 5427, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5444, 144, true);
            WriteLiteral(" style=\"display: normal\">\r\n        <div href=\"/treedisplay\" class=\"btn btn-primary\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse-");
            EndContext();
            BeginContext(5589, 15, false);
#line 175 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
                                                                                                                Write(rootQuestion.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5604, 23, true);
            WriteLiteral("\" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 5627, "\"", 5669, 3);
            WriteAttributeValue("", 5643, "collapse-", 5643, 9, true);
#line 175 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
WriteAttributeValue("", 5652, rootQuestion.Id, 5652, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 5668, ";", 5668, 1, true);
            EndWriteAttribute();
            BeginContext(5670, 78, true);
            WriteLiteral(" style=\"background-color:#eaeaff; color:black; width:960px\">\r\n            <h1>");
            EndContext();
            BeginContext(5749, 17, false);
#line 176 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
           Write(rootQuestion.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5766, 23, true);
            WriteLiteral("</h1>\r\n            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5789, "\"", 5820, 2);
            WriteAttributeValue("", 5794, "svgholder-", 5794, 10, true);
#line 177 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
WriteAttributeValue("", 5804, rootQuestion.Id, 5804, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5821, 38, true);
            WriteLiteral("></div>\r\n            <script>drawTree(");
            EndContext();
            BeginContext(5860, 15, false);
#line 178 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
                        Write(rootQuestion.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5875, 26, true);
            WriteLiteral(")</script>\r\n            <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5901, "\"", 5935, 2);
            WriteAttributeValue("", 5906, "answer-count-", 5906, 13, true);
#line 179 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
WriteAttributeValue("", 5919, rootQuestion.Id, 5919, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5936, 41, true);
            WriteLiteral("></p>\r\n            <script>getNumAnswers(");
            EndContext();
            BeginContext(5978, 15, false);
#line 180 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
                             Write(rootQuestion.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5993, 47, true);
            WriteLiteral(", getNumAnswered)</script>\r\n            <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6040, "\"", 6113, 6);
            WriteAttributeValue("", 6050, "deleteQuestionInfo(", 6050, 19, true);
#line 181 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
WriteAttributeValue("", 6069, rootQuestion.Id, 6069, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 6085, ");", 6085, 2, true);
            WriteAttributeValue(" ", 6087, "hideDiv(", 6088, 9, true);
#line 181 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
WriteAttributeValue("", 6096, rootQuestion.Id, 6096, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 6112, ")", 6112, 1, true);
            EndWriteAttribute();
            BeginContext(6114, 68, true);
            WriteLiteral(">Delete Question?</button>\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
            EndContext();
#line 185 "C:\Users\rober\OneDrive\Code\Flochar\Pages\QuestionForum.cshtml"
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
