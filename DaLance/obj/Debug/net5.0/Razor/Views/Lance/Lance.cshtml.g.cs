#pragma checksum "C:\Users\angel\source\repos\DaLance\DaLance\Views\Lance\Lance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8938ddc84a085c5fa2ea6e7a2c8b93582562681b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lance_Lance), @"mvc.1.0.view", @"/Views/Lance/Lance.cshtml")]
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
#line 1 "C:\Users\angel\source\repos\DaLance\DaLance\Views\_ViewImports.cshtml"
using DaLance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\angel\source\repos\DaLance\DaLance\Views\_ViewImports.cshtml"
using DaLance.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8938ddc84a085c5fa2ea6e7a2c8b93582562681b", @"/Views/Lance/Lance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57755abc7c27b0b0c63349c07875611f6f2e13c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Lance_Lance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Icons Grid -->
<div ng-controller=""LanceController"">
    <section ng-if=""produtos.length > 0"" class=""features-icons bg-light text-center"" style=""display: block !important;margin-top: -4pc;"">
        <h2>Produtos para o lance</h2>
        <hr>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4"" ng-repeat=""p in produtos"">
                    <div class=""features-icons-item mx-auto mb-5 mb-lg-0 mb-lg-3"" style="" border: groove; border-radius: 4%;"">
                        <h3>{{p.nome}}</h3>
                        <p class=""lead mb-0"">Valor inicial: R$ {{p.valor}}</p>
                        <button type=""submit"" class=""btn btn-block btn-lg btn-secondary"" ng-click=""newLance(p.id)"">Apostar</button>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>");
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
