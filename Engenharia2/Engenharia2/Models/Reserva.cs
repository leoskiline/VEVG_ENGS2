using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Reserva
    {
        private int id;
        private DateTime dataInicio;
        private DateTime dataFim;
        private Leitor leitor;
        private Atendente atendende;

        public Reserva(int id, DateTime dataInicio, DateTime dataFim, Leitor leitor, Atendente atendende)
        {
            this.Id = id;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.Leitor = leitor;
            this.Atendende = atendende;
        }

        public int Id { get => id; set => id = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public DateTime DataFim { get => dataFim; set => dataFim = value; }
        public Leitor Leitor { get => leitor; set => leitor = value; }
        public Atendente Atendende { get => atendende; set => atendende = value; }
    }
}
