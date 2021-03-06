#pragma checksum "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfeeecd7945131ac399330da7fc4c8b2bb22c825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actor_Details), @"mvc.1.0.view", @"/Views/Actor/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfeeecd7945131ac399330da7fc4c8b2bb22c825", @"/Views/Actor/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd332e7d858180cb33a7ebacca06239e0e713e10", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Actor_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
.main {
    display: flex;
    width: 90%;
}
.child{
    border:1px solid black;
    padding:2%;
    width:260px !important;
    margin-right: 2%;
    background-color:#f0f0ea;
    margin-bottom : 3%;
}
    
 img{
    width:200px;
    margin-bottom:2%;
}
h4{
margin-right: 3px
}
.textClass{
font-size: 14px;
}

.movies {
    display: flex;
    width: 80%;
    flex-wrap:wrap;

}
.movie{
    border:1px solid black;
    padding:2%;
    width:260px !important;
    background-color:#f0f0ea;
    margin-bottom : 3%;
    margin-right:5%;
}
img{
    width:200px;
    margin-bottom:2%;
}
h4{
    text-transform: capitalize;
    margin-top:2%;
}
span{
    margin-bottom : 100%;
}
input{
    margin-top:2%;
    padding : 2px;
}
</style>
");
#nullable restore
#line 56 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
 if (ViewBag.UserRole != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        document.getElementById(\"login\").innerHTML = \"Log Out\";\r\n        document.getElementById(\"login\").href = \"../../../Auth/LogOut\";\r\n    </script>\r\n");
#nullable restore
#line 62 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        document.getElementById(\"login\").href = \"../../../Auth/\";\r\n    </script>\r\n");
#nullable restore
#line 68 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
 if (ViewBag.actor != null)
{
    var actor = ViewBag.actor;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 73 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
   Write(actor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
               Write(actor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"main\">\r\n        <div class=\"child\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1282, "\"", 1303, 1);
#nullable restore
#line 76 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
WriteAttributeValue("", 1288, actor.Portrait, 1288, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px\"");
            BeginWriteAttribute("alt", " alt=\"", 1324, "\"", 1330, 0);
            EndWriteAttribute();
            WriteLiteral("/>\r\n        </div>\r\n    </div>\r\n    <table>\r\n        <tr style=\"height: 20%\">\r\n            <th>\r\n                <h4>Born in : ");
#nullable restore
#line 82 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
                         Write(actor.BirthDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 82 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
                                               Write(actor.BirthDate.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 82 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
                                                                      Write(actor.BirthDate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n            </th>\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                <h4>Rating : ");
#nullable restore
#line 87 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
                        Write(actor.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </th>\r\n        </tr>\r\n    </table>\r\n<h1>Movies</h1>\r\n");
#nullable restore
#line 92 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"

    if(actor.Movies.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"movies\">\r\n");
#nullable restore
#line 95 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
   foreach (var movie in actor.Movies)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"movie\" style=\"height:90%;\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1880, "\"", 1899, 1);
#nullable restore
#line 98 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
WriteAttributeValue("", 1886, movie.Poster, 1886, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1900, "\"", 1917, 1);
#nullable restore
#line 98 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
WriteAttributeValue("", 1906, movie.Name, 1906, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <h4>");
#nullable restore
#line 99 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
           Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n            <span>IMDB : ");
#nullable restore
#line 100 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
                    Write(movie.IMDB);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | RT : ");
#nullable restore
#line 100 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
                                       Write(movie.RottenTomatoes);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span><br/>\r\n            <span>Release Date : ");
#nullable restore
#line 101 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
                            Write(movie.ReleaseDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 101 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
                                                    Write(movie.ReleaseDate.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 101 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
                                                                             Write(movie.ReleaseDate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n           <input type=\"button\" value=\"View More\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2199, "\"", 2262, 3);
            WriteAttributeValue("", 2209, "window.location.href=\'../../Movie/details/", 2209, 42, true);
#nullable restore
#line 102 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
WriteAttributeValue("", 2251, movie.Id, 2251, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2260, "\';", 2260, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n");
#nullable restore
#line 104 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>  \r\n");
#nullable restore
#line 106 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
}
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>No actor found</h1>\r\n");
#nullable restore
#line 111 "C:\Users\Gio\source\repos\CinemaLibrary\CinemaLibraryWebApp\Views\Actor\Details.cshtml"
}

#line default
#line hidden
#nullable disable
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
