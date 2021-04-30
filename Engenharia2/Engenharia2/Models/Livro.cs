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
        private Exemplar exemplar;
        private Editora editora;
        private Reserva reserva;
        private Autor autor;
        private Administrador administrador;

        public Livro(int id, string nome, Exemplar exemplar, Editora editora, Reserva reserva, Autor autor, Administrador administrador)
        {
            this.Id = id;
            this.Nome = nome;
            this.Exemplar = exemplar;
            this.Editora = editora;
            this.Reserva = reserva;
            this.Autor = autor;
            this.Administrador = administrador;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public Exemplar Exemplar { get => exemplar; set => exemplar = value; }
        public Editora Editora { get => editora; set => editora = value; }
        public Reserva Reserva { get => reserva; set => reserva = value; }
        public Autor Autor { get => autor; set => autor = value; }
        public Administrador Administrador { get => administrador; set => administrador = value; }
    }
}
