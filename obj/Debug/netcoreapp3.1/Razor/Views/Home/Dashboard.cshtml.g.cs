#pragma checksum "/Users/narkalix/Documents/Coding Dojo/CSharp/examfinal/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8552a04bb58b3b45cd892efbc271f8389aee64a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "/Users/narkalix/Documents/Coding Dojo/CSharp/examfinal/Views/_ViewImports.cshtml"
using examfinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/narkalix/Documents/Coding Dojo/CSharp/examfinal/Views/_ViewImports.cshtml"
using examfinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8552a04bb58b3b45cd892efbc271f8389aee64a", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ad888ad5d0969f74359da2a552ca706a533709", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n<div class=\"text-center\">\n    <h3>Hobbies</h3>\n    <table>\n        <tr>\n            <td>Name</td>\n            <td>Enthusiasts</td>\n        </tr>\n    \n");
#nullable restore
#line 12 "/Users/narkalix/Documents/Coding Dojo/CSharp/examfinal/Views/Home/Dashboard.cshtml"
      
        foreach(Actividad a in ViewBag.AllHobbies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    <p> <a");
            BeginWriteAttribute("href", " href=\"", 285, "\"", 320, 2);
            WriteAttributeValue("", 292, "/HobbiesDetail/", 292, 15, true);
#nullable restore
#line 17 "/Users/narkalix/Documents/Coding Dojo/CSharp/examfinal/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 307, a.ActivityId, 307, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "/Users/narkalix/Documents/Coding Dojo/CSharp/examfinal/Views/Home/Dashboard.cshtml"
                                                          Write(a.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\n                </td>\n                <td>");
#nullable restore
#line 19 "/Users/narkalix/Documents/Coding Dojo/CSharp/examfinal/Views/Home/Dashboard.cshtml"
               Write(a.Seller.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 21 "/Users/narkalix/Documents/Coding Dojo/CSharp/examfinal/Views/Home/Dashboard.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n    <a style=\"margin-top:20px\" href=\"/AddActivity\" class=\"btn btn-info\">Add Activity</a>\n    <hr>\n</div>\n<style>\n    table{\n        text-align: :left;\n        border:solid;\n    }\n    td{\n        padding:5px;\n    }\n</style>");
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
