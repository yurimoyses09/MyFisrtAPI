using Microsoft.AspNetCore.Mvc;
using WebApplication.Commands;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]/id")]
    public class FuncionariosController : ControllerBase
    {
        [HttpGet]
        public string GetFuncionarios(int id)
        {
            ObterFuncionario ob = new();

            return ob.Get(id);
        }
    }
}
