#pragma checksum "C:\Users\Leonardo\Source\Repos\leoskiline\VEVG_ENGS2\Engenharia2\Engenharia2\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce67ee689162b8ab41b501590bb931134a6a037e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce67ee689162b8ab41b501590bb931134a6a037e", @"/Views/Usuario/Index.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/HTTPClient.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/views/exemplar/mascaraCPF.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/views/editora/mascaraTel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Leonardo\Source\Repos\leoskiline\VEVG_ENGS2\Engenharia2\Engenharia2\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0"">Pagina Gerenciar Usuarios</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce67ee689162b8ab41b501590bb931134a6a037e4729", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"">Gerenciar Usuario</li>
                </ol>
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>
<!-- /.content-header -->
<!-- Main content -->
<div class=""content"">
    <div class=""container-fluid"">
        <div");
            BeginWriteAttribute("class", " class=\"", 827, "\"", 835, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <form id=""reserva-fdados"" class=""form-inline"">

                <div class=""form-group mt-2"">
                    <label class=""control-label col-sm-3"" for=""email"">E-mail:</label>
                    <div class=""col-sm-2"">
                        <input type=""email"" class=""form-control"" id=""email"" placeholder=""E-mail"">
                    </div>
                </div>

                <div class=""form-group ml-2 mt-2"">
                    <label class=""control-label col-sm-2"" for=""senha"">Senha:</label>
                    <div class=""col-sm-2"">
                        <input type=""password"" placeholder=""Senha"" id=""senha"" class=""form-control"" />
                    </div>
                </div>

                <div class=""form-group mt-2"">
                    <label class=""control-label col-sm-1"" for=""nome"">Nome: </label>
                    <div class=""col-sm-2 ml-2"">
                        <input type=""text"" placeholder=""Nome"" id=""nome"" class=""form-control"" />
           ");
            WriteLiteral(@"         </div>
                </div>

                <div class=""form-group mt-2"">
                    <label class=""control-label col-sm-2"" for=""CPF"">CPF:</label>
                    <div class=""col-sm-2"">
                        <input type=""text"" onkeydown=""javascript: fMasc( this, mCPF );"" maxlength=""14"" placeholder=""Digite o CPF"" id=""cpf"" class=""form-control"" />
                    </div>
                </div>

                <div class=""form-group mt-2"">
                    <label class=""control-label col-sm-2 ml-2"" for=""endereco"">Endere??o:</label>
                    <div class=""col-sm-2 ml-2"">
                        <input type=""text"" placeholder=""Endere??o"" id=""endereco"" class=""form-control"" />
                    </div>
                </div>

                <div class=""form-group mt-2 ml-2"">
                    <label class=""control-label""  for=""telefone"">Telefone:</label>
                    <div class=""col-sm-1 ml-2"">
                        <input type=""text"" onkeypress");
            WriteLiteral(@"=""mask(this, mphone);"" maxlength=""15"" placeholder=""Telefone"" id=""telefone"" class=""form-control"" />
                    </div>
                </div>

                <div class=""form-group mt-2"">
                    <label class=""control-label col-sm-6"" for=""nivel"">Nivel de acesso:</label>
                    <div class=""col-sm-1"">
                        <select class=""custom-select"" id=""nivel"" name=""nivel"">
                            <option value=""Administrador"">Administrador</option>
                            <option value=""Atendente"">Atendente</option>
                        </select>
                    </div>
                </div>

                <div class=""form-group mt-2 ml-4"">
                    <label class=""control-label col-sm-2"" for=""status"">Status:</label>
                    <div class=""col-sm-2 ml-1"">
                        <select class=""custom-select"" id=""status"" name=""status"">
                            <option value=""Ativado"">Ativado</option>
                 ");
            WriteLiteral(@"           <option value=""Desativado"">Desativado</option>
                        </select>
                    </div>
                </div>

                <div class=""form-group mt-2"">
                    <div class=""col-sm-offset-2 col-sm-10"">
                        <button type=""button"" class=""btn btn-success"">Cadastrar</button>
                    </div><br />
                    <div class=""col-sm-3"" id=""gravou""></div>
                </div>

            </form>

            <div class=""center"">
                <div class=""row"">
                    <h2 class=""m-1"">Lista de Usuarios</h2>
                    <p class=""col-sm-5""></p>
                    <input type=""text"" class=""form-control col-sm-2 m-1"" id=""pesquisaUsuario"" placeholder=""Digite o E-mail do Usuario""");
            BeginWriteAttribute("value", " value=\"", 4708, "\"", 4716, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    <input type=""button"" class=""form-control col-1 btn-dark m-1"" value=""Pesquisar"" />
                    <input type=""button"" class=""form-control col-1 btn-default m-1"" value=""Listar Todos"" />
                </div>
                <table id=""example2"" class=""table table-bordered table-hover"">
                    <thead>
                        <tr>
                            <th>E-mail</th>
                            <th>Nome</th>
                            <th>CPF</th>
                            <th>Endere??o</th>
                            <th>Telefone</th>
                            <th>Nivel de Acesso</th>
                            <th>Status</th>
                        </tr>
                    </thead>
                    <tbody id=""corpo-tabela"">
                    </tbody>
                </table>
            </div>
        </div>
        <!-- /.row -->
    </div><!-- /.container-fluid -->
</div>

");
            DefineSection("javascript", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce67ee689162b8ab41b501590bb931134a6a037e11662", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce67ee689162b8ab41b501590bb931134a6a037e12762", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce67ee689162b8ab41b501590bb931134a6a037e13862", async() => {
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
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
