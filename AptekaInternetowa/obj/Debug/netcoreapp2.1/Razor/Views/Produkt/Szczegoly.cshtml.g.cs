#pragma checksum "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3341a472a7888aa319d1b560b8b4dcbe1acd6392"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produkt_Szczegoly), @"mvc.1.0.view", @"/Views/Produkt/Szczegoly.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produkt/Szczegoly.cshtml", typeof(AspNetCore.Views_Produkt_Szczegoly))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3341a472a7888aa319d1b560b8b4dcbe1acd6392", @"/Views/Produkt/Szczegoly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Produkt_Szczegoly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AptekaInternetowa.Models.ViewModels.GlobalVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produkt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 113, true);
            WriteLiteral("\r\n<div class=\"container\" style=\"padding: 15px\">\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            ");
            EndContext();
            BeginContext(166, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "97dd2dfdb3684714b13803508e40b9d2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 176, "~/images/", 176, 9, true);
#line 6 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
AddHtmlAttributeValue("", 185, Model.SzczegolyVM.Produkt.ZdjecieUrl, 185, 37, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(233, 139, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-8\">\r\n            <div class=\"row\">\r\n                <div class=\"col-8\">\r\n                    <h4>");
            EndContext();
            BeginContext(373, 31, false);
#line 11 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
                   Write(Model.SzczegolyVM.Produkt.Nazwa);

#line default
#line hidden
            EndContext();
            BeginContext(404, 102, true);
            WriteLiteral("</h4>\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    <p>Producent: ");
            EndContext();
            BeginContext(507, 35, false);
#line 14 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
                             Write(Model.SzczegolyVM.Produkt.Producent);

#line default
#line hidden
            EndContext();
            BeginContext(542, 92, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n            <p><h6>Cena za sztukę:</h6> ");
            EndContext();
            BeginContext(635, 30, false);
#line 18 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
                                   Write(Model.SzczegolyVM.Produkt.Cena);

#line default
#line hidden
            EndContext();
            BeginContext(665, 141, true);
            WriteLiteral("</p>\r\n\r\n            <div class=\"col-5\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-5\">\r\n                        ");
            EndContext();
            BeginContext(806, 347, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d06d256aef1e42219c3e32f2ec57a686", async() => {
                BeginContext(880, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(911, 40, false);
#line 24 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
                       Write(Html.HiddenFor(x => x.SzczegolyVM.Ilosc));

#line default
#line hidden
                EndContext();
                BeginContext(951, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(982, 45, false);
#line 25 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
                       Write(Html.HiddenFor(x => x.SzczegolyVM.Produkt.Id));

#line default
#line hidden
                EndContext();
                BeginContext(1027, 119, true);
                WriteLiteral("\r\n\r\n                            <input type=\"submit\" class=\"btn btn-primary\" value=\"Dodaj\" />\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1153, 288, true);
            WriteLiteral(@"
                    </div>

                    <div class=""col-7"">
                        <button type=""button"" class=""btn btn-bd-primary"" onclick=""updatePlus()"">+</button>
                        <input style=""border: 3px solid black; border-radius: 8px; width: 40px;"" type=""tel""");
            EndContext();
            BeginWriteAttribute("value", " value=", 1441, "", 1472, 1);
#line 33 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
WriteAttributeValue("", 1448, Model.SzczegolyVM.Ilosc, 1448, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1472, 233, true);
            WriteLiteral(" id=\"show\">\r\n                        <button type=\"button\" class=\"btn btn-bd-primary\" onclick=\"updateMinus()\">-</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n            <p><h6>Działanie:</h6> ");
            EndContext();
            BeginContext(1706, 35, false);
#line 40 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
                              Write(Model.SzczegolyVM.Produkt.Dzialanie);

#line default
#line hidden
            EndContext();
            BeginContext(1741, 41, true);
            WriteLiteral("</p>\r\n            <p><h6>Wskazania:</h6> ");
            EndContext();
            BeginContext(1783, 35, false);
#line 41 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
                              Write(Model.SzczegolyVM.Produkt.Wskazania);

#line default
#line hidden
            EndContext();
            BeginContext(1818, 64, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n\r\n    <p><h5>Dawkowanie:</h5> ");
            EndContext();
            BeginContext(1883, 36, false);
#line 45 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
                       Write(Model.SzczegolyVM.Produkt.Dawkowanie);

#line default
#line hidden
            EndContext();
            BeginContext(1919, 29, true);
            WriteLiteral("</p>\r\n    <p><h5>Skład:</h5> ");
            EndContext();
            BeginContext(1949, 31, false);
#line 46 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
                  Write(Model.SzczegolyVM.Produkt.Sklad);

#line default
#line hidden
            EndContext();
            BeginContext(1980, 40, true);
            WriteLiteral("</p>\r\n    <p><h5>Przeciwwskazania:</h5> ");
            EndContext();
            BeginContext(2021, 42, false);
#line 47 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
                             Write(Model.SzczegolyVM.Produkt.Przeciwwskazania);

#line default
#line hidden
            EndContext();
            BeginContext(2063, 44, true);
            WriteLiteral("</p>\r\n    <p><h5>Dodatkowe informacje:</h5> ");
            EndContext();
            BeginContext(2108, 45, false);
#line 48 "E:\Projekty\AptekaInternetowa\AptekaInternetowa\Views\Produkt\Szczegoly.cshtml"
                                 Write(Model.SzczegolyVM.Produkt.DodatkoweInformacje);

#line default
#line hidden
            EndContext();
            BeginContext(2153, 14, true);
            WriteLiteral("</p>\r\n\r\n</div>");
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
