using Engenharia2.Models;
using System;
using System.Collections.Generic;
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
            string sql = "INSERT INTO autor (nome,administradorId) VALUES (@nome,@administradorId)";

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
    }
}
