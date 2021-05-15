using Engenharia2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Autor
    {
        private int id;
        private string nome;
        private Administrador administrador;

        public Autor(int id, string nome, Administrador administrador)
        {
            this.Id = id;
            this.Nome = nome;
            this.Administrador = administrador;
        }

        public Autor()
        {
            this.Id = 0;
            this.Nome = "";
            this.Administrador = null;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public Administrador Administrador { get => administrador; set => administrador = value; }

        public string Gravar(System.Text.Json.JsonElement dados)
        {
            string msg = "Falha ao Gravar Autor!";
            AutorDAL autordal = new AutorDAL();
            Autor autor = new Autor();

            autor.Nome = dados.GetProperty("nome").ToString();


            if (autor.Nome.Length > 0)
                msg = autordal.gravar(autor);
            else
                msg = "Preencha Todos os Campos";
            return msg;
        }
    }
}
