using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVATOPICO
{
    internal class cadastrar
    {   
        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public cadastrar(String CPF, String Nome, String Telefone)
        {
            cmd.CommandText = "insert into Pacientes (cpf, nome, telefone) values (@CPF, @Nome, @Telefone)";

            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);

            try { cmd.Connection = conexao.conectar();
                  cmd.ExecuteNonQuery();
                  conexao.desconectar();
                this.mensagem = "Registro Salvo com Sucesso";
            } catch (SqlException e) { this.mensagem = "Opa, algo deu errado ao se conectar ao banco de dados"; }

        }
    }
}
