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
        public Exemplar(int id, Livro livro, int qtd, Posicao posicao)
        {
            this.Id = id;
            this.livro = livro;
            this.Qtd = qtd;
            this.Posicao = posicao;
        }

        public int Id { get => id; set => id = value; }
        public Livro livro { get => livro; set => livro = value; }
        public int Qtd { get => qtd; set => qtd = value; }
        public Posicao Posicao { get => posicao; set => posicao = value; }
    }
}
