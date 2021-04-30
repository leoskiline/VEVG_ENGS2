using Engenharia2.DAL;
using Engenharia2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Controllers
{
    public class CadastrarAutorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gravar([FromBody] System.Text.Json.JsonElement dados)
        {
            string msg = "Falha ao Gravar Autor!";
            AutorDAL autordal = new AutorDAL();
            Autor autor = new Autor();

            autor.Nome = dados.GetProperty("nome").ToString();


            if (autor.Nome.Length > 0)
                msg = autordal.gravar(autor);
            else
                msg = "Preencha Todos os Campos";
            return Json(new
            {
                msg
            });
        }
    }
}
