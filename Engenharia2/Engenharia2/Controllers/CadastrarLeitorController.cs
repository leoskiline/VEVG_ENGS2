using Engenharia2.DAL;
using Engenharia2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Controllers
{
    public class CadastrarLeitorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gravar([FromBody] System.Text.Json.JsonElement dados)
        {
            string msg = "Falha ao Gravar Editora!";
            LeitorDAL leitordal = new LeitorDAL();
            Leitor leitor = new Leitor();

            leitor.Nome = dados.GetProperty("nome").ToString();
            leitor.Cpf = dados.GetProperty("cpf").ToString();
            leitor.Endereco = dados.GetProperty("endereco").ToString();


            if (leitor.Nome.Length > 0 && leitor.Cpf.Length > 0 && leitor.Endereco.Length > 0)
                msg = leitordal.gravar(leitor);
            else
                msg = "Preencha Todos os Campos";
            return Json(new
            {
                msg
            });
        }
    }
}
