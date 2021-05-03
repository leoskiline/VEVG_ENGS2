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
            Livro livro = new Livro();

            livro.Nome = dados.GetProperty("nome").ToString();

            livro.Exemplar = dados.GetProperty("exemplar") //@TODO EXEMPLAR

         
            return Json(new
            {
                msg
            });
        }
    }
}
