#pragma checksum "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74275e20b3573635688d297449daff6bdb2b84f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enrollments_Index), @"mvc.1.0.view", @"/Views/Enrollments/Index.cshtml")]
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
#line 1 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\_ViewImports.cshtml"
using VisaTracking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\_ViewImports.cshtml"
using VisaTracking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\_ViewImports.cshtml"
using VisaTracking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74275e20b3573635688d297449daff6bdb2b84f0", @"/Views/Enrollments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c386873f4b79fe8cdbc005b4b89241bd744c5dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Enrollments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VisaTracking.Models.Enrollment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Enrollments</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-1\">\r\n        ");
#nullable restore
#line 10 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
   Write(Html.ActionLink("+", "Create", "Enrollments", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-2\">\r\n");
#nullable restore
#line 13 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
          
            if (ViewBag.IsShowClosed)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
           Write(Html.ActionLink("Show In Progress", "Index", "Enrollments", new { IsShowClosed = false }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
                                                                                                                                              
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
           Write(Html.ActionLink("Show Closed", "Index", "Enrollments", new { IsShowClosed = true }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
                                                                                                                                       
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row text-center\">\r\n");
#nullable restore
#line 28 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
     if (TempData["SuccessMessage"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"alert alert-success\">");
#nullable restore
#line 30 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
                                     Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 31 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<table class=\"display nowrap\" id=\"enrollments\" style=\"width:100%;\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CNICNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ApplyForCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GradesObtained));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CurrentAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ApplicationStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VisaStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>Actions</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 61 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CNICNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ApplyForCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.GradesObtained));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CurrentAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td> \r\n                <td>\r\n                    ");
#nullable restore
#line 80 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ApplicationStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("style", " style=\"", 2621, "\"", 2678, 2);
            WriteAttributeValue("", 2629, "color:", 2629, 6, true);
#nullable restore
#line 82 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
WriteAttributeValue("", 2635, item.VisaStatusId == 9? "green": "black", 2635, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <strong>");
#nullable restore
#line 83 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.VisaStatus.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74275e20b3573635688d297449daff6bdb2b84f014559", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74275e20b3573635688d297449daff6bdb2b84f016860", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2958, "display:", 2958, 8, true);
#nullable restore
#line 87 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
AddHtmlAttributeValue("", 2966, item.VisaStatusId == 9? "none": "", 2966, 37, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
                                                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74275e20b3573635688d297449daff6bdb2b84f019781", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3118, "display:", 3118, 8, true);
#nullable restore
#line 88 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
AddHtmlAttributeValue("", 3126, item.VisaStatusId == 9? "none": "", 3126, 37, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
                                                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 91 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<script>\r\n\r\n    $(document).ready(function () {\r\n        $(\'#enrollments\').DataTable({\r\n            \"scrollY\": true,\r\n            \"scrollX\": true,\r\n            \"order\": [[5, \"desc\"]]\r\n        } );\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VisaTracking.Models.Enrollment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
