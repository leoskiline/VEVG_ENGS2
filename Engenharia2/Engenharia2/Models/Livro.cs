using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Livro
    {
        private int id;
        private string nome;
        private Exemplar exemplar;
        private Editora editora;
        private Reserva reserva;
        private Autor autor;
    }
}
