#pragma checksum "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fdea79363200029dd3acad42a45a74da1896b6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Posts_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Posts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Posts/Index.cshtml", typeof(AspNetCore.Areas_Manage_Views_Posts_Index))]
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
#line 1 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
using ShaneMaravillo.SchoolFacilities.Web.Infrastructures.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdea79363200029dd3acad42a45a74da1896b6c", @"/Areas/Manage/Views/Posts/Index.cshtml")]
    public class Areas_Manage_Views_Posts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShaneMaravillo.SchoolFacilities.Web.Areas.Manage.ViewModels.Posts.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Upload Banner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Upload Thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Update Content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Update Title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/posts?pageIndex=1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(162, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_PublicLayout.cshtml";

#line default
#line hidden
            BeginContext(258, 241, true);
            WriteLiteral("\r\n<h2>Manage Posts</h2>\r\n\r\n<div class=\"card-container col-md-8\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <div class=\"input-group mb-3\">\r\n                <input id=\"searchKeyword\" type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 499, "\"", 527, 1);
#line 15 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
WriteAttributeValue("", 507, Model.Posts.Keyword, 507, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(528, 334, true);
            WriteLiteral(@" placeholder=""Search by title"" aria-label=""Search title"" aria-describedby=""basic-addon2"">
                <div class=""input-group-append"">
                    <button class=""btn btn-outline-secondary"" type=""button"" onclick=""searchTrigger()"">Search</button>
                </div>
            </div>
        </div>
    </div>

");
            EndContext();
#line 23 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
      
        if (Model.Posts != null)
        {
            if (Model.Posts.Items.Count > 0)
            {
                foreach (Post post in Model.Posts.Items)
                {

#line default
#line hidden
            BeginContext(1053, 228, true);
            WriteLiteral("                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-sm-3\">\r\n                                    ");
            EndContext();
            BeginContext(1281, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "78c467634dec49738a650e39c6234160", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1291, "~/posts/", 1291, 8, true);
#line 34 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 1299, post.Id, 1299, 8, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1307, "/Shane3.png.jpg", 1307, 15, true);
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
            BeginContext(1360, 138, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-sm-9\">\r\n                                    <h4>");
            EndContext();
            BeginContext(1499, 10, false);
#line 37 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                   Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1509, 46, true);
            WriteLiteral("</h4>\r\n                                    <p>");
            EndContext();
            BeginContext(1556, 16, false);
#line 38 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                  Write(post.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1572, 137, true);
            WriteLiteral("</p>\r\n                                    <ul class=\"list-inline\">\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(1709, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afec10ea23324c8e9aa1bdd08a4fab70", async() => {
                BeginContext(1779, 81, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-image\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1718, "~/manage/posts/update-banner/", 1718, 29, true);
#line 40 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 1747, post.Id, 1747, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1864, 76, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(1940, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1df20b4db9944603a59b330de5a49e7a", async() => {
                BeginContext(2016, 86, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-file-image\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1949, "~/manage/posts/update-thumbnail/", 1949, 32, true);
#line 41 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 1981, post.Id, 1981, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2106, 76, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(2182, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c824eb44ea824fac8ebaaa1662b5aeb2", async() => {
                BeginContext(2254, 84, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-file-alt\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2191, "~/manage/posts/update-content/", 2191, 30, true);
#line 42 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 2221, post.Id, 2221, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2342, 76, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(2418, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b169bce1aa4b0b92b6a3ef3fa11648", async() => {
                BeginContext(2486, 83, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-pen-alt\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2427, "~/manage/posts/update-title/", 2427, 28, true);
#line 43 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 2455, post.Id, 2455, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2573, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 44 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                          
                                            if (post.IsPublished)
                                            {

#line default
#line hidden
            BeginContext(2738, 106, true);
            WriteLiteral("                                                <li class=\"list-inline-item\"><a href=\"#\" title=\"Unpublish\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2844, "\"", 2896, 5);
            WriteAttributeValue("", 2854, "confirmUnpublish(\'", 2854, 18, true);
#line 47 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
WriteAttributeValue("", 2872, post.Id, 2872, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2880, "\',\'", 2880, 3, true);
#line 47 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
WriteAttributeValue("", 2883, post.Title, 2883, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2894, "\')", 2894, 2, true);
            EndWriteAttribute();
            BeginContext(2897, 99, true);
            WriteLiteral("><button class=\"btn-danger form-control-sm\"><i class=\"fas fa-window-close\"></i></button></a></li>\r\n");
            EndContext();
#line 48 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(3140, 104, true);
            WriteLiteral("                                                <li class=\"list-inline-item\"><a href=\"#\" title=\"Publish\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3244, "\"", 3294, 5);
            WriteAttributeValue("", 3254, "confirmPublish(\'", 3254, 16, true);
#line 51 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
WriteAttributeValue("", 3270, post.Id, 3270, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3278, "\',\'", 3278, 3, true);
#line 51 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
WriteAttributeValue("", 3281, post.Title, 3281, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3292, "\')", 3292, 2, true);
            EndWriteAttribute();
            BeginContext(3295, 100, true);
            WriteLiteral("><button class=\"btn-success form-control-sm\"><i class=\"fas fa-check-square\"></i></button></a></li>\r\n");
            EndContext();
#line 52 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                            }
                                        

#line default
#line hidden
            BeginContext(3485, 179, true);
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 59 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                }




#line default
#line hidden
            BeginContext(3689, 83, true);
            WriteLiteral("                <ul class=\"pagination\">\r\n                    <li class=\"page-item\">");
            EndContext();
            BeginContext(3772, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ddd4c56789547d8b7416b28f7429d04", async() => {
                BeginContext(3827, 5, true);
                WriteLiteral("First");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3836, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 65 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                       if (Model.Posts.PageIndex > 1)
                        {

#line default
#line hidden
            BeginContext(3925, 50, true);
            WriteLiteral("                            <li class=\"page-item\">");
            EndContext();
            BeginContext(3975, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6844a3b118bd407da082af6e9edab25e", async() => {
                BeginContext(4059, 25, false);
#line 67 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                                                                                                                Write(Model.Posts.PageIndex - 1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4002, "~/manage/posts?pageIndex=", 4002, 25, true);
#line 67 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 4027, Model.Posts.PageIndex - 1, 4027, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4089, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 68 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(4146, 78, true);
            WriteLiteral("                    <li class=\"page-item\"><a class=\"page-link active href=\"#\">");
            EndContext();
            BeginContext(4226, 21, false);
#line 70 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                                                          Write(Model.Posts.PageIndex);

#line default
#line hidden
            EndContext();
            BeginContext(4248, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 71 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                       if ((Model.Posts.PageIndex + 1) <= Model.Posts.PageCount)
                        {

#line default
#line hidden
            BeginContext(4368, 50, true);
            WriteLiteral("                            <li class=\"page-item\">");
            EndContext();
            BeginContext(4418, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d6180a79d884a2097c1a4573a464b98", async() => {
                BeginContext(4502, 25, false);
#line 73 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                                                                                                                Write(Model.Posts.PageIndex + 1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4445, "~/manage/posts?pageIndex=", 4445, 25, true);
#line 73 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 4470, Model.Posts.PageIndex + 1, 4470, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4532, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 74 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(4589, 42, true);
            WriteLiteral("                    <li class=\"page-item\">");
            EndContext();
            BeginContext(4631, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bcedf39ca8a404fb5f46385d7be83d6", async() => {
                BeginContext(4707, 4, true);
                WriteLiteral("Last");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4658, "~/manage/posts?pageIndex=", 4658, 25, true);
#line 76 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 4683, Model.Posts.PageCount, 4683, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4715, 30, true);
            WriteLiteral("</li>\r\n                </ul>\r\n");
            EndContext();
#line 78 "C:\Users\Shayne Maravillo\Desktop\schoolfacilites2\ShaneMaravillo.SchoolFacilities.Web\Areas\Manage\Views\Posts\Index.cshtml"
            }
        }
    

#line default
#line hidden
            BeginContext(4778, 1862, true);
            WriteLiteral(@"
</div>

<!--MODAL-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-unpublish"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Unpublish Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to unpublish <span id=""modal-unpublish-title""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-unpublish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

<!--MODAL-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-publish"">
");
            WriteLiteral(@"    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Publish Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to publish <span id=""modal-publish-title""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-publish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("pageStyles", async() => {
                BeginContext(6660, 254, true);
                WriteLiteral("\r\n    <style>\r\n        h2 {\r\n            margin-top: 30px;\r\n        }\r\n\r\n        .card-container {\r\n            margin-bottom: 30px;\r\n        }\r\n\r\n        .card {\r\n            margin-top: 15px;\r\n            margin-bottom: 15px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(6917, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("pageScripts", async() => {
                BeginContext(6942, 2235, true);
                WriteLiteral(@"
    <script>

        //////////////////////SEARCH/////////////////////////////////////////////////////////////////
        function searchTrigger() {
            window.location = ""/manage/posts?pageIndex=1&keyword="" + $(""#searchKeyword"").val();
        }

        $(""#searchKeyword"").keyup(function (event) {
            if (event.keyCode === 13) {
                searchTrigger();
            }
        });


        ////////////////////UNPUBLISH/////////////////////////////////////////////////////////////////
        function confirmUnpublish(id, title) {
            $(""#modal-unpublish-title"").html(title);
            $(""#modal-unpublish-button"").attr(""onclick"", ""unPublishPost('"" + id + ""')"");
            $(""#modal-unpublish"").modal(""show"");
        }

        function unPublishPost(id) {
            $.ajax({
                type: ""POST"",
                url: ""/manage/posts/unpublish"",
                data: { id: id },
                success: function (data) {
                  ");
                WriteLiteral(@"  location.reload();
                },
                error: function (xhr) {
                    var response = JSON.parse(xhr.responseText);
                    alert(""Error Occured : "" + response.errors[0]);
                    location.reload();
                }
            });
        }

        //////////////////PUBLISH///////////////////////////////////////////////////////////////////////
        function confirmPublish(id, title) {
            $(""#modal-publish-title"").html(title);
            $(""#modal-publish-button"").attr(""onclick"", ""publishPost('"" + id + ""')"");
            $(""#modal-publish"").modal(""show"");
        }

        function publishPost(id) {
            $.ajax({
                type: ""POST"",
                url: ""/manage/posts/publish"",
                data: { id: id },
                success: function (data) {
                    location.reload();
                },
                error: function (xhr) {
                    var response = JSON.parse(xhr.");
                WriteLiteral("responseText);\r\n                    alert(\"Error Occured : \" + response.errors[0]);\r\n                    location.reload();\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(9180, 30, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShaneMaravillo.SchoolFacilities.Web.Areas.Manage.ViewModels.Posts.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
