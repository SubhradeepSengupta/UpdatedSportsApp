#pragma checksum "C:\Users\subhradeep\Desktop\Asp.net Core Test\SportsApplication\SportsApplication\Views\SportsApplication\AddAthlete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3ff43ba2a36cbeb19c99b70ae9f603e472b191e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SportsApplication_AddAthlete), @"mvc.1.0.view", @"/Views/SportsApplication/AddAthlete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SportsApplication/AddAthlete.cshtml", typeof(AspNetCore.Views_SportsApplication_AddAthlete))]
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
#line 1 "C:\Users\subhradeep\Desktop\Asp.net Core Test\SportsApplication\SportsApplication\Views\_ViewImports.cshtml"
using SportsApplication;

#line default
#line hidden
#line 2 "C:\Users\subhradeep\Desktop\Asp.net Core Test\SportsApplication\SportsApplication\Views\_ViewImports.cshtml"
using SportsApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3ff43ba2a36cbeb19c99b70ae9f603e472b191e", @"/Views/SportsApplication/AddAthlete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e1776ef53efd5b002859436d3ba923f1a376d91", @"/Views/_ViewImports.cshtml")]
    public class Views_SportsApplication_AddAthlete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SportsApplication.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddAthleteAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\subhradeep\Desktop\Asp.net Core Test\SportsApplication\SportsApplication\Views\SportsApplication\AddAthlete.cshtml"
  
    ViewData["Title"] = "AddAthlete";

#line default
#line hidden
            BeginContext(97, 133, true);
            WriteLiteral("\r\n<div class=\"jumbotron\" style=\"margin-top: 3%; text-align: center;\">\r\n    <h2 style=\" margin-bottom:2%;\">Athlete Add Page</h2>\r\n    ");
            EndContext();
            BeginContext(230, 884, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "566b625390f545e3a5b2a5760fa1ad5d", async() => {
                BeginContext(265, 92, true);
                WriteLiteral("\r\n        <label>Name</label>\r\n        <select id=\"Name\" name=\"Name\" class=\"form-control\">\r\n");
                EndContext();
#line 11 "C:\Users\subhradeep\Desktop\Asp.net Core Test\SportsApplication\SportsApplication\Views\SportsApplication\AddAthlete.cshtml"
             foreach (User user in Model)
            {

#line default
#line hidden
                BeginContext(415, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(431, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87d9c3a8557a40f9a72f655c67398485", async() => {
                    BeginContext(440, 9, false);
#line 13 "C:\Users\subhradeep\Desktop\Asp.net Core Test\SportsApplication\SportsApplication\Views\SportsApplication\AddAthlete.cshtml"
                   Write(user.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(458, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 14 "C:\Users\subhradeep\Desktop\Asp.net Core Test\SportsApplication\SportsApplication\Views\SportsApplication\AddAthlete.cshtml"
            }

#line default
#line hidden
                BeginContext(475, 21, true);
                WriteLiteral("        </select>\r\n\r\n");
                EndContext();
#line 17 "C:\Users\subhradeep\Desktop\Asp.net Core Test\SportsApplication\SportsApplication\Views\SportsApplication\AddAthlete.cshtml"
         if (@ViewBag.TestName == "Cooper Test")
        {

#line default
#line hidden
                BeginContext(557, 220, true);
                WriteLiteral("            <div class=\"form-group\" style=\"margin-top: 2%;\">\r\n                <label>Distance</label>\r\n                <input class=\"form-control\" id=\"Distance\" name=\"Distance\" autocomplete=\"off\" />\r\n            </div>\r\n");
                EndContext();
#line 23 "C:\Users\subhradeep\Desktop\Asp.net Core Test\SportsApplication\SportsApplication\Views\SportsApplication\AddAthlete.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(813, 208, true);
                WriteLiteral("            <div class=\"form-group\" style=\"margin-top: 2%;\">\r\n                <label>Time</label>\r\n                <input class=\"form-control\" id=\"Time\" name=\"Time\" autocomplete=\"off\" />\r\n            </div>\r\n");
                EndContext();
#line 30 "C:\Users\subhradeep\Desktop\Asp.net Core Test\SportsApplication\SportsApplication\Views\SportsApplication\AddAthlete.cshtml"
        }

#line default
#line hidden
                BeginContext(1032, 75, true);
                WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-success\">Save</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1114, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SportsApplication.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
