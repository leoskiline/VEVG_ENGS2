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
            string sql = "insert into exemplar (Posicao_idPosicao,Livro_idLivro) VALUES (@posicaoId,@livroId)";
            _bd.LimparParametros();
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

        public Exemplar BuscaExemplar(int id)
        {
            string sql = "SELECT * FROM exemplar WHERE idExemplar=@id";
            _bd.LimparParametros();
            _bd.AdicionarParametro("@id", id.ToString());
            _bd.AbrirConexao();
            DataTable dt = _bd.ExecutarSelect(sql);
            _bd.FecharConexao();
            Exemplar exemplar = null;
            if(dt.Rows.Count > 0)
            {
                exemplar = new Exemplar();
                exemplar.Id = Convert.ToInt32(dt.Rows[0]["idExemplar"]);
                exemplar.Posicao = new PosicaoDAL().obterPorID(Convert.ToInt32(dt.Rows[0]["Posicao_idPosicao"]));
                exemplar.Livro = new LivroDAL().seleciona(Convert.ToInt32(dt.Rows[0]["Livro_idLivro"]));
            }

            return exemplar; 
        }

        public string deletar(int id)
        {
            string msg = "Falha ao Deletar Exemplar";
            string sql = "DELETE FROM exemplar WHERE idExemplar='" + id + "'";

            _bd.AbrirConexao();
            int rows = _bd.ExecutarNonQuery(sql);
            _bd.FecharConexao();
            if (rows > 0)
            {
                msg = "Exemplar deletado com Sucesso!";
            }
            return msg;
        }

        public string alterar(Exemplar exemplar)
        {
            string msg = "Falha ao Alterar Exemplar";
            string sql = "UPDATE exemplar SET Posicao_idPosicao=@idPosicao, Livro_idLivro=@idLivro WHERE idExemplar=@idExemplar";

            _bd.LimparParametros();
            _bd.AdicionarParametro("@idExemplar", exemplar.Id.ToString());
            _bd.AdicionarParametro("@idPosicao", exemplar.Posicao.Id.ToString());
            _bd.AdicionarParametro("@idLivro", exemplar.Livro.Id.ToString());
            _bd.AbrirConexao();
            int rows = _bd.ExecutarNonQuery(sql);
            _bd.FecharConexao();
            if (rows > 0)
            {
                msg = "Exemplar alterado com Sucesso!";
            }
            return msg;
        }

        public List<Exemplar> BuscaExemplaresNome(string nome)
        {
            string sql = "SELECT Posicao_idPosicao,idExemplar,Livro_idLivro FROM exemplar INNER JOIN livro ON livro.idLivro = exemplar.Livro_idLivro where livro.Nome like '%"+nome+"%'";
            _bd.AbrirConexao();
            DataTable dt = _bd.ExecutarSelect(sql);
            _bd.FecharConexao();
            List<Exemplar> exemplares = new List<Exemplar>();
            foreach (DataRow row in dt.Rows)
            {
                var exemplar = new Exemplar()
                {
                    Id = Convert.ToInt32(row["idExemplar"]),
                    Posicao = new PosicaoDAL().obterPorID(Convert.ToInt32(row["Posicao_idPosicao"])),
                    Livro = new LivroDAL().seleciona(Convert.ToInt32(row["Livro_idLivro"]))
                };
                exemplares.Add(exemplar);
            }
            return exemplares;
        }

        public List<Exemplar> selecionarTodos()
        {
            List<Exemplar> exemplares = new List<Exemplar>();
            string sql = "SELECT * FROM exemplar";
            _bd.AbrirConexao();
            DataTable dt = _bd.ExecutarSelect(sql);
            _bd.FecharConexao();
            foreach (DataRow row in dt.Rows)
            {
                var exemplar = new Exemplar()
                {
                    Id = Convert.ToInt32(row["idExemplar"]),
                    Posicao = new PosicaoDAL().obterPorID(Convert.ToInt32(row["Posicao_idPosicao"])),
                    Livro = new LivroDAL().seleciona(Convert.ToInt32(row["Livro_idLivro"]))
                };
                exemplares.Add(exemplar);
            }
            return exemplares;
        }
    }
}
