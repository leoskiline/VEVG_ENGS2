using Engenharia2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.Models
{
    public class Emprestimo
    {
        private int id;
        private int atendenteId;
        private int exemplarId;
        private int pagamentoId;
        private Atendente atendente;
        private Exemplar exemplar;
       

        public Emprestimo()
        {

        }

        public Emprestimo(int id, int atendenteId, int exemplarId, int pagamentoId)
        {
            this.Id = id;
            this.exemplarId = exemplarId;
            this.pagamentoId = pagamentoId;
        }

        public int Id { get => id; set => id = value; }

       
        
        public string Gravar(System.Text.Json.JsonElement dados)
        {
            string msg = "Falha ao Gravar Emprestimo!";
            string msg2 = "";
           // ReservaDAL reservadal = new ReservaDAL();
           // Livro livro = new LivroDAL().seleciona(Convert.ToInt32(dados.GetProperty("livro").ToString()));
          //  Leitor leitor = new LeitorDAL().BuscaLeitorPorCPF(dados.GetProperty("cpf").ToString());
           // bool reservado = reservadal.isReservado(leitor.Id, livro.Id);            

            if (msg2 == "Reserva Gravada com Sucesso!")
                return msg;
            else
                return msg;
        }        

    }
}
