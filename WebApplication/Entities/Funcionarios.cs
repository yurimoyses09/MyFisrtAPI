using Newtonsoft.Json;
using System.Text.Json;

namespace WebApplication
{
    public class Funcionarios
    {
        [JsonProperty("idFuncionario")]
        public int IdFuncionario { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("sexo")]
        public string Sexo { get; set; }
        [JsonProperty("departamento")]
        public string Departamento { get; set; }
        [JsonProperty("admissao")]
        public string Admissao { get; set; }
        [JsonProperty("salario")]
        public double Salario { get; set; }
        [JsonProperty("cargo")]
        public string Cargo { get; set; }
        [JsonProperty("estado")]
        public string Estado { get; set; }


    }
}
