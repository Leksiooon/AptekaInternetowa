#pragma checksum "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "072cc10a15df501b78a2fc8695c2561f4f5f52d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zamowienie_SubmissionedOrders), @"mvc.1.0.view", @"/Views/Zamowienie/SubmissionedOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Zamowienie/SubmissionedOrders.cshtml", typeof(AspNetCore.Views_Zamowienie_SubmissionedOrders))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"072cc10a15df501b78a2fc8695c2561f4f5f52d7", @"/Views/Zamowienie/SubmissionedOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Zamowienie_SubmissionedOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AptekaInternetowa.Models.ViewModels.GlobalVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 26, true);
            WriteLiteral("\r\n<div id=\"accordion\">\r\n\r\n");
            EndContext();
#line 5 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
       int i = 1; 

#line default
#line hidden
            BeginContext(100, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 6 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
     foreach (var item in Model.SubmissionedOrdersVM.Zamowienia)
    {

#line default
#line hidden
            BeginContext(173, 206, true);
            WriteLiteral("        <div class=\"card\" style=\"margin-bottom: 20px\">\r\n            <div class=\"card-header\">\r\n                <button class=\"btn btn-light\" style=\"width: 100%\" data-toggle=\"collapse\" data-target=\"#collapse");
            EndContext();
            BeginContext(381, 1, false);
#line 10 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(383, 194, true);
            WriteLiteral("\" @*aria-expanded=\"true\" aria-controls=\"collapse@(i)\"*@>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-3\">\r\n                            <h4>Zamowienie numer <b>");
            EndContext();
            BeginContext(579, 1, false);
#line 13 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
                                                Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(581, 142, true);
            WriteLiteral("</b></h4>\r\n                        </div>\r\n                        <div class=\"col-5\">\r\n                            Data złożenia zamówienia: ");
            EndContext();
            BeginContext(724, 48, false);
#line 16 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
                                                 Write(item.SubmissionDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(772, 119, true);
            WriteLiteral(";\r\n                        </div>\r\n                        <div class=\"col-4\">\r\n                            Zapłacono: ");
            EndContext();
            BeginContext(892, 12, false);
#line 19 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
                                  Write(item.Wartosc);

#line default
#line hidden
            EndContext();
            BeginContext(904, 127, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </button>\r\n            </div>\r\n\r\n            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1031, "\"", 1048, 2);
            WriteAttributeValue("", 1036, "collapse", 1036, 8, true);
#line 25 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
WriteAttributeValue("", 1044, i, 1044, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1049, 584, true);
            WriteLiteral(@" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
                <div class=""card-body"">

                    <table class=""table"">
                        <thead class=""thead-light"">
                            <tr>
                                <th scope=""col"">#</th>
                                <th scope=""col"">Nazwa</th>
                                <th scope=""col"">Cena</th>
                                <th scope=""col"">Ilość</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 38 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
                               int j = 1; 

#line default
#line hidden
            BeginContext(1678, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 39 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
                             foreach (var item2 in item.ElementyZamowienia)
                            {

#line default
#line hidden
            BeginContext(1786, 90, true);
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
            EndContext();
            BeginContext(1877, 1, false);
#line 42 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
                                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1878, 47, true);
            WriteLiteral("</th>\r\n                                    <td>");
            EndContext();
            BeginContext(1926, 19, false);
#line 43 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
                                   Write(item2.Produkt.Nazwa);

#line default
#line hidden
            EndContext();
            BeginContext(1945, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1993, 18, false);
#line 44 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
                                   Write(item2.Produkt.Cena);

#line default
#line hidden
            EndContext();
            BeginContext(2011, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2059, 11, false);
#line 45 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
                                   Write(item2.Ilosc);

#line default
#line hidden
            EndContext();
            BeginContext(2070, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 46 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
                                       j++; 

#line default
#line hidden
            BeginContext(2124, 39, true);
            WriteLiteral("                                </tr>\r\n");
            EndContext();
#line 48 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
                            }

#line default
#line hidden
            BeginContext(2194, 124, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 54 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Zamowienie\SubmissionedOrders.cshtml"
        { i += 1; }
    }

#line default
#line hidden
            BeginContext(2346, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AptekaInternetowa.Models.ViewModels.GlobalVM> Html { get; private set; }
    }
}
#pragma warning restore 1591