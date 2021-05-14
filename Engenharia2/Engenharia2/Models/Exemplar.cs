using Engenharia2.DAL;
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

        public string Gravar(System.Text.Json.JsonElement dados)
        {
            string msg = "Falha ao Gravar Exemplar!";
            LivroDAL ldal = new LivroDAL();
            PosicaoDAL pdal = new PosicaoDAL();
            ExemplarDAL edal = new ExemplarDAL();
            Exemplar exemplar = null;
            if (dados.GetProperty("livroId").ToString().Length > 0 && dados.GetProperty("setor").ToString().Length > 0 && dados.GetProperty("prateleira").ToString().Length > 0)
            {
                exemplar = new Exemplar()
                {
                    Livro = ldal.seleciona(Convert.ToInt32(dados.GetProperty("livroId").ToString())),
                    Posicao = pdal.gravar(dados.GetProperty("setor").ToString(), dados.GetProperty("prateleira").ToString())
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
            return msg;
        }
    }
}
