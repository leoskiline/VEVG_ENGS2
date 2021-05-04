using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Atendente
    {
        private int id;
        private string nome;
        private string endereco;
        private string telefone;

        public Atendente(int id, string nome, string endereco, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public Atendente()
        {
            this.id = 0;
            this.nome = "";
            this.endereco = "";
            this.telefone = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
