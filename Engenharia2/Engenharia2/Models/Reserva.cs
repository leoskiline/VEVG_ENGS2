using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Reserva
    {
        private int id;
        private string dataInicio;
        private string dataFim;
        private Leitor leitor;
        private Atendente atendende;

        public Reserva(int id, string dataInicio, string dataFim, Leitor leitor, Atendente atendende)
        {
            this.Id = id;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.Leitor = leitor;
            this.Atendende = atendende;
        }

        public int Id { get => id; set => id = value; }
        public string DataInicio { get => dataInicio; set => dataInicio = value; }
        public string DataFim { get => dataFim; set => dataFim = value; }
        public Leitor Leitor { get => leitor; set => leitor = value; }
        public Atendente Atendende { get => atendende; set => atendende = value; }
    }
}
