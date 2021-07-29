using Microsoft.AspNetCore.Mvc;
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
            CrudFuncionario ob = new();

            return ob.GetFuncionario(id);
        }

        [HttpPut]
        [Route("api/[controller]/jsonfuncionario")]
        public string Put(string jsonfuncionario) 
        {
            CrudFuncionario ob = new();

            return ob.PutFuncionario(jsonfuncionario);
            
          
        }

        [HttpDelete]
        [Route("api/[controller]/Deletefuncionario")]
        public string Delete(int id) 
        {
            CrudFuncionario ob = new();

            return ob.DeleteFuncionario(id);
        }
    }
}
