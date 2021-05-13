using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.DAL
{
    public class AtendenteDAL
    {
        MySQLPersistence _bd = new MySQLPersistence();

        public int obterIdPorNome(string nome)
        {
            int id = 0;
            string sql = "SELECT idAtendente FROM atendente WHERE nome = @nome";
            _bd.AdicionarParametro("@nome", nome);
            _bd.AbrirConexao();
            DataTable atd = _bd.ExecutarSelect(sql);
            _bd.FecharConexao();
            if (atd.Rows.Count > 0)
            {
                id = Convert.ToInt32(atd.Rows[0]["idAtendente"]);
            }
            return id;
        }
    }
}
