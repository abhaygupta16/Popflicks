#pragma checksum "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "770912edf1b2563e5e709fe474a4501cdd961a19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Home_Detail), @"mvc.1.0.view", @"/Areas/Users/Views/Home/Detail.cshtml")]
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
#line 1 "D:\prooject related data\project\Areas\Users\Views\Home\_ViewImports.cshtml"
using project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\prooject related data\project\Areas\Users\Views\Home\_ViewImports.cshtml"
using project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"770912edf1b2563e5e709fe474a4501cdd961a19", @"/Areas/Users/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6489460591dedbaaa7ef634782f0f12b0f7a4e7", @"/Areas/Users/Views/Home/_ViewImports.cshtml")]
    public class Areas_Users_Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Detail";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    body {\r\n        background-color: black;\r\n    }\r\n\r\n    h4,h3,h6 {\r\n        color: white;\r\n    }\r\n    p {\r\n        color: yellow;\r\n    }\r\n</style>\r\n\r\n<div class=\"container\">\r\n    <h3>");
#nullable restore
#line 21 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <hr />\r\n\r\n    <div>\r\n");
#nullable restore
#line 25 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
          
            var link = "https://www.youtube.com/embed/";
            var model = Model.MovieLink;
            var movielink = link + model;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <iframe width=\"100%\" height=\"500\"");
            BeginWriteAttribute("src", " src=\"", 505, "\"", 521, 1);
#nullable restore
#line 30 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
WriteAttributeValue("", 511, movielink, 511, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\r\n    </div>\r\n    \r\n\r\n    <div class=\"detailbox row\">\r\n\r\n        <div class=\"col-md-3 col-sm-10\">\r\n");
#nullable restore
#line 37 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
              
                var base64 = Convert.ToBase64String(Model.Banner);
                var imgsrc = string.Format("data:image/jpg; base64,{0}", base64);
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 941, "\"", 954, 1);
#nullable restore
#line 41 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
WriteAttributeValue("", 947, imgsrc, 947, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200px\" height=\"260px\"");
            BeginWriteAttribute("title", " title=", 984, "", 1002, 1);
#nullable restore
#line 41 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
WriteAttributeValue("", 991, Model.Name, 991, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n\r\n        <div class=\"col-md-9 col-sm-10\">\r\n            <div class=\"row pr-3\">\r\n                <div class=\"col-md-7\">\r\n                    <h4>");
#nullable restore
#line 47 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p class=\"lead\">");
#nullable restore
#line 48 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                               Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h6>\r\n");
#nullable restore
#line 50 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                         if (Model.Category == "0")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6><span class=\"text-danger\">Category</span> :  Action</h6>\r\n");
#nullable restore
#line 53 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                         if (Model.Category == "1")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6><span class=\"text-danger\">Category</span> : Adventure</h6>\r\n");
#nullable restore
#line 57 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                         if (Model.Category == "2")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6><span class=\"text-danger\">Category</span> :  Horror</h6>\r\n");
#nullable restore
#line 61 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                         if (Model.Category == "3")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6><span class=\"text-danger\">Category</span> :  Drama</h6>\r\n");
#nullable restore
#line 65 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                         if (Model.Category == "4")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6><span class=\"text-danger\">Category</span> :  Romance</h6>\r\n");
#nullable restore
#line 69 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                         if (Model.Category == "5")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6><span class=\"text-danger\">Category</span> :  Comedy</h6>\r\n");
#nullable restore
#line 73 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h6>\r\n\r\n                </div>\r\n                <div class=\"col-md-5\">\r\n                    <h6></h6><br />\r\n\r\n                    <h6><span class=\"text-danger\">Director</span> : ");
#nullable restore
#line 81 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                                                               Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h6><span class=\"text-danger\">Actors</span> : ");
#nullable restore
#line 82 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                                                             Write(Model.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h6><span class=\"text-danger\">Producer</span> : ");
#nullable restore
#line 83 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                                                               Write(Model.Producer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h6><span class=\"text-danger\">Runtime</span> : ");
#nullable restore
#line 84 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                                                              Write(Model.WatchTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h6><span class=\"text-danger\">Release</span> : ");
#nullable restore
#line 85 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                                                              Write(Model.Release);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h6>\r\n                        <span class=\"text-danger\">Ratings</span> :\r\n");
#nullable restore
#line 88 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                         if (Model.Ratings == "0")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label title=\"No star rating\">No Ratings</label>\r\n");
#nullable restore
#line 91 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                         if (Model.Ratings == "1")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img srcset=\"/Images/Star.png\" width=\"30px\" height=\"30px\" title=\"one star rating\" />\r\n");
#nullable restore
#line 95 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                         if (Model.Ratings == "2")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img srcset=\"/Images/Star.png\" width=\"30px\" height=\"30px\" title=\"two star rating\" />\r\n                            <img srcset=\"/Images/Star.png\" width=\"30px\" height=\"30px\" title=\"two star rating\" />\r\n");
#nullable restore
#line 100 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                         if (Model.Ratings == "3")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <img srcset=""/Images/Star.png"" width=""30px"" height=""30px"" title=""three star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30px"" height=""30px"" title=""three star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30px"" height=""30px"" title=""three star rating"" />
");
#nullable restore
#line 106 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                         if (Model.Ratings == "4")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <img srcset=""/Images/Star.png"" width=""30px"" height=""30px"" title=""four star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30px"" height=""30px"" title=""four star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30px"" height=""30px"" title=""four star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30px"" height=""30px"" title=""four star rating"" />
");
#nullable restore
#line 113 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                         if (Model.Ratings == "5")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <img srcset=""/Images/Star.png"" width=""30px"" height=""30px"" title=""five star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30px"" height=""30px"" title=""five star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30px"" height=""30px"" title=""five star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30px"" height=""30px"" title=""five star rating"" />
                            <img srcset=""/Images/Star.png"" width=""30px"" height=""30px"" title=""five star rating"" />
");
#nullable restore
#line 121 "D:\prooject related data\project\Areas\Users\Views\Home\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </h6>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
