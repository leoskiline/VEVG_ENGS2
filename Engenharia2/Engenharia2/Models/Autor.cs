using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Autor
    {
        private int id;
        private string nome;
        private Administrador administrador;

        public Autor(int id, string nome, Administrador administrador)
        {
            this.Id = id;
            this.Nome = nome;
            this.Administrador = administrador;
        }

        public Autor()
        {
            this.Id = 0;
            this.Nome = "";
            this.Administrador = null;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public Administrador Administrador { get => administrador; set => administrador = value; }
    }
}
