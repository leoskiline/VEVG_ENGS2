#pragma checksum "C:\Users\Leonardo\Documents\GitHub\VEVG_ENGS2\Engenharia2\Engenharia2\Views\Leitor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4a229ec7e59dca7b44222bc328b990c114b1474"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leitor_Index), @"mvc.1.0.view", @"/Views/Leitor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4a229ec7e59dca7b44222bc328b990c114b1474", @"/Views/Leitor/Index.cshtml")]
    public class Views_Leitor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/views/leitor/Index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/HTTPClient.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/views/leitor/mascaraCPF.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Leonardo\Documents\GitHub\VEVG_ENGS2\Engenharia2\Engenharia2\Views\Leitor\Index.cshtml"
  
    ViewData["Title"] = "Gerenciar Leitor";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0"">Pagina de Gerenciamento do Leitor</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4a229ec7e59dca7b44222bc328b990c114b14744636", async() => {
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
                    <li class=""breadcrumb-item active"">Cadastro de Leitor</li>
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
            BeginWriteAttribute("class", " class=\"", 796, "\"", 804, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <form class=""form-horizontal"">
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""nomeLeitor""><span style=""color:red;"">*</span>Nome:</label>
                    <div class=""col-sm-2"">
                        <input type=""text"" class=""form-control"" id=""nomeLeitor"" placeholder=""Digite o Nome do Leitor"">
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""cpfLeitor""><span style=""color:red;"">*</span>CPF:</label>
                    <div class=""col-sm-2"">
                        <input class=""form-control"" id=""cpfLeitor"" onkeydown=""javascript: fMasc( this, mCPF );"" maxlength=""14"" placeholder=""Digite o CPF do Leitor""/>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""dataLeitor""><span style=""color:red;"">*</span>Data de Nascimento:<");
            WriteLiteral(@"/label>
                    <div class=""col-sm-2"">
                        <input type=""date"" class=""form-control"" id=""dataLeitor"">
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-2"" for=""enderecoLeitor""><span style=""color:red;"">*</span>Endereco:</label>
                    <div class=""col-sm-2"">
                        <input class=""form-control"" id=""enderecoLeitor"" placeholder=""Digite o endereco do Leitor""/>
                        <span>Os campos com <span style=""color:red;"">*</span> são obrigatórios.</span>
                        <input type=""hidden"" id=""valorId"" value=""0""/>
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-sm-offset-2 col-sm-10"">
                        <button type=""button"" class=""btn btn-success"" onclick=""indexLeitor.enviar()"">Cadastrar</button>
                    </div><br />
                  ");
            WriteLiteral(@"  <div class=""col-sm-3"" id=""gravou""></div>
                </div>

            </form>
            <div class=""center"">
                <div class=""row"">
                    <h2 class=""m-1"">Lista de Leitores</h2>
                    <p class=""col-sm-5""></p>
                    <input type=""text"" class=""form-control col-sm-2 m-1"" id=""pesquisaLeitor"" onkeydown=""javascript: fMasc( this, mCPF );"" maxlength=""14"" placeholder=""Digite o CPF do leitor""");
            BeginWriteAttribute("value", " value=\"", 3308, "\"", 3316, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    <input type=""button"" class=""form-control col-1 btn-dark m-1"" value=""Pesquisar"" onclick=""indexLeitor.pesquisar()"" />
                    <input type=""button"" class=""form-control col-1 btn-default m-1"" value=""Listar Todos"" onclick=""indexLeitor.carregar()"" />
                </div>
                <table id=""tabela"" class=""table table-bordered table-hover"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Nome</th>
                            <th>CPF</th>
                            <th>Endereco</th>
                            <th>Data de Nascimento</th>
                            <th>Apagar</th>
                            <th>Alterar</th>
                        </tr>
                    </thead>
                    <tbody id=""corpo-tabela"">
                    </tbody>
                </table>
            </div>
        </div>
        <!-- /.row -->
    </div><!-- /.container-fluid -");
            WriteLiteral("->\r\n</div>\r\n\r\n");
            DefineSection("javascript", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4a229ec7e59dca7b44222bc328b990c114b147410215", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4a229ec7e59dca7b44222bc328b990c114b147411315", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4a229ec7e59dca7b44222bc328b990c114b147412415", async() => {
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
