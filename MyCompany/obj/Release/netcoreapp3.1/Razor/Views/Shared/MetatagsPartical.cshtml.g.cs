#pragma checksum "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f113c2e8b3b85a787f5b1f92ba2164886cab7f96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartical), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartical.cshtml")]
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
#line 2 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\_ViewImports.cshtml"
using MyCompany.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\_ViewImports.cshtml"
using MyCompany.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\_ViewImports.cshtml"
using MyCompany.Models.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml"
using MyCompany.Servise;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f113c2e8b3b85a787f5b1f92ba2164886cab7f96", @"/Views/Shared/MetatagsPartical.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2345ad39b7c3923d04025ab903cff74011f901b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetatagsPartical : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
#nullable restore
#line 4 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 6 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 7 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 10 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml"
      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 11 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 330, "\"", 360, 1);
#nullable restore
#line 14 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml"
WriteAttributeValue("", 340, ViewBag.Description, 340, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 15 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 429, "\"", 456, 1);
#nullable restore
#line 18 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml"
WriteAttributeValue("", 439, ViewBag.Keywords, 439, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 19 "C:\Users\olhav\OneDrive\Рабочий стол\C#\Нова папка\MyCompany\MyCompany\Views\Shared\MetatagsPartical.cshtml"
}

#line default
#line hidden
#nullable disable
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