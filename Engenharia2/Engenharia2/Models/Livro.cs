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
    }
}
