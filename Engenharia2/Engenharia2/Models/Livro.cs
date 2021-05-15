using Engenharia2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Livro
    {
        private int id;
        private string nome;
        private Editora editora;
        private Administrador administrador;
        private Autor autor;
        private int qtd;

        public Livro()
        {
            
        }

        public Livro(int id, string nome, Editora editora, Administrador administrador, Autor autor, int qtd)
        {
            this.Id = id;
            this.Nome = nome;
            this.Editora = editora;
            this.Administrador = administrador;
            this.Autor = autor;
            this.Qtd = qtd;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public Editora Editora { get => editora; set => editora = value; }
        public Administrador Administrador { get => administrador; set => administrador = value; }
        public Autor Autor { get => autor; set => autor = value; }
        public int Qtd { get => qtd; set => qtd = value; }

        public List<Livro> obterTodosLivros()
        {
            return new DAL.LivroDAL().selecionarTodos();
        }

        public string Gravar(System.Text.Json.JsonElement dados)
        {
            string msg = "Falha ao Gravar Livro!";

            LivroDAL livrodal = new LivroDAL();


            Livro livro = null;
            if (dados.GetProperty("nome").ToString().Length > 0 && dados.GetProperty("autor").ToString().Length > 0 && dados.GetProperty("editora").ToString().Length > 0)
            {
                AutorDAL autordal = new AutorDAL();
                livro = new Livro();
                livro.Nome = dados.GetProperty("nome").ToString();
                livro.Autor = autordal.BuscaAutorPorId(Convert.ToInt32(dados.GetProperty("autor").ToString()));
                livro.Editora = new EditoraDAL().BuscaEditoraPorId(Convert.ToInt32(dados.GetProperty("editora").ToString()));
                livro.Qtd = Convert.ToInt32(dados.GetProperty("qtd").ToString());
                livro.Administrador = new AdministradorDAL().obter("Leonardo Custodio dos Santos");
            }
            if (livro != null)
                msg = livrodal.gravar(livro);
            return msg;
        }
    }
}
