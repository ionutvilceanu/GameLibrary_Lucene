#pragma checksum "D:\GameLibrary_Lucene\GameLibrary\Views\Categories\newindex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cb64f1c159496b57e575847b45da60277da36d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_newindex), @"mvc.1.0.view", @"/Views/Categories/newindex.cshtml")]
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
#line 1 "D:\GameLibrary_Lucene\GameLibrary\Views\_ViewImports.cshtml"
using GameLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GameLibrary_Lucene\GameLibrary\Views\_ViewImports.cshtml"
using GameLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cb64f1c159496b57e575847b45da60277da36d1", @"/Views/Categories/newindex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec61dbb817e65adc1b67baa1f242ffffda84c22", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_newindex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameLibrary.ViewModels.CategoryBookViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CategoryDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString(".site-navbar-target"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-offset", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cb64f1c159496b57e575847b45da60277da36d15540", async() => {
                WriteLiteral(@"
    <title>Books &mdash; Offers</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">


    <link href=""https://fonts.googleapis.com/css?family=Cinzel:400,700|Montserrat:400,700|Roboto&display=swap"" rel=""stylesheet"">

    <link rel=""stylesheet"" href=""/fonts/icomoon/style.css"">

    <link rel=""stylesheet"" href=""/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""/css/jquery-ui.css"">
    <link rel=""stylesheet"" href=""/css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""/css/owl.theme.default.min.css"">
    <link rel=""stylesheet"" href=""/css/owl.theme.default.min.css"">

    <link rel=""stylesheet"" href=""/css/jquery.fancybox.min.css"">

    <link rel=""stylesheet"" href=""/css/bootstrap-datepicker.css"">

    <link rel=""stylesheet"" href=""/fonts/flaticon/font/flaticon.css"">

    <link rel=""stylesheet"" href=""/css/aos.css"">
    <link href=""/css/jquery.mb.YTPlayer.min.css"" media=""all"" rel=""stylesheet"" type=""text/css"">");
                WriteLiteral("\r\n\r\n    <link rel=\"stylesheet\" href=\"/css/style.css\">\r\n\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cb64f1c159496b57e575847b45da60277da36d17701", async() => {
                WriteLiteral("\r\n    <p>\r\n        Category: <input type=\"text\" name=\"SearchString\">\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cb64f1c159496b57e575847b45da60277da36d19686", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 51 "D:\GameLibrary_Lucene\GameLibrary\Views\Categories\newindex.cshtml"
                 foreach (Category item in Model.Categories)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>\r\n                        <ul class=\"links\">\r\n                            <center>\r\n                                <ul>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 1785, "\"", 1861, 1);
#nullable restore
#line 57 "D:\GameLibrary_Lucene\GameLibrary\Views\Categories\newindex.cshtml"
WriteAttributeValue("", 1792, Url.Action("BookDetails", "Categories", new { id = item.CategoryID}), 1792, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1862, "\"", 1888, 1);
#nullable restore
#line 57 "D:\GameLibrary_Lucene\GameLibrary\Views\Categories\newindex.cshtml"
WriteAttributeValue("", 1870, item.CategoryName, 1870, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"links\">\r\n                                        <img class=\"img-responsive\"");
                BeginWriteAttribute("src", " src=\"", 1973, "\"", 2026, 1);
#nullable restore
#line 58 "D:\GameLibrary_Lucene\GameLibrary\Views\Categories\newindex.cshtml"
WriteAttributeValue("", 1979, Url.Content("~/images/" + @item.CategoryImage), 1979, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" height=\"450\" width=\"400\"");
                BeginWriteAttribute("alt", " alt=\"", 2052, "\"", 2058, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    </a>\r\n                                </ul>\r\n                                ");
#nullable restore
#line 61 "D:\GameLibrary_Lucene\GameLibrary\Views\Categories\newindex.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
                WriteLiteral("                            </center>\r\n                        </ul>\r\n                    </td>\r\n");
#nullable restore
#line 66 "D:\GameLibrary_Lucene\GameLibrary\Views\Categories\newindex.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>

    <!-- .site-wrap -->
    <!-- loader -->
    <div id=""loader"" class=""show fullscreen""><svg class=""circular"" width=""48px"" height=""48px""><circle class=""path-bg"" cx=""24"" cy=""24"" r=""22"" fill=""none"" stroke-width=""4"" stroke=""#eeeeee"" /><circle class=""path"" cx=""24"" cy=""24"" r=""22"" fill=""none"" stroke-width=""4"" stroke-miterlimit=""10"" stroke=""#ff5e15"" /></svg></div>

    <script src=""/js/jquery-3.3.1.min.js""></script>
    <script src=""/js/jquery-migrate-3.0.1.min.js""></script>
    <script src=""/js/jquery-ui.js""></script>
    <script src=""/js/popper.min.js""></script>
    <script src=""/js/bootstrap.min.js""></script>
    <script src=""/js/owl.carousel.min.js""></script>
    <script src=""/js/jquery.stellar.min.js""></script>
    <script src=""/js/jquery.countdown.min.js""></script>
    <script src=""/js/bootstrap-datepicker.min.js""></script>
    <script src=""/js/jquery.easing.1.3.js""></script>
    <script src=""/js/aos.js""></script>
    <script src=""/js/jquery.fancybox.min.js""></script>
    <script");
                WriteLiteral(" src=\"/js/jquery.sticky.js\"></script>\r\n    <script src=\"/js/jquery.mb.YTPlayer.min.js\"></script>\r\n\r\n\r\n\r\n\r\n    <script src=\"/js/main.js\"></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</html>
<script src=""/js/jquery-3.3.1.min.js""></script>
<script src=""/js/jquery-migrate-3.0.1.min.js""></script>
<script src=""/js/jquery-ui.js""></script>
<script src=""/js/popper.min.js""></script>
<script src=""/js/bootstrap.min.js""></script>
<script src=""/js/owl.carousel.min.js""></script>
<script src=""/js/jquery.stellar.min.js""></script>
<script src=""/js/jquery.countdown.min.js""></script>
<script src=""/js/bootstrap-datepicker.min.js""></script>
<script src=""/js/jquery.easing.1.3.js""></script>
<script src=""/js/aos.js""></script>
<script src=""/js/jquery.fancybox.min.js""></script>
<script src=""/js/jquery.sticky.js""></script>
<script src=""/js/jquery.mb.YTPlayer.min.js""></script>




<script src=""/js/main.js""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameLibrary.ViewModels.CategoryBookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
