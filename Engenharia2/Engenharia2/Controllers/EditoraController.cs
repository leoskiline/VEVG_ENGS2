using Engenharia2.DAL;
using Engenharia2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Controllers
{
    public class EditoraController : Controller
    {
        private EditoraDAL editoradal = new EditoraDAL();
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Gravar([FromBody] System.Text.Json.JsonElement dados)
        {
            string msg = new Editora().Gravar(dados);
            return Json(new
            {
                msg
            });
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Json(new Models.Editora().obterTodasEditoras().AsEnumerable());
        }

        [HttpPut]
        public IActionResult Alterar(int id)
        {
            string msg = "";
            Editora editora = editoradal.BuscaEditoraPorId(id);
            return Json(new
            {
                editora.Id,
                editora.Nome,
                editora.Descricao,
                editora.Telefone
            });
        }

        [HttpDelete]
        public IActionResult Deletar(int id)
        {
            string msg = "";
            msg = this.editoradal.deletar(id);
            return Json(new
            {
                msg
            });
        }
    }
}
