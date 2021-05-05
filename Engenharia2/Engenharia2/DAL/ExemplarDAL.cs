using Engenharia2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.DAL
{
    public class ExemplarDAL
    {
        MySQLPersistence _bd = new MySQLPersistence();

        public string gravar(Exemplar ex)
        {
            string msg = "Falha ao Gravar Exemplar";
            string sql = "insert into exemplar (qtd,posicaoId,livroId) VALUES (@qtd,@posicaoId,@livroId)";
            _bd.LimparParametros();
            _bd.AdicionarParametro("@qtd", ex.Qtd.ToString());
            _bd.AdicionarParametro("@posicaoId", ex.Posicao.Id.ToString());
            _bd.AdicionarParametro("@livroId", ex.Livro.Id.ToString());
            _bd.AbrirConexao();
            int rows = _bd.ExecutarNonQuery(sql);
            _bd.FecharConexao();

            if (rows > 0)
            {
                msg = "Exemplar Gravado com Sucesso!";
            }
            return msg;
        }

        public Exemplar BuscaExemplar(string nome)
        {
            string sql = "SELECT * FROM exemplar WHERE nome=@nome";
            _bd.LimparParametros();
            _bd.AdicionarParametro("@nome", nome);
            _bd.AbrirConexao();

            DataTable dt = _bd.ExecutarSelect(sql);
            Exemplar exemplar = null;

            if(dt.Rows.Count > 0)
            {
                exemplar = new Exemplar();
                exemplar.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                exemplar.Posicao = null;
                exemplar.Qtd = Convert.ToInt32(dt.Rows[0]["qtd"]);      
                

            }

            return exemplar;
            
            
        }
    }
}
