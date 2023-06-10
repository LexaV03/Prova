using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVATOPICO
{
    internal class agendar
    {
        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        public agendar(String IDPaciente, String Dia, String Horario)
        {
            cmd.CommandText = "insert into Agendamentos (IDPaciente, Dia, Horario) values (@IDPaciente, @Dia, @Horario)";

            cmd.Parameters.AddWithValue("@IDPaciente", IDPaciente);
            cmd.Parameters.AddWithValue("@Dia", Dia);
            cmd.Parameters.AddWithValue("@Horario", Horario);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Registro Salvo com Sucesso";
            }
            catch (SqlException e) { this.mensagem = "Opa, algo deu errado ao se conectar ao banco de dados"; }

        }
    }
}
