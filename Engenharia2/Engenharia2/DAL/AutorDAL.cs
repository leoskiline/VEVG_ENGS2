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
            string sql = "INSERT INTO autor (Nome,Administrador_idAdministrador) VALUES (@nome,@administradorId)";

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
                    Nome = dt.Rows[0]["Nome"].ToString(),
                    Administrador = adm.obter("Leonardo Custodio dos Santos")
                };
            }

            return autor;


        }

        public Autor BuscaAutorPorNome(string nome)
        {
            string sql = "SELECT * FROM autor WHERE Nome=@nome";
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
                    Nome = dt.Rows[0]["Nome"].ToString(),
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
                    Nome = row["Nome"].ToString(),
                    Administrador = new AdministradorDAL().obter("Leonardo Custodio dos Santos")

                };
                autores.Add(autor);
            }
            return autores;
        }

        public List<Autor> obterAutoresPorListID(List<int> id)
        {
            List<Autor> autores = new List<Autor>();
            int cont = id.Count;
            DataTable[] dt = new DataTable[cont];
            _bd.AbrirConexao();
            string sql;
            Autor autor = null;
            for (int i = 0;i< cont;i++)
            {
                sql = "SELECT * FROM autor WHERE idAutor = @idAutor";
                _bd.LimparParametros();
                _bd.AdicionarParametro("@idAutor", id[i].ToString());
                dt[i] = _bd.ExecutarSelect(sql);
                if (dt[i].Rows.Count > 0)
                {
                    autor = new Autor()
                    {
                        Id = Convert.ToInt32(dt[i].Rows[0]["idAutor"]),
                        Nome = dt[i].Rows[0]["Nome"].ToString(),
                        Administrador = new AdministradorDAL().obter("Leonardo Custodio dos Santos")
                    };
                    autores.Add(autor);
                }
            }
            _bd.FecharConexao();
            return autores;
        }
    }
}
