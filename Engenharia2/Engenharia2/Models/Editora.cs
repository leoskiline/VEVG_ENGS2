using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Editora
    {
        private int id;
        private string nome;
        private string descricao;
        private string telefone;
        private Administrador administrador;

        public Editora(int id, string nome, string descricao, string telefone, Administrador administrador)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Telefone = telefone;
            this.Administrador = administrador;
        }
        public Editora()
        {
            this.Id = 0;
            this.Nome = "";
            this.Descricao = "";
            this.Telefone = "";
            this.Administrador = null;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public Administrador Administrador { get => administrador; set => administrador = value; }
    }
}
