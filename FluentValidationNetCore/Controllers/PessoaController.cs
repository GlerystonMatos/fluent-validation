using FluentValidationNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger)
            => _logger = logger;

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("FluentValidationNetCore");
            return "FluentValidationNetCore";
        }

        [HttpPost]
        public string Post([FromBody] Pessoa pessoa)
        {
            _logger.LogInformation("Pessoa.Nome: " + pessoa.Nome);

            if (!ModelState.IsValid)
                return "A validação falhou.";
            else
                return "Pessoa criada com sucesso";
        }
    }
}