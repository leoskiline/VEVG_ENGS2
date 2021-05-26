using Engenharia2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Engenharia2.Controllers
{
    public class AutenticarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Entrar([FromBody] JsonElement dados)
        {
            string email = dados.GetProperty("email").ToString();
            string senha = dados.GetProperty("senha").ToString();
            Administrador adm = new Administrador().Autenticar(email, senha);
            string msg = "Erro";
            if (adm != null)
            {
                msg = "Administrador";
            }else{
                Atendente at = new Atendente().Autenticar(email, senha);
                if(at != null)
                {
                    msg = "Atendente";
                }
            }
            return Json(new
            {
                msg
            });
        }
    }
}
