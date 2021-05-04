using Engenharia2.DAL;
using Engenharia2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Controllers
{
    public class CadastrarEditoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gravar([FromBody] System.Text.Json.JsonElement dados)
        {
            string msg = "Falha ao Gravar Editora!";
            EditoraDAL editoradal = new EditoraDAL();
            Editora editora = new Editora();
            editora.Nome = dados.GetProperty("nome").ToString();
            editora.Descricao = dados.GetProperty("descricao").ToString();
            editora.Telefone = dados.GetProperty("telefone").ToString();
            if (editora.Nome.Length > 0 && editora.Descricao.Length > 0 && editora.Telefone.Length > 0)
                msg = editoradal.gravar(editora);
            else
                msg = "Preencha Todos os Campos";
            return Json(new
            {
                msg
            });
        }
    }
}
