using Engenharia2.DAL;
using Engenharia2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Controllers
{
    public class CadastrarLivroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Gravar([FromBody] System.Text.Json.JsonElement dados)
        {
            string msg = "Falha ao Gravar Livro!";
            
            LivroDAL livrodal = new LivroDAL();
            

            Livro livro = null;
            if(dados.GetProperty("nome").ToString().Length>0 && dados.GetProperty("autor").ToString().Length>0 && dados.GetProperty("editora").ToString().Length>0)
            {
                AutorDAL autordal = new AutorDAL();
                livro = new Livro();
                livro.Nome = dados.GetProperty("nome").ToString();
                livro.Autor = autordal.BuscaAutorPorId(Convert.ToInt32(dados.GetProperty("autor").ToString()));
                livro.Editora = new EditoraDAL().BuscaEditoraPorId(Convert.ToInt32(dados.GetProperty("editora").ToString()));
                livro.Qtd = Convert.ToInt32(dados.GetProperty("qtd").ToString());
                livro.Administrador = new AdministradorDAL().obter("Leonardo Custodio dos Santos");
            }
            if(livro != null)
                msg = livrodal.gravar(livro);

            return Json(new
            {
                msg
            });
        }
        [HttpGet]
        public IActionResult ObterEditoras()
        {
            EditoraDAL edal = new EditoraDAL();
            List<Editora> editoras = edal.selecionarTodos();
            IEnumerable<Editora> edt = editoras.AsEnumerable();
            return Json(edt);
        }

        [HttpGet]
        public IActionResult ObterAutores()
        {
            AutorDAL adal = new AutorDAL();
            List<Models.Autor> autores = adal.selecionarTodos();
            IEnumerable<Autor> atr = autores.AsEnumerable();
            return Json(atr);
        }
    }
}
