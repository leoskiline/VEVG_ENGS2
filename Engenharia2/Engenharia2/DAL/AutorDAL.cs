using Engenharia2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.DAL
{
    public class AutorDAL
    {
        MySQLPersistence _bd = new MySQLPersistence();

        public string gravar(Autor autor)
        {
            string msg = "Falha ao Gravar Autor";
            string sql = "INSERT INTO autor (nome,Administrador_idAdministrador) VALUES (@nome,@administradorId)";

            _bd.AdicionarParametro("@nome", autor.Nome);


            AdministradorDAL admDal = new AdministradorDAL();
            _bd.AdicionarParametro("@administradorId", admDal.obterIdPorNome("Leonardo Custodio dos Santos").ToString());

            _bd.AbrirConexao();
            int rows = _bd.ExecutarNonQuery(sql);
            _bd.FecharConexao();
            if (rows > 0)
            {
                msg = "Autor " + autor.Nome + " Gravado com Sucesso!";
            }
            return msg;
        }

        public Autor BuscaAutorPorId(int id)
        {
            string sql = "SELECT * FROM autor WHERE idAutor=@id";
            _bd.LimparParametros();
            _bd.AdicionarParametro("@id", id.ToString());
            _bd.AbrirConexao();
            DataTable dt = _bd.ExecutarSelect(sql);
            _bd.FecharConexao();
            Autor autor = null;
            AdministradorDAL adm = new AdministradorDAL();
            if(dt.Rows.Count > 0)
            {
                autor = new Autor()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["idAutor"]),
                    Nome = dt.Rows[0]["nome"].ToString(),
                    Administrador = adm.obter("Leonardo Custodio dos Santos")
                };
            }

            return autor;


        }

        public Autor BuscaAutorPorNome(string nome)
        {
            string sql = "SELECT * FROM autor WHERE nome=@nome";
            _bd.LimparParametros();
            _bd.AdicionarParametro("@nome", nome);
            _bd.AbrirConexao();
            DataTable dt = _bd.ExecutarSelect(sql);
            _bd.FecharConexao();
            Autor autor = null;
            AdministradorDAL adm = new AdministradorDAL();
            if (dt.Rows.Count > 0)
            {
                autor = new Autor()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["idAutor"]),
                    Nome = dt.Rows[0]["nome"].ToString(),
                    Administrador = adm.obter("Leonardo Custodio dos Santos")
                };
            }

            return autor;
        }

        public List<Autor> selecionarTodos()
        {
            List<Autor> autores = new List<Autor>();
            string sql = "SELECT * FROM autor";
            _bd.AbrirConexao();
            DataTable dt = _bd.ExecutarSelect(sql);
            _bd.FecharConexao();
            foreach (DataRow row in dt.Rows)
            {
                var autor = new Autor()
                {
                    Id = Convert.ToInt32(row["idAutor"]),
                    Nome = row["nome"].ToString(),
                    Administrador = new AdministradorDAL().obter("Leonardo Custodio dos Santos")

                };
                autores.Add(autor);
            }
            return autores;
        }
    }
}
