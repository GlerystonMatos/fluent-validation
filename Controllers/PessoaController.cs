using FluentValidationNetCore.Model;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationNetCore.Controllers
{
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        [Route("api/pessoa/")]
        public string Get()
            => "FluentValidationNetCore";

        [HttpPost]
        [Route("api/pessoa/create")]
        public string Create([FromBody] Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return "A validação falhou.";
            }
            else
            {
                return "Pessoa criada com sucesso";
            }
        }
    }
}