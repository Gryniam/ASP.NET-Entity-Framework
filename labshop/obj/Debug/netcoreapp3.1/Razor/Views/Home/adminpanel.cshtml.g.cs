#pragma checksum "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b18d6a2b43619d05bdd3447a2c1aedd2ee2839ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_adminpanel), @"mvc.1.0.view", @"/Views/Home/adminpanel.cshtml")]
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
#line 1 "D:\Study\Project C#\labshop\labshop\Views\_ViewImports.cshtml"
using labshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\Project C#\labshop\labshop\Views\_ViewImports.cshtml"
using labshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b18d6a2b43619d05bdd3447a2c1aedd2ee2839ac", @"/Views/Home/adminpanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31e78c282fc39c8b442a20619c58d0b52cd1a86a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_adminpanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b18d6a2b43619d05bdd3447a2c1aedd2ee2839ac3373", async() => {
                WriteLiteral("\r\n    <title>adminpanel</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b18d6a2b43619d05bdd3447a2c1aedd2ee2839ac4372", async() => {
                WriteLiteral(@"
    <h4>Список товарів</h4>
    
    <table>
        <thead>
            <tr>
                <td><a href=""adding"">Додати товар</a></td>
                <td>Ім'я товару&nbsp;</td>
                <td>Ціна товару&nbsp;</td>
                <td>Кількість покупок&nbsp;</td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
              
                foreach (var tov in ViewBag.Tovars)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
                       Write(tov.TovarName);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;</td>\r\n                        <td>");
#nullable restore
#line 27 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
                       Write(tov.TovarPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;</td>\r\n                        <td>");
#nullable restore
#line 28 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
                       Write(tov.NumberOfPur);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;</td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 760, "\"", 793, 2);
                WriteAttributeValue("", 767, "/Home/editing/", 767, 14, true);
#nullable restore
#line 29 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
WriteAttributeValue("", 781, tov.TovarId, 781, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Редагувати</a><a>/</a></td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 854, "\"", 888, 2);
                WriteAttributeValue("", 861, "/Home/deleting/", 861, 15, true);
#nullable restore
#line 30 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
WriteAttributeValue("", 876, tov.TovarId, 876, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Видалити</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 32 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <h4>Користувачі</h4>\r\n    \r\n    <table>\r\n        <tbody>\r\n");
#nullable restore
#line 40 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
              
                foreach (var kor in ViewBag.users)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 44 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
                       Write(kor.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;</td>\r\n                        <td>");
#nullable restore
#line 45 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
                       Write(kor.UserMail);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;</td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 1315, "\"", 1350, 2);
                WriteAttributeValue("", 1322, "/Home/deleteuser/", 1322, 17, true);
#nullable restore
#line 46 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
WriteAttributeValue("", 1339, kor.UserId, 1339, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Видалити</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 48 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <h4>\r\n        Історія покупок\r\n    </h4>\r\n    <table>\r\n        <tbody>\r\n");
#nullable restore
#line 57 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
              
                foreach (var ip in ViewBag.buytov)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 61 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
                       Write(ip.UserMail);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;</td>\r\n                        <td>");
#nullable restore
#line 62 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
                       Write(ip.TovarName);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;</td>\r\n                        <td>");
#nullable restore
#line 63 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
                       Write(ip.DateTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;</td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 1843, "\"", 1882, 2);
                WriteAttributeValue("", 1850, "/Home/deleteorder/", 1850, 18, true);
#nullable restore
#line 64 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
WriteAttributeValue("", 1868, ip.BuyTovarId, 1868, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Видалити</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 66 "D:\Study\Project C#\labshop\labshop\Views\Home\adminpanel.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
