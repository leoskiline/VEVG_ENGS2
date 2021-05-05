using Engenharia2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.DAL
{
    public class PosicaoDAL
    {
        MySQLPersistence _bd = new MySQLPersistence();
        public Posicao obter(string setor)
        {
            Posicao pos = null;
            string sql = "SELECT * FROM posicao WHERE setor = @setor";
            _bd.AdicionarParametro("@setor", setor);
            _bd.AbrirConexao();
            DataTable poss = _bd.ExecutarSelect(sql);
            _bd.FecharConexao();
            if (poss.Rows.Count > 0)
            {
                pos = new Posicao()
                {
                   Id = Convert.ToInt32(poss.Rows[0]["id"]),
                   Setor = poss.Rows[0]["setor"].ToString(),
                   Prateleira = poss.Rows[0]["prateleira"].ToString()

                };
            }
            return pos;
        }
    }
}
