using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebApplication.Interfaces;

namespace WebApplication.Commands
{
    public class ObterFuncionario : IFuncionarios
    {
        protected SqlDataReader Dr;

        public bool DeleteFuncionario(int id) // Deleta funcionario pelo Id
        {
            throw new NotImplementedException();
        }

        public string GetFuncionario(int id)
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
                    try
                    {
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
                            funcionario.Estado = Convert.ToString(Dr["estado"]);

                            string JsonFuncionario = System.Text.Json.JsonSerializer.Serialize(funcionario);

                            string retorno;
                            return retorno = JsonFuncionario;
                        }

                        return null;

                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
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
        } // Seleciona funcionario pelo Id

        public List<Funcionarios> GetFuncionario()
        {
            throw new NotImplementedException();
        }  // Tras todos os funcionarios da base de dados

        public string PutFuncionario(string json)
        {
            ConnectionSql conn = new();

            var validaConexao = conn.Connection();
            var connection = new SqlConnection(conn.stringConnection());

            if (validaConexao.Equals("OK"))
            {
                try
                {
                    dynamic funcionario = JsonConvert.DeserializeObject<dynamic>(json);
                    var id = funcionario["IdFuncionario"].ToString();
                    var nome = funcionario["Nome"].ToString();
                    var email = funcionario["Email"].ToString();
                    var sexo = funcionario["Sexo"].ToString();
                    var departamento = funcionario["Departamento"].ToString();
                    var admissao = funcionario["Admissao"].ToString();
                    var salario = funcionario["Salario"].ToString();
                    var cargo = funcionario["Cargo"].ToString();
                    var estado = funcionario["Estado"].ToString();

                    try
                    {
                        connection.Open();
                        SqlCommand command = new("INSERT INTO funcionarios VALUES(@id, @nome, @email, @sexo, @departamento, @admissao, @salario, @cargo, @estado)", connection);

                        command.Parameters.AddWithValue("@id", int.Parse(id));
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@sexo", sexo);
                        command.Parameters.AddWithValue("@departamento", departamento);
                        command.Parameters.AddWithValue("@admissao", admissao);
                        command.Parameters.AddWithValue("@salario", double.Parse(salario));
                        command.Parameters.AddWithValue("@cargo", cargo);
                        command.Parameters.AddWithValue("@estado", estado);

                        var insert = command.ExecuteNonQuery();
                        if (insert > 0)
                            return "OK";

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
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }

            return validaConexao;
        } // Insere funcionario com informacoes em formato Json
    }
}
