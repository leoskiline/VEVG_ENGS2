using Engenharia2.DAL;
using Engenharia2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Controllers
{
    public class ExemplarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gravar([FromBody] System.Text.Json.JsonElement dados)
        {
            string msg;
            msg = new Exemplar().Gravar(dados);
            return Json(new
            {
                msg
            });
        }
        [HttpGet]
        public IActionResult ObterLivros()
        {
            return Json(new Models.Livro().obterTodosLivros().AsEnumerable());
        }
    }
}
