#pragma checksum "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96c3bc63a8433d759b89b25bc7f2eba37f85b075"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enrollments_Delete), @"mvc.1.0.view", @"/Views/Enrollments/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96c3bc63a8433d759b89b25bc7f2eba37f85b075", @"/Views/Enrollments/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c386873f4b79fe8cdbc005b4b89241bd744c5dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Enrollments_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VisaTracking.Models.Enrollment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h4>Are you sure you want to delete this Enrollment?</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ContactNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CNICNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CNICNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 42 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PassportNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PassportNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastQualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastQualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 54 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplyForCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 57 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ApplyForCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GradesObtained));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 63 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GradesObtained));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 66 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrefferedCourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 69 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrefferedCourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 72 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UniversityPreference1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 75 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UniversityPreference1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 78 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UniversityPreference2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 81 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UniversityPreference2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 84 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 87 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 90 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 93 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CurrentAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 96 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VisaStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 99 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VisaStatus.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 102 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FeePaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 105 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FeePaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 108 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Remarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <textarea class=\"form-control\" readonly>");
#nullable restore
#line 111 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
                                               Write(Model.Remarks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c3bc63a8433d759b89b25bc7f2eba37f85b07517167", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "96c3bc63a8433d759b89b25bc7f2eba37f85b07517434", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 116 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Enrollments\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Yes\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c3bc63a8433d759b89b25bc7f2eba37f85b07519232", async() => {
                    WriteLiteral("No");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
