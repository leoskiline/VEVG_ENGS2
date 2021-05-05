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
            LivroDAL ldal = new LivroDAL();
            PosicaoDAL pdal = new PosicaoDAL();
            ExemplarDAL edal = new ExemplarDAL();
            Exemplar exemplar = null;
            if(dados.GetProperty("livroId").ToString().Length > 0 && dados.GetProperty("qtd").ToString().Length>0 && dados.GetProperty("setor").ToString().Length>0)
            {
                exemplar = new Exemplar()
                {
                    Livro = ldal.seleciona(Convert.ToInt32(dados.GetProperty("livroId").ToString())),
                    Qtd = Convert.ToInt32(dados.GetProperty("qtd").ToString()),
                    Posicao = pdal.obter(dados.GetProperty("setor").ToString())
                };
            }
            else
            {
                msg = "Preencha os Campos!!!";
            }
            if (exemplar != null)
                if (exemplar.Posicao != null)
                    msg = edal.gravar(exemplar);
                else
                    msg = "Posicao Nao Existe!";
            
            return Json(new
            {
                msg
            });
        }
        [HttpGet]
        public IActionResult ObterLivros()
        {
            LivroDAL ldal = new LivroDAL();
            List<Models.Livro> livros = ldal.selecionarTodos();
            IEnumerable<Livro> lvr = livros.AsEnumerable();
            return Json(lvr);
        }
    }
}
