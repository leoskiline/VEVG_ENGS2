using Engenharia2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.DAL
{
    public class LeitorDAL
    {
        MySQLPersistence _bd = new MySQLPersistence();

        public string gravar(Leitor leitor)
        {
            string msg = "Falha ao Gravar Leitor";
            string sql = "INSERT INTO leitor (nome,cpf,endereco,dataNasc,atendenteId) VALUES (@nome,@cpf,@endereco,@dataNasc,@atendenteId)";
            _bd.AdicionarParametro("@nome", leitor.Nome);
            _bd.AdicionarParametro("@cpf", leitor.Cpf);
            _bd.AdicionarParametro("@endereco", leitor.Endereco);
            _bd.AdicionarParametro("@dataNasc", Convert.ToString(leitor.DataNasc));
            AtendenteDAL atDal = new AtendenteDAL();
            _bd.AdicionarParametro("@atendenteId", atDal.obterIdPorNome("Maria Luiza").ToString());
            _bd.AbrirConexao();
            int rows = _bd.ExecutarNonQuery(sql);
            _bd.FecharConexao();
            if (rows > 0)
            {
                msg = "Leitor " + leitor.Nome + " Gravado com Sucesso!";
            }
            return msg;
        }
    }
}
