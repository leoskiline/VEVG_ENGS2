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
            string sql = "INSERT INTO livro (Nome,Editora_idEditora,Administrador_idAdministrador,qtd) VALUES (@nome,@editoraId,@administradorId,@qtd);Select @@IDENTITY;";
            string sql2 = "INSERT INTO livro_has_autor (Livro_idLivro,Autor_idAutor) VALUES (@livroId,@autorId)";
            _bd.LimparParametros();
            _bd.AdicionarParametro("@nome", livro.Nome);
            _bd.AdicionarParametro("@editoraId", new EditoraDAL().BuscaEditoraPorId(livro.Editora.Id).Id.ToString());
            _bd.AdicionarParametro("@autorId", new AutorDAL().BuscaAutorPorId(livro.Autor.Id).Id.ToString());
            _bd.AdicionarParametro("@administradorId", new AdministradorDAL().obterIdPorNome("Leonardo Custodio dos Santos").ToString());
            _bd.AdicionarParametro("@qtd", livro.Qtd.ToString());
            _bd.AbrirConexao();
            livro.Id = _bd.ExecutarNonQueryAndGetID(sql);
            _bd.AdicionarParametro("@livroId", livro.Id.ToString());
            int rows2 = _bd.ExecutarNonQuery(sql2);
            _bd.FecharConexao();
            if(livro.Id != 0 && rows2 > 0)
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
                    Id = Convert.ToInt32(row["idLivro"]),
                    Nome = row["nome"].ToString(),
                    Editora = edal.BuscaEditoraPorId(Convert.ToInt32(row["Editora_idEditora"])),

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
