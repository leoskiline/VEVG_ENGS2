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
    }
}
