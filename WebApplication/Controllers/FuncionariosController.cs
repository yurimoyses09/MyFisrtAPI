using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebApplication.Commands;

namespace WebApplication.Controllers
{
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]/id")]
        public string Get(int id)
        {
            ObterFuncionario ob = new();

            return ob.GetFuncionario(id);
        }
        [HttpPut]
        [Route("api/[controller]/jsonfuncionario")]
        public string Put(string jsonfuncionario) 
        {
            ObterFuncionario ob = new();

            return ob.PutFuncionario(jsonfuncionario);
            
          
        }
    }
}
