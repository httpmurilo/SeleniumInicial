#pragma checksum "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Leiloes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d857b3d21e33133b15502273fbe4ab9e6f22a395"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leiloes_Index), @"mvc.1.0.view", @"/Views/Leiloes/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\_ViewImports.cshtml"
using ProjetoSelenium.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\_ViewImports.cshtml"
using ProjetoSelenium.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\_ViewImports.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\_ViewImports.cshtml"
using ProjetoSelenium.WebApp.ExTensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d857b3d21e33133b15502273fbe4ab9e6f22a395", @"/Views/Leiloes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25c39d64d391534ebd225123d68700ec2bde5faf", @"/Views/_ViewImports.cshtml")]
    public class Views_Leiloes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoSelenium.WebApp.Models.LeilaoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Leiloes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Novo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("right red btn-small btn-floating waves-effect waves-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Leiloes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"
<!-- Modal Structure -->
<div id=""modalConfirmaDelLeilao"" class=""modal"">
    <div class=""modal-content"">
        <h4>Confirmação</h4>
        <p>Tem certeza que deseja excluir o leilão?</p>
    </div>
    <div class=""modal-footer"">
        <a href=""#"" class=""modal-close btn-flat"">Não</a>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d857b3d21e33133b15502273fbe4ab9e6f22a3956237", async() => {
                WriteLiteral("\n            <input type=\"hidden\" name=\"id\" value=\"2\" class=\"inline\" />\n            <button class=\"modal-close waves-effect waves-green btn-flat\">Sim</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col s12 m8"">
            <!-- Tabela com os leilões cadastrados -->
            <div class=""card"">
                <div class=""card-content"">
                    <h4 class=""card-title"">
                        Leilões cadastrados no sistema
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d857b3d21e33133b15502273fbe4ab9e6f22a3958408", async() => {
                WriteLiteral("\n                            <i class=\"material-icons\">add</i>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </h4>
                    <table class=""highlight responsive-table"">
                        <thead>
                            <tr>
                                <th>Descrição</th>
                                <th>Valor Inicial</th>
                                <th>Categoria</th>
                                <th>Estado Atual</th>
                                <th>Ações</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 52 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Leiloes\Index.cshtml"
                             foreach (var leilao in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 55 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Leiloes\Index.cshtml"
                                   Write(leilao.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 56 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Leiloes\Index.cshtml"
                                   Write(leilao.ValorInicial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 57 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Leiloes\Index.cshtml"
                                   Write(leilao.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 58 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Leiloes\Index.cshtml"
                                   Write(leilao.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    <td>
                                        <a class=""modal-trigger black-text"" href=""#modalConfirmaDelLeilao""><i class=""material-icons"">close</i></a>
                                    </td>
                                </tr>
");
#nullable restore
#line 63 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Leiloes\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n                <!--card.content>table-->\n                <div class=\"card-action\">\n");
            WriteLiteral(@"                    <ul class=""pagination right-align"">
                        <li class=""disabled"">
                            <a href=""#!"" class=""grey-text text-lighten-2"">
                                <i class=""material-icons"">chevron_left</i>
                            </a>
                        </li>
                        <li class=""active waves-effect red"">
                            <a href=""#!"" class=""white-text"">1</a>
                        </li>
                        <li class=""waves-effect"">
                            <a href=""#!"" class=""grey-text"">2</a>
                        </li>
                        <li class=""waves-effect"">
                            <a href=""#!"" class=""grey-text"">3</a>
                        </li>
                        <li class=""waves-effect"">
                            <a href=""#!"" class=""grey-text"">
                                <i class=""material-icons"">chevron_right</i>
                            </a>
                        </li>
             ");
            WriteLiteral(@"       </ul>
                    <!--ul.pagination-->
                </div>
            </div>
            <!--div.card-->
        </div>
        <div class=""col s12 m4"">
            <!-- Filtro rápido de leilões -->
            <div class=""card teal white-text"">
                <div class=""card-content"">
                    <span class=""card-title"">
                        <i class=""material-icons left"">search</i>
                        Filtro
                    </span>
                    <ul class=""collection with-header"">
                        <li class=""collection-item collection-header teal darken-2 white-text"">Categoria</li>
                        <li class=""collection-item teal white-text""><a href=""#!"">Automóveis</a></li>
                        <li class=""collection-item teal white-text""><a href=""#!"">Arte e Pintura</a></li>
                        <li class=""collection-item teal white-text""><a href=""#!"">Itens de Colecionador</a></li>
                    </ul>
                </div>
            ");
            WriteLiteral("    <!--div.card-content-->\n            </div>\n            <!--div.card filtro-->\n        </div>\n    </div>\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoSelenium.WebApp.Models.LeilaoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591