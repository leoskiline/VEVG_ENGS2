using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Exemplar
    {
        private int id;
        private Livro livro;
        private Posicao posicao;

        public Exemplar()
        {

        }

        public Exemplar(int id, Livro livro, Posicao posicao)
        {
            this.Id = id;
            this.Livro = livro;
            this.Posicao = posicao;
        }

        public int Id { get => id; set => id = value; }
        public Livro Livro { get => livro; set => livro = value; }
        public Posicao Posicao { get => posicao; set => posicao = value; }
    }
}
