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
        private string dataNasc;
        private Atendente atendente;

        public Leitor(int id, string nome, string cpf, string endereco, string dataNasc, Atendente atendente)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.dataNasc = dataNasc;
            this.atendente = atendente;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string DataNasc { get => dataNasc; set => dataNasc = value; }
        public Atendente Atendente { get => atendente; set => atendente = value; }
    }
}
