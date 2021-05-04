using Engenharia2.DAL;
using Engenharia2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Controllers
{
    public class CadastrarExemplarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gravar([FromBody] System.Text.Json.JsonElement dados)
        {
            string msg = "Falha ao Gravar Exemplar!";

            ExemplarDAL exempDAL = new ExemplarDAL();


            Exemplar ex = new Exemplar();

            ex.Qtd = Convert.ToInt32(dados.GetProperty("qtd"));
            ex.Posicao = new Posicao(){
                Setor = dados.GetProperty("setorPos").ToString(),
                Prateleira = dados.GetProperty("prateleiraPos").ToString() 
            };

            exempDAL.gravar(ex);

            return Json(new
            {
                msg
            });
        }
    }
}
