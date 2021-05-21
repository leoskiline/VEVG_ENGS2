using Engenharia2.DAL;
using Engenharia2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Gravar([FromBody] System.Text.Json.JsonElement dados)
        {
            string nome = dados.GetProperty("nome").ToString();
            int editoraId;
            Int32.TryParse(dados.GetProperty("editora").ToString(), out editoraId);
            int contautores = dados.GetProperty("autor").GetArrayLength();
            List<int> autoresId = new List<int>();
            int qtd;
            Int32.TryParse(dados.GetProperty("qtd").ToString(), out qtd);
            for(int i = 0;i < contautores;i++)
            {
                autoresId.Add(Convert.ToInt32(dados.GetProperty("autor")[i].ToString()));
            }
            Editora editora = new Editora().obterEditoraPorID(editoraId);
            List<Autor> autores = new Autor().obterAutoresPorListID(autoresId);
            Administrador adm = new Administrador().obter("Leonardo Custodio dos Santos");
            string msg = "Preencha Todos os Campos!!!";
            if(nome.Trim().Length>0 && editoraId != 0 && contautores>0 && autoresId != null && qtd > 0 && editora != null && autores != null && adm != null)
            {
                msg = new Livro().Gravar(nome, autores, editora, adm, qtd);
            }
            return Json(new
            {
                msg
            });
        }
        [HttpGet]
        public IActionResult ObterEditoras()
        {
            return Json(new Models.Editora().obterTodasEditoras().AsEnumerable());
        }

        [HttpGet]
        public IActionResult ObterAutores()
        {
            return Json(new Models.Autor().obterTodosAutores().AsEnumerable());
        }
    }
}
