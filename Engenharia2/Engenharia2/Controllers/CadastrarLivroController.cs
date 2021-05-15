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
            string msg = new Livro().Gravar(dados);

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
