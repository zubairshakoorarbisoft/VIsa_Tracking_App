#pragma checksum "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b306c041d25469b53d22585db219ea4e03878746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enrollments_Details), @"mvc.1.0.view", @"/Views/Enrollments/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b306c041d25469b53d22585db219ea4e03878746", @"/Views/Enrollments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c386873f4b79fe8cdbc005b4b89241bd744c5dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Enrollments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VisaTracking.Models.Enrollment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("download", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h4>Enrollment Details</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CNICNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.CNICNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PassportNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.PassportNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastQualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastQualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 42 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplyForCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplyForCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GradesObtained));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.GradesObtained));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 54 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrefferedCourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 57 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrefferedCourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UniversityPreference1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 63 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.UniversityPreference1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 66 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UniversityPreference2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 69 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.UniversityPreference2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 72 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 75 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 78 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 81 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 84 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 87 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.CurrentAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 90 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VisaStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 93 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.VisaStatus.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 96 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FeePaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 99 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
       Write(Html.DisplayFor(model => model.FeePaid));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
</div>
<div class=""row"">
    <div class=""col-md-6"">
        <section>
            <h4>Attachments</h4>
            <hr>
            <div>
                <table class=""table table-responsive-sm table-bordered"">
                    <tr>
                        <th>Attached Documents</th>
                        <th>Actions</th>
                    </tr>
");
#nullable restore
#line 114 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
                     if (Model.EnrollmentAttachedDocuments.Any())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
                         foreach (var documentName in Model.EnrollmentAttachedDocuments)
                        {
                            string[] seprator = { "10___01" };

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 120 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
                               Write(documentName.Name.Split(seprator, System.StringSplitOptions.RemoveEmptyEntries)[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b306c041d25469b53d22585db219ea4e0387874618124", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4367, "~/enrollmentDocuments/", 4367, 22, true);
#nullable restore
#line 121 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
AddHtmlAttributeValue("", 4389, documentName.Name, 4389, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" | ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b306c041d25469b53d22585db219ea4e0387874619849", async() => {
                WriteLiteral("Download");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4472, "~/enrollmentDocuments/", 4472, 22, true);
#nullable restore
#line 121 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
AddHtmlAttributeValue("", 4494, documentName.Name, 4494, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 123 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"2\" class=\"text-center\">No document attached with this enrollment yet</td>\r\n                        </tr>\r\n");
#nullable restore
#line 130 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n\r\n            </div>\r\n        </section>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b306c041d25469b53d22585db219ea4e0387874622660", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4976, "display:", 4976, 8, true);
#nullable restore
#line 138 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
AddHtmlAttributeValue("", 4984, Model.VisaStatusId == 9? "none": "", 4984, 38, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 138 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Details.cshtml"
                                                                                                          WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b306c041d25469b53d22585db219ea4e0387874625551", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VisaTracking.Models.Enrollment> Html { get; private set; }
    }
}
#pragma warning restore 1591
