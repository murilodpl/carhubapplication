using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarhubApp
{
    public class CadastroServicos
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public CadastroServicos(String desc_serv)
        {
            //Comando Sql ---SqlCommand
            cmd.CommandText = "insert into servicos_solicitados(desc_servico) values (@desc_serv)";

            //parametros
            cmd.Parameters.AddWithValue("@desc_serv", desc_serv);

            try
            {
                //conectar com banco -- Conexao
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar 
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso -- variavel
                this.mensagem = "Cadastrado com Sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Falha no cadastro! (Erro na conexão com o bd)";
            }

        }
    }
}
