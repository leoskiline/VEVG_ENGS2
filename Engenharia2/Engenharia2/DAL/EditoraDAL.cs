using Engenharia2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engenharia2.DAL
{
    public class EditoraDAL
    {
        MySQLPersistence _bd = new MySQLPersistence();

        public string gravar(Editora editora)
        {
            string msg = "Falha ao Gravar Editora";
            string sql = "INSERT INTO editora (nome,descricao,telefone,administradorId) VALUES (@nome,@descricao,@telefone,@administradorId)";
            _bd.AdicionarParametro("@nome", editora.Nome);
            _bd.AdicionarParametro("@descricao", editora.Descricao);
            _bd.AdicionarParametro("@telefone", editora.Telefone);
            AdministradorDAL admDal = new AdministradorDAL();
            _bd.AdicionarParametro("@administradorId", admDal.obterIdPorNome("Leonardo Custodio dos Santos").ToString());
            _bd.AbrirConexao();
            int rows =  _bd.ExecutarNonQuery(sql);
            _bd.FecharConexao();
            if(rows > 0)
            {
                msg = "Editora " + editora.Nome + " Gravada com Sucesso!";
            }
            return msg;
        }

        //Seleção simples de lista
        public List<Editora> selecionar()
        {
            List<Editora> editora = new List<Editora>();
            string sql = "SELECT * FROM editora";          

            editora = (List<Editora>)_bd.ExecutarConsultaSimples(sql);

            return editora;
        }
    }
}
