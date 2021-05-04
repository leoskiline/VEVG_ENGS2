using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Leitor
    {
        private int id;
        private string nome;
        private string cpf;
        private string endereco;
        private DateTime dataNasc;
        private Atendente atendente;

        public Leitor(int id, string nome, string cpf, string endereco, DateTime dataNasc, Atendente atendente)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.dataNasc = dataNasc;
            this.atendente = atendente;
        }

        public Leitor()
        {
            this.id = 0;
            this.nome = "";
            this.cpf = "";
            this.endereco = "";
            this.dataNasc = Convert.ToDateTime("01/01/2000");
            this.atendente = null;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public Atendente Atendente { get => atendente; set => atendente = value; }
    }
}
