#pragma checksum "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0717670b9dbc1be5dade45b8a95bf840e267bdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/macmini/Documents/avaliacao/Views/_ViewImports.cshtml"
using avaliacao;

#line default
#line hidden
#line 1 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
using avaliacao.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0717670b9dbc1be5dade45b8a95bf840e267bdf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d127e5190b5b1de647bffec9d3c27c38730c657", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Chamados>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/DataTables/datatables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/DataTables/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Lista";

#line default
#line hidden
            BeginContext(96, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71b17ef3fc4943ffb104db00d1ce2410", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(161, 865, true);
            WriteLiteral(@"
<div class=""row"">
     <div class=""col-md-12 col-sm-12 col-lg-12"">
         <center>
             <h2>Clietes com chamados abertos</h2>
         </center>
     </div>
    <div class=""col-md-12 col-sm-12 col-lg-12"">
        <div class=""table-responsive"">
            <table class=""table"" id=""dataTable"">
                   <thead>
                       <tr>
                           <th></th>
                           <th>CNPJ/CPF</th>
                           <th>Cliente</th>
                           <th>Telefone</th>
                           <th>CEP</th>
                           <th>Logradouro</th>
                           <th>Cidade</th>
                           <th>Chamado Aberto</th>
                           <th>Detalhes</th>
                       </tr>
                   </thead>
                    <tbody>
");
            EndContext();
#line 30 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                         if (Model != null)
                        {
                            foreach (Chamados chamado in Model)
                            {

#line default
#line hidden
            BeginContext(1194, 148, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <input type=\"checkbox\" class=\"chamadoItem\" data-id=\"");
            EndContext();
            BeginContext(1343, 10, false);
#line 36 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                                                                               Write(chamado.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 73, true);
            WriteLiteral("\" />\r\n                            </td>\r\n                            <td>");
            EndContext();
            BeginContext(1427, 23, false);
#line 38 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                           Write(chamado.cliente.CpfCnpj);

#line default
#line hidden
            EndContext();
            BeginContext(1450, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1490, 31, false);
#line 39 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                           Write(chamado.cliente.RazaoSocialNome);

#line default
#line hidden
            EndContext();
            BeginContext(1521, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1561, 24, false);
#line 40 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                           Write(chamado.cliente.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(1585, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1625, 19, false);
#line 41 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                           Write(chamado.cliente.CEP);

#line default
#line hidden
            EndContext();
            BeginContext(1644, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1684, 26, false);
#line 42 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                           Write(chamado.cliente.Logradouro);

#line default
#line hidden
            EndContext();
            BeginContext(1710, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1750, 32, false);
#line 43 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                           Write(chamado.cliente.LogradouroCidade);

#line default
#line hidden
            EndContext();
            BeginContext(1782, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1823, 60, false);
#line 44 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                            Write(chamado.Fechado == false ? Html.Raw("Sim") : Html.Raw("Não"));

#line default
#line hidden
            EndContext();
            BeginContext(1884, 117, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                <buttom class=\"btn btn-info\" id=\"verCliente\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 2001, "\"", 2042, 3);
            WriteAttributeValue("", 2011, "verCliente(", 2011, 11, true);
#line 46 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
WriteAttributeValue("", 2022, chamado.cliente.Id, 2022, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2041, ")", 2041, 1, true);
            EndWriteAttribute();
            BeginContext(2043, 161, true);
            WriteLiteral(">\r\n                                    <i class=\"fas fa-search\"></i>\r\n                                    Visualizar\r\n                                </buttom>\r\n");
            EndContext();
#line 50 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                                 if(User.Identity.IsAuthenticated){

#line default
#line hidden
            BeginContext(2273, 67, true);
            WriteLiteral("                                    <buttom class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2340, "\"", 2382, 3);
            WriteAttributeValue("", 2350, "novoChamado(", 2350, 12, true);
#line 51 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
WriteAttributeValue("", 2362, chamado.cliente.Id, 2362, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2381, ")", 2381, 1, true);
            EndWriteAttribute();
            BeginContext(2383, 211, true);
            WriteLiteral(">\r\n                                        <i class=\"fas fa-plus\"></i>\r\n                                        Novo Chamado\r\n                                    </buttom>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2594, "\"", 2660, 1);
#line 55 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
WriteAttributeValue("", 2601, Url.Action("Edit","Client", new {Id = chamado.cliente.Id}), 2601, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2661, 194, true);
            WriteLiteral(" class=\"btn btn-default\">\r\n                                        <i class=\"fas fa-file\"></i>\r\n                                        Editar Cliente\r\n                                    </a>\r\n");
            EndContext();
#line 59 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2890, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 62 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                            }
                        } else
                        {

#line default
#line hidden
            BeginContext(3046, 228, true);
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"8\">\r\n                                    Nenhum chamado foi aberto ainda!\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 70 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3301, 123, true);
            WriteLiteral("                    </tbody>\r\n                <tfoot>\r\n                    <tr>\r\n                        <td colspan=\"8\">\r\n");
            EndContext();
#line 75 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
            BeginContext(3520, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3554, "\"", 3592, 1);
#line 77 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
WriteAttributeValue("", 3561, Url.Action("Create", "Client"), 3561, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3593, 757, true);
            WriteLiteral(@" class=""btn btn-info"">
                                    <i class=""fas fa-plus""></i>
                                    Novo Cliente
                                </a>
                                <buttom id=""chamadoAdd"" data-toggle=""modal"" data-target=""#NovoChamado"" class=""btn btn-default"">
                                    <i class=""fas fa-plus""></i>
                                    Novo Chamado
                                </buttom>
                                <buttom id=""chamadoClose"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#FecharChamado"">
                                    <i class=""fas fa-times""></i>
                                    Fechar Chamado
                                </buttom>
");
            EndContext();
#line 89 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                            } else
                            {

#line default
#line hidden
            BeginContext(4416, 90, true);
            WriteLiteral("                                <strong>Realize o login para acessar as opções!</strong>\r\n");
            EndContext();
#line 92 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                            }    

#line default
#line hidden
            BeginContext(4541, 675, true);
            WriteLiteral(@"                        </td>
                    </tr>
                </tfoot>
            </table>
        </div> 
    </div>
</div>

<div class=""modal fade"" id=""NovoChamado"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <h4 class=""modal-title"" id=""exampleModalLabel"">Novo Chamado</h4>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(5216, 591, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "834d642b45f04ba29976dc6933ea84dd", async() => {
                BeginContext(5222, 263, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""recipient-name"" class=""control-label"">Selecione o Cliente:</label>
                        <select name=""Cliente"" class=""form-control"" id=""Cliente"">
                            ");
                EndContext();
                BeginContext(5485, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6d28afe8652446ba96af266d99ba88b", async() => {
                    BeginContext(5502, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5520, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 114 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                             foreach (var cliente in ViewBag.Clientes){

#line default
#line hidden
                BeginContext(5595, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(5627, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db8a7a602ca141e28f3e7ec4aea6ad1d", async() => {
                    BeginContext(5656, 23, false);
#line 115 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                                                       Write(cliente.RazaoSocialNome);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 115 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                                   WriteLiteral(cliente.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5688, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 116 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(5721, 79, true);
                WriteLiteral("                        </select>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5807, 3949, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" id=""abrir"" class=""btn btn-primary"">Abrir chamado</button>
            </div>
        </div>
    </div>
</div>


<div class=""modal fade"" id=""FecharChamado"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <h4 class=""modal-title"" id=""exampleModalLabel"">Você deseja mesmo encerrar este chamado?</h4>
            </div>

            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" id=""fechar"" cla");
            WriteLiteral(@"ss=""btn btn-primary"">Fechar chamado</button>
            </div>
        </div>
    </div>
</div>


<div class=""modal fade"" id=""infoCliente"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <h4 class=""modal-title"" >Detalhes do Cliente</h4>
            </div>
             <div class=""modal-body"">
             <div class=""form-group"">
                 <span>Documento: </span>
                 <label for=""recipient-name"" class=""control-label"" id=""documento""></label>
             </div>
             <div class=""form-group"">
                 <span>Nome: </span>
                 <label for=""recipient-name"" class=""control-label"" id=""sla""></label>
             </div>
             <div class=""form-group"">
");
            WriteLiteral(@"                 <span>Documento: </span>
                 <label for=""recipient-name"" class=""control-label"" id=""nome""></label>
             </div>
             <div class=""form-group"">
                 <span>CEP: </span>
                 <label for=""recipient-name"" class=""control-label"" id=""cep""></label>
             </div>
             <div class=""form-group"">
                 <span>Logradouro: </span>
                 <label for=""recipient-name"" class=""control-label"" id=""logradouro""></label>
             </div>
             <div class=""form-group"">
                 <span>Número: </span>
                 <label for=""recipient-name"" class=""control-label"" id=""numero""></label>
             </div>
             <div class=""form-group"">
                 <span>Bairro: </span>
                 <label for=""recipient-name"" class=""control-label"" id=""bairro""></label>
             </div>
             <div class=""form-group"">
                 <span>Complemnto: </span>
                 <label for=""rec");
            WriteLiteral(@"ipient-name"" class=""control-label"" id=""complemento""></label>
             </div>
             <div class=""form-group"">
                 <span>Cidade: </span>
                 <label for=""recipient-name"" class=""control-label"" id=""cidade""></label>
             </div>
             <div class=""form-group"">
                 <span>Estado: </span>
                 <label for=""recipient-name"" class=""control-label"" id=""estado""></label>
             </div>
             <div class=""form-group"">
                 <span>Telefone: </span>
                 <label for=""recipient-name"" class=""control-label"" id=""telefone""></label>
             </div>
                 </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(9774, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(9780, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "881823b8813841f8917573bab23ca198", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9834, 406, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#dataTable"").DataTable({
                buttons: [
                    'excel'
                ]
            });
        })

        $(""#abrir"").click(function(){
            var cliente = $(""#Cliente"").val()
            console.log(""cliente =>"", cliente)
            $.ajax({
                url: '");
                EndContext();
                BeginContext(10241, 26, false);
#line 222 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                 Write(Url.Action("Abrir","Home"));

#line default
#line hidden
                EndContext();
                BeginContext(10267, 913, true);
                WriteLiteral(@"',
                type: ""post"",
                data: JSON.stringify(cliente),
                dataType: ""json"",
                contentType:'application/json',
                success: function(success) {
                    console.log(""data => "", success)
                    alert(""Chamado Aberto!"")
                },
                error: function(erro){
                    console.log(""erro => "", erro)
                    alert(erro.erro)
                }
            })
        })


        $(""#fechar"").click(function(){
            var checks = $("".chamadoItem"");
            for(var i =0;i < checks.length;i++){
                if(checks[i].checked == true){
                    console.log(""checkboxs => "", checks[i].attributes[2].nodeValue)
                    var chamadoId = checks[i].attributes[2].nodeValue;
                    $.ajax({
                        url: '");
                EndContext();
                BeginContext(11181, 27, false);
#line 246 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                         Write(Url.Action("Fechar","Home"));

#line default
#line hidden
                EndContext();
                BeginContext(11208, 710, true);
                WriteLiteral(@"',
                        type: 'post',
                        data: JSON.stringify(chamadoId),
                        dataType: ""json"",
                        contentType:'application/json',
                        success: function(success) {
                            console.log(""data => "", success)
                            alert(""Chamado fechado!"")
                        },
                        error: function(erro){
                            alert(erro.erro)

                        }

                    })
                }
            }
        })


        function verCliente(id){
            var clientId = id

            $.ajax({
                url: '");
                EndContext();
                BeginContext(11919, 37, false);
#line 270 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                 Write(Url.Action("ClientDetails", "Client"));

#line default
#line hidden
                EndContext();
                BeginContext(11956, 1223, true);
                WriteLiteral(@"',
                type: ""post"",
                data: JSON.stringify(clientId),
                dataType: ""json"",
                contentType:'application/json',
                success: function(data) {
                    console.log(""data => "", data)

                    $(""#documento"").text(data.cliente.cpfCnpj)
                    $(""#sla"").text(data.cliente.slaRespostaTempo)
                    $(""#nome"").text(data.cliente.razaoSocialNome)
                    $(""#cep"").text(data.cliente.cep)
                    $(""#logradouro"").text(data.cliente.logradouro)
                    $(""#numero"").text(data.cliente.logradouroNumero)
                    $(""#bairro"").text(data.cliente.logradouroBairro)
                     $(""#cidade"").text(data.cliente.logradouroCidade)
                    $(""#estado"").text(data.cliente.logradouroUF)
                    $(""#telefone"").text(data.cliente.telefone)
                    $(""#complemento"").text(data.cliente.logradouroComplemento)

                 ");
                WriteLiteral("   $(\"#infoCliente\").modal(\"show\")\r\n                }\r\n\r\n            })\r\n\r\n        }\r\n\r\n\r\n        function novoChamado(id){\r\n            var cliente = id\r\n            $.ajax({\r\n                url: \'");
                EndContext();
                BeginContext(13180, 26, false);
#line 301 "/Users/macmini/Documents/avaliacao/Views/Home/Index.cshtml"
                 Write(Url.Action("Abrir","Home"));

#line default
#line hidden
                EndContext();
                BeginContext(13206, 526, true);
                WriteLiteral(@"',
                type: ""post"",
                data: JSON.stringify(cliente),
                dataType: ""json"",
                contentType:'application/json',
                success: function(success) {
                    console.log(""data => "", success)
                    alert(""Chamado Aberto!"")
                },
                error: function(erro){
                    console.log(""erro => "", erro)
                    alert(erro.erro)
                }
            })
        }

    </script> 
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Chamados>> Html { get; private set; }
    }
}
#pragma warning restore 1591
