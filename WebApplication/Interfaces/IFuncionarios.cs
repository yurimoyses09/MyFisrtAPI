using System.Collections.Generic;

namespace WebApplication.Interfaces
{
    interface IFuncionarios
    {
        public string GetFuncionario(int id);
        public string PutFuncionario(string json);
        public bool DeleteFuncionario(int id);
        public List<Funcionarios> GetFuncionario();
    }
}
