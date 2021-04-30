using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.DAL
{
    public class AdministradorDAL
    {
        MySQLPersistence _bd = new MySQLPersistence();

        public int obterIdPorNome(string nome)
        {
            int id = 0;
            string sql = "SELECT id FROM administrador WHERE nome = @nome";
            _bd.AdicionarParametro("@nome", nome);
            _bd.AbrirConexao();
            DataTable admin = _bd.ExecutarSelect(sql);
            if(admin.Rows.Count > 0)
            {
                id = Convert.ToInt32(admin.Rows[0]["id"]);
            }
            return id;
        }
    }
}
