#pragma checksum "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1d519ded92777095bc7f04ce964250405969eb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_PendingPaymentList), @"mvc.1.0.view", @"/Views/Patient/PendingPaymentList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d519ded92777095bc7f04ce964250405969eb5", @"/Views/Patient/PendingPaymentList.cshtml")]
    public class Views_Patient_PendingPaymentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClinicManagementProject.Models.ConsultationDetail>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1d519ded92777095bc7f04ce964250405969eb53089", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>PendingPaymentList</title>\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1d519ded92777095bc7f04ce964250405969eb54153", async() => {
                WriteLiteral("\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            \n            <th>\n                ");
#nullable restore
#line 21 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Doctor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </th>\n\n            <th>\n                ");
#nullable restore
#line 25 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Consultation_Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Consultation_Remarks));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </th>\n\n            <th>\n                ");
#nullable restore
#line 32 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Bill));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 38 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\n            \n            <td>\n                ");
#nullable restore
#line 42 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Doctor_Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n \n            <td>\n                ");
#nullable restore
#line 46 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Consultation_Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 49 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Consultation_Remarks));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n\n            <td>\n                ");
#nullable restore
#line 53 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bill));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 56 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
           Write(Html.ActionLink("Pay Bill", "PayBill", "Patient", new { consultationid = item.Consultation_Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 59 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\n</table>\n<section>\n    ");
#nullable restore
#line 63 "C:\CollaberaTraining\July05Tim\Tim\ClinicManagementProject-main\Views\Patient\PendingPaymentList.cshtml"
Write(Html.ActionLink("Return to Main Page", "PatientConsole", "Patient"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n</section>\n");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClinicManagementProject.Models.ConsultationDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591