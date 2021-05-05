using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Exemplar
    {
        private int id;
        private int qtd;
        private Livro livro;
        private Posicao posicao;

        public Exemplar()
        {

        }

        public Exemplar(int id, int qtd, Livro livro, Posicao posicao)
        {
            this.Id = id;
            this.Qtd = qtd;
            this.Livro = livro;
            this.Posicao = posicao;
        }

        public int Id { get => id; set => id = value; }
        public int Qtd { get => qtd; set => qtd = value; }
        public Livro Livro { get => livro; set => livro = value; }
        public Posicao Posicao { get => posicao; set => posicao = value; }
    }
}
