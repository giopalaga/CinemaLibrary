#pragma checksum "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Movie\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d881243d683e962b432cb8b1cb684b0ffe8650a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Add), @"mvc.1.0.view", @"/Views/Movie/Add.cshtml")]
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
#line 1 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\_ViewImports.cshtml"
using CinemaLibraryWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\_ViewImports.cshtml"
using CinemaLibraryWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d881243d683e962b432cb8b1cb684b0ffe8650a7", @"/Views/Movie/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd332e7d858180cb33a7ebacca06239e0e713e10", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movie_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
.mainDiv{
display: flex;
}
form:nth-child(1){
width: 80%;
}
.inputMain{
    padding: 4px;
    margin-bottom: 1%;
    width: 80%;
    display: block;
}
img{
width: 40%;
height: 40%;
} 
.sd{
width: 80%;
margin-top: 1%;
color: #fff;
font-family: ""Segoe UI"",serif;
font-weight: 400;
border-radius: 2px;
border: none;
padding: 4px;
background-color: #007bff;
}
.sd:hover{
    background-color: #006ce0;
}
#posterInput{
width: 60%;
}
#checkImage{
width: 18%;
height: 35px;
color: #fff;
font-family: ""Segoe UI"",serif;
font-weight: 400;
border-radius: 2px;
border: none;
margin-top: 0;
margin-left: 1%;
background-color: #007bff;
}
</style>
");
#nullable restore
#line 48 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Movie\Add.cshtml"
    if (ViewBag.userRole != "admin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n           window.location.href=\"../Auth\";\r\n        </script>\r\n");
#nullable restore
#line 53 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Movie\Add.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mainDiv\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d881243d683e962b432cb8b1cb684b0ffe8650a75273", async() => {
                WriteLiteral(@"
        <h3>Name</h3>
        <input name=""Name"" style=""margin-right: 2%"" class=""inputMain"" required>

        <h3>Release date </h3>
        <input type=""date"" name=""ReleaseDate"" class=""inputMain"" required>

        <h3>Rating</h3>
        <input name=""IMDB"" class=""inputMain"" required>

        <h3>RT %</h3>
        <input name=""RottenTomatoes"" class=""inputMain"" required>

        <h3>Poster</h3>
        <div class=""mainDiv"">
            <input name=""Poster"" class=""inputMain"" id=""posterInput"" required>
            <input type=""button"" id=""checkImage"" value=""Check"" onclick=""Check()""/>
        </div>

        <h3>Genre</h3>
        <select name=""Genre"" class=""inputMain"" required>
");
#nullable restore
#line 76 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Movie\Add.cshtml"
             foreach (var genre in ViewBag.genres)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d881243d683e962b432cb8b1cb684b0ffe8650a76560", async() => {
#nullable restore
#line 78 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Movie\Add.cshtml"
                                     Write(genre.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Movie\Add.cshtml"
                   WriteLiteral(genre.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Movie\Add.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n\r\n        <h3>Description</h3>\r\n        <textarea name=\"Description\" class=\"inputMain\" required></textarea>\r\n\r\n        <input type=\"submit\" class=\"sd\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <img src=""https://thumbs.dreamstime.com/b/no-image-available-icon-flat-vector-no-image-available-icon-flat-vector-illustration-132482953.jpg"" alt=""picture"" id=""pic""/>
</div>


<script>
    const Check = () =>{
        let url = document.getElementById(""posterInput"").value;
        if (url != null){
            document.getElementById(""pic"").setAttribute(""src"", url);
        }
    }
</script>");
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
