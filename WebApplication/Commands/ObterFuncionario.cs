using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Commands
{
    public class ObterFuncionario : Funcionarios
    {
        protected SqlDataReader Dr;
        public string Get(int id)
        {
            ConnectionSql conn = new();

            var validaConexao = conn.Connection();
            var connection = new SqlConnection(conn.stringConnection());

            if (validaConexao == "OK")
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new("SELECT * FROM funcionarios WHERE idFuncionario = @id", connection);
                    command.Parameters.AddWithValue("@id", id);

                    Dr = command.ExecuteReader();

                    if (Dr.Read())
                    {
                        Funcionarios funcionario = new();
                        funcionario.IdFuncionario = Convert.ToInt32(Dr["idFuncionario"]);
                        funcionario.Nome = Convert.ToString(Dr["nome"]);
                        funcionario.Email = Convert.ToString(Dr["email"]);
                        funcionario.Sexo = Convert.ToString(Dr["sexo"]);
                        funcionario.Departamento = Convert.ToString(Dr["departamento"]);
                        funcionario.Admissao = Convert.ToString(Dr["admissao"]);
                        funcionario.Salario = Convert.ToDouble(Dr["salario"]);
                        funcionario.Cargo = Convert.ToString(Dr["cargo"]);

                        DataContractJsonSerializer ser = new(typeof(Funcionarios));

                        MemoryStream ms = new();

                        ser.WriteObject(ms, funcionario);

                        string json = Encoding.UTF8.GetString(ms.ToArray());

                        connection.Close();
                        string retorno;
                        return retorno = json;
                    }

                    return null;

                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open) connection.Close();
                }
            }

            return validaConexao;
        }
    }
}
