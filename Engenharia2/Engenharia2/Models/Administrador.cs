using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Administrador
    {
        private int id;
        private string nome;
        private string cpf;
        private string endereco;
        private string telefone;

        public Administrador()
        {

        }

        public Administrador(int id, string nome, string cpf, string endereco, string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
