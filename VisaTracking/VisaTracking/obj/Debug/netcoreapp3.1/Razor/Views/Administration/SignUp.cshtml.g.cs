#pragma checksum "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "248761f80c5803191c57ed2894767591acb127af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_SignUp), @"mvc.1.0.view", @"/Views/Administration/SignUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"248761f80c5803191c57ed2894767591acb127af", @"/Views/Administration/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c386873f4b79fe8cdbc005b4b89241bd744c5dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignUpViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-file-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("customFile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
 using (Html.BeginForm("SignUp", "Administration", FormMethod.Post, new { @id = "SignUpForm", @enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section>\r\n        <div class=\"container\">\r\n            ");
#nullable restore
#line 6 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
       Write(Html.ValidationSummary(null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""row justify-content-center"">

                <div class=""col-12"">
                    <div class=""row"">
                        <div class=""col text-center"">
                            <h1>User Registration</h1>
                        </div>
                    </div>
                    <div class=""row align-items-center mt-4"">
                        <div class=""col"">
                            ");
#nullable restore
#line 17 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
                       Write(Html.TextBoxFor(model => model.EmailAddress, new { @class = "form-control", placeholder = "Email Address" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 18 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
                       Write(Html.ValidationMessageFor(model => model.EmailAddress, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row align-items-center mt-4\">\r\n                        <div class=\"col\">\r\n                            ");
#nullable restore
#line 23 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
                       Write(Html.TextBoxFor(model => model.Password, new { @class = "form-control", placeholder = "Password", type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 24 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Password, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col\">\r\n                            ");
#nullable restore
#line 27 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
                       Write(Html.TextBoxFor(model => model.ConfirmPassword, new { @class = "form-control", placeholder = "Confirm Password", type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 28 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
                       Write(Html.ValidationMessageFor(model => model.ConfirmPassword, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row align-items-center\">\r\n                        <div class=\"col mt-4\">\r\n                            ");
#nullable restore
#line 33 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
                       Write(Html.DropDownList("RoleId", new SelectList(Model.UserRoles, "Id", "Name"), "Select Role", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 34 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
                       Write(Html.ValidationMessageFor(model => model.RoleId, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""row align-items-center"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "248761f80c5803191c57ed2894767591acb127af10047", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 41 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProfileImage);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"custom-file\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "248761f80c5803191c57ed2894767591acb127af11687", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 43 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProfileImage);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <label class=\"custom-file-label\" for=\"customFile\">Choose Profile Picture</label>\r\n                                </div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "248761f80c5803191c57ed2894767591acb127af13504", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 46 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProfileImage);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""row justify-content-start mt-4"">
                        <div class=""col"">
                            <button type=""submit"" class=""btn btn-primary mt-4"">Register</button>
                            <a href=""/"" class=""btn btn-danger mt-4"">Cancel</a>
                        </div>
                    </div>
                </div>


            </div>
        </div>
    </section>
");
#nullable restore
#line 62 "D:\zubair\DotNet\VIsa_Tracking_App\VisaTracking\VisaTracking\Views\Administration\SignUp.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>

    $(document).ready(function () {

        // Add the following code if you want the name of the file appear on select
        $("".custom-file-input"").on(""change"", function () {
            var fileName = $(this).val().split(""\\"").pop();
            console.log(fileName);
            $(this).siblings("".custom-file-label"").addClass(""selected"").html(fileName);
        });
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignUpViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
