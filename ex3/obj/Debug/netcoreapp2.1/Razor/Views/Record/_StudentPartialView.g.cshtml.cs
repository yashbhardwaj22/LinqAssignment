#pragma checksum "C:\Users\yashb\source\repos\ex3\ex3\Views\Record\_StudentPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19721be04084057b26e3ec613e61ef7e4a0e8157"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Record__StudentPartialView), @"mvc.1.0.view", @"/Views/Record/_StudentPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Record/_StudentPartialView.cshtml", typeof(AspNetCore.Views_Record__StudentPartialView))]
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
#line 1 "C:\Users\yashb\source\repos\ex3\ex3\Views\_ViewImports.cshtml"
using ex3;

#line default
#line hidden
#line 2 "C:\Users\yashb\source\repos\ex3\ex3\Views\_ViewImports.cshtml"
using ex3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19721be04084057b26e3ec613e61ef7e4a0e8157", @"/Views/Record/_StudentPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a9920a3684738c2a2697cf8d106ce5bd9489534", @"/Views/_ViewImports.cshtml")]
    public class Views_Record__StudentPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudentJoin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(146, 297, true);
            WriteLiteral(@"
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th scope=""row""> ID</th>
            <th> Student Name</th>
            <th> Class</th>
            <th> Age</th>
            <th> Date</th>
            <th> Fees</th>

        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 18 "C:\Users\yashb\source\repos\ex3\ex3\Views\Record\_StudentPartialView.cshtml"
         foreach (var student in Model)
        {

#line default
#line hidden
            BeginContext(495, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(546, 17, false);
#line 21 "C:\Users\yashb\source\repos\ex3\ex3\Views\Record\_StudentPartialView.cshtml"
                           Write(student.StudentID);

#line default
#line hidden
            EndContext();
            BeginContext(563, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(591, 19, false);
#line 22 "C:\Users\yashb\source\repos\ex3\ex3\Views\Record\_StudentPartialView.cshtml"
               Write(student.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(610, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(638, 20, false);
#line 23 "C:\Users\yashb\source\repos\ex3\ex3\Views\Record\_StudentPartialView.cshtml"
               Write(student.StudentClass);

#line default
#line hidden
            EndContext();
            BeginContext(658, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(686, 18, false);
#line 24 "C:\Users\yashb\source\repos\ex3\ex3\Views\Record\_StudentPartialView.cshtml"
               Write(student.StudentAge);

#line default
#line hidden
            EndContext();
            BeginContext(704, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(732, 12, false);
#line 25 "C:\Users\yashb\source\repos\ex3\ex3\Views\Record\_StudentPartialView.cshtml"
               Write(student.Date);

#line default
#line hidden
            EndContext();
            BeginContext(744, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(772, 19, false);
#line 26 "C:\Users\yashb\source\repos\ex3\ex3\Views\Record\_StudentPartialView.cshtml"
               Write(student.StudentFees);

#line default
#line hidden
            EndContext();
            BeginContext(791, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 29 "C:\Users\yashb\source\repos\ex3\ex3\Views\Record\_StudentPartialView.cshtml"
        }

#line default
#line hidden
            BeginContext(830, 24, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudentJoin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
