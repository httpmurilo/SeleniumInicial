#pragma checksum "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d094c48c337b68f7a89b106d8836e7261090fb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d094c48c337b68f7a89b106d8836e7261090fb2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25c39d64d391534ebd225123d68700ec2bde5faf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LeilaoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalhes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Categoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Automóveis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "categoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Arte e Pintura", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Item de Colecionador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Registro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Leilões Online";
    string categoria = ViewData["categoria"] as string;
    Usuario usuarioLogado = Context.Session.Get<Usuario>("usuarioLogado");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"section section-prox-leiloes\">\n    <div class=\"container\">\n");
#nullable restore
#line 10 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
         if (string.IsNullOrWhiteSpace(categoria))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>Próximos Leilões</h4>\n");
#nullable restore
#line 13 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4>Leilões da categoria ");
#nullable restore
#line 17 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
                                Write(categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 18 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n");
#nullable restore
#line 20 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
             foreach (var leilao in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col s12 m4\">\n                    <div class=\"card hoverable\" data-id=\"");
#nullable restore
#line 23 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
                                                    Write(leilao.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n");
#nullable restore
#line 24 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
                         if (usuarioLogado != null)
                        {
                            if (leilao.SendoSeguido)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"#!\" data-idLeilao=\"");
#nullable restore
#line 28 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
                                                       Write(leilao.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-idInteressada=\"");
#nullable restore
#line 28 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
                                                                                       Write(usuarioLogado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"abandonar yellow-text text-darken-4\">\n                                    <i class=\"material-icons\">star</i>\n                                </a>\n");
#nullable restore
#line 31 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"#!\" data-idLeilao=\"");
#nullable restore
#line 34 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
                                                       Write(leilao.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-idInteressada=\"");
#nullable restore
#line 34 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
                                                                                       Write(usuarioLogado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"seguir white-text\">\n                                    <i class=\"material-icons\">star_border</i>\n                                </a>\n");
#nullable restore
#line 37 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card-image\">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1588, "\"", 1608, 1);
#nullable restore
#line 40 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1594, leilao.Imagem, 1594, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"responsive-img\">\n                            <span class=\"card-title\">");
#nullable restore
#line 41 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
                                                Write(leilao.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\n                        </div>\n                        <div class=\"card-content\">\n                            <p>");
#nullable restore
#line 45 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
                          Write(leilao.Descricao.Substring(0, 150));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                        <div class=\"card-action\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d094c48c337b68f7a89b106d8836e7261090fb212891", async() => {
                WriteLiteral("Detalhes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
                                                       WriteLiteral(leilao.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 52 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>


<section class=""section section-categ-leiloes brown lighten-5"">
    <div class=""container"">
        <h4 class=""center"">Navegue pelas categorias de Leilão</h4>
        <div class=""row"">
            <div class=""col s12 m4"">
                <div class=""card"">
                    <div class=""card-content center-align"">
                        <h2 class=""icon-block brown-text""><i class=""material-icons"">directions_car</i></h2>
                        <h5>Carros e Caminhões</h5>
                        <p class=""light"">
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci, laborum incidunt voluptatum accusantium repellendus numquam.
                        </p>
                    </div>
                    <div class=""card-action"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d094c48c337b68f7a89b106d8836e7261090fb216261", async() => {
                WriteLiteral("Descobrir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            </div>
            <div class=""col s12 m4"">
                <div class=""card"">
                    <div class=""card-content center-align"">
                        <h2 class=""icon-block brown-text""><i class=""material-icons"">palette</i></h2>
                        <h5>Pinturas e Esculturas</h5>
                        <p class=""light"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci, laborum incidunt voluptatum accusantium repellendus numquam.</p>
                    </div>
                    <div class=""card-action"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d094c48c337b68f7a89b106d8836e7261090fb218776", async() => {
                WriteLiteral("Descobrir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
            </div>
            <div class=""col s12 m4"">
                <div class=""card"">
                    <div class=""card-content center-align"">
                        <h2 class=""icon-block brown-text""><i class=""material-icons"">grade</i></h2>
                        <h5>Itens de Colecionador</h5>
                        <p class=""light"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci, laborum incidunt voluptatum accusantium repellendus numquam.</p>
                    </div>
                    <div class=""card-action"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d094c48c337b68f7a89b106d8836e7261090fb221289", async() => {
                WriteLiteral("Descobrir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
            </div>
        </div>
    </div>
</section>
<!--section-categ-leiloes-->

<section class=""section section-registro white black-text"">
    <div class=""container"">
        <h4 class=""center"">Registre-se para participar dos leilões!</h4>
        <div class=""row"">
            <div class=""col s12 m6"">
                <div class=""card-panel white-text brown darken-3"">
                    <p class=""flow-text"">Laoreet ac, aliquam sit amet justo nunc tempor, metus vel placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor.</p>
                    <ul>
                        <li>
                            <i class=""material-icons left medium"">shopping_cart</i>
                            <h6>
                                Ut fusce varius nisl ac ipsum gravida vel pretium tellus tincidunt integer eu augue augue nunc elit dolor, luctus placerat.
                            </h6>
                        </li>");
            WriteLiteral(@"
                        <li>
                            <i class=""material-icons left medium"">dashboard</i>
                            <h6>
                                Ut fusce varius nisl ac ipsum gravida vel pretium tellus tincidunt integer eu augue augue nunc elit dolor, luctus placerat.
                            </h6>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col s12 m6"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d094c48c337b68f7a89b106d8836e7261090fb224721", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 130 "C:\Users\murilo.melo\Desktop\Murilo\2020\ProjetoSelenium\ProjetoSelenium.WebApp\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new ProjetoSelenium.WebApp.Models.RegistroViewModel();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n        <!--div.row-->\n    </div>\n    <!--div.container-->\n</section>\n<!--section-registro-->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LeilaoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591