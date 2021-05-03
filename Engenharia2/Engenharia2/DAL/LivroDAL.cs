using Engenharia2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
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
            string sql = "INSERT INTO livro (nome,exemplar,editora,reserva,autor) VALUES (@nome,@exemplar,@editora,@reserva,@autor)";
            _bd.AdicionarParametro("@nome", livro.Nome);
            _bd.AdicionarParametro("@exemplar", livro.Exemplar.Id.ToString());
            _bd.AdicionarParametro("@editora", livro.Editora.Id.ToString());
            AdministradorDAL admDal = new AdministradorDAL();
            _bd.AdicionarParametro("@administradorId", admDal.obterIdPorNome("Leonardo Custodio dos Santos").ToString());
            _bd.AbrirConexao();
            int rows =  _bd.ExecutarNonQuery(sql);
            _bd.FecharConexao();
            if(rows > 0)
            {
                msg = "Livro " + livro.Nome + " Gravada com Sucesso!";
            }
            return msg;
        }

        //Seleção simples de Livros
        public List<Livro> selecionar()
        {
            List<Livro> editora = new List<Livro>();
            string sql = "SELECT * FROM livro";          

            editora = (List<Livro>)_bd.ExecutarConsultaSimples(sql);

            return editora;
        }
    }
}
