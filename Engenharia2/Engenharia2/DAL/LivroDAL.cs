using Engenharia2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.DAL
{
    public class LivroDAL
    {
        MySQLPersistence _bd = new MySQLPersistence();

        public string gravar(Livro livro)
        {
            string msg = "Falha ao Gravar Livro";
            string sql = "INSERT INTO livro (nome,editoraId,autorId,administradorId) VALUES (@nome,@editoraId,@autorId,@administradorId)";
            _bd.LimparParametros();
            _bd.AdicionarParametro("@nome", livro.Nome);
            _bd.AdicionarParametro("@editoraId", livro.Editora.Id.ToString());
            _bd.AdicionarParametro("@autorId", livro.Autor.Id.ToString());
            AdministradorDAL admDal = new AdministradorDAL();
            _bd.AdicionarParametro("@administradorId", admDal.obterIdPorNome("Leonardo Custodio dos Santos").ToString());
            _bd.AbrirConexao();
            int rows =  _bd.ExecutarNonQuery(sql);
            _bd.FecharConexao();
            if(rows > 0)
            {
                msg = "Livro " + livro.Nome + " Gravado com Sucesso!";
            }
            return msg;
        }

        //Seleção simples de Livros
        public List<Livro> selecionarTodos()
        {
            List<Livro> livros = new List<Livro>();
            string sql = "SELECT * FROM livro";
            _bd.AbrirConexao();
            DataTable dt = _bd.ExecutarSelect(sql);
            _bd.FecharConexao();
            EditoraDAL edal = new EditoraDAL();
            foreach (DataRow row in dt.Rows)
            {
                var livro = new Livro()
                {
                    Id = Convert.ToInt32(row["id"]),
                    Nome = row["nome"].ToString(),
                    Editora = edal.BuscaEditoraPorId(Convert.ToInt32(row["id"])),

                };
                livros.Add(livro);
            }
            return livros;
        }

        public Livro seleciona(int id){
            string sql = "SELECT * FROM livro where id=@id";
            _bd.LimparParametros();
            _bd.AdicionarParametro("@id", id.ToString());
            _bd.AbrirConexao();
            Livro livro = null;
            DataTable dt = _bd.ExecutarSelect(sql);
            _bd.FecharConexao();
            EditoraDAL edal = new EditoraDAL();
            if(dt.Rows.Count>0)
            {
                livro = new Livro()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["id"]),
                    Nome = dt.Rows[0]["nome"].ToString(),
                    Editora = edal.BuscaEditoraPorId(Convert.ToInt32(dt.Rows[0][2]))
                };
            }
            return livro;
        }
    }
}
