#pragma checksum "C:\Users\DELL\Downloads\LoveNottiesSite-NathanTwo\LoveNottiesSite-NathanTwo\Views\Recycling\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "502232b032b0b77225dea750a7e39befc20cce31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recycling_Index), @"mvc.1.0.view", @"/Views/Recycling/Index.cshtml")]
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
#line 1 "C:\Users\DELL\Downloads\LoveNottiesSite-NathanTwo\LoveNottiesSite-NathanTwo\Views\_ViewImports.cshtml"
using LoveNottiesV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Downloads\LoveNottiesSite-NathanTwo\LoveNottiesSite-NathanTwo\Views\_ViewImports.cshtml"
using LoveNottiesV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"502232b032b0b77225dea750a7e39befc20cce31", @"/Views/Recycling/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"122b4bc046ea47ef831bbc3016da3d530c42cfa6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Recycling_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>

    .recylingHearder {
        background-color: #2233;
        height: 300px;
        width: 400px;
        margin-top: 30px;
        border: 2px solid #3424;
    }


    .temp {
        height: 300px;
        width: 400px;
        margin-top: 30px;
        background-color: #2233;
    }

    .inside {
        height: 50%;
        width: 100%;
        background-color: #3424;
    }

    .insideTwo {
        position: relative;
        top: 160px;
        right: 0;
        width: 609px;
        height: 400px;
        background-color: #3424;
        float: right;
    }

    .recylingHearderTwo {
        background-color: #2233;
        height: 300px;
        width: 400px;
        margin-top: 30px;
        border: 2px solid #3424;
    }


    .external {
        border-radius: 5px;
        border: 2px solid #046737;
        padding: 40px;
        height: 300px;
        width: 800px;
        background-color: #65ba91;
    }

    .imageOne {
        max-height: 100px;
        max-width: 100px;
        b");
            WriteLiteral(@"order: 2px solid #046737;
        display: flex; /* Use flexbox for centering */
        justify-content: center; /* Horizontally center the child */
        padding: 10px;
        padding-bottom: 40px;
    }

    .image-container {
        width: 300px; /* Set the width of the div */
        height: 200px; /* Set the height of the div */
        border: 1px solid #ccc; /* Optional border style */
        /* Add any other styling as needed */
    }

        /* Style for the image */
        .image-container img {
            width: 100%; /* Make the image width 100% of the div's width */
            height: 100%; /* Make the image height 100% of the div's height */
            object-fit: cover; /* Maintain the aspect ratio and cover the entire container */
        }

    .GI-Maps {
        border-radius: 5px;
        border: 2px solid #046737;
        padding: 20px;
        height: 426px;
        width: 100%;
        background-color: #65ba91;
    }

    .emMap {
        border-radius: 5px;
        border: 2");
            WriteLiteral(@"px solid #333;
        background-color: azure;
        padding-top: 10px;
        width: 400px;
        height: 400px;
        float: right;
    }

        .emMap iframe {
            border-radius: 5px;
            width: 100%;
            height: 100%;
            border: none;
        }

    .map-header {
        border-radius: 5px;
        border: 2px solid #333;
        background-color: azure;
        padding-bottom: 10px;
        padding-top: 10px;
        width: 800px;
        height: 400px;
        float: left;
    }
</style>





");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "502232b032b0b77225dea750a7e39befc20cce315868", async() => {
                WriteLiteral(@"
    <h1 style=""text-align:center"">Recycling</h1>

    <div>
        <div class=""box"">

            <div class=""external"">
            </div>

            <div class=""external"">
            </div>

        </div>


        <div class=""GI-Maps"">


            <div class=""emMap"">
                <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3477.521859425865!2d29.989993675527572!3d-29.35500547527793!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1ef3f9323e175d55%3A0x16e04c900668b838!2sLove%20Notties!5e0!3m2!1sen!2sza!4v1693835417430!5m2!1sen!2sza""></iframe>

            </div>


        </div>


        <br />
        <br>
        <br />
        <br />
    </div>


");
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
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
