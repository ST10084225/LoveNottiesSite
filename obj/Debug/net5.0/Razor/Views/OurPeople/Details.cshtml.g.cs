#pragma checksum "C:\Users\natha\Desktop\LatestSite\Views\OurPeople\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6920e606f7ba325d67e7366fdec3713ef330918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OurPeople_Details), @"mvc.1.0.view", @"/Views/OurPeople/Details.cshtml")]
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
#line 1 "C:\Users\natha\Desktop\LatestSite\Views\_ViewImports.cshtml"
using LoveNottiesV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natha\Desktop\LatestSite\Views\_ViewImports.cshtml"
using LoveNottiesV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6920e606f7ba325d67e7366fdec3713ef330918", @"/Views/OurPeople/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aedf47f0c0c04b9954ad69be3799438656a63a71", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_OurPeople_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoveNottiesV2.Models.OurPeople>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\natha\Desktop\LatestSite\Views\OurPeople\Details.cshtml"
  
    string fullName = Model.OurPersonFirstName + " " + Model.OurPersonLastName;
    ViewData["Title"] = fullName;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6920e606f7ba325d67e7366fdec3713ef3309183816", async() => {
                WriteLiteral("\r\n    <div class=\"m-5\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <h1>");
#nullable restore
#line 11 "C:\Users\natha\Desktop\LatestSite\Views\OurPeople\Details.cshtml"
               Write(Html.DisplayFor(model => model.OurPersonFirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\natha\Desktop\LatestSite\Views\OurPeople\Details.cshtml"
                                                                   Write(Html.Raw(" "));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\natha\Desktop\LatestSite\Views\OurPeople\Details.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.OurPersonLastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                <h6 class=\"card-subtitle text-muted\">");
#nullable restore
#line 12 "C:\Users\natha\Desktop\LatestSite\Views\OurPeople\Details.cshtml"
                                                Write(Html.DisplayFor(model => model.OurPersonTitle));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n            </div>\r\n\r\n            <div class=\"card-body\">\r\n                <div class=\"box\">\r\n                    <div class=\"justify-content-center\">\r\n                        <image");
                BeginWriteAttribute("src", " src=\"", 695, "\"", 790, 2);
                WriteAttributeValue("", 701, "https://lovenottiesstoragetest.blob.core.windows.net/ourpeopleimages/", 701, 69, true);
#nullable restore
#line 18 "C:\Users\natha\Desktop\LatestSite\Views\OurPeople\Details.cshtml"
WriteAttributeValue("", 770, Model.OurPersonID, 770, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""d-block user-select-none coverImageDetails ImageRoundBorders"" height=""650px"" focusable=""false"" role=""img"" />
                    </div>

                    <div>
                        <dl>
                            <dd class=""col-sm-10"">
                                ");
#nullable restore
#line 24 "C:\Users\natha\Desktop\LatestSite\Views\OurPeople\Details.cshtml"
                           Write(Html.DisplayFor(model => model.OurPersonDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </dd>\r\n                        </dl>\r\n                        <div>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6920e606f7ba325d67e7366fdec3713ef3309186803", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoveNottiesV2.Models.OurPeople> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
