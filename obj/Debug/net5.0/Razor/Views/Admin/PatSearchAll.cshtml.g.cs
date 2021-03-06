#pragma checksum "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Admin\PatSearchAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "892a147b9c49e742f41447337263259e280a35a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PatSearchAll), @"mvc.1.0.view", @"/Views/Admin/PatSearchAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892a147b9c49e742f41447337263259e280a35a0", @"/Views/Admin/PatSearchAll.cshtml")]
    public class Views_Admin_PatSearchAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Admin\PatSearchAll.cshtml"
  
    ViewData["Title"] = "Patient Search";
    Layout = "~/Views/Admin/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "892a147b9c49e742f41447337263259e280a35a03973", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "892a147b9c49e742f41447337263259e280a35a04296", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <title>Patient Registration</title>
    <style>
        form {
            width: 300px;
        }
    </style>
    <script>//function passwordCheck() {
        //    var pass = document.getElementById(""Password"").value;
        //    var repass = document.getElementById(""txtReType"").value;
        //    if (pass != repass)
        //        alert(""Password Mismatch"");
        //}</script>
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "892a147b9c49e742f41447337263259e280a35a06577", async() => {
                WriteLiteral("\n\n    <h1 id=\"main\" class=\"alert alert-success\">Patient Directory</h1>\n    <hr />\n    <div>");
#nullable restore
#line 31 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Admin\PatSearchAll.cshtml"
    Write(Html.ActionLink("View All", "PatViewAll", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n    <div class=\"row\">\n        <div class=\"col-md-4\">\n");
#nullable restore
#line 34 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Admin\PatSearchAll.cshtml"
             using (Html.BeginForm("PatSearch", "Admin", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Admin\PatSearchAll.cshtml"
           Write(Html.LabelFor(m => m.Name, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Admin\PatSearchAll.cshtml"
           Write(Html.EditorFor(m => m.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button class=\"btn btn-primary\">Register Patient</button>\n");
#nullable restore
#line 41 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Admin\PatSearchAll.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n    </div>\n    <section>\n        ");
#nullable restore
#line 45 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Admin\PatSearchAll.cshtml"
   Write(Html.ActionLink("Back to Login", "Login", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </section>\n    <section class=\"alert alert-danger\">\n        ");
#nullable restore
#line 48 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Admin\PatSearchAll.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </section>\n\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\n");
#nullable restore
#line 52 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Admin\PatSearchAll.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                    WriteLiteral("    ");
                }
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicManagementProject.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
