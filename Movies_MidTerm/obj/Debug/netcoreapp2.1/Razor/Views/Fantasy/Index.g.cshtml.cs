#pragma checksum "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa266e30794ca25c7b1bae380dd04c5bd0bd52af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fantasy_Index), @"mvc.1.0.view", @"/Views/Fantasy/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fantasy/Index.cshtml", typeof(AspNetCore.Views_Fantasy_Index))]
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
#line 1 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\_ViewImports.cshtml"
using Movies_MidTerm;

#line default
#line hidden
#line 2 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\_ViewImports.cshtml"
using Movies_MidTerm.Models;

#line default
#line hidden
#line 1 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa266e30794ca25c7b1bae380dd04c5bd0bd52af", @"/Views/Fantasy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c582d4d2f5925218f408e4fbb67b855f877263ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Fantasy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"
  
    ViewData["Title"] = "Fantasy";

#line default
#line hidden
            BeginContext(70, 95, true);
            WriteLiteral("\r\n<h2>Fantasy  Movies</h2>\r\n<div class=\"container alert alert-danger\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 10 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"
         foreach (var movie in ViewBag.movies)
        {
            //var temp= JsonConvert.SerializeObject(movie);

#line default
#line hidden
            BeginContext(285, 199, true);
            WriteLiteral("            <div class=\"row\" style=\"margin-left:0px;\">\r\n                <div class=\"col-xs-2\">\r\n                    <a href=\"#\" class=\"thumbnail\" style=\"width:135px;\">\r\n\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 484, "\"", 523, 1);
#line 17 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"
WriteAttributeValue("", 490, Url.Content((string)movie.image), 490, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(524, 275, true);
            WriteLiteral(@" alt=""ASP.NET"" class=""img-responsive"" />

                    </a>
                </div>
                <div class=""col-xs-6 text-primary"" style=""font-family: 'Open Sans', sans-serif;"">
                    <strong class=""text-uppercase text-danger""> Title:</strong>   ");
            EndContext();
            BeginContext(800, 11, false);
#line 22 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"
                                                                             Write(movie.title);

#line default
#line hidden
            EndContext();
            BeginContext(811, 96, true);
            WriteLiteral(" <br>\r\n                    <strong class=\"text-uppercase text-danger\">Description:</strong>     ");
            EndContext();
            BeginContext(908, 17, false);
#line 23 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"
                                                                                    Write(movie.description);

#line default
#line hidden
            EndContext();
            BeginContext(925, 96, true);
            WriteLiteral(" <br>\r\n                    <strong class=\"text-uppercase text-danger\">    Director:</strong>    ");
            EndContext();
            BeginContext(1022, 14, false);
#line 24 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"
                                                                                    Write(movie.director);

#line default
#line hidden
            EndContext();
            BeginContext(1036, 94, true);
            WriteLiteral(" <br>\r\n                    <strong class=\"text-uppercase text-danger\">    Writer: </strong>   ");
            EndContext();
            BeginContext(1131, 12, false);
#line 25 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"
                                                                                  Write(movie.writer);

#line default
#line hidden
            EndContext();
            BeginContext(1143, 89, true);
            WriteLiteral(" <br>\r\n                    <strong class=\"text-uppercase text-danger\">Stars:</strong>    ");
            EndContext();
            BeginContext(1233, 11, false);
#line 26 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"
                                                                             Write(movie.stars);

#line default
#line hidden
            EndContext();
            BeginContext(1244, 87, true);
            WriteLiteral(" <br>\r\n                    <strong class=\"text-uppercase text-danger\">Price :</strong>$");
            EndContext();
            BeginContext(1332, 11, false);
#line 27 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"
                                                                           Write(movie.price);

#line default
#line hidden
            EndContext();
            BeginContext(1343, 311, true);
            WriteLiteral(@"

                    <div class=""text-success"">
                        <strong>  In Stock. </strong>                Ships from and sold by MovieBuzz. Gift-wrap available. <br />
                    </div>
                    <input type=""button"" id=""addToCart"" value=""Add to Cart"" class=""btn btn-primary""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1654, "\"", 1893, 3);
            WriteAttributeValue("", 1664, "location.href=\'", 1664, 15, true);
#line 32 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"
WriteAttributeValue("", 1679, Url.Action("AddToCart", "Cart",new { id =movie.id, title = movie.title, description=movie.description ,director=movie.director , writer=movie.writer ,stars=movie.stars, trailer=movie.trailer ,image=movie.image }), 1679, 213, false);

#line default
#line hidden
            WriteAttributeValue("", 1892, "\'", 1892, 1, true);
            EndWriteAttribute();
            BeginContext(1894, 209, true);
            WriteLiteral(">\r\n\r\n                </div>\r\n                <div class=\"col-xs-4 text-primary\">\r\n                    <strong> Watch the trailor </strong>\r\n                    <iframe type=\"text/html\" width=\"300\" height=\"200\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2103, "\"", 2123, 1);
#line 37 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"
WriteAttributeValue("", 2109, movie.trailer, 2109, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2124, 92, true);
            WriteLiteral(" frameborder=\"0\"></iframe>\r\n\r\n                </div>\r\n            </div>\r\n            <hr>\r\n");
            EndContext();
#line 42 "C:\Users\anush\OneDrive\Desktop\Movies_MidTerm -\Movies_MidTerm\Views\Fantasy\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(2229, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
