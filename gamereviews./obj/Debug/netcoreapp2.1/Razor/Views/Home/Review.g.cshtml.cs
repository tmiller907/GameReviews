#pragma checksum "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\Home\Review.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec9b523a4d2929800efebfc8a96083bb40b02bb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Review), @"mvc.1.0.view", @"/Views/Home/Review.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Review.cshtml", typeof(AspNetCore.Views_Home_Review))]
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
#line 1 "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\_ViewImports.cshtml"
using GameReviews;

#line default
#line hidden
#line 2 "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\_ViewImports.cshtml"
using GameReviews.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec9b523a4d2929800efebfc8a96083bb40b02bb7", @"/Views/Home/Review.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d10c0ef9008442afd3d5bf99e1444b80a638a2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Review : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameReviews.Models.GameReview>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\Home\Review.cshtml"
  
    ViewBag.Title = Model.Name;

#line default
#line hidden
            BeginContext(80, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(87, 10, false);
#line 7 "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\Home\Review.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(97, 121, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"well\">\r\n            <h5><label>Name:</label> ");
            EndContext();
            BeginContext(219, 10, false);
#line 12 "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\Home\Review.cshtml"
                                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(229, 51, true);
            WriteLiteral("</h5>\r\n            <h5><label>Description:</label> ");
            EndContext();
            BeginContext(281, 17, false);
#line 13 "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\Home\Review.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(298, 49, true);
            WriteLiteral("</h5>\r\n            <h5><label>Website:</label> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 347, "\"", 368, 1);
#line 14 "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\Home\Review.cshtml"
WriteAttributeValue("", 354, Model.Website, 354, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(369, 18, true);
            WriteLiteral(" target=\"_blank\"> ");
            EndContext();
            BeginContext(388, 13, false);
#line 14 "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\Home\Review.cshtml"
                                                                             Write(Model.Website);

#line default
#line hidden
            EndContext();
            BeginContext(401, 56, true);
            WriteLiteral("</a></h5>\r\n            <h5><label>Rating:</label></h5>\r\n");
            EndContext();
#line 16 "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\Home\Review.cshtml"
                 for (var i = 0; i < Model.Stars; i++)
                    {

#line default
#line hidden
            BeginContext(534, 30, true);
            WriteLiteral("<img src=\"/Images/star.jpg\" />");
            EndContext();
#line 17 "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\Home\Review.cshtml"
                                                   }

#line default
#line hidden
            BeginContext(567, 87, true);
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n    <div>\r\n        <div class=\"col-md-6\">\r\n            ");
            EndContext();
            BeginContext(654, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1dad82e4688b4ab5b05d781d8e3402d8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 664, "~/images/", 664, 9, true);
#line 24 "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\Home\Review.cshtml"
AddHtmlAttributeValue("", 673, Model.MainPicture, 673, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 25 "C:\Users\Thomas\Desktop\Junk\GameReviews\GameReviews\Views\Home\Review.cshtml"
AddHtmlAttributeValue("", 716, Model.Name, 716, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(753, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameReviews.Models.GameReview> Html { get; private set; }
    }
}
#pragma warning restore 1591